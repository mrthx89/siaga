Imports Siaga.App.Data.Entity
Imports Siaga.App.Services
Imports Siaga.App.Data
Imports DevExpress.XtraEditors
Imports DevExpress.Utils
Imports Serilog

Namespace Repository
    Public Class KategoriAsset
        Implements IKategoriAsset

        Public ReadOnly DbContext As New Data.ApplicationDbContext()

        Public Function GetAll() As Tuple(Of Boolean, String, List(Of Entity.KategoriAsset)) Implements IKategoriAsset.GetAll
            Dim hasil As New Tuple(Of Boolean, String, List(Of Entity.KategoriAsset))(False, String.Empty, Nothing)
            Using dlg As New WaitDialogForm("Sedang merefresh data ...", "Mohon tunggu sebentar")
                Try
                    Dim result = DbContext.KategoriAssets.ToList()
                    hasil = New Tuple(Of Boolean, String, List(Of Entity.KategoriAsset))(True, "Data ditemukan", result)
                Catch ex As Exception
                    Log.Error(ex, "Error : " & ex.Message)
                    XtraMessageBox.Show("Info Kesalahan : " & ex.Message, Application.ProductName)
                End Try
            End Using
            Return hasil
        End Function

        Public Function [Get](Id As Guid) As Tuple(Of Boolean, String, Entity.KategoriAsset) Implements IKategoriAsset.Get
            Throw New NotImplementedException()
        End Function

        Public Function FindByKode(Kode As String) As Tuple(Of Boolean, String, List(Of Entity.KategoriAsset)) Implements IKategoriAsset.FindByKode
            Throw New NotImplementedException()
        End Function

        Public Function Create(Data As Entity.KategoriAsset) As Tuple(Of Boolean, String, Entity.KategoriAsset) Implements IKategoriAsset.Create
            Throw New NotImplementedException()
        End Function

        Public Function Update(Data As Entity.KategoriAsset) As Tuple(Of Boolean, String, Entity.KategoriAsset) Implements IKategoriAsset.Update
            Throw New NotImplementedException()
        End Function

        Public Function Delete(Data As Entity.KategoriAsset) As Tuple(Of Boolean, String) Implements IKategoriAsset.Delete
            Throw New NotImplementedException()
        End Function
    End Class
End Namespace
