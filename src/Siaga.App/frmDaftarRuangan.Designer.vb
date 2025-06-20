<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDaftarRuangan
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
        Me.RuanganBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colkd_kategori = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnama_kategori = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colketerangan = New DevExpress.XtraGrid.Columns.GridColumn()
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
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RuanganBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.RuanganBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 29)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1103, 659)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'RuanganBindingSource
        '
        Me.RuanganBindingSource.DataSource = GetType(Siaga.App.Data.Entity.Ruangan)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colkd_kategori, Me.colnama_kategori, Me.colketerangan})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colid
        '
        Me.colid.Caption = "ID"
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        '
        'colkd_kategori
        '
        Me.colkd_kategori.Caption = "Kode"
        Me.colkd_kategori.FieldName = "kd_ruangan"
        Me.colkd_kategori.Name = "colkd_kategori"
        Me.colkd_kategori.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "kd_kategori", "{0}")})
        Me.colkd_kategori.Visible = True
        Me.colkd_kategori.VisibleIndex = 0
        Me.colkd_kategori.Width = 78
        '
        'colnama_kategori
        '
        Me.colnama_kategori.Caption = "Nama"
        Me.colnama_kategori.FieldName = "nama_ruangan"
        Me.colnama_kategori.Name = "colnama_kategori"
        Me.colnama_kategori.Visible = True
        Me.colnama_kategori.VisibleIndex = 1
        Me.colnama_kategori.Width = 173
        '
        'colketerangan
        '
        Me.colketerangan.Caption = "Keterangan"
        Me.colketerangan.FieldName = "keterangan"
        Me.colketerangan.Name = "colketerangan"
        Me.colketerangan.Visible = True
        Me.colketerangan.VisibleIndex = 2
        Me.colketerangan.Width = 533
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
        'frmDaftarRuangan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1103, 688)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmDaftarRuangan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Daftar Kategori Asset"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RuanganBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents RuanganBindingSource As BindingSource
    Friend WithEvents colid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colkd_kategori As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnama_kategori As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colketerangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents mnSimpanLayouts As DevExpress.XtraBars.BarButtonItem
End Class
