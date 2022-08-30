Public Class FrmÁrbol

    Dim ObjTree_Ventas As Clase_Ventas
    Dim ObjTree_Productos As Clase_Productos
    Dim ObjTree_Empleados As Clase_Empleados
    Dim ObjTree_Clientes As Clase_Clientes

    Dim Tabla_Ventas As DataTable
    Dim Tabla_Productos As DataTable
    Dim Tabla_Empleados As DataTable
    Dim Tabla_Clientes As DataTable

    Dim Etiqueta As Integer

    Private Sub cmdVolver7_Click(sender As Object, e As EventArgs) Handles cmdVolver7.Click
        Me.Close()
    End Sub

    Private Sub FrmÁrbol_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SubirTablasMemoria()

        CrearÁrbol()

    End Sub

    Public Sub SubirTablasMemoria()

        Try

            ObjTree_Ventas = New Clase_Ventas
            ObjTree_Productos = New Clase_Productos
            ObjTree_Empleados = New Clase_Empleados
            ObjTree_Clientes = New Clase_Clientes

            Tabla_Ventas = ObjTree_Ventas.Obtener
            Tabla_Productos = ObjTree_Productos.Obtener
            Tabla_Empleados = ObjTree_Empleados.Obtener
            Tabla_Clientes = ObjTree_Clientes.Obtener

        Catch Er As Exception
            MsgBox("Hubo un error al obtener los datos ...", "Error")

        End Try

    End Sub

    Public Sub CrearÁrbol()

        Dim Abuelo As TreeNode
        Dim Padre As TreeNode
        Dim Hijo As TreeNode
        Dim Nieto As TreeNode

        Abuelo = TreeLMM.Nodes.Add("Empleados", "Empleados")
        Abuelo.BackColor = Color.LightSteelBlue

        For Each EMP As DataRow In Tabla_Empleados.Rows
            Padre = Abuelo.Nodes.Add(EMP("IdEmpleado"), EMP("Nombre"))
            Padre.Tag = EMP("IdEmpleado")
            Padre.BackColor = Color.LightSalmon

            For Each PROD As DataRow In Tabla_Productos.Rows
                Hijo = Padre.Nodes.Add(PROD("IdProducto"), PROD("NombreProducto"))
                Hijo.Tag = PROD("IdProducto")
                Hijo.BackColor = Color.LightBlue

                For Each VENT As DataRow In Tabla_Ventas.Rows

                    If EMP("IdEmpleado") = VENT("IdEmpleado") Then

                        If PROD("IdProducto") = VENT("IdProducto") Then

                            Nieto = Hijo.Nodes.Add(VENT("IdProducto"), VENT("FechaVenta"))
                            Nieto.Tag = VENT("IdVenta")
                            Nieto.BackColor = Color.Wheat

                        End If

                    End If

                Next

            Next

        Next

    End Sub
    Public Sub MostrarDatos_lst()

        Dim Ítem As ListViewItem

        For Each Reg_Venta As DataRow In Tabla_Ventas.Rows

            If Etiqueta = Reg_Venta("IdVenta") Then

                For Each Cli As DataRow In Tabla_Clientes.Rows

                    If Cli("IdCliente") = Reg_Venta("IdCliente") Then

                        Ítem = lstNombreCliente.Items.Add(Cli("Nombre"))
                        Ítem.SubItems.Add(Cli("Domicilio"))
                        Ítem.SubItems.Add(Cli("Teléfono"))

                    End If

                Next

            End If

        Next

    End Sub

    Private Sub TreeLMM_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeLMM.NodeMouseClick

        Etiqueta = Nothing

        lstNombreCliente.Items.Clear()

        If e.Node.Level = 3 Then

            Etiqueta = e.Node.Tag

            MostrarDatos_lst()

        End If

    End Sub
End Class