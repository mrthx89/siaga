Imports DevExpress.XtraEditors
Imports DevExpress.Utils

Public Class frmEntriRuangan
    Public Property Model As Data.Entity.Ruangan
    Public Property PTipe As [Enum].PTipe

    Private ReadOnly Rep As Services.IRuangan = New Repository.Ruangan()

    Public Sub New(PTipe As [Enum].PTipe, Model As Data.Entity.Ruangan)

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

    Private Sub frmEntriRuangan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (PTipe = [Enum].PTipe.Create) Then
            Model = New Data.Entity.Ruangan With {
                .id = Guid.NewGuid,
                .kd_ruangan = String.Empty,
                .nama_ruangan = String.Empty,
                .keterangan = String.Empty}
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
        RuanganBindingSource.DataSource = Model

        If (IO.File.Exists(IO.Path.Combine(Program.FolderApp, "System", "Layouts", $"{Me.Name}_{DataLayoutControl1.Name}.xml"))) Then
            DataLayoutControl1.RestoreLayoutFromXml(IO.Path.Combine(Program.FolderApp, "System", "Layouts", $"{Me.Name}_{DataLayoutControl1.Name}.xml"))
        End If
    End Sub

    Private Sub mnSimpanLayouts_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnSimpanLayouts.ItemClick
        mnSimpanLayouts.Enabled = False
        DataLayoutControl1.SaveLayoutToXml(IO.Path.Combine(Program.FolderApp, "System", "Layouts", $"{Me.Name}_{DataLayoutControl1.Name}.xml"))
        XtraMessageBox.Show("Berhasil disimpan.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        mnSimpanLayouts.Enabled = True
    End Sub

    Private Sub mnSimpan_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnSimpan.ItemClick
        mnSimpan.Enabled = False
        If (Me.Validate) Then
            Dim Result As Tuple(Of Boolean, String, Data.Entity.Ruangan)

            If (PTipe = [Enum].PTipe.Create) Then
                Result = Rep.Create(Model)
            ElseIf (PTipe = [Enum].PTipe.Edit) Then
                Result = Rep.Update(Model)
            Else
                Result = New Tuple(Of Boolean, String, Data.Entity.Ruangan)(False, "Tidak ada action", Nothing)
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