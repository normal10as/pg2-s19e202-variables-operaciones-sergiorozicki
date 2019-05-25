Module Refrase

    Sub Main()
        Dim frase As String = " Aunque la cadena sea de oro, sirve para lo mismo."
        Dim palabra_actual, palabra_nueva, frase_nueva As String
        Console.WriteLine(frase)
        Console.Write("Ingrese la palabra a reemplazar: ")
        palabra_actual = Console.ReadLine()
        Console.Write("Ingrese la palabra nueva: ")
        palabra_nueva = Console.ReadLine()
        Dim palabra_actual1 = " " + palabra_actual + " "
        Dim palabra_nueva1 = " " + palabra_nueva + " "
        frase_nueva = (Replace(frase, palabra_actual1, palabra_nueva1, 1, -1, 1))
        palabra_actual1 = " " + palabra_actual + ","
        palabra_nueva1 = " " + palabra_nueva + ","
        frase_nueva = (Replace(frase_nueva, palabra_actual1, palabra_nueva1, 1, -1, 1))
        palabra_actual1 = " " + palabra_actual + "."
        palabra_nueva1 = " " + palabra_nueva + "."
        frase_nueva = (Replace(frase_nueva, palabra_actual1, palabra_nueva1, 1, -1, 1))
        Console.WriteLine("Frase editada: " & frase_nueva)
        Console.ReadLine()
    End Sub

End Module
