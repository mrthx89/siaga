Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace Data.Entity
    <Table("detailasset")>
    Public Class DetailAsset
        <Key>
        Public Property id As Guid

        <MaxLength(50)>
        Public Property kd_asset As String

        <MaxLength(50)>
        Public Property kd_detail As String

        <MaxLength(100)>
        Public Property nama_asset As String

        Public Property tgl_perolehan As DateTime

        <MaxLength(255)>
        Public Property sumber As String

        <Range(0, Decimal.MaxValue)>
        Public Property harga_beli As Decimal

        <MaxLength(255)>
        Public Property kondisi As String

        ' ✅ Relasi ke KategoriAsset (Foreign Key)
        <ForeignKey("kd_asset")>
        Public Overridable Property Asset As Asset
    End Class
End Namespace
