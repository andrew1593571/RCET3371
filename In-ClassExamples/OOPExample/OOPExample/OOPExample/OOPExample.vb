Option Explicit On
Option Strict On
Imports OOPExample.Libs



'Andrew Keller
'RCET3371
'Spring 2025
'OOP Example
'https://github.com/andrew1593571/RCET3371.git

Module OOPExample

    Sub Main()
        Andrew.TestingClass.SomeSub()
        CircuitSolver.SeriesCircuit.SolveSeriesCircuit()
        CircuitSolver.ParallelSolver.SolveParallelCircuit()
        Console.WriteLine(Libs.UsefulStuffLib.LuckyNumber())

        Dim Deck As New CardGame.DeckOfCards("Bill")
        Dim DeckTwo As New CardGame.DeckOfCards("Frank")
        Dim OtherDeck As New CardGame.DeckOfCards("Mary")

        Console.WriteLine(Deck.Name)
        Console.WriteLine(DeckTwo.Name)
        Console.WriteLine(OtherDeck.Name)

    End Sub

End Module
