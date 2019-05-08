Imports System
Module Concatenacion
    Sub Main(args As String())

        Dim nombre_empresa As String = "Pepe"
        Dim nombre_calle As String = "Bs As"
        Dim altura_calle As Integer = 2115
        Dim fecha_inicio_actividades As Date = "15/06/2010"
        Dim nombre_empresa2, nombre_calle2, altura_calle2, fecha_inicio_actividades2

        Console.WriteLine(nombre_empresa & " " & nombre_calle & " " & altura_calle & " " & fecha_inicio_actividades)
        nombre_empresa2 = Convert.ToString(nombre_empresa)
        nombre_calle2 = Convert.ToString(nombre_calle)
        altura_calle2 = Convert.ToString(altura_calle)
        fecha_inicio_actividades2 = Convert.ToString(fecha_inicio_actividades)
        Console.WriteLine(nombre_empresa2 + " " + nombre_calle2 + " " + altura_calle2 + " " + fecha_inicio_actividades2)
    End Sub
End Module