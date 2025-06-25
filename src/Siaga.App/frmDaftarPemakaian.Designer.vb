<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDaftarPemakaian
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
        Me.PemakaianBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colid_ruangan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colruangan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colid_detail_asset = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldetail_asset = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltgl_mulai_pakai = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colid_asset = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colasset = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colkategori_asset = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtRuangan = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gvRuangan = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtAsset = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gvAsset = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtKategori = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gvKategori = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.tglSampai = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.tglDari = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PemakaianBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtRuangan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvRuangan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAsset.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvAsset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKategori.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvKategori, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglSampai.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglSampai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglDari.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglDari.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.PemakaianBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 97)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1103, 591)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'PemakaianBindingSource
        '
        Me.PemakaianBindingSource.DataSource = GetType(Siaga.App.Model.PemakaianDTo)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colid_ruangan, Me.colruangan, Me.colid_detail_asset, Me.coldetail_asset, Me.coltgl_mulai_pakai, Me.colid_asset, Me.colasset, Me.colkategori_asset})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.coltgl_mulai_pakai, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        '
        'colid_ruangan
        '
        Me.colid_ruangan.FieldName = "id_ruangan"
        Me.colid_ruangan.Name = "colid_ruangan"
        '
        'colruangan
        '
        Me.colruangan.Caption = "Ruangan"
        Me.colruangan.FieldName = "ruangan"
        Me.colruangan.Name = "colruangan"
        Me.colruangan.Visible = True
        Me.colruangan.VisibleIndex = 1
        Me.colruangan.Width = 104
        '
        'colid_detail_asset
        '
        Me.colid_detail_asset.FieldName = "id_detail_asset"
        Me.colid_detail_asset.Name = "colid_detail_asset"
        '
        'coldetail_asset
        '
        Me.coldetail_asset.Caption = "Detil Asset"
        Me.coldetail_asset.FieldName = "detail_asset"
        Me.coldetail_asset.Name = "coldetail_asset"
        Me.coldetail_asset.Visible = True
        Me.coldetail_asset.VisibleIndex = 3
        Me.coldetail_asset.Width = 160
        '
        'coltgl_mulai_pakai
        '
        Me.coltgl_mulai_pakai.Caption = "Tgl Mulai Pakai"
        Me.coltgl_mulai_pakai.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.coltgl_mulai_pakai.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.coltgl_mulai_pakai.FieldName = "tgl_mulai_pakai"
        Me.coltgl_mulai_pakai.Name = "coltgl_mulai_pakai"
        Me.coltgl_mulai_pakai.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "tgl_mulai_pakai", "{0}")})
        Me.coltgl_mulai_pakai.Visible = True
        Me.coltgl_mulai_pakai.VisibleIndex = 0
        Me.coltgl_mulai_pakai.Width = 102
        '
        'colid_asset
        '
        Me.colid_asset.FieldName = "id_asset"
        Me.colid_asset.Name = "colid_asset"
        '
        'colasset
        '
        Me.colasset.Caption = "Asset"
        Me.colasset.FieldName = "asset"
        Me.colasset.Name = "colasset"
        Me.colasset.Visible = True
        Me.colasset.VisibleIndex = 4
        Me.colasset.Width = 246
        '
        'colkategori_asset
        '
        Me.colkategori_asset.Caption = "Kategori Asset"
        Me.colkategori_asset.FieldName = "kategori_asset"
        Me.colkategori_asset.Name = "colkategori_asset"
        Me.colkategori_asset.Visible = True
        Me.colkategori_asset.VisibleIndex = 2
        Me.colkategori_asset.Width = 122
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
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.txtRuangan)
        Me.PanelControl1.Controls.Add(Me.txtAsset)
        Me.PanelControl1.Controls.Add(Me.txtKategori)
        Me.PanelControl1.Controls.Add(Me.tglSampai)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.tglDari)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 29)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1103, 68)
        Me.PanelControl1.TabIndex = 5
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(319, 45)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl5.TabIndex = 9
        Me.LabelControl5.Text = "Ruangan"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(319, 19)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl4.TabIndex = 8
        Me.LabelControl4.Text = "Asset"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(12, 45)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl3.TabIndex = 7
        Me.LabelControl3.Text = "Kategori"
        '
        'txtRuangan
        '
        Me.txtRuangan.EnterMoveNextControl = True
        Me.txtRuangan.Location = New System.Drawing.Point(368, 42)
        Me.txtRuangan.MenuManager = Me.BarManager1
        Me.txtRuangan.Name = "txtRuangan"
        Me.txtRuangan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtRuangan.Properties.View = Me.gvRuangan
        Me.txtRuangan.Size = New System.Drawing.Size(213, 20)
        Me.txtRuangan.TabIndex = 6
        '
        'gvRuangan
        '
        Me.gvRuangan.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gvRuangan.Name = "gvRuangan"
        Me.gvRuangan.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvRuangan.OptionsView.ShowGroupPanel = False
        '
        'txtAsset
        '
        Me.txtAsset.EnterMoveNextControl = True
        Me.txtAsset.Location = New System.Drawing.Point(368, 16)
        Me.txtAsset.MenuManager = Me.BarManager1
        Me.txtAsset.Name = "txtAsset"
        Me.txtAsset.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtAsset.Properties.View = Me.gvAsset
        Me.txtAsset.Size = New System.Drawing.Size(213, 20)
        Me.txtAsset.TabIndex = 5
        '
        'gvAsset
        '
        Me.gvAsset.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gvAsset.Name = "gvAsset"
        Me.gvAsset.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvAsset.OptionsView.ShowGroupPanel = False
        '
        'txtKategori
        '
        Me.txtKategori.EnterMoveNextControl = True
        Me.txtKategori.Location = New System.Drawing.Point(58, 42)
        Me.txtKategori.MenuManager = Me.BarManager1
        Me.txtKategori.Name = "txtKategori"
        Me.txtKategori.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtKategori.Properties.View = Me.gvKategori
        Me.txtKategori.Size = New System.Drawing.Size(213, 20)
        Me.txtKategori.TabIndex = 4
        '
        'gvKategori
        '
        Me.gvKategori.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gvKategori.Name = "gvKategori"
        Me.gvKategori.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvKategori.OptionsView.ShowGroupPanel = False
        '
        'tglSampai
        '
        Me.tglSampai.EditValue = New Date(2025, 6, 25, 8, 26, 0, 849)
        Me.tglSampai.EnterMoveNextControl = True
        Me.tglSampai.Location = New System.Drawing.Point(178, 16)
        Me.tglSampai.MenuManager = Me.BarManager1
        Me.tglSampai.Name = "tglSampai"
        Me.tglSampai.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tglSampai.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tglSampai.Properties.Mask.EditMask = "dd-MM-yyyy"
        Me.tglSampai.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.tglSampai.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.tglSampai.Size = New System.Drawing.Size(93, 20)
        Me.tglSampai.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(157, 19)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(15, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "s/d"
        '
        'tglDari
        '
        Me.tglDari.EditValue = New Date(2025, 6, 25, 8, 26, 0, 849)
        Me.tglDari.EnterMoveNextControl = True
        Me.tglDari.Location = New System.Drawing.Point(58, 16)
        Me.tglDari.MenuManager = Me.BarManager1
        Me.tglDari.Name = "tglDari"
        Me.tglDari.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tglDari.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tglDari.Properties.Mask.EditMask = "dd-MM-yyyy"
        Me.tglDari.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.tglDari.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.tglDari.Size = New System.Drawing.Size(93, 20)
        Me.tglDari.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 19)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Periode"
        '
        'frmDaftarPemakaian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1103, 688)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmDaftarPemakaian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Daftar Pemakaian"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PemakaianBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtRuangan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvRuangan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAsset.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvAsset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKategori.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvKategori, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglSampai.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglSampai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglDari.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglDari.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PemakaianBindingSource As BindingSource
    Friend WithEvents mnSimpanLayouts As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents tglSampai As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tglDari As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRuangan As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gvRuangan As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtAsset As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gvAsset As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtKategori As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gvKategori As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colid_ruangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colruangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colid_detail_asset As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldetail_asset As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltgl_mulai_pakai As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colid_asset As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colasset As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colkategori_asset As DevExpress.XtraGrid.Columns.GridColumn
End Class
