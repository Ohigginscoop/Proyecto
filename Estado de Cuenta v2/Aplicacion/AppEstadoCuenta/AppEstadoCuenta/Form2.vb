
Imports System.Drawing.Printing
Imports System.Drawing.Printing.PrintDocument
Imports System.IO



Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports iTextSharp.text
Imports Microsoft.VisualBasic




Public Class FrmEstadoCuenta

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    'Private Sub ImprimirEstado(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
    '    Dim bm As Bitmap(PnlEstadoCuenta.Width, PnlEstadoCuenta.height)

    '    PnlEstadoCuenta.DrawToBitmap(bm, New Rectangle(0, 0, PnlEstadoCuenta.Width, PnlEstadoCuenta.Height))
    'End Sub


    Private Sub ImprimirEstado(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(Me.PnlEstadoCuenta.Width, Me.PnlEstadoCuenta.Height)

        PnlEstadoCuenta.DrawToBitmap(bm, New System.Drawing.Rectangle(0, 0, PnlEstadoCuenta.Width, PnlEstadoCuenta.Height))
        e.Graphics.DrawImage(bm, 0, 0)
    End Sub

    Public Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'Original
        'PrintPreviewDialog1.ShowDialog()

        'PrintDocPDF

        Dim auxPaso As String

        auxPaso = ""
        auxPaso = "Estado Cuenta " & Microsoft.VisualBasic.Strings.Right("00000000" & LblRut.Text, 8) & "-" & Microsoft.VisualBasic.Strings.Right("000000" & LblCredito.Text, 8)

        'Parametros impresion PDF Windows
        With PrintDocumentPDF
            .PrinterSettings.PrinterName = "Microsoft Print to PDF"
            .PrinterSettings.PrintToFile = True

            'Variable Public directory As String
            directory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)

            'Variable Public filename as string
            fileName = auxPaso & ".pdf"
            .PrinterSettings.PrintFileName = Path.Combine(directory, fileName)

            .Print()
        End With

    End Sub

    Private Sub FrmEstadoCuenta_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LimpiarEstadoCuenta()
        CargarDatosEstadoCuenta()
    End Sub


    Private Sub BtnPDF_Click(sender As System.Object, e As System.EventArgs) Handles BtnPDF.Click

        Dim doc As New PrintDocument

        doc.PrinterSettings.PrinterName = "Microsoft Print to PDF"

        doc.PrinterSettings.PrintToFile = True

        Dim directory As String

        directory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)

        Dim fileName As String

        fileName = "MyOutputDocument.pdf"

        doc.PrinterSettings.PrintFileName = Path.Combine(directory, fileName)

        'Pagina a imprimir
        Dim bm As New Bitmap(Me.PnlEstadoCuenta.Width, Me.PnlEstadoCuenta.Height)
        'Dim ep As Printing.PrintPageEventArgs

        PnlEstadoCuenta.DrawToBitmap(bm, New System.Drawing.Rectangle(0, 0, PnlEstadoCuenta.Width, PnlEstadoCuenta.Height))
        'ep.Graphics.DrawImage(bm, 0, 0)

        'doc.p()
        'pagina()
        

        doc.Print()

    End Sub

    ''Generar PDF
    'Dim SaveFileDialog As New SaveFileDialog
    'Dim Ruta As String

    'With SaveFileDialog
    '    .Title = "Guardar"
    '    .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments

    '    .Filter = "Archivos pdf (*.pdf)|*.pdf"

    '    .FileName = "Archivo"
    '    .OverwritePrompt = True
    '    .CheckPathExists = True
    'End With

    'If SaveFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
    '    Ruta = SaveFileDialog.FileName
    'Else
    '    Ruta = String.Empty
    '    Exit Sub
    'End If


    ' ''Genera el archivo en PDF
    ''Try
    ''    'Documento
    ''    Dim document As New iTextSharp.text.Document(pageSize:=)

    ''    'Configuracion de la hoja
    ''    HtmlDocument.

    ''Catch ex As Exception

    ''End Try

    Private Sub PrintPreviewDialog1_Load(sender As System.Object, e As System.EventArgs) Handles PrintPreviewDialog1.Load

    End Sub

    Private Sub PrintDocument2_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs)

    End Sub

    Private Sub Imprimir_PDF(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocumentPDF.PrintPage
        Dim bm As New Bitmap(Me.PnlEstadoCuenta.Width, Me.PnlEstadoCuenta.Height)

        PnlEstadoCuenta.DrawToBitmap(bm, New System.Drawing.Rectangle(0, 0, PnlEstadoCuenta.Width, PnlEstadoCuenta.Height))
        e.Graphics.DrawImage(bm, 0, 0)
    End Sub

    Private Sub Imprimir_PDF()
        Throw New NotImplementedException
    End Sub

    Private Sub Label10_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Label11_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Label1_Click_1(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub PnlEstadoCuenta_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles PnlEstadoCuenta.Paint

    End Sub

    Private Sub LblValor1_Click(sender As System.Object, e As System.EventArgs) Handles LblValor1.Click

    End Sub

    Private Sub LblFechaProximoVencimiento1_Click(sender As System.Object, e As System.EventArgs) Handles LblFechaProximoVencimiento1.Click

    End Sub

    Private Sub LblMontoAtraso_Click(sender As System.Object, e As System.EventArgs) Handles LblMontoAtraso.Click

    End Sub

    Private Sub Label8_Click(sender As System.Object, e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub LblCredito_Click(sender As System.Object, e As System.EventArgs) Handles LblCredito.Click

    End Sub
End Class