Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer

        For i = 0 To 9
            MsgBox("Iteracion: " + i.ToString)
        Next
    End Sub
End Class
