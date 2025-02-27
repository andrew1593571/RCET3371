Imports System.Resources
Imports OOPExample.CardGame

Public Class MainForm
    Private deck As New DeckOfCards
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        deck.Shuffle()
    End Sub

    Sub DealACard() Handles Me.Click
        Dim card As PlayingCard
        card = deck.Deal()

        If card IsNot Nothing Then
            DisplayPictureBox.BackgroundImage = My.Resources.ResourceManager.GetObject(card.ShortName)
        End If
    End Sub
End Class