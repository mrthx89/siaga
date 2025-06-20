Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace Data.Entity
    <Table("pemakaian")>
    Public Class Pemakaian
        <Key>
        Public Property id As Guid
        Public Property id_ruangan As Guid
        Public Property id_detail_asset As Guid
        Public Property tgl_mulai_pakai As DateTime

        <ForeignKey("id_ruangan")>
        Public Overridable Property Ruangan As Ruangan
        <ForeignKey("id_detail_asset")>
        Public Overridable Property DetailAsset As DetailAsset
    End Class
End Namespace
