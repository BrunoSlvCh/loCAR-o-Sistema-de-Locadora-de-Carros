<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_locacoes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_locacoes))
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.grp_nova = New System.Windows.Forms.GroupBox()
        Me.lbl_cliente = New System.Windows.Forms.Label()
        Me.cbo_cliente = New System.Windows.Forms.ComboBox()
        Me.lbl_carro = New System.Windows.Forms.Label()
        Me.cbo_carro = New System.Windows.Forms.ComboBox()
        Me.lbl_saida = New System.Windows.Forms.Label()
        Me.dtp_saida = New System.Windows.Forms.DateTimePicker()
        Me.lbl_prevista = New System.Windows.Forms.Label()
        Me.dtp_prevista = New System.Windows.Forms.DateTimePicker()
        Me.lbl_valor_label = New System.Windows.Forms.Label()
        Me.lbl_valor_calc = New System.Windows.Forms.Label()
        Me.btn_registrar = New System.Windows.Forms.Button()
        Me.grp_lista = New System.Windows.Forms.GroupBox()
        Me.dgv_locacoes = New System.Windows.Forms.DataGridView()
        Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_carro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_saida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_prevista = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.grp_nova.SuspendLayout()
        Me.grp_lista.SuspendLayout()
        CType(Me.dgv_locacoes, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lbl_titulo.Text = "REGISTRAR LOCAÇÃO"
        Me.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grp_nova
        '
        Me.grp_nova.Controls.Add(Me.lbl_cliente)
        Me.grp_nova.Controls.Add(Me.cbo_cliente)
        Me.grp_nova.Controls.Add(Me.lbl_carro)
        Me.grp_nova.Controls.Add(Me.cbo_carro)
        Me.grp_nova.Controls.Add(Me.lbl_saida)
        Me.grp_nova.Controls.Add(Me.dtp_saida)
        Me.grp_nova.Controls.Add(Me.lbl_prevista)
        Me.grp_nova.Controls.Add(Me.dtp_prevista)
        Me.grp_nova.Controls.Add(Me.lbl_valor_label)
        Me.grp_nova.Controls.Add(Me.lbl_valor_calc)
        Me.grp_nova.Controls.Add(Me.btn_registrar)
        Me.grp_nova.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.grp_nova.Location = New System.Drawing.Point(10, 50)
        Me.grp_nova.Name = "grp_nova"
        Me.grp_nova.Size = New System.Drawing.Size(860, 155)
        Me.grp_nova.TabIndex = 1
        Me.grp_nova.TabStop = False
        Me.grp_nova.Text = "NOVA LOCAÇÃO"
        '
        'lbl_cliente
        '
        Me.lbl_cliente.AutoSize = True
        Me.lbl_cliente.Location = New System.Drawing.Point(10, 22)
        Me.lbl_cliente.Name = "lbl_cliente"
        Me.lbl_cliente.Size = New System.Drawing.Size(68, 15)
        Me.lbl_cliente.TabIndex = 0
        Me.lbl_cliente.Text = "CLIENTE:"
        '
        'cbo_cliente
        '
        Me.cbo_cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_cliente.Location = New System.Drawing.Point(10, 40)
        Me.cbo_cliente.Name = "cbo_cliente"
        Me.cbo_cliente.Size = New System.Drawing.Size(280, 23)
        Me.cbo_cliente.TabIndex = 1
        '
        'lbl_carro
        '
        Me.lbl_carro.AutoSize = True
        Me.lbl_carro.Location = New System.Drawing.Point(305, 22)
        Me.lbl_carro.Name = "lbl_carro"
        Me.lbl_carro.Size = New System.Drawing.Size(143, 15)
        Me.lbl_carro.TabIndex = 2
        Me.lbl_carro.Text = "CARRO DISPONÍVEL:"
        '
        'cbo_carro
        '
        Me.cbo_carro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_carro.Location = New System.Drawing.Point(305, 40)
        Me.cbo_carro.Name = "cbo_carro"
        Me.cbo_carro.Size = New System.Drawing.Size(340, 23)
        Me.cbo_carro.TabIndex = 3
        '
        'lbl_saida
        '
        Me.lbl_saida.AutoSize = True
        Me.lbl_saida.Location = New System.Drawing.Point(10, 78)
        Me.lbl_saida.Name = "lbl_saida"
        Me.lbl_saida.Size = New System.Drawing.Size(111, 15)
        Me.lbl_saida.TabIndex = 4
        Me.lbl_saida.Text = "DATA DE SAÍDA:"
        '
        'dtp_saida
        '
        Me.dtp_saida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_saida.Location = New System.Drawing.Point(10, 96)
        Me.dtp_saida.Name = "dtp_saida"
        Me.dtp_saida.Size = New System.Drawing.Size(160, 21)
        Me.dtp_saida.TabIndex = 5
        '
        'lbl_prevista
        '
        Me.lbl_prevista.AutoSize = True
        Me.lbl_prevista.Location = New System.Drawing.Point(185, 78)
        Me.lbl_prevista.Name = "lbl_prevista"
        Me.lbl_prevista.Size = New System.Drawing.Size(162, 15)
        Me.lbl_prevista.TabIndex = 6
        Me.lbl_prevista.Text = "DEVOLUÇÃO PREVISTA:"
        '
        'dtp_prevista
        '
        Me.dtp_prevista.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_prevista.Location = New System.Drawing.Point(185, 96)
        Me.dtp_prevista.Name = "dtp_prevista"
        Me.dtp_prevista.Size = New System.Drawing.Size(160, 21)
        Me.dtp_prevista.TabIndex = 7
        '
        'lbl_valor_label
        '
        Me.lbl_valor_label.AutoSize = True
        Me.lbl_valor_label.Location = New System.Drawing.Point(360, 78)
        Me.lbl_valor_label.Name = "lbl_valor_label"
        Me.lbl_valor_label.Size = New System.Drawing.Size(129, 15)
        Me.lbl_valor_label.TabIndex = 8
        Me.lbl_valor_label.Text = "VALOR ESTIMADO:"
        '
        'lbl_valor_calc
        '
        Me.lbl_valor_calc.AutoSize = True
        Me.lbl_valor_calc.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_valor_calc.ForeColor = System.Drawing.Color.SeaGreen
        Me.lbl_valor_calc.Location = New System.Drawing.Point(360, 96)
        Me.lbl_valor_calc.Name = "lbl_valor_calc"
        Me.lbl_valor_calc.Size = New System.Drawing.Size(66, 18)
        Me.lbl_valor_calc.TabIndex = 9
        Me.lbl_valor_calc.Text = "R$ 0,00"
        '
        'btn_registrar
        '
        Me.btn_registrar.BackColor = System.Drawing.Color.SeaGreen
        Me.btn_registrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btn_registrar.ForeColor = System.Drawing.Color.White
        Me.btn_registrar.Location = New System.Drawing.Point(690, 88)
        Me.btn_registrar.Name = "btn_registrar"
        Me.btn_registrar.Size = New System.Drawing.Size(155, 36)
        Me.btn_registrar.TabIndex = 10
        Me.btn_registrar.Text = "REGISTRAR"
        Me.btn_registrar.UseVisualStyleBackColor = False
        '
        'grp_lista
        '
        Me.grp_lista.Controls.Add(Me.dgv_locacoes)
        Me.grp_lista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.grp_lista.Location = New System.Drawing.Point(10, 215)
        Me.grp_lista.Name = "grp_lista"
        Me.grp_lista.Size = New System.Drawing.Size(860, 280)
        Me.grp_lista.TabIndex = 2
        Me.grp_lista.TabStop = False
        Me.grp_lista.Text = "LOCAÇÕES EM ABERTO"
        '
        'dgv_locacoes
        '
        Me.dgv_locacoes.AllowUserToAddRows = False
        Me.dgv_locacoes.AllowUserToDeleteRows = False
        Me.dgv_locacoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_locacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_locacoes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id, Me.col_cliente, Me.col_carro, Me.col_saida, Me.col_prevista, Me.col_status})
        Me.dgv_locacoes.Location = New System.Drawing.Point(10, 20)
        Me.dgv_locacoes.Name = "dgv_locacoes"
        Me.dgv_locacoes.ReadOnly = True
        Me.dgv_locacoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_locacoes.Size = New System.Drawing.Size(840, 250)
        Me.dgv_locacoes.TabIndex = 0
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
        Me.col_saida.HeaderText = "DATA SAÍDA"
        Me.col_saida.Name = "col_saida"
        Me.col_saida.ReadOnly = True
        '
        'col_prevista
        '
        Me.col_prevista.HeaderText = "PREV. RETORNO"
        Me.col_prevista.Name = "col_prevista"
        Me.col_prevista.ReadOnly = True
        '
        'col_status
        '
        Me.col_status.HeaderText = "STATUS"
        Me.col_status.Name = "col_status"
        Me.col_status.ReadOnly = True
        '
        'btn_voltar
        '
        Me.btn_voltar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btn_voltar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_voltar.ForeColor = System.Drawing.Color.White
        Me.btn_voltar.Location = New System.Drawing.Point(740, 505)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(130, 32)
        Me.btn_voltar.TabIndex = 3
        Me.btn_voltar.Text = "VOLTAR"
        Me.btn_voltar.UseVisualStyleBackColor = False
        '
        'frm_locacoes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(880, 550)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.grp_nova)
        Me.Controls.Add(Me.grp_lista)
        Me.Controls.Add(Me.btn_voltar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_locacoes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Locações - Locadora de Carros"
        Me.grp_nova.ResumeLayout(False)
        Me.grp_nova.PerformLayout()
        Me.grp_lista.ResumeLayout(False)
        CType(Me.dgv_locacoes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl_titulo As Label
    Friend WithEvents grp_nova As GroupBox
    Friend WithEvents lbl_cliente As Label
    Friend WithEvents cbo_cliente As ComboBox
    Friend WithEvents lbl_carro As Label
    Friend WithEvents cbo_carro As ComboBox
    Friend WithEvents lbl_saida As Label
    Friend WithEvents dtp_saida As DateTimePicker
    Friend WithEvents lbl_prevista As Label
    Friend WithEvents dtp_prevista As DateTimePicker
    Friend WithEvents lbl_valor_label As Label
    Friend WithEvents lbl_valor_calc As Label
    Friend WithEvents btn_registrar As Button
    Friend WithEvents grp_lista As GroupBox
    Friend WithEvents dgv_locacoes As DataGridView
    Friend WithEvents col_id As DataGridViewTextBoxColumn
    Friend WithEvents col_cliente As DataGridViewTextBoxColumn
    Friend WithEvents col_carro As DataGridViewTextBoxColumn
    Friend WithEvents col_saida As DataGridViewTextBoxColumn
    Friend WithEvents col_prevista As DataGridViewTextBoxColumn
    Friend WithEvents col_status As DataGridViewTextBoxColumn
    Friend WithEvents btn_voltar As Button
End Class
