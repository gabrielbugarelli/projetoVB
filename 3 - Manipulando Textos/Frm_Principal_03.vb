Public Class Frm_Principal_03

    Dim listaCurso As String
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        'O Me.Text serve para manipular as propriedades do Inicalizador Frm_Principal
        Me.Text = "Manipulando Textos"
        Lbl_NomeProjeto.Text = "3 - Manipulando Textos"
        Btm_Principal.Text = "Clique para ver os resultados"
        Lbl_Curso.Text = "Digite o seu curso preferido"
        Btn_Adicionar.Text = "Adicione a sua lista"

    End Sub

    Private Sub Btm_Principal_Click(sender As Object, e As EventArgs) Handles Btm_Principal.Click
        Dim primeiraLetra As Char = "a"
        Dim segundaLetraas As Char = Chr(65)

        MsgBox("O caracter da variável da primeira letra é: " + primeiraLetra)

    End Sub

    Private Sub Txt_Entrada_TextChanged(sender As Object, e As EventArgs) Handles Txt_Entrada.TextChanged

    End Sub

    Private Sub Btn_GO_Click(sender As Object, e As EventArgs) Handles Btn_GO.Click

        Dim valorChar As Integer = Asc(Txt_Entrada.Text)

        Txt_Saida.Text = valorChar.ToString

    End Sub

    Private Sub Txt_Saida_TextChanged(sender As Object, e As EventArgs) Handles Txt_Saida.TextChanged

    End Sub

    Private Sub Txt_Curso_TextChanged(sender As Object, e As EventArgs) Handles Txt_Curso.TextChanged

    End Sub

    Private Sub Btn_Adicionar_Click(sender As Object, e As EventArgs) Handles Btn_Adicionar.Click
        Dim cursoDigitado As String = Txt_Curso.Text
        listaCurso = listaCurso + cursoDigitado + vbCrLf

        Txt_Lista.Text = listaCurso

    End Sub

    Private Sub Txt_Lista_TextChanged(sender As Object, e As EventArgs) Handles Txt_Lista.TextChanged

    End Sub
End Class
