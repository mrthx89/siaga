Namespace Services
    Public Interface IPengguna
        Function GetLogin(UserId As String, Password As String) As Tuple(Of Boolean, String, Data.Entity.Pengguna)
        Function GetUser(Id As Guid) As Tuple(Of Boolean, String, Data.Entity.Pengguna)
        Function GetUsers() As Tuple(Of Boolean, String, List(Of Data.Entity.Pengguna))
    End Interface
End Namespace
