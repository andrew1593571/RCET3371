Option Strict On
Option Explicit On

'Andrew Keller
'RCET3371
'Spring 2025
'Dart Game
'https://github.com/andrew1593571/RCET3371.git

Public Class DartGameForm

    ''' <summary>
    ''' Stores the current turn number and calls the store sub if a new turn is called
    ''' </summary>
    ''' <param name="newTurn"></param>
    ''' <param name="setTurn"></param>
    ''' <returns></returns>
    Function TurnNumber(Optional newTurn As Boolean = False, Optional setTurn As Integer = 0) As Integer
        Static _turnNumber As Integer

        If setTurn <> 0 Then
            _turnNumber = setTurn
        End If

        If newTurn Then
            _turnNumber += 1
        End If

        TurnNumberLabel.Text = _turnNumber.ToString

        Return _turnNumber
    End Function

    Function DartNumber(Optional newDart As Boolean = False, Optional setDart As Integer = 0) As Integer
        Static _dartNumber As Integer

        If setDart <> 0 Then
            _dartNumber = setDart
        End If

        If newDart Then
            _dartNumber += 1
            If _dartNumber > 3 Then 'If new dart number is greater than 3, increase the turn number and set dart number to 1
                TurnNumber(True)
                _dartNumber = 1
            End If
            'TODO - call the store sub
        End If

        DartNumberLabel.Text = _dartNumber.ToString

        Return _dartNumber
    End Function

    Sub ThrowDart()
        DartNumber(True)

    End Sub

    Private Sub AboutMenuItem_Click(sender As Object, e As EventArgs) Handles AboutTopMenuItem.Click, AboutContextMenuItem.Click
        AboutForm.Show()
    End Sub

    Private Sub DartGameForm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar.ToString = " " Then
            ThrowDart()
            MsgBox("Test")
        End If
    End Sub
    Private Sub ThrowButton_Click(sender As Object, e As EventArgs) Handles ThrowButton.Click
        ThrowDart()
    End Sub

    Private Sub DartGameForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        TurnNumber(False, 1)
        DartNumber(False, 0)
    End Sub
End Class
