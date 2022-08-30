<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargarNuevoClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargarNuevoEmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargarNuevoProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargarNuevaVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargarNuevaVentaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÁrbolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerÁrbolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.wwwlblLMM = New System.Windows.Forms.LinkLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.SS_lblFechaHora = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer_FechaHoraActual = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.EmpleadosToolStripMenuItem, Me.ProductosToolStripMenuItem, Me.CargarNuevaVentaToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.ÁrbolToolStripMenuItem, Me.AcercaDeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(533, 25)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(63, 21)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CargarNuevoClienteToolStripMenuItem})
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(65, 21)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'CargarNuevoClienteToolStripMenuItem
        '
        Me.CargarNuevoClienteToolStripMenuItem.Name = "CargarNuevoClienteToolStripMenuItem"
        Me.CargarNuevoClienteToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.CargarNuevoClienteToolStripMenuItem.Text = "Cargar Nuevo Cliente"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CargarNuevoEmpleadoToolStripMenuItem})
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(85, 21)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'CargarNuevoEmpleadoToolStripMenuItem
        '
        Me.CargarNuevoEmpleadoToolStripMenuItem.Name = "CargarNuevoEmpleadoToolStripMenuItem"
        Me.CargarNuevoEmpleadoToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.CargarNuevoEmpleadoToolStripMenuItem.Text = "Cargar Nuevo Empleado"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CargarNuevoProductoToolStripMenuItem})
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(79, 21)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'CargarNuevoProductoToolStripMenuItem
        '
        Me.CargarNuevoProductoToolStripMenuItem.Name = "CargarNuevoProductoToolStripMenuItem"
        Me.CargarNuevoProductoToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.CargarNuevoProductoToolStripMenuItem.Text = "Cargar Nuevo Producto"
        '
        'CargarNuevaVentaToolStripMenuItem
        '
        Me.CargarNuevaVentaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CargarNuevaVentaToolStripMenuItem1, Me.ConsultarVentasToolStripMenuItem})
        Me.CargarNuevaVentaToolStripMenuItem.Name = "CargarNuevaVentaToolStripMenuItem"
        Me.CargarNuevaVentaToolStripMenuItem.Size = New System.Drawing.Size(52, 21)
        Me.CargarNuevaVentaToolStripMenuItem.Text = "Venta"
        '
        'CargarNuevaVentaToolStripMenuItem1
        '
        Me.CargarNuevaVentaToolStripMenuItem1.Name = "CargarNuevaVentaToolStripMenuItem1"
        Me.CargarNuevaVentaToolStripMenuItem1.Size = New System.Drawing.Size(193, 22)
        Me.CargarNuevaVentaToolStripMenuItem1.Text = "Cargar Nueva Venta"
        '
        'ConsultarVentasToolStripMenuItem
        '
        Me.ConsultarVentasToolStripMenuItem.Name = "ConsultarVentasToolStripMenuItem"
        Me.ConsultarVentasToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.ConsultarVentasToolStripMenuItem.Text = "Consultar Ventas"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReporteDeVentasToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(73, 21)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'ReporteDeVentasToolStripMenuItem
        '
        Me.ReporteDeVentasToolStripMenuItem.Name = "ReporteDeVentasToolStripMenuItem"
        Me.ReporteDeVentasToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.ReporteDeVentasToolStripMenuItem.Text = "Reporte de Ventas"
        '
        'ÁrbolToolStripMenuItem
        '
        Me.ÁrbolToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerÁrbolToolStripMenuItem})
        Me.ÁrbolToolStripMenuItem.Name = "ÁrbolToolStripMenuItem"
        Me.ÁrbolToolStripMenuItem.Size = New System.Drawing.Size(52, 21)
        Me.ÁrbolToolStripMenuItem.Text = "Árbol"
        '
        'VerÁrbolToolStripMenuItem
        '
        Me.VerÁrbolToolStripMenuItem.Name = "VerÁrbolToolStripMenuItem"
        Me.VerÁrbolToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.VerÁrbolToolStripMenuItem.Text = "Ver Árbol de Ventas"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem1})
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(56, 21)
        Me.AcercaDeToolStripMenuItem.Text = "Ayuda"
        '
        'AcercaDeToolStripMenuItem1
        '
        Me.AcercaDeToolStripMenuItem1.Name = "AcercaDeToolStripMenuItem1"
        Me.AcercaDeToolStripMenuItem1.Size = New System.Drawing.Size(283, 22)
        Me.AcercaDeToolStripMenuItem1.Text = "Acerca de Los Misioneros Maderas"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 38)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(509, 99)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'wwwlblLMM
        '
        Me.wwwlblLMM.AutoSize = True
        Me.wwwlblLMM.Location = New System.Drawing.Point(205, 147)
        Me.wwwlblLMM.Name = "wwwlblLMM"
        Me.wwwlblLMM.Size = New System.Drawing.Size(123, 16)
        Me.wwwlblLMM.TabIndex = 27
        Me.wwwlblLMM.TabStop = True
        Me.wwwlblLMM.Text = "Visitar Pagina Web"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SS_lblFechaHora})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 172)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(533, 22)
        Me.StatusStrip1.TabIndex = 28
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'SS_lblFechaHora
        '
        Me.SS_lblFechaHora.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SS_lblFechaHora.Name = "SS_lblFechaHora"
        Me.SS_lblFechaHora.Size = New System.Drawing.Size(518, 17)
        Me.SS_lblFechaHora.Spring = True
        Me.SS_lblFechaHora.Text = "Fecha y Hora en tiempo real"
        '
        'Timer_FechaHoraActual
        '
        Me.Timer_FechaHoraActual.Enabled = True
        Me.Timer_FechaHoraActual.Interval = 1000
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.ClientSize = New System.Drawing.Size(533, 194)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.wwwlblLMM)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmPrincipal"
        Me.Text = "Los Misioneros Maderas - Venta de Maderas en General"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents wwwlblLMM As LinkLabel
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CargarNuevoClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CargarNuevoEmpleadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CargarNuevoProductoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CargarNuevaVentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CargarNuevaVentaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ConsultarVentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteDeVentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents SS_lblFechaHora As ToolStripStatusLabel
    Friend WithEvents ÁrbolToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerÁrbolToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer_FechaHoraActual As Timer
End Class
