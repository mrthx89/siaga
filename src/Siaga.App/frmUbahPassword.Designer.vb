<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUbahPassword
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim EditorButtonImageOptions2 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim EditorButtonImageOptions3 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPasswordBaru = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPasswordLama = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPasswordBaru2 = New DevExpress.XtraEditors.ButtonEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.DxErrorProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        CType(Me.txtPasswordBaru.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPasswordLama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPasswordBaru2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 103)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(71, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Password Baru"
        '
        'txtPasswordBaru
        '
        Me.txtPasswordBaru.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPasswordBaru.EnterMoveNextControl = True
        Me.txtPasswordBaru.Location = New System.Drawing.Point(121, 97)
        Me.txtPasswordBaru.Name = "txtPasswordBaru"
        Me.txtPasswordBaru.Properties.AutoHeight = False
        EditorButtonImageOptions1.SvgImage = Global.Siaga.App.My.Resources.Resources.show
        EditorButtonImageOptions1.SvgImageSize = New System.Drawing.Size(20, 20)
        Me.txtPasswordBaru.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(EditorButtonImageOptions1, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, Nothing)})
        Me.txtPasswordBaru.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPasswordBaru.Properties.MaxLength = 50
        Me.txtPasswordBaru.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswordBaru.Size = New System.Drawing.Size(174, 26)
        Me.txtPasswordBaru.TabIndex = 4
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 71)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Password Lama"
        '
        'txtPasswordLama
        '
        Me.txtPasswordLama.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPasswordLama.EnterMoveNextControl = True
        Me.txtPasswordLama.Location = New System.Drawing.Point(121, 65)
        Me.txtPasswordLama.Name = "txtPasswordLama"
        Me.txtPasswordLama.Properties.AutoHeight = False
        EditorButtonImageOptions2.SvgImage = Global.Siaga.App.My.Resources.Resources.show
        EditorButtonImageOptions2.SvgImageSize = New System.Drawing.Size(20, 20)
        Me.txtPasswordLama.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(EditorButtonImageOptions2, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, Nothing)})
        Me.txtPasswordLama.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPasswordLama.Properties.MaxLength = 50
        Me.txtPasswordLama.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswordLama.Size = New System.Drawing.Size(174, 26)
        Me.txtPasswordLama.TabIndex = 2
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Options.UseTextOptions = True
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl3.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl3.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(283, 47)
        Me.LabelControl3.TabIndex = 0
        Me.LabelControl3.Text = "Untuk mengubah password anda, anda perlu memasukkan password lama dan password ba" &
    "ru anda."
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(12, 135)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(103, 13)
        Me.LabelControl4.TabIndex = 5
        Me.LabelControl4.Text = "Ulangi Password Baru"
        '
        'txtPasswordBaru2
        '
        Me.txtPasswordBaru2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPasswordBaru2.EnterMoveNextControl = True
        Me.txtPasswordBaru2.Location = New System.Drawing.Point(121, 129)
        Me.txtPasswordBaru2.Name = "txtPasswordBaru2"
        Me.txtPasswordBaru2.Properties.AutoHeight = False
        EditorButtonImageOptions3.SvgImage = Global.Siaga.App.My.Resources.Resources.show
        EditorButtonImageOptions3.SvgImageSize = New System.Drawing.Size(20, 20)
        Me.txtPasswordBaru2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(EditorButtonImageOptions3, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, Nothing)})
        Me.txtPasswordBaru2.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPasswordBaru2.Properties.MaxLength = 50
        Me.txtPasswordBaru2.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswordBaru2.Size = New System.Drawing.Size(174, 26)
        Me.txtPasswordBaru2.TabIndex = 6
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Location = New System.Drawing.Point(163, 168)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(132, 23)
        Me.SimpleButton1.TabIndex = 7
        Me.SimpleButton1.Text = "&Rubah Password"
        '
        'DxErrorProvider1
        '
        Me.DxErrorProvider1.ContainerControl = Me
        '
        'frmUbahPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(307, 203)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txtPasswordBaru2)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtPasswordLama)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtPasswordBaru)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUbahPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Ubah Password"
        CType(Me.txtPasswordBaru.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPasswordLama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPasswordBaru2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPasswordBaru As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPasswordLama As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPasswordBaru2 As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DxErrorProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
End Class
