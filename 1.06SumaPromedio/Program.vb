Imports System
Module SumaPromedio
    Sub Main(args As String())

        Dim a As Integer
        Dim b As Integer
        Dim c As Integer
        Dim d As Integer
        Dim e As Integer

        Console.Write("Ingrese el 1° valor: ")
        a = Console.ReadLine()
        Console.Write("Ingrese el 2° valor: ")
        b = Console.ReadLine()
        Console.Write("Ingrese el 3° valor: ")
        c = Console.ReadLine()
        Console.Write("Ingrese el 4° valor: ")
        d = Console.ReadLine()
        Console.WriteLine("La sumatoria de los numeros ingresados es: " & a + b + c + d)
        e = a + b + c + d
        Console.WriteLine("La media de las numeros ingresados es: " & e / 2)
        Console.WriteLine("El promedio de los cuatro valores ingresados es: " & e / 4)
    End Sub
End Module