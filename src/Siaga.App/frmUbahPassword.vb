Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class frmUbahPassword
    Private ReadOnly Rep As Services.IPengguna = New Repository.Pengguna()

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        DxErrorProvider1.ClearErrors()

        If (String.IsNullOrEmpty(txtPasswordLama.Text) OrElse String.IsNullOrWhiteSpace(txtPasswordLama.Text)) Then
            DxErrorProvider1.SetError(txtPasswordLama, "Password lama belum diisi.")
        End If
        If (String.IsNullOrEmpty(txtPasswordBaru.Text) OrElse String.IsNullOrWhiteSpace(txtPasswordBaru.Text)) Then
            DxErrorProvider1.SetError(txtPasswordBaru, "Password baru belum diisi.")
        End If
        If (txtPasswordBaru.Text.ToLower() <> txtPasswordBaru2.Text.ToLower()) Then
            DxErrorProvider1.SetError(txtPasswordBaru2, "Password baru dan Ulangi password baru belum sesuai.")
        End If
        If (txtPasswordBaru.Text.ToLower() = txtPasswordLama.Text.ToLower()) Then
            DxErrorProvider1.SetError(txtPasswordBaru, "Password baru dan Password lama tidak boleh sama.")
        End If
        If (txtPasswordBaru.Text.ToLower().Length <= 5) Then
            DxErrorProvider1.SetError(txtPasswordBaru, "Password baru harus melebihi 5 karakter.")
        End If

        If (Not DxErrorProvider1.HasErrors) Then
            Dim result = Rep.ChangePassword(Program.UserLogin, txtPasswordLama.Text, txtPasswordBaru.Text)
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

    Private Sub txtPasswordLama_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtPasswordLama.ButtonClick, txtPasswordBaru.ButtonClick, txtPasswordBaru2.ButtonClick
        If (e.Button.Index = 0) Then
            If (TryCast(sender, ButtonEdit).Properties.PasswordChar <> CChar(String.Empty)) Then
                TryCast(sender, ButtonEdit).Properties.PasswordChar = CChar(String.Empty)
                TryCast(sender, ButtonEdit).Properties.Buttons(0).ImageOptions.SvgImage = My.Resources.hide
            Else
                TryCast(sender, ButtonEdit).Properties.PasswordChar = "*"c
                TryCast(sender, ButtonEdit).Properties.Buttons(0).ImageOptions.SvgImage = My.Resources.show
            End If
        End If
    End Sub
End Class