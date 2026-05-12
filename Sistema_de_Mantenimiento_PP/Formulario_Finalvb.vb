
Imports System.Data.SqlClient

Public Class Formulario_Finalvb
    Private conexionManager As New Conexion()
    Dim conexion As Conexion = New Conexion
    Private Sub Formulario_Finalvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carga_estadocivil()
        carga_profesion()
        carga_provincia()
        carga_tipoid()
        carga_proveedor_movil()
    End Sub

    Private Sub carga_tipoid()
        conexion.Obtener_Conexion()
        Dim dt = conexion.cargar_tipoid()
        Cmb_Tipo_Identificacion.DataSource = dt
        Cmb_Tipo_Identificacion.DisplayMember = "DESCRIPCION"
        Cmb_Tipo_Identificacion.ValueMember = "CODIGO_ID"
        Cmb_Tipo_Identificacion.SelectedIndex = -1
    End Sub

    Private Sub carga_estadocivil()
        conexion.Obtener_Conexion()
        Dim dt = conexion.cargar_estadocivil()
        Cmb_estado_civil.DataSource = dt
        Cmb_estado_civil.DisplayMember = "DESCRIPCION"
        Cmb_estado_civil.ValueMember = "CODIGO_ID"
        Cmb_estado_civil.SelectedIndex = -1
    End Sub
    'Metodo para cargar el combo de provincia
    Private Sub carga_provincia()
        conexion.Obtener_Conexion()
        Dim dt = conexion.cargar_provincia()
        Cmbprovincia.DataSource = dt
        Cmbprovincia.DisplayMember = "DESCRIPCION_PROVINCIA"
        Cmbprovincia.ValueMember = "CODIGO_PROVINCIA"
        Cmbprovincia.SelectedIndex = -1
    End Sub
    'Metodo para cargar el combo de canton y distrito dependiendo de la provincia
    Private Sub Cmbprovincia_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Cmbprovincia.SelectionChangeCommitted
        Dim dt = conexion.cargar_canton(Cmbprovincia.SelectedValue.ToString())
        Cmbcanton.DataSource = dt
        Cmbcanton.DisplayMember = "DESCRIPCION_CANTON"
        Cmbcanton.ValueMember = "CODIGO_CANTON"
        Cmbdistrito.DataSource = Nothing
        Cmbcanton.SelectedIndex = 0

        Dim dt2 = conexion.cargar_distrito(Cmbprovincia.SelectedValue.ToString())
        Cmbdistrito.DataSource = dt2
        Cmbdistrito.DisplayMember = "DESCRIPCION_DISTRITO"
        Cmbdistrito.ValueMember = "CODIGO_DISTRITO"
        Cmbdistrito.SelectedIndex = -1
    End Sub
    'Metodo para cargar el combo de la profesion
    Private Sub carga_profesion()
        conexion.Obtener_Conexion()
        Dim dt = conexion.cargar_profesion()
        Cmbprofesion.DataSource = dt
        Cmbprofesion.DisplayMember = "DESCRIPCION"
        Cmbprofesion.ValueMember = "CODIGO_ID"
        Cmbprofesion.SelectedIndex = -1
    End Sub
    'Metodo para cargar el combo de proveedor de movil
    Private Sub carga_proveedor_movil()
        conexion.Obtener_Conexion()
        Dim dt = conexion.cargar_proveedor_movil()
        Cmbproveedor_movil.DataSource = dt
        Cmbproveedor_movil.DisplayMember = "DESCRIPCION"
        Cmbproveedor_movil.ValueMember = "CODIGO_ID"
        Cmbproveedor_movil.SelectedIndex = -1
    End Sub
    'Metodo para consultar el padron electoral
    Private Sub Btn_Consultar_Padron_Click(sender As Object, e As EventArgs) Handles Btn_Consultar_Padron.Click
        Dim videntificacion, valorsinformato As String
        valorsinformato = ""
        videntificacion = Txt_NumeroId.Text
        valorsinformato = videntificacion.Replace("-", "")
        MsgBox(valorsinformato)
        Dim dt = conexion.buscar_padron(valorsinformato)
        If f = 0 Then
            Txt_Nombre.Text = dt.Rows(0)!nombre
            Txt_Primer_Apellido.Text = dt.Rows(0)!primer_apellido
            Txt_Segundo_Apellido.Text = dt.Rows(0)!segundo_apellido
            Txt_Nombre.Enabled = False
            Txt_Primer_Apellido.Enabled = False
            Txt_Segundo_Apellido.Enabled = False
        Else
            MsgBox("Identificacion No existe en el Padron Electoral")
        End If
    End Sub
    'Metodo para incluir un nuevo colaborador, se hace uso de transacciones para asegurar la integridad de los datos
    Private Sub Btn_Incluir_Click(sender As Object, e As EventArgs) Handles Btn_Incluir.Click
        Dim cn As SqlConnection = Nothing
        Dim transaccion As SqlTransaction = Nothing

        Try
            cn = conexionManager.Obtener_Conexion()
            If cn.State <> ConnectionState.Open Then cn.Open()

            transaccion = cn.BeginTransaction()
            'Primero se inserta el registro en la tabla principal COLABORADOR
            Dim sqlColaborador As String = "
            INSERT INTO COLABORADOR (TIPO_ID, IDENTIFICACION, NOMBRE, PRIMER_APELLIDO, SEGUNDO_APELLIDO, FECHA_NACIMIENTO, FECHA_AFILIACION)
            VALUES (@TIPO_ID, @IDENTIFICACION, @NOMBRE, @PRIMER_APELLIDO, @SEGUNDO_APELLIDO, @FECHA_NACIMIENTO, @FECHA_AFILIACION)"

            Dim cmdColaborador As New SqlCommand(sqlColaborador, cn, transaccion)
            'Se agregan los parametros necesarios para la insercion
            cmdColaborador.Parameters.AddWithValue("@TIPO_ID", Cmb_Tipo_Identificacion.SelectedValue)
            cmdColaborador.Parameters.AddWithValue("@IDENTIFICACION", Txt_NumeroId.Text.Replace("-", "").Trim())
            cmdColaborador.Parameters.AddWithValue("@NOMBRE", Txt_Nombre.Text)
            cmdColaborador.Parameters.AddWithValue("@PRIMER_APELLIDO", Txt_Primer_Apellido.Text)
            cmdColaborador.Parameters.AddWithValue("@SEGUNDO_APELLIDO", Txt_Segundo_Apellido.Text)
            cmdColaborador.Parameters.AddWithValue("@FECHA_NACIMIENTO", Dtp_Fecha_Nacimiento.Value)
            cmdColaborador.Parameters.AddWithValue("@FECHA_AFILIACION", Dtp_Fecha_Afiliacion.Value)

            cmdColaborador.ExecuteNonQuery()
            'Se inserta el registro en la tabla de detalles DATOS_COLABORADOR
            Dim sqlDetalle As String = "
            INSERT INTO DATOS_COLABORADOR (TIPO_ID, IDENTIFICACION, PROFESION, MOVIL, CORREO_ELECTRONICO, ESTADO_CIVIL, PROVINCIA, CANTON, DISTRITO)
            VALUES (@TIPO_ID, @IDENTIFICACION, @PROFESION, @MOVIL, @CORREO_ELECTRONICO, @ESTADO_CIVIL, @PROVINCIA, @CANTON, @DISTRITO)"

            Dim cmdDetalle As New SqlCommand(sqlDetalle, cn, transaccion)
            cmdDetalle.Parameters.AddWithValue("@TIPO_ID", Cmb_Tipo_Identificacion.SelectedValue)
            cmdDetalle.Parameters.AddWithValue("@IDENTIFICACION", Txt_NumeroId.Text.Replace("-", "").Trim())
            cmdDetalle.Parameters.AddWithValue("@PROFESION", Cmbprofesion.SelectedValue)
            cmdDetalle.Parameters.AddWithValue("@MOVIL", Cmbproveedor_movil.SelectedValue)
            cmdDetalle.Parameters.AddWithValue("@CORREO_ELECTRONICO", Txt_Correo_Electronico.Text)
            cmdDetalle.Parameters.AddWithValue("@ESTADO_CIVIL", Cmb_estado_civil.SelectedValue)
            cmdDetalle.Parameters.AddWithValue("@PROVINCIA", Cmbprovincia.SelectedValue)
            cmdDetalle.Parameters.AddWithValue("@CANTON", Cmbcanton.SelectedValue)
            cmdDetalle.Parameters.AddWithValue("@DISTRITO", Cmbdistrito.SelectedValue)

            cmdDetalle.ExecuteNonQuery()

            transaccion.Commit()
            MessageBox.Show("Datos Guardados Exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Btn_Limpiar.PerformClick()

        Catch ex As Exception
            If transaccion IsNot Nothing Then transaccion.Rollback()
            MessageBox.Show("Error al guardar: " & ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If cn IsNot Nothing AndAlso cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    'Metodo para consultar un colaborador por su numero de identificacion
    Private Sub Btn_Consultar_Click(sender As Object, e As EventArgs) Handles Btn_Consultar.Click
        If Txt_NumeroId.MaskFull Then
            'Se limpia el numero de identificacion de guiones y espacios para realizar la consulta
            Dim cedulaLimpia As String = Txt_NumeroId.Text.Replace("-", "").Trim()
            Dim dt As DataTable = conexion.buscar_colaborador(cedulaLimpia)
            If dt.Rows.Count > 0 Then
                'Si se encuentra, se cargan los datos en los campos correspondientes
                Txt_Nombre.Text = dt.Rows(0)("NOMBRE").ToString()
                Txt_Primer_Apellido.Text = dt.Rows(0)("PRIMER_APELLIDO").ToString()
                Txt_Segundo_Apellido.Text = dt.Rows(0)("SEGUNDO_APELLIDO").ToString()


                Txt_Nombre.ReadOnly = True
                Txt_Primer_Apellido.ReadOnly = True
                Txt_Segundo_Apellido.ReadOnly = True
            Else
                MessageBox.Show("La identificación no se encuentra en la base de datos.", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Txt_Nombre.Clear()
                Txt_Nombre.ReadOnly = False

            End If

        Else
            MessageBox.Show("Por favor, complete el número de identificación correctamente.", "Formato incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Btn_Eliminar_Click(sender As Object, e As EventArgs) Handles Btn_Eliminar.Click
        If String.IsNullOrWhiteSpace(Txt_Nombre.Text) Then
            MessageBox.Show("Debe presionar el botón Consultar y cargar un registro antes de eliminar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim respuesta As DialogResult = MessageBox.Show("¿Está seguro de que desea eliminar permanentemente a este colaborador y todos sus detalles?",
                                                    "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If respuesta = DialogResult.Yes Then
            Dim cn As SqlConnection = Nothing
            Dim transaccion As SqlTransaction = Nothing

            Try
                cn = conexionManager.Obtener_Conexion()
                If cn.State <> ConnectionState.Open Then cn.Open()

                transaccion = cn.BeginTransaction()

                Dim sqlDetalle As String = "DELETE FROM DATOS_COLABORADOR WHERE IDENTIFICACION = @IDENTIFICACION"
                Dim cmdDetalle As New SqlCommand(sqlDetalle, cn, transaccion)
                cmdDetalle.Parameters.AddWithValue("@IDENTIFICACION", Txt_NumeroId.Text.Replace("-", "").Trim())
                cmdDetalle.ExecuteNonQuery()

                Dim sqlPadre As String = "DELETE FROM COLABORADOR WHERE IDENTIFICACION = @IDENTIFICACION"
                Dim cmdPadre As New SqlCommand(sqlPadre, cn, transaccion)
                cmdPadre.Parameters.AddWithValue("@IDENTIFICACION", Txt_NumeroId.Text.Replace("-", "").Trim())

                Dim filasAfectadas As Integer = cmdPadre.ExecuteNonQuery()

                If filasAfectadas > 0 Then
                    transaccion.Commit()
                    MessageBox.Show("Registro eliminado de ambas tablas correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Btn_Limpiar.PerformClick()
                Else
                    MessageBox.Show("No se encontró el registro principal para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    transaccion.Rollback()
                End If

            Catch ex As Exception
                If transaccion IsNot Nothing Then transaccion.Rollback()
                MessageBox.Show("Error al eliminar los datos: " & ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If cn IsNot Nothing AndAlso cn.State = ConnectionState.Open Then cn.Close()
            End Try
        End If
    End Sub

    Private Sub Btn_Limpiar_Click(sender As Object, e As EventArgs) Handles Btn_Limpiar.Click
        Txt_Nombre.Clear()
        Txt_Primer_Apellido.Clear()
        Txt_Segundo_Apellido.Clear()
        Txt_Correo_Electronico.Clear()
        Txt_Direccion_Exacta.Clear()
        Txt_NumeroId.Clear()
    End Sub

    Private Sub Cmb_Tipo_Identificacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_Tipo_Identificacion.SelectedIndexChanged
        Txt_NumeroId.Clear()
        Txt_NumeroId.TextMaskFormat = MaskFormat.IncludeLiterals

        Select Case Cmb_Tipo_Identificacion.Text.ToUpper()
            Case "NACIONAL"
                Txt_NumeroId.Mask = "0-0000-0000"
            Case "DIME", "DIMEX"
                Txt_NumeroId.Mask = "000000000000"
            Case "PASAPORTE"
                Txt_NumeroId.Mask = "AAAAAAAAAAAAAAAAAAAA"
        End Select
    End Sub

    Private Sub Btn_Modificar_Click(sender As Object, e As EventArgs) Handles Btn_Modificar.Click
        If String.IsNullOrWhiteSpace(Txt_NumeroId.Text) Then
            MessageBox.Show("Por favor, cargue un registro antes de intentar modificar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim cn As SqlConnection = Nothing
        Dim transaccion As SqlTransaction = Nothing

        Try
            cn = conexionManager.Obtener_Conexion()
            If cn.State <> ConnectionState.Open Then cn.Open()
            transaccion = cn.BeginTransaction()

            Dim sqlColaborador As String = "UPDATE COLABORADOR SET NOMBRE = @NOMBRE WHERE IDENTIFICACION = @IDENTIFICACION"

            Using cmd1 As New SqlCommand(sqlColaborador, cn, transaccion)
                cmd1.Parameters.AddWithValue("@NOMBRE", Txt_Nombre.Text)
                cmd1.Parameters.AddWithValue("@IDENTIFICACION", Txt_NumeroId.Text.Replace("-", "").Trim())
                cmd1.ExecuteNonQuery()
            End Using
            'Luego se actualizan los datos en la tabla de detalles
            Dim sqlDetalle As String = "
        UPDATE DATOS_COLABORADOR 
        SET ESTADO_CIVIL = @ESTADO_CIVIL,
            PROVINCIA = @PROVINCIA, 
            CANTON = @CANTON, 
            DISTRITO = @DISTRITO,
            PROFESION = @PROFESION, 
            CORREO_ELECTRONICO = @CORREO_ELECTRONICO,
            MOVIL = @MOVIL
        WHERE IDENTIFICACION = @IDENTIFICACION"
            'Se agregan los parametros necesarios para la actualizacion
            Using cmd2 As New SqlCommand(sqlDetalle, cn, transaccion)
                cmd2.Parameters.AddWithValue("@ESTADO_CIVIL", Cmb_estado_civil.SelectedValue)
                cmd2.Parameters.AddWithValue("@PROFESION", Cmbprofesion.SelectedValue)
                cmd2.Parameters.AddWithValue("@PROVINCIA", Cmbprovincia.SelectedValue)
                cmd2.Parameters.AddWithValue("@CANTON", Cmbcanton.SelectedValue)
                cmd2.Parameters.AddWithValue("@DISTRITO", Cmbdistrito.SelectedValue)
                cmd2.Parameters.AddWithValue("@CORREO_ELECTRONICO", Txt_Correo_Electronico.Text)
                cmd2.Parameters.AddWithValue("@MOVIL", Cmbproveedor_movil.SelectedValue)
                cmd2.Parameters.AddWithValue("@IDENTIFICACION", Txt_NumeroId.Text.Replace("-", "").Trim())
                cmd2.ExecuteNonQuery()
            End Using

            transaccion.Commit()
            MessageBox.Show("Datos actualizados correctamente en la tabla de detalles.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            If transaccion IsNot Nothing Then transaccion.Rollback()
            MessageBox.Show("Error al modificar: " & ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If cn IsNot Nothing AndAlso cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub
End Class