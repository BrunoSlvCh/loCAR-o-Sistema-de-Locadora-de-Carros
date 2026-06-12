Module Module1

    Public db As ADODB.Connection
    Public rs As ADODB.Recordset
    Public SQL As String
    Public resp As Integer
    Public usuario_logado As String
    Public tipo_logado As String
    Public id_selecionado As Integer
    Public user_selecionado As String
    Public id_carro As Integer
    Public dias As Integer
    Public total As Decimal
    Public tipo As String
    Public ano As String
    Public id_cliente As Integer
    Public id_carro_loc As Integer

    Sub conectar_banco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=SQLOLEDB;Data Source=NOTEBOOKBRUNO;Initial Catalog=locadora_carros;Trusted_Connection=yes;")
        Catch ex As Exception
            MsgBox("Erro ao conectar ao banco!" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERRO")
            End
        End Try
    End Sub

End Module
