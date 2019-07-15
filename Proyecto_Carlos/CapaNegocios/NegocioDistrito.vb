Imports CapaEntidad
Imports CapaDatos
Public Class NegocioDistrito
    Dim dd As New DatosDistrito
    Public Sub Registrar(ByVal EnDis As EntidadDistrito)
        dd.Conectar()
        dd.Registrar(EnDis)
        dd.Desconectar()
    End Sub
    Public Function ConsultaDis()
        dd.Conectar()
        Return dd.ConsultaDis
        dd.Desconectar()
    End Function
    Public Sub Eliminar(ByVal EnDis As EntidadDistrito)
        dd.Conectar()
        dd.Eliminar(EnDis)
        dd.Desconectar()
    End Sub
End Class
