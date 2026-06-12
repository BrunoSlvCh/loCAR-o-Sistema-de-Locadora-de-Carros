Public Class frm_menu

    Private Sub frm_menu_Load(s As Object, e As EventArgs) Handles MyBase.Load
        Text = "Menu Principal - " & usuario_logado
        lbl_usuario.Text = "Usuário: " & usuario_logado & " (" & tipo_logado & ")"
    End Sub

    Private Sub btn_clientes_Click(s As Object, e As EventArgs) Handles btn_clientes.Click
        frm_clientes.Show()
        Hide()
    End Sub

    Private Sub btn_carros_Click(s As Object, e As EventArgs) Handles btn_carros.Click
        frm_carros.Show()
        Hide()
    End Sub

    Private Sub btn_locacoes_Click(s As Object, e As EventArgs) Handles btn_locacoes.Click
        frm_locacoes.Show()
        Hide()
    End Sub

    Private Sub btn_devolucao_Click(s As Object, e As EventArgs) Handles btn_devolucao.Click
        frm_devolucao.Show()
        Hide()
    End Sub

    Private Sub btn_adm_Click(s As Object, e As EventArgs) Handles btn_adm.Click
        If tipo_logado = "ADM" Then
            frm_adm.Show()
            Hide()
        Else
            MsgBox("Acesso restrito ao administrador!", MsgBoxStyle.Exclamation, "ATENÇÃO")
        End If
    End Sub

    Private Sub btn_sair_Click(s As Object, e As EventArgs) Handles btn_sair.Click
        resp = MsgBox("Deseja sair do sistema?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
        If resp = 6 Then Application.Exit()
    End Sub

End Class
