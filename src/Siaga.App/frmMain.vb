﻿Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraEditors
Imports Serilog

Public Class frmMain
    Public Property IsLogin As Boolean = False
    Public Property DbContext As New Data.ApplicationDbContext()

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
            mnStatusUser.Caption = "Username : (none)"
            IsLogin = False
            RibbonPage2.Visible = False
            ribbonControl.SelectedPage = RibbonPage1

            'Buka Menu Login
            ShowLoginForm()
        Else
            'Belum Login jadi buka Login
            ShowLoginForm()
        End If
    End Sub

    Private Sub ShowLoginForm()
        Using frm As New frmLogin() With {.MdiParent = Nothing}
            Try
                If (frm.ShowDialog(Me) = DialogResult.OK) Then
                    IsLogin = True
                    mnLogInOut.ImageOptions.LargeImage = My.Resources.LogOut
                    mnLogInOut.Caption = "Logout"

                    mnStatusUser.Caption = "Username : " & Program.UserLogin.nama
                    RibbonPage2.Visible = True
                    ribbonControl.SelectedPage = RibbonPage2
                End If
            Catch ex As Exception
                Log.Logger.Error(ex, "Info Kesalahan : " & ex.Message)
                XtraMessageBox.Show("Info Kesalahan : " & ex.Message)
            End Try
        End Using
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

        mnServer.Caption = "Server : " & DbContext.Database.Connection.DataSource
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

    Private Sub mnKategoriAsset_ItemClick(sender As Object, e As ItemClickEventArgs) Handles mnKategoriAsset.ItemClick
        Dim frm As frmDaftarKategoriAsset = Nothing
        For Each ctl In Me.MdiChildren
            If TypeOf ctl Is frmDaftarKategoriAsset Then
                frm = TryCast(ctl, frmDaftarKategoriAsset)
                Exit For
            End If
        Next
        If (frm Is Nothing) Then
            frm = New frmDaftarKategoriAsset() With {.MdiParent = Me}
        End If
        frm.Show()
        frm.Focus()
    End Sub

    Private Sub mnAssets_ItemClick(sender As Object, e As ItemClickEventArgs) Handles mnAssets.ItemClick
        Dim frm As frmDaftarAsset = Nothing
        For Each ctl In Me.MdiChildren
            If TypeOf ctl Is frmDaftarAsset Then
                frm = TryCast(ctl, frmDaftarAsset)
                Exit For
            End If
        Next
        If (frm Is Nothing) Then
            frm = New frmDaftarAsset() With {.MdiParent = Me}
        End If
        frm.Show()
        frm.Focus()
    End Sub

    Private Sub mnRuangan_ItemClick(sender As Object, e As ItemClickEventArgs) Handles mnRuangan.ItemClick
        Dim frm As frmDaftarRuangan = Nothing
        For Each ctl In Me.MdiChildren
            If TypeOf ctl Is frmDaftarRuangan Then
                frm = TryCast(ctl, frmDaftarRuangan)
                Exit For
            End If
        Next
        If (frm Is Nothing) Then
            frm = New frmDaftarRuangan() With {.MdiParent = Me}
        End If
        frm.Show()
        frm.Focus()
    End Sub

    Private Sub mnStatusUser_ItemClick(sender As Object, e As ItemClickEventArgs) Handles mnStatusUser.ItemClick
        mnStatusUser.Enabled = False
        Using frm As New frmUbahPassword()
            Try
                If (frm.ShowDialog(Me) = DialogResult.OK) Then
                    Application.Restart()
                End If
            Catch ex As Exception
                Log.Logger.Error(ex, "Info Kesalahan : " & ex.Message)
                XtraMessageBox.Show("Info Kesalahan : " & ex.Message)
            End Try
        End Using
        mnStatusUser.Enabled = True
    End Sub

    Private Sub mnPemindahan_ItemClick(sender As Object, e As ItemClickEventArgs) Handles mnPemakaian.ItemClick
        Dim frm As frmDaftarPemakaian = Nothing
        For Each ctl In Me.MdiChildren
            If TypeOf ctl Is frmDaftarPemakaian Then
                frm = TryCast(ctl, frmDaftarPemakaian)
                Exit For
            End If
        Next
        If (frm Is Nothing) Then
            frm = New frmDaftarPemakaian() With {.MdiParent = Me}
        End If
        frm.Show()
        frm.Focus()
    End Sub

    Private Sub mnPemutihan_ItemClick(sender As Object, e As ItemClickEventArgs) Handles mnPemutihan.ItemClick
        Dim frm As frmDaftarPemutihan = Nothing
        For Each ctl In Me.MdiChildren
            If TypeOf ctl Is frmDaftarPemutihan Then
                frm = TryCast(ctl, frmDaftarPemutihan)
                Exit For
            End If
        Next
        If (frm Is Nothing) Then
            frm = New frmDaftarPemutihan() With {.MdiParent = Me}
        End If
        frm.Show()
        frm.Focus()
    End Sub

    Private Sub mnLaporanRekapRuangan_ItemClick(sender As Object, e As ItemClickEventArgs) Handles mnLaporanRekapRuangan.ItemClick
        Dim frm As Report.frmRekapLaporanRuangan = Nothing
        For Each ctl In Me.MdiChildren
            If TypeOf ctl Is Report.frmRekapLaporanRuangan Then
                frm = TryCast(ctl, Report.frmRekapLaporanRuangan)
                Exit For
            End If
        Next
        If (frm Is Nothing) Then
            frm = New Report.frmRekapLaporanRuangan() With {.MdiParent = Me}
        End If
        frm.Show()
        frm.Focus()
    End Sub

    Private Sub mnLaporanRekapAsset_ItemClick(sender As Object, e As ItemClickEventArgs) Handles mnLaporanRekapAsset.ItemClick
        Dim frm As Report.frmRekapAsset = Nothing
        For Each ctl In Me.MdiChildren
            If TypeOf ctl Is Report.frmRekapAsset Then
                frm = TryCast(ctl, Report.frmRekapAsset)
                Exit For
            End If
        Next
        If (frm Is Nothing) Then
            frm = New Report.frmRekapAsset() With {.MdiParent = Me}
        End If
        frm.Show()
        frm.Focus()
    End Sub

    Private Sub mnLaporanRincianAsset_ItemClick(sender As Object, e As ItemClickEventArgs) Handles mnLaporanRincianAsset.ItemClick
        Dim frm As Report.frmRincianAsset = Nothing
        For Each ctl In Me.MdiChildren
            If TypeOf ctl Is Report.frmRincianAsset Then
                frm = TryCast(ctl, Report.frmRincianAsset)
                Exit For
            End If
        Next
        If (frm Is Nothing) Then
            frm = New Report.frmRincianAsset() With {.MdiParent = Me}
        End If
        frm.Show()
        frm.Focus()
    End Sub

    Private Sub mnLaporanRincianAssetRusak_ItemClick(sender As Object, e As ItemClickEventArgs) Handles mnLaporanRincianAssetRusak.ItemClick
        Dim frm As Report.frmRincianAssetRusak = Nothing
        For Each ctl In Me.MdiChildren
            If TypeOf ctl Is Report.frmRincianAssetRusak Then
                frm = TryCast(ctl, Report.frmRincianAssetRusak)
                Exit For
            End If
        Next
        If (frm Is Nothing) Then
            frm = New Report.frmRincianAssetRusak() With {.MdiParent = Me}
        End If
        frm.Show()
        frm.Focus()
    End Sub

    Private Sub mnLaporanPemutihanAsset_ItemClick(sender As Object, e As ItemClickEventArgs) Handles mnLaporanPemutihanAsset.ItemClick
        Dim frm As Report.frmRincianPemutihan = Nothing
        For Each ctl In Me.MdiChildren
            If TypeOf ctl Is Report.frmRincianPemutihan Then
                frm = TryCast(ctl, Report.frmRincianPemutihan)
                Exit For
            End If
        Next
        If (frm Is Nothing) Then
            frm = New Report.frmRincianPemutihan() With {.MdiParent = Me}
        End If
        frm.Show()
        frm.Focus()
    End Sub

    Private Sub mnLaporanRincianKodeAsset_ItemClick(sender As Object, e As ItemClickEventArgs) Handles mnLaporanRincianKodeAsset.ItemClick
        Dim frm As Report.frmRincianKodeAsset = Nothing
        For Each ctl In Me.MdiChildren
            If TypeOf ctl Is Report.frmRincianKodeAsset Then
                frm = TryCast(ctl, Report.frmRincianKodeAsset)
                Exit For
            End If
        Next
        If (frm Is Nothing) Then
            frm = New Report.frmRincianKodeAsset() With {.MdiParent = Me}
        End If
        frm.Show()
        frm.Focus()
    End Sub
End Class
