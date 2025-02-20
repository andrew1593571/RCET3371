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
    End Sub

End Module
