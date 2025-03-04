Option Explicit On
Option Strict On

'Andrew Keller
'RCET3371
'Spring 2025
'GameOfWar
'https://github.com/andrew1593571/RCET3371.git

Public Class PlayingCard
    Private _suit As Integer
    ''' <summary>
    ''' Returns the card suit as an integer
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property Suit() As Integer
        Get
            Return _suit
        End Get
    End Property

    Private _value As Integer
    ''' <summary>
    ''' Returns the card value as an integer
    ''' </summary>
    ''' <returns></returns>
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
End Class
