Public Class Form1

    Private Sub ButtonSaludo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSaludo.Click
        MsgBox("Hola Mundo")
    End Sub

    Private Sub ButtonSuma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSuma.Click

        Dim num1, num2, suma As Integer
        num1 = TextNum1.Text
        num2 = TextNum2.Text

        suma = num1 + num2
        LabelResultado.Text = suma.ToString

    End Sub

    Private Sub ButtonCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCerrar.Click
        Me.Close()
    End Sub
End Class
