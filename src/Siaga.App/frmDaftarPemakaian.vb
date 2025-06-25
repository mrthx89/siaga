Imports DevExpress.XtraEditors
Imports DevExpress.Utils
Imports Serilog
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmDaftarPemakaian
    Public Property Rep As Services.IPemakaian = New Repository.Pemakaian()
    Public Property RepKategori As Services.IKategoriAsset = New Repository.KategoriAsset()
    Public Property RepAsset As Services.IAsset = New Repository.Asset()
    Public Property RepRuangan As Services.IRuangan = New Repository.Ruangan()

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

        Dim dtRuangan = RepRuangan.GetAll(False)
        Dim dataRuangan = From x In If(dtRuangan.Item1, dtRuangan.Item3, New List(Of Data.Entity.Ruangan)())
                          Select New With {.ID = x.id, .Kode = x.kd_ruangan, .Nama = x.nama_ruangan}
        txtRuangan.Properties.DataSource = dataRuangan.ToList()
        txtRuangan.Properties.ValueMember = "ID"
        txtRuangan.Properties.DisplayMember = "Nama"

        tglDari.DateTime = DateTime.Now.Date.AddDays((-1 * DateTime.Now.Day) + 1)
        tglSampai.DateTime = DateTime.Now.Date
    End Sub

    Private Sub mnBaru_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnBaru.ItemClick
        mnBaru.Enabled = False
        Using frm As New frmEntriPemakaian([Enum].PTipe.Create, New Data.Entity.Pemakaian())
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
            Dim viewModel = TryCast(PemakaianBindingSource.Current, Model.PemakaianDTo)
            Using frm As New frmEntriPemakaian([Enum].PTipe.Edit, New Data.Entity.Pemakaian With {.id = viewModel.id, .id_detail_asset = viewModel.id_detail_asset, .id_ruangan = viewModel.id_ruangan, .tgl_mulai_pakai = viewModel.tgl_mulai_pakai})
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
            Dim Pemakaians As Model.PemakaianDTo = TryCast(PemakaianBindingSource.Current, Model.PemakaianDTo)
            Dim dialog = XtraMessageBox.Show($"Yakin ingin menghapus data Pemakaian Asset {Pemakaians.detail_asset} ini?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If (dialog = DialogResult.Yes) Then
                Dim result = Rep.Delete(Pemakaians.id)
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
        Dim IDAsset, IDKategoriAsset, IDRuangan As Guid
        Guid.TryParse(If(txtAsset.EditValue IsNot Nothing, txtAsset.EditValue.ToString(), ""), IDAsset)
        Guid.TryParse(If(txtKategori.EditValue IsNot Nothing, txtKategori.EditValue.ToString(), ""), IDKategoriAsset)
        Guid.TryParse(If(txtRuangan.EditValue IsNot Nothing, txtRuangan.EditValue.ToString(), ""), IDRuangan)
        Dim data = Rep.GetAll(New Model.FilterListPemakaian With {
            .TglDari = tglDari.DateTime,
            .TglSampai = tglSampai.DateTime,
            .IDAsset = IDAsset,
            .IDKategoriAsset = IDKategoriAsset,
            .IDRuangan = IDRuangan})
        If (data.Item1) Then
            PemakaianBindingSource.DataSource = data.Item3
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

    Private Sub frmDaftarPemakaian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshLookUp()
        mnSegarkan.PerformClick()
    End Sub

    Private Sub GridView1_DataSourceChange(sender As Object, e As EventArgs) Handles GridView1.DataSourceChanged, gvAsset.DataSourceChanged, gvKategori.DataSourceChanged, gvRuangan.DataSourceChanged
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
        gvRuangan.SaveLayoutToXml(IO.Path.Combine(Program.FolderApp, "System", "Layouts", $"{Me.Name}_{gvRuangan.Name}.xml"))
        XtraMessageBox.Show("Berhasil disimpan.", Application.ProductName)
        mnSimpanLayouts.Enabled = True
    End Sub
End Class