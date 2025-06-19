Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class Assets2
        Inherits DbMigration
    
        Public Overrides Sub Up()
            DropForeignKey("detailasset", "id", "asset")
            DropIndex("detailasset", New String() {"id"})
            AddColumn("detailasset", "id_asset", Function(c) c.Guid(nullable:=False))
            CreateIndex("detailasset", "id_asset")
            AddForeignKey("detailasset", "id_asset", "asset", "id", cascadeDelete:=True)
            DropColumn("detailasset", "kd_asset")
        End Sub

        Public Overrides Sub Down()
            AddColumn("detailasset", "kd_asset", Function(c) c.String(maxLength:=50, storeType:="nvarchar"))
            DropForeignKey("detailasset", "id_asset", "asset")
            DropIndex("detailasset", New String() {"id_asset"})
            DropColumn("detailasset", "id_asset")
            CreateIndex("detailasset", "id")
            AddForeignKey("detailasset", "id", "asset", "id")
        End Sub
    End Class
End Namespace
