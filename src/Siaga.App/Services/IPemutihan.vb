Namespace Services
    Public Interface IPemutihan
        Function GetAll(Filter As Model.FilterListPemutihan) As Tuple(Of Boolean, String, List(Of Model.PemutihanDTo))
        Function [Get](Id As Guid) As Tuple(Of Boolean, String, Model.PemutihanDTo)
        Function Create(Data As Data.Entity.Pemutihan) As Tuple(Of Boolean, String, Data.Entity.Pemutihan)
        Function Update(Data As Data.Entity.Pemutihan) As Tuple(Of Boolean, String, Data.Entity.Pemutihan)
        Function Delete(id As Guid) As Tuple(Of Boolean, String)
    End Interface
End Namespace