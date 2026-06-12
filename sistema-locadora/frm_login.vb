Public Class frm_login

    Private Sub frm_login_Load(s As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        txt_usuario.Focus()
    End Sub

    Private Sub btn_entrar_Click(s As Object, e As EventArgs) Handles btn_entrar.Click
        Try
            If txt_usuario.Text = "" Or txt_senha.Text = "" Then
                MsgBox("Preencha o usuário e a senha!", MsgBoxStyle.Exclamation, "ATENÇÃO")
                Exit Sub
            End If

            SQL = "SELECT * FROM tb_contas WHERE usuario='" & txt_usuario.Text & "' AND senha='" & txt_senha.Text & "' AND status='Ativo'"
            rs = db.Execute(SQL)

            If rs.EOF = False Then
                usuario_logado = rs.Fields("usuario").Value
                tipo_logado = rs.Fields("tipo").Value

                If tipo_logado = "ADM" Then
                    frm_adm.Show()
                Else
                    frm_menu.Show()
                End If

                Hide()
            Else
                MsgBox("Usuário ou senha incorretos, ou acesso bloqueado!", MsgBoxStyle.Critical, "ERRO")
                txt_senha.Text = ""
                txt_usuario.Focus()
            End If

        Catch ex As Exception
            MsgBox("Erro ao realizar login!" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERRO")
        End Try
    End Sub

    Private Sub btn_esqueci_Click(s As Object, e As EventArgs) Handles btn_esqueci.Click
        Try
            user_selecionado = InputBox("Digite seu usuário para recuperar a senha:", "Esqueceu a Senha")
            If user_selecionado = "" Then Exit Sub

            SQL = "SELECT email, senha FROM tb_contas WHERE usuario='" & user_selecionado & "'"
            rs = db.Execute(SQL)

            If rs.EOF = False Then
                MsgBox("Sua senha é: " & rs.Fields("senha").Value & vbCrLf & "E-mail: " & rs.Fields("email").Value, MsgBoxStyle.Information, "Recuperar Senha")
            Else
                MsgBox("Usuário não encontrado!", MsgBoxStyle.Exclamation, "ATENÇÃO")
            End If

        Catch ex As Exception
            MsgBox("Erro ao recuperar senha!" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERRO")
        End Try
    End Sub

    Private Sub btn_sair_Click(s As Object, e As EventArgs) Handles btn_sair.Click
        Application.Exit()
    End Sub

    Private Sub txt_senha_KeyPress(s As Object, e As KeyPressEventArgs) Handles txt_senha.KeyPress
        If e.KeyChar = Chr(13) Then btn_entrar_Click(s, e)
    End Sub

End Class
