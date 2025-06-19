Namespace Services
    Public Interface IKategoriAsset
        Function GetAll() As Tuple(Of Boolean, String, List(Of Data.Entity.KategoriAsset))
        Function [Get](Id As Guid) As Tuple(Of Boolean, String, Data.Entity.KategoriAsset)
        Function FindByKode(Kode As String) As Tuple(Of Boolean, String, List(Of Data.Entity.KategoriAsset))
        Function Create(Data As Data.Entity.KategoriAsset) As Tuple(Of Boolean, String, Data.Entity.KategoriAsset)
        Function Update(Data As Data.Entity.KategoriAsset) As Tuple(Of Boolean, String, Data.Entity.KategoriAsset)
        Function Delete(Data As Data.Entity.KategoriAsset) As Tuple(Of Boolean, String)
    End Interface
End Namespace
