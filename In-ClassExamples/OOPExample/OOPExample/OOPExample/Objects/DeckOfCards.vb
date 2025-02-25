Option Explicit On
Option Strict On

'Andrew Keller
'RCET3371
'Spring 2025
'OOP Example
'https://github.com/andrew1593571/RCET3371.git

Namespace CardGame

    Public Class DeckOfCards
        'properties
        Private _name As String
        ''' <summary>
        ''' The name of the card deck
        ''' </summary>
        ''' <returns></returns>
        Public Property Name() As String
            Get
                Return _name
            End Get
            Set(ByVal value As String)
                _name = value
            End Set
        End Property

        Public ReadOnly Property Remaining() As Integer
            Get
                Return Me._deck.Count
            End Get
        End Property

        Private _deck As New Stack(Of PlayingCard)

        Sub New(name As String)
            Me.Name = name
        End Sub

        Public Sub Shuffle()
            Dim suit As Integer
            Dim value As Integer
            Dim card As PlayingCard
            Dim array() As PlayingCard
            Dim inDeck As Boolean

            Me._deck.Clear()

            For i = 1 To 52
                suit = Me.GetRandomNumberInRange(4, 1)
                value = Me.GetRandomNumberInRange(13, 1)
                inDeck = False

                card = New PlayingCard(suit, value)

                array = Me._deck.ToArray()

                For j = 0 To array.Length() - 1
                    If suit = array(j).Suit And value = array(j).Value Then
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

        Public Function Deal() As PlayingCard
            If Me._deck.Count > 0 Then
                Return Me._deck.Pop()
            Else
                Return Nothing
            End If
        End Function

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

End Namespace