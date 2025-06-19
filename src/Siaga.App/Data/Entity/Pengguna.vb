Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace Data.Entity
    <Table("pengguna")>
    Public Class Pengguna
        <Key>
        Public Property id As Guid

        <MaxLength(50)>
        Public Property user As String

        <MaxLength(100)>
        Public Property nama As String

        <MaxLength(255)>
        Public Property password As String
    End Class
End Namespace