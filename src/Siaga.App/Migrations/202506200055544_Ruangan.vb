Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class Ruangan
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.ruangan",
                Function(c) New With
                    {
                        .id = c.Guid(nullable := False),
                        .kd_ruangan = c.String(maxLength := 50, storeType := "nvarchar"),
                        .nama_ruangan = c.String(maxLength := 100, storeType := "nvarchar"),
                        .keterangan = c.String(maxLength := 255, storeType := "nvarchar")
                    }) _
                .PrimaryKey(Function(t) t.id) _
                .Index(Function(t) t.kd_ruangan, unique := True, name := "ix_ruangan_kd_ruangan")
            
        End Sub
        
        Public Overrides Sub Down()
            DropIndex("dbo.ruangan", "ix_ruangan_kd_ruangan")
            DropTable("dbo.ruangan")
        End Sub
    End Class
End Namespace
