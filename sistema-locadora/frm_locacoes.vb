Public Class frm_locacoes

    Private Sub frm_locacoes_Load(s As Object, e As EventArgs) Handles MyBase.Load
        dtp_saida.Value = DateTime.Today
        dtp_prevista.Value = DateTime.Today.AddDays(1)
        carregar_clientes()
        carregar_carros()
        carregar_locacoes()
    End Sub

    Private Sub frm_locacoes_Activated(s As Object, e As EventArgs) Handles MyBase.Activated
        carregar_locacoes()
        carregar_carros()
    End Sub

    Private Sub carregar_clientes()
        Try
            SQL = "SELECT id, nome FROM tb_clientes ORDER BY nome"
            rs = db.Execute(SQL)
            cbo_cliente.Items.Clear()
            cbo_cliente.Items.Add("")
            Do While rs.EOF = False
                cbo_cliente.Items.Add(rs.Fields("id").Value & " - " & rs.Fields("nome").Value)
                rs.MoveNext()
            Loop
        Catch ex As Exception
        End Try
    End Sub

    Private Sub carregar_carros()
        Try
            SQL = "SELECT id, placa, modelo, valor_diaria FROM tb_carros WHERE disponivel=1 ORDER BY modelo"
            rs = db.Execute(SQL)
            cbo_carro.Items.Clear()
            cbo_carro.Items.Add("")
            Do While rs.EOF = False
                cbo_carro.Items.Add(rs.Fields("id").Value & " - " & rs.Fields("modelo").Value & " (" & rs.Fields("placa").Value & ") R$" & rs.Fields("valor_diaria").Value)
                rs.MoveNext()
            Loop
        Catch ex As Exception
        End Try
    End Sub

    Private Sub carregar_locacoes()
        Try
            SQL = "SELECT l.id, c.nome, cr.modelo, cr.placa, l.data_saida, l.data_prevista, l.status FROM tb_locacoes l INNER JOIN tb_clientes c ON l.id_cliente=c.id INNER JOIN tb_carros cr ON l.id_carro=cr.id WHERE l.status='Aberta' ORDER BY l.data_saida DESC"
            rs = db.Execute(SQL)
            dgv_locacoes.Rows.Clear()
            Do While rs.EOF = False
                dgv_locacoes.Rows.Add(rs.Fields("id").Value, rs.Fields("nome").Value, rs.Fields("modelo").Value & " - " & rs.Fields("placa").Value, rs.Fields("data_saida").Value, rs.Fields("data_prevista").Value, rs.Fields("status").Value)
                rs.MoveNext()
            Loop
        Catch ex As Exception
            MsgBox("Erro ao carregar locações!" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERRO")
        End Try
    End Sub

    Private Sub calcular_valor()
        Try
            If cbo_carro.Text = "" Then
                lbl_valor_calc.Text = "R$ 0,00"
                Exit Sub
            End If

            id_carro_loc = CInt(cbo_carro.Text.Split("-")(0).Trim())
            SQL = "SELECT valor_diaria FROM tb_carros WHERE id=" & id_carro_loc
            rs = db.Execute(SQL)

            If rs.EOF = False Then
                dias = (dtp_prevista.Value.Date - dtp_saida.Value.Date).Days
                If dias <= 0 Then dias = 1
                total = CDec(rs.Fields("valor_diaria").Value) * dias
                lbl_valor_calc.Text = "R$ " & total.ToString("N2") & " (" & dias & " dias)"
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub cbo_carro_SelectedIndexChanged(s As Object, e As EventArgs) Handles cbo_carro.SelectedIndexChanged
        calcular_valor()
    End Sub

    Private Sub dtp_saida_ValueChanged(s As Object, e As EventArgs) Handles dtp_saida.ValueChanged
        calcular_valor()
    End Sub

    Private Sub dtp_prevista_ValueChanged(s As Object, e As EventArgs) Handles dtp_prevista.ValueChanged
        calcular_valor()
    End Sub

    Private Sub btn_registrar_Click(s As Object, e As EventArgs) Handles btn_registrar.Click
        Try
            If cbo_cliente.Text = "" Or cbo_carro.Text = "" Then
                MsgBox("Selecione o cliente e o carro!", MsgBoxStyle.Exclamation, "ATENÇÃO")
                Exit Sub
            End If

            If dtp_prevista.Value.Date <= dtp_saida.Value.Date Then
                MsgBox("A data prevista deve ser após a data de saída!", MsgBoxStyle.Exclamation, "ATENÇÃO")
                Exit Sub
            End If

            id_cliente = CInt(cbo_cliente.Text.Split("-")(0).Trim())
            id_carro_loc = CInt(cbo_carro.Text.Split("-")(0).Trim())

            SQL = "INSERT INTO tb_locacoes (id_cliente, id_carro, data_saida, data_prevista, status) VALUES (" & id_cliente & "," & id_carro_loc & ",'" & dtp_saida.Value.ToString("yyyy-MM-dd") & "','" & dtp_prevista.Value.ToString("yyyy-MM-dd") & "','Aberta')"
            db.Execute(SQL)

            SQL = "UPDATE tb_carros SET disponivel=0 WHERE id=" & id_carro_loc
            db.Execute(SQL)

            MsgBox("Locação registrada com sucesso!", MsgBoxStyle.Information, "AVISO")
            cbo_cliente.Text = ""
            cbo_carro.Text = ""
            lbl_valor_calc.Text = "R$ 0,00"
            carregar_carros()
            carregar_locacoes()

        Catch ex As Exception
            MsgBox("Erro ao registrar locação!" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERRO")
        End Try
    End Sub

    Private Sub btn_voltar_Click(s As Object, e As EventArgs) Handles btn_voltar.Click
        frm_menu.Show()
        Hide()
    End Sub

End Class
