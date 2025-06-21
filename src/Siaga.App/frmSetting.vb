Imports System.Configuration
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.Utils
Imports Serilog

Public Class frmSetting
    Private Sub frmSetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connStr = ConfigurationManager.ConnectionStrings("DefaultConnection")?.ConnectionString

        If Not String.IsNullOrEmpty(connStr) Then
            Dim builder = New MySql.Data.MySqlClient.MySqlConnectionStringBuilder(connStr)
            txtServer.Text = builder.Server
            txtDatabase.Text = builder.Database
            txtUserId.Text = builder.UserID
            txtPassword.Text = builder.Password
            txtTimeout.EditValue = builder.DefaultCommandTimeout
        Else
            txtServer.Text = "localhost"
            txtDatabase.Text = "dbsiaga"
            txtUserId.Text = "root"
            txtPassword.Text = ""
            txtTimeout.EditValue = 300
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        SimpleButton1.Enabled = False
        Using dlg As New WaitDialogForm("Sedang mengkoneksikan database ...", "Please wait")
            Using db As New MySqlConnection("")
                Try
                    dlg.TopMost = False
                    dlg.Show()
                    dlg.Focus()

                    Dim timeout As Integer = 0
                    Integer.TryParse(txtTimeout.EditValue.ToString(), timeout)
                    db.ConnectionString = $"server={txtServer.Text};user id={txtUserId.Text};password={txtPassword.Text};database=mysql;persistsecurityinfo=True;default command timeout={timeout};Connection Timeout=5;"
                    db.Open()

                    ' Buka konfigurasi
                    Dim config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)

                    ' Set connection string baru
                    Dim newConn As String = $"server={txtServer.Text};user id={txtUserId.Text};password={txtPassword.Text};database={txtDatabase.Text};persistsecurityinfo=True;default command timeout={timeout};"
                    If config.ConnectionStrings.ConnectionStrings("DefaultConnection") IsNot Nothing Then
                        config.ConnectionStrings.ConnectionStrings("DefaultConnection").ConnectionString = newConn
                    Else
                        config.ConnectionStrings.ConnectionStrings.Add(New ConnectionStringSettings("DefaultConnection", newConn, "MySql.Data.MySqlClient"))
                    End If

                    ' Simpan dan refresh
                    config.Save(ConfigurationSaveMode.Modified)
                    ConfigurationManager.RefreshSection("connectionStrings")

                    DialogResult = DialogResult.OK
                    Me.Close()
                Catch ex As Exception
                    Log.Logger.Error(ex, "Info Kesalahan : " & ex.Message)
                    XtraMessageBox.Show("Info Kesalahan : " & ex.Message)
                Finally
                    db.Dispose()
                    dlg.Dispose()
                End Try
            End Using
        End Using
        SimpleButton1.Enabled = True
    End Sub
End Class