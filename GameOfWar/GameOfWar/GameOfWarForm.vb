﻿Imports System.Linq.Expressions
Imports System.Reflection.Emit

Public Class GameOfWarForm

    ''' <summary>
    ''' Stores the current warGame
    ''' </summary>
    Private warGame As WarGameLogic

    Private gameInProgress As Boolean

    Sub UpdateGraphics()
        Dim g As Graphics = TablePictureBox.CreateGraphics
        Dim blackBrush As New SolidBrush(Color.Black)
        Dim whiteBrush As New SolidBrush(Color.White)
        Dim font As New Font(Me.Font.Name, 2.5, Me.Font.Style)
        Dim gameOverFont As New Font(Me.Font.Name, 6, Me.Font.Style)
        Dim scaleX!, scaleY!
        Dim cardBack As Image = My.Resources.ResourceManager.GetObject("CardBack")
        Dim table As Queue(Of PlayingCard)
        Dim tableX As Integer = 70
        Dim gameOverRectangle As New Rectangle(10, 30, 80, 20)

        table = warGame.Table

        scaleX = CSng(TablePictureBox.Width / 100)
        scaleY = CSng(TablePictureBox.Height / 100)
        TablePictureBox.Refresh()

        g.ScaleTransform(scaleX, scaleY)
        g.DrawString("Player One", font, blackBrush, New Rectangle(40, 0, 20, 5))
        g.DrawString("Player Two", font, blackBrush, New Rectangle(40, 95, 20, 5))

        If warGame.playerOneRemaining <> 0 Then
            g.DrawImage(cardBack, New Rectangle(10, 5, 20, 40))
        End If
        If warGame.playerTwoRemaining <> 0 Then
            g.DrawImage(cardBack, New Rectangle(10, 55, 20, 40))
        End If

        If warGame.RoundsPlayed <> 0 Then
            g.DrawImage(My.Resources.ResourceManager.GetObject(warGame.PlayerOneCard.ShortName), New Rectangle(40, 5, 20, 40))
            g.DrawImage(My.Resources.ResourceManager.GetObject(warGame.PlayerTwoCard.ShortName), New Rectangle(40, 55, 20, 40))
        End If

        If table.Count <> 0 Then
            For i = 1 To table.Count
                g.DrawImage(My.Resources.ResourceManager.GetObject(table.Dequeue.ShortName), New Rectangle(tableX, 30, 20, 40))
                tableX += 5
            Next
        End If

        If warGame.GameOver Then
            g.FillRectangle(whiteBrush, gameOverRectangle)
            Select Case warGame.Winner
                Case 1
                    g.DrawString("Player One Wins!", gameOverFont, blackBrush, gameOverRectangle)
                Case 2
                    g.DrawString("Player Two Wins!", gameOverFont, blackBrush, gameOverRectangle)
            End Select
        End If

        blackBrush.Dispose()
        g.Dispose()
    End Sub

    ''' <summary>
    ''' Updates all text labels for the game
    ''' </summary>
    Sub UpdateLabels()
        PlayerOneRemainingLabel.Text = $"Remaining: {warGame.playerOneRemaining} Cards"
        PlayerTwoRemainingLabel.Text = $"Remaining: {warGame.playerTwoRemaining} Cards"

        PlayerOneRoundsWonLabel.Text = $"Rounds Won: {warGame.PlayerOneRoundsWon}"
        PlayerTwoRoundsWonLabel.Text = $"Rounds Won: {warGame.PlayerTwoRoundsWon}"

        If warGame.RoundsPlayed = 0 Then
            PlayerOneLastCardLabel.Text = $"Last Card: -"
            PlayerTwoLastCardLabel.Text = $"Last Card: -"
            LastWinnerLabel.Text = $"Last Round Winner: -"

        Else
            PlayerOneLastCardLabel.Text = $"Last Card: {warGame.PlayerOneCard.PrettyName}"
            PlayerTwoLastCardLabel.Text = $"Last Card: {warGame.PlayerTwoCard.PrettyName}"
            Select Case warGame.RoundWinner
                Case 0
                    LastWinnerLabel.Text = $"Last Round Winner: War"
                Case 1
                    LastWinnerLabel.Text = $"Last Round Winner: Player One"
                Case 2
                    LastWinnerLabel.Text = "Last Round Winner: Player Two"
            End Select

        End If

        RoundsLabel.Text = $"Rounds Played: {warGame.RoundsPlayed}"

    End Sub

    ''' <summary>
    ''' starts a new game if a game is not currently in progress
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click, StartTopMenuItem.Click
        If gameInProgress Then
            MsgBox($"A Game at round {warGame.RoundsPlayed} is currently in progress.")
        Else
            warGame = New WarGameLogic
            gameInProgress = True
            UpdateLabels()
            UpdateGraphics()
        End If
    End Sub

    ''' <summary>
    ''' If a game is in progress, plays the next round and updates both graphics and labels
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub PlayButton_Click(sender As Object, e As EventArgs) Handles PlayButton.Click, PlayTopMenuItem.Click
        If gameInProgress Then
            warGame.PlayRound()
            UpdateLabels()
            UpdateGraphics()
            If warGame.GameOver Then
                gameInProgress = False
            End If
        Else
            MsgBox("Please start a new game.")
        End If
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub AboutTopMenuItem_Click(sender As Object, e As EventArgs) Handles AboutTopMenuItem.Click
        AboutForm.Show()
    End Sub
End Class
