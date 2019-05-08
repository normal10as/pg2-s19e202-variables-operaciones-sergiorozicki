Imports System
Module VariablesTipo
    Sub Main(args As String())

        Dim nombre As String = "Sergio"
        Dim DNI As Integer = 25456698
        Dim lugar_nacimiento As String = "Posadas"
        Dim fecha_nacimiento As Date = "6 / 11 / 1995"
        Dim altura As Byte = 179
        Dim nacionlidad As Boolean = True
        Dim temperatura_ambiente As Decimal = 30
        Dim nombre_calle As String = "Bs As"
        Dim altura_calle As Integer = 2589
        Dim distancis_ciudad_km As UShort = 10
        Dim profundidad_mar_mts As UShort = 200
        Dim cant_habit_territ_nacional As Integer = 44271041
        Dim kg_producto As Decimal = 25
        Dim monto_articulo As Decimal = 150

        Console.WriteLine("Senor/ra: " & nombre & vbCrLf & "DNI: " & DNI & vbCrLf & "Lugar de nacimiento: " & lugar_nacimiento & vbCrLf & "Fecha de nacimiento: " & fecha_nacimiento &
                           vbCrLf & "Altura corporal: " & altura & vbCrLf & "Nacionalidad: " & nacionlidad & vbCrLf & "Temperatura hambiente: " & temperatura_ambiente &
                           vbCrLf & "Nombre de la calle: " & nombre_calle & vbCrLf & "Altura de la calle: " & altura_calle & vbCrLf & "Distancia entre ciudad : " & distancis_ciudad_km &
                           vbCrLf & "Profundidad del mar: " & profundidad_mar_mts & vbCrLf & "Cantidad habitantes territorio nacional: " & cant_habit_territ_nacional &
                           vbCrLf & "Kg producto: " & kg_producto & vbCrLf & "Monto articulo: " & monto_articulo)
    End Sub
End Module