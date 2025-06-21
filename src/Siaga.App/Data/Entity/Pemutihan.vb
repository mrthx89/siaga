Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace Data.Entity
    <Table("pemutihan")>
    Public Class Pemutihan
        <Key>
        Public Property id As Guid
        Public Property id_detail_asset As Guid
        Public Property tgl_pemutihan As DateTime
        <MaxLength(255)>
        Public Property alasan As String
        <MaxLength(255)>
        Public Property keterangan As String

        <ForeignKey("id_detail_asset")>
        Public Overridable Property DetailAsset As DetailAsset
    End Class
End Namespace
