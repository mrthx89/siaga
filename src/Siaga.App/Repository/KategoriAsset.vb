Imports Siaga.App.Data.Entity
Imports Siaga.App.Services
Imports Siaga.App.Data
Imports DevExpress.XtraEditors
Imports DevExpress.Utils
Imports Serilog

Namespace Repository
    Public Class KategoriAsset
        Implements IKategoriAsset

        Public ReadOnly DbContext As New Data.ApplicationDbContext()

        Public Function GetAll() As Tuple(Of Boolean, String, List(Of Entity.KategoriAsset)) Implements IKategoriAsset.GetAll
            Dim hasil As New Tuple(Of Boolean, String, List(Of Entity.KategoriAsset))(False, String.Empty, Nothing)
            Using dlg As New WaitDialogForm("Sedang merefresh data ...", "Mohon tunggu sebentar")
                Try
                    Dim result = DbContext.KategoriAssets.AsNoTracking.ToList()
                    hasil = New Tuple(Of Boolean, String, List(Of Entity.KategoriAsset))(True, "Data ditemukan", result)
                Catch ex As Exception
                    Log.Error(ex, "Error : " & ex.Message)
                    XtraMessageBox.Show("Info Kesalahan : " & ex.Message, Application.ProductName)
                    hasil = New Tuple(Of Boolean, String, List(Of Entity.KategoriAsset))(False, "Info Kesalahan : " & ex.Message, Nothing)
                End Try
            End Using
            Return hasil
        End Function

        Public Function [Get](Id As Guid) As Tuple(Of Boolean, String, Entity.KategoriAsset) Implements IKategoriAsset.Get
            Dim hasil As New Tuple(Of Boolean, String, Entity.KategoriAsset)(False, String.Empty, Nothing)
            Using dlg As New WaitDialogForm("Sedang merefresh data ...", "Mohon tunggu sebentar")
                Try
                    Dim result = DbContext.KategoriAssets.AsNoTracking.FirstOrDefault(Function(m) m.id = Id)
                    If (result IsNot Nothing) Then
                        hasil = New Tuple(Of Boolean, String, Entity.KategoriAsset)(True, "Data ditemukan", result)
                    Else
                        hasil = New Tuple(Of Boolean, String, Entity.KategoriAsset)(False, "Data tidak ditemukan", Nothing)
                    End If
                Catch ex As Exception
                    Log.Error(ex, "Error : " & ex.Message)
                    XtraMessageBox.Show("Info Kesalahan : " & ex.Message, Application.ProductName)
                    hasil = New Tuple(Of Boolean, String, Entity.KategoriAsset)(False, "Info Kesalahan : " & ex.Message, Nothing)
                End Try
            End Using
            Return hasil
        End Function

        Public Function FindByKode(Kode As String) As Tuple(Of Boolean, String, Entity.KategoriAsset) Implements IKategoriAsset.FindByKode
            Dim hasil As New Tuple(Of Boolean, String, Entity.KategoriAsset)(False, String.Empty, Nothing)
            Using dlg As New WaitDialogForm("Sedang merefresh data ...", "Mohon tunggu sebentar")
                Try
                    Dim result = DbContext.KategoriAssets.AsNoTracking.FirstOrDefault(Function(m) m.kd_kategori = Kode)
                    If (result IsNot Nothing) Then
                        hasil = New Tuple(Of Boolean, String, Entity.KategoriAsset)(True, "Data ditemukan", result)
                    Else
                        hasil = New Tuple(Of Boolean, String, Entity.KategoriAsset)(False, "Data tidak ditemukan", Nothing)
                    End If
                Catch ex As Exception
                    Log.Error(ex, "Error : " & ex.Message)
                    XtraMessageBox.Show("Info Kesalahan : " & ex.Message, Application.ProductName)
                    hasil = New Tuple(Of Boolean, String, Entity.KategoriAsset)(False, "Info Kesalahan : " & ex.Message, Nothing)
                End Try
            End Using
            Return hasil
        End Function

        Public Function Create(Data As Entity.KategoriAsset) As Tuple(Of Boolean, String, Entity.KategoriAsset) Implements IKategoriAsset.Create
            Dim hasil As New Tuple(Of Boolean, String, Entity.KategoriAsset)(False, String.Empty, Nothing)
            Using dlg As New WaitDialogForm("Sedang menyimpan data ...", "Mohon tunggu sebentar")
                Try
                    Data.id = Guid.NewGuid()
                    If (String.IsNullOrEmpty(Data.kd_kategori) OrElse String.IsNullOrWhiteSpace(Data.kd_kategori)) Then
                        hasil = New Tuple(Of Boolean, String, Entity.KategoriAsset)(False, "Kode belum diisi.", Data)
                        Exit Try
                    End If
                    If (String.IsNullOrEmpty(Data.nama_kategori) OrElse String.IsNullOrWhiteSpace(Data.nama_kategori)) Then
                        hasil = New Tuple(Of Boolean, String, Entity.KategoriAsset)(False, "Nama belum diisi.", Data)
                        Exit Try
                    End If

                    Dim cekKodeSudahDipakai = DbContext.KategoriAssets.Where(Function(m) m.id <> Data.id AndAlso m.kd_kategori.ToLower() = Data.kd_kategori.ToLower()).ToList()
                    If (cekKodeSudahDipakai.Count() = 0) Then
                        DbContext.KategoriAssets.Add(Data)
                        hasil = New Tuple(Of Boolean, String, Entity.KategoriAsset)(True, "Data telah disimpan", Data)
                    Else
                        hasil = New Tuple(Of Boolean, String, Entity.KategoriAsset)(False, "Kode sudah dipakai di master asset lain.", Nothing)
                    End If

                    DbContext.SaveChanges()
                Catch ex As Exception
                    Log.Error(ex, "Error : " & ex.Message)
                    XtraMessageBox.Show("Info Kesalahan : " & ex.Message, Application.ProductName)
                    hasil = New Tuple(Of Boolean, String, Entity.KategoriAsset)(False, "Info Kesalahan : " & ex.Message, Nothing)
                End Try
            End Using
            Return hasil
        End Function

        Public Function Update(Data As Entity.KategoriAsset) As Tuple(Of Boolean, String, Entity.KategoriAsset) Implements IKategoriAsset.Update
            Dim hasil As New Tuple(Of Boolean, String, Entity.KategoriAsset)(False, String.Empty, Nothing)
            Using dlg As New WaitDialogForm("Sedang menyimpan data ...", "Mohon tunggu sebentar")
                Try
                    If (String.IsNullOrEmpty(Data.kd_kategori) OrElse String.IsNullOrWhiteSpace(Data.kd_kategori)) Then
                        hasil = New Tuple(Of Boolean, String, Entity.KategoriAsset)(False, "Kode belum diisi.", Data)
                        Exit Try
                    End If
                    If (String.IsNullOrEmpty(Data.nama_kategori) OrElse String.IsNullOrWhiteSpace(Data.nama_kategori)) Then
                        hasil = New Tuple(Of Boolean, String, Entity.KategoriAsset)(False, "Nama belum diisi.", Data)
                        Exit Try
                    End If

                    Dim dataOld = DbContext.KategoriAssets.FirstOrDefault(Function(m) m.id = Data.id)
                    If (dataOld IsNot Nothing) Then
                        Dim cekKodeSudahDipakai = DbContext.KategoriAssets.Where(Function(m) m.id <> Data.id AndAlso m.kd_kategori.ToLower() = Data.kd_kategori.ToLower()).ToList()
                        If (cekKodeSudahDipakai.Count() = 0) Then
                            DbContext.Entry(dataOld).CurrentValues.SetValues(Data)
                            hasil = New Tuple(Of Boolean, String, Entity.KategoriAsset)(True, "Data telah diubah", Data)
                        Else
                            hasil = New Tuple(Of Boolean, String, Entity.KategoriAsset)(False, "Kode sudah dipakai di master asset lain.", Nothing)
                        End If
                    Else
                        hasil = New Tuple(Of Boolean, String, Entity.KategoriAsset)(False, "Data tidak ditemukan", Nothing)
                    End If
                    DbContext.SaveChanges()
                Catch ex As Exception
                    Log.Error(ex, "Error : " & ex.Message)
                    XtraMessageBox.Show("Info Kesalahan : " & ex.Message, Application.ProductName)
                    hasil = New Tuple(Of Boolean, String, Entity.KategoriAsset)(False, "Info Kesalahan : " & ex.Message, Nothing)
                End Try
            End Using
            Return hasil
        End Function

        Public Function Delete(Data As Entity.KategoriAsset) As Tuple(Of Boolean, String) Implements IKategoriAsset.Delete
            Dim hasil As New Tuple(Of Boolean, String)(False, String.Empty)
            Using dlg As New WaitDialogForm("Sedang menghapus data ...", "Mohon tunggu sebentar")
                Try
                    Dim result = DbContext.KategoriAssets.FirstOrDefault(Function(m) m.id = Data.id)
                    If (result IsNot Nothing) Then
                        Dim dipakai = DbContext.Assets.Where(Function(m) m.id_kategori = result.id).ToList()
                        If (dipakai.Count = 0) Then
                            DbContext.KategoriAssets.Remove(result)
                            hasil = New Tuple(Of Boolean, String)(True, "Data telah dihapus")
                        Else
                            hasil = New Tuple(Of Boolean, String)(False, "Data telah dipakai di master assets")
                        End If
                    Else
                        hasil = New Tuple(Of Boolean, String)(False, "Data tidak ditemukan")
                    End If
                    DbContext.SaveChanges()
                Catch ex As Exception
                    Log.Error(ex, "Error : " & ex.Message)
                    XtraMessageBox.Show("Info Kesalahan : " & ex.Message, Application.ProductName)
                    hasil = New Tuple(Of Boolean, String)(False, "Info Kesalahan : " & ex.Message)
                End Try
            End Using
            Return hasil
        End Function
    End Class
End Namespace
