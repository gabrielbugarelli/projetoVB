<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Principal_03
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
        Me.Btm_Principal = New System.Windows.Forms.Button()
        Me.Lbl_NomeProjeto = New System.Windows.Forms.Label()
        Me.Btn_GO = New System.Windows.Forms.Button()
        Me.Txt_Entrada = New System.Windows.Forms.TextBox()
        Me.Txt_Saida = New System.Windows.Forms.TextBox()
        Me.Lbl_Curso = New System.Windows.Forms.Label()
        Me.Txt_Curso = New System.Windows.Forms.TextBox()
        Me.Btn_Adicionar = New System.Windows.Forms.Button()
        Me.Txt_Lista = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Btm_Principal
        '
        Me.Btm_Principal.Location = New System.Drawing.Point(34, 73)
        Me.Btm_Principal.Name = "Btm_Principal"
        Me.Btm_Principal.Size = New System.Drawing.Size(162, 71)
        Me.Btm_Principal.TabIndex = 0
        Me.Btm_Principal.Text = "Clique"
        Me.Btm_Principal.UseVisualStyleBackColor = True
        '
        'Lbl_NomeProjeto
        '
        Me.Lbl_NomeProjeto.AutoSize = True
        Me.Lbl_NomeProjeto.Location = New System.Drawing.Point(31, 22)
        Me.Lbl_NomeProjeto.Name = "Lbl_NomeProjeto"
        Me.Lbl_NomeProjeto.Size = New System.Drawing.Size(95, 13)
        Me.Lbl_NomeProjeto.TabIndex = 1
        Me.Lbl_NomeProjeto.Text = "1 - Primeiro Projeto"
        '
        'Btn_GO
        '
        Me.Btn_GO.Location = New System.Drawing.Point(276, 164)
        Me.Btn_GO.Name = "Btn_GO"
        Me.Btn_GO.Size = New System.Drawing.Size(100, 23)
        Me.Btn_GO.TabIndex = 2
        Me.Btn_GO.Text = "GO"
        Me.Btn_GO.UseVisualStyleBackColor = True
        '
        'Txt_Entrada
        '
        Me.Txt_Entrada.Location = New System.Drawing.Point(276, 138)
        Me.Txt_Entrada.Name = "Txt_Entrada"
        Me.Txt_Entrada.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Entrada.TabIndex = 3
        '
        'Txt_Saida
        '
        Me.Txt_Saida.Location = New System.Drawing.Point(276, 193)
        Me.Txt_Saida.Name = "Txt_Saida"
        Me.Txt_Saida.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Saida.TabIndex = 4
        '
        'Lbl_Curso
        '
        Me.Lbl_Curso.AutoSize = True
        Me.Lbl_Curso.Location = New System.Drawing.Point(31, 234)
        Me.Lbl_Curso.Name = "Lbl_Curso"
        Me.Lbl_Curso.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Curso.TabIndex = 5
        Me.Lbl_Curso.Text = "Label1"
        '
        'Txt_Curso
        '
        Me.Txt_Curso.Location = New System.Drawing.Point(34, 261)
        Me.Txt_Curso.Name = "Txt_Curso"
        Me.Txt_Curso.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Curso.TabIndex = 6
        '
        'Btn_Adicionar
        '
        Me.Btn_Adicionar.Location = New System.Drawing.Point(158, 261)
        Me.Btn_Adicionar.Name = "Btn_Adicionar"
        Me.Btn_Adicionar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Adicionar.TabIndex = 7
        Me.Btn_Adicionar.Text = "Button1"
        Me.Btn_Adicionar.UseVisualStyleBackColor = True
        '
        'Txt_Lista
        '
        Me.Txt_Lista.Location = New System.Drawing.Point(34, 290)
        Me.Txt_Lista.Multiline = True
        Me.Txt_Lista.Name = "Txt_Lista"
        Me.Txt_Lista.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_Lista.Size = New System.Drawing.Size(199, 115)
        Me.Txt_Lista.TabIndex = 8
        '
        'Frm_Principal_03
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 450)
        Me.Controls.Add(Me.Txt_Lista)
        Me.Controls.Add(Me.Btn_Adicionar)
        Me.Controls.Add(Me.Txt_Curso)
        Me.Controls.Add(Me.Lbl_Curso)
        Me.Controls.Add(Me.Txt_Saida)
        Me.Controls.Add(Me.Txt_Entrada)
        Me.Controls.Add(Me.Btn_GO)
        Me.Controls.Add(Me.Lbl_NomeProjeto)
        Me.Controls.Add(Me.Btm_Principal)
        Me.Name = "Frm_Principal_03"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btm_Principal As Button
    Friend WithEvents Lbl_NomeProjeto As Label
    Friend WithEvents Btn_GO As Button
    Friend WithEvents Txt_Entrada As TextBox
    Friend WithEvents Txt_Saida As TextBox
    Friend WithEvents Lbl_Curso As Label
    Friend WithEvents Txt_Curso As TextBox
    Friend WithEvents Btn_Adicionar As Button
    Friend WithEvents Txt_Lista As TextBox
End Class
