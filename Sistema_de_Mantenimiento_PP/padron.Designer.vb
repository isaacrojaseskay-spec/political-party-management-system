<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class padron
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
        Me.Btncargar = New System.Windows.Forms.Button()
        Me.Lblruta = New System.Windows.Forms.Label()
        Me.TxtRuta = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Txthora = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Btncargar
        '
        Me.Btncargar.Location = New System.Drawing.Point(51, 104)
        Me.Btncargar.Name = "Btncargar"
        Me.Btncargar.Size = New System.Drawing.Size(193, 101)
        Me.Btncargar.TabIndex = 0
        Me.Btncargar.Text = "Cargar archivo"
        Me.Btncargar.UseVisualStyleBackColor = True
        '
        'Lblruta
        '
        Me.Lblruta.AutoSize = True
        Me.Lblruta.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblruta.Location = New System.Drawing.Point(276, 136)
        Me.Lblruta.Name = "Lblruta"
        Me.Lblruta.Size = New System.Drawing.Size(67, 28)
        Me.Lblruta.TabIndex = 1
        Me.Lblruta.Text = "Ruta:"
        '
        'TxtRuta
        '
        Me.TxtRuta.Location = New System.Drawing.Point(375, 142)
        Me.TxtRuta.Name = "TxtRuta"
        Me.TxtRuta.Size = New System.Drawing.Size(564, 22)
        Me.TxtRuta.TabIndex = 2
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Txthora
        '
        Me.Txthora.Location = New System.Drawing.Point(508, 39)
        Me.Txthora.Name = "Txthora"
        Me.Txthora.Size = New System.Drawing.Size(373, 22)
        Me.Txthora.TabIndex = 3
        '
        'padron
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 450)
        Me.Controls.Add(Me.Txthora)
        Me.Controls.Add(Me.TxtRuta)
        Me.Controls.Add(Me.Lblruta)
        Me.Controls.Add(Me.Btncargar)
        Me.Name = "padron"
        Me.Text = "padron"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btncargar As Button
    Friend WithEvents Lblruta As Label
    Friend WithEvents TxtRuta As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Txthora As TextBox
End Class
