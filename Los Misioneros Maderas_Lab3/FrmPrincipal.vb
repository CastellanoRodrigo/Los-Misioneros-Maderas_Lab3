Public Class FrmPrincipal
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub wwwlblLMM_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles wwwlblLMM.LinkClicked

        Me.wwwlblLMM.LinkVisited = True
        System.Diagnostics.Process.Start("https://www.facebook.com/Los-Misioneros-Maderas-121727338561531/")

    End Sub

    Private Sub CargarNuevoClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarNuevoClienteToolStripMenuItem.Click

        FrmClientes.Show()

    End Sub

    Private Sub CargarNuevoEmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarNuevoEmpleadoToolStripMenuItem.Click

        MsgBox("Sección no programada aún, para practicar iré completando lo que le falte a esta aplicación")

        'FrmEmpleados.Show()
    End Sub

    Private Sub CargarNuevoProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarNuevoProductoToolStripMenuItem.Click

        MsgBox("Sección no programada aún, para practicar iré completando lo que le falte a esta aplicación")

        'FrmProductos.Show()
    End Sub

    Private Sub CargarNuevaVentaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CargarNuevaVentaToolStripMenuItem1.Click

        FrmVentas.Show()

    End Sub

    Private Sub ConsultarVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarVentasToolStripMenuItem.Click

        FrmConsultarVentas.Show()

    End Sub

    Private Sub AcercaDeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem1.Click

        MsgBox("Sección en construcción, disculpe las molestias")

    End Sub

    Private Sub ReporteDeVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeVentasToolStripMenuItem.Click

        FrmReportes.Show()

    End Sub

    Private Sub VerÁrbolToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerÁrbolToolStripMenuItem.Click

        FrmÁrbol.Show()

    End Sub

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer_FechaHoraActual_Tick(sender As Object, e As EventArgs) Handles Timer_FechaHoraActual.Tick

        Dim FechaActual As Date = DateTime.Now.ToString("dd/MM/yyyy")
        Dim HoraActual As String = DateTime.Now.ToString("HH:mm:ss")

        SS_lblFechaHora.Text = "Fecha Actual:" & "  " & FechaActual & "                    " & "Hora Actual:" & "  " & HoraActual

    End Sub

End Class
