Public Class Persona
    Private _fechaNacimiento As Date
    Private _nombre As String

    Sub New(nombre As String, fechanacimiento As Date)
        Me.FechaNacimiento = Now
        Me.Nombre = ""
    End Sub

    Public Property FechaNacimiento As Date
        Get
            Return _fechaNacimiento
        End Get
        Set(value As Date)
            If value <= value.AddYears(-16) Then
                value = _fechaNacimiento
            End If
        End Set
    End Property

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

    Public ReadOnly Property Edad As Short
        Get
            Return CalcularEdad(FechaNacimiento, Today)
        End Get
    End Property

    Private Function CalcularEdad(fecha_nacimiento As Date, fecha_actual As Date) As Short
        Return fecha_actual.Year - fecha_nacimiento.Year
    End Function

    Public Overrides Function ToString() As String
        Return Me.Nombre
    End Function

End Class
