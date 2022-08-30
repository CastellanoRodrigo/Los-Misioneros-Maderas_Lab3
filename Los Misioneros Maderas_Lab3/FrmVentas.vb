Public Class FrmVentas

    Dim Objeto_Producto As New Clase_Productos
    Dim Objeto_Cliente As New Clase_Clientes
    Dim Objeto_Empleado As New Clase_Empleados
    Dim Objeto_Venta As New Clase_Ventas

    Private Sub FrmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Objeto_Producto.GetDatos_BD_Productos()

        Objeto_Cliente.GetDatos_BD_Clientes()

        Objeto_Empleado.GetDatos_BD_Empleados()

        Objeto_Venta.GetDatos_BD_Ventas()
        Objeto_Venta.FechaVenta = dtpFecha.Value.Date

    End Sub

    Private Sub cmdVolver2_Click(sender As Object, e As EventArgs) Handles cmdVolver2.Click
        Me.Close()
    End Sub

    Private Sub cmdCargarVenta_Click(sender As Object, e As EventArgs) Handles cmdCargarVenta.Click

        Objeto_Producto.Adquirir_ID_Producto()
        Objeto_Venta.IdProducto = Objeto_Producto.ID_Producto

        Objeto_Empleado.Adquirir_ID_Empleado()
        Objeto_Venta.IdEmpleado = Objeto_Empleado.ID_Empleado

        Objeto_Cliente.Adquirir_ID_Cliente()
        Objeto_Venta.IdCliente = Objeto_Cliente.ID_Cliente

        If cbClientes.SelectedIndex <> -1 And cbEmpleados.SelectedIndex <> -1 And cbProductos.SelectedIndex <> -1 Then

            Objeto_Venta.Cargar_Nueva_Venta()

            Objeto_Venta.ResetearValores_VENT()

        Else : MsgBox("Ningún campo debe quedar vacío.")

        End If

    End Sub

    Private Sub cbProductos_DropDown(sender As Object, e As EventArgs) Handles cbProductos.DropDown

        Objeto_Producto.cb_Productos(cbProductos)

    End Sub

    Private Sub cbClientes_DropDown(sender As Object, e As EventArgs) Handles cbClientes.DropDown

        Objeto_Cliente.cb_Clientes(cbClientes)

    End Sub

    Private Sub cbEmpleados_DropDown(sender As Object, e As EventArgs) Handles cbEmpleados.DropDown

        Objeto_Empleado.cb_Empleados(cbEmpleados)

    End Sub

    Private Sub cbProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProductos.SelectedIndexChanged

        Objeto_Producto.Nombre_Producto = cbProductos.Text

    End Sub

    Private Sub cbClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbClientes.SelectedIndexChanged

        Objeto_Cliente.Nombre_Cliente = cbClientes.Text

    End Sub

    Private Sub cbEmpleados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEmpleados.SelectedIndexChanged

        Objeto_Empleado.Nombre_Empleado = cbEmpleados.Text

    End Sub

End Class