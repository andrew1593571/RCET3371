Option Strict On
Option Explicit On

Public Class GraphicsForm

    Sub SetDefaults()
        'TODO
    End Sub

    Sub DrawLine(x%, y%, oldX%, oldY%)
        Dim g As Graphics = DrawPictureBox.CreateGraphics
        Dim pen As New Pen(Color.Black)
        Dim scaleX!, scaleY!
        Dim deltaY!, deltaX!

        scaleX = CSng(DrawPictureBox.Width / 100)
        scaleY = CSng(DrawPictureBox.Height / 100) * -1

        deltaX = 0
        deltaY = CSng(DrawPictureBox.Height / 2)

        'g.TranslateTransform(deltaX, deltaY)
        'g.ScaleTransform(scaleX, scaleY)

        g.DrawLine(pen, oldX, oldY, x, y)

        oldX = x
        oldY = y

        g.Dispose()
        pen.Dispose()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        SetDefaults()
    End Sub

    Private Sub DrawButton_Click(sender As Object, e As EventArgs) Handles DrawButton.Click
        DrawLine(95, 95, 0, 5)
    End Sub

    Private Sub DrawPictureBox_MouseMove(sender As Object, e As MouseEventArgs) Handles DrawPictureBox.MouseMove
        Static oldX%, oldY%
        CoordinatesStatusLabel.Text = $"({e.X.ToString.PadLeft(4)},{e.Y.ToString.PadLeft(4)})"
        If e.Button = MouseButtons.Left Then
            DrawLine(e.X, e.Y, oldX, oldY)
        End If

        oldX = e.X
        oldY = e.Y
    End Sub
End Class
