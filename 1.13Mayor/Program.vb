Imports System

Module Program
    Sub Main(args As String())

        Dim valor, mayor As Integer
        Dim contador = 0

        While contador <= 2
            Console.Write("Ingrese un valor numerico: ")
            valor = Console.ReadLine()
            contador += 1
            If contador = 1 Then
                mayor = valor
            End If
            If valor >= mayor Then
                mayor = valor
            End If
        End While
        Console.WriteLine("El mayor valor es: " & (mayor))
    End Sub
End Module