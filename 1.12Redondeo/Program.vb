Imports System.Math
Module Program
    Sub Main(args As String())

        Dim valor As Decimal

        Console.Write("Ingrese un numero real: ")
        valor = Console.ReadLine()
        Console.WriteLine("Valor aproximado por exceso: " & Math.Ceiling(valor))
        Console.WriteLine("Valor aproximado por defecto: " & Math.Floor(valor))
        Console.WriteLine("Su valor redondeado: " & Math.Round(valor))
    End Sub
End Module