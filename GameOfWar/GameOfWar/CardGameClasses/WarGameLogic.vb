Option Explicit On
Option Strict On

'Andrew Keller
'RCET3371
'Spring 2025
'GameOfWar
'https://github.com/andrew1593571/RCET3371.git

Public Class WarGameLogic
    Private _playerOneDeck As New Queue(Of PlayingCard)

    Private _playerTwoDeck As New Queue(Of PlayingCard)

    Private _table As New Queue(Of PlayingCard)

    Private _playerOneCard As PlayingCard

    Private _playerTwoCard As PlayingCard

    Private _roundsplayed As Integer

    Private _gameOver As Boolean

    Private _winner As Integer

    Private _roundWinner As Integer

    ''' <summary>
    ''' If the game has ended, the winner is returned. Else 0 is returned.
    ''' Return 1 is a player one win.
    ''' Return 2 is a player two win.
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property Winner() As Integer
        Get
            Return _winner
        End Get
    End Property

    ''' <summary>
    ''' returns the last round winner
    ''' 0 is a war
    ''' 1 is a player one victory
    ''' 2 is a player two victory
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property RoundWinner As Integer
        Get
            Return _roundWinner
        End Get
    End Property

    ''' <summary>
    ''' Returns true if the game has ended
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property GameOver() As Boolean
        Get
            Return _gameOver
        End Get
    End Property

    ''' <summary>
    ''' Returns the number of rounds played in the current game
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property RoundsPlayed As Integer
        Get
            Return _roundsplayed
        End Get
    End Property

    ''' <summary>
    ''' Returns the most recently played card for Player One
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property PlayerOneCard As PlayingCard
        Get
            Return _playerOneCard
        End Get
    End Property

    ''' <summary>
    ''' Returns the most recently played card for player two.
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property PlayerTwoCard As PlayingCard
        Get
            Return _playerTwoCard
        End Get
    End Property

    ''' <summary>
    ''' Returns the full queue of cards held on the table following war
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property Table As Queue(Of PlayingCard)
        Get
            Dim _duplicateTable As New Queue(Of PlayingCard)
            Dim card As PlayingCard
            For i = 1 To _table.Count
                card = _table.Dequeue
                _duplicateTable.Enqueue(card)
                _table.Enqueue(card)
            Next
            Return _duplicateTable
        End Get
    End Property

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

    ''' <summary>
    ''' When player one wins a round, put both player's cards into player one's deck with any cards currently on the table.
    ''' </summary>
    Private Sub PlayerOneWin()
        _playerOneDeck.Enqueue(_playerOneCard)
        _playerOneDeck.Enqueue(_playerTwoCard)
        If _table.Count <> 0 Then
            For i = 1 To _table.Count
                _playerOneDeck.Enqueue(_table.Dequeue)
            Next
        End If
        _roundWinner = 1
    End Sub

    ''' <summary>
    ''' When player two wins a round, put both player's cards into player two's deck with any cards currently on the table.
    ''' </summary>
    Private Sub PlayerTwoWin()
        _playerTwoDeck.Enqueue(_playerTwoCard)
        _playerTwoDeck.Enqueue(_playerOneCard)
        If _table.Count <> 0 Then
            For i = 1 To _table.Count
                _playerTwoDeck.Enqueue(_table.Dequeue)
            Next
        End If
        _roundWinner = 2
    End Sub

    ''' <summary>
    ''' If the game is not over, pull the top card from each player and determine the outcome
    ''' </summary>
    Public Sub PlayRound()

        If Not _gameOver Then
            _playerOneCard = _playerOneDeck.Dequeue
            _playerTwoCard = _playerTwoDeck.Dequeue

            Select Case True
                Case _playerOneCard.Value = _playerTwoCard.Value
                    'war has occurred, put both cards into the _table queue
                    _table.Enqueue(_playerOneCard)
                    _table.Enqueue(_playerTwoCard)
                    _roundWinner = 0

                Case _playerOneCard.Value = 1
                    'if player one has an ace
                    PlayerOneWin()

                Case _playerTwoCard.Value = 1
                    'if player two has an ace
                    PlayerTwoWin()

                Case _playerOneCard.Value > _playerTwoCard.Value
                    'if player one outranks player two
                    PlayerOneWin()

                Case _playerTwoCard.Value > _playerOneCard.Value
                    'if player two outranks player one
                    PlayerTwoWin()
            End Select

            'increment number of rounds played and check if game is over
            _roundsplayed += 1
            If _playerOneDeck.Count = 0 Or _playerTwoDeck.Count = 0 Then
                _gameOver = True
                Select Case 0
                    Case _playerOneDeck.Count
                        _winner = 1

                    Case _playerTwoDeck.Count
                        _winner = 2
                End Select
            End If
        End If

    End Sub

    ''' <summary>
    ''' Create new game
    ''' </summary>
    Sub New()
        Dim deck As New DeckOfCards
        Dim playerSelect As Boolean = False

        Do
            If playerSelect Then
                _playerTwoDeck.Enqueue(deck.Deal)
                playerSelect = False
            Else
                _playerOneDeck.Enqueue(deck.Deal)
                playerSelect = True
            End If
        Loop While deck.Remaining <> 0

        _roundsplayed = 0
    End Sub
End Class
