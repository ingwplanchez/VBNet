Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim Arreglo(3) As String
        Dim IntArreglo() As Integer
        Dim Matriz(,) As Integer = {{1, 2, 3}, {4, 5, 6}}

        IntArreglo = New Integer() {1, 2, 3}

        Arreglo(0) = "Posicion 0"
        Arreglo(1) = "Posicion 1"
        Arreglo(2) = "Posicion 2"

        MsgBox(Arreglo(0))
        MsgBox(Arreglo(1))
        MsgBox(Arreglo(2))

        MsgBox(Arreglo(0) + " " + Arreglo(1) + " " + Arreglo(2))
        MsgBox(IntArreglo(0).ToString + " " + IntArreglo(1).ToString + " " + IntArreglo(2).ToString)

        MsgBox(Matriz(1, 1).ToString)

    End Sub
End Class
