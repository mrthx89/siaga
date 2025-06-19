Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class Assets
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "asset",
                Function(c) New With
                    {
                        .id = c.Guid(nullable:=False),
                        .kd_asset = c.String(maxLength:=50, storeType:="nvarchar"),
                        .nama_asset = c.String(maxLength:=100, storeType:="nvarchar"),
                        .id_kategori = c.Guid(nullable:=False),
                        .keterangan = c.String(maxLength:=255, storeType:="nvarchar")
                    }) _
                .PrimaryKey(Function(t) t.id) _
                .ForeignKey("kategoriasset", Function(t) t.id_kategori, cascadeDelete:=True) _
                .Index(Function(t) t.kd_asset, unique:=True, name:="ix_asset_kd_asset") _
                .Index(Function(t) t.id_kategori)

            CreateTable(
                "detailasset",
                Function(c) New With
                    {
                        .id = c.Guid(nullable:=False),
                        .kd_asset = c.String(maxLength:=50, storeType:="nvarchar"),
                        .kd_detail = c.String(maxLength:=50, storeType:="nvarchar"),
                        .nama_asset = c.String(maxLength:=100, storeType:="nvarchar"),
                        .tgl_perolehan = c.DateTime(nullable:=False, precision:=0),
                        .sumber = c.String(maxLength:=255, storeType:="nvarchar"),
                        .harga_beli = c.Decimal(nullable:=False, precision:=18, scale:=2),
                        .kondisi = c.String(maxLength:=255, storeType:="nvarchar")
                    }) _
                .PrimaryKey(Function(t) t.id) _
                .ForeignKey("asset", Function(t) t.id) _
                .Index(Function(t) t.id)

        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("asset", "id_kategori", "kategoriasset")
            DropForeignKey("detailasset", "id", "asset")
            DropIndex("detailasset", New String() {"id"})
            DropIndex("asset", New String() {"id_kategori"})
            DropIndex("asset", "ix_asset_kd_asset")
            DropTable("detailasset")
            DropTable("asset")
        End Sub
    End Class
End Namespace
