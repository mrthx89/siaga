Imports DevExpress.XtraEditors
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmEntriPemakaian
    Public Property Model As Data.Entity.Pemakaian
    Public Property PTipe As [Enum].PTipe

    Private ReadOnly Rep As Services.IPemakaian = New Repository.Pemakaian()
    Private ReadOnly RepRuangan As Services.IRuangan = New Repository.Ruangan()
    Private ReadOnly RepAsset As Services.IAsset = New Repository.Asset()

    Public Sub New(PTipe As [Enum].PTipe, Model As Data.Entity.Pemakaian)

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

    Private Sub frmEntriPemakaian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim hasilRuangan = RepRuangan.GetAll(False)
        Dim listRuangan = From x In If(hasilRuangan.Item1, hasilRuangan.Item3, New List(Of Data.Entity.Ruangan))
                          Select New With {.ID = x.id, .Kode = x.kd_ruangan, .Nama = x.nama_ruangan}
        id_ruanganSearchLookUpEdit.Properties.DataSource = listRuangan.ToList()
        id_ruanganSearchLookUpEdit.Properties.ValueMember = "ID"
        id_ruanganSearchLookUpEdit.Properties.DisplayMember = "Nama"

        Dim IDDetilAsset As Guid
        Guid.TryParse(If(id_detail_assetSearchLookUpEdit.EditValue IsNot Nothing, id_detail_assetSearchLookUpEdit.ToString(), String.Empty), IDDetilAsset)
        Dim hasilAsset = RepAsset.LookUp(IDDetilAsset)
        Dim listAsset = (From x In If(hasilAsset.Item1, hasilAsset.Item3, New List(Of Model.DetilAssetLookUpDTo)())
                         Select x)
        id_detail_assetSearchLookUpEdit.Properties.DataSource = listAsset.ToList()
        id_detail_assetSearchLookUpEdit.Properties.ValueMember = "ID"
        id_detail_assetSearchLookUpEdit.Properties.DisplayMember = "Barcode"

        If (PTipe = [Enum].PTipe.Create) Then
            Model = New Data.Entity.Pemakaian With {
                .id = Guid.NewGuid,
                .id_ruangan = Guid.Empty,
                .id_detail_asset = Guid.Empty,
                .tgl_mulai_pakai = DateTime.Now.Date}
        Else
            'Get Data
            Dim Result = Rep.Get(Model.id)
            If (Result.Item1) Then
                Model = New Data.Entity.Pemakaian With {
                    .id = Result.Item3.id,
                    .id_detail_asset = Result.Item3.id_detail_asset,
                    .id_ruangan = Result.Item3.id_ruangan,
                    .tgl_mulai_pakai = Result.Item3.tgl_mulai_pakai}
            Else
                XtraMessageBox.Show(Result.Item2, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                DialogResult = DialogResult.Abort
                Me.Close()
            End If
        End If

        'Show Data
        PemakaianBindingSource.DataSource = Model

        If (IO.File.Exists(IO.Path.Combine(Program.FolderApp, "System", "Layouts", $"{Me.Name}_{DataLayoutControl1.Name}.xml"))) Then
            DataLayoutControl1.RestoreLayoutFromXml(IO.Path.Combine(Program.FolderApp, "System", "Layouts", $"{Me.Name}_{DataLayoutControl1.Name}.xml"))
        End If
    End Sub

    Private Sub mnSimpanLayouts_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnSimpanLayouts.ItemClick
        mnSimpanLayouts.Enabled = False
        DataLayoutControl1.SaveLayoutToXml(IO.Path.Combine(Program.FolderApp, "System", "Layouts", $"{Me.Name}_{DataLayoutControl1.Name}.xml"))
        gvDetailAsset.SaveLayoutToXml(IO.Path.Combine(Program.FolderApp, "System", "Layouts", $"{Me.Name}_{gvDetailAsset.Name}.xml"))
        gvRuangan.SaveLayoutToXml(IO.Path.Combine(Program.FolderApp, "System", "Layouts", $"{Me.Name}_{gvRuangan.Name}.xml"))
        XtraMessageBox.Show("Berhasil disimpan.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        mnSimpanLayouts.Enabled = True
    End Sub

    Private Sub GridView1_DataSourceChange(sender As Object, e As EventArgs) Handles gvDetailAsset.DataSourceChanged, gvRuangan.DataSourceChanged
        If (IO.File.Exists(IO.Path.Combine(Program.FolderApp, "System", "Layouts", $"{Me.Name}_{TryCast(sender, GridView).Name}.xml"))) Then
            TryCast(sender, GridView).RestoreLayoutFromXml(IO.Path.Combine(Program.FolderApp, "System", "Layouts", $"{Me.Name}_{TryCast(sender, GridView).Name}.xml"))
        End If
        With TryCast(sender, GridView)
            .ShowFindPanel()
            .OptionsView.EnableAppearanceOddRow = True
        End With
    End Sub

    Private Sub mnSimpan_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnSimpan.ItemClick
        mnSimpan.Enabled = False
        If (Me.Validate) Then
            Dim Result As Tuple(Of Boolean, String, Data.Entity.Pemakaian)

            If (PTipe = [Enum].PTipe.Create) Then
                Result = Rep.Create(Model)
            ElseIf (PTipe = [Enum].PTipe.Edit) Then
                Result = Rep.Update(Model)
            Else
                Result = New Tuple(Of Boolean, String, Data.Entity.Pemakaian)(False, "Tidak ada action", Nothing)
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
End Class