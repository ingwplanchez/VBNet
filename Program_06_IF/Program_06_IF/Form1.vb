Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim num1, num2 As Integer

        num1 = TextBox1.Text
        num2 = TextBox2.Text

        If (num1 < num2) Then
            MsgBox("Numero 1 menor que numero 2")

        ElseIf (num1 = num2) Then
            MsgBox("Los numeros son iguales")

        Else
            MsgBox("Numero 1 mayor que numero 2")
        End If

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
