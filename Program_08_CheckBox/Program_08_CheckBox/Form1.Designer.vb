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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckRock = New System.Windows.Forms.CheckBox()
        Me.CheckBlues = New System.Windows.Forms.CheckBox()
        Me.CheckJazz = New System.Windows.Forms.CheckBox()
        Me.CheckFlamenco = New System.Windows.Forms.CheckBox()
        Me.CheckTango = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Que musica le Gusta?"
        '
        'CheckRock
        '
        Me.CheckRock.AutoSize = True
        Me.CheckRock.Location = New System.Drawing.Point(16, 58)
        Me.CheckRock.Name = "CheckRock"
        Me.CheckRock.Size = New System.Drawing.Size(52, 17)
        Me.CheckRock.TabIndex = 1
        Me.CheckRock.Text = "Rock"
        Me.CheckRock.UseVisualStyleBackColor = True
        '
        'CheckBlues
        '
        Me.CheckBlues.AutoSize = True
        Me.CheckBlues.Location = New System.Drawing.Point(16, 91)
        Me.CheckBlues.Name = "CheckBlues"
        Me.CheckBlues.Size = New System.Drawing.Size(52, 17)
        Me.CheckBlues.TabIndex = 2
        Me.CheckBlues.Text = "Blues"
        Me.CheckBlues.UseVisualStyleBackColor = True
        '
        'CheckJazz
        '
        Me.CheckJazz.AutoSize = True
        Me.CheckJazz.Location = New System.Drawing.Point(16, 125)
        Me.CheckJazz.Name = "CheckJazz"
        Me.CheckJazz.Size = New System.Drawing.Size(47, 17)
        Me.CheckJazz.TabIndex = 3
        Me.CheckJazz.Text = "Jazz"
        Me.CheckJazz.UseVisualStyleBackColor = True
        '
        'CheckFlamenco
        '
        Me.CheckFlamenco.AutoSize = True
        Me.CheckFlamenco.Location = New System.Drawing.Point(16, 158)
        Me.CheckFlamenco.Name = "CheckFlamenco"
        Me.CheckFlamenco.Size = New System.Drawing.Size(72, 17)
        Me.CheckFlamenco.TabIndex = 4
        Me.CheckFlamenco.Text = "Flamenco"
        Me.CheckFlamenco.UseVisualStyleBackColor = True
        '
        'CheckTango
        '
        Me.CheckTango.AutoSize = True
        Me.CheckTango.Location = New System.Drawing.Point(16, 193)
        Me.CheckTango.Name = "CheckTango"
        Me.CheckTango.Size = New System.Drawing.Size(57, 17)
        Me.CheckTango.TabIndex = 5
        Me.CheckTango.Text = "Tango"
        Me.CheckTango.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(106, 217)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Enviar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CheckTango)
        Me.Controls.Add(Me.CheckFlamenco)
        Me.Controls.Add(Me.CheckJazz)
        Me.Controls.Add(Me.CheckBlues)
        Me.Controls.Add(Me.CheckRock)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "CheckBox"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CheckRock As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBlues As System.Windows.Forms.CheckBox
    Friend WithEvents CheckJazz As System.Windows.Forms.CheckBox
    Friend WithEvents CheckFlamenco As System.Windows.Forms.CheckBox
    Friend WithEvents CheckTango As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
