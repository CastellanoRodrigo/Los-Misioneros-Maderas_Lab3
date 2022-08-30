<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProductos
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
        Me.gbDatosProducto = New System.Windows.Forms.GroupBox()
        Me.cmdCargarProducto = New System.Windows.Forms.Button()
        Me.txtValorProducto = New System.Windows.Forms.TextBox()
        Me.txtNombreProducto = New System.Windows.Forms.TextBox()
        Me.lblValorProducto = New System.Windows.Forms.Label()
        Me.lblNombreProducto = New System.Windows.Forms.Label()
        Me.cmdVolver5 = New System.Windows.Forms.Button()
        Me.gbDatosProducto.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbDatosProducto
        '
        Me.gbDatosProducto.Controls.Add(Me.cmdCargarProducto)
        Me.gbDatosProducto.Controls.Add(Me.txtValorProducto)
        Me.gbDatosProducto.Controls.Add(Me.txtNombreProducto)
        Me.gbDatosProducto.Controls.Add(Me.lblValorProducto)
        Me.gbDatosProducto.Controls.Add(Me.lblNombreProducto)
        Me.gbDatosProducto.Location = New System.Drawing.Point(37, 36)
        Me.gbDatosProducto.Name = "gbDatosProducto"
        Me.gbDatosProducto.Size = New System.Drawing.Size(293, 156)
        Me.gbDatosProducto.TabIndex = 1
        Me.gbDatosProducto.TabStop = False
        Me.gbDatosProducto.Text = "Datos del Producto"
        '
        'cmdCargarProducto
        '
        Me.cmdCargarProducto.Location = New System.Drawing.Point(88, 113)
        Me.cmdCargarProducto.Name = "cmdCargarProducto"
        Me.cmdCargarProducto.Size = New System.Drawing.Size(117, 25)
        Me.cmdCargarProducto.TabIndex = 4
        Me.cmdCargarProducto.Text = "Cargar Producto"
        Me.cmdCargarProducto.UseVisualStyleBackColor = True
        '
        'txtValorProducto
        '
        Me.txtValorProducto.Location = New System.Drawing.Point(91, 73)
        Me.txtValorProducto.Name = "txtValorProducto"
        Me.txtValorProducto.Size = New System.Drawing.Size(185, 22)
        Me.txtValorProducto.TabIndex = 3
        '
        'txtNombreProducto
        '
        Me.txtNombreProducto.Location = New System.Drawing.Point(91, 35)
        Me.txtNombreProducto.Name = "txtNombreProducto"
        Me.txtNombreProducto.Size = New System.Drawing.Size(185, 22)
        Me.txtNombreProducto.TabIndex = 2
        '
        'lblValorProducto
        '
        Me.lblValorProducto.AutoSize = True
        Me.lblValorProducto.Location = New System.Drawing.Point(12, 76)
        Me.lblValorProducto.Name = "lblValorProducto"
        Me.lblValorProducto.Size = New System.Drawing.Size(64, 16)
        Me.lblValorProducto.TabIndex = 1
        Me.lblValorProducto.Text = "Valor   ($)"
        '
        'lblNombreProducto
        '
        Me.lblNombreProducto.AutoSize = True
        Me.lblNombreProducto.Location = New System.Drawing.Point(12, 38)
        Me.lblNombreProducto.Name = "lblNombreProducto"
        Me.lblNombreProducto.Size = New System.Drawing.Size(57, 16)
        Me.lblNombreProducto.TabIndex = 0
        Me.lblNombreProducto.Text = "Nombre"
        '
        'cmdVolver5
        '
        Me.cmdVolver5.Location = New System.Drawing.Point(146, 209)
        Me.cmdVolver5.Name = "cmdVolver5"
        Me.cmdVolver5.Size = New System.Drawing.Size(75, 25)
        Me.cmdVolver5.TabIndex = 6
        Me.cmdVolver5.Text = "Volver"
        Me.cmdVolver5.UseVisualStyleBackColor = True
        '
        'FrmProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 249)
        Me.Controls.Add(Me.cmdVolver5)
        Me.Controls.Add(Me.gbDatosProducto)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmProductos"
        Me.Text = "Los Misioneros Maderas - Añadir Producto"
        Me.gbDatosProducto.ResumeLayout(False)
        Me.gbDatosProducto.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbDatosProducto As GroupBox
    Friend WithEvents cmdCargarProducto As Button
    Friend WithEvents txtValorProducto As TextBox
    Friend WithEvents txtNombreProducto As TextBox
    Friend WithEvents lblValorProducto As Label
    Friend WithEvents lblNombreProducto As Label
    Friend WithEvents cmdVolver5 As Button
End Class
