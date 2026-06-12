<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_adm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_adm))
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.grp_cadastro = New System.Windows.Forms.GroupBox()
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.txt_novo_usuario = New System.Windows.Forms.TextBox()
        Me.lbl_senha = New System.Windows.Forms.Label()
        Me.txt_nova_senha = New System.Windows.Forms.TextBox()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.txt_novo_email = New System.Windows.Forms.TextBox()
        Me.chk_adm = New System.Windows.Forms.CheckBox()
        Me.btn_cadastrar = New System.Windows.Forms.Button()
        Me.grp_gerenciar = New System.Windows.Forms.GroupBox()
        Me.dgv_contas = New System.Windows.Forms.DataGridView()
        Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_bloquear = New System.Windows.Forms.Button()
        Me.btn_ativar = New System.Windows.Forms.Button()
        Me.btn_excluir = New System.Windows.Forms.Button()
        Me.btn_ir_menu = New System.Windows.Forms.Button()
        Me.btn_sair = New System.Windows.Forms.Button()
        Me.grp_cadastro.SuspendLayout()
        Me.grp_gerenciar.SuspendLayout()
        CType(Me.dgv_contas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_titulo
        '
        Me.lbl_titulo.BackColor = System.Drawing.Color.SteelBlue
        Me.lbl_titulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_titulo.ForeColor = System.Drawing.Color.White
        Me.lbl_titulo.Location = New System.Drawing.Point(0, 0)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(780, 40)
        Me.lbl_titulo.TabIndex = 0
        Me.lbl_titulo.Text = "PAINEL DO ADMINISTRADOR"
        Me.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grp_cadastro
        '
        Me.grp_cadastro.Controls.Add(Me.lbl_usuario)
        Me.grp_cadastro.Controls.Add(Me.txt_novo_usuario)
        Me.grp_cadastro.Controls.Add(Me.lbl_senha)
        Me.grp_cadastro.Controls.Add(Me.txt_nova_senha)
        Me.grp_cadastro.Controls.Add(Me.lbl_email)
        Me.grp_cadastro.Controls.Add(Me.txt_novo_email)
        Me.grp_cadastro.Controls.Add(Me.chk_adm)
        Me.grp_cadastro.Controls.Add(Me.btn_cadastrar)
        Me.grp_cadastro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.grp_cadastro.Location = New System.Drawing.Point(10, 50)
        Me.grp_cadastro.Name = "grp_cadastro"
        Me.grp_cadastro.Size = New System.Drawing.Size(760, 120)
        Me.grp_cadastro.TabIndex = 1
        Me.grp_cadastro.TabStop = False
        Me.grp_cadastro.Text = "CADASTRO DE CONTAS"
        '
        'lbl_usuario
        '
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.Location = New System.Drawing.Point(10, 25)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(72, 15)
        Me.lbl_usuario.TabIndex = 0
        Me.lbl_usuario.Text = "USUÁRIO:"
        '
        'txt_novo_usuario
        '
        Me.txt_novo_usuario.Location = New System.Drawing.Point(10, 45)
        Me.txt_novo_usuario.Name = "txt_novo_usuario"
        Me.txt_novo_usuario.Size = New System.Drawing.Size(140, 21)
        Me.txt_novo_usuario.TabIndex = 1
        '
        'lbl_senha
        '
        Me.lbl_senha.AutoSize = True
        Me.lbl_senha.Location = New System.Drawing.Point(165, 25)
        Me.lbl_senha.Name = "lbl_senha"
        Me.lbl_senha.Size = New System.Drawing.Size(57, 15)
        Me.lbl_senha.TabIndex = 2
        Me.lbl_senha.Text = "SENHA:"
        '
        'txt_nova_senha
        '
        Me.txt_nova_senha.Location = New System.Drawing.Point(165, 45)
        Me.txt_nova_senha.Name = "txt_nova_senha"
        Me.txt_nova_senha.Size = New System.Drawing.Size(120, 21)
        Me.txt_nova_senha.TabIndex = 3
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Location = New System.Drawing.Point(300, 25)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(57, 15)
        Me.lbl_email.TabIndex = 4
        Me.lbl_email.Text = "E-MAIL:"
        '
        'txt_novo_email
        '
        Me.txt_novo_email.Location = New System.Drawing.Point(300, 45)
        Me.txt_novo_email.Name = "txt_novo_email"
        Me.txt_novo_email.Size = New System.Drawing.Size(200, 21)
        Me.txt_novo_email.TabIndex = 5
        '
        'chk_adm
        '
        Me.chk_adm.AutoSize = True
        Me.chk_adm.Location = New System.Drawing.Point(515, 47)
        Me.chk_adm.Name = "chk_adm"
        Me.chk_adm.Size = New System.Drawing.Size(77, 19)
        Me.chk_adm.TabIndex = 6
        Me.chk_adm.Text = "É ADM?"
        '
        'btn_cadastrar
        '
        Me.btn_cadastrar.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_cadastrar.ForeColor = System.Drawing.Color.White
        Me.btn_cadastrar.Location = New System.Drawing.Point(620, 40)
        Me.btn_cadastrar.Name = "btn_cadastrar"
        Me.btn_cadastrar.Size = New System.Drawing.Size(120, 30)
        Me.btn_cadastrar.TabIndex = 7
        Me.btn_cadastrar.Text = "CADASTRAR"
        Me.btn_cadastrar.UseVisualStyleBackColor = False
        '
        'grp_gerenciar
        '
        Me.grp_gerenciar.Controls.Add(Me.dgv_contas)
        Me.grp_gerenciar.Controls.Add(Me.btn_bloquear)
        Me.grp_gerenciar.Controls.Add(Me.btn_ativar)
        Me.grp_gerenciar.Controls.Add(Me.btn_excluir)
        Me.grp_gerenciar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.grp_gerenciar.Location = New System.Drawing.Point(10, 180)
        Me.grp_gerenciar.Name = "grp_gerenciar"
        Me.grp_gerenciar.Size = New System.Drawing.Size(760, 280)
        Me.grp_gerenciar.TabIndex = 2
        Me.grp_gerenciar.TabStop = False
        Me.grp_gerenciar.Text = "GERENCIAMENTO DE CONTAS"
        '
        'dgv_contas
        '
        Me.dgv_contas.AllowUserToAddRows = False
        Me.dgv_contas.AllowUserToDeleteRows = False
        Me.dgv_contas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_contas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_contas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id, Me.col_usuario, Me.col_tipo, Me.col_email, Me.col_status})
        Me.dgv_contas.Location = New System.Drawing.Point(10, 25)
        Me.dgv_contas.Name = "dgv_contas"
        Me.dgv_contas.ReadOnly = True
        Me.dgv_contas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_contas.Size = New System.Drawing.Size(740, 200)
        Me.dgv_contas.TabIndex = 0
        '
        'col_id
        '
        Me.col_id.HeaderText = "ID"
        Me.col_id.Name = "col_id"
        Me.col_id.ReadOnly = True
        Me.col_id.Visible = False
        '
        'col_usuario
        '
        Me.col_usuario.HeaderText = "USUÁRIO"
        Me.col_usuario.Name = "col_usuario"
        Me.col_usuario.ReadOnly = True
        '
        'col_tipo
        '
        Me.col_tipo.HeaderText = "TIPO"
        Me.col_tipo.Name = "col_tipo"
        Me.col_tipo.ReadOnly = True
        '
        'col_email
        '
        Me.col_email.HeaderText = "E-MAIL"
        Me.col_email.Name = "col_email"
        Me.col_email.ReadOnly = True
        '
        'col_status
        '
        Me.col_status.HeaderText = "STATUS"
        Me.col_status.Name = "col_status"
        Me.col_status.ReadOnly = True
        '
        'btn_bloquear
        '
        Me.btn_bloquear.BackColor = System.Drawing.Color.Orange
        Me.btn_bloquear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_bloquear.ForeColor = System.Drawing.Color.White
        Me.btn_bloquear.Location = New System.Drawing.Point(10, 235)
        Me.btn_bloquear.Name = "btn_bloquear"
        Me.btn_bloquear.Size = New System.Drawing.Size(150, 32)
        Me.btn_bloquear.TabIndex = 1
        Me.btn_bloquear.Text = "BLOQUEAR ACESSO"
        Me.btn_bloquear.UseVisualStyleBackColor = False
        '
        'btn_ativar
        '
        Me.btn_ativar.BackColor = System.Drawing.Color.SeaGreen
        Me.btn_ativar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_ativar.ForeColor = System.Drawing.Color.White
        Me.btn_ativar.Location = New System.Drawing.Point(175, 235)
        Me.btn_ativar.Name = "btn_ativar"
        Me.btn_ativar.Size = New System.Drawing.Size(150, 32)
        Me.btn_ativar.TabIndex = 2
        Me.btn_ativar.Text = "ATIVAR ACESSO"
        Me.btn_ativar.UseVisualStyleBackColor = False
        '
        'btn_excluir
        '
        Me.btn_excluir.BackColor = System.Drawing.Color.Firebrick
        Me.btn_excluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_excluir.ForeColor = System.Drawing.Color.White
        Me.btn_excluir.Location = New System.Drawing.Point(340, 235)
        Me.btn_excluir.Name = "btn_excluir"
        Me.btn_excluir.Size = New System.Drawing.Size(150, 32)
        Me.btn_excluir.TabIndex = 3
        Me.btn_excluir.Text = "EXCLUIR ACESSO"
        Me.btn_excluir.UseVisualStyleBackColor = False
        '
        'btn_ir_menu
        '
        Me.btn_ir_menu.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_ir_menu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_ir_menu.ForeColor = System.Drawing.Color.White
        Me.btn_ir_menu.Location = New System.Drawing.Point(10, 475)
        Me.btn_ir_menu.Name = "btn_ir_menu"
        Me.btn_ir_menu.Size = New System.Drawing.Size(170, 35)
        Me.btn_ir_menu.TabIndex = 3
        Me.btn_ir_menu.Text = "IR PARA O MENU"
        Me.btn_ir_menu.UseVisualStyleBackColor = False
        '
        'btn_sair
        '
        Me.btn_sair.BackColor = System.Drawing.Color.Firebrick
        Me.btn_sair.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_sair.ForeColor = System.Drawing.Color.White
        Me.btn_sair.Location = New System.Drawing.Point(600, 475)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(170, 35)
        Me.btn_sair.TabIndex = 4
        Me.btn_sair.Text = "SAIR DO SISTEMA"
        Me.btn_sair.UseVisualStyleBackColor = False
        '
        'frm_adm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(780, 525)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.grp_cadastro)
        Me.Controls.Add(Me.grp_gerenciar)
        Me.Controls.Add(Me.btn_ir_menu)
        Me.Controls.Add(Me.btn_sair)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_adm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Painel ADM - Locadora de Carros"
        Me.grp_cadastro.ResumeLayout(False)
        Me.grp_cadastro.PerformLayout()
        Me.grp_gerenciar.ResumeLayout(False)
        CType(Me.dgv_contas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl_titulo As Label
    Friend WithEvents grp_cadastro As GroupBox
    Friend WithEvents lbl_usuario As Label
    Friend WithEvents txt_novo_usuario As TextBox
    Friend WithEvents lbl_senha As Label
    Friend WithEvents txt_nova_senha As TextBox
    Friend WithEvents lbl_email As Label
    Friend WithEvents txt_novo_email As TextBox
    Friend WithEvents chk_adm As CheckBox
    Friend WithEvents btn_cadastrar As Button
    Friend WithEvents grp_gerenciar As GroupBox
    Friend WithEvents dgv_contas As DataGridView
    Friend WithEvents col_id As DataGridViewTextBoxColumn
    Friend WithEvents col_usuario As DataGridViewTextBoxColumn
    Friend WithEvents col_tipo As DataGridViewTextBoxColumn
    Friend WithEvents col_email As DataGridViewTextBoxColumn
    Friend WithEvents col_status As DataGridViewTextBoxColumn
    Friend WithEvents btn_bloquear As Button
    Friend WithEvents btn_ativar As Button
    Friend WithEvents btn_excluir As Button
    Friend WithEvents btn_ir_menu As Button
    Friend WithEvents btn_sair As Button
End Class
