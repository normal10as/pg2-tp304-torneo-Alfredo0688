Public Class Jugador
    Inherits Persona
    Private _numero As Short
    Private _equipo As Equipo 'asociacion bidireccional
    'un jugador puede estar sin equipo o 1 equipo

    'el set de equipo será friend
    Sub New(nombre As String, fechanacimiento As Date, numero As UShort)
        MyBase.New(nombre, fechanacimiento)
        Me.Numero = 0
    End Sub

    Public Property Equipo As Equipo
        Get
            Return _equipo
        End Get
        Set(value As Equipo)
            _equipo = value
        End Set
    End Property

    Public Property Numero As Short
        Get
            Return _numero
        End Get
        Set(value As Short)
            If value > 0 And value < 100 Then
                _numero = value
            End If

        End Set
    End Property

    Public Overrides Function ToString() As String
        Return Me.Nombre & "(" & Me.Numero & ")"
    End Function

End Class
