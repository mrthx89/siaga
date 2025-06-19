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

        Public Property id_kategori As Guid

        <MaxLength(255)>
        Public Property keterangan As String

        ' ✅ Relasi ke KategoriAsset (Foreign Key)
        <ForeignKey("id_kategori")>
        Public Overridable Property KategoriAsset As KategoriAsset

        Public Overridable Property DetailAssets As ICollection(Of DetailAsset)
    End Class
End Namespace
