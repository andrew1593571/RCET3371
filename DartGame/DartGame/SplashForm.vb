Option Strict On
Option Explicit On

'Andrew Keller
'RCET3371
'Spring 2025
'Dart Game
'https://github.com/andrew1593571/RCET3371.git

Public Class SplashForm

    Private Sub SplashTimer_Tick(sender As Object, e As EventArgs) Handles SplashTimer.Tick
        SplashTimer.Stop()
        DartGameForm.Show()
        Me.Close()
    End Sub

    Private Sub SplashForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SplashTimer.Start()
    End Sub
End Class