Imports System.ComponentModel.DataAnnotations

Namespace Model
    Public Class PemutihanDTo
        Public Property id As Guid
        Public Property id_ruangan As Guid
        Public Property id_detail_asset As Guid
        Public Property detail_asset As String
        Public Property tgl_pemutihan As DateTime
        Public Property id_asset As Guid
        Public Property asset As String
        Public Property kategori_asset As String
        <MaxLength(255)>
        Public Property alasan As String
        <MaxLength(255)>
        Public Property keterangan As String
    End Class
End Namespace
