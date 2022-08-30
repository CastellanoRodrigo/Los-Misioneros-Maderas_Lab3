<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmpleados
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
        Me.gbDatosEmpleado = New System.Windows.Forms.GroupBox()
        Me.txtTeléfonoEMP = New System.Windows.Forms.TextBox()
        Me.txtDomicilioEMP = New System.Windows.Forms.TextBox()
        Me.txtNombreApellidoEMP = New System.Windows.Forms.TextBox()
        Me.cmdCargarEmpleado = New System.Windows.Forms.Button()
        Me.lblNombreEMP = New System.Windows.Forms.Label()
        Me.lblDomicilioEMP = New System.Windows.Forms.Label()
        Me.lblTelEMP = New System.Windows.Forms.Label()
        Me.cmdVolver4 = New System.Windows.Forms.Button()
        Me.gbDatosEmpleado.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbDatosEmpleado
        '
        Me.gbDatosEmpleado.Controls.Add(Me.txtTeléfonoEMP)
        Me.gbDatosEmpleado.Controls.Add(Me.txtDomicilioEMP)
        Me.gbDatosEmpleado.Controls.Add(Me.txtNombreApellidoEMP)
        Me.gbDatosEmpleado.Controls.Add(Me.cmdCargarEmpleado)
        Me.gbDatosEmpleado.Controls.Add(Me.lblNombreEMP)
        Me.gbDatosEmpleado.Controls.Add(Me.lblDomicilioEMP)
        Me.gbDatosEmpleado.Controls.Add(Me.lblTelEMP)
        Me.gbDatosEmpleado.Location = New System.Drawing.Point(12, 12)
        Me.gbDatosEmpleado.Name = "gbDatosEmpleado"
        Me.gbDatosEmpleado.Size = New System.Drawing.Size(385, 249)
        Me.gbDatosEmpleado.TabIndex = 1
        Me.gbDatosEmpleado.TabStop = False
        Me.gbDatosEmpleado.Text = "Datos del Empleado"
        '
        'txtTeléfonoEMP
        '
        Me.txtTeléfonoEMP.Location = New System.Drawing.Point(155, 147)
        Me.txtTeléfonoEMP.Name = "txtTeléfonoEMP"
        Me.txtTeléfonoEMP.Size = New System.Drawing.Size(212, 22)
        Me.txtTeléfonoEMP.TabIndex = 45
        '
        'txtDomicilioEMP
        '
        Me.txtDomicilioEMP.Location = New System.Drawing.Point(155, 106)
        Me.txtDomicilioEMP.Name = "txtDomicilioEMP"
        Me.txtDomicilioEMP.Size = New System.Drawing.Size(211, 22)
        Me.txtDomicilioEMP.TabIndex = 44
        '
        'txtNombreApellidoEMP
        '
        Me.txtNombreApellidoEMP.Location = New System.Drawing.Point(155, 65)
        Me.txtNombreApellidoEMP.Name = "txtNombreApellidoEMP"
        Me.txtNombreApellidoEMP.Size = New System.Drawing.Size(212, 22)
        Me.txtNombreApellidoEMP.TabIndex = 43
        '
        'cmdCargarEmpleado
        '
        Me.cmdCargarEmpleado.Location = New System.Drawing.Point(127, 208)
        Me.cmdCargarEmpleado.Name = "cmdCargarEmpleado"
        Me.cmdCargarEmpleado.Size = New System.Drawing.Size(131, 25)
        Me.cmdCargarEmpleado.TabIndex = 42
        Me.cmdCargarEmpleado.Text = "Cargar Empleado"
        Me.cmdCargarEmpleado.UseVisualStyleBackColor = True
        '
        'lblNombreEMP
        '
        Me.lblNombreEMP.AutoSize = True
        Me.lblNombreEMP.Location = New System.Drawing.Point(6, 68)
        Me.lblNombreEMP.Name = "lblNombreEMP"
        Me.lblNombreEMP.Size = New System.Drawing.Size(120, 16)
        Me.lblNombreEMP.TabIndex = 39
        Me.lblNombreEMP.Text = "Nombre y Apellido"
        '
        'lblDomicilioEMP
        '
        Me.lblDomicilioEMP.AutoSize = True
        Me.lblDomicilioEMP.Location = New System.Drawing.Point(6, 109)
        Me.lblDomicilioEMP.Name = "lblDomicilioEMP"
        Me.lblDomicilioEMP.Size = New System.Drawing.Size(64, 16)
        Me.lblDomicilioEMP.TabIndex = 40
        Me.lblDomicilioEMP.Text = "Domicilio"
        '
        'lblTelEMP
        '
        Me.lblTelEMP.AutoSize = True
        Me.lblTelEMP.Location = New System.Drawing.Point(6, 150)
        Me.lblTelEMP.Name = "lblTelEMP"
        Me.lblTelEMP.Size = New System.Drawing.Size(62, 16)
        Me.lblTelEMP.TabIndex = 41
        Me.lblTelEMP.Text = "Teléfono"
        '
        'cmdVolver4
        '
        Me.cmdVolver4.Location = New System.Drawing.Point(168, 277)
        Me.cmdVolver4.Name = "cmdVolver4"
        Me.cmdVolver4.Size = New System.Drawing.Size(75, 25)
        Me.cmdVolver4.TabIndex = 44
        Me.cmdVolver4.Text = "Volver"
        Me.cmdVolver4.UseVisualStyleBackColor = True
        '
        'FrmEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 317)
        Me.Controls.Add(Me.cmdVolver4)
        Me.Controls.Add(Me.gbDatosEmpleado)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmEmpleados"
        Me.Text = "Los Misioneros Maderas - Añadir Empleado"
        Me.gbDatosEmpleado.ResumeLayout(False)
        Me.gbDatosEmpleado.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbDatosEmpleado As GroupBox
    Friend WithEvents txtTeléfonoEMP As TextBox
    Friend WithEvents txtDomicilioEMP As TextBox
    Friend WithEvents txtNombreApellidoEMP As TextBox
    Friend WithEvents cmdCargarEmpleado As Button
    Friend WithEvents lblNombreEMP As Label
    Friend WithEvents lblDomicilioEMP As Label
    Friend WithEvents lblTelEMP As Label
    Friend WithEvents cmdVolver4 As Button
End Class
