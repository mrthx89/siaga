Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon

Public Class frmMain
    Public Property IsLogin As Boolean = False

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub LoginClick()
        If (IsLogin) Then
            'Sudah Login jadi diLogOut
            For Each ctl In Me.MdiChildren
                If Not (TypeOf ctl Is frmDashboard) Then
                    ctl.Dispose()
                End If
                Application.DoEvents()
            Next
            mnLogInOut.ImageOptions.LargeImage = My.Resources.LogIn
            mnLogInOut.Caption = "Login"
            'Buka Menu Login
        Else
            'Belum Login jadi buka Login
        End If
    End Sub

    Private Sub mnLogInOut_ItemClick(sender As Object, e As ItemClickEventArgs) Handles mnLogInOut.ItemClick
        LoginClick()
    End Sub

    Private Sub OpenDashboard()
        Dim frm As New frmDashboard
        frm.MdiParent = Me
        frm.Show()
        frm.Focus()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenDashboard()

        IsLogin = False
        mnLogInOut.ImageOptions.LargeImage = My.Resources.LogIn
        mnLogInOut.Caption = "Login"
        mnLogInOut.PerformClick()
    End Sub

    Private Sub mnSetting_ItemClick(sender As Object, e As ItemClickEventArgs) Handles mnSetting.ItemClick

    End Sub

    Private Sub skinRibbonGalleryBarItem_GalleryItemClick(sender As Object, e As GalleryItemClickEventArgs) Handles skinRibbonGalleryBarItem.GalleryItemClick
        Program.AppConfig.Theme = e.Item.Caption
        Program.SaveConfig(Program.AppConfig)
    End Sub
End Class
