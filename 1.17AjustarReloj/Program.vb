Imports System.DateTime
Imports System.String

Module AjustarReloj
    Sub Main(args As String())

        Dim a�o, mes, minuto, segundo As Date
        Dim dia, hora, ajustar As String

        a�o = a�o.Now
        mes = mes.Now
        minuto = minuto.Now
        segundo = segundo.Now
        Console.Write("Ingrese dia del 1 al 31: ")
        dia = Console.ReadLine()
        Console.Write("Ingrese hora del 00 al 23: ")
        hora = Console.ReadLine()
        ajustar = New DateTime(a�o.Year, mes.Month, dia, hora, minuto.Minute, segundo.Second)
        Console.WriteLine("Reloj ajustado: " & ajustar)

    End Sub
End Module