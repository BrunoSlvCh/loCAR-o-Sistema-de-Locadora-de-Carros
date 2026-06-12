Public Class frm_carros

    Private Sub frm_carros_Load(s As Object, e As EventArgs) Handles MyBase.Load
        carregar_carros()
    End Sub

    Private Sub carregar_carros()
        Try
            SQL = "SELECT id, placa, modelo, marca, ano, cor, valor_diaria, CASE disponivel WHEN 1 THEN 'Sim' ELSE 'Não' END AS disp FROM tb_carros ORDER BY modelo"
            rs = db.Execute(SQL)
            dgv_carros.Rows.Clear()
            Do While rs.EOF = False
                dgv_carros.Rows.Add(rs.Fields("id").Value, rs.Fields("placa").Value, rs.Fields("modelo").Value, rs.Fields("marca").Value, rs.Fields("ano").Value, rs.Fields("cor").Value, rs.Fields("valor_diaria").Value, rs.Fields("disp").Value)
                rs.MoveNext()
            Loop
        Catch ex As Exception
            MsgBox("Erro ao carregar carros!" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERRO")
        End Try
    End Sub

    Private Sub btn_salvar_Click(s As Object, e As EventArgs) Handles btn_salvar.Click
        Try
            If txt_placa.Text = "" Or txt_modelo.Text = "" Or txt_valor.Text = "" Then
                MsgBox("Placa, Modelo e Valor são obrigatórios!", MsgBoxStyle.Exclamation, "ATENÇÃO")
                Exit Sub
            End If

            ano = "0"
            If txt_ano.Text <> "" Then ano = txt_ano.Text

            If txt_id.Text = "" Then
                SQL = "SELECT * FROM tb_carros WHERE placa='" & txt_placa.Text & "'"
                rs = db.Execute(SQL)
                If rs.EOF = False Then
                    MsgBox("Placa já cadastrada!", MsgBoxStyle.Exclamation, "ATENÇÃO")
                    Exit Sub
                End If
                SQL = "INSERT INTO tb_carros (placa, modelo, marca, ano, cor, valor_diaria) VALUES ('" & txt_placa.Text & "','" & txt_modelo.Text & "','" & txt_marca.Text & "'," & ano & ",'" & txt_cor.Text & "'," & txt_valor.Text.Replace(",", ".") & ")"
                db.Execute(SQL)
                MsgBox("Carro cadastrado com sucesso!", MsgBoxStyle.Information, "AVISO")
            Else
                SQL = "UPDATE tb_carros SET placa='" & txt_placa.Text & "', modelo='" & txt_modelo.Text & "', marca='" & txt_marca.Text & "', ano=" & ano & ", cor='" & txt_cor.Text & "', valor_diaria=" & txt_valor.Text.Replace(",", ".") & " WHERE id=" & txt_id.Text
                db.Execute(SQL)
                MsgBox("Carro atualizado com sucesso!", MsgBoxStyle.Information, "AVISO")
            End If

            limpar_campos()
            carregar_carros()

        Catch ex As Exception
            MsgBox("Erro ao salvar carro!" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERRO")
        End Try
    End Sub

    Private Sub btn_excluir_Click(s As Object, e As EventArgs) Handles btn_excluir.Click
        Try
            If txt_id.Text = "" Then
                MsgBox("Selecione um carro para excluir!", MsgBoxStyle.Exclamation, "ATENÇÃO")
                Exit Sub
            End If

            resp = MsgBox("Excluir o carro '" & txt_modelo.Text & " - " & txt_placa.Text & "'?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
            If resp = 6 Then
                SQL = "DELETE FROM tb_carros WHERE id=" & txt_id.Text
                db.Execute(SQL)
                MsgBox("Carro excluído!", MsgBoxStyle.Information, "AVISO")
                limpar_campos()
                carregar_carros()
            End If

        Catch ex As Exception
            MsgBox("Erro ao excluir carro!" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERRO")
        End Try
    End Sub

    Private Sub btn_limpar_Click(s As Object, e As EventArgs) Handles btn_limpar.Click
        limpar_campos()
    End Sub

    Private Sub btn_voltar_Click(s As Object, e As EventArgs) Handles btn_voltar.Click
        frm_menu.Show()
        Hide()
    End Sub

    Private Sub dgv_carros_CellClick(s As Object, e As DataGridViewCellEventArgs) Handles dgv_carros.CellClick
        If dgv_carros.CurrentRow IsNot Nothing Then
            txt_id.Text = dgv_carros.CurrentRow.Cells(0).Value
            txt_placa.Text = dgv_carros.CurrentRow.Cells(1).Value
            txt_modelo.Text = dgv_carros.CurrentRow.Cells(2).Value
            txt_marca.Text = dgv_carros.CurrentRow.Cells(3).Value
            txt_ano.Text = dgv_carros.CurrentRow.Cells(4).Value
            txt_cor.Text = dgv_carros.CurrentRow.Cells(5).Value
            txt_valor.Text = dgv_carros.CurrentRow.Cells(6).Value
        End If
    End Sub

    Private Sub txt_pesquisar_TextChanged(s As Object, e As EventArgs) Handles txt_pesquisar.TextChanged
        Try
            SQL = "SELECT id, placa, modelo, marca, ano, cor, valor_diaria, CASE disponivel WHEN 1 THEN 'Sim' ELSE 'Não' END AS disp FROM tb_carros WHERE modelo LIKE '%" & txt_pesquisar.Text & "%' OR placa LIKE '%" & txt_pesquisar.Text & "%' ORDER BY modelo"
            rs = db.Execute(SQL)
            dgv_carros.Rows.Clear()
            Do While rs.EOF = False
                dgv_carros.Rows.Add(rs.Fields("id").Value, rs.Fields("placa").Value, rs.Fields("modelo").Value, rs.Fields("marca").Value, rs.Fields("ano").Value, rs.Fields("cor").Value, rs.Fields("valor_diaria").Value, rs.Fields("disp").Value)
                rs.MoveNext()
            Loop
        Catch ex As Exception
        End Try
    End Sub

    Private Sub limpar_campos()
        txt_id.Text = ""
        txt_placa.Text = ""
        txt_modelo.Text = ""
        txt_marca.Text = ""
        txt_ano.Text = ""
        txt_cor.Text = ""
        txt_valor.Text = ""
        txt_placa.Focus()
    End Sub

End Class
