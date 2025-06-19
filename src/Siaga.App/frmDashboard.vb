Imports System.IO

Public Class frmDashboard
    Public Property FileGambar As String = IO.Path.Combine(Program.FolderApp, "System", "BG.png")
    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (File.Exists(FileGambar)) Then
            PictureEdit1.Image = Image.FromFile(FileGambar)
        Else
            PictureEdit1.Image = Nothing
        End If
        PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
    End Sub
End Class