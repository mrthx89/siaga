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

        Public Property Penggunas As DbSet(Of Pengguna)

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
        End Sub
    End Class
End Namespace