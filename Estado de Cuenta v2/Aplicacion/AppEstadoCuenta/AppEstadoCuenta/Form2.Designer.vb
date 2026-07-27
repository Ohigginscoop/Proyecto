<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEstadoCuenta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEstadoCuenta))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.BtnPDF = New System.Windows.Forms.Button()
        Me.PrintDialogPDF = New System.Windows.Forms.PrintDialog()
        Me.PrintDocumentPDF = New System.Drawing.Printing.PrintDocument()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblMontoProximoVencimiento3 = New System.Windows.Forms.Label()
        Me.LblFechaProximoVencimiento3 = New System.Windows.Forms.Label()
        Me.LblMontoProximoVencimiento2 = New System.Windows.Forms.Label()
        Me.LblFechaProximoVencimiento2 = New System.Windows.Forms.Label()
        Me.LblFechaProximoVencimiento1 = New System.Windows.Forms.Label()
        Me.LblMontoProximoVencimiento1 = New System.Windows.Forms.Label()
        Me.LblVencimiento1 = New System.Windows.Forms.Label()
        Me.LblValor1 = New System.Windows.Forms.Label()
        Me.PnlEstadoCuenta = New System.Windows.Forms.Panel()
        Me.LblGastoCobranza = New System.Windows.Forms.Label()
        Me.LblInteresMonetario = New System.Windows.Forms.Label()
        Me.LblPlazoPrepago = New System.Windows.Forms.Label()
        Me.LblCargoPrepago = New System.Windows.Forms.Label()
        Me.LblProveedorSA2 = New System.Windows.Forms.Label()
        Me.LblCobertura2 = New System.Windows.Forms.Label()
        Me.LblCostoTotal2 = New System.Windows.Forms.Label()
        Me.LblCostoMensual2 = New System.Windows.Forms.Label()
        Me.LblSeguroCesantiaCHUBB = New System.Windows.Forms.Label()
        Me.LblProveedorSA = New System.Windows.Forms.Label()
        Me.LblCobertura = New System.Windows.Forms.Label()
        Me.LblCostoTotal = New System.Windows.Forms.Label()
        Me.LblCostoMensual = New System.Windows.Forms.Label()
        Me.LblCuotaRef = New System.Windows.Forms.Label()
        Me.LblMontoAtraso = New System.Windows.Forms.Label()
        Me.LblMontoCargAtraso = New System.Windows.Forms.Label()
        Me.LblDetalle = New System.Windows.Forms.Label()
        Me.LblMontoVencNoPag = New System.Windows.Forms.Label()
        Me.LblCuotVencidasNoPag = New System.Windows.Forms.Label()
        Me.LblNumCuotasPag = New System.Windows.Forms.Label()
        Me.LblGarVigen = New System.Windows.Forms.Label()
        Me.LblCAEV = New System.Windows.Forms.Label()
        Me.LblCostoTtlPrep = New System.Windows.Forms.Label()
        Me.LblSaldoCred = New System.Windows.Forms.Label()
        Me.LblProximaCuota = New System.Windows.Forms.Label()
        Me.LblRut = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.LblPlazo = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LblCredito = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblFechaEstado = New System.Windows.Forms.Label()
        Me.LblEtiquetaNombre = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label90 = New System.Windows.Forms.Label()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LblDiasAtraso1 = New System.Windows.Forms.Label()
        Me.LblTotal1 = New System.Windows.Forms.Label()
        Me.LblGastos1 = New System.Windows.Forms.Label()
        Me.LblInteres1 = New System.Windows.Forms.Label()
        Me.LblCuota1 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.LblCae = New System.Windows.Forms.Label()
        Me.LblValor6 = New System.Windows.Forms.Label()
        Me.LblValor5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LblTasaInteres = New System.Windows.Forms.Label()
        Me.LblVencimiento7 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblDiasAtraso11 = New System.Windows.Forms.Label()
        Me.LblTotal11 = New System.Windows.Forms.Label()
        Me.LblGastos11 = New System.Windows.Forms.Label()
        Me.LblInteres11 = New System.Windows.Forms.Label()
        Me.LblValor11 = New System.Windows.Forms.Label()
        Me.LblVencimiento11 = New System.Windows.Forms.Label()
        Me.LblCuota11 = New System.Windows.Forms.Label()
        Me.LblTotalAPagar = New System.Windows.Forms.Label()
        Me.LblDiasAtraso10 = New System.Windows.Forms.Label()
        Me.LblDiasAtraso9 = New System.Windows.Forms.Label()
        Me.LblDiasAtraso8 = New System.Windows.Forms.Label()
        Me.LblDiasAtraso7 = New System.Windows.Forms.Label()
        Me.LblDiasAtraso6 = New System.Windows.Forms.Label()
        Me.LblDiasAtraso5 = New System.Windows.Forms.Label()
        Me.LblDiasAtraso4 = New System.Windows.Forms.Label()
        Me.LblDiasAtraso3 = New System.Windows.Forms.Label()
        Me.LblDiasAtraso2 = New System.Windows.Forms.Label()
        Me.LblTotal10 = New System.Windows.Forms.Label()
        Me.LblTotal9 = New System.Windows.Forms.Label()
        Me.LblTotal8 = New System.Windows.Forms.Label()
        Me.LblTotal7 = New System.Windows.Forms.Label()
        Me.LblTotal6 = New System.Windows.Forms.Label()
        Me.LblTotal5 = New System.Windows.Forms.Label()
        Me.LblTotal4 = New System.Windows.Forms.Label()
        Me.LblTotal3 = New System.Windows.Forms.Label()
        Me.LblTotal2 = New System.Windows.Forms.Label()
        Me.LblGastos10 = New System.Windows.Forms.Label()
        Me.LblGastos9 = New System.Windows.Forms.Label()
        Me.LblGastos8 = New System.Windows.Forms.Label()
        Me.LblGastos7 = New System.Windows.Forms.Label()
        Me.LblGastos6 = New System.Windows.Forms.Label()
        Me.LblGastos5 = New System.Windows.Forms.Label()
        Me.LblGastos4 = New System.Windows.Forms.Label()
        Me.LblGastos3 = New System.Windows.Forms.Label()
        Me.LblGastos2 = New System.Windows.Forms.Label()
        Me.LblInteres10 = New System.Windows.Forms.Label()
        Me.LblInteres9 = New System.Windows.Forms.Label()
        Me.LblInteres8 = New System.Windows.Forms.Label()
        Me.LblInteres7 = New System.Windows.Forms.Label()
        Me.LblInteres6 = New System.Windows.Forms.Label()
        Me.LblInteres5 = New System.Windows.Forms.Label()
        Me.LblInteres4 = New System.Windows.Forms.Label()
        Me.LblInteres3 = New System.Windows.Forms.Label()
        Me.LblInteres2 = New System.Windows.Forms.Label()
        Me.LblValor10 = New System.Windows.Forms.Label()
        Me.LblValor9 = New System.Windows.Forms.Label()
        Me.LblValor8 = New System.Windows.Forms.Label()
        Me.LblValor7 = New System.Windows.Forms.Label()
        Me.LblValor4 = New System.Windows.Forms.Label()
        Me.LblValor3 = New System.Windows.Forms.Label()
        Me.LblValor2 = New System.Windows.Forms.Label()
        Me.LblVencimiento10 = New System.Windows.Forms.Label()
        Me.LblVencimiento9 = New System.Windows.Forms.Label()
        Me.LblVencimiento8 = New System.Windows.Forms.Label()
        Me.LblVencimiento6 = New System.Windows.Forms.Label()
        Me.LblVencimiento5 = New System.Windows.Forms.Label()
        Me.LblVencimiento4 = New System.Windows.Forms.Label()
        Me.LblVencimiento3 = New System.Windows.Forms.Label()
        Me.LblVencimiento2 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.LblCuota10 = New System.Windows.Forms.Label()
        Me.LblCuota9 = New System.Windows.Forms.Label()
        Me.LblCuota8 = New System.Windows.Forms.Label()
        Me.LblCuota7 = New System.Windows.Forms.Label()
        Me.LblCuota6 = New System.Windows.Forms.Label()
        Me.LblCuota5 = New System.Windows.Forms.Label()
        Me.LblCuota4 = New System.Windows.Forms.Label()
        Me.LblCuota3 = New System.Windows.Forms.Label()
        Me.LblCuota2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.PnlEstadoCuenta.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1117, 279)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(52, 53)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(1069, 455)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(93, 88)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(1076, 805)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(93, 88)
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Location = New System.Drawing.Point(1076, 713)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(93, 88)
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Location = New System.Drawing.Point(1069, 619)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(93, 88)
        Me.PictureBox5.TabIndex = 7
        Me.PictureBox5.TabStop = False
        '
        'BtnPDF
        '
        Me.BtnPDF.Location = New System.Drawing.Point(1087, 552)
        Me.BtnPDF.Name = "BtnPDF"
        Me.BtnPDF.Size = New System.Drawing.Size(75, 61)
        Me.BtnPDF.TabIndex = 8
        Me.BtnPDF.Text = "PDF"
        Me.BtnPDF.UseVisualStyleBackColor = True
        '
        'PrintDialogPDF
        '
        Me.PrintDialogPDF.UseEXDialog = True
        '
        'PrintDocumentPDF
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(4, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(120, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'LblTitulo
        '
        Me.LblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.Location = New System.Drawing.Point(4, 70)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(761, 20)
        Me.LblTitulo.TabIndex = 3
        Me.LblTitulo.Text = "Comunicación Trimestral Crédito de Consumo"
        Me.LblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblNombre
        '
        Me.LblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.Location = New System.Drawing.Point(130, 27)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(416, 20)
        Me.LblNombre.TabIndex = 4
        Me.LblNombre.Text = "Nombre"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LblMontoProximoVencimiento3)
        Me.GroupBox1.Controls.Add(Me.LblFechaProximoVencimiento3)
        Me.GroupBox1.Controls.Add(Me.LblMontoProximoVencimiento2)
        Me.GroupBox1.Controls.Add(Me.LblFechaProximoVencimiento2)
        Me.GroupBox1.Controls.Add(Me.LblFechaProximoVencimiento1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(50, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(139, 55)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Proximos Vencimientos"
        '
        'LblMontoProximoVencimiento3
        '
        Me.LblMontoProximoVencimiento3.AutoSize = True
        Me.LblMontoProximoVencimiento3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMontoProximoVencimiento3.Location = New System.Drawing.Point(520, 63)
        Me.LblMontoProximoVencimiento3.Name = "LblMontoProximoVencimiento3"
        Me.LblMontoProximoVencimiento3.Size = New System.Drawing.Size(159, 20)
        Me.LblMontoProximoVencimiento3.TabIndex = 10
        Me.LblMontoProximoVencimiento3.Text = "Monto Vencimiento 1"
        '
        'LblFechaProximoVencimiento3
        '
        Me.LblFechaProximoVencimiento3.AutoSize = True
        Me.LblFechaProximoVencimiento3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFechaProximoVencimiento3.Location = New System.Drawing.Point(548, 34)
        Me.LblFechaProximoVencimiento3.Name = "LblFechaProximoVencimiento3"
        Me.LblFechaProximoVencimiento3.Size = New System.Drawing.Size(106, 20)
        Me.LblFechaProximoVencimiento3.TabIndex = 9
        Me.LblFechaProximoVencimiento3.Text = "Vencimiento1"
        '
        'LblMontoProximoVencimiento2
        '
        Me.LblMontoProximoVencimiento2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMontoProximoVencimiento2.Location = New System.Drawing.Point(280, 63)
        Me.LblMontoProximoVencimiento2.Name = "LblMontoProximoVencimiento2"
        Me.LblMontoProximoVencimiento2.Size = New System.Drawing.Size(159, 20)
        Me.LblMontoProximoVencimiento2.TabIndex = 8
        Me.LblMontoProximoVencimiento2.Text = "Monto Vencimiento 1"
        '
        'LblFechaProximoVencimiento2
        '
        Me.LblFechaProximoVencimiento2.AutoSize = True
        Me.LblFechaProximoVencimiento2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFechaProximoVencimiento2.Location = New System.Drawing.Point(302, 34)
        Me.LblFechaProximoVencimiento2.Name = "LblFechaProximoVencimiento2"
        Me.LblFechaProximoVencimiento2.Size = New System.Drawing.Size(106, 20)
        Me.LblFechaProximoVencimiento2.TabIndex = 7
        Me.LblFechaProximoVencimiento2.Text = "Vencimiento1"
        '
        'LblFechaProximoVencimiento1
        '
        Me.LblFechaProximoVencimiento1.AutoSize = True
        Me.LblFechaProximoVencimiento1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFechaProximoVencimiento1.Location = New System.Drawing.Point(811, 137)
        Me.LblFechaProximoVencimiento1.Name = "LblFechaProximoVencimiento1"
        Me.LblFechaProximoVencimiento1.Size = New System.Drawing.Size(106, 20)
        Me.LblFechaProximoVencimiento1.TabIndex = 5
        Me.LblFechaProximoVencimiento1.Text = "Vencimiento1"
        '
        'LblMontoProximoVencimiento1
        '
        Me.LblMontoProximoVencimiento1.AutoSize = True
        Me.LblMontoProximoVencimiento1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMontoProximoVencimiento1.Location = New System.Drawing.Point(-40, 20)
        Me.LblMontoProximoVencimiento1.Name = "LblMontoProximoVencimiento1"
        Me.LblMontoProximoVencimiento1.Size = New System.Drawing.Size(159, 20)
        Me.LblMontoProximoVencimiento1.TabIndex = 6
        Me.LblMontoProximoVencimiento1.Text = "Monto Vencimiento 1"
        '
        'LblVencimiento1
        '
        Me.LblVencimiento1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblVencimiento1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVencimiento1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.LblVencimiento1.Location = New System.Drawing.Point(466, 257)
        Me.LblVencimiento1.Name = "LblVencimiento1"
        Me.LblVencimiento1.Size = New System.Drawing.Size(299, 25)
        Me.LblVencimiento1.TabIndex = 33
        Me.LblVencimiento1.Text = "Cuota1"
        Me.LblVencimiento1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblValor1
        '
        Me.LblValor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblValor1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblValor1.Location = New System.Drawing.Point(466, 232)
        Me.LblValor1.Name = "LblValor1"
        Me.LblValor1.Size = New System.Drawing.Size(299, 25)
        Me.LblValor1.TabIndex = 45
        Me.LblValor1.Text = "Cuota1"
        Me.LblValor1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PnlEstadoCuenta
        '
        Me.PnlEstadoCuenta.Controls.Add(Me.LblGastoCobranza)
        Me.PnlEstadoCuenta.Controls.Add(Me.LblInteresMonetario)
        Me.PnlEstadoCuenta.Controls.Add(Me.LblPlazoPrepago)
        Me.PnlEstadoCuenta.Controls.Add(Me.LblCargoPrepago)
        Me.PnlEstadoCuenta.Controls.Add(Me.LblProveedorSA2)
        Me.PnlEstadoCuenta.Controls.Add(Me.LblCobertura2)
        Me.PnlEstadoCuenta.Controls.Add(Me.LblCostoTotal2)
        Me.PnlEstadoCuenta.Controls.Add(Me.LblCostoMensual2)
        Me.PnlEstadoCuenta.Controls.Add(Me.LblSeguroCesantiaCHUBB)
        Me.PnlEstadoCuenta.Controls.Add(Me.LblProveedorSA)
        Me.PnlEstadoCuenta.Controls.Add(Me.LblCobertura)
        Me.PnlEstadoCuenta.Controls.Add(Me.LblCostoTotal)
        Me.PnlEstadoCuenta.Controls.Add(Me.LblCostoMensual)
        Me.PnlEstadoCuenta.Controls.Add(Me.LblCuotaRef)
        Me.PnlEstadoCuenta.Controls.Add(Me.LblMontoAtraso)
        Me.PnlEstadoCuenta.Controls.Add(Me.LblMontoCargAtraso)
        Me.PnlEstadoCuenta.Controls.Add(Me.LblDetalle)
        Me.PnlEstadoCuenta.Controls.Add(Me.LblMontoVencNoPag)
        Me.PnlEstadoCuenta.Controls.Add(Me.LblCuotVencidasNoPag)
        Me.PnlEstadoCuenta.Controls.Add(Me.LblNumCuotasPag)
        Me.PnlEstadoCuenta.Controls.Add(Me.LblGarVigen)
        Me.PnlEstadoCuenta.Controls.Add(Me.LblCAEV)
        Me.PnlEstadoCuenta.Controls.Add(Me.LblCostoTtlPrep)
        Me.PnlEstadoCuenta.Controls.Add(Me.LblSaldoCred)
        Me.PnlEstadoCuenta.Controls.Add(Me.LblProximaCuota)
        Me.PnlEstadoCuenta.Controls.Add(Me.LblRut)
        Me.PnlEstadoCuenta.Controls.Add(Me.Label41)
        Me.PnlEstadoCuenta.Controls.Add(Me.Label42)
        Me.PnlEstadoCuenta.Controls.Add(Me.Label40)
        Me.PnlEstadoCuenta.Controls.Add(Me.Label38)
        Me.PnlEstadoCuenta.Controls.Add(Me.Label39)
        Me.PnlEstadoCuenta.Controls.Add(Me.Label37)
        Me.PnlEstadoCuenta.Controls.Add(Me.Label33)
        Me.PnlEstadoCuenta.Controls.Add(Me.Label34)
        Me.PnlEstadoCuenta.Controls.Add(Me.Label35)
        Me.PnlEstadoCuenta.Controls.Add(Me.Label24)
        Me.PnlEstadoCuenta.Controls.Add(Me.Label26)
        Me.PnlEstadoCuenta.Controls.Add(Me.Label27)
        Me.PnlEstadoCuenta.Controls.Add(Me.Label28)
        Me.PnlEstadoCuenta.Controls.Add(Me.Label29)
        Me.PnlEstadoCuenta.Controls.Add(Me.Label30)
        Me.PnlEstadoCuenta.Controls.Add(Me.Label31)
        Me.PnlEstadoCuenta.Controls.Add(Me.Label32)
        Me.PnlEstadoCuenta.Controls.Add(Me.Label23)
        Me.PnlEstadoCuenta.Controls.Add(Me.Label15)
        Me.PnlEstadoCuenta.Controls.Add(Me.Label16)
        Me.PnlEstadoCuenta.Controls.Add(Me.Label17)
        Me.PnlEstadoCuenta.Controls.Add(Me.Label18)
        Me.PnlEstadoCuenta.Controls.Add(Me.Label20)
        Me.PnlEstadoCuenta.Controls.Add(Me.Label22)
        Me.PnlEstadoCuenta.Controls.Add(Me.Label14)
        Me.PnlEstadoCuenta.Controls.Add(Me.LblPlazo)
        Me.PnlEstadoCuenta.Controls.Add(Me.Label10)
        Me.PnlEstadoCuenta.Controls.Add(Me.Label11)
        Me.PnlEstadoCuenta.Controls.Add(Me.Label12)
        Me.PnlEstadoCuenta.Controls.Add(Me.Label13)
        Me.PnlEstadoCuenta.Controls.Add(Me.Label7)
        Me.PnlEstadoCuenta.Controls.Add(Me.Label8)
        Me.PnlEstadoCuenta.Controls.Add(Me.Label5)
        Me.PnlEstadoCuenta.Controls.Add(Me.Label6)
        Me.PnlEstadoCuenta.Controls.Add(Me.Label4)
        Me.PnlEstadoCuenta.Controls.Add(Me.LblCredito)
        Me.PnlEstadoCuenta.Controls.Add(Me.Label3)
        Me.PnlEstadoCuenta.Controls.Add(Me.Label2)
        Me.PnlEstadoCuenta.Controls.Add(Me.LblFechaEstado)
        Me.PnlEstadoCuenta.Controls.Add(Me.LblValor1)
        Me.PnlEstadoCuenta.Controls.Add(Me.LblVencimiento1)
        Me.PnlEstadoCuenta.Controls.Add(Me.LblNombre)
        Me.PnlEstadoCuenta.Controls.Add(Me.LblTitulo)
        Me.PnlEstadoCuenta.Controls.Add(Me.PictureBox1)
        Me.PnlEstadoCuenta.Location = New System.Drawing.Point(7, 3)
        Me.PnlEstadoCuenta.Name = "PnlEstadoCuenta"
        Me.PnlEstadoCuenta.Size = New System.Drawing.Size(773, 1002)
        Me.PnlEstadoCuenta.TabIndex = 2
        '
        'LblGastoCobranza
        '
        Me.LblGastoCobranza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblGastoCobranza.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGastoCobranza.Location = New System.Drawing.Point(466, 937)
        Me.LblGastoCobranza.Name = "LblGastoCobranza"
        Me.LblGastoCobranza.Size = New System.Drawing.Size(299, 63)
        Me.LblGastoCobranza.TabIndex = 192
        Me.LblGastoCobranza.Text = "LblGastoCobranza"
        Me.LblGastoCobranza.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblInteresMonetario
        '
        Me.LblInteresMonetario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblInteresMonetario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInteresMonetario.Location = New System.Drawing.Point(466, 912)
        Me.LblInteresMonetario.Name = "LblInteresMonetario"
        Me.LblInteresMonetario.Size = New System.Drawing.Size(299, 25)
        Me.LblInteresMonetario.TabIndex = 191
        Me.LblInteresMonetario.Text = "LblInteresMonetario"
        Me.LblInteresMonetario.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblPlazoPrepago
        '
        Me.LblPlazoPrepago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblPlazoPrepago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPlazoPrepago.Location = New System.Drawing.Point(466, 867)
        Me.LblPlazoPrepago.Name = "LblPlazoPrepago"
        Me.LblPlazoPrepago.Size = New System.Drawing.Size(299, 25)
        Me.LblPlazoPrepago.TabIndex = 190
        Me.LblPlazoPrepago.Text = "LblPlazoPrepago"
        Me.LblPlazoPrepago.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblCargoPrepago
        '
        Me.LblCargoPrepago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCargoPrepago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCargoPrepago.Location = New System.Drawing.Point(466, 842)
        Me.LblCargoPrepago.Name = "LblCargoPrepago"
        Me.LblCargoPrepago.Size = New System.Drawing.Size(299, 25)
        Me.LblCargoPrepago.TabIndex = 189
        Me.LblCargoPrepago.Text = "LblCargoPrepago"
        Me.LblCargoPrepago.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblProveedorSA2
        '
        Me.LblProveedorSA2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblProveedorSA2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProveedorSA2.Location = New System.Drawing.Point(466, 797)
        Me.LblProveedorSA2.Name = "LblProveedorSA2"
        Me.LblProveedorSA2.Size = New System.Drawing.Size(299, 25)
        Me.LblProveedorSA2.TabIndex = 188
        Me.LblProveedorSA2.Text = "LblProveedorSA2"
        Me.LblProveedorSA2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblCobertura2
        '
        Me.LblCobertura2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCobertura2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCobertura2.Location = New System.Drawing.Point(466, 772)
        Me.LblCobertura2.Name = "LblCobertura2"
        Me.LblCobertura2.Size = New System.Drawing.Size(299, 25)
        Me.LblCobertura2.TabIndex = 187
        Me.LblCobertura2.Text = "LblCobertura2"
        Me.LblCobertura2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblCostoTotal2
        '
        Me.LblCostoTotal2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCostoTotal2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCostoTotal2.Location = New System.Drawing.Point(466, 747)
        Me.LblCostoTotal2.Name = "LblCostoTotal2"
        Me.LblCostoTotal2.Size = New System.Drawing.Size(299, 25)
        Me.LblCostoTotal2.TabIndex = 186
        Me.LblCostoTotal2.Text = "LblCostoTotal2"
        Me.LblCostoTotal2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblCostoMensual2
        '
        Me.LblCostoMensual2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCostoMensual2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCostoMensual2.Location = New System.Drawing.Point(466, 722)
        Me.LblCostoMensual2.Name = "LblCostoMensual2"
        Me.LblCostoMensual2.Size = New System.Drawing.Size(299, 25)
        Me.LblCostoMensual2.TabIndex = 185
        Me.LblCostoMensual2.Text = "LblCostoMensual2"
        Me.LblCostoMensual2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblSeguroCesantiaCHUBB
        '
        Me.LblSeguroCesantiaCHUBB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblSeguroCesantiaCHUBB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSeguroCesantiaCHUBB.Location = New System.Drawing.Point(466, 697)
        Me.LblSeguroCesantiaCHUBB.Name = "LblSeguroCesantiaCHUBB"
        Me.LblSeguroCesantiaCHUBB.Size = New System.Drawing.Size(299, 25)
        Me.LblSeguroCesantiaCHUBB.TabIndex = 184
        Me.LblSeguroCesantiaCHUBB.Text = "LblSeguroCesantiaCHUBB"
        Me.LblSeguroCesantiaCHUBB.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblProveedorSA
        '
        Me.LblProveedorSA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblProveedorSA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProveedorSA.Location = New System.Drawing.Point(466, 672)
        Me.LblProveedorSA.Name = "LblProveedorSA"
        Me.LblProveedorSA.Size = New System.Drawing.Size(299, 25)
        Me.LblProveedorSA.TabIndex = 183
        Me.LblProveedorSA.Text = "LblProveedorSA"
        Me.LblProveedorSA.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblCobertura
        '
        Me.LblCobertura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCobertura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCobertura.Location = New System.Drawing.Point(466, 647)
        Me.LblCobertura.Name = "LblCobertura"
        Me.LblCobertura.Size = New System.Drawing.Size(299, 25)
        Me.LblCobertura.TabIndex = 182
        Me.LblCobertura.Text = "LblCobertura"
        Me.LblCobertura.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblCostoTotal
        '
        Me.LblCostoTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCostoTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCostoTotal.Location = New System.Drawing.Point(466, 622)
        Me.LblCostoTotal.Name = "LblCostoTotal"
        Me.LblCostoTotal.Size = New System.Drawing.Size(299, 25)
        Me.LblCostoTotal.TabIndex = 181
        Me.LblCostoTotal.Text = "LblCostoTotal"
        Me.LblCostoTotal.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblCostoMensual
        '
        Me.LblCostoMensual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCostoMensual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCostoMensual.Location = New System.Drawing.Point(466, 597)
        Me.LblCostoMensual.Name = "LblCostoMensual"
        Me.LblCostoMensual.Size = New System.Drawing.Size(299, 25)
        Me.LblCostoMensual.TabIndex = 180
        Me.LblCostoMensual.Text = "LblCostoMensual"
        Me.LblCostoMensual.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblCuotaRef
        '
        Me.LblCuotaRef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCuotaRef.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCuotaRef.Location = New System.Drawing.Point(466, 547)
        Me.LblCuotaRef.Name = "LblCuotaRef"
        Me.LblCuotaRef.Size = New System.Drawing.Size(299, 25)
        Me.LblCuotaRef.TabIndex = 178
        Me.LblCuotaRef.Text = "LblCuotaRef"
        Me.LblCuotaRef.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblMontoAtraso
        '
        Me.LblMontoAtraso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblMontoAtraso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMontoAtraso.Location = New System.Drawing.Point(466, 502)
        Me.LblMontoAtraso.Name = "LblMontoAtraso"
        Me.LblMontoAtraso.Size = New System.Drawing.Size(299, 25)
        Me.LblMontoAtraso.TabIndex = 177
        Me.LblMontoAtraso.Text = "LblMontoAtraso"
        Me.LblMontoAtraso.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblMontoCargAtraso
        '
        Me.LblMontoCargAtraso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblMontoCargAtraso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMontoCargAtraso.Location = New System.Drawing.Point(466, 477)
        Me.LblMontoCargAtraso.Name = "LblMontoCargAtraso"
        Me.LblMontoCargAtraso.Size = New System.Drawing.Size(299, 25)
        Me.LblMontoCargAtraso.TabIndex = 176
        Me.LblMontoCargAtraso.Text = "LblMontoCargAtraso"
        Me.LblMontoCargAtraso.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblDetalle
        '
        Me.LblDetalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDetalle.Location = New System.Drawing.Point(466, 452)
        Me.LblDetalle.Name = "LblDetalle"
        Me.LblDetalle.Size = New System.Drawing.Size(299, 25)
        Me.LblDetalle.TabIndex = 175
        Me.LblDetalle.Text = "LblDetalle"
        Me.LblDetalle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblMontoVencNoPag
        '
        Me.LblMontoVencNoPag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblMontoVencNoPag.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMontoVencNoPag.Location = New System.Drawing.Point(466, 427)
        Me.LblMontoVencNoPag.Name = "LblMontoVencNoPag"
        Me.LblMontoVencNoPag.Size = New System.Drawing.Size(299, 25)
        Me.LblMontoVencNoPag.TabIndex = 174
        Me.LblMontoVencNoPag.Text = "LblMontoVencNoPag"
        Me.LblMontoVencNoPag.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblCuotVencidasNoPag
        '
        Me.LblCuotVencidasNoPag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCuotVencidasNoPag.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCuotVencidasNoPag.Location = New System.Drawing.Point(466, 402)
        Me.LblCuotVencidasNoPag.Name = "LblCuotVencidasNoPag"
        Me.LblCuotVencidasNoPag.Size = New System.Drawing.Size(299, 25)
        Me.LblCuotVencidasNoPag.TabIndex = 173
        Me.LblCuotVencidasNoPag.Text = "LblCuotVencidasNoPag"
        Me.LblCuotVencidasNoPag.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblNumCuotasPag
        '
        Me.LblNumCuotasPag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblNumCuotasPag.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNumCuotasPag.Location = New System.Drawing.Point(466, 377)
        Me.LblNumCuotasPag.Name = "LblNumCuotasPag"
        Me.LblNumCuotasPag.Size = New System.Drawing.Size(299, 25)
        Me.LblNumCuotasPag.TabIndex = 172
        Me.LblNumCuotasPag.Text = "LblNumCuotasPag"
        Me.LblNumCuotasPag.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblGarVigen
        '
        Me.LblGarVigen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblGarVigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGarVigen.Location = New System.Drawing.Point(466, 332)
        Me.LblGarVigen.Name = "LblGarVigen"
        Me.LblGarVigen.Size = New System.Drawing.Size(299, 25)
        Me.LblGarVigen.TabIndex = 171
        Me.LblGarVigen.Text = "LblGarVigen"
        Me.LblGarVigen.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblCAEV
        '
        Me.LblCAEV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCAEV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCAEV.Location = New System.Drawing.Point(466, 307)
        Me.LblCAEV.Name = "LblCAEV"
        Me.LblCAEV.Size = New System.Drawing.Size(299, 25)
        Me.LblCAEV.TabIndex = 170
        Me.LblCAEV.Text = "LblCAEV"
        Me.LblCAEV.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblCostoTtlPrep
        '
        Me.LblCostoTtlPrep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCostoTtlPrep.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCostoTtlPrep.Location = New System.Drawing.Point(466, 282)
        Me.LblCostoTtlPrep.Name = "LblCostoTtlPrep"
        Me.LblCostoTtlPrep.Size = New System.Drawing.Size(299, 25)
        Me.LblCostoTtlPrep.TabIndex = 169
        Me.LblCostoTtlPrep.Text = "LblCostoTtlPrep"
        Me.LblCostoTtlPrep.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblSaldoCred
        '
        Me.LblSaldoCred.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblSaldoCred.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSaldoCred.Location = New System.Drawing.Point(466, 207)
        Me.LblSaldoCred.Name = "LblSaldoCred"
        Me.LblSaldoCred.Size = New System.Drawing.Size(299, 25)
        Me.LblSaldoCred.TabIndex = 168
        Me.LblSaldoCred.Text = "LblSaldoCred"
        Me.LblSaldoCred.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblProximaCuota
        '
        Me.LblProximaCuota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblProximaCuota.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProximaCuota.Location = New System.Drawing.Point(466, 183)
        Me.LblProximaCuota.Name = "LblProximaCuota"
        Me.LblProximaCuota.Size = New System.Drawing.Size(299, 25)
        Me.LblProximaCuota.TabIndex = 167
        Me.LblProximaCuota.Text = "LblProximaCuota"
        Me.LblProximaCuota.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblRut
        '
        Me.LblRut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRut.Location = New System.Drawing.Point(130, 47)
        Me.LblRut.Name = "LblRut"
        Me.LblRut.Size = New System.Drawing.Size(416, 20)
        Me.LblRut.TabIndex = 166
        Me.LblRut.Text = "Rut"
        '
        'Label41
        '
        Me.Label41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(4, 937)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(462, 63)
        Me.Label41.TabIndex = 165
        Me.Label41.Text = "Gasto de Cobranza:"
        '
        'Label42
        '
        Me.Label42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(4, 912)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(462, 25)
        Me.Label42.TabIndex = 164
        Me.Label42.Text = "Interés Monetario:"
        '
        'Label40
        '
        Me.Label40.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label40.Location = New System.Drawing.Point(4, 892)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(761, 20)
        Me.Label40.TabIndex = 163
        Me.Label40.Text = "V. COSTOS POR ATRASO"
        '
        'Label38
        '
        Me.Label38.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(4, 867)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(462, 25)
        Me.Label38.TabIndex = 162
        Me.Label38.Text = "Plazo de Aviso para Pago Anticipado o Prepago:"
        '
        'Label39
        '
        Me.Label39.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(4, 842)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(462, 25)
        Me.Label39.TabIndex = 161
        Me.Label39.Text = "Cargo Prepago:"
        '
        'Label37
        '
        Me.Label37.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(4, 822)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(761, 20)
        Me.Label37.TabIndex = 160
        Me.Label37.Text = "IV. CONDICIONES DE PREPAGO"
        '
        'Label33
        '
        Me.Label33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(4, 797)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(462, 25)
        Me.Label33.TabIndex = 159
        Me.Label33.Text = "Nombre Proveedor del Servicio Asociado:"
        '
        'Label34
        '
        Me.Label34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(4, 772)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(462, 25)
        Me.Label34.TabIndex = 158
        Me.Label34.Text = "Cobertura:"
        '
        'Label35
        '
        Me.Label35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(4, 747)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(462, 25)
        Me.Label35.TabIndex = 157
        Me.Label35.Text = "Costo Total (Pesos):"
        '
        'Label24
        '
        Me.Label24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(4, 722)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(462, 25)
        Me.Label24.TabIndex = 156
        Me.Label24.Text = "Costo Mensual (Pesos):"
        '
        'Label26
        '
        Me.Label26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(4, 697)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(462, 25)
        Me.Label26.TabIndex = 155
        Me.Label26.Text = "Seguro Cesantía CHUBB:"
        '
        'Label27
        '
        Me.Label27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(4, 672)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(462, 25)
        Me.Label27.TabIndex = 154
        Me.Label27.Text = "Nombre Proveedor del Servicio Asociado:"
        '
        'Label28
        '
        Me.Label28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(4, 647)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(462, 25)
        Me.Label28.TabIndex = 153
        Me.Label28.Text = "Cobertura:"
        '
        'Label29
        '
        Me.Label29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(4, 622)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(462, 25)
        Me.Label29.TabIndex = 152
        Me.Label29.Text = "Costo Total (Pesos):"
        '
        'Label30
        '
        Me.Label30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(4, 597)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(462, 25)
        Me.Label30.TabIndex = 151
        Me.Label30.Text = "Costo Mensual (Pesos):"
        '
        'Label31
        '
        Me.Label31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(4, 572)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(761, 25)
        Me.Label31.TabIndex = 150
        Me.Label31.Text = "Seguro Desgravamen CHUBB"
        '
        'Label32
        '
        Me.Label32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(4, 547)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(462, 25)
        Me.Label32.TabIndex = 149
        Me.Label32.Text = "Valor Cuota Referencia:"
        '
        'Label23
        '
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(4, 527)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(761, 20)
        Me.Label23.TabIndex = 148
        Me.Label23.Text = "III. GASTOS O CARGOS POR PRODUCTOS O SERVICIOS VOLUNTARIAMENTE CONTRATADOS"
        '
        'Label15
        '
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(4, 502)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(462, 25)
        Me.Label15.TabIndex = 147
        Me.Label15.Text = "Monto Atraso (Pesos):"
        '
        'Label16
        '
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(4, 477)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(462, 25)
        Me.Label16.TabIndex = 146
        Me.Label16.Text = "Monto Cargado por Atraso (pesos):"
        '
        'Label17
        '
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(4, 452)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(462, 25)
        Me.Label17.TabIndex = 145
        Me.Label17.Text = "Detalle:"
        '
        'Label18
        '
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(4, 427)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(462, 25)
        Me.Label18.TabIndex = 144
        Me.Label18.Text = "Monto Vencido no Pagado (Pesos):"
        '
        'Label20
        '
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(4, 402)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(462, 25)
        Me.Label20.TabIndex = 143
        Me.Label20.Text = "Número de Cuotas Vencidas no Pagadas:"
        '
        'Label22
        '
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(4, 377)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(462, 25)
        Me.Label22.TabIndex = 142
        Me.Label22.Text = "Número de Cuotas Pagadas:"
        '
        'Label14
        '
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(4, 357)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(761, 20)
        Me.Label14.TabIndex = 141
        Me.Label14.Text = "II. HISTORIAL"
        '
        'LblPlazo
        '
        Me.LblPlazo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblPlazo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPlazo.Location = New System.Drawing.Point(466, 159)
        Me.LblPlazo.Name = "LblPlazo"
        Me.LblPlazo.Size = New System.Drawing.Size(299, 25)
        Me.LblPlazo.TabIndex = 30
        Me.LblPlazo.Text = "00.00"
        Me.LblPlazo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(4, 332)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(462, 25)
        Me.Label10.TabIndex = 140
        Me.Label10.Text = "Garantías Vigentes:"
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(4, 307)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(462, 25)
        Me.Label11.TabIndex = 139
        Me.Label11.Text = "Carga Anual Equivalente Vigente (CAEV):"
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(4, 282)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(462, 25)
        Me.Label12.TabIndex = 138
        Me.Label12.Text = "Costo Total Prepago (Pesos):"
        '
        'Label13
        '
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(4, 257)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(462, 25)
        Me.Label13.TabIndex = 137
        Me.Label13.Text = "Fecha del Próximo Pago:"
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(4, 232)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(462, 25)
        Me.Label7.TabIndex = 136
        Me.Label7.Text = "Valor de la Cuota (Pesos):"
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(4, 207)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(462, 25)
        Me.Label8.TabIndex = 135
        Me.Label8.Text = "Saldo del Credito (Pesos):"
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(462, 25)
        Me.Label5.TabIndex = 134
        Me.Label5.Text = "Número próxima cuota a pagar:"
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(462, 25)
        Me.Label6.TabIndex = 133
        Me.Label6.Text = "Plazo del crédito pendiente mensuales:"
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(761, 20)
        Me.Label4.TabIndex = 132
        Me.Label4.Text = "I. PRODUCTO PRINCIPAL"
        '
        'LblCredito
        '
        Me.LblCredito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCredito.Location = New System.Drawing.Point(466, 114)
        Me.LblCredito.Name = "LblCredito"
        Me.LblCredito.Size = New System.Drawing.Size(299, 25)
        Me.LblCredito.TabIndex = 6
        Me.LblCredito.Text = "N Credito"
        Me.LblCredito.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(462, 25)
        Me.Label3.TabIndex = 131
        Me.Label3.Text = "N° Crédito:"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(462, 25)
        Me.Label2.TabIndex = 130
        Me.Label2.Text = "Fecha de Información:"
        '
        'LblFechaEstado
        '
        Me.LblFechaEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblFechaEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFechaEstado.Location = New System.Drawing.Point(466, 89)
        Me.LblFechaEstado.Name = "LblFechaEstado"
        Me.LblFechaEstado.Size = New System.Drawing.Size(299, 25)
        Me.LblFechaEstado.TabIndex = 30
        Me.LblFechaEstado.Text = "dd/mm/aaaa"
        Me.LblFechaEstado.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblEtiquetaNombre
        '
        Me.LblEtiquetaNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEtiquetaNombre.Location = New System.Drawing.Point(-28, -5)
        Me.LblEtiquetaNombre.Name = "LblEtiquetaNombre"
        Me.LblEtiquetaNombre.Size = New System.Drawing.Size(121, 30)
        Me.LblEtiquetaNombre.TabIndex = 109
        Me.LblEtiquetaNombre.Text = "Nombre"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label90)
        Me.GroupBox7.Controls.Add(Me.Label69)
        Me.GroupBox7.Controls.Add(Me.Label58)
        Me.GroupBox7.Controls.Add(Me.Label47)
        Me.GroupBox7.Controls.Add(Me.LblMontoProximoVencimiento1)
        Me.GroupBox7.Controls.Add(Me.Label36)
        Me.GroupBox7.Controls.Add(Me.Label21)
        Me.GroupBox7.Controls.Add(Me.Label19)
        Me.GroupBox7.Controls.Add(Me.Label9)
        Me.GroupBox7.Controls.Add(Me.LblDiasAtraso1)
        Me.GroupBox7.Controls.Add(Me.GroupBox1)
        Me.GroupBox7.Controls.Add(Me.LblTotal1)
        Me.GroupBox7.Controls.Add(Me.LblGastos1)
        Me.GroupBox7.Controls.Add(Me.LblInteres1)
        Me.GroupBox7.Controls.Add(Me.LblCuota1)
        Me.GroupBox7.Controls.Add(Me.GroupBox5)
        Me.GroupBox7.Controls.Add(Me.GroupBox3)
        Me.GroupBox7.Controls.Add(Me.GroupBox6)
        Me.GroupBox7.Controls.Add(Me.GroupBox2)
        Me.GroupBox7.Controls.Add(Me.GroupBox4)
        Me.GroupBox7.Controls.Add(Me.Label1)
        Me.GroupBox7.Controls.Add(Me.LblDiasAtraso11)
        Me.GroupBox7.Controls.Add(Me.LblTotal11)
        Me.GroupBox7.Controls.Add(Me.LblGastos11)
        Me.GroupBox7.Controls.Add(Me.LblInteres11)
        Me.GroupBox7.Controls.Add(Me.LblValor11)
        Me.GroupBox7.Controls.Add(Me.LblVencimiento11)
        Me.GroupBox7.Controls.Add(Me.LblCuota11)
        Me.GroupBox7.Controls.Add(Me.LblTotalAPagar)
        Me.GroupBox7.Controls.Add(Me.LblDiasAtraso10)
        Me.GroupBox7.Controls.Add(Me.LblDiasAtraso9)
        Me.GroupBox7.Controls.Add(Me.LblDiasAtraso8)
        Me.GroupBox7.Controls.Add(Me.LblDiasAtraso7)
        Me.GroupBox7.Controls.Add(Me.LblDiasAtraso6)
        Me.GroupBox7.Controls.Add(Me.LblDiasAtraso5)
        Me.GroupBox7.Controls.Add(Me.LblDiasAtraso4)
        Me.GroupBox7.Controls.Add(Me.LblDiasAtraso3)
        Me.GroupBox7.Controls.Add(Me.LblDiasAtraso2)
        Me.GroupBox7.Controls.Add(Me.LblTotal10)
        Me.GroupBox7.Controls.Add(Me.LblTotal9)
        Me.GroupBox7.Controls.Add(Me.LblTotal8)
        Me.GroupBox7.Controls.Add(Me.LblTotal7)
        Me.GroupBox7.Controls.Add(Me.LblTotal6)
        Me.GroupBox7.Controls.Add(Me.LblTotal5)
        Me.GroupBox7.Controls.Add(Me.LblTotal4)
        Me.GroupBox7.Controls.Add(Me.LblTotal3)
        Me.GroupBox7.Controls.Add(Me.LblTotal2)
        Me.GroupBox7.Controls.Add(Me.LblGastos10)
        Me.GroupBox7.Controls.Add(Me.LblGastos9)
        Me.GroupBox7.Controls.Add(Me.LblGastos8)
        Me.GroupBox7.Controls.Add(Me.LblGastos7)
        Me.GroupBox7.Controls.Add(Me.LblGastos6)
        Me.GroupBox7.Controls.Add(Me.LblGastos5)
        Me.GroupBox7.Controls.Add(Me.LblGastos4)
        Me.GroupBox7.Controls.Add(Me.LblGastos3)
        Me.GroupBox7.Controls.Add(Me.LblGastos2)
        Me.GroupBox7.Controls.Add(Me.LblInteres10)
        Me.GroupBox7.Controls.Add(Me.LblInteres9)
        Me.GroupBox7.Controls.Add(Me.LblInteres8)
        Me.GroupBox7.Controls.Add(Me.LblInteres7)
        Me.GroupBox7.Controls.Add(Me.LblInteres6)
        Me.GroupBox7.Controls.Add(Me.LblInteres5)
        Me.GroupBox7.Controls.Add(Me.LblInteres4)
        Me.GroupBox7.Controls.Add(Me.LblInteres3)
        Me.GroupBox7.Controls.Add(Me.LblInteres2)
        Me.GroupBox7.Controls.Add(Me.LblValor10)
        Me.GroupBox7.Controls.Add(Me.LblValor9)
        Me.GroupBox7.Controls.Add(Me.LblValor8)
        Me.GroupBox7.Controls.Add(Me.LblValor7)
        Me.GroupBox7.Controls.Add(Me.LblValor4)
        Me.GroupBox7.Controls.Add(Me.LblValor3)
        Me.GroupBox7.Controls.Add(Me.LblValor2)
        Me.GroupBox7.Controls.Add(Me.LblVencimiento10)
        Me.GroupBox7.Controls.Add(Me.LblVencimiento9)
        Me.GroupBox7.Controls.Add(Me.LblVencimiento8)
        Me.GroupBox7.Controls.Add(Me.LblVencimiento6)
        Me.GroupBox7.Controls.Add(Me.LblVencimiento5)
        Me.GroupBox7.Controls.Add(Me.LblVencimiento4)
        Me.GroupBox7.Controls.Add(Me.LblVencimiento3)
        Me.GroupBox7.Controls.Add(Me.LblVencimiento2)
        Me.GroupBox7.Controls.Add(Me.Label25)
        Me.GroupBox7.Controls.Add(Me.LblCuota10)
        Me.GroupBox7.Controls.Add(Me.LblCuota9)
        Me.GroupBox7.Controls.Add(Me.LblCuota8)
        Me.GroupBox7.Controls.Add(Me.LblCuota7)
        Me.GroupBox7.Controls.Add(Me.LblCuota6)
        Me.GroupBox7.Controls.Add(Me.LblCuota5)
        Me.GroupBox7.Controls.Add(Me.LblCuota4)
        Me.GroupBox7.Controls.Add(Me.LblCuota3)
        Me.GroupBox7.Controls.Add(Me.LblCuota2)
        Me.GroupBox7.Location = New System.Drawing.Point(1022, 73)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(147, 124)
        Me.GroupBox7.TabIndex = 9
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "GroupBox7"
        '
        'Label90
        '
        Me.Label90.AutoSize = True
        Me.Label90.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label90.Location = New System.Drawing.Point(-60, 40)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(92, 20)
        Me.Label90.TabIndex = 221
        Me.Label90.Text = "Dias Atraso"
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.Location = New System.Drawing.Point(377, 39)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(44, 20)
        Me.Label69.TabIndex = 220
        Me.Label69.Text = "Total"
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.Location = New System.Drawing.Point(270, 39)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(61, 20)
        Me.Label58.TabIndex = 219
        Me.Label58.Text = "Gastos"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(167, 39)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(59, 20)
        Me.Label47.TabIndex = 218
        Me.Label47.Text = "Interes"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(65, 39)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(46, 20)
        Me.Label36.TabIndex = 217
        Me.Label36.Text = "Valor"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(-162, 39)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(97, 20)
        Me.Label21.TabIndex = 216
        Me.Label21.Text = "Vencimiento"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(-236, 38)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(52, 20)
        Me.Label19.TabIndex = 215
        Me.Label19.Text = "Cuota"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(-239, 4)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(184, 20)
        Me.Label9.TabIndex = 214
        Me.Label9.Text = "Detalle Cuotas Vencidas"
        '
        'LblDiasAtraso1
        '
        Me.LblDiasAtraso1.AutoSize = True
        Me.LblDiasAtraso1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDiasAtraso1.Location = New System.Drawing.Point(-41, 76)
        Me.LblDiasAtraso1.Name = "LblDiasAtraso1"
        Me.LblDiasAtraso1.Size = New System.Drawing.Size(61, 20)
        Me.LblDiasAtraso1.TabIndex = 213
        Me.LblDiasAtraso1.Text = "Cuota1"
        Me.LblDiasAtraso1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblTotal1
        '
        Me.LblTotal1.AutoSize = True
        Me.LblTotal1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal1.Location = New System.Drawing.Point(378, 76)
        Me.LblTotal1.Name = "LblTotal1"
        Me.LblTotal1.Size = New System.Drawing.Size(61, 20)
        Me.LblTotal1.TabIndex = 212
        Me.LblTotal1.Text = "Cuota1"
        Me.LblTotal1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblGastos1
        '
        Me.LblGastos1.AutoSize = True
        Me.LblGastos1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGastos1.Location = New System.Drawing.Point(270, 76)
        Me.LblGastos1.Name = "LblGastos1"
        Me.LblGastos1.Size = New System.Drawing.Size(61, 20)
        Me.LblGastos1.TabIndex = 211
        Me.LblGastos1.Text = "Cuota1"
        Me.LblGastos1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblInteres1
        '
        Me.LblInteres1.AutoSize = True
        Me.LblInteres1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInteres1.Location = New System.Drawing.Point(166, 76)
        Me.LblInteres1.Name = "LblInteres1"
        Me.LblInteres1.Size = New System.Drawing.Size(61, 20)
        Me.LblInteres1.TabIndex = 210
        Me.LblInteres1.Text = "Cuota1"
        Me.LblInteres1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblCuota1
        '
        Me.LblCuota1.AutoSize = True
        Me.LblCuota1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCuota1.Location = New System.Drawing.Point(-236, 76)
        Me.LblCuota1.Name = "LblCuota1"
        Me.LblCuota1.Size = New System.Drawing.Size(61, 20)
        Me.LblCuota1.TabIndex = 209
        Me.LblCuota1.Text = "Cuota1"
        Me.LblCuota1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.LblCae)
        Me.GroupBox5.Controls.Add(Me.LblValor6)
        Me.GroupBox5.Controls.Add(Me.LblValor5)
        Me.GroupBox5.Controls.Add(Me.LblEtiquetaNombre)
        Me.GroupBox5.Location = New System.Drawing.Point(44, 35)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(128, 47)
        Me.GroupBox5.TabIndex = 208
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "CAE"
        '
        'LblCae
        '
        Me.LblCae.AutoSize = True
        Me.LblCae.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCae.Location = New System.Drawing.Point(42, 18)
        Me.LblCae.Name = "LblCae"
        Me.LblCae.Size = New System.Drawing.Size(49, 20)
        Me.LblCae.TabIndex = 30
        Me.LblCae.Text = "00.00"
        '
        'LblValor6
        '
        Me.LblValor6.AutoSize = True
        Me.LblValor6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblValor6.Location = New System.Drawing.Point(-14, 10)
        Me.LblValor6.Name = "LblValor6"
        Me.LblValor6.Size = New System.Drawing.Size(61, 20)
        Me.LblValor6.TabIndex = 154
        Me.LblValor6.Text = "Cuota1"
        Me.LblValor6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblValor5
        '
        Me.LblValor5.AutoSize = True
        Me.LblValor5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblValor5.Location = New System.Drawing.Point(-14, -19)
        Me.LblValor5.Name = "LblValor5"
        Me.LblValor5.Size = New System.Drawing.Size(61, 20)
        Me.LblValor5.TabIndex = 153
        Me.LblValor5.Text = "Cuota1"
        Me.LblValor5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LblTasaInteres)
        Me.GroupBox3.Controls.Add(Me.LblVencimiento7)
        Me.GroupBox3.Location = New System.Drawing.Point(36, 27)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(128, 47)
        Me.GroupBox3.TabIndex = 207
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tasa Interes"
        '
        'LblTasaInteres
        '
        Me.LblTasaInteres.AutoSize = True
        Me.LblTasaInteres.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTasaInteres.Location = New System.Drawing.Point(42, 18)
        Me.LblTasaInteres.Name = "LblTasaInteres"
        Me.LblTasaInteres.Size = New System.Drawing.Size(49, 20)
        Me.LblTasaInteres.TabIndex = 30
        Me.LblTasaInteres.Text = "00.00"
        '
        'LblVencimiento7
        '
        Me.LblVencimiento7.AutoSize = True
        Me.LblVencimiento7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVencimiento7.Location = New System.Drawing.Point(50, -2)
        Me.LblVencimiento7.Name = "LblVencimiento7"
        Me.LblVencimiento7.Size = New System.Drawing.Size(61, 20)
        Me.LblVencimiento7.TabIndex = 146
        Me.LblVencimiento7.Text = "Cuota1"
        Me.LblVencimiento7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox6
        '
        Me.GroupBox6.Location = New System.Drawing.Point(34, 27)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(128, 47)
        Me.GroupBox6.TabIndex = 206
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Numero de Credito"
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(177, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(130, 47)
        Me.GroupBox2.TabIndex = 205
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Plazo"
        '
        'GroupBox4
        '
        Me.GroupBox4.Location = New System.Drawing.Point(-106, 27)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(125, 47)
        Me.GroupBox4.TabIndex = 204
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Fecha Emision"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-44, 200)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(365, 26)
        Me.Label1.TabIndex = 203
        Me.Label1.Text = "Monto vencido a la fecha de emision"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDiasAtraso11
        '
        Me.LblDiasAtraso11.AutoSize = True
        Me.LblDiasAtraso11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDiasAtraso11.Location = New System.Drawing.Point(-51, 143)
        Me.LblDiasAtraso11.Name = "LblDiasAtraso11"
        Me.LblDiasAtraso11.Size = New System.Drawing.Size(61, 20)
        Me.LblDiasAtraso11.TabIndex = 202
        Me.LblDiasAtraso11.Text = "Cuota1"
        Me.LblDiasAtraso11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblTotal11
        '
        Me.LblTotal11.AutoSize = True
        Me.LblTotal11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal11.Location = New System.Drawing.Point(368, 143)
        Me.LblTotal11.Name = "LblTotal11"
        Me.LblTotal11.Size = New System.Drawing.Size(61, 20)
        Me.LblTotal11.TabIndex = 201
        Me.LblTotal11.Text = "Cuota1"
        Me.LblTotal11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblGastos11
        '
        Me.LblGastos11.AutoSize = True
        Me.LblGastos11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGastos11.Location = New System.Drawing.Point(260, 143)
        Me.LblGastos11.Name = "LblGastos11"
        Me.LblGastos11.Size = New System.Drawing.Size(61, 20)
        Me.LblGastos11.TabIndex = 200
        Me.LblGastos11.Text = "Cuota1"
        Me.LblGastos11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblInteres11
        '
        Me.LblInteres11.AutoSize = True
        Me.LblInteres11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInteres11.Location = New System.Drawing.Point(156, 143)
        Me.LblInteres11.Name = "LblInteres11"
        Me.LblInteres11.Size = New System.Drawing.Size(61, 20)
        Me.LblInteres11.TabIndex = 199
        Me.LblInteres11.Text = "Cuota1"
        Me.LblInteres11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblValor11
        '
        Me.LblValor11.AutoSize = True
        Me.LblValor11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblValor11.Location = New System.Drawing.Point(54, 143)
        Me.LblValor11.Name = "LblValor11"
        Me.LblValor11.Size = New System.Drawing.Size(61, 20)
        Me.LblValor11.TabIndex = 198
        Me.LblValor11.Text = "Cuota1"
        Me.LblValor11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblVencimiento11
        '
        Me.LblVencimiento11.AutoSize = True
        Me.LblVencimiento11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVencimiento11.Location = New System.Drawing.Point(-153, 143)
        Me.LblVencimiento11.Name = "LblVencimiento11"
        Me.LblVencimiento11.Size = New System.Drawing.Size(61, 20)
        Me.LblVencimiento11.TabIndex = 197
        Me.LblVencimiento11.Text = "Cuota1"
        Me.LblVencimiento11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblCuota11
        '
        Me.LblCuota11.AutoSize = True
        Me.LblCuota11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCuota11.Location = New System.Drawing.Point(-246, 143)
        Me.LblCuota11.Name = "LblCuota11"
        Me.LblCuota11.Size = New System.Drawing.Size(61, 20)
        Me.LblCuota11.TabIndex = 196
        Me.LblCuota11.Text = "Cuota1"
        Me.LblCuota11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblTotalAPagar
        '
        Me.LblTotalAPagar.AutoSize = True
        Me.LblTotalAPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalAPagar.Location = New System.Drawing.Point(340, 200)
        Me.LblTotalAPagar.Name = "LblTotalAPagar"
        Me.LblTotalAPagar.Size = New System.Drawing.Size(108, 26)
        Me.LblTotalAPagar.TabIndex = 195
        Me.LblTotalAPagar.Text = "0.000.000"
        Me.LblTotalAPagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDiasAtraso10
        '
        Me.LblDiasAtraso10.AutoSize = True
        Me.LblDiasAtraso10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDiasAtraso10.Location = New System.Drawing.Point(-51, 112)
        Me.LblDiasAtraso10.Name = "LblDiasAtraso10"
        Me.LblDiasAtraso10.Size = New System.Drawing.Size(61, 20)
        Me.LblDiasAtraso10.TabIndex = 194
        Me.LblDiasAtraso10.Text = "Cuota1"
        Me.LblDiasAtraso10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblDiasAtraso9
        '
        Me.LblDiasAtraso9.AutoSize = True
        Me.LblDiasAtraso9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDiasAtraso9.Location = New System.Drawing.Point(-51, 83)
        Me.LblDiasAtraso9.Name = "LblDiasAtraso9"
        Me.LblDiasAtraso9.Size = New System.Drawing.Size(61, 20)
        Me.LblDiasAtraso9.TabIndex = 193
        Me.LblDiasAtraso9.Text = "Cuota1"
        Me.LblDiasAtraso9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblDiasAtraso8
        '
        Me.LblDiasAtraso8.AutoSize = True
        Me.LblDiasAtraso8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDiasAtraso8.Location = New System.Drawing.Point(-51, 54)
        Me.LblDiasAtraso8.Name = "LblDiasAtraso8"
        Me.LblDiasAtraso8.Size = New System.Drawing.Size(61, 20)
        Me.LblDiasAtraso8.TabIndex = 192
        Me.LblDiasAtraso8.Text = "Cuota1"
        Me.LblDiasAtraso8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblDiasAtraso7
        '
        Me.LblDiasAtraso7.AutoSize = True
        Me.LblDiasAtraso7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDiasAtraso7.Location = New System.Drawing.Point(-51, 23)
        Me.LblDiasAtraso7.Name = "LblDiasAtraso7"
        Me.LblDiasAtraso7.Size = New System.Drawing.Size(61, 20)
        Me.LblDiasAtraso7.TabIndex = 191
        Me.LblDiasAtraso7.Text = "Cuota1"
        Me.LblDiasAtraso7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblDiasAtraso6
        '
        Me.LblDiasAtraso6.AutoSize = True
        Me.LblDiasAtraso6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDiasAtraso6.Location = New System.Drawing.Point(-51, -7)
        Me.LblDiasAtraso6.Name = "LblDiasAtraso6"
        Me.LblDiasAtraso6.Size = New System.Drawing.Size(61, 20)
        Me.LblDiasAtraso6.TabIndex = 190
        Me.LblDiasAtraso6.Text = "Cuota1"
        Me.LblDiasAtraso6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblDiasAtraso5
        '
        Me.LblDiasAtraso5.AutoSize = True
        Me.LblDiasAtraso5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDiasAtraso5.Location = New System.Drawing.Point(-51, -36)
        Me.LblDiasAtraso5.Name = "LblDiasAtraso5"
        Me.LblDiasAtraso5.Size = New System.Drawing.Size(61, 20)
        Me.LblDiasAtraso5.TabIndex = 189
        Me.LblDiasAtraso5.Text = "Cuota1"
        Me.LblDiasAtraso5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblDiasAtraso4
        '
        Me.LblDiasAtraso4.AutoSize = True
        Me.LblDiasAtraso4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDiasAtraso4.Location = New System.Drawing.Point(-51, -65)
        Me.LblDiasAtraso4.Name = "LblDiasAtraso4"
        Me.LblDiasAtraso4.Size = New System.Drawing.Size(61, 20)
        Me.LblDiasAtraso4.TabIndex = 188
        Me.LblDiasAtraso4.Text = "Cuota1"
        Me.LblDiasAtraso4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblDiasAtraso3
        '
        Me.LblDiasAtraso3.AutoSize = True
        Me.LblDiasAtraso3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDiasAtraso3.Location = New System.Drawing.Point(-51, -94)
        Me.LblDiasAtraso3.Name = "LblDiasAtraso3"
        Me.LblDiasAtraso3.Size = New System.Drawing.Size(61, 20)
        Me.LblDiasAtraso3.TabIndex = 187
        Me.LblDiasAtraso3.Text = "Cuota1"
        Me.LblDiasAtraso3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblDiasAtraso2
        '
        Me.LblDiasAtraso2.AutoSize = True
        Me.LblDiasAtraso2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDiasAtraso2.Location = New System.Drawing.Point(-51, -125)
        Me.LblDiasAtraso2.Name = "LblDiasAtraso2"
        Me.LblDiasAtraso2.Size = New System.Drawing.Size(61, 20)
        Me.LblDiasAtraso2.TabIndex = 186
        Me.LblDiasAtraso2.Text = "Cuota1"
        Me.LblDiasAtraso2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblTotal10
        '
        Me.LblTotal10.AutoSize = True
        Me.LblTotal10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal10.Location = New System.Drawing.Point(368, 112)
        Me.LblTotal10.Name = "LblTotal10"
        Me.LblTotal10.Size = New System.Drawing.Size(61, 20)
        Me.LblTotal10.TabIndex = 185
        Me.LblTotal10.Text = "Cuota1"
        Me.LblTotal10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblTotal9
        '
        Me.LblTotal9.AutoSize = True
        Me.LblTotal9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal9.Location = New System.Drawing.Point(368, 83)
        Me.LblTotal9.Name = "LblTotal9"
        Me.LblTotal9.Size = New System.Drawing.Size(61, 20)
        Me.LblTotal9.TabIndex = 184
        Me.LblTotal9.Text = "Cuota1"
        Me.LblTotal9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblTotal8
        '
        Me.LblTotal8.AutoSize = True
        Me.LblTotal8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal8.Location = New System.Drawing.Point(368, 54)
        Me.LblTotal8.Name = "LblTotal8"
        Me.LblTotal8.Size = New System.Drawing.Size(61, 20)
        Me.LblTotal8.TabIndex = 183
        Me.LblTotal8.Text = "Cuota1"
        Me.LblTotal8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblTotal7
        '
        Me.LblTotal7.AutoSize = True
        Me.LblTotal7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal7.Location = New System.Drawing.Point(368, 23)
        Me.LblTotal7.Name = "LblTotal7"
        Me.LblTotal7.Size = New System.Drawing.Size(61, 20)
        Me.LblTotal7.TabIndex = 182
        Me.LblTotal7.Text = "Cuota1"
        Me.LblTotal7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblTotal6
        '
        Me.LblTotal6.AutoSize = True
        Me.LblTotal6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal6.Location = New System.Drawing.Point(368, -7)
        Me.LblTotal6.Name = "LblTotal6"
        Me.LblTotal6.Size = New System.Drawing.Size(61, 20)
        Me.LblTotal6.TabIndex = 181
        Me.LblTotal6.Text = "Cuota1"
        Me.LblTotal6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblTotal5
        '
        Me.LblTotal5.AutoSize = True
        Me.LblTotal5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal5.Location = New System.Drawing.Point(368, -36)
        Me.LblTotal5.Name = "LblTotal5"
        Me.LblTotal5.Size = New System.Drawing.Size(61, 20)
        Me.LblTotal5.TabIndex = 180
        Me.LblTotal5.Text = "Cuota1"
        Me.LblTotal5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblTotal4
        '
        Me.LblTotal4.AutoSize = True
        Me.LblTotal4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal4.Location = New System.Drawing.Point(368, -65)
        Me.LblTotal4.Name = "LblTotal4"
        Me.LblTotal4.Size = New System.Drawing.Size(61, 20)
        Me.LblTotal4.TabIndex = 179
        Me.LblTotal4.Text = "Cuota1"
        Me.LblTotal4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblTotal3
        '
        Me.LblTotal3.AutoSize = True
        Me.LblTotal3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal3.Location = New System.Drawing.Point(368, -94)
        Me.LblTotal3.Name = "LblTotal3"
        Me.LblTotal3.Size = New System.Drawing.Size(61, 20)
        Me.LblTotal3.TabIndex = 178
        Me.LblTotal3.Text = "Cuota1"
        Me.LblTotal3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblTotal2
        '
        Me.LblTotal2.AutoSize = True
        Me.LblTotal2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal2.Location = New System.Drawing.Point(368, -125)
        Me.LblTotal2.Name = "LblTotal2"
        Me.LblTotal2.Size = New System.Drawing.Size(61, 20)
        Me.LblTotal2.TabIndex = 177
        Me.LblTotal2.Text = "Cuota1"
        Me.LblTotal2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblGastos10
        '
        Me.LblGastos10.AutoSize = True
        Me.LblGastos10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGastos10.Location = New System.Drawing.Point(260, 112)
        Me.LblGastos10.Name = "LblGastos10"
        Me.LblGastos10.Size = New System.Drawing.Size(61, 20)
        Me.LblGastos10.TabIndex = 176
        Me.LblGastos10.Text = "Cuota1"
        Me.LblGastos10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblGastos9
        '
        Me.LblGastos9.AutoSize = True
        Me.LblGastos9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGastos9.Location = New System.Drawing.Point(260, 83)
        Me.LblGastos9.Name = "LblGastos9"
        Me.LblGastos9.Size = New System.Drawing.Size(61, 20)
        Me.LblGastos9.TabIndex = 175
        Me.LblGastos9.Text = "Cuota1"
        Me.LblGastos9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblGastos8
        '
        Me.LblGastos8.AutoSize = True
        Me.LblGastos8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGastos8.Location = New System.Drawing.Point(260, 54)
        Me.LblGastos8.Name = "LblGastos8"
        Me.LblGastos8.Size = New System.Drawing.Size(61, 20)
        Me.LblGastos8.TabIndex = 174
        Me.LblGastos8.Text = "Cuota1"
        Me.LblGastos8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblGastos7
        '
        Me.LblGastos7.AutoSize = True
        Me.LblGastos7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGastos7.Location = New System.Drawing.Point(260, 23)
        Me.LblGastos7.Name = "LblGastos7"
        Me.LblGastos7.Size = New System.Drawing.Size(61, 20)
        Me.LblGastos7.TabIndex = 173
        Me.LblGastos7.Text = "Cuota1"
        Me.LblGastos7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblGastos6
        '
        Me.LblGastos6.AutoSize = True
        Me.LblGastos6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGastos6.Location = New System.Drawing.Point(260, -7)
        Me.LblGastos6.Name = "LblGastos6"
        Me.LblGastos6.Size = New System.Drawing.Size(61, 20)
        Me.LblGastos6.TabIndex = 172
        Me.LblGastos6.Text = "Cuota1"
        Me.LblGastos6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblGastos5
        '
        Me.LblGastos5.AutoSize = True
        Me.LblGastos5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGastos5.Location = New System.Drawing.Point(260, -36)
        Me.LblGastos5.Name = "LblGastos5"
        Me.LblGastos5.Size = New System.Drawing.Size(61, 20)
        Me.LblGastos5.TabIndex = 171
        Me.LblGastos5.Text = "Cuota1"
        Me.LblGastos5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblGastos4
        '
        Me.LblGastos4.AutoSize = True
        Me.LblGastos4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGastos4.Location = New System.Drawing.Point(260, -65)
        Me.LblGastos4.Name = "LblGastos4"
        Me.LblGastos4.Size = New System.Drawing.Size(61, 20)
        Me.LblGastos4.TabIndex = 170
        Me.LblGastos4.Text = "Cuota1"
        Me.LblGastos4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblGastos3
        '
        Me.LblGastos3.AutoSize = True
        Me.LblGastos3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGastos3.Location = New System.Drawing.Point(260, -94)
        Me.LblGastos3.Name = "LblGastos3"
        Me.LblGastos3.Size = New System.Drawing.Size(61, 20)
        Me.LblGastos3.TabIndex = 169
        Me.LblGastos3.Text = "Cuota1"
        Me.LblGastos3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblGastos2
        '
        Me.LblGastos2.AutoSize = True
        Me.LblGastos2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGastos2.Location = New System.Drawing.Point(260, -125)
        Me.LblGastos2.Name = "LblGastos2"
        Me.LblGastos2.Size = New System.Drawing.Size(61, 20)
        Me.LblGastos2.TabIndex = 168
        Me.LblGastos2.Text = "Cuota1"
        Me.LblGastos2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblInteres10
        '
        Me.LblInteres10.AutoSize = True
        Me.LblInteres10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInteres10.Location = New System.Drawing.Point(156, 112)
        Me.LblInteres10.Name = "LblInteres10"
        Me.LblInteres10.Size = New System.Drawing.Size(61, 20)
        Me.LblInteres10.TabIndex = 167
        Me.LblInteres10.Text = "Cuota1"
        Me.LblInteres10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblInteres9
        '
        Me.LblInteres9.AutoSize = True
        Me.LblInteres9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInteres9.Location = New System.Drawing.Point(156, 83)
        Me.LblInteres9.Name = "LblInteres9"
        Me.LblInteres9.Size = New System.Drawing.Size(61, 20)
        Me.LblInteres9.TabIndex = 166
        Me.LblInteres9.Text = "Cuota1"
        Me.LblInteres9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblInteres8
        '
        Me.LblInteres8.AutoSize = True
        Me.LblInteres8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInteres8.Location = New System.Drawing.Point(156, 54)
        Me.LblInteres8.Name = "LblInteres8"
        Me.LblInteres8.Size = New System.Drawing.Size(61, 20)
        Me.LblInteres8.TabIndex = 165
        Me.LblInteres8.Text = "Cuota1"
        Me.LblInteres8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblInteres7
        '
        Me.LblInteres7.AutoSize = True
        Me.LblInteres7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInteres7.Location = New System.Drawing.Point(156, 23)
        Me.LblInteres7.Name = "LblInteres7"
        Me.LblInteres7.Size = New System.Drawing.Size(61, 20)
        Me.LblInteres7.TabIndex = 164
        Me.LblInteres7.Text = "Cuota1"
        Me.LblInteres7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblInteres6
        '
        Me.LblInteres6.AutoSize = True
        Me.LblInteres6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInteres6.Location = New System.Drawing.Point(156, -7)
        Me.LblInteres6.Name = "LblInteres6"
        Me.LblInteres6.Size = New System.Drawing.Size(61, 20)
        Me.LblInteres6.TabIndex = 163
        Me.LblInteres6.Text = "Cuota1"
        Me.LblInteres6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblInteres5
        '
        Me.LblInteres5.AutoSize = True
        Me.LblInteres5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInteres5.Location = New System.Drawing.Point(156, -36)
        Me.LblInteres5.Name = "LblInteres5"
        Me.LblInteres5.Size = New System.Drawing.Size(61, 20)
        Me.LblInteres5.TabIndex = 162
        Me.LblInteres5.Text = "Cuota1"
        Me.LblInteres5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblInteres4
        '
        Me.LblInteres4.AutoSize = True
        Me.LblInteres4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInteres4.Location = New System.Drawing.Point(156, -65)
        Me.LblInteres4.Name = "LblInteres4"
        Me.LblInteres4.Size = New System.Drawing.Size(61, 20)
        Me.LblInteres4.TabIndex = 161
        Me.LblInteres4.Text = "Cuota1"
        Me.LblInteres4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblInteres3
        '
        Me.LblInteres3.AutoSize = True
        Me.LblInteres3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInteres3.Location = New System.Drawing.Point(156, -94)
        Me.LblInteres3.Name = "LblInteres3"
        Me.LblInteres3.Size = New System.Drawing.Size(61, 20)
        Me.LblInteres3.TabIndex = 160
        Me.LblInteres3.Text = "Cuota1"
        Me.LblInteres3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblInteres2
        '
        Me.LblInteres2.AutoSize = True
        Me.LblInteres2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInteres2.Location = New System.Drawing.Point(156, -125)
        Me.LblInteres2.Name = "LblInteres2"
        Me.LblInteres2.Size = New System.Drawing.Size(61, 20)
        Me.LblInteres2.TabIndex = 159
        Me.LblInteres2.Text = "Cuota1"
        Me.LblInteres2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblValor10
        '
        Me.LblValor10.AutoSize = True
        Me.LblValor10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblValor10.Location = New System.Drawing.Point(54, 112)
        Me.LblValor10.Name = "LblValor10"
        Me.LblValor10.Size = New System.Drawing.Size(61, 20)
        Me.LblValor10.TabIndex = 158
        Me.LblValor10.Text = "Cuota1"
        Me.LblValor10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblValor9
        '
        Me.LblValor9.AutoSize = True
        Me.LblValor9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblValor9.Location = New System.Drawing.Point(54, 83)
        Me.LblValor9.Name = "LblValor9"
        Me.LblValor9.Size = New System.Drawing.Size(61, 20)
        Me.LblValor9.TabIndex = 157
        Me.LblValor9.Text = "Cuota1"
        Me.LblValor9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblValor8
        '
        Me.LblValor8.AutoSize = True
        Me.LblValor8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblValor8.Location = New System.Drawing.Point(54, 54)
        Me.LblValor8.Name = "LblValor8"
        Me.LblValor8.Size = New System.Drawing.Size(61, 20)
        Me.LblValor8.TabIndex = 156
        Me.LblValor8.Text = "Cuota1"
        Me.LblValor8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblValor7
        '
        Me.LblValor7.AutoSize = True
        Me.LblValor7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblValor7.Location = New System.Drawing.Point(54, 23)
        Me.LblValor7.Name = "LblValor7"
        Me.LblValor7.Size = New System.Drawing.Size(61, 20)
        Me.LblValor7.TabIndex = 155
        Me.LblValor7.Text = "Cuota1"
        Me.LblValor7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblValor4
        '
        Me.LblValor4.AutoSize = True
        Me.LblValor4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblValor4.Location = New System.Drawing.Point(54, -65)
        Me.LblValor4.Name = "LblValor4"
        Me.LblValor4.Size = New System.Drawing.Size(61, 20)
        Me.LblValor4.TabIndex = 152
        Me.LblValor4.Text = "Cuota1"
        Me.LblValor4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblValor3
        '
        Me.LblValor3.AutoSize = True
        Me.LblValor3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblValor3.Location = New System.Drawing.Point(54, -94)
        Me.LblValor3.Name = "LblValor3"
        Me.LblValor3.Size = New System.Drawing.Size(61, 20)
        Me.LblValor3.TabIndex = 151
        Me.LblValor3.Text = "Cuota1"
        Me.LblValor3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblValor2
        '
        Me.LblValor2.AutoSize = True
        Me.LblValor2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblValor2.Location = New System.Drawing.Point(54, -125)
        Me.LblValor2.Name = "LblValor2"
        Me.LblValor2.Size = New System.Drawing.Size(61, 20)
        Me.LblValor2.TabIndex = 150
        Me.LblValor2.Text = "Cuota1"
        Me.LblValor2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblVencimiento10
        '
        Me.LblVencimiento10.AutoSize = True
        Me.LblVencimiento10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVencimiento10.Location = New System.Drawing.Point(-153, 112)
        Me.LblVencimiento10.Name = "LblVencimiento10"
        Me.LblVencimiento10.Size = New System.Drawing.Size(61, 20)
        Me.LblVencimiento10.TabIndex = 149
        Me.LblVencimiento10.Text = "Cuota1"
        Me.LblVencimiento10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblVencimiento9
        '
        Me.LblVencimiento9.AutoSize = True
        Me.LblVencimiento9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVencimiento9.Location = New System.Drawing.Point(-153, 83)
        Me.LblVencimiento9.Name = "LblVencimiento9"
        Me.LblVencimiento9.Size = New System.Drawing.Size(61, 20)
        Me.LblVencimiento9.TabIndex = 148
        Me.LblVencimiento9.Text = "Cuota1"
        Me.LblVencimiento9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblVencimiento8
        '
        Me.LblVencimiento8.AutoSize = True
        Me.LblVencimiento8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVencimiento8.Location = New System.Drawing.Point(-153, 54)
        Me.LblVencimiento8.Name = "LblVencimiento8"
        Me.LblVencimiento8.Size = New System.Drawing.Size(61, 20)
        Me.LblVencimiento8.TabIndex = 147
        Me.LblVencimiento8.Text = "Cuota1"
        Me.LblVencimiento8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblVencimiento6
        '
        Me.LblVencimiento6.AutoSize = True
        Me.LblVencimiento6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVencimiento6.Location = New System.Drawing.Point(-153, -7)
        Me.LblVencimiento6.Name = "LblVencimiento6"
        Me.LblVencimiento6.Size = New System.Drawing.Size(61, 20)
        Me.LblVencimiento6.TabIndex = 145
        Me.LblVencimiento6.Text = "Cuota1"
        Me.LblVencimiento6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblVencimiento5
        '
        Me.LblVencimiento5.AutoSize = True
        Me.LblVencimiento5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVencimiento5.Location = New System.Drawing.Point(-153, -36)
        Me.LblVencimiento5.Name = "LblVencimiento5"
        Me.LblVencimiento5.Size = New System.Drawing.Size(61, 20)
        Me.LblVencimiento5.TabIndex = 144
        Me.LblVencimiento5.Text = "Cuota1"
        Me.LblVencimiento5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblVencimiento4
        '
        Me.LblVencimiento4.AutoSize = True
        Me.LblVencimiento4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVencimiento4.Location = New System.Drawing.Point(-153, -65)
        Me.LblVencimiento4.Name = "LblVencimiento4"
        Me.LblVencimiento4.Size = New System.Drawing.Size(61, 20)
        Me.LblVencimiento4.TabIndex = 143
        Me.LblVencimiento4.Text = "Cuota1"
        Me.LblVencimiento4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblVencimiento3
        '
        Me.LblVencimiento3.AutoSize = True
        Me.LblVencimiento3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVencimiento3.Location = New System.Drawing.Point(-153, -94)
        Me.LblVencimiento3.Name = "LblVencimiento3"
        Me.LblVencimiento3.Size = New System.Drawing.Size(61, 20)
        Me.LblVencimiento3.TabIndex = 142
        Me.LblVencimiento3.Text = "Cuota1"
        Me.LblVencimiento3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblVencimiento2
        '
        Me.LblVencimiento2.AutoSize = True
        Me.LblVencimiento2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVencimiento2.Location = New System.Drawing.Point(-153, -125)
        Me.LblVencimiento2.Name = "LblVencimiento2"
        Me.LblVencimiento2.Size = New System.Drawing.Size(61, 20)
        Me.LblVencimiento2.TabIndex = 141
        Me.LblVencimiento2.Text = "Cuota1"
        Me.LblVencimiento2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(-255, 163)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(711, 20)
        Me.Label25.TabIndex = 140
        Me.Label25.Text = "______________________________________________________________________________"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblCuota10
        '
        Me.LblCuota10.AutoSize = True
        Me.LblCuota10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCuota10.Location = New System.Drawing.Point(-246, 112)
        Me.LblCuota10.Name = "LblCuota10"
        Me.LblCuota10.Size = New System.Drawing.Size(61, 20)
        Me.LblCuota10.TabIndex = 139
        Me.LblCuota10.Text = "Cuota1"
        Me.LblCuota10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblCuota9
        '
        Me.LblCuota9.AutoSize = True
        Me.LblCuota9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCuota9.Location = New System.Drawing.Point(-246, 83)
        Me.LblCuota9.Name = "LblCuota9"
        Me.LblCuota9.Size = New System.Drawing.Size(61, 20)
        Me.LblCuota9.TabIndex = 138
        Me.LblCuota9.Text = "Cuota1"
        Me.LblCuota9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblCuota8
        '
        Me.LblCuota8.AutoSize = True
        Me.LblCuota8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCuota8.Location = New System.Drawing.Point(-246, 54)
        Me.LblCuota8.Name = "LblCuota8"
        Me.LblCuota8.Size = New System.Drawing.Size(61, 20)
        Me.LblCuota8.TabIndex = 137
        Me.LblCuota8.Text = "Cuota1"
        Me.LblCuota8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblCuota7
        '
        Me.LblCuota7.AutoSize = True
        Me.LblCuota7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCuota7.Location = New System.Drawing.Point(-246, 23)
        Me.LblCuota7.Name = "LblCuota7"
        Me.LblCuota7.Size = New System.Drawing.Size(61, 20)
        Me.LblCuota7.TabIndex = 136
        Me.LblCuota7.Text = "Cuota1"
        Me.LblCuota7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblCuota6
        '
        Me.LblCuota6.AutoSize = True
        Me.LblCuota6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCuota6.Location = New System.Drawing.Point(-246, -7)
        Me.LblCuota6.Name = "LblCuota6"
        Me.LblCuota6.Size = New System.Drawing.Size(61, 20)
        Me.LblCuota6.TabIndex = 135
        Me.LblCuota6.Text = "Cuota1"
        Me.LblCuota6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblCuota5
        '
        Me.LblCuota5.AutoSize = True
        Me.LblCuota5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCuota5.Location = New System.Drawing.Point(-246, -36)
        Me.LblCuota5.Name = "LblCuota5"
        Me.LblCuota5.Size = New System.Drawing.Size(61, 20)
        Me.LblCuota5.TabIndex = 134
        Me.LblCuota5.Text = "Cuota1"
        Me.LblCuota5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblCuota4
        '
        Me.LblCuota4.AutoSize = True
        Me.LblCuota4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCuota4.Location = New System.Drawing.Point(-246, -65)
        Me.LblCuota4.Name = "LblCuota4"
        Me.LblCuota4.Size = New System.Drawing.Size(61, 20)
        Me.LblCuota4.TabIndex = 133
        Me.LblCuota4.Text = "Cuota1"
        Me.LblCuota4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblCuota3
        '
        Me.LblCuota3.AutoSize = True
        Me.LblCuota3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCuota3.Location = New System.Drawing.Point(-246, -94)
        Me.LblCuota3.Name = "LblCuota3"
        Me.LblCuota3.Size = New System.Drawing.Size(61, 20)
        Me.LblCuota3.TabIndex = 132
        Me.LblCuota3.Text = "Cuota1"
        Me.LblCuota3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblCuota2
        '
        Me.LblCuota2.AutoSize = True
        Me.LblCuota2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCuota2.Location = New System.Drawing.Point(-246, -125)
        Me.LblCuota2.Name = "LblCuota2"
        Me.LblCuota2.Size = New System.Drawing.Size(61, 20)
        Me.LblCuota2.TabIndex = 131
        Me.LblCuota2.Text = "Cuota1"
        Me.LblCuota2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmEstadoCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1190, 1005)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.BtnPDF)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PnlEstadoCuenta)
        Me.Name = "FrmEstadoCuenta"
        Me.Text = "Form2"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PnlEstadoCuenta.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnPDF As System.Windows.Forms.Button
    Friend WithEvents PrintDialogPDF As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocumentPDF As System.Drawing.Printing.PrintDocument
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LblTitulo As System.Windows.Forms.Label
    Friend WithEvents LblNombre As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LblMontoProximoVencimiento3 As System.Windows.Forms.Label
    Friend WithEvents LblFechaProximoVencimiento3 As System.Windows.Forms.Label
    Friend WithEvents LblMontoProximoVencimiento2 As System.Windows.Forms.Label
    Friend WithEvents LblFechaProximoVencimiento2 As System.Windows.Forms.Label
    Friend WithEvents LblMontoProximoVencimiento1 As System.Windows.Forms.Label
    Friend WithEvents LblFechaProximoVencimiento1 As System.Windows.Forms.Label
    Friend WithEvents LblVencimiento1 As System.Windows.Forms.Label
    Friend WithEvents LblValor1 As System.Windows.Forms.Label
    Friend WithEvents PnlEstadoCuenta As System.Windows.Forms.Panel
    Friend WithEvents LblEtiquetaNombre As System.Windows.Forms.Label
    Friend WithEvents LblPlazo As System.Windows.Forms.Label
    Friend WithEvents LblFechaEstado As System.Windows.Forms.Label
    Friend WithEvents LblCredito As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblDiasAtraso11 As System.Windows.Forms.Label
    Friend WithEvents LblTotal11 As System.Windows.Forms.Label
    Friend WithEvents LblGastos11 As System.Windows.Forms.Label
    Friend WithEvents LblInteres11 As System.Windows.Forms.Label
    Friend WithEvents LblValor11 As System.Windows.Forms.Label
    Friend WithEvents LblVencimiento11 As System.Windows.Forms.Label
    Friend WithEvents LblCuota11 As System.Windows.Forms.Label
    Friend WithEvents LblTotalAPagar As System.Windows.Forms.Label
    Friend WithEvents LblDiasAtraso10 As System.Windows.Forms.Label
    Friend WithEvents LblDiasAtraso9 As System.Windows.Forms.Label
    Friend WithEvents LblDiasAtraso8 As System.Windows.Forms.Label
    Friend WithEvents LblDiasAtraso7 As System.Windows.Forms.Label
    Friend WithEvents LblDiasAtraso6 As System.Windows.Forms.Label
    Friend WithEvents LblDiasAtraso5 As System.Windows.Forms.Label
    Friend WithEvents LblDiasAtraso4 As System.Windows.Forms.Label
    Friend WithEvents LblDiasAtraso3 As System.Windows.Forms.Label
    Friend WithEvents LblDiasAtraso2 As System.Windows.Forms.Label
    Friend WithEvents LblTotal10 As System.Windows.Forms.Label
    Friend WithEvents LblTotal9 As System.Windows.Forms.Label
    Friend WithEvents LblTotal8 As System.Windows.Forms.Label
    Friend WithEvents LblTotal7 As System.Windows.Forms.Label
    Friend WithEvents LblTotal6 As System.Windows.Forms.Label
    Friend WithEvents LblTotal5 As System.Windows.Forms.Label
    Friend WithEvents LblTotal4 As System.Windows.Forms.Label
    Friend WithEvents LblTotal3 As System.Windows.Forms.Label
    Friend WithEvents LblTotal2 As System.Windows.Forms.Label
    Friend WithEvents LblGastos10 As System.Windows.Forms.Label
    Friend WithEvents LblGastos9 As System.Windows.Forms.Label
    Friend WithEvents LblGastos8 As System.Windows.Forms.Label
    Friend WithEvents LblGastos7 As System.Windows.Forms.Label
    Friend WithEvents LblGastos6 As System.Windows.Forms.Label
    Friend WithEvents LblGastos5 As System.Windows.Forms.Label
    Friend WithEvents LblGastos4 As System.Windows.Forms.Label
    Friend WithEvents LblGastos3 As System.Windows.Forms.Label
    Friend WithEvents LblGastos2 As System.Windows.Forms.Label
    Friend WithEvents LblInteres10 As System.Windows.Forms.Label
    Friend WithEvents LblInteres9 As System.Windows.Forms.Label
    Friend WithEvents LblInteres8 As System.Windows.Forms.Label
    Friend WithEvents LblInteres7 As System.Windows.Forms.Label
    Friend WithEvents LblInteres6 As System.Windows.Forms.Label
    Friend WithEvents LblInteres5 As System.Windows.Forms.Label
    Friend WithEvents LblInteres4 As System.Windows.Forms.Label
    Friend WithEvents LblInteres3 As System.Windows.Forms.Label
    Friend WithEvents LblInteres2 As System.Windows.Forms.Label
    Friend WithEvents LblValor10 As System.Windows.Forms.Label
    Friend WithEvents LblValor9 As System.Windows.Forms.Label
    Friend WithEvents LblValor8 As System.Windows.Forms.Label
    Friend WithEvents LblValor7 As System.Windows.Forms.Label
    Friend WithEvents LblValor6 As System.Windows.Forms.Label
    Friend WithEvents LblValor5 As System.Windows.Forms.Label
    Friend WithEvents LblValor4 As System.Windows.Forms.Label
    Friend WithEvents LblValor3 As System.Windows.Forms.Label
    Friend WithEvents LblValor2 As System.Windows.Forms.Label
    Friend WithEvents LblVencimiento10 As System.Windows.Forms.Label
    Friend WithEvents LblVencimiento9 As System.Windows.Forms.Label
    Friend WithEvents LblVencimiento8 As System.Windows.Forms.Label
    Friend WithEvents LblVencimiento7 As System.Windows.Forms.Label
    Friend WithEvents LblVencimiento6 As System.Windows.Forms.Label
    Friend WithEvents LblVencimiento5 As System.Windows.Forms.Label
    Friend WithEvents LblVencimiento4 As System.Windows.Forms.Label
    Friend WithEvents LblVencimiento3 As System.Windows.Forms.Label
    Friend WithEvents LblVencimiento2 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents LblCuota10 As System.Windows.Forms.Label
    Friend WithEvents LblCuota9 As System.Windows.Forms.Label
    Friend WithEvents LblCuota8 As System.Windows.Forms.Label
    Friend WithEvents LblCuota7 As System.Windows.Forms.Label
    Friend WithEvents LblCuota6 As System.Windows.Forms.Label
    Friend WithEvents LblCuota5 As System.Windows.Forms.Label
    Friend WithEvents LblCuota4 As System.Windows.Forms.Label
    Friend WithEvents LblCuota3 As System.Windows.Forms.Label
    Friend WithEvents LblCuota2 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label90 As System.Windows.Forms.Label
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LblDiasAtraso1 As System.Windows.Forms.Label
    Friend WithEvents LblTotal1 As System.Windows.Forms.Label
    Friend WithEvents LblGastos1 As System.Windows.Forms.Label
    Friend WithEvents LblInteres1 As System.Windows.Forms.Label
    Friend WithEvents LblCuota1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents LblCae As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents LblTasaInteres As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents LblRut As System.Windows.Forms.Label
    Friend WithEvents LblGarVigen As System.Windows.Forms.Label
    Friend WithEvents LblCAEV As System.Windows.Forms.Label
    Friend WithEvents LblCostoTtlPrep As System.Windows.Forms.Label
    Friend WithEvents LblSaldoCred As System.Windows.Forms.Label
    Friend WithEvents LblProximaCuota As System.Windows.Forms.Label
    Friend WithEvents LblGastoCobranza As System.Windows.Forms.Label
    Friend WithEvents LblInteresMonetario As System.Windows.Forms.Label
    Friend WithEvents LblPlazoPrepago As System.Windows.Forms.Label
    Friend WithEvents LblCargoPrepago As System.Windows.Forms.Label
    Friend WithEvents LblProveedorSA2 As System.Windows.Forms.Label
    Friend WithEvents LblCobertura2 As System.Windows.Forms.Label
    Friend WithEvents LblCostoTotal2 As System.Windows.Forms.Label
    Friend WithEvents LblCostoMensual2 As System.Windows.Forms.Label
    Friend WithEvents LblSeguroCesantiaCHUBB As System.Windows.Forms.Label
    Friend WithEvents LblProveedorSA As System.Windows.Forms.Label
    Friend WithEvents LblCobertura As System.Windows.Forms.Label
    Friend WithEvents LblCostoTotal As System.Windows.Forms.Label
    Friend WithEvents LblCostoMensual As System.Windows.Forms.Label
    Friend WithEvents LblCuotaRef As System.Windows.Forms.Label
    Friend WithEvents LblMontoAtraso As System.Windows.Forms.Label
    Friend WithEvents LblMontoCargAtraso As System.Windows.Forms.Label
    Friend WithEvents LblDetalle As System.Windows.Forms.Label
    Friend WithEvents LblMontoVencNoPag As System.Windows.Forms.Label
    Friend WithEvents LblCuotVencidasNoPag As System.Windows.Forms.Label
    Friend WithEvents LblNumCuotasPag As System.Windows.Forms.Label
End Class
