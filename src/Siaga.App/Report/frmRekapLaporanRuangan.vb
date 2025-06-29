Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports MySql.Data.MySqlClient

Namespace Report
    Public Class frmRekapLaporanRuangan
        Public Property RepRuangan As Services.IRuangan = New Repository.Ruangan()
        Public ReadOnly DbContext As New Data.ApplicationDbContext()

        Private Sub mnDesignReport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnDesignReport.ItemClick
            ViewTheReport([Enum].ActionPrint.Design)
        End Sub

        Private Sub ViewTheReport(Action As [Enum].ActionPrint)
            Dim ds As New DataSet
            Using db As New MySqlConnection(DbContext.Database.Connection.ConnectionString)
                Using com As New MySqlCommand()
                    Using oDA As New MySqlDataAdapter
                        Try
                            db.Open()
                            com.Connection = db
                            com.CommandTimeout = db.ConnectionTimeout
                            oDA.SelectCommand = com

                            'Create Procedurenya
                            ' --- Cek dan Buat Stored Procedure jika belum ada ---
                            Dim sqlCheckSP As String = "SELECT COUNT(*) FROM information_schema.routines 
                                                    WHERE routine_schema = DATABASE() 
                                                      AND routine_name = 'spRekapLaporanRuangan' 
                                                      AND routine_type = 'PROCEDURE';"
                            com.CommandType = CommandType.Text
                            com.CommandText = sqlCheckSP
                            Dim count As Integer = Convert.ToInt32(com.ExecuteScalar())
                            If count = 0 Then
                                Dim sqlCreateSP As String = "CREATE PROCEDURE spRekapLaporanRuangan (
                                                            IN p_tanggal DATETIME,
                                                            IN p_idruangan CHAR(36)
                                                        )
                                                        BEGIN
                                                        SELECT asset.kd_asset, asset.nama_asset, ruangan.kd_ruangan, ruangan.nama_ruangan, TLap.jumlah, asset.keterangan
                                                            FROM (
                                                            SELECT 
                                                                da.id_asset,
                                                                h.id_ruangan,
                                                                COUNT(*) AS jumlah
                                                            FROM (
                                                                -- Ambil history terakhir per detail_asset berdasarkan noid, sampai tanggal tertentu
                                                                SELECT h1.*
                                                                FROM historydetailasset h1
                                                                INNER JOIN (
                                                                    SELECT A.id_detail_asset, MAX(A.tgl_transaksi) AS max_tgl
                                                                    FROM historydetailasset A
                                                                    WHERE DATE(A.tgl_transaksi) <= p_tanggal
                                                                    GROUP BY A.id_detail_asset
                                                                ) h2 ON h1.id_detail_asset = h2.id_detail_asset AND h1.tgl_transaksi = h2.max_tgl
                                                            ) AS h
                                                            INNER JOIN detailasset da ON da.id = h.id_detail_asset
                                                            WHERE (h.id_ruangan = p_idruangan OR p_idruangan IS NULL)
                                                            GROUP BY da.id_asset, h.id_ruangan) AS TLap
                                                            INNER JOIN asset ON TLap.id_asset=asset.id
                                                            INNER JOIN ruangan ON TLap.id_ruangan=ruangan.id
                                                            WHERE ruangan.id <> '69ffffcc-a79a-4e7e-b72c-c291729df0be';
                                                        END"
                                com.CommandText = sqlCreateSP
                                com.Parameters.Clear()
                                com.ExecuteNonQuery()
                            End If

                            'Panggil Procedurenya
                            com.CommandText = "spRekapLaporanRuangan"
                            com.CommandType = CommandType.StoredProcedure
                            com.Parameters.Clear()
                            com.Parameters.AddWithValue("p_tanggal", txtTanggalSampai.DateTime)
                            Dim IDRuangan As Guid
                            If Guid.TryParse(If(txtRuangan.EditValue?.ToString(), ""), IDRuangan) AndAlso IDRuangan <> Guid.Empty Then
                                com.Parameters.AddWithValue("p_idruangan", IDRuangan.ToString())
                            Else
                                ' Jika tidak dipilih, kirim NULL
                                com.Parameters.AddWithValue("p_idruangan", DBNull.Value)
                            End If
                            oDA.Fill(ds, "RekapLaporanRuangan")

                            Dim CalculateFields As New Dictionary(Of String, Object)
                            CalculateFields.Add("calTanggal", txtTanggalSampai.DateTime)
                            CalculateFields.Add("calRuangan", If(IDRuangan <> Guid.Empty, txtRuangan.Text, "Semua"))
                            Dim report = Utils.Report.ViewReport("RekapLaporanRuangan.repx", ds, New Dictionary(Of String, Object), CalculateFields, "", Action)
                            If (report IsNot Nothing) Then
                                DocumentViewer1.DocumentSource = report
                                'report.CreateDocument()
                            End If
                        Catch ex As Exception
                            XtraMessageBox.Show("Error : " & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                    End Using
                End Using
            End Using
        End Sub

        Private Sub cmdPreview_Click(sender As Object, e As EventArgs) Handles cmdPreview.Click
            ViewTheReport([Enum].ActionPrint.View)
        End Sub

        Private Sub frmRekapLaporanRuangan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Dim dtRuangan = RepRuangan.GetAll(False)
            Dim dataRuangan = From x In If(dtRuangan.Item1, dtRuangan.Item3, New List(Of Data.Entity.Ruangan)())
                              Select New With {.ID = x.id, .Kode = x.kd_ruangan, .Nama = x.nama_ruangan}
            txtRuangan.Properties.DataSource = dataRuangan.ToList()
            txtRuangan.Properties.ValueMember = "ID"
            txtRuangan.Properties.DisplayMember = "Nama"

            txtTanggalSampai.DateTime = DateTime.Now.AddDays((-1 * DateTime.Now.Day) + 1).AddMonths(1).AddDays(-1)
        End Sub

        Private Sub GridView1_DataSourceChange(sender As Object, e As EventArgs) Handles gvRuangan.DataSourceChanged
            If (IO.File.Exists(IO.Path.Combine(Program.FolderApp, "System", "Layouts", $"{Me.Name}_{TryCast(sender, GridView).Name}.xml"))) Then
                TryCast(sender, GridView).RestoreLayoutFromXml(IO.Path.Combine(Program.FolderApp, "System", "Layouts", $"{Me.Name}_{TryCast(sender, GridView).Name}.xml"))
            End If
            With TryCast(sender, GridView)
                .ShowFindPanel()
                .OptionsView.EnableAppearanceOddRow = True
            End With
        End Sub

        Private Sub mnSaveLayouts_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnSaveLayouts.ItemClick
            mnSaveLayouts.Enabled = False
            gvRuangan.SaveLayoutToXml(IO.Path.Combine(Program.FolderApp, "System", "Layouts", $"{Me.Name}_{gvRuangan.Name}.xml"))
            XtraMessageBox.Show("Berhasil disimpan.", Application.ProductName)
            mnSaveLayouts.Enabled = True
        End Sub
    End Class
End Namespace