<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEntriAsset
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
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.AssetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.mnSimpan = New DevExpress.XtraBars.BarButtonItem()
        Me.mnTutup = New DevExpress.XtraBars.BarButtonItem()
        Me.mnSimpanLayouts = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.keteranganMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForketerangan = New DevExpress.XtraLayout.LayoutControlItem()
        Me.kd_assetTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemForkd_asset = New DevExpress.XtraLayout.LayoutControlItem()
        Me.nama_assetTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemFornama_asset = New DevExpress.XtraLayout.LayoutControlItem()
        Me.id_kategoriSearchLookUpEdit = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ItemForid_kategori = New DevExpress.XtraLayout.LayoutControlItem()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colid_asset = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbarcode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltgl_perolehan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colharga_beli = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colkondisi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.DetailAssetsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RepositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.cmdAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.cmdRemove = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.AssetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.keteranganMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForketerangan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kd_assetTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForkd_asset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nama_assetTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemFornama_asset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.id_kategoriSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForid_kategori, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailAssetsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.cmdRemove)
        Me.DataLayoutControl1.Controls.Add(Me.cmdAdd)
        Me.DataLayoutControl1.Controls.Add(Me.GridControl1)
        Me.DataLayoutControl1.Controls.Add(Me.keteranganMemoEdit)
        Me.DataLayoutControl1.Controls.Add(Me.kd_assetTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.nama_assetTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.id_kategoriSearchLookUpEdit)
        Me.DataLayoutControl1.DataSource = Me.AssetBindingSource
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.Location = New System.Drawing.Point(0, 29)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1094, 206, 450, 400)
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(692, 501)
        Me.DataLayoutControl1.TabIndex = 0
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'AssetBindingSource
        '
        Me.AssetBindingSource.DataSource = GetType(Siaga.App.Model.AssetDTo)
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.mnSimpan, Me.mnTutup, Me.mnSimpanLayouts})
        Me.BarManager1.MaxItemId = 3
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.mnSimpan), New DevExpress.XtraBars.LinkPersistInfo(Me.mnTutup), New DevExpress.XtraBars.LinkPersistInfo(Me.mnSimpanLayouts, True)})
        Me.Bar1.Text = "Tools"
        '
        'mnSimpan
        '
        Me.mnSimpan.Caption = "&Simpan [F6]"
        Me.mnSimpan.Id = 0
        Me.mnSimpan.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F6)
        Me.mnSimpan.Name = "mnSimpan"
        '
        'mnTutup
        '
        Me.mnTutup.Caption = "&Tutup [F4]"
        Me.mnTutup.Id = 1
        Me.mnTutup.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F4)
        Me.mnTutup.Name = "mnTutup"
        '
        'mnSimpanLayouts
        '
        Me.mnSimpanLayouts.Caption = "Simpan &Layouts [F10]"
        Me.mnSimpanLayouts.Id = 2
        Me.mnSimpanLayouts.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F10)
        Me.mnSimpanLayouts.Name = "mnSimpanLayouts"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(692, 29)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 530)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(692, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 29)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 501)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(692, 29)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 501)
        '
        'keteranganMemoEdit
        '
        Me.keteranganMemoEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AssetBindingSource, "keterangan", True))
        Me.keteranganMemoEdit.Location = New System.Drawing.Point(12, 100)
        Me.keteranganMemoEdit.MenuManager = Me.BarManager1
        Me.keteranganMemoEdit.Name = "keteranganMemoEdit"
        Me.keteranganMemoEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.keteranganMemoEdit.Size = New System.Drawing.Size(668, 59)
        Me.keteranganMemoEdit.StyleController = Me.DataLayoutControl1
        Me.keteranganMemoEdit.TabIndex = 6
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2, Me.LayoutControlItem1, Me.LayoutControlItem2, Me.EmptySpaceItem1, Me.LayoutControlItem3})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(692, 501)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForketerangan, Me.ItemForkd_asset, Me.ItemFornama_asset, Me.ItemForid_kategori})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(672, 151)
        '
        'ItemForketerangan
        '
        Me.ItemForketerangan.Control = Me.keteranganMemoEdit
        Me.ItemForketerangan.Location = New System.Drawing.Point(0, 72)
        Me.ItemForketerangan.Name = "ItemForketerangan"
        Me.ItemForketerangan.Size = New System.Drawing.Size(672, 79)
        Me.ItemForketerangan.StartNewLine = True
        Me.ItemForketerangan.Text = "Keterangan"
        Me.ItemForketerangan.TextLocation = DevExpress.Utils.Locations.Top
        Me.ItemForketerangan.TextSize = New System.Drawing.Size(56, 13)
        '
        'kd_assetTextEdit
        '
        Me.kd_assetTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AssetBindingSource, "kd_asset", True))
        Me.kd_assetTextEdit.EnterMoveNextControl = True
        Me.kd_assetTextEdit.Location = New System.Drawing.Point(71, 36)
        Me.kd_assetTextEdit.MenuManager = Me.BarManager1
        Me.kd_assetTextEdit.Name = "kd_assetTextEdit"
        Me.kd_assetTextEdit.Size = New System.Drawing.Size(609, 20)
        Me.kd_assetTextEdit.StyleController = Me.DataLayoutControl1
        Me.kd_assetTextEdit.TabIndex = 7
        '
        'ItemForkd_asset
        '
        Me.ItemForkd_asset.Control = Me.kd_assetTextEdit
        Me.ItemForkd_asset.Location = New System.Drawing.Point(0, 24)
        Me.ItemForkd_asset.Name = "ItemForkd_asset"
        Me.ItemForkd_asset.Size = New System.Drawing.Size(672, 24)
        Me.ItemForkd_asset.Text = "Kode"
        Me.ItemForkd_asset.TextSize = New System.Drawing.Size(56, 13)
        '
        'nama_assetTextEdit
        '
        Me.nama_assetTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AssetBindingSource, "nama_asset", True))
        Me.nama_assetTextEdit.EnterMoveNextControl = True
        Me.nama_assetTextEdit.Location = New System.Drawing.Point(71, 60)
        Me.nama_assetTextEdit.MenuManager = Me.BarManager1
        Me.nama_assetTextEdit.Name = "nama_assetTextEdit"
        Me.nama_assetTextEdit.Size = New System.Drawing.Size(609, 20)
        Me.nama_assetTextEdit.StyleController = Me.DataLayoutControl1
        Me.nama_assetTextEdit.TabIndex = 8
        '
        'ItemFornama_asset
        '
        Me.ItemFornama_asset.Control = Me.nama_assetTextEdit
        Me.ItemFornama_asset.Location = New System.Drawing.Point(0, 48)
        Me.ItemFornama_asset.Name = "ItemFornama_asset"
        Me.ItemFornama_asset.Size = New System.Drawing.Size(672, 24)
        Me.ItemFornama_asset.Text = "Nama"
        Me.ItemFornama_asset.TextSize = New System.Drawing.Size(56, 13)
        '
        'id_kategoriSearchLookUpEdit
        '
        Me.id_kategoriSearchLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AssetBindingSource, "id_kategori", True))
        Me.id_kategoriSearchLookUpEdit.EnterMoveNextControl = True
        Me.id_kategoriSearchLookUpEdit.Location = New System.Drawing.Point(71, 12)
        Me.id_kategoriSearchLookUpEdit.MenuManager = Me.BarManager1
        Me.id_kategoriSearchLookUpEdit.Name = "id_kategoriSearchLookUpEdit"
        Me.id_kategoriSearchLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.id_kategoriSearchLookUpEdit.Properties.NullText = ""
        Me.id_kategoriSearchLookUpEdit.Properties.View = Me.SearchLookUpEdit1View
        Me.id_kategoriSearchLookUpEdit.Size = New System.Drawing.Size(609, 20)
        Me.id_kategoriSearchLookUpEdit.StyleController = Me.DataLayoutControl1
        Me.id_kategoriSearchLookUpEdit.TabIndex = 9
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'ItemForid_kategori
        '
        Me.ItemForid_kategori.Control = Me.id_kategoriSearchLookUpEdit
        Me.ItemForid_kategori.Location = New System.Drawing.Point(0, 0)
        Me.ItemForid_kategori.Name = "ItemForid_kategori"
        Me.ItemForid_kategori.Size = New System.Drawing.Size(672, 24)
        Me.ItemForid_kategori.Text = "Kategori"
        Me.ItemForid_kategori.TextSize = New System.Drawing.Size(56, 13)
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.DetailAssetsBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(12, 163)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCalcEdit1, Me.RepositoryItemDateEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(627, 326)
        Me.GridControl1.TabIndex = 10
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid1, Me.colid_asset, Me.colbarcode, Me.coltgl_perolehan, Me.colsumber, Me.colharga_beli, Me.colkondisi})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowDetailButtons = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colid1
        '
        Me.colid1.FieldName = "id"
        Me.colid1.Name = "colid1"
        Me.colid1.OptionsColumn.AllowEdit = False
        Me.colid1.OptionsColumn.AllowFocus = False
        '
        'colid_asset
        '
        Me.colid_asset.FieldName = "id_asset"
        Me.colid_asset.Name = "colid_asset"
        Me.colid_asset.OptionsColumn.AllowEdit = False
        Me.colid_asset.OptionsColumn.AllowFocus = False
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
        Me.coltgl_perolehan.ColumnEdit = Me.RepositoryItemDateEdit1
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
        Me.colharga_beli.ColumnEdit = Me.RepositoryItemCalcEdit1
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
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.GridControl1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 151)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(631, 330)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'DetailAssetsBindingSource
        '
        Me.DetailAssetsBindingSource.DataMember = "DetailAssets"
        Me.DetailAssetsBindingSource.DataSource = Me.AssetBindingSource
        '
        'RepositoryItemCalcEdit1
        '
        Me.RepositoryItemCalcEdit1.AutoHeight = False
        Me.RepositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit1.Mask.EditMask = "n2"
        Me.RepositoryItemCalcEdit1.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemCalcEdit1.Name = "RepositoryItemCalcEdit1"
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Mask.EditMask = "dd-MM-yyyy"
        Me.RepositoryItemDateEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.RepositoryItemDateEdit1.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(643, 163)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(37, 22)
        Me.cmdAdd.StyleController = Me.DataLayoutControl1
        Me.cmdAdd.TabIndex = 11
        Me.cmdAdd.Text = "+"
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.cmdAdd
        Me.LayoutControlItem2.Location = New System.Drawing.Point(631, 151)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(41, 26)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(41, 26)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(41, 26)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(631, 203)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(41, 278)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'cmdRemove
        '
        Me.cmdRemove.Location = New System.Drawing.Point(643, 189)
        Me.cmdRemove.Name = "cmdRemove"
        Me.cmdRemove.Size = New System.Drawing.Size(37, 22)
        Me.cmdRemove.StyleController = Me.DataLayoutControl1
        Me.cmdRemove.TabIndex = 12
        Me.cmdRemove.Text = "-"
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cmdRemove
        Me.LayoutControlItem3.Location = New System.Drawing.Point(631, 177)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(41, 26)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'frmEntriAsset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 530)
        Me.Controls.Add(Me.DataLayoutControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmEntriAsset"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Entri Asset"
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.AssetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.keteranganMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForketerangan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kd_assetTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForkd_asset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nama_assetTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemFornama_asset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.id_kategoriSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForid_kategori, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailAssetsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents mnSimpan As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnTutup As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents AssetBindingSource As BindingSource
    Friend WithEvents mnSimpanLayouts As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents keteranganMemoEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForketerangan As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents kd_assetTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents nama_assetTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents id_kategoriSearchLookUpEdit As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ItemForkd_asset As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemFornama_asset As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForid_kategori As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents DetailAssetsBindingSource As BindingSource
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colid1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colid_asset As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbarcode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltgl_perolehan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colharga_beli As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colkondisi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmdRemove As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
End Class
