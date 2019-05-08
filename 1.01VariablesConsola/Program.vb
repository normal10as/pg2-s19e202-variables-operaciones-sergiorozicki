Imports System

Module VariablesConsola
    Sub Main(args As String())

        Dim nombre, b As String
        Dim apellido As String
        Dim fecha_nacimiento As Date

        Console.Write("Igrese nombre: ")
        nombre = Console.ReadLine()
        Console.Write("Ingrese apellido: ")
        apellido = Console.ReadLine()
        Console.Write("Ingrese fecha de nacimiento: ")
        fecha_nacimiento = Console.ReadLine()
        Console.WriteLine(apellido & " " & nombre & " " & "nacido el: " & fecha_nacimiento)
        Console.Read()
    End Sub
End Module