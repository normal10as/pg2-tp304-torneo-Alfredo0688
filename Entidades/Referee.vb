Public Class Referee
    Inherits Persona

    Private _internacional As Boolean
    Private _campo As String
    Sub New(nombre As String, fechanacimiento As Date, internacional As Boolean)
        MyBase.New(nombre, fechanacimiento)
        Me.Internacional = _internacional
    End Sub

    Public Property Internacional As Boolean
        Get
            Return _internacional
        End Get
        Set(value As Boolean)
            _internacional = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        If Internacional = True Then
            _campo = "[I]"
        End If
        Return MyBase.Nombre & " " & _campo
    End Function

End Class
