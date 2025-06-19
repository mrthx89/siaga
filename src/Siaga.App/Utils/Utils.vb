Imports System.Security.Cryptography
Imports System.Text

Namespace Utils
    Public Class Utils
        Private Shared Salt As String = "Th3Str0nger@Passw0RD"
        Public Shared Function HashPassword(StringData As String) As String
            Using sha256 As SHA256 = SHA256.Create()
                Dim bytes As Byte() = Encoding.UTF8.GetBytes(StringData & Salt)
                Dim hash As Byte() = sha256.ComputeHash(bytes)
                Return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant()
            End Using
        End Function
    End Class
End Namespace
