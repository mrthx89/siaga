Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace Data.Entity
    <Table("kategoriasset")>
    Public Class KategoriAsset
        <Key>
        Public Property id As Guid

        <MaxLength(50)>
        Public Property kd_kategori As String

        <MaxLength(100)>
        Public Property nama_kategori As String

        <MaxLength(255)>
        Public Property keterangan As String
    End Class
End Namespace