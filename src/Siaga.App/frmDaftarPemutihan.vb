Imports DevExpress.XtraEditors
Imports DevExpress.Utils
Imports Serilog
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmDaftarPemutihan
    Public Property Rep As Services.IPemutihan = New Repository.Pemutihan()
    Public Property RepKategori As Services.IKategoriAsset = New Repository.KategoriAsset()
    Public Property RepAsset As Services.IAsset = New Repository.Asset()

    Private Sub RefreshLookUp()
        Dim dtAsset = RepAsset.GetAll()
        Dim dataAsset = From x In If(dtAsset.Item1, dtAsset.Item3, New List(Of Model.AssetDTo)())
                        Select New With {.ID = x.id, .Kode = x.kd_asset, .Nama = x.nama_asset, .Kategori = x.nama_kategori}
        txtAsset.Properties.DataSource = dataAsset.ToList()
        txtAsset.Properties.ValueMember = "ID"
        txtAsset.Properties.DisplayMember = "Nama"

        Dim dtKategori = RepKategori.GetAll()
        Dim dataKategori = From x In If(dtKategori.Item1, dtKategori.Item3, New List(Of Data.Entity.KategoriAsset)())
                           Select New With {.ID = x.id, .Kode = x.kd_kategori, .Nama = x.nama_kategori}
        txtKategori.Properties.DataSource = dataKategori.ToList()
        txtKategori.Properties.ValueMember = "ID"
        txtKategori.Properties.DisplayMember = "Nama"

        tglDari.DateTime = DateTime.Now.Date.AddDays((-1 * DateTime.Now.Day) + 1)
        tglSampai.DateTime = DateTime.Now.Date
    End Sub

    Private Sub mnBaru_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnBaru.ItemClick
        mnBaru.Enabled = False
        Using frm As New frmEntriPemutihan([Enum].PTipe.Create, New Data.Entity.Pemutihan())
            Try
                If (frm.ShowDialog(Me) = DialogResult.OK) Then
                    mnSegarkan.PerformClick()

                    With GridView1
                        .ClearSelection()
                        .FocusedRowHandle = .LocateByDisplayText(0, colid, frm.Model.id.ToString())
                        .SelectRow(.FocusedRowHandle)
                        .MakeRowVisible(.FocusedRowHandle)
                    End With
                End If
            Catch ex As Exception
                Log.Error(ex, "Error : " & ex.Message)
                XtraMessageBox.Show("Error : " & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
        mnBaru.Enabled = True
    End Sub

    Private Sub mnUbah_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnUbah.ItemClick
        mnUbah.Enabled = False
        If (GridView1.FocusedRowHandle >= 0) Then
            Dim viewModel = TryCast(PemutihanBindingSource.Current, Model.PemutihanDTo)
            Using frm As New frmEntriPemutihan([Enum].PTipe.Edit, New Data.Entity.Pemutihan With {.id = viewModel.id, .id_detail_asset = viewModel.id_detail_asset, .alasan = viewModel.alasan, .tgl_pemutihan = viewModel.tgl_pemutihan, .keterangan = viewModel.tgl_pemutihan})
                Try
                    If (frm.ShowDialog(Me) = DialogResult.OK) Then
                        mnSegarkan.PerformClick()

                        With GridView1
                            .ClearSelection()
                            .FocusedRowHandle = .LocateByDisplayText(0, colid, frm.Model.id.ToString())
                            .SelectRow(.FocusedRowHandle)
                            .MakeRowVisible(.FocusedRowHandle)
                        End With
                    End If
                Catch ex As Exception
                    Log.Error(ex, "Error : " & ex.Message)
                    XtraMessageBox.Show("Error : " & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End If
        mnUbah.Enabled = True
    End Sub

    Private Sub mnHapus_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnHapus.ItemClick
        mnHapus.Enabled = False
        If (GridView1.FocusedRowHandle >= 0) Then
            Dim Pemutihans As Model.PemutihanDTo = TryCast(PemutihanBindingSource.Current, Model.PemutihanDTo)
            Dim dialog = XtraMessageBox.Show($"Yakin ingin menghapus data Pemutihan Asset {Pemutihans.detail_asset} ini?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If (dialog = DialogResult.Yes) Then
                Dim result = Rep.Delete(Pemutihans.id)
                If (result.Item1) Then
                    mnSegarkan.PerformClick()
                Else
                    XtraMessageBox.Show(result.Item2, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        End If
        mnHapus.Enabled = True
    End Sub

    Private Sub mnSegarkan_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnSegarkan.ItemClick
        Dim IDAsset, IDKategoriAsset As Guid
        Guid.TryParse(If(txtAsset.EditValue IsNot Nothing, txtAsset.EditValue.ToString(), ""), IDAsset)
        Guid.TryParse(If(txtKategori.EditValue IsNot Nothing, txtKategori.EditValue.ToString(), ""), IDKategoriAsset)
        Dim data = Rep.GetAll(New Model.FilterListPemutihan With {
            .TglDari = tglDari.DateTime,
            .TglSampai = tglSampai.DateTime,
            .IDAsset = IDAsset,
            .IDKategoriAsset = IDKategoriAsset})
        If (data.Item1) Then
            PemutihanBindingSource.DataSource = data.Item3
        Else
            XtraMessageBox.Show(data.Item2, Application.ProductName)
        End If
    End Sub

    Private Sub mnExportExcel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnExportExcel.ItemClick
        mnExportExcel.Enabled = False
        Using dlg As New SaveFileDialog()
            Try
                dlg.Title = "Export data ke Excel"
                dlg.Filter = "Excel 2003 Files|*.xls|Excel 2007 Files|*.xlsx"
                If (dlg.ShowDialog(Me) = DialogResult.OK) Then
                    Dim FileInfo As New IO.FileInfo(dlg.FileName)
                    If (FileInfo.Extension = "xls" OrElse FileInfo.Extension = ".xls") Then
                        GridView1.ExportToXls(dlg.FileName)
                    Else
                        GridView1.ExportToXlsx(dlg.FileName)
                    End If
                End If
            Catch ex As Exception
                Log.Error(ex, "Error : " & ex.Message)
                XtraMessageBox.Show("Error : " & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                dlg.Dispose()
            End Try
        End Using
        mnExportExcel.Enabled = True
    End Sub

    Private Sub frmDaftarPemutihan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshLookUp()
        mnSegarkan.PerformClick()
    End Sub

    Private Sub GridView1_DataSourceChange(sender As Object, e As EventArgs) Handles GridView1.DataSourceChanged, gvAsset.DataSourceChanged, gvKategori.DataSourceChanged
        If (IO.File.Exists(IO.Path.Combine(Program.FolderApp, "System", "Layouts", $"{Me.Name}_{TryCast(sender, GridView).Name}.xml"))) Then
            TryCast(sender, GridView).RestoreLayoutFromXml(IO.Path.Combine(Program.FolderApp, "System", "Layouts", $"{Me.Name}_{TryCast(sender, GridView).Name}.xml"))
        End If
        With TryCast(sender, GridView)
            .ShowFindPanel()
            .OptionsView.EnableAppearanceOddRow = True
        End With
    End Sub

    Private Sub mnSimpanLayouts_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnSimpanLayouts.ItemClick
        mnSimpanLayouts.Enabled = False
        GridView1.SaveLayoutToXml(IO.Path.Combine(Program.FolderApp, "System", "Layouts", $"{Me.Name}_{GridView1.Name}.xml"))
        gvAsset.SaveLayoutToXml(IO.Path.Combine(Program.FolderApp, "System", "Layouts", $"{Me.Name}_{gvAsset.Name}.xml"))
        gvKategori.SaveLayoutToXml(IO.Path.Combine(Program.FolderApp, "System", "Layouts", $"{Me.Name}_{gvKategori.Name}.xml"))
        XtraMessageBox.Show("Berhasil disimpan.", Application.ProductName)
        mnSimpanLayouts.Enabled = True
    End Sub
End Class