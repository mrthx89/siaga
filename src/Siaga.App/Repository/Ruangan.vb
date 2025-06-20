Imports Siaga.App.Data.Entity
Imports Siaga.App.Services
Imports Siaga.App.Data
Imports DevExpress.XtraEditors
Imports DevExpress.Utils
Imports Serilog

Namespace Repository
    Public Class Ruangan
        Implements IRuangan

        Public ReadOnly DbContext As New Data.ApplicationDbContext()

        Public Function GetAll() As Tuple(Of Boolean, String, List(Of Entity.Ruangan)) Implements IRuangan.GetAll
            Dim hasil As New Tuple(Of Boolean, String, List(Of Entity.Ruangan))(False, String.Empty, Nothing)
            Using dlg As New WaitDialogForm("Sedang merefresh data ...", "Mohon tunggu sebentar")
                Try
                    Dim result = DbContext.Ruangans.AsNoTracking.ToList()
                    hasil = New Tuple(Of Boolean, String, List(Of Entity.Ruangan))(True, "Data ditemukan", result)
                Catch ex As Exception
                    Log.Error(ex, "Error : " & ex.Message)
                    XtraMessageBox.Show("Info Kesalahan : " & ex.Message, Application.ProductName)
                    hasil = New Tuple(Of Boolean, String, List(Of Entity.Ruangan))(False, "Info Kesalahan : " & ex.Message, Nothing)
                End Try
            End Using
            Return hasil
        End Function

        Public Function [Get](Id As Guid) As Tuple(Of Boolean, String, Entity.Ruangan) Implements IRuangan.Get
            Dim hasil As New Tuple(Of Boolean, String, Entity.Ruangan)(False, String.Empty, Nothing)
            Using dlg As New WaitDialogForm("Sedang merefresh data ...", "Mohon tunggu sebentar")
                Try
                    Dim result = DbContext.Ruangans.AsNoTracking.FirstOrDefault(Function(m) m.id = Id)
                    If (result IsNot Nothing) Then
                        hasil = New Tuple(Of Boolean, String, Entity.Ruangan)(True, "Data ditemukan", result)
                    Else
                        hasil = New Tuple(Of Boolean, String, Entity.Ruangan)(False, "Data tidak ditemukan", Nothing)
                    End If
                Catch ex As Exception
                    Log.Error(ex, "Error : " & ex.Message)
                    XtraMessageBox.Show("Info Kesalahan : " & ex.Message, Application.ProductName)
                    hasil = New Tuple(Of Boolean, String, Entity.Ruangan)(False, "Info Kesalahan : " & ex.Message, Nothing)
                End Try
            End Using
            Return hasil
        End Function

        Public Function FindByKode(Kode As String) As Tuple(Of Boolean, String, Entity.Ruangan) Implements IRuangan.FindByKode
            Dim hasil As New Tuple(Of Boolean, String, Entity.Ruangan)(False, String.Empty, Nothing)
            Using dlg As New WaitDialogForm("Sedang merefresh data ...", "Mohon tunggu sebentar")
                Try
                    Dim result = DbContext.Ruangans.AsNoTracking.FirstOrDefault(Function(m) m.kd_ruangan = Kode)
                    If (result IsNot Nothing) Then
                        hasil = New Tuple(Of Boolean, String, Entity.Ruangan)(True, "Data ditemukan", result)
                    Else
                        hasil = New Tuple(Of Boolean, String, Entity.Ruangan)(False, "Data tidak ditemukan", Nothing)
                    End If
                Catch ex As Exception
                    Log.Error(ex, "Error : " & ex.Message)
                    XtraMessageBox.Show("Info Kesalahan : " & ex.Message, Application.ProductName)
                    hasil = New Tuple(Of Boolean, String, Entity.Ruangan)(False, "Info Kesalahan : " & ex.Message, Nothing)
                End Try
            End Using
            Return hasil
        End Function

        Public Function Create(Data As Entity.Ruangan) As Tuple(Of Boolean, String, Entity.Ruangan) Implements IRuangan.Create
            Dim hasil As New Tuple(Of Boolean, String, Entity.Ruangan)(False, String.Empty, Nothing)
            Using dlg As New WaitDialogForm("Sedang menyimpan data ...", "Mohon tunggu sebentar")
                Try
                    Data.id = Guid.NewGuid()
                    If (String.IsNullOrEmpty(Data.kd_ruangan) OrElse String.IsNullOrWhiteSpace(Data.kd_ruangan)) Then
                        hasil = New Tuple(Of Boolean, String, Entity.Ruangan)(False, "Kode belum diisi.", Data)
                        Exit Try
                    End If
                    If (String.IsNullOrEmpty(Data.nama_ruangan) OrElse String.IsNullOrWhiteSpace(Data.nama_ruangan)) Then
                        hasil = New Tuple(Of Boolean, String, Entity.Ruangan)(False, "Nama belum diisi.", Data)
                        Exit Try
                    End If

                    Dim cekKodeSudahDipakai = DbContext.Ruangans.Where(Function(m) m.id <> Data.id AndAlso m.kd_ruangan.ToLower() = Data.kd_ruangan.ToLower()).ToList()
                    If (cekKodeSudahDipakai.Count() = 0) Then
                        DbContext.Ruangans.Add(Data)
                        hasil = New Tuple(Of Boolean, String, Entity.Ruangan)(True, "Data telah disimpan", Data)
                    Else
                        hasil = New Tuple(Of Boolean, String, Entity.Ruangan)(False, "Kode sudah dipakai di master asset lain.", Nothing)
                    End If

                    DbContext.SaveChanges()
                Catch ex As Exception
                    Log.Error(ex, "Error : " & ex.Message)
                    XtraMessageBox.Show("Info Kesalahan : " & ex.Message, Application.ProductName)
                    hasil = New Tuple(Of Boolean, String, Entity.Ruangan)(False, "Info Kesalahan : " & ex.Message, Nothing)
                End Try
            End Using
            Return hasil
        End Function

        Public Function Update(Data As Entity.Ruangan) As Tuple(Of Boolean, String, Entity.Ruangan) Implements IRuangan.Update
            Dim hasil As New Tuple(Of Boolean, String, Entity.Ruangan)(False, String.Empty, Nothing)
            Using dlg As New WaitDialogForm("Sedang menyimpan data ...", "Mohon tunggu sebentar")
                Try
                    If (String.IsNullOrEmpty(Data.kd_ruangan) OrElse String.IsNullOrWhiteSpace(Data.kd_ruangan)) Then
                        hasil = New Tuple(Of Boolean, String, Entity.Ruangan)(False, "Kode belum diisi.", Data)
                        Exit Try
                    End If
                    If (String.IsNullOrEmpty(Data.nama_ruangan) OrElse String.IsNullOrWhiteSpace(Data.nama_ruangan)) Then
                        hasil = New Tuple(Of Boolean, String, Entity.Ruangan)(False, "Nama belum diisi.", Data)
                        Exit Try
                    End If

                    Dim dataOld = DbContext.Ruangans.FirstOrDefault(Function(m) m.id = Data.id)
                    If (dataOld IsNot Nothing) Then
                        Dim cekKodeSudahDipakai = DbContext.Ruangans.Where(Function(m) m.id <> Data.id AndAlso m.kd_ruangan.ToLower() = Data.kd_ruangan.ToLower()).ToList()
                        If (cekKodeSudahDipakai.Count() = 0) Then
                            DbContext.Entry(dataOld).CurrentValues.SetValues(Data)
                            hasil = New Tuple(Of Boolean, String, Entity.Ruangan)(True, "Data telah diubah", Data)
                        Else
                            hasil = New Tuple(Of Boolean, String, Entity.Ruangan)(False, "Kode sudah dipakai di master asset lain.", Nothing)
                        End If
                    Else
                        hasil = New Tuple(Of Boolean, String, Entity.Ruangan)(False, "Data tidak ditemukan", Nothing)
                    End If
                    DbContext.SaveChanges()
                Catch ex As Exception
                    Log.Error(ex, "Error : " & ex.Message)
                    XtraMessageBox.Show("Info Kesalahan : " & ex.Message, Application.ProductName)
                    hasil = New Tuple(Of Boolean, String, Entity.Ruangan)(False, "Info Kesalahan : " & ex.Message, Nothing)
                End Try
            End Using
            Return hasil
        End Function

        Public Function Delete(Data As Entity.Ruangan) As Tuple(Of Boolean, String) Implements IRuangan.Delete
            Dim hasil As New Tuple(Of Boolean, String)(False, String.Empty)
            Using dlg As New WaitDialogForm("Sedang menghapus data ...", "Mohon tunggu sebentar")
                Try
                    Dim result = DbContext.Ruangans.FirstOrDefault(Function(m) m.id = Data.id)
                    If (result IsNot Nothing) Then
                        Dim dipakaiPemakaian = DbContext.Pemakaians.Where(Function(m) m.id_ruangan = result.id).ToList()
                        Dim dipakaiHistory = DbContext.HistoryDetailAssets.Where(Function(m) m.id_ruangan = result.id).ToList()
                        If (dipakaiPemakaian.Count = 0 AndAlso dipakaiHistory.Count = 0) Then
                            DbContext.Ruangans.Remove(result)
                            hasil = New Tuple(Of Boolean, String)(True, "Data telah dihapus")
                        Else
                            hasil = New Tuple(Of Boolean, String)(False, "Data telah dipakai di History Detil Asset atau Pemakaian")
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
