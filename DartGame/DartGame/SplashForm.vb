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