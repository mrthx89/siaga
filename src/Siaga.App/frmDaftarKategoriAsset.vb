Imports DevExpress.XtraEditors
Imports DevExpress.Utils
Imports Serilog

Public Class frmDaftarKategoriAsset
    Public Property Rep As Services.IKategoriAsset = New Repository.KategoriAsset()

    Private Sub mnBaru_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnBaru.ItemClick

    End Sub

    Private Sub mnUbah_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnUbah.ItemClick

    End Sub

    Private Sub mnHapus_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnHapus.ItemClick

    End Sub

    Private Sub mnSegarkan_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnSegarkan.ItemClick
        Dim data = Rep.GetAll()
        If (data.Item1) Then
            KategoriAssetBindingSource.DataSource = data.Item3
        Else
            XtraMessageBox.Show(data.Item2, Application.ProductName)
        End If
    End Sub

    Private Sub mnExportExcel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnExportExcel.ItemClick
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
    End Sub

    Private Sub frmDaftarKategoriAsset_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mnSegarkan.PerformClick()
    End Sub

    Private Sub GridView1_DataSourceChange(sender As Object, e As EventArgs) Handles GridView1.DataSourceChanged
        If (IO.File.Exists(IO.Path.Combine(Program.FolderApp, "System", "Layouts", $"{Me.Name}_{GridView1.Name}.xml"))) Then
            GridView1.RestoreLayoutFromXml(IO.Path.Combine(Program.FolderApp, "System", "Layouts", $"{Me.Name}_{GridView1.Name}.xml"))
        End If
    End Sub

    Private Sub mnSimpanLayouts_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnSimpanLayouts.ItemClick
        GridView1.SaveLayoutToXml(IO.Path.Combine(Program.FolderApp, "System", "Layouts", $"{Me.Name}_{GridView1.Name}.xml"))
        XtraMessageBox.Show("Berhasil", Application.ProductName)
    End Sub
End Class