Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class AssetsRevisi
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("detailasset", "barcode", Function(c) c.String(maxLength:=50, storeType:="nvarchar"))
            CreateIndex("detailasset", "barcode", unique:=True, name:="ix_detail_asset_barcode")
            DropColumn("detailasset", "kd_detail")
            DropColumn("detailasset", "nama_asset")
        End Sub

        Public Overrides Sub Down()
            AddColumn("detailasset", "nama_asset", Function(c) c.String(maxLength:=100, storeType:="nvarchar"))
            AddColumn("detailasset", "kd_detail", Function(c) c.String(maxLength:=50, storeType:="nvarchar"))
            DropIndex("detailasset", "ix_detail_asset_barcode")
            DropColumn("detailasset", "barcode")
        End Sub
    End Class
End Namespace
