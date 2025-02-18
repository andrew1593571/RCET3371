Public Class HistoryForm

    ''' <summary>
    ''' Stores the current history
    ''' (Turn,Dart,X/Y) X is 0, Y is 1
    ''' If LoadHistory is true, will load existing history from file
    ''' </summary>
    ''' <returns></returns>
    Function History(Optional loadHistory As Boolean = False) As Integer(,,)
        Static _history(LastTurn(), 2, 1) As Integer
        Dim currentLine As String
        Dim turnNumber As Integer
        Dim dartNumber As Integer
        Dim x As Integer
        Dim y As Integer

        If loadHistory Then
            FileOpen(1, "Throws.log", OpenMode.Input)

            Do Until EOF(1)
                currentLine = LineInput(1)
                turnNumber = CInt(Split(currentLine, ",")(0)) - 1
                dartNumber = CInt(Split(currentLine, ",")(1)) - 1
                x = CInt(Split(currentLine, ",")(2))
                y = CInt(Split(currentLine, ",")(3))
                _history(turnNumber, dartNumber, 0) = x
                _history(turnNumber, dartNumber, 1) = y
            Loop

            FileClose(1)
        End If

        Return _history
    End Function

    Function TurnNumber(Optional nextTurn As Boolean = False, Optional backTurn As Boolean = False, Optional setTurn As Integer = 0) As Integer
        Static _turnNumber As Integer

        If setTurn <> 0 Then
            _turnNumber = setTurn
        End If

        If nextTurn Then
            _turnNumber += 1
        End If

        If backTurn Then
            _turnNumber -= 1
        End If

        If _turnNumber > LastTurn() Then
            _turnNumber = LastTurn()
        End If

        If _turnNumber < 1 Then
            _turnNumber = 1
        End If

        LoadTurn(_turnNumber - 1)

        TurnNumberLabel.Text = _turnNumber.ToString

        Return _turnNumber
    End Function

    Sub LoadTurn(turnNumber As Integer)
        Dim _history As Integer(,,) = History()
        Dim g As Graphics = HistoryPictureBox.CreateGraphics
        Dim brush As New SolidBrush(Color.Red)
        Dim x As Integer
        Dim y As Integer

        HistoryPictureBox.Refresh()
        'g.FillEllipse(brush, 200, 100, 30, 30)
        'g.FillRectangle(brush, 100, 100, 30, 30)

        For i = 0 To 2
            x = History()(turnNumber, i, 0)
            y = History()(turnNumber, i, 1)
            g.FillEllipse(brush, x - 15, y - 15, 30, 30) 'draws a 30 by 30 ellipse centered on X and Y

        Next

        TurnNumberLabel.Text = CStr(turnNumber + 1)

        g.Dispose()
        brush.Dispose()
    End Sub

    ''' <summary>
    ''' Retrieves the last turn stored in file
    ''' </summary>
    ''' <returns></returns>
    Function LastTurn() As Integer
        Dim lastLine As String

        FileOpen(1, "Throws.log", OpenMode.Input)
        'scan the throws.log file until End of File, retrieves last line
        Do Until EOF(1)
            lastLine = LineInput(1)
        Loop
        FileClose(1)

        TotalTurnLabel.Text = Split(lastLine, ",")(0)


        'retrieve last turn from the last line of the file
        Return CInt(Split(lastLine, ",")(0))
    End Function

    Private Sub HistoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        History(True)
        LoadTimer.Start()
    End Sub

    ''' <summary>
    ''' When the History Form closes, shows the Dart Game form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub HistoryForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        DartGameForm.Show()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click, BackToGameTopMenuItem.Click, BackToGameToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        TurnNumber(True)
    End Sub

    Private Sub PreviousButton_Click(sender As Object, e As EventArgs) Handles PreviousButton.Click
        TurnNumber(False, True)
    End Sub

    Private Sub AboutTopMenuItem_Click(sender As Object, e As EventArgs) Handles AboutTopMenuItem.Click, AboutToolStripMenuItem.Click
        AboutForm.Show()
    End Sub

    Private Sub LoadTimer_Tick(sender As Object, e As EventArgs) Handles LoadTimer.Tick
        LoadTimer.Stop()
        TurnNumber(False, False, 1)
    End Sub
End Class