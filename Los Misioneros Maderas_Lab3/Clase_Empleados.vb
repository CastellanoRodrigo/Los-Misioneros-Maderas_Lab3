Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.IO

Public Class Clase_Empleados

    Dim Cadena_Config = Base_de_Datos.Cadena_Conexión
    Dim Conex As New OleDbConnection(Cadena_Config)
    Dim Comando As New OleDbCommand
    Dim Data_Adapt As New OleDbDataAdapter(Comando)
    Dim Data_Set As New DataSet

    Public Nombre_Empleado As String
    Public ID_Empleado As Integer

    Dim Tabla As New DataTable

    Public Sub GetDatos_BD_Empleados()

        Comando.Connection = Conex
        Comando.CommandType = CommandType.TableDirect
        Comando.CommandText = "Empleados"

        Conex.Open()
        Data_Adapt.Fill(Data_Set, "Empleados")
        Conex.Close()

    End Sub

    Public Sub New()
        Comando.Connection = Conex
        Comando.CommandType = CommandType.TableDirect
        Comando.CommandText = "Empleados"
        Data_Adapt.Fill(Tabla)
        Dim VDC(1) As DataColumn
        VDC(0) = Tabla.Columns("Id_Empleado")
        Tabla.PrimaryKey = VDC
    End Sub

    Public Sub Cargar_Nuevo_Empleado()



    End Sub

    Public Sub ResetearValores_EMP()
        FrmEmpleados.txtNombreApellidoEMP.Text = ""
        FrmEmpleados.txtDomicilioEMP.Text = ""
        FrmEmpleados.txtTeléfonoEMP.Text = ""
        FrmEmpleados.txtNombreApellidoEMP.Focus()
    End Sub

    Public Sub cb_Empleados(ByRef cb_Empleados As ComboBox)
        cb_Empleados.DisplayMember = "Nombre"
        cb_Empleados.ValueMember = "IdEmpleado"
        cb_Empleados.DataSource = Data_Set.Tables("Empleados")
    End Sub

    Public Sub Adquirir_ID_Empleado()
        For Each f As DataRow In Data_Set.Tables("Empleados").Rows
            If f("Nombre") = Nombre_Empleado Then
                ID_Empleado = f("IdEmpleado")
            End If
        Next
    End Sub

    Public Function Obtener() As DataTable

        Return Tabla

    End Function

End Class
