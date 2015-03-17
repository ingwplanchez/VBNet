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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioSuma = New System.Windows.Forms.RadioButton()
        Me.RadioResta = New System.Windows.Forms.RadioButton()
        Me.RadioMultiplicacion = New System.Windows.Forms.RadioButton()
        Me.RadioDivision = New System.Windows.Forms.RadioButton()
        Me.ButtonCalcular = New System.Windows.Forms.Button()
        Me.TextNum1 = New System.Windows.Forms.TextBox()
        Me.TextNum2 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextNum2)
        Me.GroupBox1.Controls.Add(Me.TextNum1)
        Me.GroupBox1.Controls.Add(Me.ButtonCalcular)
        Me.GroupBox1.Controls.Add(Me.RadioDivision)
        Me.GroupBox1.Controls.Add(Me.RadioMultiplicacion)
        Me.GroupBox1.Controls.Add(Me.RadioResta)
        Me.GroupBox1.Controls.Add(Me.RadioSuma)
        Me.GroupBox1.Location = New System.Drawing.Point(34, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(243, 147)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Operaciones"
        '
        'RadioSuma
        '
        Me.RadioSuma.AutoSize = True
        Me.RadioSuma.Location = New System.Drawing.Point(17, 37)
        Me.RadioSuma.Name = "RadioSuma"
        Me.RadioSuma.Size = New System.Drawing.Size(52, 17)
        Me.RadioSuma.TabIndex = 0
        Me.RadioSuma.TabStop = True
        Me.RadioSuma.Text = "Suma"
        Me.RadioSuma.UseVisualStyleBackColor = True
        '
        'RadioResta
        '
        Me.RadioResta.AutoSize = True
        Me.RadioResta.Location = New System.Drawing.Point(16, 60)
        Me.RadioResta.Name = "RadioResta"
        Me.RadioResta.Size = New System.Drawing.Size(53, 17)
        Me.RadioResta.TabIndex = 1
        Me.RadioResta.TabStop = True
        Me.RadioResta.Text = "Resta"
        Me.RadioResta.UseVisualStyleBackColor = True
        '
        'RadioMultiplicacion
        '
        Me.RadioMultiplicacion.AutoSize = True
        Me.RadioMultiplicacion.Location = New System.Drawing.Point(17, 83)
        Me.RadioMultiplicacion.Name = "RadioMultiplicacion"
        Me.RadioMultiplicacion.Size = New System.Drawing.Size(89, 17)
        Me.RadioMultiplicacion.TabIndex = 2
        Me.RadioMultiplicacion.TabStop = True
        Me.RadioMultiplicacion.Text = "Multiplicacion"
        Me.RadioMultiplicacion.UseVisualStyleBackColor = True
        '
        'RadioDivision
        '
        Me.RadioDivision.AutoSize = True
        Me.RadioDivision.Location = New System.Drawing.Point(16, 106)
        Me.RadioDivision.Name = "RadioDivision"
        Me.RadioDivision.Size = New System.Drawing.Size(62, 17)
        Me.RadioDivision.TabIndex = 3
        Me.RadioDivision.TabStop = True
        Me.RadioDivision.Text = "Division"
        Me.RadioDivision.UseVisualStyleBackColor = True
        '
        'ButtonCalcular
        '
        Me.ButtonCalcular.Location = New System.Drawing.Point(131, 106)
        Me.ButtonCalcular.Name = "ButtonCalcular"
        Me.ButtonCalcular.Size = New System.Drawing.Size(88, 23)
        Me.ButtonCalcular.TabIndex = 4
        Me.ButtonCalcular.Text = "Calcular"
        Me.ButtonCalcular.UseVisualStyleBackColor = True
        '
        'TextNum1
        '
        Me.TextNum1.Location = New System.Drawing.Point(131, 37)
        Me.TextNum1.Name = "TextNum1"
        Me.TextNum1.Size = New System.Drawing.Size(88, 20)
        Me.TextNum1.TabIndex = 5
        '
        'TextNum2
        '
        Me.TextNum2.Location = New System.Drawing.Point(131, 63)
        Me.TextNum2.Name = "TextNum2"
        Me.TextNum2.Size = New System.Drawing.Size(88, 20)
        Me.TextNum2.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 221)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Operaciones"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonCalcular As System.Windows.Forms.Button
    Friend WithEvents RadioDivision As System.Windows.Forms.RadioButton
    Friend WithEvents RadioMultiplicacion As System.Windows.Forms.RadioButton
    Friend WithEvents RadioResta As System.Windows.Forms.RadioButton
    Friend WithEvents RadioSuma As System.Windows.Forms.RadioButton
    Friend WithEvents TextNum2 As System.Windows.Forms.TextBox
    Friend WithEvents TextNum1 As System.Windows.Forms.TextBox

End Class
