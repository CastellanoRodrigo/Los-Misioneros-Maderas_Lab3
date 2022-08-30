Imports System.Data.OleDb
Imports System.Drawing.Printing

Public Class FrmReportes

    Dim Obj_Venta_Rep As New Clase_Ventas

    Public prtPrev As New PrintPreviewDialog
    Public WithEvents Documento_a_Imprimir As New Printing.PrintDocument

    Private Sub cmdVolver6_Click(sender As Object, e As EventArgs) Handles cmdVolver6.Click
        Me.Close()
    End Sub

    Private Sub FrmReportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Obj_Venta_Rep.GetDatos_BD_Ventas()

        Obj_Venta_Rep.bmp = New Bitmap(Me.picReporte.Size.Width, Me.picReporte.Size.Height)

        cmdImprimirRep.Enabled = False

    End Sub

    Private Sub cmdCalcularRep_Click(sender As Object, e As EventArgs) Handles cmdCalcularRep.Click

        Obj_Venta_Rep.Calcular_Rep_Ventas(picReporte)

        cmdImprimirRep.Enabled = True

    End Sub

    Private Sub cmdImprimirRep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimirRep.Click

        'instancia el objeto imprimir previa con el documento que contiene los datos de la lista

        prtPrev.Document = Documento_a_Imprimir

        'texto que se muestra antes del resultado
        prtPrev.Text = "Previsualizar Documento"

        'muestra la ventana 
        prtPrev.ShowDialog()

        PrintDialog1.AllowSomePages = True
        PrintDialog1.ShowHelp = True
        PrintDialog1.Document = Documento_a_Imprimir

        'Hablitando las siguientes 4 líneas, se muestran las opciones de la impresora

        'Dim Resultado As DialogResult = PrintDialog1.ShowDialog()
        'If (Resultado = DialogResult.OK) Then
        'Documento_a_Imprimir.Print()
        'End If

    End Sub

    Private Sub document_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles Documento_a_Imprimir.PrintPage

        'Aquí se procede a dibujar la imagen
        e.Graphics.DrawImage(Me.picReporte.Image, 50, 50)

        'Aquí se imprime el contenido
        e.Graphics.DrawString("Desde: " & Obj_Venta_Rep.Fecha_Mínima & "    Hasta: " & Obj_Venta_Rep.Fecha_Máxima, New Font("Segoe UI", 12, FontStyle.Regular), Brushes.Red, New PointF(5, 5))
    End Sub

End Class