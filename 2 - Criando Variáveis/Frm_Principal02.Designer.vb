<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Principal02
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Btn_Principal = New System.Windows.Forms.Button()
        Me.Lbl_NomeProjeto = New System.Windows.Forms.Label()
        Me.Btn_NumerosInteiros = New System.Windows.Forms.Button()
        Me.Btn_ConversaoNumero = New System.Windows.Forms.Button()
        Me.Txt_Numerador = New System.Windows.Forms.TextBox()
        Me.Txt_Denominador = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_Resultado = New System.Windows.Forms.Button()
        Me.Txt_Saida = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Btn_Principal
        '
        Me.Btn_Principal.Location = New System.Drawing.Point(12, 47)
        Me.Btn_Principal.Name = "Btn_Principal"
        Me.Btn_Principal.Size = New System.Drawing.Size(118, 44)
        Me.Btn_Principal.TabIndex = 0
        Me.Btn_Principal.Text = "Números Inteiros"
        Me.Btn_Principal.UseVisualStyleBackColor = True
        '
        'Lbl_NomeProjeto
        '
        Me.Lbl_NomeProjeto.AutoSize = True
        Me.Lbl_NomeProjeto.Location = New System.Drawing.Point(12, 9)
        Me.Lbl_NomeProjeto.Name = "Lbl_NomeProjeto"
        Me.Lbl_NomeProjeto.Size = New System.Drawing.Size(104, 13)
        Me.Lbl_NomeProjeto.TabIndex = 2
        Me.Lbl_NomeProjeto.Text = "2 - Criando Variáveis"
        '
        'Btn_NumerosInteiros
        '
        Me.Btn_NumerosInteiros.Location = New System.Drawing.Point(12, 97)
        Me.Btn_NumerosInteiros.Name = "Btn_NumerosInteiros"
        Me.Btn_NumerosInteiros.Size = New System.Drawing.Size(118, 44)
        Me.Btn_NumerosInteiros.TabIndex = 3
        Me.Btn_NumerosInteiros.Text = "Números Ponto Flutuante"
        Me.Btn_NumerosInteiros.UseVisualStyleBackColor = True
        '
        'Btn_ConversaoNumero
        '
        Me.Btn_ConversaoNumero.Location = New System.Drawing.Point(12, 147)
        Me.Btn_ConversaoNumero.Name = "Btn_ConversaoNumero"
        Me.Btn_ConversaoNumero.Size = New System.Drawing.Size(118, 44)
        Me.Btn_ConversaoNumero.TabIndex = 4
        Me.Btn_ConversaoNumero.Text = "Conversão de Números"
        Me.Btn_ConversaoNumero.UseVisualStyleBackColor = True
        '
        'Txt_Numerador
        '
        Me.Txt_Numerador.Location = New System.Drawing.Point(360, 71)
        Me.Txt_Numerador.Name = "Txt_Numerador"
        Me.Txt_Numerador.Size = New System.Drawing.Size(104, 20)
        Me.Txt_Numerador.TabIndex = 5
        '
        'Txt_Denominador
        '
        Me.Txt_Denominador.Location = New System.Drawing.Point(360, 108)
        Me.Txt_Denominador.Name = "Txt_Denominador"
        Me.Txt_Denominador.Size = New System.Drawing.Size(104, 20)
        Me.Txt_Denominador.TabIndex = 7
        Me.Txt_Denominador.Tag = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(292, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Numerador:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(281, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Denominador:"
        '
        'Btn_Resultado
        '
        Me.Btn_Resultado.Location = New System.Drawing.Point(360, 147)
        Me.Btn_Resultado.Name = "Btn_Resultado"
        Me.Btn_Resultado.Size = New System.Drawing.Size(104, 23)
        Me.Btn_Resultado.TabIndex = 9
        Me.Btn_Resultado.Text = "Resultado"
        Me.Btn_Resultado.UseVisualStyleBackColor = True
        '
        'Txt_Saida
        '
        Me.Txt_Saida.Location = New System.Drawing.Point(360, 176)
        Me.Txt_Saida.Multiline = True
        Me.Txt_Saida.Name = "Txt_Saida"
        Me.Txt_Saida.Size = New System.Drawing.Size(104, 20)
        Me.Txt_Saida.TabIndex = 10
        Me.Txt_Saida.Tag = ""
        '
        'Frm_TelaPrincipal02
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Txt_Saida)
        Me.Controls.Add(Me.Btn_Resultado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txt_Denominador)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txt_Numerador)
        Me.Controls.Add(Me.Btn_ConversaoNumero)
        Me.Controls.Add(Me.Btn_NumerosInteiros)
        Me.Controls.Add(Me.Lbl_NomeProjeto)
        Me.Controls.Add(Me.Btn_Principal)
        Me.Name = "Frm_TelaPrincipal02"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Principal As Button
    Friend WithEvents Lbl_NomeProjeto As Label
    Friend WithEvents Btn_NumerosInteiros As Button
    Friend WithEvents Btn_ConversaoNumero As Button
    Friend WithEvents Txt_Numerador As TextBox
    Friend WithEvents Txt_Denominador As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Btn_Resultado As Button
    Friend WithEvents Txt_Saida As TextBox
End Class