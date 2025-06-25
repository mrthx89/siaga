<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEntriPemakaian
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
        Me.PemakaianBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.mnSimpan = New DevExpress.XtraBars.BarButtonItem()
        Me.mnTutup = New DevExpress.XtraBars.BarButtonItem()
        Me.mnSimpanLayouts = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.id_ruanganSearchLookUpEdit = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gvRuangan = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ItemForid_ruangan = New DevExpress.XtraLayout.LayoutControlItem()
        Me.id_detail_assetSearchLookUpEdit = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gvDetailAsset = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ItemForid_detail_asset = New DevExpress.XtraLayout.LayoutControlItem()
        Me.tgl_mulai_pakaiDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.ItemFortgl_mulai_pakai = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.PemakaianBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.id_ruanganSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvRuangan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForid_ruangan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.id_detail_assetSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDetailAsset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForid_detail_asset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tgl_mulai_pakaiDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tgl_mulai_pakaiDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemFortgl_mulai_pakai, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.id_ruanganSearchLookUpEdit)
        Me.DataLayoutControl1.Controls.Add(Me.id_detail_assetSearchLookUpEdit)
        Me.DataLayoutControl1.Controls.Add(Me.tgl_mulai_pakaiDateEdit)
        Me.DataLayoutControl1.DataSource = Me.PemakaianBindingSource
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.Location = New System.Drawing.Point(0, 29)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(572, 193, 450, 400)
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(388, 246)
        Me.DataLayoutControl1.TabIndex = 0
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'PemakaianBindingSource
        '
        Me.PemakaianBindingSource.DataSource = GetType(Siaga.App.Data.Entity.Pemakaian)
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
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForid_ruangan, Me.ItemForid_detail_asset, Me.ItemFortgl_mulai_pakai})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(368, 72)
        '
        'id_ruanganSearchLookUpEdit
        '
        Me.id_ruanganSearchLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PemakaianBindingSource, "id_ruangan", True))
        Me.id_ruanganSearchLookUpEdit.EnterMoveNextControl = True
        Me.id_ruanganSearchLookUpEdit.Location = New System.Drawing.Point(84, 36)
        Me.id_ruanganSearchLookUpEdit.MenuManager = Me.BarManager1
        Me.id_ruanganSearchLookUpEdit.Name = "id_ruanganSearchLookUpEdit"
        Me.id_ruanganSearchLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.id_ruanganSearchLookUpEdit.Properties.NullText = ""
        Me.id_ruanganSearchLookUpEdit.Properties.View = Me.gvRuangan
        Me.id_ruanganSearchLookUpEdit.Size = New System.Drawing.Size(292, 20)
        Me.id_ruanganSearchLookUpEdit.StyleController = Me.DataLayoutControl1
        Me.id_ruanganSearchLookUpEdit.TabIndex = 7
        '
        'gvRuangan
        '
        Me.gvRuangan.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gvRuangan.Name = "gvRuangan"
        Me.gvRuangan.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvRuangan.OptionsView.ShowGroupPanel = False
        '
        'ItemForid_ruangan
        '
        Me.ItemForid_ruangan.Control = Me.id_ruanganSearchLookUpEdit
        Me.ItemForid_ruangan.Location = New System.Drawing.Point(0, 24)
        Me.ItemForid_ruangan.Name = "ItemForid_ruangan"
        Me.ItemForid_ruangan.Size = New System.Drawing.Size(368, 24)
        Me.ItemForid_ruangan.Text = "Ruangan"
        Me.ItemForid_ruangan.TextSize = New System.Drawing.Size(69, 13)
        '
        'id_detail_assetSearchLookUpEdit
        '
        Me.id_detail_assetSearchLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PemakaianBindingSource, "id_detail_asset", True))
        Me.id_detail_assetSearchLookUpEdit.EnterMoveNextControl = True
        Me.id_detail_assetSearchLookUpEdit.Location = New System.Drawing.Point(84, 60)
        Me.id_detail_assetSearchLookUpEdit.MenuManager = Me.BarManager1
        Me.id_detail_assetSearchLookUpEdit.Name = "id_detail_assetSearchLookUpEdit"
        Me.id_detail_assetSearchLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.id_detail_assetSearchLookUpEdit.Properties.NullText = ""
        Me.id_detail_assetSearchLookUpEdit.Properties.View = Me.gvDetailAsset
        Me.id_detail_assetSearchLookUpEdit.Size = New System.Drawing.Size(292, 20)
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
        'ItemForid_detail_asset
        '
        Me.ItemForid_detail_asset.Control = Me.id_detail_assetSearchLookUpEdit
        Me.ItemForid_detail_asset.Location = New System.Drawing.Point(0, 48)
        Me.ItemForid_detail_asset.Name = "ItemForid_detail_asset"
        Me.ItemForid_detail_asset.Size = New System.Drawing.Size(368, 24)
        Me.ItemForid_detail_asset.Text = "Detil Asset"
        Me.ItemForid_detail_asset.TextSize = New System.Drawing.Size(69, 13)
        '
        'tgl_mulai_pakaiDateEdit
        '
        Me.tgl_mulai_pakaiDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PemakaianBindingSource, "tgl_mulai_pakai", True))
        Me.tgl_mulai_pakaiDateEdit.EditValue = Nothing
        Me.tgl_mulai_pakaiDateEdit.EnterMoveNextControl = True
        Me.tgl_mulai_pakaiDateEdit.Location = New System.Drawing.Point(84, 12)
        Me.tgl_mulai_pakaiDateEdit.MenuManager = Me.BarManager1
        Me.tgl_mulai_pakaiDateEdit.Name = "tgl_mulai_pakaiDateEdit"
        Me.tgl_mulai_pakaiDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tgl_mulai_pakaiDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tgl_mulai_pakaiDateEdit.Properties.Mask.EditMask = "dd-MM-yyyy"
        Me.tgl_mulai_pakaiDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.tgl_mulai_pakaiDateEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.tgl_mulai_pakaiDateEdit.Size = New System.Drawing.Size(292, 20)
        Me.tgl_mulai_pakaiDateEdit.StyleController = Me.DataLayoutControl1
        Me.tgl_mulai_pakaiDateEdit.TabIndex = 9
        '
        'ItemFortgl_mulai_pakai
        '
        Me.ItemFortgl_mulai_pakai.Control = Me.tgl_mulai_pakaiDateEdit
        Me.ItemFortgl_mulai_pakai.Location = New System.Drawing.Point(0, 0)
        Me.ItemFortgl_mulai_pakai.Name = "ItemFortgl_mulai_pakai"
        Me.ItemFortgl_mulai_pakai.Size = New System.Drawing.Size(368, 24)
        Me.ItemFortgl_mulai_pakai.Text = "Tgl Mulai Pakai"
        Me.ItemFortgl_mulai_pakai.TextSize = New System.Drawing.Size(69, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 72)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(368, 154)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmEntriPemakaian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 275)
        Me.Controls.Add(Me.DataLayoutControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmEntriPemakaian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Entri Pemakaian Asset"
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.PemakaianBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.id_ruanganSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvRuangan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForid_ruangan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.id_detail_assetSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDetailAsset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForid_detail_asset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tgl_mulai_pakaiDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tgl_mulai_pakaiDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemFortgl_mulai_pakai, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PemakaianBindingSource As BindingSource
    Friend WithEvents mnSimpanLayouts As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents id_ruanganSearchLookUpEdit As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gvRuangan As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents id_detail_assetSearchLookUpEdit As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gvDetailAsset As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents tgl_mulai_pakaiDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ItemForid_ruangan As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForid_detail_asset As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemFortgl_mulai_pakai As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
End Class
