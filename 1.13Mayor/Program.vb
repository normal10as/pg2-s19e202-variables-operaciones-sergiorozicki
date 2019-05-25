Imports System.Math

Module Program
    Sub Main(args As String())

        Dim valor1, valor2, valor3, mayor1, mayor2 As Integer

        Console.Write("Ingrese 1er valor numerico: ")
        valor1 = Console.ReadLine()
        Console.Write("Ingrese 2do valor numerico: ")
        valor2 = Console.ReadLine()
        Console.Write("Ingrese 3er valor numerico: ")
        valor3 = Console.ReadLine()
        mayor1 = Max(valor1, valor2)
        mayor2 = Max(mayor1, valor3)
        Console.WriteLine("El mayor valor es: " & (mayor2))
    End Sub
End Module