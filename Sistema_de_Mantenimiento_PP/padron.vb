Public Class padron
    Private conexionManager As New Conexion()
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Txthora.Text = Now
    End Sub

    Private Sub Btncargar_Click(sender As Object, e As EventArgs) Handles Btncargar.Click
        If TxtRuta.Text.Trim() = "" Then
            MessageBox.Show("Por favor, ingrese la ruta del archivo")
        Else
            conexionManager.cargarArchivo(TxtRuta.Text.Trim)

        End If


    End Sub


End Class