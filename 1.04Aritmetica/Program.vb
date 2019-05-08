Imports System
Module Aritmetica
    Sub Main(args As String())

        Dim entero1 As Integer = 5
        Dim entero2 As Integer = 7
        Dim flotante1 As Double = 6.4
        Dim flotante2 As Double = 4.6

        Console.WriteLine("Suma de entero1 con entero2: " & entero1 + entero2)
        Console.WriteLine("Suma de flotante1 con flotante2: " & flotante1 + flotante2)
        Console.WriteLine("Suma de entero1 con flotante1: " & entero1 + flotante1)
        Console.WriteLine("Suma de entero2 con flotante2: " & entero2 + flotante2)
        Console.WriteLine("Resta de entero1 con entero2: " & entero1 - entero2)
        Console.WriteLine("Resta de flotante1 con flotante2: " & flotante1 - flotante2)
        Console.WriteLine("Resta de entero1 con flotante1: " & entero1 - flotante1)
        Console.WriteLine("Resta de entero2 con flotante2: " & entero2 - flotante2)
        Console.WriteLine("Multiplicacion de entero1 con entero2: " & entero1 * entero2)
        Console.WriteLine("Multiplicacion de flotante1 con flotante2: " & flotante1 * flotante2)
        Console.WriteLine("Multiplicacion de entero1 con flotante1: " & entero1 * flotante1)
        Console.WriteLine("Multiplicacion de entero2 con flotante2: " & entero2 * flotante2)
        Console.WriteLine("Division de entero1 con entero2: " & entero1 / entero2)
        Console.WriteLine("Division de flotante1 con flotante2: " & flotante1 / flotante2)
        Console.WriteLine("Division de entero1 con flotante1: " & entero1 / flotante1)
        Console.WriteLine("Division de entero2 con flotante2: " & entero2 / flotante2)
    End Sub
End Module