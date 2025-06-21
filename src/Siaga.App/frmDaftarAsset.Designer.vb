<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDaftarAsset
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.AssetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.mnBaru = New DevExpress.XtraBars.BarButtonItem()
        Me.mnUbah = New DevExpress.XtraBars.BarButtonItem()
        Me.mnHapus = New DevExpress.XtraBars.BarButtonItem()
        Me.mnSegarkan = New DevExpress.XtraBars.BarButtonItem()
        Me.mnExportExcel = New DevExpress.XtraBars.BarButtonItem()
        Me.mnSimpanLayouts = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colkd_asset = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnama_asset = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colid_kategori = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnama_kategori = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colketerangan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.DetailAssetsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colid1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colid_asset = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbarcode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltgl_perolehan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colharga_beli = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colkondisi = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AssetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailAssetsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.AssetBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 20)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(528, 637)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'AssetBindingSource
        '
        Me.AssetBindingSource.DataSource = GetType(Siaga.App.Model.AssetDTo)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colkd_asset, Me.colnama_asset, Me.colid_kategori, Me.colnama_kategori, Me.colketerangan})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowDetailButtons = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.mnBaru, Me.mnUbah, Me.mnHapus, Me.mnSegarkan, Me.mnExportExcel, Me.mnSimpanLayouts})
        Me.BarManager1.MaxItemId = 6
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.mnBaru), New DevExpress.XtraBars.LinkPersistInfo(Me.mnUbah), New DevExpress.XtraBars.LinkPersistInfo(Me.mnHapus), New DevExpress.XtraBars.LinkPersistInfo(Me.mnSegarkan, True), New DevExpress.XtraBars.LinkPersistInfo(Me.mnExportExcel, True), New DevExpress.XtraBars.LinkPersistInfo(Me.mnSimpanLayouts, True)})
        Me.Bar1.Text = "Tools"
        '
        'mnBaru
        '
        Me.mnBaru.Caption = "&Baru [F1]"
        Me.mnBaru.Id = 0
        Me.mnBaru.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F1)
        Me.mnBaru.Name = "mnBaru"
        '
        'mnUbah
        '
        Me.mnUbah.Caption = "&Ubah [F2]"
        Me.mnUbah.Id = 1
        Me.mnUbah.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F2)
        Me.mnUbah.Name = "mnUbah"
        '
        'mnHapus
        '
        Me.mnHapus.Caption = "&Hapus [F3]"
        Me.mnHapus.Id = 2
        Me.mnHapus.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F3)
        Me.mnHapus.Name = "mnHapus"
        '
        'mnSegarkan
        '
        Me.mnSegarkan.Caption = "&Segarkan [F5]"
        Me.mnSegarkan.Id = 3
        Me.mnSegarkan.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5)
        Me.mnSegarkan.Name = "mnSegarkan"
        '
        'mnExportExcel
        '
        Me.mnExportExcel.Caption = "&Export Excel [F8]"
        Me.mnExportExcel.Id = 4
        Me.mnExportExcel.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F8)
        Me.mnExportExcel.Name = "mnExportExcel"
        '
        'mnSimpanLayouts
        '
        Me.mnSimpanLayouts.Caption = "Simpan &Layouts [F10]"
        Me.mnSimpanLayouts.Id = 5
        Me.mnSimpanLayouts.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F10)
        Me.mnSimpanLayouts.Name = "mnSimpanLayouts"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1103, 29)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 688)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1103, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 29)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 659)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1103, 29)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 659)
        '
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        '
        'colkd_asset
        '
        Me.colkd_asset.Caption = "Kode Asset"
        Me.colkd_asset.FieldName = "kd_asset"
        Me.colkd_asset.Name = "colkd_asset"
        Me.colkd_asset.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "kd_asset", "{0}")})
        Me.colkd_asset.Visible = True
        Me.colkd_asset.VisibleIndex = 1
        Me.colkd_asset.Width = 76
        '
        'colnama_asset
        '
        Me.colnama_asset.Caption = "Nama Asset"
        Me.colnama_asset.FieldName = "nama_asset"
        Me.colnama_asset.Name = "colnama_asset"
        Me.colnama_asset.Visible = True
        Me.colnama_asset.VisibleIndex = 2
        Me.colnama_asset.Width = 129
        '
        'colid_kategori
        '
        Me.colid_kategori.FieldName = "id_kategori"
        Me.colid_kategori.Name = "colid_kategori"
        '
        'colnama_kategori
        '
        Me.colnama_kategori.Caption = "Kategori Asset"
        Me.colnama_kategori.FieldName = "nama_kategori"
        Me.colnama_kategori.Name = "colnama_kategori"
        Me.colnama_kategori.Visible = True
        Me.colnama_kategori.VisibleIndex = 0
        Me.colnama_kategori.Width = 90
        '
        'colketerangan
        '
        Me.colketerangan.Caption = "Keterangan"
        Me.colketerangan.FieldName = "keterangan"
        Me.colketerangan.Name = "colketerangan"
        Me.colketerangan.Visible = True
        Me.colketerangan.VisibleIndex = 3
        Me.colketerangan.Width = 338
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 29)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.GroupControl1)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.GroupControl2)
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1103, 659)
        Me.SplitContainerControl1.SplitterPosition = 566
        Me.SplitContainerControl1.TabIndex = 5
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.GridControl1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(532, 659)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Data Asset"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.GridControl2)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(566, 659)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Data Detail Asset"
        '
        'GridControl2
        '
        Me.GridControl2.DataSource = Me.DetailAssetsBindingSource
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(2, 20)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(562, 637)
        Me.GridControl2.TabIndex = 1
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid1, Me.colid_asset, Me.colbarcode, Me.coltgl_perolehan, Me.colsumber, Me.colharga_beli, Me.colkondisi})
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsSelection.MultiSelect = True
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.ShowAutoFilterRow = True
        Me.GridView2.OptionsView.ShowDetailButtons = False
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'DetailAssetsBindingSource
        '
        Me.DetailAssetsBindingSource.DataMember = "DetailAssets"
        Me.DetailAssetsBindingSource.DataSource = Me.AssetBindingSource
        '
        'colid1
        '
        Me.colid1.FieldName = "id"
        Me.colid1.Name = "colid1"
        '
        'colid_asset
        '
        Me.colid_asset.FieldName = "id_asset"
        Me.colid_asset.Name = "colid_asset"
        '
        'colbarcode
        '
        Me.colbarcode.Caption = "Barcode"
        Me.colbarcode.FieldName = "barcode"
        Me.colbarcode.Name = "colbarcode"
        Me.colbarcode.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "barcode", "{0}")})
        Me.colbarcode.Visible = True
        Me.colbarcode.VisibleIndex = 0
        Me.colbarcode.Width = 101
        '
        'coltgl_perolehan
        '
        Me.coltgl_perolehan.Caption = "Tgl Perolehan"
        Me.coltgl_perolehan.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.coltgl_perolehan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.coltgl_perolehan.FieldName = "tgl_perolehan"
        Me.coltgl_perolehan.Name = "coltgl_perolehan"
        Me.coltgl_perolehan.Visible = True
        Me.coltgl_perolehan.VisibleIndex = 1
        Me.coltgl_perolehan.Width = 73
        '
        'colsumber
        '
        Me.colsumber.Caption = "Sumber"
        Me.colsumber.FieldName = "sumber"
        Me.colsumber.Name = "colsumber"
        Me.colsumber.Visible = True
        Me.colsumber.VisibleIndex = 2
        Me.colsumber.Width = 131
        '
        'colharga_beli
        '
        Me.colharga_beli.AppearanceCell.Options.UseTextOptions = True
        Me.colharga_beli.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colharga_beli.AppearanceHeader.Options.UseTextOptions = True
        Me.colharga_beli.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colharga_beli.Caption = "Harga Beli"
        Me.colharga_beli.DisplayFormat.FormatString = "n2"
        Me.colharga_beli.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colharga_beli.FieldName = "harga_beli"
        Me.colharga_beli.Name = "colharga_beli"
        Me.colharga_beli.Visible = True
        Me.colharga_beli.VisibleIndex = 3
        Me.colharga_beli.Width = 93
        '
        'colkondisi
        '
        Me.colkondisi.Caption = "Kondisi"
        Me.colkondisi.FieldName = "kondisi"
        Me.colkondisi.Name = "colkondisi"
        Me.colkondisi.Visible = True
        Me.colkondisi.VisibleIndex = 4
        Me.colkondisi.Width = 189
        '
        'frmDaftarAsset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1103, 688)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmDaftarAsset"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Daftar Asset"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AssetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailAssetsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents mnBaru As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnUbah As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnHapus As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnSegarkan As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnExportExcel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents AssetBindingSource As BindingSource
    Friend WithEvents mnSimpanLayouts As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colkd_asset As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnama_asset As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colid_kategori As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnama_kategori As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colketerangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DetailAssetsBindingSource As BindingSource
    Friend WithEvents colid1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colid_asset As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbarcode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltgl_perolehan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colharga_beli As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colkondisi As DevExpress.XtraGrid.Columns.GridColumn
End Class
