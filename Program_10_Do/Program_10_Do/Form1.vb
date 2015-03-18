Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer = 0

        Do
            MsgBox("Ciclo Do = " + i.ToString)
            i = i + 1
        Loop While i < 3

        i = 0

        Do While i < 3
            MsgBox("Ciclo Do While = " + i.ToString)
            i = i + 1
        Loop

        i = 0

        While i < 3
            MsgBox("Ciclo While = " + i.ToString)
            i = i + 1
        End While

    End Sub
End Class
