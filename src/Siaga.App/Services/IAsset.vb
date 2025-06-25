Namespace Services
    Public Interface IAsset
        Function GetAll() As Tuple(Of Boolean, String, List(Of Model.AssetDTo))
        Function [Get](Id As Guid) As Tuple(Of Boolean, String, Model.AssetDTo)
        Function FindByKode(Kode As String) As Tuple(Of Boolean, String, Model.AssetDTo)
        Function Create(Data As Model.AssetDTo) As Tuple(Of Boolean, String, Model.AssetDTo)
        Function Update(Data As Model.AssetDTo) As Tuple(Of Boolean, String, Model.AssetDTo)
        Function Delete(Data As Model.AssetDTo) As Tuple(Of Boolean, String)
        Function LookUp(id As Guid) As Tuple(Of Boolean, String, List(Of Model.DetilAssetLookUpDTo))
    End Interface
End Namespace
