Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace Data.Entity
    <Table("historydetailasset")>
    Public Class HistoryDetailAsset
        <Key>
        Public Property id As Guid
        Public Property id_ruangan As Guid
        Public Property id_detail_asset As Guid
        Public Property tgl_transaksi As DateTime
        Public Property id_transaksi As Guid
        Public Property id_jenis_transaksi As Guid

        <ForeignKey("id_ruangan")>
        Public Overridable Property Ruangan As Ruangan
        <ForeignKey("id_detail_asset")>
        Public Overridable Property DetailAsset As DetailAsset
        <ForeignKey("id_jenis_transaksi")>
        Public Overridable Property JenisTransaksi As JenisTransaksi
    End Class
End Namespace