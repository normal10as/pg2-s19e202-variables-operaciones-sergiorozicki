Module Cadenas1

    Sub Main()
        Dim palabra, a, o, invertida As String
        Console.Write("Ingrese una palabra que contenga la letra (a) y la letra (o): ")
        palabra = Console.ReadLine()
        a = InStr(1, palabra, "a")
        o = InStr(1, palabra, "o")
        invertida = StrReverse(palabra)
        Console.WriteLine("La posicion de la 1° letra (a) es: " & a)
        Console.WriteLine("La posicion de la 1° letra (o) es: " & o)
        Console.WriteLine("La palabra invertida es: " & invertida)
        Console.ReadLine()
    End Sub

End Module
