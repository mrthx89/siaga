Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class InitialCreate
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "pengguna",
                Function(c) New With
                    {
                        .id = c.Guid(nullable:=False),
                        .user = c.String(maxLength:=50, storeType:="varchar"),
                        .nama = c.String(maxLength:=100, storeType:="varchar"),
                        .password = c.String(maxLength:=255, storeType:="varchar")
                    }) _
                .PrimaryKey(Function(t) t.id) _
                .Index(Function(t) t.user, unique:=True, name:="ix_pengguna_user")

            CreateTable(
                "kategoriasset",
                Function(c) New With
                    {
                        .id = c.Guid(nullable:=False),
                        .kd_kategori = c.String(maxLength:=50, storeType:="varchar"),
                        .nama_kategori = c.String(maxLength:=100, storeType:="varchar"),
                        .keterangan = c.String(maxLength:=255, storeType:="varchar")
                    }) _
                .PrimaryKey(Function(t) t.id) _
                .Index(Function(t) t.kd_kategori, unique:=True, name:="ix_kategoriasset_kd_kategori")

        End Sub
        
        Public Overrides Sub Down()
            DropIndex("kategoriasset", "ix_kategoriasset_kd_kategori")
            DropIndex("pengguna", "ix_pengguna_user")
            DropTable("kategoriasset")
            DropTable("pengguna")
        End Sub
    End Class
End Namespace
