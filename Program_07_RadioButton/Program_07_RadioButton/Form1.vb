Public Class Form1

    Private Sub ButtonCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCalcular.Click
        Dim n1, n2 As Integer
        Dim Resultado As Double

        n1 = TextNum1.Text
        n2 = TextNum2.Text

        If (RadioSuma.Checked = True) Then
            Resultado = n1 + n2

        ElseIf (RadioResta.Checked = True) Then
            Resultado = n1 - n2

        ElseIf (RadioMultiplicacion.Checked = True) Then
            Resultado = n1 * n2

        Else
            Resultado = n1 / n2
            If (n2 = 0) Then
                MsgBox("El denominador debe ser diferente de cero")
            End If
        End If
        MsgBox("El resultado es " + Resultado.ToString)

    End Sub
End Class
