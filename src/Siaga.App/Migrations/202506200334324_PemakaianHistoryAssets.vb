Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class PemakaianHistoryAssets
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "historydetailasset",
                Function(c) New With
                    {
                        .id = c.Guid(nullable:=False),
                        .id_ruangan = c.Guid(nullable:=False),
                        .id_detail_asset = c.Guid(nullable:=False),
                        .tgl_transaksi = c.DateTime(nullable:=False, precision:=0),
                        .id_transaksi = c.Guid(nullable:=False),
                        .id_jenis_transaksi = c.Guid(nullable:=False)
                    }) _
                .PrimaryKey(Function(t) t.id) _
                .ForeignKey("detailasset", Function(t) t.id_detail_asset, cascadeDelete:=True) _
                .ForeignKey("jenistransaksi", Function(t) t.id_jenis_transaksi, cascadeDelete:=True) _
                .ForeignKey("ruangan", Function(t) t.id_ruangan, cascadeDelete:=True) _
                .Index(Function(t) t.id_ruangan) _
                .Index(Function(t) t.id_detail_asset) _
                .Index(Function(t) t.id_jenis_transaksi)

            CreateTable(
                "jenistransaksi",
                Function(c) New With
                    {
                        .id = c.Guid(nullable:=False),
                        .kd_jenis_transaksi = c.String(maxLength:=50, storeType:="nvarchar"),
                        .nama_jenis_transaksi = c.String(maxLength:=255, storeType:="nvarchar")
                    }) _
                .PrimaryKey(Function(t) t.id) _
                .Index(Function(t) t.kd_jenis_transaksi, unique:=True, name:="ix_jenis_transaksi_kd_jenis_transaksi")

            CreateTable(
                "pemakaian",
                Function(c) New With
                    {
                        .id = c.Guid(nullable:=False),
                        .id_ruangan = c.Guid(nullable:=False),
                        .id_detail_asset = c.Guid(nullable:=False),
                        .tgl_mulai_pakai = c.DateTime(nullable:=False, precision:=0)
                    }) _
                .PrimaryKey(Function(t) t.id) _
                .ForeignKey("detailasset", Function(t) t.id_detail_asset, cascadeDelete:=True) _
                .ForeignKey("ruangan", Function(t) t.id_ruangan, cascadeDelete:=True) _
                .Index(Function(t) t.id_ruangan) _
                .Index(Function(t) t.id_detail_asset)

        End Sub

        Public Overrides Sub Down()
            DropForeignKey("pemakaian", "id_ruangan", "ruangan")
            DropForeignKey("pemakaian", "id_detail_asset", "detailasset")
            DropForeignKey("historydetailasset", "id_ruangan", "ruangan")
            DropForeignKey("historydetailasset", "id_jenis_transaksi", "jenistransaksi")
            DropForeignKey("historydetailasset", "id_detail_asset", "detailasset")
            DropIndex("pemakaian", New String() {"id_detail_asset"})
            DropIndex("pemakaian", New String() {"id_ruangan"})
            DropIndex("jenistransaksi", "ix_jenis_transaksi_kd_jenis_transaksi")
            DropIndex("historydetailasset", New String() {"id_jenis_transaksi"})
            DropIndex("historydetailasset", New String() {"id_detail_asset"})
            DropIndex("historydetailasset", New String() {"id_ruangan"})
            DropTable("pemakaian")
            DropTable("jenistransaksi")
            DropTable("historydetailasset")
        End Sub
    End Class
End Namespace
