Public Class frm_devolucao

    Private Sub frm_devolucao_Load(s As Object, e As EventArgs) Handles MyBase.Load
        dtp_retorno.Value = DateTime.Today
        carregar_locacoes_abertas()
    End Sub

    Private Sub frm_devolucao_Activated(s As Object, e As EventArgs) Handles MyBase.Activated
        carregar_locacoes_abertas()
    End Sub

    Private Sub carregar_locacoes_abertas()
        Try
            SQL = "SELECT l.id, c.nome, cr.modelo, cr.placa, l.data_saida, l.data_prevista, cr.valor_diaria FROM tb_locacoes l INNER JOIN tb_clientes c ON l.id_cliente=c.id INNER JOIN tb_carros cr ON l.id_carro=cr.id WHERE l.status='Aberta' ORDER BY l.data_saida"
            rs = db.Execute(SQL)
            dgv_abertas.Rows.Clear()
            Do While rs.EOF = False
                dgv_abertas.Rows.Add(rs.Fields("id").Value, rs.Fields("nome").Value, rs.Fields("modelo").Value & " - " & rs.Fields("placa").Value, rs.Fields("data_saida").Value, rs.Fields("data_prevista").Value, rs.Fields("valor_diaria").Value)
                rs.MoveNext()
            Loop
        Catch ex As Exception
            MsgBox("Erro ao carregar locações!" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERRO")
        End Try
    End Sub

    Private Sub dgv_abertas_CellClick(s As Object, e As DataGridViewCellEventArgs) Handles dgv_abertas.CellClick
        If dgv_abertas.CurrentRow IsNot Nothing Then
            txt_id_loc.Text = dgv_abertas.CurrentRow.Cells(0).Value
            lbl_cliente_val.Text = dgv_abertas.CurrentRow.Cells(1).Value
            lbl_carro_val.Text = dgv_abertas.CurrentRow.Cells(2).Value
            lbl_saida_val.Text = CDate(dgv_abertas.CurrentRow.Cells(3).Value).ToString("dd/MM/yyyy")
            lbl_prevista_val.Text = CDate(dgv_abertas.CurrentRow.Cells(4).Value).ToString("dd/MM/yyyy")
            calcular_total()
        End If
    End Sub

    Private Sub dtp_retorno_ValueChanged(s As Object, e As EventArgs) Handles dtp_retorno.ValueChanged
        calcular_total()
    End Sub

    Private Sub calcular_total()
        Try
            If txt_id_loc.Text = "" Then Exit Sub

            SQL = "SELECT cr.valor_diaria, l.data_saida FROM tb_locacoes l INNER JOIN tb_carros cr ON l.id_carro=cr.id WHERE l.id=" & txt_id_loc.Text
            rs = db.Execute(SQL)

            If rs.EOF = False Then
                dias = (dtp_retorno.Value.Date - CDate(rs.Fields("data_saida").Value)).Days
                If dias <= 0 Then dias = 1
                total = CDec(rs.Fields("valor_diaria").Value) * dias
                lbl_total_val.Text = "R$ " & total.ToString("N2") & " (" & dias & " dias)"
                lbl_total_val.ForeColor = System.Drawing.Color.SeaGreen
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_devolver_Click(s As Object, e As EventArgs) Handles btn_devolver.Click
        Try
            If txt_id_loc.Text = "" Then
                MsgBox("Selecione uma locação na lista!", MsgBoxStyle.Exclamation, "ATENÇÃO")
                Exit Sub
            End If

            SQL = "SELECT l.id_carro, cr.valor_diaria, l.data_saida FROM tb_locacoes l INNER JOIN tb_carros cr ON l.id_carro=cr.id WHERE l.id=" & txt_id_loc.Text
            rs = db.Execute(SQL)

            If rs.EOF Then
                MsgBox("Locação não encontrada!", MsgBoxStyle.Exclamation, "ATENÇÃO")
                Exit Sub
            End If

            id_carro = CInt(rs.Fields("id_carro").Value)
            dias = (dtp_retorno.Value.Date - CDate(rs.Fields("data_saida").Value)).Days
            If dias <= 0 Then dias = 1
            total = CDec(rs.Fields("valor_diaria").Value) * dias

            resp = MsgBox("Confirmar devolução?" & vbCrLf & "Cliente: " & lbl_cliente_val.Text & vbCrLf & "Carro: " & lbl_carro_val.Text & vbCrLf & "Total: R$ " & total.ToString("N2"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, "CONFIRMAR")
            If resp = 6 Then
                SQL = "UPDATE tb_locacoes SET data_retorno='" & dtp_retorno.Value.ToString("yyyy-MM-dd") & "', valor_total=" & total.ToString("N2").Replace(",", ".") & ", status='Encerrada' WHERE id=" & txt_id_loc.Text
                db.Execute(SQL)

                SQL = "UPDATE tb_carros SET disponivel=1 WHERE id=" & id_carro
                db.Execute(SQL)

                MsgBox("Devolução registrada! Valor: R$ " & total.ToString("N2"), MsgBoxStyle.Information, "AVISO")
                limpar_campos()
                carregar_locacoes_abertas()
            End If

        Catch ex As Exception
            MsgBox("Erro ao registrar devolução!" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERRO")
        End Try
    End Sub

    Private Sub btn_voltar_Click(s As Object, e As EventArgs) Handles btn_voltar.Click
        frm_menu.Show()
        Hide()
    End Sub

    Private Sub limpar_campos()
        txt_id_loc.Text = ""
        lbl_cliente_val.Text = "-"
        lbl_carro_val.Text = "-"
        lbl_saida_val.Text = "-"
        lbl_prevista_val.Text = "-"
        lbl_total_val.Text = "R$ 0,00"
        dtp_retorno.Value = DateTime.Today
    End Sub

End Class
