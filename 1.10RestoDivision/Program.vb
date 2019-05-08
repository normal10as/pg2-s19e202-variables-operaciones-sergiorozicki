Imports System
Module RetornoDivision
    Sub Main(args As String())

        Dim valor, resto As Integer

        Console.Write("Ingrese un valor entero: ")
        valor = Console.ReadLine()
        resto = valor Mod 2
        Console.WriteLine("Resto = " & resto)
    End Sub
End Module