﻿Module module1

    Sub main()
        Dim numeros(9) As Integer

        Dim suma As Integer = 0

        For i = 0 To numeros.Length - 1 Step 1

            Console.WriteLine("ingrese in valor: " & i + 1)
            numeros(i) = Console.ReadLine()

        Next

        Console.WriteLine("suma total:  " & suma)
        Console.ReadLine()

    End Sub
End Module
