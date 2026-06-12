Public Class frm_clientes

    Private Sub frm_clientes_Load(s As Object, e As EventArgs) Handles MyBase.Load
        carregar_clientes()
    End Sub

    Private Sub carregar_clientes()
        Try
            SQL = "SELECT id, cpf, nome, fone, email, endereco FROM tb_clientes ORDER BY nome"
            rs = db.Execute(SQL)
            dgv_clientes.Rows.Clear()
            Do While rs.EOF = False
                dgv_clientes.Rows.Add(rs.Fields("id").Value, rs.Fields("cpf").Value, rs.Fields("nome").Value, rs.Fields("fone").Value, rs.Fields("email").Value, rs.Fields("endereco").Value)
                rs.MoveNext()
            Loop
        Catch ex As Exception
            MsgBox("Erro ao carregar clientes!" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERRO")
        End Try
    End Sub

    Private Sub btn_salvar_Click(s As Object, e As EventArgs) Handles btn_salvar.Click
        Try
            If txt_cpf.Text = "" Or txt_nome.Text = "" Then
                MsgBox("CPF e Nome são obrigatórios!", MsgBoxStyle.Exclamation, "ATENÇÃO")
                Exit Sub
            End If

            If txt_id.Text = "" Then
                SQL = "SELECT * FROM tb_clientes WHERE cpf='" & txt_cpf.Text & "'"
                rs = db.Execute(SQL)
                If rs.EOF = False Then
                    MsgBox("CPF já cadastrado!", MsgBoxStyle.Exclamation, "ATENÇÃO")
                    Exit Sub
                End If
                SQL = "INSERT INTO tb_clientes (cpf, nome, fone, email, endereco) VALUES ('" & txt_cpf.Text & "','" & txt_nome.Text & "','" & txt_fone.Text & "','" & txt_email.Text & "','" & txt_endereco.Text & "')"
                db.Execute(SQL)
                MsgBox("Cliente cadastrado com sucesso!", MsgBoxStyle.Information, "AVISO")
            Else
                SQL = "UPDATE tb_clientes SET cpf='" & txt_cpf.Text & "', nome='" & txt_nome.Text & "', fone='" & txt_fone.Text & "', email='" & txt_email.Text & "', endereco='" & txt_endereco.Text & "' WHERE id=" & txt_id.Text
                db.Execute(SQL)
                MsgBox("Cliente atualizado com sucesso!", MsgBoxStyle.Information, "AVISO")
            End If

            limpar_campos()
            carregar_clientes()

        Catch ex As Exception
            MsgBox("Erro ao salvar cliente!" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERRO")
        End Try
    End Sub

    Private Sub btn_excluir_Click(s As Object, e As EventArgs) Handles btn_excluir.Click
        Try
            If txt_id.Text = "" Then
                MsgBox("Selecione um cliente para excluir!", MsgBoxStyle.Exclamation, "ATENÇÃO")
                Exit Sub
            End If

            resp = MsgBox("Excluir o cliente '" & txt_nome.Text & "'?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
            If resp = 6 Then
                SQL = "DELETE FROM tb_clientes WHERE id=" & txt_id.Text
                db.Execute(SQL)
                MsgBox("Cliente excluído!", MsgBoxStyle.Information, "AVISO")
                limpar_campos()
                carregar_clientes()
            End If

        Catch ex As Exception
            MsgBox("Erro ao excluir cliente!" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERRO")
        End Try
    End Sub

    Private Sub btn_limpar_Click(s As Object, e As EventArgs) Handles btn_limpar.Click
        limpar_campos()
    End Sub

    Private Sub btn_voltar_Click(s As Object, e As EventArgs) Handles btn_voltar.Click
        frm_menu.Show()
        Hide()
    End Sub

    Private Sub dgv_clientes_CellClick(s As Object, e As DataGridViewCellEventArgs) Handles dgv_clientes.CellClick
        If dgv_clientes.CurrentRow IsNot Nothing Then
            txt_id.Text = dgv_clientes.CurrentRow.Cells(0).Value
            txt_cpf.Text = dgv_clientes.CurrentRow.Cells(1).Value
            txt_nome.Text = dgv_clientes.CurrentRow.Cells(2).Value
            txt_fone.Text = dgv_clientes.CurrentRow.Cells(3).Value
            txt_email.Text = dgv_clientes.CurrentRow.Cells(4).Value
            txt_endereco.Text = dgv_clientes.CurrentRow.Cells(5).Value
        End If
    End Sub

    Private Sub txt_pesquisar_TextChanged(s As Object, e As EventArgs) Handles txt_pesquisar.TextChanged
        Try
            SQL = "SELECT id, cpf, nome, fone, email, endereco FROM tb_clientes WHERE nome LIKE '%" & txt_pesquisar.Text & "%' OR cpf LIKE '%" & txt_pesquisar.Text & "%' ORDER BY nome"
            rs = db.Execute(SQL)
            dgv_clientes.Rows.Clear()
            Do While rs.EOF = False
                dgv_clientes.Rows.Add(rs.Fields("id").Value, rs.Fields("cpf").Value, rs.Fields("nome").Value, rs.Fields("fone").Value, rs.Fields("email").Value, rs.Fields("endereco").Value)
                rs.MoveNext()
            Loop
        Catch ex As Exception
        End Try
    End Sub

    Private Sub limpar_campos()
        txt_id.Text = ""
        txt_cpf.Text = ""
        txt_nome.Text = ""
        txt_fone.Text = ""
        txt_email.Text = ""
        txt_endereco.Text = ""
        txt_cpf.Focus()
    End Sub

End Class
