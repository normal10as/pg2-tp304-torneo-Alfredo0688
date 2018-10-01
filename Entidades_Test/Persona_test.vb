Imports Entidades
Module Persona_test


    Sub Main()
        Dim per As New Persona("Gomez", #2-22-1995#)


        Console.WriteLine("Nombre de la persona: {0}", per.Nombre)
        Console.WriteLine("Fecha de nacimiento de la persona: {0}", per.FechaNacimiento)
        Console.WriteLine("Edad de la persona: {0}", per.Edad)
        Console.ReadKey()
    End Sub

End Module
