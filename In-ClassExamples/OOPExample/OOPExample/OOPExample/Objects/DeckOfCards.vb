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