Option Explicit On
Option Strict On
Imports OOPExample.CardGame
Imports OOPExample.Libs



'Andrew Keller
'RCET3371
'Spring 2025
'OOP Example
'https://github.com/andrew1593571/RCET3371.git

Module OOPExample

    Sub Main()
        Dim card As PlayingCard
        Dim mainForm As New MainForm

        Andrew.TestingClass.SomeSub()
        CircuitSolver.SeriesCircuit.SolveSeriesCircuit()
        CircuitSolver.ParallelSolver.SolveParallelCircuit()
        Console.WriteLine(Libs.UsefulStuffLib.LuckyNumber())

        Dim Deck As New CardGame.DeckOfCards("Bill")
        Dim DeckTwo As New CardGame.DeckOfCards("Frank")
        Dim OtherDeck As New CardGame.DeckOfCards("Mary")

        Deck.Shuffle()

        For i = 1 To 52
            card = Deck.Deal()
            If card IsNot Nothing Then
                Console.WriteLine($"{Deck.Remaining} - {card.PrettyName}")
            End If
        Next

        Console.WriteLine(Deck.Name)
        Console.WriteLine(DeckTwo.Name)
        Console.WriteLine(OtherDeck.Name)

        'Console.Read()
        mainForm.Show()

        Console.ReadLine()

    End Sub

End Module
