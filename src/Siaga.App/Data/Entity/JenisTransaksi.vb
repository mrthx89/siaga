Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace Data.Entity
    <Table("jenistransaksi")>
    Public Class JenisTransaksi
        <Key>
        Public Property id As Guid
        <MaxLength(50)>
        Public Property kd_jenis_transaksi As String
        <MaxLength(255)>
        Public Property nama_jenis_transaksi As String
        Public Overridable Property HistoryDetailAssets As ICollection(Of HistoryDetailAsset)
    End Class
End Namespace
