<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.Lbl_Usuario = New System.Windows.Forms.Label()
        Me.Lbl_Clave = New System.Windows.Forms.Label()
        Me.Txt_Usuario = New System.Windows.Forms.TextBox()
        Me.Txt_Clave = New System.Windows.Forms.TextBox()
        Me.Grb_Autenticacion = New System.Windows.Forms.GroupBox()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.Btn_Aceptar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Grb_Autenticacion.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lbl_Usuario
        '
        Me.Lbl_Usuario.AutoSize = True
        Me.Lbl_Usuario.Location = New System.Drawing.Point(80, 88)
        Me.Lbl_Usuario.Name = "Lbl_Usuario"
        Me.Lbl_Usuario.Size = New System.Drawing.Size(68, 16)
        Me.Lbl_Usuario.TabIndex = 0
        Me.Lbl_Usuario.Text = "USUARIO"
        '
        'Lbl_Clave
        '
        Me.Lbl_Clave.AutoSize = True
        Me.Lbl_Clave.Location = New System.Drawing.Point(80, 168)
        Me.Lbl_Clave.Name = "Lbl_Clave"
        Me.Lbl_Clave.Size = New System.Drawing.Size(50, 16)
        Me.Lbl_Clave.TabIndex = 1
        Me.Lbl_Clave.Text = "CLAVE"
        '
        'Txt_Usuario
        '
        Me.Txt_Usuario.Location = New System.Drawing.Point(183, 88)
        Me.Txt_Usuario.Name = "Txt_Usuario"
        Me.Txt_Usuario.Size = New System.Drawing.Size(191, 22)
        Me.Txt_Usuario.TabIndex = 2
        '
        'Txt_Clave
        '
        Me.Txt_Clave.Location = New System.Drawing.Point(183, 162)
        Me.Txt_Clave.Name = "Txt_Clave"
        Me.Txt_Clave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_Clave.Size = New System.Drawing.Size(191, 22)
        Me.Txt_Clave.TabIndex = 3
        '
        'Grb_Autenticacion
        '
        Me.Grb_Autenticacion.Controls.Add(Me.Btn_Cancelar)
        Me.Grb_Autenticacion.Controls.Add(Me.Btn_Aceptar)
        Me.Grb_Autenticacion.Location = New System.Drawing.Point(108, 216)
        Me.Grb_Autenticacion.Name = "Grb_Autenticacion"
        Me.Grb_Autenticacion.Size = New System.Drawing.Size(292, 83)
        Me.Grb_Autenticacion.TabIndex = 4
        Me.Grb_Autenticacion.TabStop = False
        Me.Grb_Autenticacion.Text = "GroupBox1"
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.BackColor = System.Drawing.Color.Crimson
        Me.Btn_Cancelar.Location = New System.Drawing.Point(164, 21)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(102, 39)
        Me.Btn_Cancelar.TabIndex = 6
        Me.Btn_Cancelar.Text = "CANCELAR"
        Me.Btn_Cancelar.UseVisualStyleBackColor = False
        '
        'Btn_Aceptar
        '
        Me.Btn_Aceptar.BackColor = System.Drawing.Color.PaleGreen
        Me.Btn_Aceptar.Location = New System.Drawing.Point(37, 21)
        Me.Btn_Aceptar.Name = "Btn_Aceptar"
        Me.Btn_Aceptar.Size = New System.Drawing.Size(102, 39)
        Me.Btn_Aceptar.TabIndex = 5
        Me.Btn_Aceptar.Text = "ACEPTAR"
        Me.Btn_Aceptar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Sistema_de_Mantenimiento_PP.My.Resources.Resources.Seguridad
        Me.PictureBox1.Location = New System.Drawing.Point(470, 88)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(237, 204)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Grb_Autenticacion)
        Me.Controls.Add(Me.Txt_Clave)
        Me.Controls.Add(Me.Txt_Usuario)
        Me.Controls.Add(Me.Lbl_Clave)
        Me.Controls.Add(Me.Lbl_Usuario)
        Me.Name = "Form5"
        Me.Text = "Autenticacion"
        Me.Grb_Autenticacion.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_Usuario As Label
    Friend WithEvents Lbl_Clave As Label
    Friend WithEvents Txt_Usuario As TextBox
    Friend WithEvents Txt_Clave As TextBox
    Friend WithEvents Grb_Autenticacion As GroupBox
    Friend WithEvents Btn_Cancelar As Button
    Friend WithEvents Btn_Aceptar As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
