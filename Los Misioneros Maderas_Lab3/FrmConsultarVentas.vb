Public Class FrmConsultarVentas

    Dim Obj_Venta As New Clase_Ventas
    Dim Obj_Empleado As New Clase_Empleados

    Private Sub FrmConsultarVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Obj_Venta.GetDatos_BD_Ventas()

        Obj_Empleado.GetDatos_BD_Empleados()

        Obj_Venta.Elegir_Fecha = dtpFechaCV.Value.Date

    End Sub

    Private Sub cmdVolver3_Click(sender As Object, e As EventArgs) Handles cmdVolver3.Click
        Me.Close()
    End Sub

    Private Sub cmdConsultarVentas_Click(sender As Object, e As EventArgs) Handles cmdConsultarVentas.Click

        Obj_Empleado.Adquirir_ID_Empleado()
        Obj_Venta.Elegir_Empleado = Obj_Empleado.ID_Empleado
        Obj_Venta.Elegir_Fecha = dtpFechaCV.Value.Date

        If cbEmpleadosCV.SelectedIndex <> -1 Then

            Obj_Venta.Consultar_Ventas(dgvGrillaCV)

        Else
            MsgBox("Debes elegir un Empleado de la lista")
        End If

    End Sub

    Private Sub cbEmpleadosCV_DropDown(sender As Object, e As EventArgs) Handles cbEmpleadosCV.DropDown

        Obj_Empleado.cb_Empleados(cbEmpleadosCV)

    End Sub

    Private Sub cbEmpleadosCV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEmpleadosCV.SelectedIndexChanged

        Obj_Empleado.Nombre_Empleado = cbEmpleadosCV.Text

    End Sub

End Class