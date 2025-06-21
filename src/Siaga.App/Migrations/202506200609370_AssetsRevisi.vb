Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class AssetsRevisi
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.detailasset", "barcode", Function(c) c.String(maxLength := 50, storeType := "nvarchar"))
            CreateIndex("dbo.detailasset", "barcode", unique := True, name := "ix_detail_asset_barcode")
            DropColumn("dbo.detailasset", "kd_detail")
            DropColumn("dbo.detailasset", "nama_asset")
        End Sub
        
        Public Overrides Sub Down()
            AddColumn("dbo.detailasset", "nama_asset", Function(c) c.String(maxLength := 100, storeType := "nvarchar"))
            AddColumn("dbo.detailasset", "kd_detail", Function(c) c.String(maxLength := 50, storeType := "nvarchar"))
            DropIndex("dbo.detailasset", "ix_detail_asset_barcode")
            DropColumn("dbo.detailasset", "barcode")
        End Sub
    End Class
End Namespace
