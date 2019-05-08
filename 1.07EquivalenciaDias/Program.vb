Imports System
Module EquivalenciaDias
    Sub Main(args As String())

        Const dias_del_anio As Integer = 365
        Const dias_laborales As Integer = 247
        Const dias_semana As Integer = 7
        Const horas_por_dia As Integer = 24
        Const minutos_por_hora As Integer = 60
        Dim dias As Integer

        Console.Write("Ingrese cantidad de dias: ")
        dias = Console.ReadLine()
        Console.WriteLine("Corresponde a: " & dias / dias_semana & " semanas")
        Console.WriteLine("Corresponde a: " & dias * horas_por_dia & " horas")
        Console.WriteLine("Corresponde a: " & dias * horas_por_dia * minutos_por_hora & " minutos")
        Console.WriteLine("El anio tiene en total: " & dias_del_anio / dias_semana & " semanas")
        Console.WriteLine("El anio tiene en total: " & dias_laborales / dias_semana & " semanas laborales")
    End Sub
End Module