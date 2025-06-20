<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.tabbedView = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
        Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.skinRibbonGalleryBarItem = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.employeesBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.customersBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.mnLogInOut = New DevExpress.XtraBars.BarButtonItem()
        Me.mnSetting = New DevExpress.XtraBars.BarButtonItem()
        Me.mnServer = New DevExpress.XtraBars.BarStaticItem()
        Me.mnStatusUser = New DevExpress.XtraBars.BarStaticItem()
        Me.mnKategoriAsset = New DevExpress.XtraBars.BarButtonItem()
        Me.mnAssets = New DevExpress.XtraBars.BarButtonItem()
        Me.mnRuangan = New DevExpress.XtraBars.BarButtonItem()
        Me.mnPemindahan = New DevExpress.XtraBars.BarButtonItem()
        Me.mnPemutihan = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ribbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ribbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.XtraTabbedMdiManager1 = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        CType(Me.tabbedView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabbedView
        '
        Me.tabbedView.RootContainer.Element = Nothing
        '
        'ribbonControl
        '
        Me.ribbonControl.ApplicationCaption = "Siaga.App"
        Me.ribbonControl.ApplicationIcon = Global.Siaga.App.My.Resources.Resources.Logo
        Me.ribbonControl.ExpandCollapseItem.Id = 0
        Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl.ExpandCollapseItem, Me.skinRibbonGalleryBarItem, Me.employeesBarButtonItem, Me.customersBarButtonItem, Me.mnLogInOut, Me.mnSetting, Me.mnServer, Me.mnStatusUser, Me.mnKategoriAsset, Me.mnAssets, Me.mnRuangan, Me.mnPemindahan, Me.mnPemutihan})
        Me.ribbonControl.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl.MaxItemId = 55
        Me.ribbonControl.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always
        Me.ribbonControl.Name = "ribbonControl"
        Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage2, Me.RibbonPage1})
        Me.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
        Me.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl.Size = New System.Drawing.Size(1173, 143)
        Me.ribbonControl.StatusBar = Me.ribbonStatusBar
        Me.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'skinRibbonGalleryBarItem
        '
        Me.skinRibbonGalleryBarItem.Id = 14
        Me.skinRibbonGalleryBarItem.Name = "skinRibbonGalleryBarItem"
        '
        'employeesBarButtonItem
        '
        Me.employeesBarButtonItem.Caption = "Employees"
        Me.employeesBarButtonItem.Id = 44
        Me.employeesBarButtonItem.Name = "employeesBarButtonItem"
        '
        'customersBarButtonItem
        '
        Me.customersBarButtonItem.Caption = "Customers"
        Me.customersBarButtonItem.Id = 45
        Me.customersBarButtonItem.Name = "customersBarButtonItem"
        '
        'mnLogInOut
        '
        Me.mnLogInOut.Caption = "Login"
        Me.mnLogInOut.Id = 46
        Me.mnLogInOut.ImageOptions.LargeImage = Global.Siaga.App.My.Resources.Resources.LogIn
        Me.mnLogInOut.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L))
        Me.mnLogInOut.Name = "mnLogInOut"
        '
        'mnSetting
        '
        Me.mnSetting.Caption = "Setting"
        Me.mnSetting.Id = 47
        Me.mnSetting.ImageOptions.LargeImage = Global.Siaga.App.My.Resources.Resources.Setting
        Me.mnSetting.Name = "mnSetting"
        Me.mnSetting.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'mnServer
        '
        Me.mnServer.Caption = "Server : (none)"
        Me.mnServer.Id = 48
        Me.mnServer.ImageOptions.SvgImage = CType(resources.GetObject("mnServer.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.mnServer.Name = "mnServer"
        '
        'mnStatusUser
        '
        Me.mnStatusUser.Caption = "Username : (none)"
        Me.mnStatusUser.Hint = "Klik untuk mengubah password"
        Me.mnStatusUser.Id = 49
        Me.mnStatusUser.ImageOptions.SvgImage = CType(resources.GetObject("mnStatusUser.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.mnStatusUser.Name = "mnStatusUser"
        '
        'mnKategoriAsset
        '
        Me.mnKategoriAsset.Caption = "Kategori Assets"
        Me.mnKategoriAsset.Id = 50
        Me.mnKategoriAsset.ImageOptions.LargeImage = Global.Siaga.App.My.Resources.Resources.Category
        Me.mnKategoriAsset.Name = "mnKategoriAsset"
        '
        'mnAssets
        '
        Me.mnAssets.Caption = "Assets"
        Me.mnAssets.Id = 51
        Me.mnAssets.ImageOptions.LargeImage = Global.Siaga.App.My.Resources.Resources.Assets
        Me.mnAssets.Name = "mnAssets"
        '
        'mnRuangan
        '
        Me.mnRuangan.Caption = "Ruangan"
        Me.mnRuangan.Id = 52
        Me.mnRuangan.ImageOptions.LargeImage = Global.Siaga.App.My.Resources.Resources.Lokasi
        Me.mnRuangan.Name = "mnRuangan"
        '
        'mnPemindahan
        '
        Me.mnPemindahan.Caption = "Pemindahan"
        Me.mnPemindahan.Id = 53
        Me.mnPemindahan.Name = "mnPemindahan"
        '
        'mnPemutihan
        '
        Me.mnPemutihan.Caption = "Pemutihan"
        Me.mnPemutihan.Id = 54
        Me.mnPemutihan.Name = "mnPemutihan"
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup2, Me.RibbonPageGroup3, Me.RibbonPageGroup4})
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "Menu Utama"
        Me.RibbonPage2.Visible = False
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.mnKategoriAsset)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.mnAssets)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.mnRuangan)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "Master"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.ItemLinks.Add(Me.mnPemindahan)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.mnPemutihan)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.Text = "Transaksi"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.Text = "Laporan"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.ribbonPageGroup})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "View"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.mnLogInOut)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.mnSetting)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Modul"
        '
        'ribbonPageGroup
        '
        Me.ribbonPageGroup.AllowTextClipping = False
        Me.ribbonPageGroup.ItemLinks.Add(Me.skinRibbonGalleryBarItem)
        Me.ribbonPageGroup.Name = "ribbonPageGroup"
        Me.ribbonPageGroup.ShowCaptionButton = False
        Me.ribbonPageGroup.Text = "Appearance"
        '
        'ribbonStatusBar
        '
        Me.ribbonStatusBar.ItemLinks.Add(Me.mnServer)
        Me.ribbonStatusBar.ItemLinks.Add(Me.mnStatusUser)
        Me.ribbonStatusBar.Location = New System.Drawing.Point(0, 721)
        Me.ribbonStatusBar.Name = "ribbonStatusBar"
        Me.ribbonStatusBar.Ribbon = Me.ribbonControl
        Me.ribbonStatusBar.Size = New System.Drawing.Size(1173, 31)
        '
        'XtraTabbedMdiManager1
        '
        Me.XtraTabbedMdiManager1.MdiParent = Me
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1173, 752)
        Me.Controls.Add(Me.ribbonStatusBar)
        Me.Controls.Add(Me.ribbonControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "frmMain"
        Me.Ribbon = Me.ribbonControl
        Me.StatusBar = Me.ribbonStatusBar
        Me.Text = "Siaga.App"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.tabbedView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Private WithEvents tabbedView As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView
    Private WithEvents ribbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Private WithEvents ribbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private WithEvents ribbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Private WithEvents skinRibbonGalleryBarItem As DevExpress.XtraBars.SkinRibbonGalleryBarItem
    Private WithEvents employeesBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Private WithEvents customersBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents XtraTabbedMdiManager1 As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
    Friend WithEvents mnLogInOut As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents mnSetting As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents mnServer As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents mnStatusUser As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents mnKategoriAsset As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnAssets As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnRuangan As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnPemindahan As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnPemutihan As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
End Class
