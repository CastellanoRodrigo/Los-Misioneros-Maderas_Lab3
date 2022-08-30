Public Class FrmProductos
    Private Sub FrmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub cmdCargarProducto_Click(sender As Object, e As EventArgs) Handles cmdCargarProducto.Click

        'ResetearValores_PROD()

    End Sub

    Private Sub cmdVolver5_Click(sender As Object, e As EventArgs) Handles cmdVolver5.Click
        Me.Close()
    End Sub

    Private Sub txtNombreProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombreProducto.KeyPress

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

    Private Sub txtValorProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValorProducto.KeyPress

        Dim c As Char = e.KeyChar

        If Not Char.IsDigit(c) Then
            Select Case c

                Case "$"c 'Permite símbolo peso
                Case "."c 'Permite punto
                Case ","c 'Permite coma
                Case Chr(8) 'Permite retroceso

                Case Else
                    e.Handled = True
            End Select
        End If

    End Sub

End Class