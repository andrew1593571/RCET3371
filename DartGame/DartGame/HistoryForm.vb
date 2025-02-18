Public Class HistoryForm

    Function History() As Integer(,,,)
        Static _History(LastTurn() - 1, 2, 0, 0) As Integer

        MsgBox("Test")
    End Function

    Sub LoadTurn(turnNumber As Integer)

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

    End Sub

    Private Sub PreviousButton_Click(sender As Object, e As EventArgs) Handles PreviousButton.Click


    End Sub

    Private Sub HistoryForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        DartGameForm.Show()
    End Sub
End Class