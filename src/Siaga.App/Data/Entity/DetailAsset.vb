Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace Data.Entity
    <Table("detailasset")>
    Public Class DetailAsset
        <Key>
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

        ' ✅ Relasi ke Asset (Foreign Key)
        <ForeignKey("id_asset")>
        Public Overridable Property Asset As Asset

        Public Overridable Property Pemakaians As ICollection(Of Pemakaian)
        Public Overridable Property Pemutihans As ICollection(Of Pemutihan)
        Public Overridable Property HistoryDetailAssets As ICollection(Of HistoryDetailAsset)
    End Class
End Namespace
