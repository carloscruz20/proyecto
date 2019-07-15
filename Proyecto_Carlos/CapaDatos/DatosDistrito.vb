Imports System.Data.SqlClient
Imports CapaEntidad
Public Class DatosDistrito
    Dim db As New SqlConnection
    Dim rg As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim conexion As String = ("Data Source=DESKTOP-GG6H7TF;Initial Catalog=Prueba;Integrated Security=True")

    Public Sub Registrar(ByVal EnDis As EntidadDistrito)
        rg = New SqlCommand("InsertarDis", db)
        rg.CommandType = CommandType.StoredProcedure
        rg.Parameters.AddWithValue("@Id_Distrito", EnDis.Id_Distrito)
        rg.Parameters.AddWithValue("@Nombre_Distrito", EnDis.Nombre_Distrito)
        rg.ExecuteNonQuery()
    End Sub

    Public Sub Conectar()
        db = New SqlConnection(conexion)
        db.Open()
    End Sub
    Public Sub Desconectar()
        db.Close()
    End Sub

    Public Function ConsultaDis()
        rg = New SqlCommand("ListaDis", db)
        rg.CommandType = CommandType.StoredProcedure
        da = New SqlDataAdapter(rg)
        ConsultaDis = New DataTable
        da.Fill(ConsultaDis)
    End Function
    Public Sub Eliminar(ByVal EnDis As EntidadDistrito)
        rg = New SqlCommand("Eliminar", db)
        rg.CommandType = CommandType.StoredProcedure
        rg.Parameters.AddWithValue("@Id_Distrito", EnDis.Id_Distrito)
        rg.Parameters.AddWithValue("@Nombre_Distrito", EnDis.Nombre_Distrito)
        rg.ExecuteNonQuery()
    End Sub
End Class
