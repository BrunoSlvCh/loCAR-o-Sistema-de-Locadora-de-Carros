<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_menu))
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.btn_clientes = New System.Windows.Forms.Button()
        Me.btn_carros = New System.Windows.Forms.Button()
        Me.btn_locacoes = New System.Windows.Forms.Button()
        Me.btn_devolucao = New System.Windows.Forms.Button()
        Me.btn_adm = New System.Windows.Forms.Button()
        Me.btn_sair = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_titulo
        '
        Me.lbl_titulo.BackColor = System.Drawing.Color.SteelBlue
        Me.lbl_titulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_titulo.ForeColor = System.Drawing.Color.White
        Me.lbl_titulo.Location = New System.Drawing.Point(0, 0)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(600, 45)
        Me.lbl_titulo.TabIndex = 0
        Me.lbl_titulo.Text = "LOCADORA DE CARROS - MENU"
        Me.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_usuario
        '
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic)
        Me.lbl_usuario.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_usuario.Location = New System.Drawing.Point(10, 55)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(53, 15)
        Me.lbl_usuario.TabIndex = 1
        Me.lbl_usuario.Text = "Usuário:"
        '
        'btn_clientes
        '
        Me.btn_clientes.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_clientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btn_clientes.ForeColor = System.Drawing.Color.White
        Me.btn_clientes.Location = New System.Drawing.Point(60, 90)
        Me.btn_clientes.Name = "btn_clientes"
        Me.btn_clientes.Size = New System.Drawing.Size(220, 55)
        Me.btn_clientes.TabIndex = 2
        Me.btn_clientes.Text = "CLIENTES"
        Me.btn_clientes.UseVisualStyleBackColor = False
        '
        'btn_carros
        '
        Me.btn_carros.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_carros.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btn_carros.ForeColor = System.Drawing.Color.White
        Me.btn_carros.Location = New System.Drawing.Point(320, 90)
        Me.btn_carros.Name = "btn_carros"
        Me.btn_carros.Size = New System.Drawing.Size(220, 55)
        Me.btn_carros.TabIndex = 3
        Me.btn_carros.Text = "CARROS"
        Me.btn_carros.UseVisualStyleBackColor = False
        '
        'btn_locacoes
        '
        Me.btn_locacoes.BackColor = System.Drawing.Color.SeaGreen
        Me.btn_locacoes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btn_locacoes.ForeColor = System.Drawing.Color.White
        Me.btn_locacoes.Location = New System.Drawing.Point(60, 170)
        Me.btn_locacoes.Name = "btn_locacoes"
        Me.btn_locacoes.Size = New System.Drawing.Size(220, 55)
        Me.btn_locacoes.TabIndex = 4
        Me.btn_locacoes.Text = "LOCAÇÕES"
        Me.btn_locacoes.UseVisualStyleBackColor = False
        '
        'btn_devolucao
        '
        Me.btn_devolucao.BackColor = System.Drawing.Color.SeaGreen
        Me.btn_devolucao.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btn_devolucao.ForeColor = System.Drawing.Color.White
        Me.btn_devolucao.Location = New System.Drawing.Point(320, 170)
        Me.btn_devolucao.Name = "btn_devolucao"
        Me.btn_devolucao.Size = New System.Drawing.Size(220, 55)
        Me.btn_devolucao.TabIndex = 5
        Me.btn_devolucao.Text = "DEVOLUÇÃO"
        Me.btn_devolucao.UseVisualStyleBackColor = False
        '
        'btn_adm
        '
        Me.btn_adm.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btn_adm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btn_adm.ForeColor = System.Drawing.Color.White
        Me.btn_adm.Location = New System.Drawing.Point(60, 250)
        Me.btn_adm.Name = "btn_adm"
        Me.btn_adm.Size = New System.Drawing.Size(220, 55)
        Me.btn_adm.TabIndex = 6
        Me.btn_adm.Text = "PAINEL ADM"
        Me.btn_adm.UseVisualStyleBackColor = False
        '
        'btn_sair
        '
        Me.btn_sair.BackColor = System.Drawing.Color.Firebrick
        Me.btn_sair.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btn_sair.ForeColor = System.Drawing.Color.White
        Me.btn_sair.Location = New System.Drawing.Point(320, 250)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(220, 55)
        Me.btn_sair.TabIndex = 7
        Me.btn_sair.Text = "SAIR"
        Me.btn_sair.UseVisualStyleBackColor = False
        '
        'frm_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(600, 335)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.lbl_usuario)
        Me.Controls.Add(Me.btn_clientes)
        Me.Controls.Add(Me.btn_carros)
        Me.Controls.Add(Me.btn_locacoes)
        Me.Controls.Add(Me.btn_devolucao)
        Me.Controls.Add(Me.btn_adm)
        Me.Controls.Add(Me.btn_sair)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu - Locadora de Carros"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_titulo As Label
    Friend WithEvents lbl_usuario As Label
    Friend WithEvents btn_clientes As Button
    Friend WithEvents btn_carros As Button
    Friend WithEvents btn_locacoes As Button
    Friend WithEvents btn_devolucao As Button
    Friend WithEvents btn_adm As Button
    Friend WithEvents btn_sair As Button
End Class
