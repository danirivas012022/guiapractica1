Module Module1

    Sub Main()
        FunCInt()
    End Sub

    Sub FunCInt()
        Console.WriteLine("Ingresar el valor entero numero uno: ")
        Dim valor1 As Integer = CInt(Console.ReadLine())

        Console.Write("Ingresar el valor entero numero dos: ")
        Dim valor2 As Integer = CInt(Console.ReadLine())

        Console.Write("Ingresear el valor entero numero 3: ")
        Dim valor3 As Integer = CInt(Console.ReadLine())

        Dim mayor As Integer
        Dim medio As Integer
        Dim menor As Integer

        If valor1 >= valor2 AndAlso valor1 >= valor3 Then
            mayor = valor1
            If valor2 >= valor3 Then
                medio = valor2
                menor = valor3
            Else
                medio = valor3
                menor = valor2
            End If
        ElseIf valor2 >= valor1 AndAlso valor2 >= valor3 Then
            mayor = valor2
            If valor1 >= valor3 Then
                medio = valor1
                menor = valor3
            Else
                medio = valor3
                menor = valor1
            End If
        Else
            mayor = valor3
            If valor1 >= valor2 Then
                medio = valor1
                menor = valor2
            Else
                medio = valor2
                menor = valor1
            End If
        End If

        Console.WriteLine("El mayor valor es: " & mayor)
        Console.WriteLine("El valor medio es: " & medio)
        Console.WriteLine("El menor valor es: " & menor)

        Console.WriteLine("Guia realizada por Daniela Beatriz Rivas Hernández")
        Console.ReadLine()
    End Sub

End Module
