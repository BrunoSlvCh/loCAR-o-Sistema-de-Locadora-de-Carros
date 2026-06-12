<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_carros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_carros))
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.grp_dados = New System.Windows.Forms.GroupBox()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.lbl_placa = New System.Windows.Forms.Label()
        Me.txt_placa = New System.Windows.Forms.TextBox()
        Me.lbl_modelo = New System.Windows.Forms.Label()
        Me.txt_modelo = New System.Windows.Forms.TextBox()
        Me.lbl_marca = New System.Windows.Forms.Label()
        Me.txt_marca = New System.Windows.Forms.TextBox()
        Me.lbl_ano = New System.Windows.Forms.Label()
        Me.txt_ano = New System.Windows.Forms.TextBox()
        Me.lbl_cor = New System.Windows.Forms.Label()
        Me.txt_cor = New System.Windows.Forms.TextBox()
        Me.lbl_valor = New System.Windows.Forms.Label()
        Me.txt_valor = New System.Windows.Forms.TextBox()
        Me.btn_salvar = New System.Windows.Forms.Button()
        Me.btn_excluir = New System.Windows.Forms.Button()
        Me.btn_limpar = New System.Windows.Forms.Button()
        Me.lbl_pesquisar = New System.Windows.Forms.Label()
        Me.txt_pesquisar = New System.Windows.Forms.TextBox()
        Me.dgv_carros = New System.Windows.Forms.DataGridView()
        Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_placa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_modelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_ano = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_cor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_disp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.grp_dados.SuspendLayout()
        CType(Me.dgv_carros, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lbl_titulo.Text = "CADASTRO DE CARROS"
        Me.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grp_dados
        '
        Me.grp_dados.Controls.Add(Me.lbl_id)
        Me.grp_dados.Controls.Add(Me.txt_id)
        Me.grp_dados.Controls.Add(Me.lbl_placa)
        Me.grp_dados.Controls.Add(Me.txt_placa)
        Me.grp_dados.Controls.Add(Me.lbl_modelo)
        Me.grp_dados.Controls.Add(Me.txt_modelo)
        Me.grp_dados.Controls.Add(Me.lbl_marca)
        Me.grp_dados.Controls.Add(Me.txt_marca)
        Me.grp_dados.Controls.Add(Me.lbl_ano)
        Me.grp_dados.Controls.Add(Me.txt_ano)
        Me.grp_dados.Controls.Add(Me.lbl_cor)
        Me.grp_dados.Controls.Add(Me.txt_cor)
        Me.grp_dados.Controls.Add(Me.lbl_valor)
        Me.grp_dados.Controls.Add(Me.txt_valor)
        Me.grp_dados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.grp_dados.Location = New System.Drawing.Point(10, 50)
        Me.grp_dados.Name = "grp_dados"
        Me.grp_dados.Size = New System.Drawing.Size(860, 120)
        Me.grp_dados.TabIndex = 1
        Me.grp_dados.TabStop = False
        Me.grp_dados.Text = "DADOS DO CARRO"
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
        'lbl_placa
        '
        Me.lbl_placa.AutoSize = True
        Me.lbl_placa.Location = New System.Drawing.Point(60, 22)
        Me.lbl_placa.Name = "lbl_placa"
        Me.lbl_placa.Size = New System.Drawing.Size(53, 15)
        Me.lbl_placa.TabIndex = 2
        Me.lbl_placa.Text = "PLACA:"
        '
        'txt_placa
        '
        Me.txt_placa.Location = New System.Drawing.Point(60, 40)
        Me.txt_placa.Name = "txt_placa"
        Me.txt_placa.Size = New System.Drawing.Size(100, 21)
        Me.txt_placa.TabIndex = 3
        '
        'lbl_modelo
        '
        Me.lbl_modelo.AutoSize = True
        Me.lbl_modelo.Location = New System.Drawing.Point(175, 22)
        Me.lbl_modelo.Name = "lbl_modelo"
        Me.lbl_modelo.Size = New System.Drawing.Size(70, 15)
        Me.lbl_modelo.TabIndex = 4
        Me.lbl_modelo.Text = "MODELO:"
        '
        'txt_modelo
        '
        Me.txt_modelo.Location = New System.Drawing.Point(175, 40)
        Me.txt_modelo.Name = "txt_modelo"
        Me.txt_modelo.Size = New System.Drawing.Size(180, 21)
        Me.txt_modelo.TabIndex = 5
        '
        'lbl_marca
        '
        Me.lbl_marca.AutoSize = True
        Me.lbl_marca.Location = New System.Drawing.Point(370, 22)
        Me.lbl_marca.Name = "lbl_marca"
        Me.lbl_marca.Size = New System.Drawing.Size(58, 15)
        Me.lbl_marca.TabIndex = 6
        Me.lbl_marca.Text = "MARCA:"
        '
        'txt_marca
        '
        Me.txt_marca.Location = New System.Drawing.Point(370, 40)
        Me.txt_marca.Name = "txt_marca"
        Me.txt_marca.Size = New System.Drawing.Size(130, 21)
        Me.txt_marca.TabIndex = 7
        '
        'lbl_ano
        '
        Me.lbl_ano.AutoSize = True
        Me.lbl_ano.Location = New System.Drawing.Point(515, 22)
        Me.lbl_ano.Name = "lbl_ano"
        Me.lbl_ano.Size = New System.Drawing.Size(39, 15)
        Me.lbl_ano.TabIndex = 8
        Me.lbl_ano.Text = "ANO:"
        '
        'txt_ano
        '
        Me.txt_ano.Location = New System.Drawing.Point(515, 40)
        Me.txt_ano.Name = "txt_ano"
        Me.txt_ano.Size = New System.Drawing.Size(60, 21)
        Me.txt_ano.TabIndex = 9
        '
        'lbl_cor
        '
        Me.lbl_cor.AutoSize = True
        Me.lbl_cor.Location = New System.Drawing.Point(590, 22)
        Me.lbl_cor.Name = "lbl_cor"
        Me.lbl_cor.Size = New System.Drawing.Size(40, 15)
        Me.lbl_cor.TabIndex = 10
        Me.lbl_cor.Text = "COR:"
        '
        'txt_cor
        '
        Me.txt_cor.Location = New System.Drawing.Point(590, 40)
        Me.txt_cor.Name = "txt_cor"
        Me.txt_cor.Size = New System.Drawing.Size(100, 21)
        Me.txt_cor.TabIndex = 11
        '
        'lbl_valor
        '
        Me.lbl_valor.AutoSize = True
        Me.lbl_valor.Location = New System.Drawing.Point(705, 22)
        Me.lbl_valor.Name = "lbl_valor"
        Me.lbl_valor.Size = New System.Drawing.Size(103, 15)
        Me.lbl_valor.TabIndex = 12
        Me.lbl_valor.Text = "VALOR/DIA R$:"
        '
        'txt_valor
        '
        Me.txt_valor.Location = New System.Drawing.Point(705, 40)
        Me.txt_valor.Name = "txt_valor"
        Me.txt_valor.Size = New System.Drawing.Size(140, 21)
        Me.txt_valor.TabIndex = 13
        '
        'btn_salvar
        '
        Me.btn_salvar.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_salvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_salvar.ForeColor = System.Drawing.Color.White
        Me.btn_salvar.Location = New System.Drawing.Point(10, 180)
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
        Me.btn_excluir.Location = New System.Drawing.Point(155, 180)
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
        Me.btn_limpar.Location = New System.Drawing.Point(300, 180)
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
        Me.lbl_pesquisar.Location = New System.Drawing.Point(10, 225)
        Me.lbl_pesquisar.Name = "lbl_pesquisar"
        Me.lbl_pesquisar.Size = New System.Drawing.Size(210, 15)
        Me.lbl_pesquisar.TabIndex = 5
        Me.lbl_pesquisar.Text = "PESQUISAR (modelo ou placa):"
        '
        'txt_pesquisar
        '
        Me.txt_pesquisar.Location = New System.Drawing.Point(10, 243)
        Me.txt_pesquisar.Name = "txt_pesquisar"
        Me.txt_pesquisar.Size = New System.Drawing.Size(300, 20)
        Me.txt_pesquisar.TabIndex = 6
        '
        'dgv_carros
        '
        Me.dgv_carros.AllowUserToAddRows = False
        Me.dgv_carros.AllowUserToDeleteRows = False
        Me.dgv_carros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_carros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_carros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id, Me.col_placa, Me.col_modelo, Me.col_marca, Me.col_ano, Me.col_cor, Me.col_valor, Me.col_disp})
        Me.dgv_carros.Location = New System.Drawing.Point(10, 273)
        Me.dgv_carros.Name = "dgv_carros"
        Me.dgv_carros.ReadOnly = True
        Me.dgv_carros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_carros.Size = New System.Drawing.Size(860, 245)
        Me.dgv_carros.TabIndex = 7
        '
        'col_id
        '
        Me.col_id.HeaderText = "ID"
        Me.col_id.Name = "col_id"
        Me.col_id.ReadOnly = True
        Me.col_id.Visible = False
        '
        'col_placa
        '
        Me.col_placa.HeaderText = "PLACA"
        Me.col_placa.Name = "col_placa"
        Me.col_placa.ReadOnly = True
        '
        'col_modelo
        '
        Me.col_modelo.HeaderText = "MODELO"
        Me.col_modelo.Name = "col_modelo"
        Me.col_modelo.ReadOnly = True
        '
        'col_marca
        '
        Me.col_marca.HeaderText = "MARCA"
        Me.col_marca.Name = "col_marca"
        Me.col_marca.ReadOnly = True
        '
        'col_ano
        '
        Me.col_ano.HeaderText = "ANO"
        Me.col_ano.Name = "col_ano"
        Me.col_ano.ReadOnly = True
        '
        'col_cor
        '
        Me.col_cor.HeaderText = "COR"
        Me.col_cor.Name = "col_cor"
        Me.col_cor.ReadOnly = True
        '
        'col_valor
        '
        Me.col_valor.HeaderText = "VALOR/DIA"
        Me.col_valor.Name = "col_valor"
        Me.col_valor.ReadOnly = True
        '
        'col_disp
        '
        Me.col_disp.HeaderText = "DISPONÍVEL"
        Me.col_disp.Name = "col_disp"
        Me.col_disp.ReadOnly = True
        '
        'btn_voltar
        '
        Me.btn_voltar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btn_voltar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_voltar.ForeColor = System.Drawing.Color.White
        Me.btn_voltar.Location = New System.Drawing.Point(740, 528)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(130, 32)
        Me.btn_voltar.TabIndex = 8
        Me.btn_voltar.Text = "VOLTAR"
        Me.btn_voltar.UseVisualStyleBackColor = False
        '
        'frm_carros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(880, 572)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.grp_dados)
        Me.Controls.Add(Me.btn_salvar)
        Me.Controls.Add(Me.btn_excluir)
        Me.Controls.Add(Me.btn_limpar)
        Me.Controls.Add(Me.lbl_pesquisar)
        Me.Controls.Add(Me.txt_pesquisar)
        Me.Controls.Add(Me.dgv_carros)
        Me.Controls.Add(Me.btn_voltar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_carros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Carros - Locadora de Carros"
        Me.grp_dados.ResumeLayout(False)
        Me.grp_dados.PerformLayout()
        CType(Me.dgv_carros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_titulo As Label
    Friend WithEvents grp_dados As GroupBox
    Friend WithEvents lbl_id As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents lbl_placa As Label
    Friend WithEvents txt_placa As TextBox
    Friend WithEvents lbl_modelo As Label
    Friend WithEvents txt_modelo As TextBox
    Friend WithEvents lbl_marca As Label
    Friend WithEvents txt_marca As TextBox
    Friend WithEvents lbl_ano As Label
    Friend WithEvents txt_ano As TextBox
    Friend WithEvents lbl_cor As Label
    Friend WithEvents txt_cor As TextBox
    Friend WithEvents lbl_valor As Label
    Friend WithEvents txt_valor As TextBox
    Friend WithEvents btn_salvar As Button
    Friend WithEvents btn_excluir As Button
    Friend WithEvents btn_limpar As Button
    Friend WithEvents lbl_pesquisar As Label
    Friend WithEvents txt_pesquisar As TextBox
    Friend WithEvents dgv_carros As DataGridView
    Friend WithEvents col_id As DataGridViewTextBoxColumn
    Friend WithEvents col_placa As DataGridViewTextBoxColumn
    Friend WithEvents col_modelo As DataGridViewTextBoxColumn
    Friend WithEvents col_marca As DataGridViewTextBoxColumn
    Friend WithEvents col_ano As DataGridViewTextBoxColumn
    Friend WithEvents col_cor As DataGridViewTextBoxColumn
    Friend WithEvents col_valor As DataGridViewTextBoxColumn
    Friend WithEvents col_disp As DataGridViewTextBoxColumn
    Friend WithEvents btn_voltar As Button
End Class
