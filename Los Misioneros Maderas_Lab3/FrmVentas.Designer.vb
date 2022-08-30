<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVentas
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
        Me.gbDatosVenta = New System.Windows.Forms.GroupBox()
        Me.lblVenFech = New System.Windows.Forms.Label()
        Me.lblVenCli = New System.Windows.Forms.Label()
        Me.lblVenEmp = New System.Windows.Forms.Label()
        Me.lblVenPro = New System.Windows.Forms.Label()
        Me.cbClientes = New System.Windows.Forms.ComboBox()
        Me.cbEmpleados = New System.Windows.Forms.ComboBox()
        Me.cbProductos = New System.Windows.Forms.ComboBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.cmdVolver2 = New System.Windows.Forms.Button()
        Me.cmdCargarVenta = New System.Windows.Forms.Button()
        Me.gbDatosVenta.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbDatosVenta
        '
        Me.gbDatosVenta.BackColor = System.Drawing.Color.Gold
        Me.gbDatosVenta.Controls.Add(Me.lblVenFech)
        Me.gbDatosVenta.Controls.Add(Me.lblVenCli)
        Me.gbDatosVenta.Controls.Add(Me.lblVenEmp)
        Me.gbDatosVenta.Controls.Add(Me.lblVenPro)
        Me.gbDatosVenta.Controls.Add(Me.cbClientes)
        Me.gbDatosVenta.Controls.Add(Me.cbEmpleados)
        Me.gbDatosVenta.Controls.Add(Me.cbProductos)
        Me.gbDatosVenta.Controls.Add(Me.dtpFecha)
        Me.gbDatosVenta.Location = New System.Drawing.Point(12, 12)
        Me.gbDatosVenta.Name = "gbDatosVenta"
        Me.gbDatosVenta.Size = New System.Drawing.Size(463, 177)
        Me.gbDatosVenta.TabIndex = 7
        Me.gbDatosVenta.TabStop = False
        Me.gbDatosVenta.Text = "Especificaciones de la Venta"
        '
        'lblVenFech
        '
        Me.lblVenFech.AutoSize = True
        Me.lblVenFech.Location = New System.Drawing.Point(12, 127)
        Me.lblVenFech.Name = "lblVenFech"
        Me.lblVenFech.Size = New System.Drawing.Size(46, 16)
        Me.lblVenFech.TabIndex = 10
        Me.lblVenFech.Text = "Fecha"
        '
        'lblVenCli
        '
        Me.lblVenCli.AutoSize = True
        Me.lblVenCli.Location = New System.Drawing.Point(12, 51)
        Me.lblVenCli.Name = "lblVenCli"
        Me.lblVenCli.Size = New System.Drawing.Size(49, 16)
        Me.lblVenCli.TabIndex = 7
        Me.lblVenCli.Text = "Cliente"
        '
        'lblVenEmp
        '
        Me.lblVenEmp.AutoSize = True
        Me.lblVenEmp.Location = New System.Drawing.Point(168, 51)
        Me.lblVenEmp.Name = "lblVenEmp"
        Me.lblVenEmp.Size = New System.Drawing.Size(71, 16)
        Me.lblVenEmp.TabIndex = 8
        Me.lblVenEmp.Text = "Empleado"
        '
        'lblVenPro
        '
        Me.lblVenPro.AutoSize = True
        Me.lblVenPro.Location = New System.Drawing.Point(325, 51)
        Me.lblVenPro.Name = "lblVenPro"
        Me.lblVenPro.Size = New System.Drawing.Size(62, 16)
        Me.lblVenPro.TabIndex = 9
        Me.lblVenPro.Text = "Producto"
        '
        'cbClientes
        '
        Me.cbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbClientes.FormattingEnabled = True
        Me.cbClientes.Location = New System.Drawing.Point(15, 77)
        Me.cbClientes.Name = "cbClientes"
        Me.cbClientes.Size = New System.Drawing.Size(121, 24)
        Me.cbClientes.TabIndex = 0
        '
        'cbEmpleados
        '
        Me.cbEmpleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEmpleados.FormattingEnabled = True
        Me.cbEmpleados.Location = New System.Drawing.Point(171, 77)
        Me.cbEmpleados.Name = "cbEmpleados"
        Me.cbEmpleados.Size = New System.Drawing.Size(121, 24)
        Me.cbEmpleados.TabIndex = 1
        '
        'cbProductos
        '
        Me.cbProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProductos.FormattingEnabled = True
        Me.cbProductos.Location = New System.Drawing.Point(327, 77)
        Me.cbProductos.Name = "cbProductos"
        Me.cbProductos.Size = New System.Drawing.Size(121, 24)
        Me.cbProductos.TabIndex = 2
        '
        'dtpFecha
        '
        Me.dtpFecha.Location = New System.Drawing.Point(75, 122)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(373, 22)
        Me.dtpFecha.TabIndex = 3
        '
        'cmdVolver2
        '
        Me.cmdVolver2.Location = New System.Drawing.Point(28, 210)
        Me.cmdVolver2.Name = "cmdVolver2"
        Me.cmdVolver2.Size = New System.Drawing.Size(121, 25)
        Me.cmdVolver2.TabIndex = 8
        Me.cmdVolver2.Text = "Volver"
        Me.cmdVolver2.UseVisualStyleBackColor = True
        '
        'cmdCargarVenta
        '
        Me.cmdCargarVenta.Location = New System.Drawing.Point(340, 210)
        Me.cmdCargarVenta.Name = "cmdCargarVenta"
        Me.cmdCargarVenta.Size = New System.Drawing.Size(121, 25)
        Me.cmdCargarVenta.TabIndex = 9
        Me.cmdCargarVenta.Text = "Cargar Venta"
        Me.cmdCargarVenta.UseVisualStyleBackColor = True
        '
        'FrmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.ClientSize = New System.Drawing.Size(487, 254)
        Me.Controls.Add(Me.cmdCargarVenta)
        Me.Controls.Add(Me.cmdVolver2)
        Me.Controls.Add(Me.gbDatosVenta)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmVentas"
        Me.Text = "Los Misioneros Maderas - Cargar Ventas"
        Me.gbDatosVenta.ResumeLayout(False)
        Me.gbDatosVenta.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbDatosVenta As GroupBox
    Friend WithEvents lblVenFech As Label
    Friend WithEvents lblVenCli As Label
    Friend WithEvents lblVenEmp As Label
    Friend WithEvents lblVenPro As Label
    Friend WithEvents cbClientes As ComboBox
    Friend WithEvents cbEmpleados As ComboBox
    Friend WithEvents cbProductos As ComboBox
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents cmdVolver2 As Button
    Friend WithEvents cmdCargarVenta As Button
End Class
