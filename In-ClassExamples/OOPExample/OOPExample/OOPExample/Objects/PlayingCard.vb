Option Explicit On
Option Strict On

'Andrew Keller
'RCET3371
'Spring 2025
'OOP Example
'https://github.com/andrew1593571/RCET3371.git

Namespace CardGame

    Public Class PlayingCard

        Private _suit As Integer
        Public ReadOnly Property Suit() As Integer
            Get
                Return _suit
            End Get
        End Property

        Private _value As Integer
        Public ReadOnly Property Value() As Integer
            Get
                Return _value
            End Get
        End Property

        Sub New(suit As Integer, value As Integer)

            Me._suit = suit
            Me._value = value

        End Sub

        ''' <summary>
        ''' Gets the suit name
        ''' </summary>
        ''' <returns>Suit name String</returns>
        Public Function PrettySuit() As String
            Dim _names() As String = {"Spades", "Clubs", "Diamonds", "Hearts"}

            Return _names(Me.Suit - 1)

        End Function


        ''' <summary>
        ''' Gets the Card Name
        ''' </summary>
        ''' <returns>Card name String</returns>
        Public Function PrettyValue() As String
            Select Case Me.Value
                Case 1
                    Return "Ace"
                Case 2
                    Return "Two"
                Case 3
                    Return "Three"
                Case 4
                    Return "Four"
                Case 5
                    Return "Five"
                Case 6
                    Return "Six"
                Case 7
                    Return "Seven"
                Case 8
                    Return "Eight"
                Case 9
                    Return "Nine"
                Case 10
                    Return "Ten"
                Case 11
                    Return "Jack"
                Case 12
                    Return "Queen"
                Case 13
                    Return "King"
                Case Else
                    Return "Unknown"
            End Select
        End Function

        ''' <summary>
        ''' Returns the pretty name of the card
        ''' </summary>
        ''' <returns></returns>
        Public Function PrettyName() As String
            Return $"{Me.PrettyValue} of {Me.PrettySuit}"
        End Function

    End Class

End Namespace