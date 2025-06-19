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

        ' Optional: Navigasi balik (One-to-Many)
        Public Overridable Property Assets As ICollection(Of Asset)
    End Class
End Namespace