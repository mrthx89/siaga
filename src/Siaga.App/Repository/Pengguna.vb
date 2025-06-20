Imports Siaga.App.Data.Entity
Imports Siaga.App.Services
Imports Siaga.App.Data
Imports DevExpress.XtraEditors
Imports DevExpress.Utils
Imports Serilog

Namespace Repository
    Public Class Pengguna
        Implements Services.IPengguna

        Private ReadOnly Context As New Data.ApplicationDbContext

        Public Function GetLogin(UserId As String, Password As String) As Tuple(Of Boolean, String, Data.Entity.Pengguna) Implements IPengguna.GetLogin
            Dim Hasil As New Tuple(Of Boolean, String, Data.Entity.Pengguna)(False, String.Empty, Nothing)
            Using dlg As New WaitDialogForm("Sedang merefresh data ...", "Please wait")
                Try
                    dlg.TopMost = False
                    dlg.Show()
                    dlg.Focus()

                    Dim pengguna = Context.Penggunas.AsNoTracking().FirstOrDefault(Function(m) m.user.ToLower() = UserId.ToLower())
                    If (pengguna IsNot Nothing) Then
                        If (pengguna.password = Utils.Utils.HashPassword(Password.ToUpper())) Then
                            pengguna.password = Password
                            Hasil = New Tuple(Of Boolean, String, Entity.Pengguna)(True, "User ditemukan", pengguna)
                        Else
                            Hasil = New Tuple(Of Boolean, String, Entity.Pengguna)(False, "Password yang anda masukkan salah", Nothing)
                        End If
                    Else
                        Hasil = New Tuple(Of Boolean, String, Entity.Pengguna)(False, "Pengguna tidak ditemukan", Nothing)
                    End If
                Catch ex As Exception
                    Log.Error(ex, "Error : " & ex.Message)
                    XtraMessageBox.Show("Error : " & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
            Return Hasil
        End Function

        Public Function GetUser(Id As Guid) As Tuple(Of Boolean, String, Data.Entity.Pengguna) Implements IPengguna.GetUser
            Throw New NotImplementedException()
        End Function

        Public Function GetUsers() As Tuple(Of Boolean, String, List(Of Data.Entity.Pengguna)) Implements IPengguna.GetUsers
            Throw New NotImplementedException()
        End Function

        Public Function ChangePassword(User As Entity.Pengguna, OldPassword As String, NewPassword As String) As Tuple(Of Boolean, String, Entity.Pengguna) Implements IPengguna.ChangePassword
            Dim Hasil As New Tuple(Of Boolean, String, Data.Entity.Pengguna)(False, String.Empty, Nothing)
            Using dlg As New WaitDialogForm("Sedang mengubah data ...", "Please wait")
                Try
                    dlg.TopMost = False
                    dlg.Show()
                    dlg.Focus()

                    Dim pengguna = Context.Penggunas.FirstOrDefault(Function(m) m.id = User.id)
                    If (pengguna IsNot Nothing) Then
                        If (pengguna.password = Utils.Utils.HashPassword(OldPassword.ToUpper())) Then
                            pengguna.password = Utils.Utils.HashPassword(NewPassword.ToUpper())
                            Context.Entry(pengguna).CurrentValues().SetValues(pengguna)
                            Context.SaveChanges()
                            pengguna.password = NewPassword
                            Hasil = New Tuple(Of Boolean, String, Entity.Pengguna)(True, "User ditemukan", pengguna)
                        Else
                            Hasil = New Tuple(Of Boolean, String, Entity.Pengguna)(False, "Password yang anda masukkan salah", Nothing)
                        End If
                    Else
                        Hasil = New Tuple(Of Boolean, String, Entity.Pengguna)(False, "Pengguna tidak ditemukan", Nothing)
                    End If
                Catch ex As Exception
                    Log.Error(ex, "Error : " & ex.Message)
                    XtraMessageBox.Show("Error : " & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
            Return Hasil
        End Function
    End Class
End Namespace
