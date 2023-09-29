Module Module1

    Sub Main()
        Console.WriteLine("Ingresar el promedio de las infracciones: ")
        Dim promedioMensual As Double = Double.Parse(Console.ReadLine())

        Dim promedioDelDia As Double = (promedioMensual * 0.2) / 30
        Dim promedioDelaTarde As Double = (promedioMensual * 0.35) / 30
        Dim promedioDelaNoche As Double = (promedioMensual * 0.45) / 30

        Console.WriteLine("Promedio diario de infracciones matutino: " & promedioDelDia)
        Console.WriteLine("Promedio diario de infracciones en la tarde: " & promedioDelaTarde)
        Console.WriteLine("Promedio diario de infracciones nocturno: " & promedioDelaNoche)


        Console.WriteLine("Guia realizada por Daniela Beatriz Rivas Hernández")
        Console.ReadLine()
    End Sub

End Module
