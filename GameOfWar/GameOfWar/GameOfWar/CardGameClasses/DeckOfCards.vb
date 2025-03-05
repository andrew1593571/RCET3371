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

End Class
