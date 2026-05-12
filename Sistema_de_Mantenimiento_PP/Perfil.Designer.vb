<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Perfil
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Grbcatalogo_tipoid = New System.Windows.Forms.GroupBox()
        Me.Txtdescripcion = New System.Windows.Forms.TextBox()
        Me.Lbldescripcion = New System.Windows.Forms.Label()
        Me.Txt_tipoid = New System.Windows.Forms.TextBox()
        Me.Lbltipoid = New System.Windows.Forms.Label()
        Me.Txtfecha = New System.Windows.Forms.TextBox()
        Me.Grbacciones = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Boteliminar = New System.Windows.Forms.Button()
        Me.Botconsultar = New System.Windows.Forms.Button()
        Me.Botmodificar = New System.Windows.Forms.Button()
        Me.Botinsertar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CODIGOIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCRIPCIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PERFILBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PROYECTO_DB_PARTIDOS_POLITICOSDataSet4 = New Sistema_de_Mantenimiento_PP.PROYECTO_DB_PARTIDOS_POLITICOSDataSet4()
        Me.PERFILTableAdapter = New Sistema_de_Mantenimiento_PP.PROYECTO_DB_PARTIDOS_POLITICOSDataSet4TableAdapters.PERFILTableAdapter()
        Me.Grbcatalogo_tipoid.SuspendLayout()
        Me.Grbacciones.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PERFILBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROYECTO_DB_PARTIDOS_POLITICOSDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Grbcatalogo_tipoid
        '
        Me.Grbcatalogo_tipoid.Controls.Add(Me.Txtdescripcion)
        Me.Grbcatalogo_tipoid.Controls.Add(Me.Lbldescripcion)
        Me.Grbcatalogo_tipoid.Controls.Add(Me.Txt_tipoid)
        Me.Grbcatalogo_tipoid.Controls.Add(Me.Lbltipoid)
        Me.Grbcatalogo_tipoid.Location = New System.Drawing.Point(25, 30)
        Me.Grbcatalogo_tipoid.Name = "Grbcatalogo_tipoid"
        Me.Grbcatalogo_tipoid.Size = New System.Drawing.Size(947, 179)
        Me.Grbcatalogo_tipoid.TabIndex = 3
        Me.Grbcatalogo_tipoid.TabStop = False
        Me.Grbcatalogo_tipoid.Text = "Mantenimiento Perfil"
        '
        'Txtdescripcion
        '
        Me.Txtdescripcion.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Txtdescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txtdescripcion.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtdescripcion.Location = New System.Drawing.Point(309, 103)
        Me.Txtdescripcion.MaxLength = 50
        Me.Txtdescripcion.Name = "Txtdescripcion"
        Me.Txtdescripcion.Size = New System.Drawing.Size(440, 32)
        Me.Txtdescripcion.TabIndex = 7
        '
        'Lbldescripcion
        '
        Me.Lbldescripcion.AutoSize = True
        Me.Lbldescripcion.Location = New System.Drawing.Point(31, 113)
        Me.Lbldescripcion.Name = "Lbldescripcion"
        Me.Lbldescripcion.Size = New System.Drawing.Size(167, 16)
        Me.Lbldescripcion.TabIndex = 6
        Me.Lbldescripcion.Text = "DIGITE LA DESCRIPCION:"
        '
        'Txt_tipoid
        '
        Me.Txt_tipoid.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Txt_tipoid.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_tipoid.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Txt_tipoid.Location = New System.Drawing.Point(309, 43)
        Me.Txt_tipoid.MaxLength = 2
        Me.Txt_tipoid.Name = "Txt_tipoid"
        Me.Txt_tipoid.Size = New System.Drawing.Size(100, 32)
        Me.Txt_tipoid.TabIndex = 5
        '
        'Lbltipoid
        '
        Me.Lbltipoid.AutoSize = True
        Me.Lbltipoid.Location = New System.Drawing.Point(31, 53)
        Me.Lbltipoid.Name = "Lbltipoid"
        Me.Lbltipoid.Size = New System.Drawing.Size(122, 16)
        Me.Lbltipoid.TabIndex = 0
        Me.Lbltipoid.Text = "DIGITE EL PERFIL:"
        '
        'Txtfecha
        '
        Me.Txtfecha.BackColor = System.Drawing.Color.RosyBrown
        Me.Txtfecha.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtfecha.Location = New System.Drawing.Point(1011, 43)
        Me.Txtfecha.Name = "Txtfecha"
        Me.Txtfecha.Size = New System.Drawing.Size(298, 29)
        Me.Txtfecha.TabIndex = 14
        '
        'Grbacciones
        '
        Me.Grbacciones.Controls.Add(Me.Button1)
        Me.Grbacciones.Controls.Add(Me.Boteliminar)
        Me.Grbacciones.Controls.Add(Me.Botconsultar)
        Me.Grbacciones.Controls.Add(Me.Botmodificar)
        Me.Grbacciones.Controls.Add(Me.Botinsertar)
        Me.Grbacciones.Location = New System.Drawing.Point(25, 247)
        Me.Grbacciones.Name = "Grbacciones"
        Me.Grbacciones.Size = New System.Drawing.Size(859, 110)
        Me.Grbacciones.TabIndex = 15
        Me.Grbacciones.TabStop = False
        Me.Grbacciones.Text = "Acciones"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.HotPink
        Me.Button1.Location = New System.Drawing.Point(683, 31)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 51)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "&Limpiar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Boteliminar
        '
        Me.Boteliminar.BackColor = System.Drawing.Color.HotPink
        Me.Boteliminar.Location = New System.Drawing.Point(529, 31)
        Me.Boteliminar.Name = "Boteliminar"
        Me.Boteliminar.Size = New System.Drawing.Size(132, 51)
        Me.Boteliminar.TabIndex = 9
        Me.Boteliminar.Text = "&Eliminar"
        Me.Boteliminar.UseVisualStyleBackColor = False
        '
        'Botconsultar
        '
        Me.Botconsultar.BackColor = System.Drawing.Color.HotPink
        Me.Botconsultar.Location = New System.Drawing.Point(233, 31)
        Me.Botconsultar.Name = "Botconsultar"
        Me.Botconsultar.Size = New System.Drawing.Size(132, 51)
        Me.Botconsultar.TabIndex = 7
        Me.Botconsultar.Text = "&Consultar"
        Me.Botconsultar.UseVisualStyleBackColor = False
        '
        'Botmodificar
        '
        Me.Botmodificar.BackColor = System.Drawing.Color.HotPink
        Me.Botmodificar.Location = New System.Drawing.Point(382, 31)
        Me.Botmodificar.Name = "Botmodificar"
        Me.Botmodificar.Size = New System.Drawing.Size(132, 51)
        Me.Botmodificar.TabIndex = 8
        Me.Botmodificar.Text = "&Modificar"
        Me.Botmodificar.UseVisualStyleBackColor = False
        '
        'Botinsertar
        '
        Me.Botinsertar.BackColor = System.Drawing.Color.HotPink
        Me.Botinsertar.Location = New System.Drawing.Point(82, 31)
        Me.Botinsertar.Name = "Botinsertar"
        Me.Botinsertar.Size = New System.Drawing.Size(132, 51)
        Me.Botinsertar.TabIndex = 6
        Me.Botinsertar.Text = "&Insertar"
        Me.Botinsertar.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODIGOIDDataGridViewTextBoxColumn, Me.DESCRIPCIONDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PERFILBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(25, 381)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(859, 148)
        Me.DataGridView1.TabIndex = 16
        '
        'CODIGOIDDataGridViewTextBoxColumn
        '
        Me.CODIGOIDDataGridViewTextBoxColumn.DataPropertyName = "CODIGO_ID"
        Me.CODIGOIDDataGridViewTextBoxColumn.HeaderText = "CODIGO_ID"
        Me.CODIGOIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CODIGOIDDataGridViewTextBoxColumn.Name = "CODIGOIDDataGridViewTextBoxColumn"
        Me.CODIGOIDDataGridViewTextBoxColumn.Width = 125
        '
        'DESCRIPCIONDataGridViewTextBoxColumn
        '
        Me.DESCRIPCIONDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPCION"
        Me.DESCRIPCIONDataGridViewTextBoxColumn.HeaderText = "DESCRIPCION"
        Me.DESCRIPCIONDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DESCRIPCIONDataGridViewTextBoxColumn.Name = "DESCRIPCIONDataGridViewTextBoxColumn"
        Me.DESCRIPCIONDataGridViewTextBoxColumn.Width = 125
        '
        'PERFILBindingSource
        '
        Me.PERFILBindingSource.DataMember = "PERFIL"
        Me.PERFILBindingSource.DataSource = Me.PROYECTO_DB_PARTIDOS_POLITICOSDataSet4
        '
        'PROYECTO_DB_PARTIDOS_POLITICOSDataSet4
        '
        Me.PROYECTO_DB_PARTIDOS_POLITICOSDataSet4.DataSetName = "PROYECTO_DB_PARTIDOS_POLITICOSDataSet4"
        Me.PROYECTO_DB_PARTIDOS_POLITICOSDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PERFILTableAdapter
        '
        Me.PERFILTableAdapter.ClearBeforeFill = True
        '
        'Perfil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1332, 609)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Grbacciones)
        Me.Controls.Add(Me.Txtfecha)
        Me.Controls.Add(Me.Grbcatalogo_tipoid)
        Me.Name = "Perfil"
        Me.Text = "Perfil"
        Me.Grbcatalogo_tipoid.ResumeLayout(False)
        Me.Grbcatalogo_tipoid.PerformLayout()
        Me.Grbacciones.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PERFILBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROYECTO_DB_PARTIDOS_POLITICOSDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents Grbcatalogo_tipoid As GroupBox
    Friend WithEvents Txtdescripcion As TextBox
    Friend WithEvents Lbldescripcion As Label
    Friend WithEvents Txt_tipoid As TextBox
    Friend WithEvents Lbltipoid As Label
    Friend WithEvents Txtfecha As TextBox
    Friend WithEvents Grbacciones As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Boteliminar As Button
    Friend WithEvents Botconsultar As Button
    Friend WithEvents Botmodificar As Button
    Friend WithEvents Botinsertar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PROYECTO_DB_PARTIDOS_POLITICOSDataSet4 As PROYECTO_DB_PARTIDOS_POLITICOSDataSet4
    Friend WithEvents PERFILBindingSource As BindingSource
    Friend WithEvents PERFILTableAdapter As PROYECTO_DB_PARTIDOS_POLITICOSDataSet4TableAdapters.PERFILTableAdapter
    Friend WithEvents CODIGOIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DESCRIPCIONDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
