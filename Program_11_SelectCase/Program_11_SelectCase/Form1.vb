Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim opcion As String = ""
        Dim n1, n2 As Integer
        Dim operacion As Double

        

        Try
            If RadioSuma.Checked = True Then
                opcion = "Sumar"
            End If

            If RadioResta.Checked = True Then
                opcion = "Restar"
            End If

            If RadioMultiplicacion.Checked = True Then
                opcion = "Multiplicar"
            End If

            If RadioDivision.Checked = True Then
                opcion = "Dividir"
            End If

            n1 = TextBox1.Text
            n2 = TextBox2.Text

            Select Case opcion
                Case "Sumar"
                    operacion = n1 + n2
                Case "Restar"
                    operacion = n1 - n2
                Case "Multiplicar"
                    operacion = n1 * n2
                Case "Dividir"
                    operacion = n1 / n2
                Case Else
                    MsgBox("NO se ha selecccionado ninguna operacion")
                    Exit Sub
            End Select
            MsgBox("Resultado: " + operacion.ToString)

        Catch ex As Exception
            MsgBox("Formato invalido.")
        End Try



    End Sub
End Class

