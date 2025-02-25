Option Explicit On
Option Strict On
Imports OOPExample.Libs

'Andrew Keller
'RCET3371
'Spring 2025
'OOP Example
'https://github.com/andrew1593571/RCET3371.git

Namespace CardGame

    Public Class PlayingCard

        Private _suit As String
        Public ReadOnly Property Suit() As String
            Get
                Return _suit
            End Get
        End Property

        Private _value As String
        Public ReadOnly Property Value() As String
            Get
                Return _value
            End Get
        End Property

        Sub New(suit As String, value As String)

            Me._suit = suit
            Me._value = value

        End Sub

    End Class

End Namespace