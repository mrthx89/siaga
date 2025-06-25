Imports Siaga.App.Data.Entity
Imports Siaga.App.Services
Imports Siaga.App.Data
Imports DevExpress.XtraEditors
Imports DevExpress.Utils
Imports Serilog
Imports Siaga.App.Model

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
                                     .nama_kategori = If(k IsNot Nothing, k.nama_kategori, String.Empty)}).ToList()
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
                                     .nama_kategori = If(k IsNot Nothing, k.nama_kategori, String.Empty)}).FirstOrDefault()
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
                                     .nama_kategori = If(k IsNot Nothing, k.nama_kategori, String.Empty)}).FirstOrDefault()
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
                Dim transaction As System.Data.Entity.DbContextTransaction = Nothing
                Try
                    transaction = DbContext.Database.BeginTransaction()
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
                                          From a In DbContext.DetailAssets.Where(Function(m) m.id = x.id_detail_asset).DefaultIfEmpty()
                                          From d In DbContext.JenisTransaksies.Where(Function(m) m.id = x.id_jenis_transaksi).DefaultIfEmpty()
                                          Where a.id_asset = dataNew.id AndAlso d.id = jenisTransaksi.id
                                          Select x)
                        DbContext.HistoryDetailAssets.RemoveRange(queryHapus)

                        Dim queryInsert = (From d In dataNew.DetailAssets
                                           Select New HistoryDetailAsset With {
                                              .id = Guid.NewGuid,
                                              .id_detail_asset = d.id,
                                              .id_jenis_transaksi = jenisTransaksi.id,
                                              .id_ruangan = ruangan.id,
                                              .id_transaksi = dataNew.id,
                                              .tgl_transaksi = d.tgl_perolehan}).ToList()
                        DbContext.HistoryDetailAssets.AddRange(queryInsert)

                        DbContext.SaveChanges()
                        transaction.Commit()
                        transaction = Nothing
                        hasil = New Tuple(Of Boolean, String, Model.AssetDTo)(True, "Data telah disimpan", Data)
                    Else
                        hasil = New Tuple(Of Boolean, String, Model.AssetDTo)(False, "Kode sudah dipakai di master asset lain.", Nothing)
                    End If
                Catch ex As Exception
                    If (transaction IsNot Nothing) Then
                        transaction.Rollback()
                    End If
                    transaction = Nothing
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
                Dim transaction As System.Data.Entity.DbContextTransaction = Nothing
                Try
                    transaction = DbContext.Database.BeginTransaction()
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

                    Dim dataOld = DbContext.Assets.FirstOrDefault(Function(m) m.id = Data.id)
                    If (dataOld IsNot Nothing) Then
                        Dim cekKodeSudahDipakai = DbContext.Assets.Where(Function(m) m.id <> Data.id AndAlso m.kd_asset.ToLower() = Data.kd_asset.ToLower()).ToList()
                        If (cekKodeSudahDipakai.Count() = 0) Then
                            'Ke History
                            Dim jenisTransaksi = DbContext.JenisTransaksies.FirstOrDefault(Function(m) m.kd_jenis_transaksi.ToLower() = "Perolehan".ToLower())
                            Dim ruangan = DbContext.Ruangans.FirstOrDefault(Function(m) m.kd_ruangan.ToLower() = "00000-Perolehan".ToLower())
                            Dim queryHapus = (From x In DbContext.HistoryDetailAssets
                                              From a In DbContext.DetailAssets.Where(Function(m) m.id = x.id_detail_asset).DefaultIfEmpty()
                                              From d In DbContext.JenisTransaksies.Where(Function(m) m.id = x.id_jenis_transaksi).DefaultIfEmpty()
                                              Where a.id_asset = dataOld.id AndAlso d.id = jenisTransaksi.id
                                              Select x)
                            DbContext.HistoryDetailAssets.RemoveRange(queryHapus)

                            'Proses Update
                            dataOld.id_kategori = Data.id_kategori
                            dataOld.kd_asset = Data.kd_asset
                            dataOld.nama_asset = Data.nama_asset
                            dataOld.keterangan = Data.keterangan

                            For Each itemBaru In Data.DetailAssets
                                Dim itemLama = dataOld.DetailAssets.FirstOrDefault(Function(x) x.id = itemBaru.id)
                                If itemLama IsNot Nothing Then
                                    ' Update
                                    itemLama.barcode = itemBaru.barcode
                                    itemLama.harga_beli = itemBaru.harga_beli
                                    itemLama.kondisi = itemBaru.kondisi
                                    itemLama.sumber = itemBaru.sumber
                                    itemLama.tgl_perolehan = itemBaru.tgl_perolehan
                                Else
                                    ' Insert baru
                                    DbContext.DetailAssets.Add(New DetailAsset With {
                                        .id = itemBaru.id,
                                        .id_asset = Data.id,
                                        .barcode = itemBaru.barcode,
                                        .harga_beli = itemBaru.harga_beli,
                                        .kondisi = itemBaru.kondisi,
                                        .sumber = itemBaru.sumber,
                                        .tgl_perolehan = itemBaru.tgl_perolehan
                                    })
                                End If

                                Application.DoEvents()
                            Next
                            Dim toBeDeleted = dataOld.DetailAssets.Where(Function(itemLama) Not Data.DetailAssets.Any(Function(x) x.id = itemLama.id)).ToList()
                            DbContext.DetailAssets.RemoveRange(toBeDeleted)
                            DbContext.Entry(dataOld).State = System.Data.Entity.EntityState.Modified

                            'Ke History
                            Dim queryInsert = (From d In dataOld.DetailAssets
                                               Select New HistoryDetailAsset With {
                                                  .id = Guid.NewGuid,
                                                  .id_detail_asset = d.id,
                                                  .id_jenis_transaksi = jenisTransaksi.id,
                                                  .id_ruangan = ruangan.id,
                                                  .id_transaksi = dataOld.id,
                                                  .tgl_transaksi = d.tgl_perolehan}).ToList()
                            DbContext.HistoryDetailAssets.AddRange(queryInsert)

                            DbContext.SaveChanges()
                            transaction.Commit()
                            transaction = Nothing
                            hasil = New Tuple(Of Boolean, String, Model.AssetDTo)(True, "Data telah disimpan", Data)
                        Else
                            hasil = New Tuple(Of Boolean, String, Model.AssetDTo)(False, "Kode sudah dipakai di master asset lain.", Nothing)
                        End If
                    Else
                        hasil = New Tuple(Of Boolean, String, Model.AssetDTo)(False, "Data tidak ditemukan.", Nothing)
                    End If
                Catch ex As Exception
                    If (transaction IsNot Nothing) Then
                        transaction.Rollback()
                    End If
                    transaction = Nothing
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
                Dim tran As System.Data.Entity.DbContextTransaction = Nothing
                Try
                    tran = DbContext.Database.BeginTransaction()
                    Dim result = DbContext.Assets.FirstOrDefault(Function(m) m.id = Data.id)
                    If (result IsNot Nothing) Then
                        Dim dipakaiPemakaian = (From p In DbContext.Pemakaians
                                                Join d In DbContext.DetailAssets On p.id_detail_asset Equals d.id
                                                Where d.id_asset = result.id
                                                Select p).ToList()
                        Dim dipakaiPemutihan = (From p In DbContext.Pemutihans
                                                Join d In DbContext.DetailAssets On p.id_detail_asset Equals d.id
                                                Where d.id_asset = result.id
                                                Select p).ToList()
                        Dim dipakaiHistory = (From p In DbContext.HistoryDetailAssets
                                              Join d In DbContext.DetailAssets On p.id_detail_asset Equals d.id
                                              Join j In DbContext.JenisTransaksies On p.id_jenis_transaksi Equals j.id
                                              Where d.id_asset = result.id AndAlso j.kd_jenis_transaksi.ToLower() <> "00000-Perolehan".ToLower()
                                              Select p).ToList()
                        If (dipakaiPemakaian.Count = 0 AndAlso dipakaiPemutihan.Count = 0 AndAlso dipakaiHistory.Count = 0) Then
                            'Ke History
                            Dim jenisTransaksi = DbContext.JenisTransaksies.FirstOrDefault(Function(m) m.kd_jenis_transaksi.ToLower() = "Perolehan".ToLower())
                            Dim ruangan = DbContext.Ruangans.FirstOrDefault(Function(m) m.kd_ruangan.ToLower() = "00000-Perolehan".ToLower())
                            Dim queryHapus = (From x In DbContext.HistoryDetailAssets
                                              From a In DbContext.DetailAssets.Where(Function(m) m.id = x.id_detail_asset).DefaultIfEmpty()
                                              From d In DbContext.JenisTransaksies.Where(Function(m) m.id = x.id_jenis_transaksi).DefaultIfEmpty()
                                              Where a.id_asset = result.id AndAlso d.id = jenisTransaksi.id
                                              Select x)
                            DbContext.HistoryDetailAssets.RemoveRange(queryHapus)
                            DbContext.Assets.Remove(result)
                            DbContext.SaveChanges()
                            tran.Commit()
                            tran = Nothing
                            hasil = New Tuple(Of Boolean, String)(True, "Data telah dihapus")
                        Else
                            hasil = New Tuple(Of Boolean, String)(False, "Data telah dipakai di History Detil Asset atau Pemakaian")
                        End If
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

        Public Function LookUp(id As Guid) As Tuple(Of Boolean, String, List(Of DetilAssetLookUpDTo)) Implements IAsset.LookUp
            Dim hasil As New Tuple(Of Boolean, String, List(Of DetilAssetLookUpDTo))(False, String.Empty, Nothing)
            Using dlg As New WaitDialogForm("Sedang merefresh data ...", "Mohon tunggu sebentar")
                Try
                    Dim query = (From d In DbContext.DetailAssets
                                 Join a In DbContext.Assets On a.id Equals d.id_asset
                                 Join k In DbContext.KategoriAssets On k.id Equals a.id_kategori
                                 From p In DbContext.Pemutihans.Where(Function(m) m.id_detail_asset = d.id).DefaultIfEmpty()
                                 Where (d.id = id OrElse p Is Nothing)
                                 Select New Model.DetilAssetLookUpDTo With {
                                    .ID = d.id,
                                    .Barcode = d.barcode,
                                    .KategoriAsset = k.nama_kategori,
                                    .KodeAsset = a.kd_asset,
                                    .NamaAsset = a.nama_asset})
                    hasil = New Tuple(Of Boolean, String, List(Of Model.DetilAssetLookUpDTo))(True, "Data ditemukan", query.ToList())
                Catch ex As Exception
                    Log.Error(ex, "Error : " & ex.Message)
                    XtraMessageBox.Show("Info Kesalahan : " & ex.Message, Application.ProductName)
                    hasil = New Tuple(Of Boolean, String, List(Of Model.DetilAssetLookUpDTo))(False, "Info Kesalahan : " & ex.Message, Nothing)
                End Try
            End Using
            Return hasil
        End Function
    End Class
End Namespace
