Imports DevExpress.XtraEditors
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmEntriPemutihan
    Public Property Model As Data.Entity.Pemutihan
    Public Property PTipe As [Enum].PTipe

    Private ReadOnly Rep As Services.IPemutihan = New Repository.Pemutihan()
    Private ReadOnly RepAsset As Services.IAsset = New Repository.Asset()

    Public Sub New(PTipe As [Enum].PTipe, Model As Data.Entity.Pemutihan)

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

    Private Sub frmEntriPemutihan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (PTipe = [Enum].PTipe.Create) Then
            Model = New Data.Entity.Pemutihan With {
                .id = Guid.NewGuid,
                .id_detail_asset = Guid.Empty,
                .tgl_pemutihan = DateTime.Now.Date,
                .alasan = String.Empty,
                .keterangan = String.Empty}
        Else
            'Get Data
            Dim Result = Rep.Get(Model.id)
            If (Result.Item1) Then
                Model = New Data.Entity.Pemutihan With {
                    .id = Result.Item3.id,
                    .id_detail_asset = Result.Item3.id_detail_asset,
                    .tgl_pemutihan = Result.Item3.tgl_pemutihan,
                    .alasan = Result.Item3.alasan,
                    .keterangan = Result.Item3.keterangan}
            Else
                XtraMessageBox.Show(Result.Item2, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                DialogResult = DialogResult.Abort
                Me.Close()
            End If
        End If

        'Show Data
        PemutihanBindingSource.DataSource = Model

        'DataSource Perlu Data Awal
        Dim hasilAsset = RepAsset.LookUp(Model.id_detail_asset)
        Dim listAsset = (From x In If(hasilAsset.Item1, hasilAsset.Item3, New List(Of Model.DetilAssetLookUpDTo)())
                         Select x)
        id_detail_assetSearchLookUpEdit.Properties.DataSource = listAsset.ToList()
        id_detail_assetSearchLookUpEdit.Properties.ValueMember = "ID"
        id_detail_assetSearchLookUpEdit.Properties.DisplayMember = "Barcode"

        If (IO.File.Exists(IO.Path.Combine(Program.FolderApp, "System", "Layouts", $"{Me.Name}_{DataLayoutControl1.Name}.xml"))) Then
            DataLayoutControl1.RestoreLayoutFromXml(IO.Path.Combine(Program.FolderApp, "System", "Layouts", $"{Me.Name}_{DataLayoutControl1.Name}.xml"))
        End If
    End Sub

    Private Sub mnSimpanLayouts_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnSimpanLayouts.ItemClick
        mnSimpanLayouts.Enabled = False
        DataLayoutControl1.SaveLayoutToXml(IO.Path.Combine(Program.FolderApp, "System", "Layouts", $"{Me.Name}_{DataLayoutControl1.Name}.xml"))
        gvDetailAsset.SaveLayoutToXml(IO.Path.Combine(Program.FolderApp, "System", "Layouts", $"{Me.Name}_{gvDetailAsset.Name}.xml"))
        XtraMessageBox.Show("Berhasil disimpan.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        mnSimpanLayouts.Enabled = True
    End Sub

    Private Sub GridView1_DataSourceChange(sender As Object, e As EventArgs) Handles gvDetailAsset.DataSourceChanged
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
            Dim Result As Tuple(Of Boolean, String, Data.Entity.Pemutihan)

            If (PTipe = [Enum].PTipe.Create) Then
                Result = Rep.Create(Model)
            ElseIf (PTipe = [Enum].PTipe.Edit) Then
                Result = Rep.Update(Model)
            Else
                Result = New Tuple(Of Boolean, String, Data.Entity.Pemutihan)(False, "Tidak ada action", Nothing)
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