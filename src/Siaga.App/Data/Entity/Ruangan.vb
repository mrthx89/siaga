﻿Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace Data.Entity
    <Table("ruangan")>
    Public Class Ruangan
        <Key>
        Public Property id As Guid

        <MaxLength(50)>
        Public Property kd_ruangan As String

        <MaxLength(100)>
        Public Property nama_ruangan As String

        <MaxLength(255)>
        Public Property keterangan As String

        Public Overridable Property Pemakaians As ICollection(Of Pemakaian)
        Public Overridable Property HistoryDetailAssets As ICollection(Of HistoryDetailAsset)
    End Class
End Namespace