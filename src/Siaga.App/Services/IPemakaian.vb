Namespace Services
    Public Interface IPemakaian
        Function GetAll(Filter As Model.FilterListPemakaian) As Tuple(Of Boolean, String, List(Of Model.PemakaianDTo))
        Function [Get](Id As Guid) As Tuple(Of Boolean, String, Model.PemakaianDTo)
        Function Create(Data As Data.Entity.Pemakaian) As Tuple(Of Boolean, String, Data.Entity.Pemakaian)
        Function Update(Data As Data.Entity.Pemakaian) As Tuple(Of Boolean, String, Data.Entity.Pemakaian)
        Function Delete(id As Guid) As Tuple(Of Boolean, String)
    End Interface
End Namespace
