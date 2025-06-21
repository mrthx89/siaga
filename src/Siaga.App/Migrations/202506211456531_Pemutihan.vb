Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class Pemutihan
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.pemutihan",
                Function(c) New With
                    {
                        .id = c.Guid(nullable := False),
                        .id_detail_asset = c.Guid(nullable := False),
                        .tgl_pemutihan = c.DateTime(nullable := False, precision := 0),
                        .alasan = c.String(maxLength := 255, storeType := "nvarchar"),
                        .keterangan = c.String(maxLength := 255, storeType := "nvarchar")
                    }) _
                .PrimaryKey(Function(t) t.id) _
                .ForeignKey("dbo.detailasset", Function(t) t.id_detail_asset, cascadeDelete := True) _
                .Index(Function(t) t.id_detail_asset)
            
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.pemutihan", "id_detail_asset", "dbo.detailasset")
            DropIndex("dbo.pemutihan", New String() { "id_detail_asset" })
            DropTable("dbo.pemutihan")
        End Sub
    End Class
End Namespace
