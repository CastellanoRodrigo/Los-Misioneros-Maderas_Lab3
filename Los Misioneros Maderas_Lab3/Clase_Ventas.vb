Imports System.Data.OleDb

Public Class Clase_Ventas

    Dim Cadena_Config = Base_de_Datos.Cadena_Conexión
    Dim Conex As New OleDbConnection(Cadena_Config)
    Dim Comando As New OleDbCommand
    Dim Data_Adapt As New OleDbDataAdapter(Comando)
    Dim Data_Set As New DataSet

    Public IdProducto As Integer
    Public IdCliente As Integer
    Public IdEmpleado As Integer
    Public FechaVenta As Date

    Public Elegir_Empleado As Integer
    Public Elegir_Fecha As Date

    Public txt_picBox As Graphics
    Public bmp As Bitmap
    Public Fecha_Mínima As Date
    Public Fecha_Máxima As Date

    Dim Tabla As New DataTable

    Public Sub GetDatos_BD_Ventas()

        Comando.Connection = Conex
        Comando.CommandType = CommandType.TableDirect
        Comando.CommandText = "Ventas"

        Conex.Open()
        Data_Adapt.Fill(Data_Set, "Ventas")
        Conex.Close()

    End Sub

    Public Sub New()
        Comando.Connection = Conex
        Comando.CommandType = CommandType.TableDirect
        Comando.CommandText = "Ventas"
        Data_Adapt.Fill(Tabla)
        Dim VDC(1) As DataColumn
        VDC(0) = Tabla.Columns("IdVenta")
        Tabla.PrimaryKey = VDC
    End Sub

    Public Sub Cargar_Nueva_Venta()
        Try
            Dim NuevoRegistro As DataRow = Data_Set.Tables("Ventas").NewRow

            NuevoRegistro("IdProducto") = IdProducto
            NuevoRegistro("IdCliente") = IdCliente
            NuevoRegistro("IdEmpleado") = IdEmpleado
            NuevoRegistro("FechaVenta") = FechaVenta

            Data_Set.Tables("Ventas").Rows.Add(NuevoRegistro)

            Dim CB As New OleDbCommandBuilder(Data_Adapt)
            Data_Adapt.Update(Data_Set, "Ventas")

            MsgBox("Los datos se han cargado con éxito")

        Catch Er As Exception
            MsgBox("Error: " & vbCrLf & Er.Message & MsgBoxStyle.Critical, MsgBoxStyle.OkOnly, "Operacion interrumpida")
        End Try
    End Sub

    Public Sub ResetearValores_VENT()
        FrmVentas.cbClientes.SelectedIndex = -1
        FrmVentas.cbEmpleados.SelectedIndex = -1
        FrmVentas.cbProductos.SelectedIndex = -1
        FrmVentas.cbClientes.Focus()
    End Sub

    Public Sub Consultar_Ventas(ByRef Grilla As DataGridView)

        Dim Buscar As String
        Dim Lista As Integer

        Grilla.Columns.Clear()

        Try

            If Elegir_Empleado > 0 Then

                If Elegir_Fecha <> Nothing Then

                    Buscar = "Select IdVenta, IdProducto,IdCliente, IdEmpleado, FechaVenta FROM Ventas WHERE IdEmpleado =" & Elegir_Empleado & "AND FechaVenta =#" & Elegir_Fecha & "#"
                    Data_Adapt = New OleDbDataAdapter(Buscar, Conex)
                    Data_Set = New DataSet
                    Data_Adapt.Fill(Data_Set, "Ventas")
                    Lista = Data_Set.Tables("Ventas").Rows.Count

                    If Lista <> 0 Then

                        With Grilla
                            .DataSource = Data_Set
                            .DataMember = "Ventas"

                            .Columns(0).HeaderText = "ID_Venta"
                            .Columns(1).HeaderText = "ID_Producto"
                            .Columns(2).HeaderText = "ID_Cliente"
                            .Columns(3).HeaderText = "ID_Empleado"
                            .Columns(4).HeaderText = "Fecha"

                            .BorderStyle = BorderStyle.Fixed3D

                        End With

                        For Each fila As DataRow In Data_Set.Tables("Ventas").Rows

                        Next

                    Else

                        MsgBox("No existen Registros")

                    End If

                End If

            End If

        Catch Er As Exception
            MessageBox.Show(Er.Message, "Error - Ejecución interrumpida")

        End Try

    End Sub

    Public Sub Calcular_Rep_Ventas(ByRef PictureBox As PictureBox)

        Dim Data_Read As OleDbDataReader
        Dim Consulta_Rep As String

        Try
            Data_Set = New DataSet
            Consulta_Rep = "SELECT DateValue([FechaVenta]) AS Fecha, Count(Ventas.FechaVenta) AS _Ventas FROM(Ventas) GROUP BY DateValue([FechaVenta])"
            Comando.CommandText = Consulta_Rep

            Conex.Open()
            Data_Read = Comando.ExecuteReader

            Dim f As Integer = 5

            Do While Data_Read.Read

                txt_picBox = Graphics.FromImage(bmp)

                Dim Font As New Font("Segoe UI", 12)
                Dim Brush As New SolidBrush(Color.Black)
                Dim Point As New Point(30, f)

                txt_picBox.DrawString(Data_Read("Fecha") & "              " & Data_Read("_Ventas") & "     Ventas", Font, Brush, Point)

                If f = 5 Then
                    Fecha_Mínima = Data_Read("Fecha")
                Else
                    Fecha_Máxima = Data_Read("Fecha")
                End If

                f = f + 20

            Loop

        Catch Er As Exception
            MessageBox.Show(Er.Message)

        End Try

        Conex.Close()
        PictureBox.Image = bmp
        FrmReportes.lblFechaMinMax.Text = "Desde: " & Fecha_Mínima & " ----- Hasta: " & Fecha_Máxima

    End Sub

    Public Function Obtener() As DataTable

        Return Tabla

    End Function

End Class
