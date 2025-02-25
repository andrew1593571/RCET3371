Option Explicit On
Option Strict On
Imports OOPExample.Libs

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


        'fields (variables/constants)

        '
        Sub New(name As String)
            Me.Name = name
        End Sub

        'other methods

    End Class

End Namespace