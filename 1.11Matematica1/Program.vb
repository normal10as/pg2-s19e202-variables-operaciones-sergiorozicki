Imports System.Math
Module Matematica1
    Sub Main(args As String())

        Dim valor As Integer = 0
        Dim valorabsoluto

        Console.Write("Ingrse un valor numerico: ")
        valor = Console.ReadLine()
        valorabsoluto = Abs(valor)
        Console.WriteLine("Valor absoluto: " & valorabsoluto)
        Console.WriteLine("Elevado a la decima potenia: " & valorabsoluto ^ 10)
        Console.WriteLine("Raiz cuadrada: " & Sqrt(valorabsoluto))
    End Sub
End Module