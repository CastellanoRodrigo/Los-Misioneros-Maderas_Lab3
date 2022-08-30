<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmClientes
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
        Me.gbDatosCliente = New System.Windows.Forms.GroupBox()
        Me.cmdTablaClientes_a_TXT = New System.Windows.Forms.Button()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.lblDomicilioCliente = New System.Windows.Forms.Label()
        Me.cmdCargarCliente = New System.Windows.Forms.Button()
        Me.lblTeléfonoCliente = New System.Windows.Forms.Label()
        Me.txtTeléfono = New System.Windows.Forms.TextBox()
        Me.txtDomicilio = New System.Windows.Forms.TextBox()
        Me.txtNombreApellido = New System.Windows.Forms.TextBox()
        Me.cmdVolver = New System.Windows.Forms.Button()
        Me.gbDatosCliente.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbDatosCliente
        '
        Me.gbDatosCliente.BackColor = System.Drawing.Color.PeachPuff
        Me.gbDatosCliente.Controls.Add(Me.cmdTablaClientes_a_TXT)
        Me.gbDatosCliente.Controls.Add(Me.lblCliente)
        Me.gbDatosCliente.Controls.Add(Me.lblDomicilioCliente)
        Me.gbDatosCliente.Controls.Add(Me.cmdCargarCliente)
        Me.gbDatosCliente.Controls.Add(Me.lblTeléfonoCliente)
        Me.gbDatosCliente.Controls.Add(Me.txtTeléfono)
        Me.gbDatosCliente.Controls.Add(Me.txtDomicilio)
        Me.gbDatosCliente.Controls.Add(Me.txtNombreApellido)
        Me.gbDatosCliente.Location = New System.Drawing.Point(12, 12)
        Me.gbDatosCliente.Name = "gbDatosCliente"
        Me.gbDatosCliente.Size = New System.Drawing.Size(385, 249)
        Me.gbDatosCliente.TabIndex = 37
        Me.gbDatosCliente.TabStop = False
        Me.gbDatosCliente.Text = "Datos del Cliente"
        '
        'cmdTablaClientes_a_TXT
        '
        Me.cmdTablaClientes_a_TXT.Location = New System.Drawing.Point(94, 209)
        Me.cmdTablaClientes_a_TXT.Name = "cmdTablaClientes_a_TXT"
        Me.cmdTablaClientes_a_TXT.Size = New System.Drawing.Size(197, 25)
        Me.cmdTablaClientes_a_TXT.TabIndex = 38
        Me.cmdTablaClientes_a_TXT.Text = "Guardar tabla Clientes en TXT"
        Me.cmdTablaClientes_a_TXT.UseVisualStyleBackColor = True
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(6, 50)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(120, 16)
        Me.lblCliente.TabIndex = 26
        Me.lblCliente.Text = "Nombre y Apellido"
        '
        'lblDomicilioCliente
        '
        Me.lblDomicilioCliente.AutoSize = True
        Me.lblDomicilioCliente.Location = New System.Drawing.Point(6, 88)
        Me.lblDomicilioCliente.Name = "lblDomicilioCliente"
        Me.lblDomicilioCliente.Size = New System.Drawing.Size(64, 16)
        Me.lblDomicilioCliente.TabIndex = 27
        Me.lblDomicilioCliente.Text = "Domicilio"
        '
        'cmdCargarCliente
        '
        Me.cmdCargarCliente.Location = New System.Drawing.Point(142, 167)
        Me.cmdCargarCliente.Name = "cmdCargarCliente"
        Me.cmdCargarCliente.Size = New System.Drawing.Size(101, 25)
        Me.cmdCargarCliente.TabIndex = 33
        Me.cmdCargarCliente.Text = "Cargar Cliente"
        Me.cmdCargarCliente.UseVisualStyleBackColor = True
        '
        'lblTeléfonoCliente
        '
        Me.lblTeléfonoCliente.AutoSize = True
        Me.lblTeléfonoCliente.Location = New System.Drawing.Point(8, 125)
        Me.lblTeléfonoCliente.Name = "lblTeléfonoCliente"
        Me.lblTeléfonoCliente.Size = New System.Drawing.Size(62, 16)
        Me.lblTeléfonoCliente.TabIndex = 28
        Me.lblTeléfonoCliente.Text = "Teléfono"
        '
        'txtTeléfono
        '
        Me.txtTeléfono.Location = New System.Drawing.Point(132, 122)
        Me.txtTeléfono.Name = "txtTeléfono"
        Me.txtTeléfono.Size = New System.Drawing.Size(242, 22)
        Me.txtTeléfono.TabIndex = 32
        '
        'txtDomicilio
        '
        Me.txtDomicilio.Location = New System.Drawing.Point(132, 85)
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.Size = New System.Drawing.Size(242, 22)
        Me.txtDomicilio.TabIndex = 31
        '
        'txtNombreApellido
        '
        Me.txtNombreApellido.Location = New System.Drawing.Point(132, 47)
        Me.txtNombreApellido.Name = "txtNombreApellido"
        Me.txtNombreApellido.Size = New System.Drawing.Size(242, 22)
        Me.txtNombreApellido.TabIndex = 30
        '
        'cmdVolver
        '
        Me.cmdVolver.Location = New System.Drawing.Point(168, 280)
        Me.cmdVolver.Name = "cmdVolver"
        Me.cmdVolver.Size = New System.Drawing.Size(75, 30)
        Me.cmdVolver.TabIndex = 38
        Me.cmdVolver.Text = "Volver"
        Me.cmdVolver.UseVisualStyleBackColor = True
        '
        'FrmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.ClientSize = New System.Drawing.Size(411, 327)
        Me.Controls.Add(Me.cmdVolver)
        Me.Controls.Add(Me.gbDatosCliente)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmClientes"
        Me.Text = "Los Misioneros Maderas - Añadir Cliente"
        Me.gbDatosCliente.ResumeLayout(False)
        Me.gbDatosCliente.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbDatosCliente As GroupBox
    Friend WithEvents cmdTablaClientes_a_TXT As Button
    Friend WithEvents lblCliente As Label
    Friend WithEvents lblDomicilioCliente As Label
    Friend WithEvents cmdCargarCliente As Button
    Friend WithEvents lblTeléfonoCliente As Label
    Friend WithEvents txtTeléfono As TextBox
    Friend WithEvents txtDomicilio As TextBox
    Friend WithEvents txtNombreApellido As TextBox
    Friend WithEvents cmdVolver As Button
End Class
