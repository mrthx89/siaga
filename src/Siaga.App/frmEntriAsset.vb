Imports DevExpress.XtraEditors
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmEntriAsset
    Public Property Model As Model.AssetDTo
    Public Property PTipe As [Enum].PTipe

    Private ReadOnly Rep As Services.IAsset = New Repository.Asset()
    Private ReadOnly RepKategori As Services.IKategoriAsset = New Repository.KategoriAsset()

    Public Sub New(PTipe As [Enum].PTipe, Model As Model.AssetDTo)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Model = Model
        Me.PTipe = PTipe
    End Sub

    Private Sub mnTutup_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnTutup.ItemClick
        DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmEntriAsset_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        id_kategoriSearchLookUpEdit.Properties.DataSource = RepKategori.GetAll().Item3
        id_kategoriSearchLookUpEdit.Properties.ValueMember = "id"
        id_kategoriSearchLookUpEdit.Properties.DisplayMember = "nama_kategori"

        If (PTipe = [Enum].PTipe.Create) Then
            Model = New Model.AssetDTo With {
                .id = Guid.NewGuid,
                .id_kategori = Guid.Empty,
                .nama_kategori = String.Empty,
                .keterangan = String.Empty,
                .kd_asset = String.Empty,
                .nama_asset = String.Empty,
                .DetailAssets = New List(Of Model.DetilAssetDTo)()}
        Else
            'Get Data
            Dim Result = Rep.Get(Model.id)
            If (Result.Item1) Then
                Model = Result.Item3
            Else
                XtraMessageBox.Show(Result.Item2, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                DialogResult = DialogResult.Abort
                Me.Close()
            End If
        End If

        'Show Data
        AssetBindingSource.DataSource = Model
        GridControl1.RefreshDataSource()

        If (IO.File.Exists(IO.Path.Combine(Program.FolderApp, "System", "Layouts", $"{Me.Name}_{DataLayoutControl1.Name}.xml"))) Then
            DataLayoutControl1.RestoreLayoutFromXml(IO.Path.Combine(Program.FolderApp, "System", "Layouts", $"{Me.Name}_{DataLayoutControl1.Name}.xml"))
        End If
    End Sub

    Private Sub GridView1_DataSourceChange(sender As Object, e As EventArgs) Handles GridView1.DataSourceChanged, SearchLookUpEdit1View.DataSourceChanged
        If (IO.File.Exists(IO.Path.Combine(Program.FolderApp, "System", "Layouts", $"{Me.Name}_{TryCast(sender, GridView).Name}.xml"))) Then
            TryCast(sender, GridView).RestoreLayoutFromXml(IO.Path.Combine(Program.FolderApp, "System", "Layouts", $"{Me.Name}_{TryCast(sender, GridView).Name}.xml"))
        End If
        With TryCast(sender, GridView)
            .ShowFindPanel()
            .OptionsView.EnableAppearanceOddRow = True
        End With
    End Sub

    Private Sub mnSimpanLayouts_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnSimpanLayouts.ItemClick
        mnSimpanLayouts.Enabled = False
        DataLayoutControl1.SaveLayoutToXml(IO.Path.Combine(Program.FolderApp, "System", "Layouts", $"{Me.Name}_{DataLayoutControl1.Name}.xml"))
        GridView1.SaveLayoutToXml(IO.Path.Combine(Program.FolderApp, "System", "Layouts", $"{Me.Name}_{GridView1.Name}.xml"))
        SearchLookUpEdit1View.SaveLayoutToXml(IO.Path.Combine(Program.FolderApp, "System", "Layouts", $"{Me.Name}_{SearchLookUpEdit1View.Name}.xml"))
        XtraMessageBox.Show("Berhasil disimpan.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        mnSimpanLayouts.Enabled = True
    End Sub

    Private Sub mnSimpan_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnSimpan.ItemClick
        mnSimpan.Enabled = False
        If (Me.Validate) Then
            Dim Result As Tuple(Of Boolean, String, Model.AssetDTo)

            If (PTipe = [Enum].PTipe.Create) Then
                Result = Rep.Create(Model)
            ElseIf (PTipe = [Enum].PTipe.Edit) Then
                Result = Rep.Update(Model)
            Else
                Result = New Tuple(Of Boolean, String, Model.AssetDTo)(False, "Tidak ada action", Nothing)
            End If

            If (Result.Item1) Then
                DialogResult = DialogResult.OK
                Me.Close()
            Else
                XtraMessageBox.Show(Result.Item2, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
        mnSimpan.Enabled = True
    End Sub

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        If Me.Validate() Then
            Dim dataValid = Model.DetailAssets.Where(Function(m)
                                                         Return m.tgl_perolehan >= DateTime.Parse("1900-01-01") OrElse String.IsNullOrEmpty(m.sumber) OrElse String.IsNullOrWhiteSpace(m.sumber) OrElse String.IsNullOrEmpty(m.kondisi) OrElse String.IsNullOrWhiteSpace(m.kondisi)
                                                     End Function)
            If (dataValid.Count = 0) Then
                GridView1.AddNewRow()

                ' Fokus ke baris baru
                Dim newRowHandle As Integer = GridView1.FocusedRowHandle
                If newRowHandle = DevExpress.XtraGrid.GridControl.NewItemRowHandle Then
                    ' Baris baru dalam mode editing langsung
                    GridView1.FocusedColumn = GridView1.VisibleColumns(0) ' Atau kolom yang ingin difokuskan
                    GridView1.ShowEditor()
                Else
                    ' Setelah baris benar-benar ditambahkan ke data source
                    GridView1.FocusedRowHandle = GridView1.RowCount - 1
                    GridView1.MakeRowVisible(GridView1.FocusedRowHandle)
                End If
            End If
        End If
    End Sub

    Private Sub cmdRemove_Click(sender As Object, e As EventArgs) Handles cmdRemove.Click
        If (Me.Validate AndAlso GridView1.FocusedRowHandle >= 0) Then
            Dim dialog = XtraMessageBox.Show("Yakin akan menghapus data detail asset yang telah dipilih?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If (dialog = DialogResult.Yes) Then
                GridView1.DeleteSelectedRows()
            End If
        End If
    End Sub
End Class