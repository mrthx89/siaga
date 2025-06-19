Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace Data.Entity
    <Table("ruangan")>
    Public Class Ruangan
        <Key>
        Public Property id As Guid

        <MaxLength(50)>
        Public Property kd_ruangan As String

        <MaxLength(100)>
        Public Property nama_ruangan As String

        <MaxLength(255)>
        Public Property keterangan As String
    End Class
End Namespace