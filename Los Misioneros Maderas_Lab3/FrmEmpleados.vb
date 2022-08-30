Public Class FrmEmpleados

    Private Sub FrmEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub cmdCargarEmpleado_Click(sender As Object, e As EventArgs) Handles cmdCargarEmpleado.Click

        'ResetearValores_EMP()

    End Sub



    Private Sub cmdVolver4_Click(sender As Object, e As EventArgs) Handles cmdVolver4.Click
        Me.Close()
    End Sub

    Private Sub txtNombreApellidoEMP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombreApellidoEMP.KeyPress

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

    Private Sub txtTeléfonoEMP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTeléfonoEMP.KeyPress

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

End Class