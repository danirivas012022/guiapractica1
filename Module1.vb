Module Module1

    Sub Main()
        FunCDbl()

    End Sub

    Sub FunCDbl()
        Console.WriteLine("Ingresar el tiempo en horas: ")
        Dim horas As Double = CDbl(Console.ReadLine())

        Console.WriteLine("Ingresar el tiempo en minutos: ")
        Dim minutos As Double = CDbl(Console.ReadLine())

        Dim tiempoCompletoEnHoras As Double = horas + (minutos / 60)

        Dim distanciaKM As Double = 42.195
        Dim velocidadKmPorHora As Double = distanciaKM / tiempoCompletoEnHoras
        Dim velocidadKmPorMinuto As Double = distanciaKM / (tiempoCompletoEnHoras * 60)
        Dim velocidadKmPorSegundo As Double = distanciaKM / (tiempoCompletoEnHoras * 3600)
        Dim velocidadMetrosPorMinuto As Double = (distanciaKM * 1000) / (tiempoCompletoEnHoras * 60)
        Dim velocidadMetrosPorSegundo As Double = (distanciaKM * 1000) / (tiempoCompletoEnHoras * 3600)

        Console.WriteLine("Velocidad media en Km/h: " & velocidadKmPorHora)
        Console.WriteLine("Velocidad media en Km/min: " & velocidadKmPorMinuto)
        Console.WriteLine("Velocidad media en Km/s: " & velocidadKmPorSegundo)
        Console.WriteLine("Velocidad media en m/min: " & velocidadMetrosPorMinuto)
        Console.WriteLine("Velocidad media en m/s: " & velocidadMetrosPorSegundo)


        Console.WriteLine("Guia realizada por Daniela Beatriz Rivas Hernández")

        Console.ReadLine()


    End Sub


End Module
