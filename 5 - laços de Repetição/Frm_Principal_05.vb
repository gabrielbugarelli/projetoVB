Public Class Frm_Principal_05
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.Text = "5 - laços de Repetição"

        'LABELS
        Lbl_NomeProjeto.Text = "5 - Laços de Repetição"
        Lbl_Principal.Text = "Valor Investido"
        Lbl_Rendimento.Text = "Juros (%)"
        Lbl_Periodos.Text = "Periodos"
        Lbl_Principal2.Text = "Valor investido"
        Lbl_Redimento2.Text = "Juros mensais(%)"
        Lbl_Anos.Text = "Anos aplicados"
        Lbl_AcrescimoRendimento.Text = "Acrescimo Juros (%)"
        Lbl_Limite.Text = "Limite"

        'BOTÕES
        Btm_While.Text = "WHILE"
        Btm_For.Text = "FOR"
        Btm_Calcular.Text = "Calcular"

        'GRUPOS
        Grp_Grupo1.Text = "Cálculo do investimento por WHILE e FOR"
        Grp_Grupo2.Text = "Cálculo do investimento anual"

    End Sub

    Private Sub Btm_Principal_Click(sender As Object, e As EventArgs) Handles Btm_While.Click
        Dim investimento As Double = Val(Txt_Principal.Text)
        Dim rendimento As Double = Val(Txt_Rendimento.Text)
        Dim periodos As Integer = Val(Txt_Periodos.Text)
        Dim contador As Integer = 1

        Dim extrato As String = ""

        While contador <= periodos
            investimento += (investimento * (rendimento / 100))
            extrato += " O saldo do investimento no mês " + contador.ToString + " é " + investimento.ToString + vbCrLf

            contador += 1
        End While

        Txt_Extrato_While.Text = extrato

    End Sub

    Private Sub Btm_For_Click(sender As Object, e As EventArgs) Handles Btm_For.Click
        Dim investimento As Double = Val(Txt_Principal.Text)
        Dim rendimento As Double = Val(Txt_Rendimento.Text)
        Dim periodos As Integer = Val(Txt_Periodos.Text)

        Dim extrato As String = ""

        Dim i As Integer
        For i = 1 To periodos
            investimento += (investimento * (rendimento / 100))
            extrato += " O saldo do investimento no mês " + i.ToString + " é " + investimento.ToString + vbCrLf
        Next

        Txt_Extrato_for.Text = extrato

    End Sub

    Private Sub Btm_Calcular_Click(sender As Object, e As EventArgs) Handles Btm_Calcular.Click
        Dim investimento As Double = Val(Txt_Principal2.Text)
        Dim rendimento As Double = Val(Txt_Redimento2.Text)
        Dim anos As Integer = Val(Txt_Anos.Text)
        Dim acrescimosJuros As Double = Val(Txt_AcrescimoRendimento.Text)
        Dim limite As Double = Val(Txt_Limite.Text)

        Dim extrato As String = ""
        Dim contador As Integer = 1
        Dim executouExitFor As Boolean = False

        For i As Integer = 1 To anos
            For j As Integer = 1 To 12
                investimento += (investimento * (rendimento / 100))
                extrato += " O saldo do investimento no mês " + contador.ToString + " é " _
                + investimento.ToString + " usando a taxa " + rendimento.ToString + " % mês " + vbCrLf

                If investimento >= limite Then
                    extrato += "O investimento atingiu o limite" + vbCrLf
                    executouExitFor = True
                    Exit For 'sai do for
                End If

                contador += 1
            Next
            If executouExitFor Then
                Exit For
            End If

            rendimento += (rendimento * acrescimosJuros / 100)
        Next

        Txt_Resultado.Text = extrato.ToString
    End Sub
End Class
