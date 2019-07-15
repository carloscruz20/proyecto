Public Class EntidadDistrito
    Private _Id_Distrito As String
    Private _Nombre_Distrito As String

    Public Property Id_Distrito As String
        Get
            Return _Id_Distrito
        End Get
        Set(value As String)
            _Id_Distrito = value
        End Set
    End Property

    Public Property Nombre_Distrito As String
        Get
            Return _Nombre_Distrito
        End Get
        Set(value As String)
            _Nombre_Distrito = value
        End Set
    End Property
End Class
