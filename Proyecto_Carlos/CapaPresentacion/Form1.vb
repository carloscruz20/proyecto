Imports CapaEntidad
Imports CapaNegocios
Public Class Form1
    Dim ed As New EntidadDistrito
    Dim nd As New NegocioDistrito
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = nd.ConsultaDis
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ed.Id_Distrito = txtcodigo.Text
        ed.Nombre_Distrito = txtnombre.Text
        nd.Registrar(ed)
        MsgBox("Datos Registrados")
        txtcodigo.Clear()
        txtnombre.Clear()
        DataGridView1.DataSource = nd.ConsultaDis
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ed.Id_Distrito = txteliminar.Text
        ed.Nombre_Distrito = txtnombre.Text
        nd.Eliminar(ed)
        MsgBox("Registro Elimando")
        txteliminar.Clear()
        DataGridView1.DataSource = nd.ConsultaDis
    End Sub
End Class
