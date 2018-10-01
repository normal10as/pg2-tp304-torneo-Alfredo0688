Imports Entidades
Module Jugador_test
    Sub main()

        Dim jug As New Jugador("CR7", #5/2/1984#, 7)

        Console.WriteLine("Nombre del jugador: {0}", jug.Nombre)
        Console.WriteLine("Fecha de nacimiento del jugador: {0}", jug.FechaNacimiento)
        Console.WriteLine("Número del jugador: {0}", jug.Numero)
        Console.WriteLine("Edad del jugador: {0}", jug.Edad)
        Console.ReadKey()


    End Sub
End Module
