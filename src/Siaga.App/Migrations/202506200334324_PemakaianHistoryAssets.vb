Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class PemakaianHistoryAssets
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.historydetailasset",
                Function(c) New With
                    {
                        .id = c.Guid(nullable := False),
                        .id_ruangan = c.Guid(nullable := False),
                        .id_detail_asset = c.Guid(nullable := False),
                        .tgl_transaksi = c.DateTime(nullable := False, precision := 0),
                        .id_transaksi = c.Guid(nullable := False),
                        .id_jenis_transaksi = c.Guid(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.id) _
                .ForeignKey("dbo.detailasset", Function(t) t.id_detail_asset, cascadeDelete := True) _
                .ForeignKey("dbo.jenistransaksi", Function(t) t.id_jenis_transaksi, cascadeDelete := True) _
                .ForeignKey("dbo.ruangan", Function(t) t.id_ruangan, cascadeDelete := True) _
                .Index(Function(t) t.id_ruangan) _
                .Index(Function(t) t.id_detail_asset) _
                .Index(Function(t) t.id_jenis_transaksi)
            
            CreateTable(
                "dbo.jenistransaksi",
                Function(c) New With
                    {
                        .id = c.Guid(nullable := False),
                        .kd_jenis_transaksi = c.String(maxLength := 50, storeType := "nvarchar"),
                        .nama_jenis_transaksi = c.String(maxLength := 255, storeType := "nvarchar")
                    }) _
                .PrimaryKey(Function(t) t.id) _
                .Index(Function(t) t.kd_jenis_transaksi, unique := True, name := "ix_jenis_transaksi_kd_jenis_transaksi")
            
            CreateTable(
                "dbo.pemakaian",
                Function(c) New With
                    {
                        .id = c.Guid(nullable := False),
                        .id_ruangan = c.Guid(nullable := False),
                        .id_detail_asset = c.Guid(nullable := False),
                        .tgl_mulai_pakai = c.DateTime(nullable := False, precision := 0)
                    }) _
                .PrimaryKey(Function(t) t.id) _
                .ForeignKey("dbo.detailasset", Function(t) t.id_detail_asset, cascadeDelete := True) _
                .ForeignKey("dbo.ruangan", Function(t) t.id_ruangan, cascadeDelete := True) _
                .Index(Function(t) t.id_ruangan) _
                .Index(Function(t) t.id_detail_asset)
            
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.pemakaian", "id_ruangan", "dbo.ruangan")
            DropForeignKey("dbo.pemakaian", "id_detail_asset", "dbo.detailasset")
            DropForeignKey("dbo.historydetailasset", "id_ruangan", "dbo.ruangan")
            DropForeignKey("dbo.historydetailasset", "id_jenis_transaksi", "dbo.jenistransaksi")
            DropForeignKey("dbo.historydetailasset", "id_detail_asset", "dbo.detailasset")
            DropIndex("dbo.pemakaian", New String() { "id_detail_asset" })
            DropIndex("dbo.pemakaian", New String() { "id_ruangan" })
            DropIndex("dbo.jenistransaksi", "ix_jenis_transaksi_kd_jenis_transaksi")
            DropIndex("dbo.historydetailasset", New String() { "id_jenis_transaksi" })
            DropIndex("dbo.historydetailasset", New String() { "id_detail_asset" })
            DropIndex("dbo.historydetailasset", New String() { "id_ruangan" })
            DropTable("dbo.pemakaian")
            DropTable("dbo.jenistransaksi")
            DropTable("dbo.historydetailasset")
        End Sub
    End Class
End Namespace
