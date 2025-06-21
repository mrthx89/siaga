Imports Siaga.App.Data.Entity
Imports Siaga.App.Services
Imports Siaga.App.Data
Imports DevExpress.XtraEditors
Imports DevExpress.Utils
Imports Serilog

Namespace Repository
    Public Class Asset
        Implements IAsset

        Public ReadOnly DbContext As New Data.ApplicationDbContext()

        Public Function GetAll() As Tuple(Of Boolean, String, List(Of Model.AssetDTo)) Implements IAsset.GetAll
            Dim hasil As New Tuple(Of Boolean, String, List(Of Model.AssetDTo))(False, String.Empty, Nothing)
            Using dlg As New WaitDialogForm("Sedang merefresh data ...", "Mohon tunggu sebentar")
                Try
                    Dim result = (From a In DbContext.Assets
                                  From k In DbContext.KategoriAssets.Where(Function(m) m.id = a.id_kategori).DefaultIfEmpty()
                                  Select New Model.AssetDTo With {
                                     .id = a.id,
                                     .id_kategori = a.id_kategori,
                                     .kd_asset = a.kd_asset,
                                     .keterangan = a.keterangan,
                                     .nama_asset = a.nama_asset,
                                     .nama_kategori = If(k Is Nothing, k.nama_kategori, String.Empty),
                                     .DetailAssets = New List(Of Model.DetilAssetDTo)()}).ToList()
                    For Each item In result
                        item.DetailAssets = (From d In DbContext.DetailAssets
                                             Where d.id_asset = item.id
                                             Select New Model.DetilAssetDTo With {
                                                .id = d.id,
                                                .barcode = d.barcode,
                                                .id_asset = d.id_asset,
                                                .harga_beli = d.harga_beli,
                                                .kondisi = d.kondisi,
                                                .sumber = d.sumber,
                                                .tgl_perolehan = d.tgl_perolehan}).ToList()
                        Application.DoEvents()
                    Next
                    hasil = New Tuple(Of Boolean, String, List(Of Model.AssetDTo))(True, "Data ditemukan", result)
                Catch ex As Exception
                    Log.Error(ex, "Error : " & ex.Message)
                    XtraMessageBox.Show("Info Kesalahan : " & ex.Message, Application.ProductName)
                    hasil = New Tuple(Of Boolean, String, List(Of Model.AssetDTo))(False, "Info Kesalahan : " & ex.Message, Nothing)
                End Try
            End Using
            Return hasil
        End Function

        Public Function [Get](Id As Guid) As Tuple(Of Boolean, String, Model.AssetDTo) Implements IAsset.Get
            Dim hasil As New Tuple(Of Boolean, String, Model.AssetDTo)(False, String.Empty, Nothing)
            Using dlg As New WaitDialogForm("Sedang merefresh data ...", "Mohon tunggu sebentar")
                Try
                    Dim result = (From a In DbContext.Assets
                                  From k In DbContext.KategoriAssets.Where(Function(m) m.id = a.id_kategori).DefaultIfEmpty()
                                  Where a.id = Id
                                  Select New Model.AssetDTo With {
                                     .id = a.id,
                                     .id_kategori = a.id_kategori,
                                     .kd_asset = a.kd_asset,
                                     .keterangan = a.keterangan,
                                     .nama_asset = a.nama_asset,
                                     .nama_kategori = If(k Is Nothing, k.nama_kategori, String.Empty),
                                     .DetailAssets = New List(Of Model.DetilAssetDTo)()}).FirstOrDefault()
                    If (result IsNot Nothing) Then
                        result.DetailAssets = (From d In DbContext.DetailAssets
                                               Where d.id_asset = result.id
                                               Select New Model.DetilAssetDTo With {
                                                .id = d.id,
                                                .barcode = d.barcode,
                                                .id_asset = d.id_asset,
                                                .harga_beli = d.harga_beli,
                                                .kondisi = d.kondisi,
                                                .sumber = d.sumber,
                                                .tgl_perolehan = d.tgl_perolehan}).ToList()
                    End If
                    If (result IsNot Nothing) Then
                        hasil = New Tuple(Of Boolean, String, Model.AssetDTo)(True, "Data ditemukan", result)
                    Else
                        hasil = New Tuple(Of Boolean, String, Model.AssetDTo)(False, "Data tidak ditemukan", Nothing)
                    End If
                Catch ex As Exception
                    Log.Error(ex, "Error : " & ex.Message)
                    XtraMessageBox.Show("Info Kesalahan : " & ex.Message, Application.ProductName)
                    hasil = New Tuple(Of Boolean, String, Model.AssetDTo)(False, "Info Kesalahan : " & ex.Message, Nothing)
                End Try
            End Using
            Return hasil
        End Function

        Public Function FindByKode(Kode As String) As Tuple(Of Boolean, String, Model.AssetDTo) Implements IAsset.FindByKode
            Dim hasil As New Tuple(Of Boolean, String, Model.AssetDTo)(False, String.Empty, Nothing)
            Using dlg As New WaitDialogForm("Sedang merefresh data ...", "Mohon tunggu sebentar")
                Try
                    Dim result = (From a In DbContext.Assets
                                  From k In DbContext.KategoriAssets.Where(Function(m) m.id = a.id_kategori).DefaultIfEmpty()
                                  Where a.kd_asset.ToLower() = Kode.ToLower()
                                  Select New Model.AssetDTo With {
                                     .id = a.id,
                                     .id_kategori = a.id_kategori,
                                     .kd_asset = a.kd_asset,
                                     .keterangan = a.keterangan,
                                     .nama_asset = a.nama_asset,
                                     .nama_kategori = If(k Is Nothing, k.nama_kategori, String.Empty),
                                     .DetailAssets = New List(Of Model.DetilAssetDTo)()}).FirstOrDefault()
                    If (result IsNot Nothing) Then
                        result.DetailAssets = (From d In DbContext.DetailAssets
                                               Where d.id_asset = result.id
                                               Select New Model.DetilAssetDTo With {
                                                .id = d.id,
                                                .barcode = d.barcode,
                                                .id_asset = d.id_asset,
                                                .harga_beli = d.harga_beli,
                                                .kondisi = d.kondisi,
                                                .sumber = d.sumber,
                                                .tgl_perolehan = d.tgl_perolehan}).ToList()
                    End If
                    If (result IsNot Nothing) Then
                        hasil = New Tuple(Of Boolean, String, Model.AssetDTo)(True, "Data ditemukan", result)
                    Else
                        hasil = New Tuple(Of Boolean, String, Model.AssetDTo)(False, "Data tidak ditemukan", Nothing)
                    End If
                Catch ex As Exception
                    Log.Error(ex, "Error : " & ex.Message)
                    XtraMessageBox.Show("Info Kesalahan : " & ex.Message, Application.ProductName)
                    hasil = New Tuple(Of Boolean, String, Model.AssetDTo)(False, "Info Kesalahan : " & ex.Message, Nothing)
                End Try
            End Using
            Return hasil
        End Function

        Public Function Create(Data As Model.AssetDTo) As Tuple(Of Boolean, String, Model.AssetDTo) Implements IAsset.Create
            Dim hasil As New Tuple(Of Boolean, String, Model.AssetDTo)(False, String.Empty, Nothing)
            Using dlg As New WaitDialogForm("Sedang menyimpan data ...", "Mohon tunggu sebentar")
                Try
                    Data.id = Guid.NewGuid()
                    If (String.IsNullOrEmpty(Data.kd_asset) OrElse String.IsNullOrWhiteSpace(Data.kd_asset)) Then
                        hasil = New Tuple(Of Boolean, String, Model.AssetDTo)(False, "Kode belum diisi.", Data)
                        Exit Try
                    End If
                    If (String.IsNullOrEmpty(Data.nama_asset) OrElse String.IsNullOrWhiteSpace(Data.nama_asset)) Then
                        hasil = New Tuple(Of Boolean, String, Model.AssetDTo)(False, "Nama belum diisi.", Data)
                        Exit Try
                    End If
                    Dim kodekategori = DbContext.KategoriAssets.AsNoTracking().FirstOrDefault(Function(m) m.id = Data.id_kategori)
                    If (kodekategori Is Nothing) Then
                        hasil = New Tuple(Of Boolean, String, Model.AssetDTo)(False, "Kategori tidak ditemukan.", Data)
                        Exit Try
                    End If
                    If (Data.DetailAssets Is Nothing OrElse Data.DetailAssets.Count = 0) Then
                        hasil = New Tuple(Of Boolean, String, Model.AssetDTo)(False, "Detil Assets tidak ditemukan.", Data)
                        Exit Try
                    Else
                        For Each item In Data.DetailAssets
                            If (item.tgl_perolehan <= DateTime.Parse("1900-01-01")) Then
                                hasil = New Tuple(Of Boolean, String, Model.AssetDTo)(False, "Tanggal Perolehan belum diisi.", Data)
                                Exit Try
                            End If
                            If (String.IsNullOrEmpty(item.barcode) OrElse String.IsNullOrWhiteSpace(item.barcode)) Then
                                hasil = New Tuple(Of Boolean, String, Model.AssetDTo)(False, "Barcode Asset belum diisi.", Data)
                                Exit Try
                            End If
                            Dim cekBarcodeSudahDipakai = DbContext.DetailAssets.Where(Function(m) m.id <> item.id AndAlso m.barcode.ToLower() = item.barcode.ToLower()).ToList()
                            If (cekBarcodeSudahDipakai.Count() >= 1) Then
                                hasil = New Tuple(Of Boolean, String, Model.AssetDTo)(False, "Barcode Asset sudah dipakai.", Data)
                                Exit Try
                            End If
                            Application.DoEvents()
                        Next
                    End If

                    Dim cekKodeSudahDipakai = DbContext.Assets.Where(Function(m) m.id <> Data.id AndAlso m.kd_asset.ToLower() = Data.kd_asset.ToLower()).ToList()
                    If (cekKodeSudahDipakai.Count() = 0) Then
                        Dim dataNew As New Data.Entity.Asset With {
                            .id = Data.id,
                            .id_kategori = Data.id_kategori,
                            .kd_asset = Data.kd_asset,
                            .nama_asset = Data.nama_asset,
                            .keterangan = Data.keterangan,
                            .DetailAssets = New List(Of Data.Entity.DetailAsset)}
                        For Each item In Data.DetailAssets
                            dataNew.DetailAssets.Add(New DetailAsset With {
                                                     .id = Guid.NewGuid,
                                                     .id_asset = Data.id,
                                                     .barcode = item.barcode,
                                                     .harga_beli = item.harga_beli,
                                                     .kondisi = item.kondisi,
                                                     .sumber = item.sumber,
                                                     .tgl_perolehan = item.tgl_perolehan})
                            Application.DoEvents()
                        Next
                        DbContext.Assets.Add(dataNew)

                        'Ke History
                        Dim jenisTransaksi = DbContext.JenisTransaksies.FirstOrDefault(Function(m) m.kd_jenis_transaksi.ToLower() = "Perolehan".ToLower())
                        Dim ruangan = DbContext.Ruangans.FirstOrDefault(Function(m) m.kd_ruangan.ToLower() = "00000-Perolehan".ToLower())
                        Dim queryHapus = (From x In DbContext.HistoryDetailAssets
                                          From d In DbContext.JenisTransaksies.Where(Function(m) m.id = x.id_jenis_transaksi).DefaultIfEmpty()
                                          Where x.id_detail_asset = dataNew.id AndAlso d.id = jenisTransaksi.id
                                          Select x)
                        DbContext.HistoryDetailAssets.RemoveRange(queryHapus)

                        Dim queryInsert = (From d In dataNew.DetailAssets
                                           Select New HistoryDetailAsset With {
                                              .id = d.id,
                                              .id_detail_asset = d.id,
                                              .id_jenis_transaksi = jenisTransaksi.id,
                                              .id_ruangan = ruangan.id,
                                              .id_transaksi = dataNew.id,
                                              .tgl_transaksi = d.tgl_perolehan}).ToList()
                        DbContext.HistoryDetailAssets.AddRange(queryInsert)

                        DbContext.SaveChanges()
                        hasil = New Tuple(Of Boolean, String, Model.AssetDTo)(True, "Data telah disimpan", Data)
                    Else
                        hasil = New Tuple(Of Boolean, String, Model.AssetDTo)(False, "Kode sudah dipakai di master asset lain.", Nothing)
                    End If
                Catch ex As Exception
                    Log.Error(ex, "Error : " & ex.Message)
                    XtraMessageBox.Show("Info Kesalahan : " & ex.Message, Application.ProductName)
                    hasil = New Tuple(Of Boolean, String, Model.AssetDTo)(False, "Info Kesalahan : " & ex.Message, Nothing)
                End Try
            End Using
            Return hasil
        End Function

        Public Function Update(Data As Model.AssetDTo) As Tuple(Of Boolean, String, Model.AssetDTo) Implements IAsset.Update
            Dim hasil As New Tuple(Of Boolean, String, Model.AssetDTo)(False, String.Empty, Nothing)
            Using dlg As New WaitDialogForm("Sedang menyimpan data ...", "Mohon tunggu sebentar")
                Try
                    If (String.IsNullOrEmpty(Data.kd_asset) OrElse String.IsNullOrWhiteSpace(Data.kd_asset)) Then
                        hasil = New Tuple(Of Boolean, String, Model.AssetDTo)(False, "Kode belum diisi.", Data)
                        Exit Try
                    End If
                    If (String.IsNullOrEmpty(Data.nama_asset) OrElse String.IsNullOrWhiteSpace(Data.nama_asset)) Then
                        hasil = New Tuple(Of Boolean, String, Model.AssetDTo)(False, "Nama belum diisi.", Data)
                        Exit Try
                    End If

                    Dim dataOld = DbContext.Assets.FirstOrDefault(Function(m) m.id = Data.id)
                    If (dataOld IsNot Nothing) Then
                        Dim cekKodeSudahDipakai = DbContext.Assets.Where(Function(m) m.id <> Data.id AndAlso m.kd_asset.ToLower() = Data.kd_asset.ToLower()).ToList()
                        If (cekKodeSudahDipakai.Count() = 0) Then
                            DbContext.Entry(dataOld).CurrentValues.SetValues(Data)
                            hasil = New Tuple(Of Boolean, String, Model.AssetDTo)(True, "Data telah diubah", Data)
                        Else
                            hasil = New Tuple(Of Boolean, String, Model.AssetDTo)(False, "Kode sudah dipakai di master asset lain.", Nothing)
                        End If
                    Else
                        hasil = New Tuple(Of Boolean, String, Model.AssetDTo)(False, "Data tidak ditemukan", Nothing)
                    End If
                    DbContext.SaveChanges()
                Catch ex As Exception
                    Log.Error(ex, "Error : " & ex.Message)
                    XtraMessageBox.Show("Info Kesalahan : " & ex.Message, Application.ProductName)
                    hasil = New Tuple(Of Boolean, String, Model.AssetDTo)(False, "Info Kesalahan : " & ex.Message, Nothing)
                End Try
            End Using
            Return hasil
        End Function

        Public Function Delete(Data As Model.AssetDTo) As Tuple(Of Boolean, String) Implements IAsset.Delete
            Dim hasil As New Tuple(Of Boolean, String)(False, String.Empty)
            Using dlg As New WaitDialogForm("Sedang menghapus data ...", "Mohon tunggu sebentar")
                Try
                    Dim result = DbContext.Assets.FirstOrDefault(Function(m) m.id = Data.id AndAlso (m.kd_asset.ToLower() <> "0000-perolehan".ToLower() AndAlso m.kd_asset.ToLower() <> "0000-pemutihan".ToLower()))
                    If (result IsNot Nothing) Then
                        Dim dipakaiPemakaian = DbContext.Pemakaians.Where(Function(m) m.id_Asset = result.id).ToList()
                        Dim dipakaiHistory = DbContext.HistoryDetailAssets.Where(Function(m) m.id_Asset = result.id).ToList()
                        If (dipakaiPemakaian.Count = 0 AndAlso dipakaiHistory.Count = 0) Then
                            DbContext.Assets.Remove(result)
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
