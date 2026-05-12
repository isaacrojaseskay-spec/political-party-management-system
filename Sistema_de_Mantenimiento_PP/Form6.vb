Public Class Form6
    Dim conexion As Conexion = New Conexion
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        'Declarar variables
        Dim strsql, vusuario, vclave As String
        Dim j As Integer
        strsql = ""
        vusuario = ""
        vclave = ""
        j = 0
        Try
            If TxtUsuario.Text = "" Or TxtClave.Text = "" Then
                MsgBox("Datos Imcompletos, por favor completar")
                Return
            Else
                If MessageBox.Show("Esta seguro de insertar el Registro en la base de datos?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                    vusuario = TxtUsuario.Text
                    vclave = TxtClave.Text
                    Dim contraseñaencriptada As String = conexion.Encriptarcontraseña(vclave)
                    vclave = contraseñaencriptada
                    strsql = "INSERT INTO USUARIO_CLAVE( USUARIO,CLAVE)"
                    strsql += vbCrLf + "VALUES('" & vusuario & "','" & vclave & "')"
                    MsgBox(strsql)
                    conexion.insertar(strsql)
                    If f = 0 Then
                        MessageBox.Show("Datos Almacenados sactisfactoriamente", "Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        MessageBox.Show("Error al insertar datos", "Datos no Guardados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error:" + ex.ToString)
        End Try
    End Sub

    Private Sub TxtUsuario_TextChanged(sender As Object, e As EventArgs) Handles TxtUsuario.TextChanged

    End Sub
End Class