Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class Pemutihan
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "pemutihan",
                Function(c) New With
                    {
                        .id = c.Guid(nullable:=False),
                        .id_detail_asset = c.Guid(nullable:=False),
                        .tgl_pemutihan = c.DateTime(nullable:=False, precision:=0),
                        .alasan = c.String(maxLength:=255, storeType:="nvarchar"),
                        .keterangan = c.String(maxLength:=255, storeType:="nvarchar")
                    }) _
                .PrimaryKey(Function(t) t.id) _
                .ForeignKey("detailasset", Function(t) t.id_detail_asset, cascadeDelete:=True) _
                .Index(Function(t) t.id_detail_asset)

        End Sub

        Public Overrides Sub Down()
            DropForeignKey("pemutihan", "id_detail_asset", "detailasset")
            DropIndex("pemutihan", New String() {"id_detail_asset"})
            DropTable("pemutihan")
        End Sub
    End Class
End Namespace
