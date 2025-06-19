Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Migrations
Imports System.Linq

Namespace Migrations

    Friend NotInheritable Class Configuration
        Inherits DbMigrationsConfiguration(Of Data.ApplicationDbContext)

        Public Sub New()
            AutomaticMigrationsEnabled = False
        End Sub

        Protected Overrides Sub Seed(context As Data.ApplicationDbContext)
            '  This method will be called after migrating to the latest version.

            '  You can use the DbSet(Of T).AddOrUpdate() helper extension method
            '  to avoid creating duplicate seed data.

            SeedData(context)
        End Sub

        ' ✅ Tambahkan method public shared
        Public Shared Sub SeedData(context As Data.ApplicationDbContext)
            ' Seeder manual
            If Not context.Penggunas.Any(Function(p) p.user = "admin") Then
                context.Penggunas.AddOrUpdate(
                Function(p) p.user, ' digunakan sebagai identifikasi unik
                New Data.Entity.Pengguna With {
                    .id = Guid.NewGuid(),
                    .user = "admin",
                    .nama = "Administrator",
                    .password = Utils.Utils.HashPassword("123456") ' idealnya ini di-hash
                }
            )
            End If
        End Sub
    End Class

End Namespace
