Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports MySql.Data.MySqlClient

Namespace Report
    Public Class frmRekapAsset
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
                                                      AND routine_name = 'spRekapAsset' 
                                                      AND routine_type = 'PROCEDURE';"
                            com.CommandType = CommandType.Text
                            com.CommandText = sqlCheckSP
                            Dim count As Integer = Convert.ToInt32(com.ExecuteScalar())
                            If count = 0 Then
                                Dim sqlCreateSP As String = "CREATE PROCEDURE spRekapAsset ( p_tanggal DATETIME ) 
                                                        BEGIN
                                                          SELECT
                                                            asset.id,
                                                            asset.kd_asset,
                                                            asset.nama_asset,
                                                            SUM( TLap.jumlah ) jumlah,
                                                            SUM( CASE WHEN lcase( TLap.kondisi ) = lcase( 'Baik' ) THEN TLap.jumlah ELSE 0 END ) baik,
                                                            SUM( CASE WHEN lcase( TLap.kondisi ) = lcase( 'Baik' ) THEN 0 ELSE TLap.jumlah END ) rusak,
                                                            asset.keterangan,
                                                            kategoriasset.kd_kategori,
                                                            kategoriasset.nama_kategori 
                                                          FROM
                                                            (
                                                              SELECT
                                                                h1.id_asset,
                                                                SUM( 1 - CASE WHEN p.id IS NOT NULL THEN 1 ELSE 0 END ) AS jumlah,
                                                                h1.kondisi 
                                                              FROM
                                                                detailasset h1
                                                                LEFT JOIN pemutihan p ON p.id_detail_asset = h1.id 
                                                                AND p.tgl_pemutihan <= p_tanggal 
                                                              GROUP BY
                                                                h1.id_asset,
                                                                h1.kondisi 
                                                            ) AS TLap
                                                            INNER JOIN asset ON TLap.id_asset = asset.id
                                                            INNER JOIN kategoriasset ON asset.id_kategori = kategoriasset.id 
                                                          GROUP BY
                                                            asset.id,
                                                            asset.kd_asset,
                                                            asset.nama_asset,
                                                            asset.keterangan,
                                                            kategoriasset.kd_kategori,
                                                            kategoriasset.nama_kategori;
                                                        END"
                                com.CommandText = sqlCreateSP
                                com.Parameters.Clear()
                                com.ExecuteNonQuery()
                            End If

                            'Panggil Procedurenya
                            com.CommandText = "spRekapAsset"
                            com.CommandType = CommandType.StoredProcedure
                            com.Parameters.Clear()
                            com.Parameters.AddWithValue("p_tanggal", txtTanggalSampai.DateTime)
                            oDA.Fill(ds, "RekapAsset")

                            Dim CalculateFields As New Dictionary(Of String, Object)
                            CalculateFields.Add("calTanggal", txtTanggalSampai.DateTime)
                            Dim report = Utils.Report.ViewReport("RekapAsset.repx", ds, New Dictionary(Of String, Object), CalculateFields, "", Action)
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

        Private Sub frmRekapAsset_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            txtTanggalSampai.DateTime = DateTime.Now.AddDays((-1 * DateTime.Now.Day) + 1).AddMonths(1).AddDays(-1)
        End Sub

        Private Sub mnSaveLayouts_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnSaveLayouts.ItemClick
            mnSaveLayouts.Enabled = False
            XtraMessageBox.Show("Berhasil disimpan.", Application.ProductName)
            mnSaveLayouts.Enabled = True
        End Sub
    End Class
End Namespace