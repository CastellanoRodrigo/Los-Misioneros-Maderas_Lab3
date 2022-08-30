<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReportes
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
        Me.picReporte = New System.Windows.Forms.PictureBox()
        Me.cmdCalcularRep = New System.Windows.Forms.Button()
        Me.cmdImprimirRep = New System.Windows.Forms.Button()
        Me.cmdVolver6 = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.lblFechaMinMax = New System.Windows.Forms.Label()
        CType(Me.picReporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picReporte
        '
        Me.picReporte.BackColor = System.Drawing.Color.LightCyan
        Me.picReporte.Location = New System.Drawing.Point(24, 39)
        Me.picReporte.Name = "picReporte"
        Me.picReporte.Size = New System.Drawing.Size(330, 228)
        Me.picReporte.TabIndex = 0
        Me.picReporte.TabStop = False
        '
        'cmdCalcularRep
        '
        Me.cmdCalcularRep.Location = New System.Drawing.Point(24, 291)
        Me.cmdCalcularRep.Name = "cmdCalcularRep"
        Me.cmdCalcularRep.Size = New System.Drawing.Size(75, 25)
        Me.cmdCalcularRep.TabIndex = 1
        Me.cmdCalcularRep.Text = "Calcular"
        Me.cmdCalcularRep.UseVisualStyleBackColor = True
        '
        'cmdImprimirRep
        '
        Me.cmdImprimirRep.Location = New System.Drawing.Point(279, 291)
        Me.cmdImprimirRep.Name = "cmdImprimirRep"
        Me.cmdImprimirRep.Size = New System.Drawing.Size(75, 25)
        Me.cmdImprimirRep.TabIndex = 2
        Me.cmdImprimirRep.Text = "Imprimir"
        Me.cmdImprimirRep.UseVisualStyleBackColor = True
        '
        'cmdVolver6
        '
        Me.cmdVolver6.Location = New System.Drawing.Point(152, 291)
        Me.cmdVolver6.Name = "cmdVolver6"
        Me.cmdVolver6.Size = New System.Drawing.Size(75, 25)
        Me.cmdVolver6.TabIndex = 3
        Me.cmdVolver6.Text = "Volver"
        Me.cmdVolver6.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'lblFechaMinMax
        '
        Me.lblFechaMinMax.AutoSize = True
        Me.lblFechaMinMax.BackColor = System.Drawing.Color.White
        Me.lblFechaMinMax.ForeColor = System.Drawing.Color.Red
        Me.lblFechaMinMax.Location = New System.Drawing.Point(21, 9)
        Me.lblFechaMinMax.Name = "lblFechaMinMax"
        Me.lblFechaMinMax.Size = New System.Drawing.Size(0, 16)
        Me.lblFechaMinMax.TabIndex = 4
        '
        'FrmReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.ClientSize = New System.Drawing.Size(379, 328)
        Me.Controls.Add(Me.lblFechaMinMax)
        Me.Controls.Add(Me.cmdVolver6)
        Me.Controls.Add(Me.cmdImprimirRep)
        Me.Controls.Add(Me.cmdCalcularRep)
        Me.Controls.Add(Me.picReporte)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmReportes"
        Me.Text = "Los Misioneros Maderas - Reporte de Ventas"
        CType(Me.picReporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picReporte As PictureBox
    Friend WithEvents cmdCalcularRep As Button
    Friend WithEvents cmdImprimirRep As Button
    Friend WithEvents cmdVolver6 As Button
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents lblFechaMinMax As Label
End Class
