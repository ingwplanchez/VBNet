Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Sub saludar()
        MsgBox("Funcion saludar")
    End Sub

    Function retornaSaludo()
        Dim saludo As String
        saludo = "Procedimiento Saludo"
        Return saludo
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        saludar()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim hola As String
        hola = retornaSaludo()
        MsgBox(hola)

    End Sub
End Class
