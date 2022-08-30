Imports System.Data.OleDb

Public Class Clase_Productos

    Dim Cadena_Config = Base_de_Datos.Cadena_Conexión
    Dim Conex As New OleDbConnection(Cadena_Config)
    Dim Comando As New OleDbCommand
    Dim Data_Adapt As New OleDbDataAdapter(Comando)
    Dim Data_Set As New DataSet

    Public Nombre_Producto As String
    Public ID_Producto As Integer

    Dim Tabla As New DataTable

    Public Sub GetDatos_BD_Productos()

        Comando.Connection = Conex
        Comando.CommandType = CommandType.TableDirect
        Comando.CommandText = "Productos"

        Conex.Open()
        Data_Adapt.Fill(Data_Set, "Productos")
        Conex.Close()

    End Sub

    Public Sub New()
        Comando.Connection = Conex
        Comando.CommandType = CommandType.TableDirect
        Comando.CommandText = "Productos"
        Data_Adapt.Fill(Tabla)
        Dim VDC(1) As DataColumn
        VDC(0) = Tabla.Columns("Id_Producto")
        Tabla.PrimaryKey = VDC
    End Sub

    Public Sub Cargar_Nuevo_Producto()



    End Sub

    Public Sub ResetearValores_PROD()
        FrmProductos.txtNombreProducto.Text = ""
        FrmProductos.txtValorProducto.Text = ""
        FrmProductos.txtNombreProducto.Focus()
    End Sub

    Public Sub cb_Productos(ByRef cb_Productos As ComboBox)
        cb_Productos.DisplayMember = "NombreProducto"
        cb_Productos.ValueMember = "IdProducto"
        cb_Productos.DataSource = Data_Set.Tables("Productos")
    End Sub

    Public Sub Adquirir_ID_Producto()
        For Each f As DataRow In Data_Set.Tables("Productos").Rows
            If f("NombreProducto") = Nombre_Producto Then
                ID_Producto = f("IdProducto")
            End If
        Next
    End Sub

    Public Function Obtener() As DataTable

        Return Tabla

    End Function

End Class
