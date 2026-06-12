Public Class frm_adm

    Private Sub frm_adm_Load(s As Object, e As EventArgs) Handles MyBase.Load
        Text = "Painel ADM - " & usuario_logado
        carregar_contas()
    End Sub

    Private Sub carregar_contas()
        Try
            SQL = "SELECT id, usuario, tipo, email, status FROM tb_contas ORDER BY usuario"
            rs = db.Execute(SQL)
            dgv_contas.Rows.Clear()
            Do While rs.EOF = False
                dgv_contas.Rows.Add(rs.Fields("id").Value, rs.Fields("usuario").Value, rs.Fields("tipo").Value, rs.Fields("email").Value, rs.Fields("status").Value)
                rs.MoveNext()
            Loop
        Catch ex As Exception
            MsgBox("Erro ao carregar contas!" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERRO")
        End Try
    End Sub

    Private Sub btn_cadastrar_Click(s As Object, e As EventArgs) Handles btn_cadastrar.Click
        Try
            If txt_novo_usuario.Text = "" Or txt_nova_senha.Text = "" Or txt_novo_email.Text = "" Then
                MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation, "ATENÇÃO")
                Exit Sub
            End If

            SQL = "SELECT * FROM tb_contas WHERE usuario='" & txt_novo_usuario.Text & "'"
            rs = db.Execute(SQL)
            If rs.EOF = False Then
                MsgBox("Usuário já cadastrado!", MsgBoxStyle.Exclamation, "ATENÇÃO")
                Exit Sub
            End If

            tipo = "Usuario"
            If chk_adm.Checked Then tipo = "ADM"

            SQL = "INSERT INTO tb_contas (usuario, senha, tipo, email, status) VALUES ('" & txt_novo_usuario.Text & "','" & txt_nova_senha.Text & "','" & tipo & "','" & txt_novo_email.Text & "','Ativo')"
            db.Execute(SQL)
            MsgBox("Conta cadastrada com sucesso!", MsgBoxStyle.Information, "AVISO")
            limpar_campos()
            carregar_contas()

        Catch ex As Exception
            MsgBox("Erro ao cadastrar conta!" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERRO")
        End Try
    End Sub

    Private Sub btn_bloquear_Click(s As Object, e As EventArgs) Handles btn_bloquear.Click
        Try
            If dgv_contas.CurrentRow Is Nothing Then
                MsgBox("Selecione uma conta!", MsgBoxStyle.Exclamation, "ATENÇÃO")
                Exit Sub
            End If

            id_selecionado = dgv_contas.CurrentRow.Cells(0).Value
            user_selecionado = dgv_contas.CurrentRow.Cells(1).Value

            If user_selecionado = "admin" Then
                MsgBox("Não é possível bloquear o admin!", MsgBoxStyle.Exclamation, "ATENÇÃO")
                Exit Sub
            End If

            resp = MsgBox("Bloquear acesso de '" & user_selecionado & "'?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
            If resp = 6 Then
                SQL = "UPDATE tb_contas SET status='Bloqueado' WHERE id=" & id_selecionado
                db.Execute(SQL)
                MsgBox("Acesso bloqueado!", MsgBoxStyle.Information, "AVISO")
                carregar_contas()
            End If

        Catch ex As Exception
            MsgBox("Erro ao bloquear conta!" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERRO")
        End Try
    End Sub

    Private Sub btn_ativar_Click(s As Object, e As EventArgs) Handles btn_ativar.Click
        Try
            If dgv_contas.CurrentRow Is Nothing Then
                MsgBox("Selecione uma conta!", MsgBoxStyle.Exclamation, "ATENÇÃO")
                Exit Sub
            End If

            id_selecionado = dgv_contas.CurrentRow.Cells(0).Value
            user_selecionado = dgv_contas.CurrentRow.Cells(1).Value

            resp = MsgBox("Ativar acesso de '" & user_selecionado & "'?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
            If resp = 6 Then
                SQL = "UPDATE tb_contas SET status='Ativo' WHERE id=" & id_selecionado
                db.Execute(SQL)
                MsgBox("Acesso ativado!", MsgBoxStyle.Information, "AVISO")
                carregar_contas()
            End If

        Catch ex As Exception
            MsgBox("Erro ao ativar conta!" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERRO")
        End Try
    End Sub

    Private Sub btn_excluir_Click(s As Object, e As EventArgs) Handles btn_excluir.Click
        Try
            If dgv_contas.CurrentRow Is Nothing Then
                MsgBox("Selecione uma conta!", MsgBoxStyle.Exclamation, "ATENÇÃO")
                Exit Sub
            End If

            id_selecionado = dgv_contas.CurrentRow.Cells(0).Value
            user_selecionado = dgv_contas.CurrentRow.Cells(1).Value

            If user_selecionado = "admin" Then
                MsgBox("Não é possível excluir o admin!", MsgBoxStyle.Exclamation, "ATENÇÃO")
                Exit Sub
            End If

            resp = MsgBox("Excluir a conta '" & user_selecionado & "'?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "ATENÇÃO")
            If resp = 6 Then
                SQL = "DELETE FROM tb_contas WHERE id=" & id_selecionado
                db.Execute(SQL)
                MsgBox("Conta excluída!", MsgBoxStyle.Information, "AVISO")
                carregar_contas()
            End If

        Catch ex As Exception
            MsgBox("Erro ao excluir conta!" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERRO")
        End Try
    End Sub

    Private Sub btn_ir_menu_Click(s As Object, e As EventArgs) Handles btn_ir_menu.Click
        frm_menu.Show()
        Hide()
    End Sub

    Private Sub btn_sair_Click(s As Object, e As EventArgs) Handles btn_sair.Click
        resp = MsgBox("Deseja sair do sistema?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
        If resp = 6 Then Application.Exit()
    End Sub

    Private Sub limpar_campos()
        txt_novo_usuario.Text = ""
        txt_nova_senha.Text = ""
        txt_novo_email.Text = ""
        chk_adm.Checked = False
        txt_novo_usuario.Focus()
    End Sub

End Class
