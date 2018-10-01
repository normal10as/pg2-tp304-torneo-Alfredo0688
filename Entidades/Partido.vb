Public Class Partido
    Private _local As Equipo
    Private _visitante As Equipo
    Private _refereee As Referee
    Private _jornada As Byte
    Private _golesLocal As Byte
    Private _golesVisitantes As Byte
    Private _minutosGolesLocales As List(Of Byte)
    Private _minutosGolesVisitantes As List(Of Byte)
    Private _finalizado As Boolean

    Public Property Local As Equipo
        Get
            Return _local
        End Get
        Set(value As Equipo)
            _local = value
        End Set
    End Property

    Public Property Visitante As Equipo
        Get
            Return _visitante
        End Get
        Set(value As Equipo)
            _visitante = value
        End Set
    End Property

    Public Property Referee As Referee
        Get
            Return _refereee
        End Get
        Set(value As Referee)
            _refereee = value
        End Set
    End Property

    Public Property Jornada As Byte
        Get
            Return _jornada
        End Get
        Set(value As Byte)
            _jornada = value
        End Set
    End Property

    Public ReadOnly Property golesLocal As Byte
        Get
            Return _golesLocal
        End Get
    End Property

    Public ReadOnly Property golesVisitantes As Byte
        Get
            Return _golesVisitantes
        End Get
    End Property

    Public ReadOnly Property minutosGolesLocales As List(Of Byte)
        Get
            Return _minutosGolesLocales
        End Get
    End Property

    Public ReadOnly Property minutosGolesVisitantes As List(Of Byte)
        Get
            Return _minutosGolesVisitantes
        End Get
    End Property

    Public Sub nuevoGolLocal(minutos As UShort)
        _minutosGolesLocales.Add(minutos)
        _golesLocal += 1
    End Sub

    Public Sub nuevoGolVisitante(minutos As UShort)
        _minutosGolesVisitantes.Add(minutos)
        _golesVisitantes += 1
    End Sub

    Public Sub finalizado()
        _finalizado = True
    End Sub

    Public Overrides Function ToString() As String
        Return Me.Local.ToString & "(" & Me.golesLocal & ") " & Me.Visitante.ToString & "(" & golesVisitantes & ")"
    End Function

End Class
