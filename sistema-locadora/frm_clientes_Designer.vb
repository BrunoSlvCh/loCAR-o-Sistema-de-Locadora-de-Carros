<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_clientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_clientes))
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.grp_dados = New System.Windows.Forms.GroupBox()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.lbl_cpf = New System.Windows.Forms.Label()
        Me.txt_cpf = New System.Windows.Forms.TextBox()
        Me.lbl_nome = New System.Windows.Forms.Label()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.lbl_fone = New System.Windows.Forms.Label()
        Me.txt_fone = New System.Windows.Forms.TextBox()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.lbl_endereco = New System.Windows.Forms.Label()
        Me.txt_endereco = New System.Windows.Forms.TextBox()
        Me.btn_salvar = New System.Windows.Forms.Button()
        Me.btn_excluir = New System.Windows.Forms.Button()
        Me.btn_limpar = New System.Windows.Forms.Button()
        Me.lbl_pesquisar = New System.Windows.Forms.Label()
        Me.txt_pesquisar = New System.Windows.Forms.TextBox()
        Me.dgv_clientes = New System.Windows.Forms.DataGridView()
        Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_cpf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_fone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_endereco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.grp_dados.SuspendLayout()
        CType(Me.dgv_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lbl_titulo.Size = New System.Drawing.Size(880, 40)
        Me.lbl_titulo.TabIndex = 0
        Me.lbl_titulo.Text = "CADASTRO DE CLIENTES"
        Me.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grp_dados
        '
        Me.grp_dados.Controls.Add(Me.lbl_id)
        Me.grp_dados.Controls.Add(Me.txt_id)
        Me.grp_dados.Controls.Add(Me.lbl_cpf)
        Me.grp_dados.Controls.Add(Me.txt_cpf)
        Me.grp_dados.Controls.Add(Me.lbl_nome)
        Me.grp_dados.Controls.Add(Me.txt_nome)
        Me.grp_dados.Controls.Add(Me.lbl_fone)
        Me.grp_dados.Controls.Add(Me.txt_fone)
        Me.grp_dados.Controls.Add(Me.lbl_email)
        Me.grp_dados.Controls.Add(Me.txt_email)
        Me.grp_dados.Controls.Add(Me.lbl_endereco)
        Me.grp_dados.Controls.Add(Me.txt_endereco)
        Me.grp_dados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.grp_dados.Location = New System.Drawing.Point(10, 50)
        Me.grp_dados.Name = "grp_dados"
        Me.grp_dados.Size = New System.Drawing.Size(860, 140)
        Me.grp_dados.TabIndex = 1
        Me.grp_dados.TabStop = False
        Me.grp_dados.Text = "DADOS DO CLIENTE"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(10, 22)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(25, 15)
        Me.lbl_id.TabIndex = 0
        Me.lbl_id.Text = "ID:"
        '
        'txt_id
        '
        Me.txt_id.BackColor = System.Drawing.Color.LightGray
        Me.txt_id.Location = New System.Drawing.Point(10, 40)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(40, 21)
        Me.txt_id.TabIndex = 1
        '
        'lbl_cpf
        '
        Me.lbl_cpf.AutoSize = True
        Me.lbl_cpf.Location = New System.Drawing.Point(60, 22)
        Me.lbl_cpf.Name = "lbl_cpf"
        Me.lbl_cpf.Size = New System.Drawing.Size(37, 15)
        Me.lbl_cpf.TabIndex = 2
        Me.lbl_cpf.Text = "CPF:"
        '
        'txt_cpf
        '
        Me.txt_cpf.Location = New System.Drawing.Point(60, 40)
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(120, 21)
        Me.txt_cpf.TabIndex = 3
        '
        'lbl_nome
        '
        Me.lbl_nome.AutoSize = True
        Me.lbl_nome.Location = New System.Drawing.Point(195, 22)
        Me.lbl_nome.Name = "lbl_nome"
        Me.lbl_nome.Size = New System.Drawing.Size(52, 15)
        Me.lbl_nome.TabIndex = 4
        Me.lbl_nome.Text = "NOME:"
        '
        'txt_nome
        '
        Me.txt_nome.Location = New System.Drawing.Point(195, 40)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(220, 21)
        Me.txt_nome.TabIndex = 5
        '
        'lbl_fone
        '
        Me.lbl_fone.AutoSize = True
        Me.lbl_fone.Location = New System.Drawing.Point(430, 22)
        Me.lbl_fone.Name = "lbl_fone"
        Me.lbl_fone.Size = New System.Drawing.Size(82, 15)
        Me.lbl_fone.TabIndex = 6
        Me.lbl_fone.Text = "TELEFONE:"
        '
        'txt_fone
        '
        Me.txt_fone.Location = New System.Drawing.Point(430, 40)
        Me.txt_fone.Name = "txt_fone"
        Me.txt_fone.Size = New System.Drawing.Size(120, 21)
        Me.txt_fone.TabIndex = 7
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Location = New System.Drawing.Point(565, 22)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(57, 15)
        Me.lbl_email.TabIndex = 8
        Me.lbl_email.Text = "E-MAIL:"
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(565, 40)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(280, 21)
        Me.txt_email.TabIndex = 9
        '
        'lbl_endereco
        '
        Me.lbl_endereco.AutoSize = True
        Me.lbl_endereco.Location = New System.Drawing.Point(10, 75)
        Me.lbl_endereco.Name = "lbl_endereco"
        Me.lbl_endereco.Size = New System.Drawing.Size(87, 15)
        Me.lbl_endereco.TabIndex = 10
        Me.lbl_endereco.Text = "ENDEREÇO:"
        '
        'txt_endereco
        '
        Me.txt_endereco.Location = New System.Drawing.Point(10, 93)
        Me.txt_endereco.Name = "txt_endereco"
        Me.txt_endereco.Size = New System.Drawing.Size(835, 21)
        Me.txt_endereco.TabIndex = 11
        '
        'btn_salvar
        '
        Me.btn_salvar.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_salvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_salvar.ForeColor = System.Drawing.Color.White
        Me.btn_salvar.Location = New System.Drawing.Point(10, 200)
        Me.btn_salvar.Name = "btn_salvar"
        Me.btn_salvar.Size = New System.Drawing.Size(130, 32)
        Me.btn_salvar.TabIndex = 2
        Me.btn_salvar.Text = "SALVAR"
        Me.btn_salvar.UseVisualStyleBackColor = False
        '
        'btn_excluir
        '
        Me.btn_excluir.BackColor = System.Drawing.Color.Firebrick
        Me.btn_excluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_excluir.ForeColor = System.Drawing.Color.White
        Me.btn_excluir.Location = New System.Drawing.Point(155, 200)
        Me.btn_excluir.Name = "btn_excluir"
        Me.btn_excluir.Size = New System.Drawing.Size(130, 32)
        Me.btn_excluir.TabIndex = 3
        Me.btn_excluir.Text = "EXCLUIR"
        Me.btn_excluir.UseVisualStyleBackColor = False
        '
        'btn_limpar
        '
        Me.btn_limpar.BackColor = System.Drawing.Color.DimGray
        Me.btn_limpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_limpar.ForeColor = System.Drawing.Color.White
        Me.btn_limpar.Location = New System.Drawing.Point(300, 200)
        Me.btn_limpar.Name = "btn_limpar"
        Me.btn_limpar.Size = New System.Drawing.Size(130, 32)
        Me.btn_limpar.TabIndex = 4
        Me.btn_limpar.Text = "LIMPAR"
        Me.btn_limpar.UseVisualStyleBackColor = False
        '
        'lbl_pesquisar
        '
        Me.lbl_pesquisar.AutoSize = True
        Me.lbl_pesquisar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_pesquisar.Location = New System.Drawing.Point(10, 245)
        Me.lbl_pesquisar.Name = "lbl_pesquisar"
        Me.lbl_pesquisar.Size = New System.Drawing.Size(189, 15)
        Me.lbl_pesquisar.TabIndex = 5
        Me.lbl_pesquisar.Text = "PESQUISAR (nome ou CPF):"
        '
        'txt_pesquisar
        '
        Me.txt_pesquisar.Location = New System.Drawing.Point(10, 263)
        Me.txt_pesquisar.Name = "txt_pesquisar"
        Me.txt_pesquisar.Size = New System.Drawing.Size(300, 20)
        Me.txt_pesquisar.TabIndex = 6
        '
        'dgv_clientes
        '
        Me.dgv_clientes.AllowUserToAddRows = False
        Me.dgv_clientes.AllowUserToDeleteRows = False
        Me.dgv_clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_clientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id, Me.col_cpf, Me.col_nome, Me.col_fone, Me.col_email, Me.col_endereco})
        Me.dgv_clientes.Location = New System.Drawing.Point(10, 295)
        Me.dgv_clientes.Name = "dgv_clientes"
        Me.dgv_clientes.ReadOnly = True
        Me.dgv_clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_clientes.Size = New System.Drawing.Size(860, 230)
        Me.dgv_clientes.TabIndex = 7
        '
        'col_id
        '
        Me.col_id.HeaderText = "ID"
        Me.col_id.Name = "col_id"
        Me.col_id.ReadOnly = True
        Me.col_id.Visible = False
        '
        'col_cpf
        '
        Me.col_cpf.HeaderText = "CPF"
        Me.col_cpf.Name = "col_cpf"
        Me.col_cpf.ReadOnly = True
        '
        'col_nome
        '
        Me.col_nome.HeaderText = "NOME"
        Me.col_nome.Name = "col_nome"
        Me.col_nome.ReadOnly = True
        '
        'col_fone
        '
        Me.col_fone.HeaderText = "TELEFONE"
        Me.col_fone.Name = "col_fone"
        Me.col_fone.ReadOnly = True
        '
        'col_email
        '
        Me.col_email.HeaderText = "E-MAIL"
        Me.col_email.Name = "col_email"
        Me.col_email.ReadOnly = True
        '
        'col_endereco
        '
        Me.col_endereco.HeaderText = "ENDEREÇO"
        Me.col_endereco.Name = "col_endereco"
        Me.col_endereco.ReadOnly = True
        '
        'btn_voltar
        '
        Me.btn_voltar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btn_voltar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_voltar.ForeColor = System.Drawing.Color.White
        Me.btn_voltar.Location = New System.Drawing.Point(740, 535)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(130, 32)
        Me.btn_voltar.TabIndex = 8
        Me.btn_voltar.Text = "VOLTAR"
        Me.btn_voltar.UseVisualStyleBackColor = False
        '
        'frm_clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(880, 580)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.grp_dados)
        Me.Controls.Add(Me.btn_salvar)
        Me.Controls.Add(Me.btn_excluir)
        Me.Controls.Add(Me.btn_limpar)
        Me.Controls.Add(Me.lbl_pesquisar)
        Me.Controls.Add(Me.txt_pesquisar)
        Me.Controls.Add(Me.dgv_clientes)
        Me.Controls.Add(Me.btn_voltar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes - Locadora de Carros"
        Me.grp_dados.ResumeLayout(False)
        Me.grp_dados.PerformLayout()
        CType(Me.dgv_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_titulo As Label
    Friend WithEvents grp_dados As GroupBox
    Friend WithEvents lbl_id As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents lbl_cpf As Label
    Friend WithEvents txt_cpf As TextBox
    Friend WithEvents lbl_nome As Label
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents lbl_fone As Label
    Friend WithEvents txt_fone As TextBox
    Friend WithEvents lbl_email As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents lbl_endereco As Label
    Friend WithEvents txt_endereco As TextBox
    Friend WithEvents btn_salvar As Button
    Friend WithEvents btn_excluir As Button
    Friend WithEvents btn_limpar As Button
    Friend WithEvents lbl_pesquisar As Label
    Friend WithEvents txt_pesquisar As TextBox
    Friend WithEvents dgv_clientes As DataGridView
    Friend WithEvents col_id As DataGridViewTextBoxColumn
    Friend WithEvents col_cpf As DataGridViewTextBoxColumn
    Friend WithEvents col_nome As DataGridViewTextBoxColumn
    Friend WithEvents col_fone As DataGridViewTextBoxColumn
    Friend WithEvents col_email As DataGridViewTextBoxColumn
    Friend WithEvents col_endereco As DataGridViewTextBoxColumn
    Friend WithEvents btn_voltar As Button
End Class
