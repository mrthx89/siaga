Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure.Annotations
Imports MySql.Data.EntityFramework
Imports Siaga.App.Data.Entity

Namespace Data
    <DbConfigurationType(GetType(MySql.Data.EntityFramework.MySqlEFConfiguration))>
    Public Class ApplicationDbContext
        Inherits DbContext

        Public Sub New()
            ' Name=DefaultConnection mengacu pada nama di app.config
            MyBase.New("name=DefaultConnection")
        End Sub

        Public Property Assets As DbSet(Of Asset)

        Public Property KategoriAssets As DbSet(Of KategoriAsset)

        Public Property Penggunas As DbSet(Of Pengguna)

        Public Property Ruangans As DbSet(Of Ruangan)

        Public Property Pemakaians As DbSet(Of Pemakaian)

        Public Property HistoryDetailAssets As DbSet(Of HistoryDetailAsset)

        Public Property JenisTransaksies As DbSet(Of JenisTransaksi)

        Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
            MyBase.OnModelCreating(modelBuilder)
            ' Konfigurasi tambahan jika perlu

            modelBuilder.Entity(Of Pengguna)() _
                .Property(Function(p) p.user) _
                .HasColumnAnnotation(
                    "Index",
                    New IndexAnnotation(New IndexAttribute("ix_pengguna_user") With {.IsUnique = True})
                )

            modelBuilder.Entity(Of KategoriAsset)() _
                .Property(Function(p) p.kd_kategori) _
                .HasColumnAnnotation(
                    "Index",
                    New IndexAnnotation(New IndexAttribute("ix_kategoriasset_kd_kategori") With {.IsUnique = True})
                )

            modelBuilder.Entity(Of Asset)() _
                .Property(Function(p) p.kd_asset) _
                .HasColumnAnnotation(
                    "Index",
                    New IndexAnnotation(New IndexAttribute("ix_asset_kd_asset") With {.IsUnique = True})
                )

            modelBuilder.Entity(Of Ruangan)() _
                .Property(Function(p) p.kd_ruangan) _
                .HasColumnAnnotation(
                    "Index",
                    New IndexAnnotation(New IndexAttribute("ix_ruangan_kd_ruangan") With {.IsUnique = True})
                )

            modelBuilder.Entity(Of JenisTransaksi)() _
                .Property(Function(p) p.kd_jenis_transaksi) _
                .HasColumnAnnotation(
                    "Index",
                    New IndexAnnotation(New IndexAttribute("ix_jenis_transaksi_kd_jenis_transaksi") With {.IsUnique = True})
                )
        End Sub
    End Class
End Namespace