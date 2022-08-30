Public Class FrmClientes
    Dim CLI As New Clase_Clientes

    Private Sub FrmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            CLI.GetDatos_BD_Clientes()

        Catch Er As Exception
            MessageBox.Show(Er.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop)

        End Try

    End Sub

    Private Sub cmdCargarCliente_Click(sender As Object, e As EventArgs) Handles cmdCargarCliente.Click

        If (txtNombreApellido.Text <> "" And txtDomicilio.Text <> "" And txtTeléfono.Text <> "") Then

            CLI.Cargar_Nuevo_Cliente()

            CLI.ResetearValores_CLI()

        Else : MsgBox("Ningún campo debe quedar vacío.")
        End If

    End Sub

    Private Sub cmdTablaClientes_a_TXT_Click(sender As Object, e As EventArgs) Handles cmdTablaClientes_a_TXT.Click

        Try

            CLI.VentanaGuardar()

            CLI.Crear_Nº_TXT()

            CLI.CopiarClientes_a_TXT()

            MsgBox("El Archivo se guardó con éxito")

        Catch Er As Exception
            MessageBox.Show(Er.Message, "Error - Ejecución interrumpida")

        End Try

    End Sub

    Private Sub cmdVolver_Click(sender As Object, e As EventArgs) Handles cmdVolver.Click

        Me.Close()

    End Sub

    Private Sub txtNombreApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombreApellido.KeyPress

        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub txtTeléfono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTeléfono.KeyPress

        Dim c As Char = e.KeyChar

        If Not Char.IsDigit(c) Then
            Select Case c

                Case "-"c 'Permite guiones
                Case Chr(8) 'Permite retroceso
                Case Chr(32) 'Permite espacios
                Case Chr(43) 'Permite el + para código de país

                Case Else
                    e.Handled = True
            End Select
        End If

    End Sub

    Private Sub txtNombreApellido_TextChanged(sender As Object, e As EventArgs) Handles txtNombreApellido.TextChanged

        CLI.Nombre = txtNombreApellido.Text

    End Sub

    Private Sub txtDomicilio_TextChanged(sender As Object, e As EventArgs) Handles txtDomicilio.TextChanged

        CLI.Domicilio = txtDomicilio.Text

    End Sub

    Private Sub txtTeléfono_TextChanged(sender As Object, e As EventArgs) Handles txtTeléfono.TextChanged

        CLI.Teléfono = txtTeléfono.Text

    End Sub


End Class