Imports System

Module NuevaFecha
    Sub Main(args As String())

        Dim fecha As Date
        Dim dias_a_sumar As Integer

        Console.Write("Ingrese Fecha: ")
        fecha = Console.ReadLine()
        Console.Write("Ingrese dias a sumar: ")
        dias_a_sumar = Console.ReadLine()
        Console.WriteLine("Fecha obtenida de la suma: " & fecha.AddDays(dias_a_sumar))
    End Sub
End Module
