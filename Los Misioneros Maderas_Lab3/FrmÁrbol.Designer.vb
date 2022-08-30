<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmÁrbol
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TreeLMM = New System.Windows.Forms.TreeView()
        Me.lstNombreCliente = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmdVolver7 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TreeLMM
        '
        Me.TreeLMM.Location = New System.Drawing.Point(12, 12)
        Me.TreeLMM.Name = "TreeLMM"
        Me.TreeLMM.Size = New System.Drawing.Size(237, 306)
        Me.TreeLMM.TabIndex = 0
        '
        'lstNombreCliente
        '
        Me.lstNombreCliente.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lstNombreCliente.Location = New System.Drawing.Point(265, 12)
        Me.lstNombreCliente.Name = "lstNombreCliente"
        Me.lstNombreCliente.Size = New System.Drawing.Size(356, 306)
        Me.lstNombreCliente.TabIndex = 1
        Me.lstNombreCliente.UseCompatibleStateImageBehavior = False
        Me.lstNombreCliente.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Nombre del Cliente"
        Me.ColumnHeader1.Width = 178
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Domicilio"
        Me.ColumnHeader2.Width = 94
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Teléfono"
        Me.ColumnHeader3.Width = 77
        '
        'cmdVolver7
        '
        Me.cmdVolver7.Location = New System.Drawing.Point(278, 334)
        Me.cmdVolver7.Name = "cmdVolver7"
        Me.cmdVolver7.Size = New System.Drawing.Size(75, 25)
        Me.cmdVolver7.TabIndex = 2
        Me.cmdVolver7.Text = "Volver"
        Me.cmdVolver7.UseVisualStyleBackColor = True
        '
        'FrmÁrbol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(630, 373)
        Me.Controls.Add(Me.cmdVolver7)
        Me.Controls.Add(Me.lstNombreCliente)
        Me.Controls.Add(Me.TreeLMM)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmÁrbol"
        Me.Text = "Los Misioneros Maderas - Árbol"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TreeLMM As TreeView
    Friend WithEvents lstNombreCliente As ListView
    Friend WithEvents cmdVolver7 As Button
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
End Class
