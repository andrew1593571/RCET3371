Option Explicit On
Option Strict On

'Andrew Keller
'RCET3371
'Spring 2025
'GameOfWar
'https://github.com/andrew1593571/RCET3371.git

Public Class WarGameLogic
    Private _playerOneDeck As New Stack(Of PlayingCard)

    Private _playerTwoDeck As New Stack(Of PlayingCard)

    Public ReadOnly Property playerOneRemaining() As Integer
        Get
            Return _playerOneDeck.Count
        End Get
    End Property

    Public ReadOnly Property playerTwoRemaining() As Integer
        Get
            Return _playerTwoDeck.Count
        End Get
    End Property

    Sub New()
        Dim deck As New DeckOfCards
        Dim playerSelect As Boolean = False

        Do
            If playerSelect Then
                _playerTwoDeck.Push(deck.Deal)
                playerSelect = False
            Else
                _playerOneDeck.Push(deck.Deal)
                playerSelect = True
            End If
        Loop While deck.Remaining <> 0
    End Sub
End Class
