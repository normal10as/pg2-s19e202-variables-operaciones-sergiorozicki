Imports System

Module VariablesConsola
    Sub Main(args As String())

        Dim nombre As String
        Dim apellido As String
        Dim fecha_nacimiento As Date

        Console.Write("Igrese el nombre de la persona: ")
        nombre = Console.ReadLine()
        Console.Write("Ingrese el apellido de la persona: ")
        apellido = Console.ReadLine()
        Console.Write("Ingrese la fecha de nacimiento: ")
        fecha_nacimiento = Console.ReadLine()
        Console.WriteLine(apellido & " " & nombre & " " & "nacido el: " & fecha_nacimiento)
        Console.Read()
    End Sub
End Module