Public Class Form5
    Dim conexion As Conexion = New Conexion
    Private Sub Btn_Aceptar_Click(sender As Object, e As EventArgs) Handles Btn_Aceptar.Click
        'lo primero capturar usuario y clave
        'Encriptar la clave con el metodo sha256
        'Buscar por medio de una funcion o metodo el usuario
        'en la base de datos
        'Si encuentra al usuario se trae la clave
        'encriptada y la compara con la clave
        'digitada
        'Si no encuentra el usuario desplegar mensaje clave incorrecta
        'usuario no existe
        Dim strsql, vusuario, vclave As String
        strsql = ""
        vusuario = ""
        vclave = ""
        Try
            If Txt_Usuario.Text = "" Or Txt_Clave.Text = "" Then
                MsgBox("Ambos campos son oligatorios")
                Return
            Else
                vusuario = Txt_Usuario.Text
                vclave = Txt_Clave.Text
                Dim contraseñaencriptada As String = conexion.Encriptarcontraseña(vclave)
                vclave = contraseñaencriptada
                Dim dt = conexion.Consulta_usuario(vusuario)
                If f = 0 Then
                    If vclave = dt.Rows(0)!clave Then
                        Formulario_Finalvb.Show()
                    Else
                        MsgBox("Clave Incorrecta")
                        Return
                    End If
                Else
                    MsgBox("Usuario no registrado")
                    Return
                End If

            End If

        Catch ex As Exception
            MessageBox.Show("Error:" + ex.ToString)

        Finally
        End Try
    End Sub
End Class