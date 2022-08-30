<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultarVentas
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbEmpleadosCV = New System.Windows.Forms.ComboBox()
        Me.cmdConsultarVentas = New System.Windows.Forms.Button()
        Me.dtpFechaCV = New System.Windows.Forms.DateTimePicker()
        Me.dgvGrillaCV = New System.Windows.Forms.DataGridView()
        Me.cmdVolver3 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvGrillaCV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Violet
        Me.GroupBox1.Controls.Add(Me.cbEmpleadosCV)
        Me.GroupBox1.Controls.Add(Me.cmdConsultarVentas)
        Me.GroupBox1.Controls.Add(Me.dtpFechaCV)
        Me.GroupBox1.Location = New System.Drawing.Point(132, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(301, 186)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Consultar Ventas por Empleado y Fecha"
        '
        'cbEmpleadosCV
        '
        Me.cbEmpleadosCV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEmpleadosCV.FormattingEnabled = True
        Me.cbEmpleadosCV.Location = New System.Drawing.Point(13, 47)
        Me.cbEmpleadosCV.Name = "cbEmpleadosCV"
        Me.cbEmpleadosCV.Size = New System.Drawing.Size(274, 24)
        Me.cbEmpleadosCV.TabIndex = 0
        '
        'cmdConsultarVentas
        '
        Me.cmdConsultarVentas.Location = New System.Drawing.Point(76, 137)
        Me.cmdConsultarVentas.Name = "cmdConsultarVentas"
        Me.cmdConsultarVentas.Size = New System.Drawing.Size(149, 25)
        Me.cmdConsultarVentas.TabIndex = 2
        Me.cmdConsultarVentas.Text = "Consultar Ventas"
        Me.cmdConsultarVentas.UseVisualStyleBackColor = True
        '
        'dtpFechaCV
        '
        Me.dtpFechaCV.Location = New System.Drawing.Point(13, 92)
        Me.dtpFechaCV.Name = "dtpFechaCV"
        Me.dtpFechaCV.Size = New System.Drawing.Size(274, 22)
        Me.dtpFechaCV.TabIndex = 1
        '
        'dgvGrillaCV
        '
        Me.dgvGrillaCV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGrillaCV.Location = New System.Drawing.Point(12, 223)
        Me.dgvGrillaCV.Name = "dgvGrillaCV"
        Me.dgvGrillaCV.Size = New System.Drawing.Size(540, 186)
        Me.dgvGrillaCV.TabIndex = 7
        '
        'cmdVolver3
        '
        Me.cmdVolver3.Location = New System.Drawing.Point(208, 434)
        Me.cmdVolver3.Name = "cmdVolver3"
        Me.cmdVolver3.Size = New System.Drawing.Size(149, 25)
        Me.cmdVolver3.TabIndex = 8
        Me.cmdVolver3.Text = "Volver"
        Me.cmdVolver3.UseVisualStyleBackColor = True
        '
        'FrmConsultarVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.ClientSize = New System.Drawing.Size(564, 480)
        Me.Controls.Add(Me.cmdVolver3)
        Me.Controls.Add(Me.dgvGrillaCV)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmConsultarVentas"
        Me.Text = "Los Misioneros Maderas - Consultar Ventas"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvGrillaCV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbEmpleadosCV As ComboBox
    Friend WithEvents cmdConsultarVentas As Button
    Friend WithEvents dtpFechaCV As DateTimePicker
    Friend WithEvents dgvGrillaCV As DataGridView
    Friend WithEvents cmdVolver3 As Button
End Class
