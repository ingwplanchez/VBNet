Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Sub soloNumeros(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then 'Si es un digito (letra)
            e.Handled = False ' si el usuario digita una letra no hace nada 

        ElseIf Char.IsControl(e.KeyChar) Then ' Si se presiona una tecla de control   
            e.Handled = False ' No hace nada
        Else
            e.Handled = True ' Muestra
        End If
        MsgBox(e.KeyChar.ToString)


    End Sub


    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        soloNumeros(e)
    End Sub
End Class
