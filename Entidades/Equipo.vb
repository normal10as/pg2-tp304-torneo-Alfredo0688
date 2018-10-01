Public Class Equipo
    Private _nombre As String
    Private _jugadores As List(Of Jugador)

    Sub New(nombre As String)
        Me.Nombre = nombre
    End Sub

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            If value <> "" And value.Length <= 30 Then
                _nombre = value
            End If

        End Set
    End Property

    Public Sub ComprarJugador(jugador As Jugador)
        _jugadores.Add(jugador)
    End Sub

    Public Function GetAllJugador() As List(Of Jugador)
        Return _jugadores
    End Function

    Public Function liberarJugador(jugador As Jugador)

        _jugadores.Remove(jugador)

    End Function

    'Public Sub VenderJugador(jugador As Jugador, equipodestino As Equipo)
    '    _jugadores.Remove(jugador)
    'End Sub
    Public Overrides Function ToString() As String
        Return Me.Nombre
    End Function
End Class
