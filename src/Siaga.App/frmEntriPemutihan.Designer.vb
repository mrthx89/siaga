<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEntriPemutihan
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
        Me.PemutihanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.mnSimpan = New DevExpress.XtraBars.BarButtonItem()
        Me.mnTutup = New DevExpress.XtraBars.BarButtonItem()
        Me.mnSimpanLayouts = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.id_detail_assetSearchLookUpEdit = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gvDetailAsset = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForid_detail_asset = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.tgl_pemutihanDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.ItemFortgl_pemutihan = New DevExpress.XtraLayout.LayoutControlItem()
        Me.alasanTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemForalasan = New DevExpress.XtraLayout.LayoutControlItem()
        Me.keteranganTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemForketerangan = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.PemutihanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.id_detail_assetSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDetailAsset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForid_detail_asset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tgl_pemutihanDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tgl_pemutihanDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemFortgl_pemutihan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.alasanTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForalasan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.keteranganTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForketerangan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.id_detail_assetSearchLookUpEdit)
        Me.DataLayoutControl1.Controls.Add(Me.tgl_pemutihanDateEdit)
        Me.DataLayoutControl1.Controls.Add(Me.alasanTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.keteranganTextEdit)
        Me.DataLayoutControl1.DataSource = Me.PemutihanBindingSource
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.Location = New System.Drawing.Point(0, 29)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(572, 193, 450, 400)
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(388, 246)
        Me.DataLayoutControl1.TabIndex = 0
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'PemutihanBindingSource
        '
        Me.PemutihanBindingSource.DataSource = GetType(Siaga.App.Data.Entity.Pemutihan)
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
        Me.barDockControlTop.Size = New System.Drawing.Size(388, 29)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 275)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(388, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 29)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 246)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(388, 29)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 246)
        '
        'id_detail_assetSearchLookUpEdit
        '
        Me.id_detail_assetSearchLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PemutihanBindingSource, "id_detail_asset", True))
        Me.id_detail_assetSearchLookUpEdit.EnterMoveNextControl = True
        Me.id_detail_assetSearchLookUpEdit.Location = New System.Drawing.Point(82, 36)
        Me.id_detail_assetSearchLookUpEdit.MenuManager = Me.BarManager1
        Me.id_detail_assetSearchLookUpEdit.Name = "id_detail_assetSearchLookUpEdit"
        Me.id_detail_assetSearchLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.id_detail_assetSearchLookUpEdit.Properties.NullText = ""
        Me.id_detail_assetSearchLookUpEdit.Properties.View = Me.gvDetailAsset
        Me.id_detail_assetSearchLookUpEdit.Size = New System.Drawing.Size(294, 20)
        Me.id_detail_assetSearchLookUpEdit.StyleController = Me.DataLayoutControl1
        Me.id_detail_assetSearchLookUpEdit.TabIndex = 8
        '
        'gvDetailAsset
        '
        Me.gvDetailAsset.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gvDetailAsset.Name = "gvDetailAsset"
        Me.gvDetailAsset.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvDetailAsset.OptionsView.ShowGroupPanel = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2, Me.EmptySpaceItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(388, 246)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForid_detail_asset, Me.ItemForalasan, Me.ItemForketerangan, Me.ItemFortgl_pemutihan})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(368, 96)
        '
        'ItemForid_detail_asset
        '
        Me.ItemForid_detail_asset.Control = Me.id_detail_assetSearchLookUpEdit
        Me.ItemForid_detail_asset.Location = New System.Drawing.Point(0, 24)
        Me.ItemForid_detail_asset.Name = "ItemForid_detail_asset"
        Me.ItemForid_detail_asset.Size = New System.Drawing.Size(368, 24)
        Me.ItemForid_detail_asset.Text = "Detil Asset"
        Me.ItemForid_detail_asset.TextSize = New System.Drawing.Size(67, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 96)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(368, 130)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'tgl_pemutihanDateEdit
        '
        Me.tgl_pemutihanDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PemutihanBindingSource, "tgl_pemutihan", True))
        Me.tgl_pemutihanDateEdit.EditValue = Nothing
        Me.tgl_pemutihanDateEdit.EnterMoveNextControl = True
        Me.tgl_pemutihanDateEdit.Location = New System.Drawing.Point(82, 12)
        Me.tgl_pemutihanDateEdit.MenuManager = Me.BarManager1
        Me.tgl_pemutihanDateEdit.Name = "tgl_pemutihanDateEdit"
        Me.tgl_pemutihanDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tgl_pemutihanDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tgl_pemutihanDateEdit.Properties.Mask.EditMask = "dd-MM-yyyy"
        Me.tgl_pemutihanDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.tgl_pemutihanDateEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.tgl_pemutihanDateEdit.Size = New System.Drawing.Size(294, 20)
        Me.tgl_pemutihanDateEdit.StyleController = Me.DataLayoutControl1
        Me.tgl_pemutihanDateEdit.TabIndex = 10
        '
        'ItemFortgl_pemutihan
        '
        Me.ItemFortgl_pemutihan.Control = Me.tgl_pemutihanDateEdit
        Me.ItemFortgl_pemutihan.Location = New System.Drawing.Point(0, 0)
        Me.ItemFortgl_pemutihan.Name = "ItemFortgl_pemutihan"
        Me.ItemFortgl_pemutihan.Size = New System.Drawing.Size(368, 24)
        Me.ItemFortgl_pemutihan.Text = "Tgl Pemutihan"
        Me.ItemFortgl_pemutihan.TextSize = New System.Drawing.Size(67, 13)
        '
        'alasanTextEdit
        '
        Me.alasanTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PemutihanBindingSource, "alasan", True))
        Me.alasanTextEdit.EnterMoveNextControl = True
        Me.alasanTextEdit.Location = New System.Drawing.Point(82, 60)
        Me.alasanTextEdit.MenuManager = Me.BarManager1
        Me.alasanTextEdit.Name = "alasanTextEdit"
        Me.alasanTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.alasanTextEdit.Size = New System.Drawing.Size(294, 20)
        Me.alasanTextEdit.StyleController = Me.DataLayoutControl1
        Me.alasanTextEdit.TabIndex = 11
        '
        'ItemForalasan
        '
        Me.ItemForalasan.Control = Me.alasanTextEdit
        Me.ItemForalasan.Location = New System.Drawing.Point(0, 48)
        Me.ItemForalasan.Name = "ItemForalasan"
        Me.ItemForalasan.Size = New System.Drawing.Size(368, 24)
        Me.ItemForalasan.Text = "Alasan"
        Me.ItemForalasan.TextSize = New System.Drawing.Size(67, 13)
        '
        'keteranganTextEdit
        '
        Me.keteranganTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PemutihanBindingSource, "keterangan", True))
        Me.keteranganTextEdit.EnterMoveNextControl = True
        Me.keteranganTextEdit.Location = New System.Drawing.Point(82, 84)
        Me.keteranganTextEdit.MenuManager = Me.BarManager1
        Me.keteranganTextEdit.Name = "keteranganTextEdit"
        Me.keteranganTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.keteranganTextEdit.Size = New System.Drawing.Size(294, 20)
        Me.keteranganTextEdit.StyleController = Me.DataLayoutControl1
        Me.keteranganTextEdit.TabIndex = 12
        '
        'ItemForketerangan
        '
        Me.ItemForketerangan.Control = Me.keteranganTextEdit
        Me.ItemForketerangan.Location = New System.Drawing.Point(0, 72)
        Me.ItemForketerangan.Name = "ItemForketerangan"
        Me.ItemForketerangan.Size = New System.Drawing.Size(368, 24)
        Me.ItemForketerangan.Text = "Keterangan"
        Me.ItemForketerangan.TextSize = New System.Drawing.Size(67, 13)
        '
        'frmEntriPemutihan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 275)
        Me.Controls.Add(Me.DataLayoutControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmEntriPemutihan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Entri Pemutihan Asset"
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.PemutihanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.id_detail_assetSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDetailAsset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForid_detail_asset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tgl_pemutihanDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tgl_pemutihanDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemFortgl_pemutihan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.alasanTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForalasan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.keteranganTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForketerangan, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PemutihanBindingSource As BindingSource
    Friend WithEvents mnSimpanLayouts As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents id_detail_assetSearchLookUpEdit As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gvDetailAsset As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ItemForid_detail_asset As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents tgl_pemutihanDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents alasanTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents keteranganTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ItemFortgl_pemutihan As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForalasan As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForketerangan As DevExpress.XtraLayout.LayoutControlItem
End Class
