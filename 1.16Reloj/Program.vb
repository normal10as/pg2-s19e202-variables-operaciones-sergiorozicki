Imports System.DateTime

Module Reloj
    Sub Main(args As String())
        Console.WriteLine("D�a del a�o: " & Now.DayOfYear)
        Console.WriteLine("Mes: " & Now.Month)
        Console.WriteLine("Hora: " & Now.Hour)
        Console.WriteLine("Minutos: " & Now.Minute)
    End Sub
End Module