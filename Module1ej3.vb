Module Module1

    Sub Main()
        FunCInt()
    End Sub

    Sub FunCInt()
        Console.WriteLine("Ingresar el primer número entero: ")
        Dim num1 As Integer = CInt(Console.ReadLine())

        Console.Write("Ingresar el segundo número entero: ")
        Dim num2 As Integer = CInt(Console.ReadLine())

        If num2 Mod num1 = 0 Then
            Console.WriteLine(num1 & " es divisor de " & num2)
        Else
            Console.WriteLine(num1 & " no es divisor de " & num2)
        End If


        Console.WriteLine("Guia realizada por Daniela Beatriz Rivas Hernández")
        Console.ReadLine()
    End Sub
End Module
