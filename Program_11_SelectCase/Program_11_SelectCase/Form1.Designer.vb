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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.RadioSuma = New System.Windows.Forms.RadioButton()
        Me.RadioResta = New System.Windows.Forms.RadioButton()
        Me.RadioMultiplicacion = New System.Windows.Forms.RadioButton()
        Me.RadioDivision = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(13, 43)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(141, 43)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 1
        '
        'RadioSuma
        '
        Me.RadioSuma.AutoSize = True
        Me.RadioSuma.Location = New System.Drawing.Point(13, 85)
        Me.RadioSuma.Name = "RadioSuma"
        Me.RadioSuma.Size = New System.Drawing.Size(52, 17)
        Me.RadioSuma.TabIndex = 2
        Me.RadioSuma.TabStop = True
        Me.RadioSuma.Text = "Suma"
        Me.RadioSuma.UseVisualStyleBackColor = True
        '
        'RadioResta
        '
        Me.RadioResta.AutoSize = True
        Me.RadioResta.Location = New System.Drawing.Point(12, 117)
        Me.RadioResta.Name = "RadioResta"
        Me.RadioResta.Size = New System.Drawing.Size(53, 17)
        Me.RadioResta.TabIndex = 3
        Me.RadioResta.TabStop = True
        Me.RadioResta.Text = "Resta"
        Me.RadioResta.UseVisualStyleBackColor = True
        '
        'RadioMultiplicacion
        '
        Me.RadioMultiplicacion.AutoSize = True
        Me.RadioMultiplicacion.Location = New System.Drawing.Point(13, 151)
        Me.RadioMultiplicacion.Name = "RadioMultiplicacion"
        Me.RadioMultiplicacion.Size = New System.Drawing.Size(89, 17)
        Me.RadioMultiplicacion.TabIndex = 4
        Me.RadioMultiplicacion.TabStop = True
        Me.RadioMultiplicacion.Text = "Multiplicacion"
        Me.RadioMultiplicacion.UseVisualStyleBackColor = True
        '
        'RadioDivision
        '
        Me.RadioDivision.AutoSize = True
        Me.RadioDivision.Location = New System.Drawing.Point(12, 184)
        Me.RadioDivision.Name = "RadioDivision"
        Me.RadioDivision.Size = New System.Drawing.Size(62, 17)
        Me.RadioDivision.TabIndex = 5
        Me.RadioDivision.TabStop = True
        Me.RadioDivision.Text = "Division"
        Me.RadioDivision.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(92, 218)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Calcular"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Num1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(141, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Num2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(255, 262)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RadioDivision)
        Me.Controls.Add(Me.RadioMultiplicacion)
        Me.Controls.Add(Me.RadioResta)
        Me.Controls.Add(Me.RadioSuma)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents RadioSuma As System.Windows.Forms.RadioButton
    Friend WithEvents RadioResta As System.Windows.Forms.RadioButton
    Friend WithEvents RadioMultiplicacion As System.Windows.Forms.RadioButton
    Friend WithEvents RadioDivision As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
