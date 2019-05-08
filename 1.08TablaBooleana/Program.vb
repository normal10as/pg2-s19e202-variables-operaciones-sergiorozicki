Imports System
Module Tabla_booleana
    Sub Main(args As String())
        Console.WriteLine("________Tabla And_______")
        Console.WriteLine("Verdadero y verdadero: " & (True And True))
        Console.WriteLine("Verdadero y falso: " & (True And False))
        Console.WriteLine("Falso y verdadero: " & (False And True))
        Console.WriteLine("Falso y falso: " & (False And False))
        Console.WriteLine("________Tabla Or________")
        Console.WriteLine("Verdadero y verdadero: " & (True Or True))
        Console.WriteLine("Verdadero y falso: " & (True Or False))
        Console.WriteLine("Falso y verdadero: " & (False Or True))
        Console.WriteLine("Falso y falso: " & (False Or False))
        Console.WriteLine("________Tabla Xor________")
        Console.WriteLine("Verdadero y verdadero: " & (True Xor True))
        Console.WriteLine("Verdadero y falso: " & (True Xor False))
        Console.WriteLine("Falso y verdadero: " & (False Xor True))
        Console.WriteLine("Falso y falso: " & (False Xor False))
        Console.WriteLine("________Tabla Not________")
        Console.WriteLine("Verdadero: " & (Not True))
        Console.WriteLine("Falso: " & (Not False))
    End Sub
End Module