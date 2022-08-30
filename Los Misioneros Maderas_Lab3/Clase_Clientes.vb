Imports System.Data.OleDb
Imports System.IO

Public Class Clase_Clientes

    Dim Cadena_Config = Base_de_Datos.Cadena_Conexión
    Dim Conex As New OleDbConnection(Cadena_Config)
    Dim Comando As New OleDbCommand
    Dim Data_Adapt As New OleDbDataAdapter(Comando)
    Dim Data_Set As New DataSet

    Public Nombre As String
    Public Domicilio As String
    Public Teléfono As String

    Public ArchivoTXTMaderas As String

    Public _IdCliente_ As Long
    Public _NombreApellido_ As String
    Public _Domicilio_ As String
    Public _Teléfono_ As String

    Public Nombre_Cliente As String
    Public ID_Cliente As Integer

    Dim Tabla As New DataTable

    Public Sub GetDatos_BD_Clientes()

        Comando.Connection = Conex
        Comando.CommandType = CommandType.TableDirect
        Comando.CommandText = "Clientes"

        Conex.Open()
        Data_Adapt.Fill(Data_Set, "Clientes")
        Conex.Close()

    End Sub

    Public Sub New()
        Comando.Connection = Conex
        Comando.CommandType = CommandType.TableDirect
        Comando.CommandText = "Clientes"
        Data_Adapt.Fill(Tabla)
        Dim VDC(1) As DataColumn
        VDC(0) = Tabla.Columns("IdCliente")
        Tabla.PrimaryKey = VDC
    End Sub

    Public Sub Cargar_Nuevo_Cliente()

        Try

            Dim NuevoRegistro As DataRow = Data_Set.Tables("Clientes").NewRow

            NuevoRegistro("Nombre") = Nombre
            NuevoRegistro("Domicilio") = Domicilio
            NuevoRegistro("Teléfono") = Teléfono

            Data_Set.Tables("Clientes").Rows.Add(NuevoRegistro)

            Dim CB As New OleDbCommandBuilder(Data_Adapt)
            Data_Adapt.Update(Data_Set, "Clientes")

            MsgBox("Los datos se han cargado con éxito")

        Catch Er As Exception

            MsgBox("Se ha producido el siguiente error:" & vbCrLf & Er.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Operación interrumpida")

        End Try

    End Sub

    Public Sub ResetearValores_CLI()
        FrmClientes.txtNombreApellido.Text = ""
        FrmClientes.txtDomicilio.Text = ""
        FrmClientes.txtTeléfono.Text = ""
        FrmClientes.txtNombreApellido.Focus()
    End Sub

    Public Sub VentanaGuardar()

        Dim myStream As Stream
        Dim Ventana_Guardar As New SaveFileDialog()

        Ventana_Guardar.InitialDirectory = "c:\"
        Ventana_Guardar.Filter = "Archivos de Texto (*.txt)|*.txt|Todos los tipos de archivo (*.*)|*.*"
        Ventana_Guardar.FilterIndex = 1
        Ventana_Guardar.RestoreDirectory = True

        Data_Set = New DataSet
        Data_Adapt.Fill(Data_Set, "Clientes")

        If Ventana_Guardar.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

            ArchivoTXTMaderas = Ventana_Guardar.FileName
            myStream = Ventana_Guardar.OpenFile()

            If (myStream IsNot Nothing) Then
                myStream.Close()
            End If

        End If

    End Sub

    Public Sub Crear_Nº_TXT()
        Dim Num As Integer = 0
        Num = FreeFile()
        FileOpen(Num, ArchivoTXTMaderas, OpenMode.Append)
        FileClose()
    End Sub

    Public Sub CopiarClientes_a_TXT()

        For Each Reg As DataRow In Data_Set.Tables("Clientes").Rows

            _IdCliente_ = Reg("IdCliente")
            _NombreApellido_ = Reg("Nombre")
            _Domicilio_ = Reg("Domicilio")
            _Teléfono_ = Reg("Teléfono")

            Dim Num As Integer = 0
            Num = FreeFile()
            FileOpen(Num, ArchivoTXTMaderas, OpenMode.Append)
            WriteLine(Num, _IdCliente_, _NombreApellido_, _Domicilio_, _Teléfono_)

            FileClose(Num)

        Next

    End Sub

    Public Sub cb_Clientes(ByRef cb_Cli As ComboBox)

        cb_Cli.DisplayMember = "Nombre"
        cb_Cli.ValueMember = "IdCliente"
        cb_Cli.DataSource = Data_Set.Tables("Clientes")

    End Sub

    Public Sub Adquirir_ID_Cliente()

        For Each f As DataRow In Data_Set.Tables("Clientes").Rows
            If f("Nombre") = Nombre_Cliente Then
                ID_Cliente = f("IdCliente")
            End If
        Next

    End Sub

    Public Function Obtener() As DataTable

        Return Tabla

    End Function

End Class
