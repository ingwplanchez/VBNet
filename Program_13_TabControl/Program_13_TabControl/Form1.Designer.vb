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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TextID1 = New System.Windows.Forms.TextBox()
        Me.TextNombre1 = New System.Windows.Forms.TextBox()
        Me.ButtonADD = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonCancel2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextID2 = New System.Windows.Forms.TextBox()
        Me.TextID3 = New System.Windows.Forms.TextBox()
        Me.TextNombre3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ButtonRefresh = New System.Windows.Forms.Button()
        Me.ButtonCancel3 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(0, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(284, 198)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.ButtonCancel)
        Me.TabPage1.Controls.Add(Me.ButtonADD)
        Me.TabPage1.Controls.Add(Me.TextNombre1)
        Me.TabPage1.Controls.Add(Me.TextID1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(276, 172)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Insertar"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TextID2)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.ButtonCancel2)
        Me.TabPage2.Controls.Add(Me.ButtonDelete)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(276, 172)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Eliminar"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.ButtonCancel3)
        Me.TabPage3.Controls.Add(Me.ButtonRefresh)
        Me.TabPage3.Controls.Add(Me.Label5)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Controls.Add(Me.TextNombre3)
        Me.TabPage3.Controls.Add(Me.TextID3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(276, 172)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Actualizar"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TextID1
        '
        Me.TextID1.Location = New System.Drawing.Point(6, 19)
        Me.TextID1.Name = "TextID1"
        Me.TextID1.Size = New System.Drawing.Size(100, 20)
        Me.TextID1.TabIndex = 0
        '
        'TextNombre1
        '
        Me.TextNombre1.Location = New System.Drawing.Point(8, 58)
        Me.TextNombre1.Name = "TextNombre1"
        Me.TextNombre1.Size = New System.Drawing.Size(100, 20)
        Me.TextNombre1.TabIndex = 1
        '
        'ButtonADD
        '
        Me.ButtonADD.Location = New System.Drawing.Point(8, 143)
        Me.ButtonADD.Name = "ButtonADD"
        Me.ButtonADD.Size = New System.Drawing.Size(75, 23)
        Me.ButtonADD.TabIndex = 2
        Me.ButtonADD.Text = "Agregar"
        Me.ButtonADD.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(193, 143)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancel.TabIndex = 3
        Me.ButtonCancel.Text = "Cancelar"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Identificacion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nombre"
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Location = New System.Drawing.Point(6, 143)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(75, 23)
        Me.ButtonDelete.TabIndex = 0
        Me.ButtonDelete.Text = "Eliminar"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonCancel2
        '
        Me.ButtonCancel2.Location = New System.Drawing.Point(193, 143)
        Me.ButtonCancel2.Name = "ButtonCancel2"
        Me.ButtonCancel2.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancel2.TabIndex = 1
        Me.ButtonCancel2.Text = "Cancelar"
        Me.ButtonCancel2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Identificacion"
        '
        'TextID2
        '
        Me.TextID2.Location = New System.Drawing.Point(6, 19)
        Me.TextID2.Name = "TextID2"
        Me.TextID2.Size = New System.Drawing.Size(100, 20)
        Me.TextID2.TabIndex = 3
        '
        'TextID3
        '
        Me.TextID3.Location = New System.Drawing.Point(6, 19)
        Me.TextID3.Name = "TextID3"
        Me.TextID3.Size = New System.Drawing.Size(100, 20)
        Me.TextID3.TabIndex = 0
        '
        'TextNombre3
        '
        Me.TextNombre3.Location = New System.Drawing.Point(6, 58)
        Me.TextNombre3.Name = "TextNombre3"
        Me.TextNombre3.Size = New System.Drawing.Size(100, 20)
        Me.TextNombre3.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Identificacion"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Nombre"
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.Location = New System.Drawing.Point(6, 143)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRefresh.TabIndex = 4
        Me.ButtonRefresh.Text = "Actualizar"
        Me.ButtonRefresh.UseVisualStyleBackColor = True
        '
        'ButtonCancel3
        '
        Me.ButtonCancel3.Location = New System.Drawing.Point(193, 143)
        Me.ButtonCancel3.Name = "ButtonCancel3"
        Me.ButtonCancel3.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancel3.TabIndex = 5
        Me.ButtonCancel3.Text = "Cancelar"
        Me.ButtonCancel3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents ButtonADD As System.Windows.Forms.Button
    Friend WithEvents TextNombre1 As System.Windows.Forms.TextBox
    Friend WithEvents TextID1 As System.Windows.Forms.TextBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TextID2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ButtonCancel2 As System.Windows.Forms.Button
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents ButtonCancel3 As System.Windows.Forms.Button
    Friend WithEvents ButtonRefresh As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextNombre3 As System.Windows.Forms.TextBox
    Friend WithEvents TextID3 As System.Windows.Forms.TextBox

End Class
