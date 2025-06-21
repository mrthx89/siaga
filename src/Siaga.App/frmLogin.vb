Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports Serilog

Public Class frmLogin
    Public Property FileMeet As String = IO.Path.Combine(Program.FolderApp, "System", "Logo.png")
    Private Rep As Services.IPengguna = New Repository.Pengguna()

    Private Sub TextEdit2_EditValueChanged(sender As Object, e As EventArgs) Handles txtPassword.EditValueChanged

    End Sub

    Private Sub TextEdit2_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtPassword.ButtonClick
        If (e.Button.Index = 0) Then
            If (txtPassword.Properties.PasswordChar.ToString().Length >= 1) Then
                txtPassword.Properties.PasswordChar = CChar(String.Empty)
                txtPassword.Properties.Buttons(0).ImageOptions.SvgImage = My.Resources.hide
            Else
                txtPassword.Properties.PasswordChar = "*"c
                txtPassword.Properties.Buttons(0).ImageOptions.SvgImage = My.Resources.show
            End If
        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (System.IO.File.Exists(FileMeet)) Then
            PictureEdit1.Image = Image.FromFile(FileMeet)
        End If
        lbAppVersion.Text = $"App ver {Application.ProductVersion}"
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        DxErrorProvider1.ClearErrors()
        If (String.IsNullOrEmpty(txtUserName.Text) OrElse String.IsNullOrWhiteSpace(txtUserName.Text)) Then
            DxErrorProvider1.SetError(txtUserName, "Username harus diisi")
        End If

        If (String.IsNullOrEmpty(txtPassword.Text) OrElse String.IsNullOrWhiteSpace(txtPassword.Text)) Then
            DxErrorProvider1.SetError(txtPassword, "Password harus diisi")
        End If

        If (Not DxErrorProvider1.HasErrors) Then
            Dim result = Rep.GetLogin(txtUserName.Text, txtPassword.Text)
            If (result.Item1) Then
                Program.UserLogin = result.Item3
                DialogResult = DialogResult.OK
                Me.Close()
            Else
                XtraMessageBox.Show(result.Item2, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            XtraMessageBox.Show(String.Join(Environment.NewLine, DxErrorProvider1.GetControlsWithError().Select(Function(m) DxErrorProvider1.GetError(m))), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub cmdSetting_Click(sender As Object, e As EventArgs) Handles cmdSetting.Click
        cmdSetting.Enabled = False
        Using frm As New frmSetting
            Try
                If (frm.ShowDialog(Me) = DialogResult.OK) Then
                    Application.Restart()
                End If
            Catch ex As Exception
                Log.Logger.Error(ex, "Info Kesalahan : " & ex.Message)
                XtraMessageBox.Show("Info Kesalahan : " & ex.Message)
            End Try
        End Using
        cmdSetting.Enabled = True
    End Sub
End Class