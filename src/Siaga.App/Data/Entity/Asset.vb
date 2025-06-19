Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace Data.Entity
    <Table("asset")>
    Public Class Asset
        <Key>
        Public Property id As Guid

        <MaxLength(50)>
        Public Property kd_asset As String

        <MaxLength(100)>
        Public Property nama_asset As String

        <MaxLength(50)>
        Public Property kd_kategori As String

        <MaxLength(255)>
        Public Property keterangan As String

        ' ✅ Relasi ke KategoriAsset (Foreign Key)
        <ForeignKey("kd_kategori")>
        Public Overridable Property KategoriAsset As KategoriAsset

        Public Overridable Property DetailAssets As ICollection(Of DetailAsset)
    End Class
End Namespace
