Namespace Services
    Public Interface IRuangan
        Function GetAll() As Tuple(Of Boolean, String, List(Of Data.Entity.Ruangan))
        Function [Get](Id As Guid) As Tuple(Of Boolean, String, Data.Entity.Ruangan)
        Function FindByKode(Kode As String) As Tuple(Of Boolean, String, Data.Entity.Ruangan)
        Function Create(Data As Data.Entity.Ruangan) As Tuple(Of Boolean, String, Data.Entity.Ruangan)
        Function Update(Data As Data.Entity.Ruangan) As Tuple(Of Boolean, String, Data.Entity.Ruangan)
        Function Delete(Data As Data.Entity.Ruangan) As Tuple(Of Boolean, String)
    End Interface
End Namespace
