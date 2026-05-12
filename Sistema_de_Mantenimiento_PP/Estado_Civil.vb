Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class Estado_Civil
    Private conexionManager As New Conexion()
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Txtfecha.Text = Now
    End Sub
    Private Sub Botinsertar_Click(sender As Object, e As EventArgs) Handles Botinsertar.Click
        'Definiendo una variable de conexion a la base de datos'
        Dim cn As SqlConnection = Nothing
        'Se define una variable de transaccion'
        Dim transaccion As SqlTransaction = Nothing
        'Cada vez que se hace una consulta a la base de datos se debe hacer dentro de un bloque Try-Catch para manejar los errores'
        Try
            'Obteniendo la conexion a la base de datos'
            cn = conexionManager.Obtener_Conexion()
            'Iniciando la transaccion'
            transaccion = cn.BeginTransaction()
            'Insertando un nuevo registro en la tabla TIPO_IDENTIFICACION'
            Dim cmdTipoid As New SqlCommand("INSERT INTO ESTADO_CIVIL(CODIGO_ID,DESCRIPCION)
            VALUES(@CODIGO_ID,@DESCRIPCION)", cn, transaccion)
            'Agregando los parametros al comando SQL'
            cmdTipoid.Parameters.AddWithValue("@CODIGO_ID", TxtEstadoCivilId.Text)
            'Agregando los parametros al comando SQL'
            cmdTipoid.Parameters.AddWithValue("@DESCRIPCION", TxtEstadoCivilDescripcion.Text)
            'Ahi le mando las variables'
            cmdTipoid.ExecuteNonQuery()
            'Inserto en la tabla tipo_identifiacion'

            'Ahora vamos a insertar un registro en la tabla BITACORA_EVENTO para registrar el evento de insercion que se acaba de realizar'
            Dim tabla, evento, usuario, identificacion As String
            'Vamos a definir el tipo de identificacion como un entero, ya que en la tabla BITACORA_EVENTO el campo TIPO_ID es de tipo entero'
            Dim tipo As Integer
            tabla = "ESTADO_CIVIL"
            evento = "INSERCION"
            usuario = "1"
            identificacion = "123456789"
            tipo = 1
            'Ahora vamos a insertar el registro en la tabla BITACORA_EVENTO'
            Dim cmdBitacora As New SqlCommand("INSERT INTO BITACORA_EVENTO(TABLA,EVENTO_CRUD,FECHA_HORA,CODIGO_USUARIO,TIPO_ID,IDENTIFICACION)
            VALUES(@TABLA,@EVENTO_CRUD,@FECHA_HORA,@CODIGO_USUARIO,@TIPO_ID,@IDENTIFICACION)", cn, transaccion)
            'Agregando los parametros al comando SQL'
            cmdBitacora.Parameters.AddWithValue("@TABLA", tabla)
            'Agregando los parametros al comando SQL'
            cmdBitacora.Parameters.AddWithValue("@EVENTO_CRUD", evento)
            'Agregando los parametros al comando SQL'
            cmdBitacora.Parameters.AddWithValue("@FECHA_HORA", DateTime.Now)
            'Agregando los parametros al comando SQL'
            cmdBitacora.Parameters.AddWithValue("@CODIGO_USUARIO", usuario)
            'Agregando los parametros al comando SQL'
            cmdBitacora.Parameters.AddWithValue("@TIPO_ID", tipo)
            'Agregando los parametros al comando SQL'
            cmdBitacora.Parameters.AddWithValue("@IDENTIFICACION", identificacion)
            'Ejecutando el comando SQL para insertar el registro en la tabla BITACORA_EVENTO'
            cmdBitacora.ExecuteNonQuery()
            'Si todo sale bien, se hace el commit de la transaccion para guardar los cambios en la base de datos'
            transaccion.Commit()
            MessageBox.Show("Datos guardados exitosamente")
        Catch ex As Exception
            If transaccion IsNot Nothing Then
                transaccion.Rollback()
                MessageBox.Show("Error : " + ex.ToString)
            End If
        Finally
            'Asegurarse de cerrar la conexion a la base de datos en el bloque Finally para liberar los recursos'
            If cn IsNot Nothing AndAlso cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub Txt_tipoid_Keypress(sender As Object, e As EventArgs) Handles TxtEstadoCivilId.KeyPress
        f = 0
        set_solo_numeros(e)
        If f = 1 Then
            MsgBox("Solo permite digitar numeros")
        End If
        TxtEstadoCivilId.Focus()
        Return
    End Sub

    Private Sub Botconsulta_Click(sender As Object, e As EventArgs) Handles Botconsulta.Click
        If TxtEstadoCivilId.Text = "" Then
            MsgBox("Datos obligatorios, favor digitar solo numeros")
            TxtEstadoCivilId.Focus()
            Return
        End If

        Dim vtipoid As Integer = Val(TxtEstadoCivilId.Text)
        Dim dt As DataTable = conexionManager.busca_codigo_dos(vtipoid)

        If f = 1 OrElse dt.Rows.Count = 0 Then
            MsgBox("Codigo de estado civil, no registrado")
            TxtEstadoCivilId.Focus()
            Return
        Else
            k = 1
            TxtEstadoCivilDescripcion.Text = dt.Rows(0)("DESCRIPCION").ToString()
        End If

        Me.ESTADO_CIVILTableAdapter.Fill(Me.PROYECTO_DB_PARTIDOS_POLITICOSDataSet1.ESTADO_CIVIL)
    End Sub

    Private Sub Grbacciones_Enter(sender As Object, e As EventArgs) Handles Grbacciones.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TxtEstadoCivilId.Text = ""
        TxtEstadoCivilDescripcion.Text = ""
        TxtEstadoCivilId.Focus()
    End Sub

    Private Sub Txtfecha_TextChanged(sender As Object, e As EventArgs) Handles Txtfecha.TextChanged

    End Sub

    Private Sub Botmodificar_Click(sender As Object, e As EventArgs) Handles Botmodificar.Click
        If k = 0 Then
            MsgBox("Debe Presionar, el boton de Consultar antes de Modificar")
            Return
        End If


        If TxtEstadoCivilId.Text = "" Or TxtEstadoCivilDescripcion.Text = "" Then
            MsgBox("Datos obligatorios, favor digitar solo numeros")
            TxtEstadoCivilId.Focus()
            Return
        End If



        Dim cn As SqlConnection = Nothing
        Dim transaccion As SqlTransaction = Nothing
        Try
            cn = conexionManager.Obtener_Conexion()
            transaccion = cn.BeginTransaction()
            Dim cmdTipoidm As New SqlCommand("UPDATE ESTADO_CIVIL SET DESCRIPCION=@DESCRIPCION WHERE CODIGO_ID=@CODIGO_ID", cn, transaccion)
            cmdTipoidm.Parameters.AddWithValue("@CODIGO_ID", TxtEstadoCivilId.Text)
            cmdTipoidm.Parameters.AddWithValue("@DESCRIPCION", TxtEstadoCivilDescripcion.Text)
            cmdTipoidm.ExecuteNonQuery()

            'Grabar la bitacora'
            Dim tabla, evento, usuario, identificacion As String
            Dim tipo As Integer
            tabla = "ESTADO_CIVIL"
            evento = "ACTUALIZACION"
            usuario = "1"
            identificacion = "123456789"
            tipo = 1
            Dim cmdBitacora As New SqlCommand("
    INSERT INTO BITACORA_EVENTO(TABLA, EVENTO_CRUD, FECHA_HORA, CODIGO_USUARIO, TIPO_ID, IDENTIFICACION)
    VALUES(@TABLA,@EVENTO_CRUD,@FECHA_HORA,@CODIGO_USUARIO,@TIPO_ID,@IDENTIFICACION)", cn, transaccion)

            cmdBitacora.Parameters.AddWithValue("@TABLA", tabla)
            cmdBitacora.Parameters.AddWithValue("@EVENTO_CRUD", evento)
            cmdBitacora.Parameters.AddWithValue("@FECHA_HORA", DateTime.Now)
            cmdBitacora.Parameters.AddWithValue("@CODIGO_USUARIO", usuario)
            cmdBitacora.Parameters.AddWithValue("@TIPO_ID", tipo)
            cmdBitacora.Parameters.AddWithValue("@IDENTIFICACION", identificacion)

            cmdBitacora.ExecuteNonQuery()

            transaccion.Commit()
            MessageBox.Show("Datos Guardados exitosamente")

        Catch ex As Exception
            If transaccion IsNot Nothing Then
                transaccion.Rollback()
                MessageBox.Show("Error  :" + ex.ToString)
            End If
        Finally
            If cn IsNot Nothing AndAlso cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub Estado_Civil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PROYECTO_DB_PARTIDOS_POLITICOSDataSet1.ESTADO_CIVIL' Puede moverla o quitarla según sea necesario.
        Me.ESTADO_CIVILTableAdapter.Fill(Me.PROYECTO_DB_PARTIDOS_POLITICOSDataSet1.ESTADO_CIVIL)
        MsgBox("Bienvenido al sistema")
    End Sub

    Private Sub Boteliminar_Click(sender As Object, e As EventArgs) Handles Boteliminar.Click
        If k = 0 Then
            MsgBox("Debe Presionar, el boton de Consultar antes de Modificar")
            Return
        End If


        If TxtEstadoCivilId.Text = "" Or TxtEstadoCivilDescripcion.Text = "" Then
            MsgBox("Datos obligatorios, favor digitar solo numeros")
            TxtEstadoCivilId.Focus()
            Return
        End If

        Dim cn As SqlConnection = Nothing
        Dim transaccion As SqlTransaction = Nothing
        Try
            If MessageBox.Show("¿Está seguro de eliminar el registro en la base de datos?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                cn = conexionManager.Obtener_Conexion()
                transaccion = cn.BeginTransaction()
                Dim cmdtipoidm As New SqlCommand("DELETE FROM ESTADO_CIVIL WHERE CODIGO_ID=@CODIGO_ID", cn, transaccion)
                cmdtipoidm.Parameters.AddWithValue("@CODIGO_ID", TxtEstadoCivilId.Text)
                cmdtipoidm.ExecuteNonQuery()

                'Grabar la bitacora'
                Dim tabla, evento, usuario, identificacion As String
                Dim tipo As Integer
                tabla = "ESTADO_CIVIL"
                evento = "ELIMINAR"
                usuario = "1"
                identificacion = "123456789"
                tipo = 1
                Dim cmdBitacora As New SqlCommand("
    INSERT INTO BITACORA_EVENTO(TABLA, EVENTO_CRUD, FECHA_HORA, CODIGO_USUARIO, TIPO_ID, IDENTIFICACION)
    VALUES(@TABLA,@EVENTO_CRUD,@FECHA_HORA,@CODIGO_USUARIO,@TIPO_ID,@IDENTIFICACION)", cn, transaccion)

                cmdBitacora.Parameters.AddWithValue("@TABLA", tabla)
                cmdBitacora.Parameters.AddWithValue("@EVENTO_CRUD", evento)
                cmdBitacora.Parameters.AddWithValue("@FECHA_HORA", DateTime.Now)
                cmdBitacora.Parameters.AddWithValue("@CODIGO_USUARIO", usuario)
                cmdBitacora.Parameters.AddWithValue("@TIPO_ID", tipo)
                cmdBitacora.Parameters.AddWithValue("@IDENTIFICACION", identificacion)

                cmdBitacora.ExecuteNonQuery()

                transaccion.Commit()
                MessageBox.Show("Datos eliminaados exitosamente")



            End If
        Catch ex As Exception
            If transaccion IsNot Nothing Then
                transaccion.Rollback()
                MessageBox.Show("Error  :" + ex.ToString)
            End If
        Finally
            If cn IsNot Nothing AndAlso cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
        Me.ESTADO_CIVILTableAdapter.Fill(Me.PROYECTO_DB_PARTIDOS_POLITICOSDataSet1.ESTADO_CIVIL)
    End Sub
End Class