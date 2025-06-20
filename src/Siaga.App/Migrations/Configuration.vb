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
            If Not context.Penggunas.Any(Function(p) p.user.ToLower() = "admin".ToLower()) Then
                context.Penggunas.AddOrUpdate(
                    Function(p) p.user, ' digunakan sebagai identifikasi unik
                    New Data.Entity.Pengguna With {
                        .id = Guid.NewGuid(),
                        .user = "admin",
                        .nama = "Administrator",
                        .password = Utils.Utils.HashPassword("123456".ToUpper()) ' idealnya ini di-hash
                    }
                )
            End If

            If Not context.JenisTransaksies.Any(Function(p) p.kd_jenis_transaksi.ToLower() = "perolehan".ToLower()) Then
                context.JenisTransaksies.AddOrUpdate(
                    Function(p) p.kd_jenis_transaksi, ' digunakan sebagai identifikasi unik
                    New Data.Entity.JenisTransaksi With {
                        .id = Guid.Parse("AD51B143-C560-48D3-B0C3-362357C086EC"),
                        .kd_jenis_transaksi = "Perolehan",
                        .nama_jenis_transaksi = "Perolehan"
                    }
                )
            End If

            If Not context.JenisTransaksies.Any(Function(p) p.kd_jenis_transaksi.ToLower() = "pemindahan".ToLower()) Then
                context.JenisTransaksies.AddOrUpdate(
                    Function(p) p.kd_jenis_transaksi, ' digunakan sebagai identifikasi unik
                    New Data.Entity.JenisTransaksi With {
                        .id = Guid.Parse("BE949D30-CEAF-45DF-A20A-08211AA6B63C"),
                        .kd_jenis_transaksi = "Pemindahan",
                        .nama_jenis_transaksi = "Pemindahan"
                    }
                )
            End If

            If Not context.JenisTransaksies.Any(Function(p) p.kd_jenis_transaksi.ToLower() = "pemutihan".ToLower()) Then
                context.JenisTransaksies.AddOrUpdate(
                    Function(p) p.kd_jenis_transaksi, ' digunakan sebagai identifikasi unik
                    New Data.Entity.JenisTransaksi With {
                        .id = Guid.Parse("2C16583E-AC38-46BF-A6EA-1BEA3E8A1A6E"),
                        .kd_jenis_transaksi = "Pemutihan",
                        .nama_jenis_transaksi = "Pemutihan"
                    }
                )
            End If
        End Sub
    End Class

End Namespace
