<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_login
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login))
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.lbl_senha = New System.Windows.Forms.Label()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.btn_entrar = New System.Windows.Forms.Button()
        Me.btn_esqueci = New System.Windows.Forms.Button()
        Me.btn_sair = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_titulo
        '
        Me.lbl_titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_titulo.Location = New System.Drawing.Point(50, 20)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(300, 30)
        Me.lbl_titulo.TabIndex = 0
        Me.lbl_titulo.Text = "LOCADORA DE CARROS"
        Me.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_usuario
        '
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_usuario.Location = New System.Drawing.Point(50, 70)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(72, 15)
        Me.lbl_usuario.TabIndex = 1
        Me.lbl_usuario.Text = "USUÁRIO:"
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(50, 90)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(300, 20)
        Me.txt_usuario.TabIndex = 0
        '
        'lbl_senha
        '
        Me.lbl_senha.AutoSize = True
        Me.lbl_senha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_senha.Location = New System.Drawing.Point(50, 125)
        Me.lbl_senha.Name = "lbl_senha"
        Me.lbl_senha.Size = New System.Drawing.Size(57, 15)
        Me.lbl_senha.TabIndex = 2
        Me.lbl_senha.Text = "SENHA:"
        '
        'txt_senha
        '
        Me.txt_senha.Location = New System.Drawing.Point(50, 145)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_senha.Size = New System.Drawing.Size(300, 20)
        Me.txt_senha.TabIndex = 1
        '
        'btn_entrar
        '
        Me.btn_entrar.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_entrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_entrar.ForeColor = System.Drawing.Color.White
        Me.btn_entrar.Location = New System.Drawing.Point(50, 190)
        Me.btn_entrar.Name = "btn_entrar"
        Me.btn_entrar.Size = New System.Drawing.Size(140, 35)
        Me.btn_entrar.TabIndex = 2
        Me.btn_entrar.Text = "ENTRAR"
        Me.btn_entrar.UseVisualStyleBackColor = False
        '
        'btn_esqueci
        '
        Me.btn_esqueci.BackColor = System.Drawing.Color.Orange
        Me.btn_esqueci.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btn_esqueci.ForeColor = System.Drawing.Color.White
        Me.btn_esqueci.Location = New System.Drawing.Point(50, 240)
        Me.btn_esqueci.Name = "btn_esqueci"
        Me.btn_esqueci.Size = New System.Drawing.Size(300, 30)
        Me.btn_esqueci.TabIndex = 3
        Me.btn_esqueci.Text = "ESQUECEU A SENHA?"
        Me.btn_esqueci.UseVisualStyleBackColor = False
        '
        'btn_sair
        '
        Me.btn_sair.BackColor = System.Drawing.Color.Firebrick
        Me.btn_sair.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_sair.ForeColor = System.Drawing.Color.White
        Me.btn_sair.Location = New System.Drawing.Point(210, 190)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(140, 35)
        Me.btn_sair.TabIndex = 4
        Me.btn_sair.Text = "SAIR"
        Me.btn_sair.UseVisualStyleBackColor = False
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(400, 295)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.lbl_usuario)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.lbl_senha)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.btn_entrar)
        Me.Controls.Add(Me.btn_esqueci)
        Me.Controls.Add(Me.btn_sair)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login - Locadora de Carros"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_titulo As Label
    Friend WithEvents lbl_usuario As Label
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents lbl_senha As Label
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents btn_entrar As Button
    Friend WithEvents btn_esqueci As Button
    Friend WithEvents btn_sair As Button
End Class
