<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ButtonSaludo = New System.Windows.Forms.Button()
        Me.ButtonSuma = New System.Windows.Forms.Button()
        Me.TextNum1 = New System.Windows.Forms.TextBox()
        Me.TextNum2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelResultado = New System.Windows.Forms.Label()
        Me.ButtonCerrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonSaludo
        '
        Me.ButtonSaludo.Location = New System.Drawing.Point(35, 171)
        Me.ButtonSaludo.Name = "ButtonSaludo"
        Me.ButtonSaludo.Size = New System.Drawing.Size(100, 23)
        Me.ButtonSaludo.TabIndex = 0
        Me.ButtonSaludo.Text = "Saludo"
        Me.ButtonSaludo.UseVisualStyleBackColor = True
        '
        'ButtonSuma
        '
        Me.ButtonSuma.Location = New System.Drawing.Point(35, 132)
        Me.ButtonSuma.Name = "ButtonSuma"
        Me.ButtonSuma.Size = New System.Drawing.Size(100, 23)
        Me.ButtonSuma.TabIndex = 1
        Me.ButtonSuma.Text = "Suma"
        Me.ButtonSuma.UseVisualStyleBackColor = True
        '
        'TextNum1
        '
        Me.TextNum1.Location = New System.Drawing.Point(35, 36)
        Me.TextNum1.Name = "TextNum1"
        Me.TextNum1.Size = New System.Drawing.Size(100, 20)
        Me.TextNum1.TabIndex = 2
        '
        'TextNum2
        '
        Me.TextNum2.Location = New System.Drawing.Point(35, 86)
        Me.TextNum2.Name = "TextNum2"
        Me.TextNum2.Size = New System.Drawing.Size(100, 20)
        Me.TextNum2.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Numero 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Numero 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(150, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Resultado"
        '
        'LabelResultado
        '
        Me.LabelResultado.AutoSize = True
        Me.LabelResultado.Location = New System.Drawing.Point(223, 57)
        Me.LabelResultado.Name = "LabelResultado"
        Me.LabelResultado.Size = New System.Drawing.Size(10, 13)
        Me.LabelResultado.TabIndex = 7
        Me.LabelResultado.Text = "-"
        '
        'ButtonCerrar
        '
        Me.ButtonCerrar.Location = New System.Drawing.Point(179, 171)
        Me.ButtonCerrar.Name = "ButtonCerrar"
        Me.ButtonCerrar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCerrar.TabIndex = 8
        Me.ButtonCerrar.Text = "Cerrar"
        Me.ButtonCerrar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 208)
        Me.Controls.Add(Me.ButtonCerrar)
        Me.Controls.Add(Me.LabelResultado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextNum2)
        Me.Controls.Add(Me.TextNum1)
        Me.Controls.Add(Me.ButtonSuma)
        Me.Controls.Add(Me.ButtonSaludo)
        Me.Name = "Form1"
        Me.Text = "Suma"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonSaludo As System.Windows.Forms.Button
    Friend WithEvents ButtonSuma As System.Windows.Forms.Button
    Friend WithEvents TextNum1 As System.Windows.Forms.TextBox
    Friend WithEvents TextNum2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LabelResultado As System.Windows.Forms.Label
    Friend WithEvents ButtonCerrar As System.Windows.Forms.Button

End Class
