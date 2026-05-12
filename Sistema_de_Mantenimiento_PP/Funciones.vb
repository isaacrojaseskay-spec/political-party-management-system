Module Funciones
    Public f, k As Integer
    Public Sub set_solo_letras(ByRef ee As System.Windows.Forms.KeyPressEventArgs)
        Dim cadena As String
        cadena = "ABCDEFGHIJKMNÑOPQRSTUVWXYZ "
        If Not InStr(cadena, ee.KeyChar) Then
            ee.Handled = False
        ElseIf Char.IsControl(ee.KeyChar) Then
            ee.Handled = False
        Else
            ee.Handled = True
        End If
    End Sub

    Public Sub set_solo_numeros(ByRef ee As System.Windows.Forms.KeyPressEventArgs)
        Dim cadena As String
        cadena = "0123456789"
        If InStr(cadena, ee.KeyChar) Then
            ee.Handled = False
        ElseIf Char.IsControl(ee.KeyChar) Then
            ee.Handled = False
        Else
            ee.Handled = True
            f = 1
        End If
    End Sub



End Module
