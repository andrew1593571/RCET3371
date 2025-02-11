Option Strict On
Option Explicit On

'Andrew Keller
'RCET3371
'Spring 2025
'Dart Game
'https://github.com/andrew1593571/RCET3371.git

Public Class DartGameForm

    Sub ThrowDart()
        MsgBox("Throw")
    End Sub

    Private Sub AboutMenuItem_Click(sender As Object, e As EventArgs) Handles AboutTopMenuItem.Click, AboutContextMenuItem.Click
        AboutForm.Show()
    End Sub

    Private Sub DartGameForm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar.ToString = " " Then
            ThrowDart()
        End If
    End Sub
    Private Sub ThrowButton_Click(sender As Object, e As EventArgs) Handles ThrowButton.Click
        ThrowDart()
    End Sub
End Class
