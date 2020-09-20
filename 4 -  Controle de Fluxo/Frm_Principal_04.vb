Public Class Frm_Principal_04
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Text = "4 - Controle de Fluxos"
        Lbl_NomeProjeto.Text = "4 - Controle de Fluxos"
        Btm_Principal.Text = "Checagem de permissão de entrada"

        Lbl_Idade.Text = "Idade"
        Lbl_Resultado.Text = "Resultado"

        Grp_Pais.Text = "Acompanhado dos pais? "

        Rdb_Sim.Text = "Sim"
        Rdb_Nao.Text = "Não"



    End Sub

    Private Sub Btm_Principal_Click(sender As Object, e As EventArgs) Handles Btm_Principal.Click
        Dim idade As Integer

        Dim acompanhadoPais As String = ""


        'tratamento de erros
        Try
            idade = Txt_idade.Text
        Catch ex As Exception
            MsgBox("Desculpa, digite apenas numeros", MsgBoxStyle.Critical)
        End Try


        'Fluxo de controle

        Dim podeEntrar As Boolean = ((idade >= 18) Or (acompanhadoPais = "S" And idade >= 16))

        Dim naoPodeEntrar As Boolean = ((acompanhadoPais = "n" And idade >= 16) Or (idade < 16))

        Dim mensagemAdicional As String = ""

        'Verifica se o checkbox foi marcado com S ou N
        If Rdb_Sim.Checked Then
            acompanhadoPais = "S"
        Else
            acompanhadoPais = "N"
        End If


        If acompanhadoPais = "S" Then
            mensagemAdicional = "Está acompanhado!"
        Else
            mensagemAdicional = "Não está acompanhado!"
        End If

        If podeEntrar Then
            Txt_Resultado.ForeColor = Color.Green
            Txt_Resultado.Text = "Pode entrar! " + mensagemAdicional
        Else
            If naoPodeEntrar Then
                Txt_Resultado.ForeColor = Color.Red
                Txt_Resultado.Text = "Não pode entrar! " + mensagemAdicional
            End If
        End If

    End Sub


End Class
