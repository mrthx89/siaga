Imports DevExpress.XtraEditors
Imports DevExpress.Utils
Imports Serilog
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmDaftarAsset
    Public Property Rep As Services.IAsset = New Repository.Asset()

    Private Sub mnBaru_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnBaru.ItemClick
        mnBaru.Enabled = False
        Using frm As New frmEntriAsset([Enum].PTipe.Create, New Model.AssetDTo())
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
            Using frm As New frmEntriAsset([Enum].PTipe.Edit, TryCast(AssetBindingSource.Current, Model.AssetDTo))
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
            Dim Assets As Model.AssetDTo = TryCast(AssetBindingSource.Current, Model.AssetDTo)
            Dim dialog = XtraMessageBox.Show($"Yakin ingin menghapus data {Assets.nama_asset} ini?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If (dialog = DialogResult.Yes) Then
                Dim result = Rep.Delete(Assets)
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
        Dim data = Rep.GetAll()
        If (data.Item1) Then
            AssetBindingSource.DataSource = data.Item3
            GridControl1.RefreshDataSource()
            GridControl2.RefreshDataSource()
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

    Private Sub frmDaftarAsset_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mnSegarkan.PerformClick()
    End Sub

    Private Sub GridView1_DataSourceChange(sender As Object, e As EventArgs) Handles GridView1.DataSourceChanged, GridView2.DataSourceChanged
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
        GridView2.SaveLayoutToXml(IO.Path.Combine(Program.FolderApp, "System", "Layouts", $"{Me.Name}_{GridView2.Name}.xml"))
        XtraMessageBox.Show("Berhasil disimpan.", Application.ProductName)
        mnSimpanLayouts.Enabled = True
    End Sub
End Class