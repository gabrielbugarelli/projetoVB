Public Class Frm_Principal02
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Btm_AloMundo_Click(sender As Object, e As EventArgs) Handles Btn_Principal.Click

        Dim idade As Integer = 12
        MsgBox("O valor da idade é: " + idade.ToString)



    End Sub

    Private Sub Btn_NumerosInteiros_Click(sender As Object, e As EventArgs) Handles Btn_NumerosInteiros.Click
        Dim x As Integer = 10
        Dim y As Double = 5.2
        Dim z As Integer = x / y



        MsgBox("O valor é: " + z.ToString)

    End Sub

    Private Sub Btn_ConversaoNumero_Click(sender As Object, e As EventArgs) Handles Btn_ConversaoNumero.Click

        Dim salario As Double = 1300.45
        Dim salarioInteiro As Integer = salario

        MsgBox("O valor do salario é: " + salario.ToString + Environment.NewLine +
               "E o salario inteiro é " + salarioInteiro.ToString)

        Dim longo As Long = 1000000000000000000
        MsgBox("O valor de longo é: " + longo.ToString)




    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Btn_Resultado_Click(sender As Object, e As EventArgs) Handles Btn_Resultado.Click
        Dim numerador, denominador, resultado As Double

        numerador = Txt_Numerador.Text
        denominador = Txt_Denominador.Text
        resultado = numerador / denominador

        Txt_Saida.Text = "O resultado é: " + resultado.ToString







    End Sub

    Private Sub Txt_Saida_TextChanged(sender As Object, e As EventArgs) Handles Txt_Saida.TextChanged

    End Sub
End Class
