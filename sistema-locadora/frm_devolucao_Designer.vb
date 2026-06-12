<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_devolucao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_devolucao))
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.grp_lista = New System.Windows.Forms.GroupBox()
        Me.dgv_abertas = New System.Windows.Forms.DataGridView()
        Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_carro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_saida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_prevista = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_diaria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grp_devolucao = New System.Windows.Forms.GroupBox()
        Me.txt_id_loc = New System.Windows.Forms.TextBox()
        Me.lbl_cli = New System.Windows.Forms.Label()
        Me.lbl_cliente_val = New System.Windows.Forms.Label()
        Me.lbl_car = New System.Windows.Forms.Label()
        Me.lbl_carro_val = New System.Windows.Forms.Label()
        Me.lbl_sai = New System.Windows.Forms.Label()
        Me.lbl_saida_val = New System.Windows.Forms.Label()
        Me.lbl_prev = New System.Windows.Forms.Label()
        Me.lbl_prevista_val = New System.Windows.Forms.Label()
        Me.lbl_retorno = New System.Windows.Forms.Label()
        Me.dtp_retorno = New System.Windows.Forms.DateTimePicker()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.lbl_total_val = New System.Windows.Forms.Label()
        Me.btn_devolver = New System.Windows.Forms.Button()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.grp_lista.SuspendLayout()
        CType(Me.dgv_abertas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_devolucao.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_titulo
        '
        Me.lbl_titulo.BackColor = System.Drawing.Color.SeaGreen
        Me.lbl_titulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_titulo.ForeColor = System.Drawing.Color.White
        Me.lbl_titulo.Location = New System.Drawing.Point(0, 0)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(880, 40)
        Me.lbl_titulo.TabIndex = 0
        Me.lbl_titulo.Text = "DEVOLUÇÃO DE VEÍCULO"
        Me.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grp_lista
        '
        Me.grp_lista.Controls.Add(Me.dgv_abertas)
        Me.grp_lista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.grp_lista.Location = New System.Drawing.Point(10, 50)
        Me.grp_lista.Name = "grp_lista"
        Me.grp_lista.Size = New System.Drawing.Size(860, 230)
        Me.grp_lista.TabIndex = 1
        Me.grp_lista.TabStop = False
        Me.grp_lista.Text = "LOCAÇÕES EM ABERTO - clique para selecionar"
        '
        'dgv_abertas
        '
        Me.dgv_abertas.AllowUserToAddRows = False
        Me.dgv_abertas.AllowUserToDeleteRows = False
        Me.dgv_abertas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_abertas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_abertas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id, Me.col_cliente, Me.col_carro, Me.col_saida, Me.col_prevista, Me.col_diaria})
        Me.dgv_abertas.Location = New System.Drawing.Point(10, 20)
        Me.dgv_abertas.Name = "dgv_abertas"
        Me.dgv_abertas.ReadOnly = True
        Me.dgv_abertas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_abertas.Size = New System.Drawing.Size(840, 200)
        Me.dgv_abertas.TabIndex = 0
        '
        'col_id
        '
        Me.col_id.HeaderText = "ID"
        Me.col_id.Name = "col_id"
        Me.col_id.ReadOnly = True
        Me.col_id.Visible = False
        '
        'col_cliente
        '
        Me.col_cliente.HeaderText = "CLIENTE"
        Me.col_cliente.Name = "col_cliente"
        Me.col_cliente.ReadOnly = True
        '
        'col_carro
        '
        Me.col_carro.HeaderText = "CARRO"
        Me.col_carro.Name = "col_carro"
        Me.col_carro.ReadOnly = True
        '
        'col_saida
        '
        Me.col_saida.HeaderText = "SAÍDA"
        Me.col_saida.Name = "col_saida"
        Me.col_saida.ReadOnly = True
        '
        'col_prevista
        '
        Me.col_prevista.HeaderText = "PREV. RETORNO"
        Me.col_prevista.Name = "col_prevista"
        Me.col_prevista.ReadOnly = True
        '
        'col_diaria
        '
        Me.col_diaria.HeaderText = "VALOR/DIA"
        Me.col_diaria.Name = "col_diaria"
        Me.col_diaria.ReadOnly = True
        '
        'grp_devolucao
        '
        Me.grp_devolucao.Controls.Add(Me.txt_id_loc)
        Me.grp_devolucao.Controls.Add(Me.lbl_cli)
        Me.grp_devolucao.Controls.Add(Me.lbl_cliente_val)
        Me.grp_devolucao.Controls.Add(Me.lbl_car)
        Me.grp_devolucao.Controls.Add(Me.lbl_carro_val)
        Me.grp_devolucao.Controls.Add(Me.lbl_sai)
        Me.grp_devolucao.Controls.Add(Me.lbl_saida_val)
        Me.grp_devolucao.Controls.Add(Me.lbl_prev)
        Me.grp_devolucao.Controls.Add(Me.lbl_prevista_val)
        Me.grp_devolucao.Controls.Add(Me.lbl_retorno)
        Me.grp_devolucao.Controls.Add(Me.dtp_retorno)
        Me.grp_devolucao.Controls.Add(Me.lbl_total)
        Me.grp_devolucao.Controls.Add(Me.lbl_total_val)
        Me.grp_devolucao.Controls.Add(Me.btn_devolver)
        Me.grp_devolucao.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.grp_devolucao.Location = New System.Drawing.Point(10, 290)
        Me.grp_devolucao.Name = "grp_devolucao"
        Me.grp_devolucao.Size = New System.Drawing.Size(860, 155)
        Me.grp_devolucao.TabIndex = 2
        Me.grp_devolucao.TabStop = False
        Me.grp_devolucao.Text = "REGISTRAR DEVOLUÇÃO"
        '
        'txt_id_loc
        '
        Me.txt_id_loc.Location = New System.Drawing.Point(0, 0)
        Me.txt_id_loc.Name = "txt_id_loc"
        Me.txt_id_loc.Size = New System.Drawing.Size(1, 21)
        Me.txt_id_loc.TabIndex = 0
        Me.txt_id_loc.Visible = False
        '
        'lbl_cli
        '
        Me.lbl_cli.AutoSize = True
        Me.lbl_cli.Location = New System.Drawing.Point(10, 20)
        Me.lbl_cli.Name = "lbl_cli"
        Me.lbl_cli.Size = New System.Drawing.Size(68, 15)
        Me.lbl_cli.TabIndex = 1
        Me.lbl_cli.Text = "CLIENTE:"
        '
        'lbl_cliente_val
        '
        Me.lbl_cliente_val.AutoSize = True
        Me.lbl_cliente_val.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lbl_cliente_val.Location = New System.Drawing.Point(10, 38)
        Me.lbl_cliente_val.Name = "lbl_cliente_val"
        Me.lbl_cliente_val.Size = New System.Drawing.Size(11, 15)
        Me.lbl_cliente_val.TabIndex = 2
        Me.lbl_cliente_val.Text = "-"
        '
        'lbl_car
        '
        Me.lbl_car.AutoSize = True
        Me.lbl_car.Location = New System.Drawing.Point(220, 20)
        Me.lbl_car.Name = "lbl_car"
        Me.lbl_car.Size = New System.Drawing.Size(58, 15)
        Me.lbl_car.TabIndex = 3
        Me.lbl_car.Text = "CARRO:"
        '
        'lbl_carro_val
        '
        Me.lbl_carro_val.AutoSize = True
        Me.lbl_carro_val.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lbl_carro_val.Location = New System.Drawing.Point(220, 38)
        Me.lbl_carro_val.Name = "lbl_carro_val"
        Me.lbl_carro_val.Size = New System.Drawing.Size(11, 15)
        Me.lbl_carro_val.TabIndex = 4
        Me.lbl_carro_val.Text = "-"
        '
        'lbl_sai
        '
        Me.lbl_sai.AutoSize = True
        Me.lbl_sai.Location = New System.Drawing.Point(440, 20)
        Me.lbl_sai.Name = "lbl_sai"
        Me.lbl_sai.Size = New System.Drawing.Size(50, 15)
        Me.lbl_sai.TabIndex = 5
        Me.lbl_sai.Text = "SAÍDA:"
        '
        'lbl_saida_val
        '
        Me.lbl_saida_val.AutoSize = True
        Me.lbl_saida_val.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lbl_saida_val.Location = New System.Drawing.Point(440, 38)
        Me.lbl_saida_val.Name = "lbl_saida_val"
        Me.lbl_saida_val.Size = New System.Drawing.Size(11, 15)
        Me.lbl_saida_val.TabIndex = 6
        Me.lbl_saida_val.Text = "-"
        '
        'lbl_prev
        '
        Me.lbl_prev.AutoSize = True
        Me.lbl_prev.Location = New System.Drawing.Point(560, 20)
        Me.lbl_prev.Name = "lbl_prev"
        Me.lbl_prev.Size = New System.Drawing.Size(51, 15)
        Me.lbl_prev.TabIndex = 7
        Me.lbl_prev.Text = "PREV.:"
        '
        'lbl_prevista_val
        '
        Me.lbl_prevista_val.AutoSize = True
        Me.lbl_prevista_val.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lbl_prevista_val.Location = New System.Drawing.Point(560, 38)
        Me.lbl_prevista_val.Name = "lbl_prevista_val"
        Me.lbl_prevista_val.Size = New System.Drawing.Size(11, 15)
        Me.lbl_prevista_val.TabIndex = 8
        Me.lbl_prevista_val.Text = "-"
        '
        'lbl_retorno
        '
        Me.lbl_retorno.AutoSize = True
        Me.lbl_retorno.Location = New System.Drawing.Point(10, 75)
        Me.lbl_retorno.Name = "lbl_retorno"
        Me.lbl_retorno.Size = New System.Drawing.Size(139, 15)
        Me.lbl_retorno.TabIndex = 9
        Me.lbl_retorno.Text = "DATA DE RETORNO:"
        '
        'dtp_retorno
        '
        Me.dtp_retorno.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_retorno.Location = New System.Drawing.Point(10, 93)
        Me.dtp_retorno.Name = "dtp_retorno"
        Me.dtp_retorno.Size = New System.Drawing.Size(160, 21)
        Me.dtp_retorno.TabIndex = 10
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Location = New System.Drawing.Point(185, 75)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(101, 15)
        Me.lbl_total.TabIndex = 11
        Me.lbl_total.Text = "VALOR TOTAL:"
        '
        'lbl_total_val
        '
        Me.lbl_total_val.AutoSize = True
        Me.lbl_total_val.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_total_val.ForeColor = System.Drawing.Color.SeaGreen
        Me.lbl_total_val.Location = New System.Drawing.Point(185, 93)
        Me.lbl_total_val.Name = "lbl_total_val"
        Me.lbl_total_val.Size = New System.Drawing.Size(72, 20)
        Me.lbl_total_val.TabIndex = 12
        Me.lbl_total_val.Text = "R$ 0,00"
        '
        'btn_devolver
        '
        Me.btn_devolver.BackColor = System.Drawing.Color.SeaGreen
        Me.btn_devolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btn_devolver.ForeColor = System.Drawing.Color.White
        Me.btn_devolver.Location = New System.Drawing.Point(680, 85)
        Me.btn_devolver.Name = "btn_devolver"
        Me.btn_devolver.Size = New System.Drawing.Size(165, 40)
        Me.btn_devolver.TabIndex = 13
        Me.btn_devolver.Text = "CONFIRMAR DEVOLUÇÃO"
        Me.btn_devolver.UseVisualStyleBackColor = False
        '
        'btn_voltar
        '
        Me.btn_voltar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btn_voltar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_voltar.ForeColor = System.Drawing.Color.White
        Me.btn_voltar.Location = New System.Drawing.Point(740, 458)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(130, 32)
        Me.btn_voltar.TabIndex = 3
        Me.btn_voltar.Text = "VOLTAR"
        Me.btn_voltar.UseVisualStyleBackColor = False
        '
        'frm_devolucao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(880, 503)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.grp_lista)
        Me.Controls.Add(Me.grp_devolucao)
        Me.Controls.Add(Me.btn_voltar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_devolucao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Devolução - Locadora de Carros"
        Me.grp_lista.ResumeLayout(False)
        CType(Me.dgv_abertas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_devolucao.ResumeLayout(False)
        Me.grp_devolucao.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl_titulo As Label
    Friend WithEvents grp_lista As GroupBox
    Friend WithEvents dgv_abertas As DataGridView
    Friend WithEvents col_id As DataGridViewTextBoxColumn
    Friend WithEvents col_cliente As DataGridViewTextBoxColumn
    Friend WithEvents col_carro As DataGridViewTextBoxColumn
    Friend WithEvents col_saida As DataGridViewTextBoxColumn
    Friend WithEvents col_prevista As DataGridViewTextBoxColumn
    Friend WithEvents col_diaria As DataGridViewTextBoxColumn
    Friend WithEvents grp_devolucao As GroupBox
    Friend WithEvents txt_id_loc As TextBox
    Friend WithEvents lbl_cli As Label
    Friend WithEvents lbl_cliente_val As Label
    Friend WithEvents lbl_car As Label
    Friend WithEvents lbl_carro_val As Label
    Friend WithEvents lbl_sai As Label
    Friend WithEvents lbl_saida_val As Label
    Friend WithEvents lbl_prev As Label
    Friend WithEvents lbl_prevista_val As Label
    Friend WithEvents lbl_retorno As Label
    Friend WithEvents dtp_retorno As DateTimePicker
    Friend WithEvents lbl_total As Label
    Friend WithEvents lbl_total_val As Label
    Friend WithEvents btn_devolver As Button
    Friend WithEvents btn_voltar As Button
End Class
