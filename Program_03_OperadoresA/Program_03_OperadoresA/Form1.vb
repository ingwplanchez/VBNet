Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim num1, num2, operacion As Integer
        num1 = 4
        num2 = 5
        operacion = num1 + num2
        MsgBox(operacion.ToString)

    End Sub
End Class
