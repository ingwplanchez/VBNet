Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Rock, Blues, Jazz, Flamenco, Tango As Boolean

        If Me.CheckRock.Checked Then
            Rock = True
        Else
            Rock = False
        End If

        If Me.CheckBlues.Checked Then
            Blues = True
        Else
            Blues = False
        End If

        If Me.CheckJazz.Checked Then
            Jazz = True
        Else
            Jazz = False
        End If

        If Me.CheckFlamenco.Checked Then
            Flamenco = True
        Else
            Flamenco = False
        End If

        If Me.CheckTango.Checked Then
            Tango = True
        Else
            Tango = False
        End If

        MsgBox("Generos seleccionados")

        If Rock Then
            MsgBox("Rock")
        End If

        If Blues Then
            MsgBox("Blues")
        End If

        If Jazz Then
            MsgBox("Jazz")
        End If

        If Flamenco Then
            MsgBox("Flamenco")
        End If

        If Tango Then
            MsgBox("Tango")
        End If


    End Sub
End Class
