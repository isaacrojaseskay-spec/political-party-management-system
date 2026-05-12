<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formulario_Finalvb
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Cmb_estado_civil = New System.Windows.Forms.ComboBox()
        Me.Lbl_Tipoid = New System.Windows.Forms.Label()
        Me.Cmb_Tipo_Identificacion = New System.Windows.Forms.ComboBox()
        Me.Lbl_NumeroId = New System.Windows.Forms.Label()
        Me.Lbl_Nombre = New System.Windows.Forms.Label()
        Me.Txt_Nombre = New System.Windows.Forms.TextBox()
        Me.Lbl_Primer_Apellido = New System.Windows.Forms.Label()
        Me.Txt_Primer_Apellido = New System.Windows.Forms.TextBox()
        Me.Lbl_Segundo_Apellido = New System.Windows.Forms.Label()
        Me.Txt_Segundo_Apellido = New System.Windows.Forms.TextBox()
        Me.Lbl_Estado_Civil = New System.Windows.Forms.Label()
        Me.Lbl_Fecha_Nacimiento = New System.Windows.Forms.Label()
        Me.Dtp_Fecha_Nacimiento = New System.Windows.Forms.DateTimePicker()
        Me.Lbl_Fecha_Afilicacion = New System.Windows.Forms.Label()
        Me.Dtp_Fecha_Afiliacion = New System.Windows.Forms.DateTimePicker()
        Me.Lbl_Provincia = New System.Windows.Forms.Label()
        Me.Cmbprovincia = New System.Windows.Forms.ComboBox()
        Me.Lbl_Canton = New System.Windows.Forms.Label()
        Me.Cmbcanton = New System.Windows.Forms.ComboBox()
        Me.Lbl_Distrito = New System.Windows.Forms.Label()
        Me.Cmbdistrito = New System.Windows.Forms.ComboBox()
        Me.Lbl_Profesion = New System.Windows.Forms.Label()
        Me.Cmbprofesion = New System.Windows.Forms.ComboBox()
        Me.Lbl_Proveedor_Movil = New System.Windows.Forms.Label()
        Me.Cmbproveedor_movil = New System.Windows.Forms.ComboBox()
        Me.Lbl_Correo_Electronico = New System.Windows.Forms.Label()
        Me.Txt_Correo_Electronico = New System.Windows.Forms.TextBox()
        Me.Lbl_Direccion_Exacta = New System.Windows.Forms.Label()
        Me.Txt_Direccion_Exacta = New System.Windows.Forms.TextBox()
        Me.Btn_Incluir = New System.Windows.Forms.Button()
        Me.Btn_Modificar = New System.Windows.Forms.Button()
        Me.Btn_Consultar = New System.Windows.Forms.Button()
        Me.Btn_Consultar_Padron = New System.Windows.Forms.Button()
        Me.Btn_Eliminar = New System.Windows.Forms.Button()
        Me.Btn_Limpiar = New System.Windows.Forms.Button()
        Me.Txt_NumeroId = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'Cmb_estado_civil
        '
        Me.Cmb_estado_civil.FormattingEnabled = True
        Me.Cmb_estado_civil.Location = New System.Drawing.Point(54, 219)
        Me.Cmb_estado_civil.Name = "Cmb_estado_civil"
        Me.Cmb_estado_civil.Size = New System.Drawing.Size(129, 24)
        Me.Cmb_estado_civil.TabIndex = 1
        '
        'Lbl_Tipoid
        '
        Me.Lbl_Tipoid.AutoSize = True
        Me.Lbl_Tipoid.Location = New System.Drawing.Point(51, 33)
        Me.Lbl_Tipoid.Name = "Lbl_Tipoid"
        Me.Lbl_Tipoid.Size = New System.Drawing.Size(116, 16)
        Me.Lbl_Tipoid.TabIndex = 2
        Me.Lbl_Tipoid.Text = "Tipo Identificacion"
        '
        'Cmb_Tipo_Identificacion
        '
        Me.Cmb_Tipo_Identificacion.FormattingEnabled = True
        Me.Cmb_Tipo_Identificacion.Location = New System.Drawing.Point(54, 62)
        Me.Cmb_Tipo_Identificacion.Name = "Cmb_Tipo_Identificacion"
        Me.Cmb_Tipo_Identificacion.Size = New System.Drawing.Size(121, 24)
        Me.Cmb_Tipo_Identificacion.TabIndex = 3
        '
        'Lbl_NumeroId
        '
        Me.Lbl_NumeroId.AutoSize = True
        Me.Lbl_NumeroId.Location = New System.Drawing.Point(226, 33)
        Me.Lbl_NumeroId.Name = "Lbl_NumeroId"
        Me.Lbl_NumeroId.Size = New System.Drawing.Size(136, 16)
        Me.Lbl_NumeroId.TabIndex = 4
        Me.Lbl_NumeroId.Text = "Numero Identificacion"
        '
        'Lbl_Nombre
        '
        Me.Lbl_Nombre.AutoSize = True
        Me.Lbl_Nombre.Location = New System.Drawing.Point(478, 33)
        Me.Lbl_Nombre.Name = "Lbl_Nombre"
        Me.Lbl_Nombre.Size = New System.Drawing.Size(56, 16)
        Me.Lbl_Nombre.TabIndex = 6
        Me.Lbl_Nombre.Text = "Nombre"
        '
        'Txt_Nombre
        '
        Me.Txt_Nombre.Location = New System.Drawing.Point(481, 62)
        Me.Txt_Nombre.Name = "Txt_Nombre"
        Me.Txt_Nombre.Size = New System.Drawing.Size(201, 22)
        Me.Txt_Nombre.TabIndex = 7
        '
        'Lbl_Primer_Apellido
        '
        Me.Lbl_Primer_Apellido.AutoSize = True
        Me.Lbl_Primer_Apellido.Location = New System.Drawing.Point(728, 33)
        Me.Lbl_Primer_Apellido.Name = "Lbl_Primer_Apellido"
        Me.Lbl_Primer_Apellido.Size = New System.Drawing.Size(99, 16)
        Me.Lbl_Primer_Apellido.TabIndex = 8
        Me.Lbl_Primer_Apellido.Text = "Primer Apellido"
        '
        'Txt_Primer_Apellido
        '
        Me.Txt_Primer_Apellido.Location = New System.Drawing.Point(731, 62)
        Me.Txt_Primer_Apellido.Name = "Txt_Primer_Apellido"
        Me.Txt_Primer_Apellido.Size = New System.Drawing.Size(201, 22)
        Me.Txt_Primer_Apellido.TabIndex = 9
        '
        'Lbl_Segundo_Apellido
        '
        Me.Lbl_Segundo_Apellido.AutoSize = True
        Me.Lbl_Segundo_Apellido.Location = New System.Drawing.Point(974, 33)
        Me.Lbl_Segundo_Apellido.Name = "Lbl_Segundo_Apellido"
        Me.Lbl_Segundo_Apellido.Size = New System.Drawing.Size(115, 16)
        Me.Lbl_Segundo_Apellido.TabIndex = 10
        Me.Lbl_Segundo_Apellido.Text = "Segundo Apellido"
        '
        'Txt_Segundo_Apellido
        '
        Me.Txt_Segundo_Apellido.Location = New System.Drawing.Point(977, 62)
        Me.Txt_Segundo_Apellido.Name = "Txt_Segundo_Apellido"
        Me.Txt_Segundo_Apellido.Size = New System.Drawing.Size(201, 22)
        Me.Txt_Segundo_Apellido.TabIndex = 11
        '
        'Lbl_Estado_Civil
        '
        Me.Lbl_Estado_Civil.AutoSize = True
        Me.Lbl_Estado_Civil.Location = New System.Drawing.Point(51, 182)
        Me.Lbl_Estado_Civil.Name = "Lbl_Estado_Civil"
        Me.Lbl_Estado_Civil.Size = New System.Drawing.Size(78, 16)
        Me.Lbl_Estado_Civil.TabIndex = 12
        Me.Lbl_Estado_Civil.Text = "Estado Civil"
        '
        'Lbl_Fecha_Nacimiento
        '
        Me.Lbl_Fecha_Nacimiento.AutoSize = True
        Me.Lbl_Fecha_Nacimiento.Location = New System.Drawing.Point(226, 182)
        Me.Lbl_Fecha_Nacimiento.Name = "Lbl_Fecha_Nacimiento"
        Me.Lbl_Fecha_Nacimiento.Size = New System.Drawing.Size(116, 16)
        Me.Lbl_Fecha_Nacimiento.TabIndex = 13
        Me.Lbl_Fecha_Nacimiento.Text = "Fecha Nacimiento"
        '
        'Dtp_Fecha_Nacimiento
        '
        Me.Dtp_Fecha_Nacimiento.Location = New System.Drawing.Point(229, 219)
        Me.Dtp_Fecha_Nacimiento.Name = "Dtp_Fecha_Nacimiento"
        Me.Dtp_Fecha_Nacimiento.Size = New System.Drawing.Size(249, 22)
        Me.Dtp_Fecha_Nacimiento.TabIndex = 14
        '
        'Lbl_Fecha_Afilicacion
        '
        Me.Lbl_Fecha_Afilicacion.AutoSize = True
        Me.Lbl_Fecha_Afilicacion.Location = New System.Drawing.Point(506, 182)
        Me.Lbl_Fecha_Afilicacion.Name = "Lbl_Fecha_Afilicacion"
        Me.Lbl_Fecha_Afilicacion.Size = New System.Drawing.Size(102, 16)
        Me.Lbl_Fecha_Afilicacion.TabIndex = 15
        Me.Lbl_Fecha_Afilicacion.Text = "Fecha Afiliacion"
        '
        'Dtp_Fecha_Afiliacion
        '
        Me.Dtp_Fecha_Afiliacion.Location = New System.Drawing.Point(509, 217)
        Me.Dtp_Fecha_Afiliacion.Name = "Dtp_Fecha_Afiliacion"
        Me.Dtp_Fecha_Afiliacion.Size = New System.Drawing.Size(249, 22)
        Me.Dtp_Fecha_Afiliacion.TabIndex = 16
        '
        'Lbl_Provincia
        '
        Me.Lbl_Provincia.AutoSize = True
        Me.Lbl_Provincia.Location = New System.Drawing.Point(789, 182)
        Me.Lbl_Provincia.Name = "Lbl_Provincia"
        Me.Lbl_Provincia.Size = New System.Drawing.Size(63, 16)
        Me.Lbl_Provincia.TabIndex = 17
        Me.Lbl_Provincia.Text = "Provincia"
        '
        'Cmbprovincia
        '
        Me.Cmbprovincia.FormattingEnabled = True
        Me.Cmbprovincia.Location = New System.Drawing.Point(792, 215)
        Me.Cmbprovincia.Name = "Cmbprovincia"
        Me.Cmbprovincia.Size = New System.Drawing.Size(121, 24)
        Me.Cmbprovincia.TabIndex = 18
        '
        'Lbl_Canton
        '
        Me.Lbl_Canton.AutoSize = True
        Me.Lbl_Canton.Location = New System.Drawing.Point(951, 182)
        Me.Lbl_Canton.Name = "Lbl_Canton"
        Me.Lbl_Canton.Size = New System.Drawing.Size(49, 16)
        Me.Lbl_Canton.TabIndex = 19
        Me.Lbl_Canton.Text = "Canton"
        '
        'Cmbcanton
        '
        Me.Cmbcanton.FormattingEnabled = True
        Me.Cmbcanton.Location = New System.Drawing.Point(954, 215)
        Me.Cmbcanton.Name = "Cmbcanton"
        Me.Cmbcanton.Size = New System.Drawing.Size(121, 24)
        Me.Cmbcanton.TabIndex = 20
        '
        'Lbl_Distrito
        '
        Me.Lbl_Distrito.AutoSize = True
        Me.Lbl_Distrito.Location = New System.Drawing.Point(1116, 182)
        Me.Lbl_Distrito.Name = "Lbl_Distrito"
        Me.Lbl_Distrito.Size = New System.Drawing.Size(48, 16)
        Me.Lbl_Distrito.TabIndex = 21
        Me.Lbl_Distrito.Text = "Distrito"
        '
        'Cmbdistrito
        '
        Me.Cmbdistrito.FormattingEnabled = True
        Me.Cmbdistrito.Location = New System.Drawing.Point(1119, 215)
        Me.Cmbdistrito.Name = "Cmbdistrito"
        Me.Cmbdistrito.Size = New System.Drawing.Size(121, 24)
        Me.Cmbdistrito.TabIndex = 22
        '
        'Lbl_Profesion
        '
        Me.Lbl_Profesion.AutoSize = True
        Me.Lbl_Profesion.Location = New System.Drawing.Point(51, 332)
        Me.Lbl_Profesion.Name = "Lbl_Profesion"
        Me.Lbl_Profesion.Size = New System.Drawing.Size(64, 16)
        Me.Lbl_Profesion.TabIndex = 23
        Me.Lbl_Profesion.Text = "Profesion"
        '
        'Cmbprofesion
        '
        Me.Cmbprofesion.FormattingEnabled = True
        Me.Cmbprofesion.Location = New System.Drawing.Point(54, 366)
        Me.Cmbprofesion.Name = "Cmbprofesion"
        Me.Cmbprofesion.Size = New System.Drawing.Size(129, 24)
        Me.Cmbprofesion.TabIndex = 24
        '
        'Lbl_Proveedor_Movil
        '
        Me.Lbl_Proveedor_Movil.AutoSize = True
        Me.Lbl_Proveedor_Movil.Location = New System.Drawing.Point(226, 332)
        Me.Lbl_Proveedor_Movil.Name = "Lbl_Proveedor_Movil"
        Me.Lbl_Proveedor_Movil.Size = New System.Drawing.Size(106, 16)
        Me.Lbl_Proveedor_Movil.TabIndex = 25
        Me.Lbl_Proveedor_Movil.Text = "Proveedor Movil"
        '
        'Cmbproveedor_movil
        '
        Me.Cmbproveedor_movil.FormattingEnabled = True
        Me.Cmbproveedor_movil.Location = New System.Drawing.Point(229, 366)
        Me.Cmbproveedor_movil.Name = "Cmbproveedor_movil"
        Me.Cmbproveedor_movil.Size = New System.Drawing.Size(121, 24)
        Me.Cmbproveedor_movil.TabIndex = 26
        '
        'Lbl_Correo_Electronico
        '
        Me.Lbl_Correo_Electronico.AutoSize = True
        Me.Lbl_Correo_Electronico.Location = New System.Drawing.Point(387, 332)
        Me.Lbl_Correo_Electronico.Name = "Lbl_Correo_Electronico"
        Me.Lbl_Correo_Electronico.Size = New System.Drawing.Size(118, 16)
        Me.Lbl_Correo_Electronico.TabIndex = 27
        Me.Lbl_Correo_Electronico.Text = "Correo Electronico"
        '
        'Txt_Correo_Electronico
        '
        Me.Txt_Correo_Electronico.Location = New System.Drawing.Point(390, 368)
        Me.Txt_Correo_Electronico.Name = "Txt_Correo_Electronico"
        Me.Txt_Correo_Electronico.Size = New System.Drawing.Size(201, 22)
        Me.Txt_Correo_Electronico.TabIndex = 28
        '
        'Lbl_Direccion_Exacta
        '
        Me.Lbl_Direccion_Exacta.AutoSize = True
        Me.Lbl_Direccion_Exacta.Location = New System.Drawing.Point(628, 332)
        Me.Lbl_Direccion_Exacta.Name = "Lbl_Direccion_Exacta"
        Me.Lbl_Direccion_Exacta.Size = New System.Drawing.Size(108, 16)
        Me.Lbl_Direccion_Exacta.TabIndex = 29
        Me.Lbl_Direccion_Exacta.Text = "Direccion Exacta"
        '
        'Txt_Direccion_Exacta
        '
        Me.Txt_Direccion_Exacta.Location = New System.Drawing.Point(631, 368)
        Me.Txt_Direccion_Exacta.Name = "Txt_Direccion_Exacta"
        Me.Txt_Direccion_Exacta.Size = New System.Drawing.Size(201, 22)
        Me.Txt_Direccion_Exacta.TabIndex = 30
        '
        'Btn_Incluir
        '
        Me.Btn_Incluir.Location = New System.Drawing.Point(1267, 255)
        Me.Btn_Incluir.Name = "Btn_Incluir"
        Me.Btn_Incluir.Size = New System.Drawing.Size(109, 54)
        Me.Btn_Incluir.TabIndex = 31
        Me.Btn_Incluir.Text = "Incluir"
        Me.Btn_Incluir.UseVisualStyleBackColor = True
        '
        'Btn_Modificar
        '
        Me.Btn_Modificar.Location = New System.Drawing.Point(1267, 332)
        Me.Btn_Modificar.Name = "Btn_Modificar"
        Me.Btn_Modificar.Size = New System.Drawing.Size(109, 54)
        Me.Btn_Modificar.TabIndex = 32
        Me.Btn_Modificar.Text = "Modificar"
        Me.Btn_Modificar.UseVisualStyleBackColor = True
        '
        'Btn_Consultar
        '
        Me.Btn_Consultar.Location = New System.Drawing.Point(1267, 406)
        Me.Btn_Consultar.Name = "Btn_Consultar"
        Me.Btn_Consultar.Size = New System.Drawing.Size(109, 54)
        Me.Btn_Consultar.TabIndex = 33
        Me.Btn_Consultar.Text = "Consultar"
        Me.Btn_Consultar.UseVisualStyleBackColor = True
        '
        'Btn_Consultar_Padron
        '
        Me.Btn_Consultar_Padron.Location = New System.Drawing.Point(1267, 476)
        Me.Btn_Consultar_Padron.Name = "Btn_Consultar_Padron"
        Me.Btn_Consultar_Padron.Size = New System.Drawing.Size(109, 54)
        Me.Btn_Consultar_Padron.TabIndex = 34
        Me.Btn_Consultar_Padron.Text = "Consultar Padron"
        Me.Btn_Consultar_Padron.UseVisualStyleBackColor = True
        '
        'Btn_Eliminar
        '
        Me.Btn_Eliminar.Location = New System.Drawing.Point(1267, 545)
        Me.Btn_Eliminar.Name = "Btn_Eliminar"
        Me.Btn_Eliminar.Size = New System.Drawing.Size(109, 54)
        Me.Btn_Eliminar.TabIndex = 35
        Me.Btn_Eliminar.Text = "Eliminar"
        Me.Btn_Eliminar.UseVisualStyleBackColor = True
        '
        'Btn_Limpiar
        '
        Me.Btn_Limpiar.Location = New System.Drawing.Point(1267, 614)
        Me.Btn_Limpiar.Name = "Btn_Limpiar"
        Me.Btn_Limpiar.Size = New System.Drawing.Size(109, 54)
        Me.Btn_Limpiar.TabIndex = 36
        Me.Btn_Limpiar.Text = "Limpiar"
        Me.Btn_Limpiar.UseVisualStyleBackColor = True
        '
        'Txt_NumeroId
        '
        Me.Txt_NumeroId.Location = New System.Drawing.Point(229, 64)
        Me.Txt_NumeroId.Name = "Txt_NumeroId"
        Me.Txt_NumeroId.Size = New System.Drawing.Size(201, 22)
        Me.Txt_NumeroId.TabIndex = 37
        '
        'Formulario_Finalvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1390, 693)
        Me.Controls.Add(Me.Txt_NumeroId)
        Me.Controls.Add(Me.Btn_Limpiar)
        Me.Controls.Add(Me.Btn_Eliminar)
        Me.Controls.Add(Me.Btn_Consultar_Padron)
        Me.Controls.Add(Me.Btn_Consultar)
        Me.Controls.Add(Me.Btn_Modificar)
        Me.Controls.Add(Me.Btn_Incluir)
        Me.Controls.Add(Me.Txt_Direccion_Exacta)
        Me.Controls.Add(Me.Lbl_Direccion_Exacta)
        Me.Controls.Add(Me.Txt_Correo_Electronico)
        Me.Controls.Add(Me.Lbl_Correo_Electronico)
        Me.Controls.Add(Me.Cmbproveedor_movil)
        Me.Controls.Add(Me.Lbl_Proveedor_Movil)
        Me.Controls.Add(Me.Cmbprofesion)
        Me.Controls.Add(Me.Lbl_Profesion)
        Me.Controls.Add(Me.Cmbdistrito)
        Me.Controls.Add(Me.Lbl_Distrito)
        Me.Controls.Add(Me.Cmbcanton)
        Me.Controls.Add(Me.Lbl_Canton)
        Me.Controls.Add(Me.Cmbprovincia)
        Me.Controls.Add(Me.Lbl_Provincia)
        Me.Controls.Add(Me.Dtp_Fecha_Afiliacion)
        Me.Controls.Add(Me.Lbl_Fecha_Afilicacion)
        Me.Controls.Add(Me.Dtp_Fecha_Nacimiento)
        Me.Controls.Add(Me.Lbl_Fecha_Nacimiento)
        Me.Controls.Add(Me.Lbl_Estado_Civil)
        Me.Controls.Add(Me.Txt_Segundo_Apellido)
        Me.Controls.Add(Me.Lbl_Segundo_Apellido)
        Me.Controls.Add(Me.Txt_Primer_Apellido)
        Me.Controls.Add(Me.Lbl_Primer_Apellido)
        Me.Controls.Add(Me.Txt_Nombre)
        Me.Controls.Add(Me.Lbl_Nombre)
        Me.Controls.Add(Me.Lbl_NumeroId)
        Me.Controls.Add(Me.Cmb_Tipo_Identificacion)
        Me.Controls.Add(Me.Lbl_Tipoid)
        Me.Controls.Add(Me.Cmb_estado_civil)
        Me.Name = "Formulario_Finalvb"
        Me.Text = "CAPTURA DATOS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Cmb_Tipoid As ComboBox
    Friend WithEvents Cmb_estado_civil As ComboBox
    Friend WithEvents Lbl_Tipoid As Label
    Friend WithEvents Cmb_Tipo_Identificacion As ComboBox
    Friend WithEvents Lbl_NumeroId As Label
    Friend WithEvents Lbl_Nombre As Label
    Friend WithEvents Txt_Nombre As TextBox
    Friend WithEvents Lbl_Primer_Apellido As Label
    Friend WithEvents Txt_Primer_Apellido As TextBox
    Friend WithEvents Lbl_Segundo_Apellido As Label
    Friend WithEvents Txt_Segundo_Apellido As TextBox
    Friend WithEvents Lbl_Estado_Civil As Label
    Friend WithEvents Lbl_Fecha_Nacimiento As Label
    Friend WithEvents Dtp_Fecha_Nacimiento As DateTimePicker
    Friend WithEvents Lbl_Fecha_Afilicacion As Label
    Friend WithEvents Dtp_Fecha_Afiliacion As DateTimePicker
    Friend WithEvents Lbl_Provincia As Label
    Friend WithEvents Cmbprovincia As ComboBox
    Friend WithEvents Lbl_Canton As Label
    Friend WithEvents Cmbcanton As ComboBox
    Friend WithEvents Lbl_Distrito As Label
    Friend WithEvents Cmbdistrito As ComboBox
    Friend WithEvents Lbl_Profesion As Label
    Friend WithEvents Cmbprofesion As ComboBox
    Friend WithEvents Lbl_Proveedor_Movil As Label
    Friend WithEvents Cmbproveedor_movil As ComboBox
    Friend WithEvents Lbl_Correo_Electronico As Label
    Friend WithEvents Txt_Correo_Electronico As TextBox
    Friend WithEvents Lbl_Direccion_Exacta As Label
    Friend WithEvents Txt_Direccion_Exacta As TextBox
    Friend WithEvents Btn_Incluir As Button
    Friend WithEvents Btn_Modificar As Button
    Friend WithEvents Btn_Consultar As Button
    Friend WithEvents Btn_Consultar_Padron As Button
    Friend WithEvents Btn_Eliminar As Button
    Friend WithEvents Btn_Limpiar As Button
    Friend WithEvents Txt_NumeroId As MaskedTextBox
End Class
