<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntriKategoriAsset
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.kd_kategoriTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.KategoriAssetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.mnSimpan = New DevExpress.XtraBars.BarButtonItem()
        Me.mnTutup = New DevExpress.XtraBars.BarButtonItem()
        Me.mnSimpanLayouts = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.nama_kategoriTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.keteranganMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForkd_kategori = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemFornama_kategori = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForketerangan = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.kd_kategoriTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KategoriAssetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nama_kategoriTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.keteranganMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForkd_kategori, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemFornama_kategori, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForketerangan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.kd_kategoriTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.nama_kategoriTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.keteranganMemoEdit)
        Me.DataLayoutControl1.DataSource = Me.KategoriAssetBindingSource
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.Location = New System.Drawing.Point(0, 29)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(517, 412)
        Me.DataLayoutControl1.TabIndex = 0
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'kd_kategoriTextEdit
        '
        Me.kd_kategoriTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.KategoriAssetBindingSource, "kd_kategori", True))
        Me.kd_kategoriTextEdit.EnterMoveNextControl = True
        Me.kd_kategoriTextEdit.Location = New System.Drawing.Point(71, 12)
        Me.kd_kategoriTextEdit.MenuManager = Me.BarManager1
        Me.kd_kategoriTextEdit.Name = "kd_kategoriTextEdit"
        Me.kd_kategoriTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.kd_kategoriTextEdit.Size = New System.Drawing.Size(434, 20)
        Me.kd_kategoriTextEdit.StyleController = Me.DataLayoutControl1
        Me.kd_kategoriTextEdit.TabIndex = 4
        '
        'KategoriAssetBindingSource
        '
        Me.KategoriAssetBindingSource.DataSource = GetType(Siaga.App.Data.Entity.KategoriAsset)
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
        Me.barDockControlTop.Size = New System.Drawing.Size(517, 29)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 441)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(517, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 29)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 412)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(517, 29)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 412)
        '
        'nama_kategoriTextEdit
        '
        Me.nama_kategoriTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.KategoriAssetBindingSource, "nama_kategori", True))
        Me.nama_kategoriTextEdit.EnterMoveNextControl = True
        Me.nama_kategoriTextEdit.Location = New System.Drawing.Point(71, 36)
        Me.nama_kategoriTextEdit.MenuManager = Me.BarManager1
        Me.nama_kategoriTextEdit.Name = "nama_kategoriTextEdit"
        Me.nama_kategoriTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.nama_kategoriTextEdit.Size = New System.Drawing.Size(434, 20)
        Me.nama_kategoriTextEdit.StyleController = Me.DataLayoutControl1
        Me.nama_kategoriTextEdit.TabIndex = 5
        '
        'keteranganMemoEdit
        '
        Me.keteranganMemoEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.KategoriAssetBindingSource, "keterangan", True))
        Me.keteranganMemoEdit.Location = New System.Drawing.Point(12, 76)
        Me.keteranganMemoEdit.MenuManager = Me.BarManager1
        Me.keteranganMemoEdit.Name = "keteranganMemoEdit"
        Me.keteranganMemoEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.keteranganMemoEdit.Size = New System.Drawing.Size(493, 324)
        Me.keteranganMemoEdit.StyleController = Me.DataLayoutControl1
        Me.keteranganMemoEdit.TabIndex = 6
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(517, 412)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForkd_kategori, Me.ItemFornama_kategori, Me.ItemForketerangan})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(497, 392)
        '
        'ItemForkd_kategori
        '
        Me.ItemForkd_kategori.Control = Me.kd_kategoriTextEdit
        Me.ItemForkd_kategori.Location = New System.Drawing.Point(0, 0)
        Me.ItemForkd_kategori.Name = "ItemForkd_kategori"
        Me.ItemForkd_kategori.Size = New System.Drawing.Size(497, 24)
        Me.ItemForkd_kategori.Text = "Kode"
        Me.ItemForkd_kategori.TextSize = New System.Drawing.Size(56, 13)
        '
        'ItemFornama_kategori
        '
        Me.ItemFornama_kategori.Control = Me.nama_kategoriTextEdit
        Me.ItemFornama_kategori.Location = New System.Drawing.Point(0, 24)
        Me.ItemFornama_kategori.Name = "ItemFornama_kategori"
        Me.ItemFornama_kategori.Size = New System.Drawing.Size(497, 24)
        Me.ItemFornama_kategori.Text = "Nama"
        Me.ItemFornama_kategori.TextSize = New System.Drawing.Size(56, 13)
        '
        'ItemForketerangan
        '
        Me.ItemForketerangan.Control = Me.keteranganMemoEdit
        Me.ItemForketerangan.Location = New System.Drawing.Point(0, 48)
        Me.ItemForketerangan.Name = "ItemForketerangan"
        Me.ItemForketerangan.Size = New System.Drawing.Size(497, 344)
        Me.ItemForketerangan.StartNewLine = True
        Me.ItemForketerangan.Text = "Keterangan"
        Me.ItemForketerangan.TextLocation = DevExpress.Utils.Locations.Top
        Me.ItemForketerangan.TextSize = New System.Drawing.Size(56, 13)
        '
        'frmEntriKategoriAsset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 441)
        Me.Controls.Add(Me.DataLayoutControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmEntriKategoriAsset"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Entri Kategori Asset"
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.kd_kategoriTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KategoriAssetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nama_kategoriTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.keteranganMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForkd_kategori, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemFornama_kategori, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents kd_kategoriTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents KategoriAssetBindingSource As BindingSource
    Friend WithEvents mnSimpanLayouts As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents nama_kategoriTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents keteranganMemoEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForkd_kategori As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemFornama_kategori As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForketerangan As DevExpress.XtraLayout.LayoutControlItem
End Class
