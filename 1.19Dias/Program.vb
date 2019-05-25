Imports System

Module Dias
    Enum DiasDeSemana
        Domingo = 1
        Lunes = 2
        Martes = 3
        Miercoles = 4
        Jueves = 5
        Viernes = 6
        Sabado = 7
    End Enum
    Sub Main(args As String())
        Dim dias As DiasDeSemana
        Console.WriteLine("Ingrese numero de dia (entre 1 y 7): ")
        dias = Console.ReadLine()
        Console.WriteLine("El dia seleccionado es: " & dias.ToString)
    End Sub
End Module
