Imports System
Module Interes
    Sub Main(args As String())

        Dim m, r, i As Decimal
        Dim t As UShort

        Console.Write("Ingrese el monto: ")
        m = Console.ReadLine()
        Console.Write("Ingrese el % de interes: ")
        r = Console.ReadLine()
        Console.Write("Ingrese el tiempo: ")
        t = Console.ReadLine()
        i = (m * r * t) / (360 * 100)
        Console.WriteLine("Interes: " & i)
        Console.WriteLine("Monto acumulado: " & i + m)
    End Sub
End Module