Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace Model
    Public Class AssetDTo
        Public Property id As Guid

        <MaxLength(50)>
        Public Property kd_asset As String

        <MaxLength(100)>
        Public Property nama_asset As String

        Public Property id_kategori As Guid

        Public Property nama_kategori As String

        <MaxLength(255)>
        Public Property keterangan As String

        Public Property DetailAssets As List(Of DetilAssetDTo)
    End Class

    Public Class DetilAssetDTo
        Public Property id As Guid

        Public Property id_asset As Guid

        <MaxLength(50)>
        Public Property barcode As String

        Public Property tgl_perolehan As DateTime

        <MaxLength(255)>
        Public Property sumber As String

        <Range(0, Decimal.MaxValue)>
        Public Property harga_beli As Decimal

        <MaxLength(255)>
        Public Property kondisi As String
    End Class
End Namespace
