﻿Imports Siaga.App.Data.Entity
Imports Siaga.App.Services
Imports Siaga.App.Data
Imports DevExpress.XtraEditors
Imports DevExpress.Utils
Imports Serilog

Namespace Repository
    Public Class Pemakaian
        Implements IPemakaian

        Public ReadOnly DbContext As New Data.ApplicationDbContext()

        Public Function GetAll(Filter As Model.FilterListPemakaian) As Tuple(Of Boolean, String, List(Of Model.PemakaianDTo)) Implements IPemakaian.GetAll
            Dim hasil As New Tuple(Of Boolean, String, List(Of Model.PemakaianDTo))(False, String.Empty, Nothing)
            Using dlg As New WaitDialogForm("Sedang merefresh data ...", "Mohon tunggu sebentar")
                Try
                    Dim TglDari As DateTime = Filter.TglDari.Date
                    Dim TglSampai As DateTime = Filter.TglSampai.Date.AddDays(1)
                    Dim query = (From p In DbContext.Pemakaians
                                 From r In DbContext.Ruangans.Where(Function(m) m.id = p.id_ruangan).DefaultIfEmpty()
                                 From d In DbContext.DetailAssets.Where(Function(m) m.id = p.id_detail_asset).DefaultIfEmpty()
                                 From a In DbContext.Assets.Where(Function(m) m.id = If(d IsNot Nothing, d.id_asset, Guid.Empty)).DefaultIfEmpty()
                                 From k In DbContext.KategoriAssets.Where(Function(m) m.id = If(a IsNot Nothing, a.id_kategori, Guid.Empty)).DefaultIfEmpty()
                                 Where p.tgl_mulai_pakai >= TglDari AndAlso p.tgl_mulai_pakai < TglSampai
                                 Select New With {
                                     p.id,
                                     .asset = If(a IsNot Nothing, a.nama_asset, String.Empty),
                                     .detail_asset = If(d IsNot Nothing, d.barcode, String.Empty),
                                     p.id_detail_asset,
                                     .id_asset = If(d IsNot Nothing, d.id_asset, Guid.Empty),
                                     p.id_ruangan,
                                     .kategori_asset = If(k IsNot Nothing, k.nama_kategori, String.Empty),
                                     .ruangan = If(r IsNot Nothing, r.nama_ruangan, String.Empty),
                                     p.tgl_mulai_pakai,
                                     .id_kategori = If(a IsNot Nothing, a.id_kategori, Guid.Empty)})
                    If (Filter.IDAsset <> Guid.Empty) Then
                        query.Where(Function(m) m.id_asset = Filter.IDAsset)
                    End If
                    If (Filter.IDKategoriAsset <> Guid.Empty) Then
                        query.Where(Function(m) m.id_kategori = Filter.IDKategoriAsset)
                    End If
                    If (Filter.IDRuangan <> Guid.Empty) Then
                        query.Where(Function(m) m.id_ruangan = Filter.IDRuangan)
                    End If
                    Dim result = (From x In query
                                  Select New Model.PemakaianDTo With {
                                      .id = x.id,
                                      .asset = x.asset,
                                      .detail_asset = x.detail_asset,
                                      .id_asset = x.id_asset,
                                      .id_detail_asset = x.id_detail_asset,
                                      .id_ruangan = x.id_ruangan,
                                      .kategori_asset = x.kategori_asset,
                                      .ruangan = x.ruangan,
                                      .tgl_mulai_pakai = x.tgl_mulai_pakai}).ToList()
                    hasil = New Tuple(Of Boolean, String, List(Of Model.PemakaianDTo))(True, "Data ditemukan", result)
                Catch ex As Exception
                    Log.Error(ex, "Error : " & ex.Message)
                    XtraMessageBox.Show("Info Kesalahan : " & ex.Message, Application.ProductName)
                    hasil = New Tuple(Of Boolean, String, List(Of Model.PemakaianDTo))(False, "Info Kesalahan : " & ex.Message, Nothing)
                End Try
            End Using
            Return hasil
        End Function

        Public Function [Get](Id As Guid) As Tuple(Of Boolean, String, Model.PemakaianDTo) Implements IPemakaian.Get
            Dim hasil As New Tuple(Of Boolean, String, Model.PemakaianDTo)(False, String.Empty, Nothing)
            Using dlg As New WaitDialogForm("Sedang merefresh data ...", "Mohon tunggu sebentar")
                Try
                    Dim result = (From p In DbContext.Pemakaians
                                  From r In DbContext.Ruangans.Where(Function(m) m.id = p.id_ruangan).DefaultIfEmpty()
                                  From d In DbContext.DetailAssets.Where(Function(m) m.id = p.id_detail_asset).DefaultIfEmpty()
                                  From a In DbContext.Assets.Where(Function(m) m.id = If(d IsNot Nothing, d.id_asset, Guid.Empty)).DefaultIfEmpty()
                                  From k In DbContext.KategoriAssets.Where(Function(m) m.id = If(a IsNot Nothing, a.id_kategori, Guid.Empty)).DefaultIfEmpty()
                                  Where p.id = Id
                                  Select New Model.PemakaianDTo With {
                                     .id = p.id,
                                     .asset = If(a IsNot Nothing, a.nama_asset, String.Empty),
                                     .detail_asset = If(d IsNot Nothing, d.barcode, String.Empty),
                                     .id_detail_asset = p.id_detail_asset,
                                     .id_asset = If(d IsNot Nothing, d.id_asset, Guid.Empty),
                                     .id_ruangan = p.id_ruangan,
                                     .kategori_asset = If(k IsNot Nothing, k.nama_kategori, String.Empty),
                                     .ruangan = If(r IsNot Nothing, r.nama_ruangan, String.Empty),
                                     .tgl_mulai_pakai = p.tgl_mulai_pakai}).FirstOrDefault()
                    If (result IsNot Nothing) Then
                        hasil = New Tuple(Of Boolean, String, Model.PemakaianDTo)(True, "Data ditemukan", result)
                    Else
                        hasil = New Tuple(Of Boolean, String, Model.PemakaianDTo)(False, "Data tidak ditemukan", Nothing)
                    End If
                Catch ex As Exception
                    Log.Error(ex, "Error : " & ex.Message)
                    XtraMessageBox.Show("Info Kesalahan : " & ex.Message, Application.ProductName)
                    hasil = New Tuple(Of Boolean, String, Model.PemakaianDTo)(False, "Info Kesalahan : " & ex.Message, Nothing)
                End Try
            End Using
            Return hasil
        End Function

        Public Function Create(Data As Data.Entity.Pemakaian) As Tuple(Of Boolean, String, Data.Entity.Pemakaian) Implements IPemakaian.Create
            Dim hasil As New Tuple(Of Boolean, String, Data.Entity.Pemakaian)(False, String.Empty, Nothing)
            Using dlg As New WaitDialogForm("Sedang menyimpan data ...", "Mohon tunggu sebentar")
                Dim transaction As System.Data.Entity.DbContextTransaction = Nothing
                Try
                    transaction = DbContext.Database.BeginTransaction()
                    Data.id = Guid.NewGuid()

                    Dim detail_asset = DbContext.DetailAssets.FirstOrDefault(Function(m) m.id = Data.id_detail_asset)
                    Dim ruangan = DbContext.Ruangans.FirstOrDefault(Function(m) m.id = Data.id_ruangan)

                    If (detail_asset Is Nothing) Then
                        hasil = New Tuple(Of Boolean, String, Data.Entity.Pemakaian)(False, "Asset tidak ditemukan.", Nothing)
                        Exit Try
                    End If

                    If (ruangan Is Nothing) Then
                        hasil = New Tuple(Of Boolean, String, Data.Entity.Pemakaian)(False, "Ruangan tidak ditemukan.", Nothing)
                        Exit Try
                    End If

                    DbContext.Pemakaians.Add(Data)

                    'Ke History
                    Dim jenisTransaksi = DbContext.JenisTransaksies.FirstOrDefault(Function(m) m.kd_jenis_transaksi.ToLower() = "Pemakaian".ToLower())
                    Dim queryInsert As New HistoryDetailAsset With {
                                                  .id = Guid.NewGuid,
                                                  .id_detail_asset = Data.id_detail_asset,
                                                  .id_jenis_transaksi = jenisTransaksi.id,
                                                  .id_ruangan = ruangan.id,
                                                  .id_transaksi = Data.id,
                                                  .tgl_transaksi = Data.tgl_mulai_pakai}
                    DbContext.HistoryDetailAssets.Add(queryInsert)

                    DbContext.SaveChanges()
                    transaction.Commit()
                    transaction = Nothing
                    hasil = New Tuple(Of Boolean, String, Data.Entity.Pemakaian)(True, "Data telah disimpan", Data)
                Catch ex As Exception
                    If (transaction IsNot Nothing) Then
                        transaction.Rollback()
                    End If
                    transaction = Nothing
                    Log.Error(ex, "Error : " & ex.Message)
                    XtraMessageBox.Show("Info Kesalahan : " & ex.Message, Application.ProductName)
                    hasil = New Tuple(Of Boolean, String, Data.Entity.Pemakaian)(False, "Info Kesalahan : " & ex.Message, Nothing)
                End Try
            End Using
            Return hasil
        End Function

        Public Function Update(Data As Data.Entity.Pemakaian) As Tuple(Of Boolean, String, Data.Entity.Pemakaian) Implements IPemakaian.Update
            Dim hasil As New Tuple(Of Boolean, String, Data.Entity.Pemakaian)(False, String.Empty, Nothing)
            Using dlg As New WaitDialogForm("Sedang menyimpan data ...", "Mohon tunggu sebentar")
                Dim transaction As System.Data.Entity.DbContextTransaction = Nothing
                Try
                    transaction = DbContext.Database.BeginTransaction()

                    Dim trans = DbContext.Pemakaians.FirstOrDefault(Function(m) m.id = Data.id)
                    Dim detail_asset = DbContext.DetailAssets.FirstOrDefault(Function(m) m.id = Data.id_detail_asset)
                    Dim ruangan = DbContext.Ruangans.FirstOrDefault(Function(m) m.id = Data.id_ruangan)

                    If (detail_asset Is Nothing) Then
                        hasil = New Tuple(Of Boolean, String, Data.Entity.Pemakaian)(False, "Asset tidak ditemukan.", Nothing)
                        Exit Try
                    End If

                    If (ruangan Is Nothing) Then
                        hasil = New Tuple(Of Boolean, String, Data.Entity.Pemakaian)(False, "Ruangan tidak ditemukan.", Nothing)
                        Exit Try
                    End If

                    If (trans Is Nothing) Then
                        hasil = New Tuple(Of Boolean, String, Data.Entity.Pemakaian)(False, "Pemindahan tidak ditemukan.", Nothing)
                        Exit Try
                    End If

                    DbContext.Entry(trans).CurrentValues.SetValues(Data)

                    'Ke History
                    Dim jenisTransaksi = DbContext.JenisTransaksies.FirstOrDefault(Function(m) m.kd_jenis_transaksi.ToLower() = "Pemakaian".ToLower())
                    Dim queryHapus = (From x In DbContext.HistoryDetailAssets
                                      Where x.id_transaksi = Data.id AndAlso x.id_jenis_transaksi = jenisTransaksi.id
                                      Select x)
                    DbContext.HistoryDetailAssets.RemoveRange(queryHapus)

                    Dim queryInsert As New HistoryDetailAsset With {
                                                  .id = Guid.NewGuid,
                                                  .id_detail_asset = Data.id_detail_asset,
                                                  .id_jenis_transaksi = jenisTransaksi.id,
                                                  .id_ruangan = ruangan.id,
                                                  .id_transaksi = Data.id,
                                                  .tgl_transaksi = Data.tgl_mulai_pakai}
                    DbContext.HistoryDetailAssets.Add(queryInsert)

                    DbContext.SaveChanges()
                    transaction.Commit()
                    transaction = Nothing
                    hasil = New Tuple(Of Boolean, String, Data.Entity.Pemakaian)(True, "Data telah disimpan", Data)
                Catch ex As Exception
                    If (transaction IsNot Nothing) Then
                        transaction.Rollback()
                    End If
                    transaction = Nothing
                    Log.Error(ex, "Error : " & ex.Message)
                    XtraMessageBox.Show("Info Kesalahan : " & ex.Message, Application.ProductName)
                    hasil = New Tuple(Of Boolean, String, Data.Entity.Pemakaian)(False, "Info Kesalahan : " & ex.Message, Nothing)
                End Try
            End Using
            Return hasil
        End Function

        Public Function Delete(id As Guid) As Tuple(Of Boolean, String) Implements IPemakaian.Delete
            Dim hasil As New Tuple(Of Boolean, String)(False, String.Empty)
            Using dlg As New WaitDialogForm("Sedang menghapus data ...", "Mohon tunggu sebentar")
                Dim tran As System.Data.Entity.DbContextTransaction = Nothing
                Try
                    tran = DbContext.Database.BeginTransaction()
                    Dim result = DbContext.Pemakaians.FirstOrDefault(Function(m) m.id = id)
                    If (result IsNot Nothing) Then
                        'Ke History
                        Dim jenisTransaksi = DbContext.JenisTransaksies.FirstOrDefault(Function(m) m.kd_jenis_transaksi.ToLower() = "Pemakaian".ToLower())
                        Dim queryHapus = (From x In DbContext.HistoryDetailAssets
                                          Where x.id_transaksi = id AndAlso x.id_jenis_transaksi = jenisTransaksi.id
                                          Select x)
                        DbContext.HistoryDetailAssets.RemoveRange(queryHapus)
                        DbContext.Pemakaians.Remove(result)
                        DbContext.SaveChanges()
                        tran.Commit()
                        tran = Nothing
                        hasil = New Tuple(Of Boolean, String)(True, "Data telah dihapus")
                    Else
                        hasil = New Tuple(Of Boolean, String)(False, "Data tidak ditemukan")
                    End If
                Catch ex As Exception
                    If (tran IsNot Nothing) Then
                        tran.Rollback()
                    End If
                    tran = Nothing
                    Log.Error(ex, "Error : " & ex.Message)
                    XtraMessageBox.Show("Info Kesalahan : " & ex.Message, Application.ProductName)
                    hasil = New Tuple(Of Boolean, String)(False, "Info Kesalahan : " & ex.Message)
                End Try
            End Using
            Return hasil
        End Function
    End Class
End Namespace
