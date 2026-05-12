Imports System.Data.SqlClient
Imports System.IO
Imports System.Security.Cryptography
Imports System.Security.Cryptography.X509Certificates
Imports System.Text
Public Class Conexion
    Private ReadOnly cadenaConexion As String =
        "Server= DESKTOP-GC2FLGC\SQLEXPRESS; Database=PROYECTO_DB_PARTIDOS_POLITICOS;Trusted_connection=True;"
    Public ds As DataSet = New DataSet()
    Public da As SqlDataAdapter
    Public comando As SqlCommand
    Public builder As SqlCommandBuilder
    Dim contprovincia As Integer = 1
    Dim contcanton As Integer = 1
    Dim contdistrito As Integer = 1
    Dim idprovincia As String
    Dim idcanton As String
    Dim iddistrito As String
    Public Function Obtener_Conexion() As SqlConnection
        Dim cn As New SqlConnection(cadenaConexion)
        cn.Open()
        Return cn
    End Function

    Public Function busca_codigo(ByVal vtipoid As String) As DataTable
        Dim dt As New DataTable()
        Dim sql As String = "SELECT * FROM TIPO_IDENTIFICACION WHERE CODIGO_ID=" & vtipoid
        Using cn As New SqlConnection(cadenaConexion)
            Dim daLocal As New SqlDataAdapter(sql, cn)
            daLocal.Fill(dt)
        End Using
        f = If(dt.Rows.Count > 0, 0, 1)
        Return dt
    End Function

    Public Function busca_codigo_dos(ByVal vtipoid As String) As DataTable
        Dim dt As New DataTable()
        Dim sql As String = "SELECT * FROM ESTADO_CIVIL WHERE CODIGO_ID=" & vtipoid
        Using cn As New SqlConnection(cadenaConexion)
            cn.Open()
            Dim daLocal As New SqlDataAdapter(sql, cn)
            daLocal.Fill(dt)
        End Using
        If dt.Rows.Count > 0 Then
            f = 0
        Else
            f = 1
        End If
        Return dt
    End Function

    Public Function busca_codigo_tres(ByVal vtipoid As String) As DataTable
        Dim dt As New DataTable()
        Dim sql As String = "SELECT * FROM PROFESION WHERE CODIGO_ID=" & vtipoid
        Using cn As New SqlConnection(cadenaConexion)
            Dim daLocal As New SqlDataAdapter(sql, cn)
            daLocal.Fill(dt)
        End Using
        f = If(dt.Rows.Count > 0, 0, 1)
        Return dt
    End Function

    Public Function busca_codigo_cuatro(ByVal vtipoid As String) As DataTable
        Dim dt As New DataTable()
        Dim sql As String = "SELECT * FROM PROVEEDOR_MOVIL WHERE CODIGO_ID=" & vtipoid
        Using cn As New SqlConnection(cadenaConexion)
            cn.Open()
            Dim daLocal As New SqlDataAdapter(sql, cn)
            daLocal.Fill(dt)
        End Using

        If dt.Rows.Count > 0 Then
            f = 0
        Else
            f = 1
        End If

        Return dt
    End Function

    Public Function busca_codigo_quinto(ByVal vtipoid As String) As DataTable
        Dim dt As New DataTable()
        Dim sql As String = "SELECT * FROM PERFIL WHERE CODIGO_ID=" & vtipoid
        Using cn As New SqlConnection(cadenaConexion)
            cn.Open()
            Dim daLocal As New SqlDataAdapter(sql, cn)
            daLocal.Fill(dt)
        End Using

        If dt.Rows.Count > 0 Then
            f = 0
        Else
            f = 1
        End If

        Return dt
    End Function

    Public Function buscar_padron(ByVal vcedula As String) As DataTable
        Dim dt = New DataTable()
        consultar("SELECT * FROM PADRON_ELECTORAL WHERE CEDULA='" + vcedula + "'", "PADRON")
        If ds.Tables("PADRON").Rows.Count > 0 Then
            f = 0
        Else
            f = 1
        End If
        da.Fill(dt)
        Return dt
    End Function

    Public Function buscar_colaborador(ByVal vcedula As String) As DataTable
        Dim dt = New DataTable()
        consultar("SELECT * FROM COLABORADOR WHERE IDENTIFICACION='" + vcedula + "'", "COLABORADOR")
        If ds.Tables("COLABORADOR").Rows.Count > 0 Then
            f = 0
        Else
            f = 1
        End If
        da.Fill(dt)
        Return dt
    End Function


    Public Sub consultar(ByVal sql As String, ByVal tabla As String)
        ds.Tables.Clear()
        da = New SqlDataAdapter(sql, cadenaConexion)
        builder = New SqlCommandBuilder(da)
        da.Fill(ds, tabla)
    End Sub

    Public Sub cargarArchivo(ByVal ruta As String)
        Using myreader As New FileIO.TextFieldParser(ruta)
            myreader.SetDelimiters(",")
            Dim currenRow As String()
            While Not myreader.EndOfData
                Try
                    currenRow = myreader.ReadFields()
                    insertarDatos(currenRow(0), currenRow(1), currenRow(2), currenRow(3))
                    '101001, SAN JOSE, CENTRAL, HOSPITAL'
                Catch ex As Exception
                    MessageBox.Show("Error:" + ex.ToString)
                End Try
            End While
            MessageBox.Show("Archivo se cargo sactisfactoriamente")
        End Using
    End Sub

    Public Sub insertarDatos(ByVal id As String, ByVal provincia As String, ByVal canton As String, ByVal distrito As String)
        Dim a, b, c As Integer
        '101001
        a = Mid(id, 1, 1)
        'a=1
        b = Mid(id, 2, 2)
        ' b = 01
        c = Mid(id, 4, 3)
        'c = 001
        contprovincia = a
        ' Consultar("SELECT * FROM PROVINCIA WHERE CODIGO_PROV= & contprovincia & , "PROVINCIA")
        consultar("SELECT * FROM PROVINCIA WHERE DESCRIPCION_PROVINCIA='" + provincia + "'", "PROVINCIA")
        If ds.Tables("PROVINCIA").Rows.Count = 0 Then
            insertar("INSERT INTO PROVINCIA VALUES(" + contprovincia.ToString() + ",'" + provincia + "')")
            idprovincia = a
        Else
            idprovincia = ds.Tables("PROVINCIA").Rows(0).Item(0).ToString
        End If
        'consultar canton
        consultar("SELECT * FROM CANTON WHERE CODIGO_PROVINCIA= " + idprovincia.ToString() + "and DESCRIPCION_CANTON= '" + canton + "'", "CANTON")
        If ds.Tables("CANTON").Rows.Count = 0 Then
            contcanton = b
            'Insertar("INSERT INTO CANTON VALUES(" + contcanton.ToString() + ",'" + idprovincia + "','" + CANTON + "')")
            insertar("INSERT INTO CANTON VALUES(" + idprovincia + ",'" + contcanton.ToString() + "','" + canton + "')")

            idcanton = b
        Else
            idcanton = ds.Tables("CANTON").Rows(0).Item(1).ToString()
        End If

        'consultar distrito
        consultar("SELECT * FROM DISTRITO WHERE CODIGO_PROVINCIA=" + idprovincia.ToString + "and CODIGO_CANTON=" + idcanton.ToString + " and DESCRIPCION_DISTRITO='" + distrito + "'", "DISTRITO")
        If ds.Tables("DISTRITO").Rows.Count = 0 Then
            contdistrito = c
            'Insertar("INSERT INTO DISTRITO VALUES(" + contdistrito.ToString() + "," + idcanton + "'," + idprovincia + "," + distrito + "'" + ")")
            insertar("INSERT INTO DISTRITO VALUES(" + idprovincia + "," + contcanton.ToString() + ",'" + contdistrito.ToString() + "','" + distrito + "')")
            iddistrito = c
        Else
            iddistrito = ds.Tables("DISTRITO").Rows(0).Item(2).ToString()
        End If

    End Sub


    Public Sub insertar(ByVal sql As String)
        Dim cn As New SqlConnection(cadenaConexion)
        cn.Open()
        comando = New SqlCommand(sql, cn)
        comando.ExecuteNonQuery()
        cn.Close()
    End Sub
    'Encriptar contraseña con sha256
    Public Function Encriptarcontraseña(contraseña As String) As String
        Dim sha256 As SHA256 = SHA256Managed.Create()
        Dim bytes As Byte() = Encoding.UTF8.GetBytes(contraseña)
        Dim hash As Byte() = sha256.ComputeHash(bytes)
        Dim stringBuilder As New StringBuilder()
        For i As Integer = 0 To hash.Length - 1
            stringBuilder.Append(hash(i).ToString("X2"))
        Next
        Return stringBuilder.ToString()
    End Function
    'En realidad no se puede desencriptar una contraseña encriptada con sha256, lo que se hace es comparar la contraseña encriptada con la contraseña encriptada que se tiene almacenada en la base de datos, si son iguales entonces la contraseña es correcta, si no son iguales entonces la contraseña es incorrecta, por eso el metodo de desencriptar contraseña no se utiliza, pero lo dejo aqui para que se vea como seria el metodo de desencriptar contraseña
    Public Function DesencriptarContraseña(contraseñaEncriptada As String) As String
        Dim sha256 As SHA256 = SHA256Managed.Create()
        Dim hashBytes As Byte() = Encoding.UTF8.GetBytes(contraseñaEncriptada)
        Dim descryptedBytes As Byte() = sha256.ComputeHash(hashBytes)
        Dim descryptedbuilder As New StringBuilder()
        For i As Integer = 0 To descryptedBytes.Length - 1
            descryptedbuilder.Append(descryptedBytes(i).ToString("X2"))
        Next
        Return descryptedbuilder.ToString()
    End Function
    'Esto se hace para todos los combobox obvio se le cambia los nombres de las tablas y los campos
    Public Function cargar_estadocivil() As DataTable
        Dim Dt = New DataTable()
        consultar("SELECT CODIGO_ID, DESCRIPCION FROM ESTADO_CIVIL", "ESTADO_CIVIL")
        da.Fill(Dt)
        Return Dt
    End Function

    Public Function cargar_tipoid() As DataTable
        Dim Dt = New DataTable()
        consultar("SELECT CODIGO_ID, DESCRIPCION FROM TIPO_IDENTIFICACION", "TIPO_IDENTIFICACION")
        da.Fill(Dt)
        Return Dt
    End Function


    Public Function cargar_provincia() As DataTable
        Dim Dt = New DataTable()
        consultar("SELECT CODIGO_PROVINCIA, DESCRIPCION_PROVINCIA FROM PROVINCIA", "PROVINCIA")
        da.Fill(Dt)
        Return Dt
    End Function

    Public Function cargar_canton(ByVal idprovincia As String) As DataTable
        Dim Dt = New DataTable()
        consultar("SELECT CODIGO_CANTON, DESCRIPCION_CANTON FROM CANTON WHERE CODIGO_PROVINCIA=" + idprovincia, "CANTON")
        da.Fill(Dt)
        Return Dt
    End Function

    Public Function cargar_distrito(ByVal idprovincia As String) As DataTable
        Dim Dt = New DataTable()
        consultar("SELECT CODIGO_DISTRITO, DESCRIPCION_DISTRITO FROM DISTRITO WHERE CODIGO_PROVINCIA=" + idprovincia, "DISTRITO")
        da.Fill(Dt)
        Return Dt
    End Function

    Public Function cargar_profesion() As DataTable
        Dim Dt = New DataTable()
        consultar("SELECT CODIGO_ID, DESCRIPCION FROM PROFESION", "PROFESION")
        da.Fill(Dt)
        Return Dt
    End Function

    Public Function cargar_proveedor_movil() As DataTable
        Dim Dt = New DataTable()
        consultar("SELECT CODIGO_ID, DESCRIPCION FROM PROVEEDOR_MOVIL", "PROVEEDOR_MOVIL")
        da.Fill(Dt)
        Return Dt
    End Function

    Public Function Consulta_usuario(ByVal idusuario As String) As DataTable
        Dim dt = New DataTable()
        consultar("SELECT USUARIO,CLAVE FROM USUARIO_CLAVE WHERE USUARIO = '" + idusuario + "'", "USUARIO")
        If ds.Tables("USUARIO").Rows.Count > 0 Then
            f = 0
        Else
            f = 1
        End If
        da.Fill(dt)
        Return dt
    End Function

End Class
