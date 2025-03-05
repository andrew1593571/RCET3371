Option Explicit On
Option Strict On

'Andrew Keller
'RCET3371
'Spring 2025
'GameOfWar
'https://github.com/andrew1593571/RCET3371.git

Public Class DeckOfCards

    ''' <summary>
    ''' Stores the shuffled deck in a stack
    ''' </summary>
    Private _deck As New Stack(Of PlayingCard)

    ''' <summary>
    ''' The number of remaining cards in the deck
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property Remaining() As Integer
        Get
            Return Me._deck.Count
        End Get
    End Property

    ''' <summary>
    ''' When a new instance is created, shuffle the deck
    ''' </summary>
    Sub New()
        Me.Shuffle()
    End Sub

    ''' <summary>
    ''' Load the deck stack with a shuffled deck
    ''' </summary>
    Public Sub Shuffle()
        Dim suit As Integer
        Dim value As Integer
        Dim card As PlayingCard
        Dim deckArray() As PlayingCard
        Dim inDeck As Boolean

        Me._deck.Clear()

        For i = 1 To 52
            suit = Me.GetRandomNumberInRange(4, 1)
            value = Me.GetRandomNumberInRange(13, 1)
            inDeck = False

            card = New PlayingCard(suit, value)
            deckArray = Me._deck.ToArray()

            For j = 0 To deckArray.Length() - 1
                If suit = deckArray(j).Suit And value = deckArray(j).Value Then
                    inDeck = True
                End If
            Next

            If inDeck Then
                i -= 1
            Else
                Me._deck.Push(card)
            End If
        Next
    End Sub

    ''' <summary>
    ''' Returns a random number in the specified range
    ''' </summary>
    ''' <param name="Max"></param>
    ''' <param name="Min"></param>
    ''' <returns></returns>
    Private Function GetRandomNumberInRange(Max As Integer, Optional Min As Integer = 0) As Integer
        Dim randomNumber As Integer

        'Initialize randomize with the current time in milliseconds
        Randomize(DateTime.Now.Millisecond)

        randomNumber = CInt(Math.Floor((Rnd() * ((Max - Min) + 1)))) + Min

        Return randomNumber
    End Function

End Class
