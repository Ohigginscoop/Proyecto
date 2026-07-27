<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.DgvCuotas = New System.Windows.Forms.DataGridView()
        Me.Cuota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Valor_Cuota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Interes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gastos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vencimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dias_Mora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LblRut = New System.Windows.Forms.Label()
        Me.TxtRut = New System.Windows.Forms.TextBox()
        Me.TxtDv = New System.Windows.Forms.TextBox()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.TxtNombres = New System.Windows.Forms.TextBox()
        Me.LblCredito = New System.Windows.Forms.Label()
        Me.TxtCredito = New System.Windows.Forms.TextBox()
        Me.BtnRetrocede = New System.Windows.Forms.Button()
        Me.BtnAvanza = New System.Windows.Forms.Button()
        Me.BtnInicio = New System.Windows.Forms.Button()
        Me.DgvCreditos = New System.Windows.Forms.DataGridView()
        Me.Rut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Credito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtApellidos = New System.Windows.Forms.TextBox()
        Me.TxtUf = New System.Windows.Forms.TextBox()
        Me.LblUf = New System.Windows.Forms.Label()
        Me.LblFechaActual = New System.Windows.Forms.Label()
        Me.TxtFechaActual = New System.Windows.Forms.TextBox()
        Me.BtnCalculaInteres = New System.Windows.Forms.Button()
        Me.TxtTasaMaximaConvencional = New System.Windows.Forms.TextBox()
        Me.LblTasaMaximaConvencional = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Cuotas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tasa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtPlazo = New System.Windows.Forms.TextBox()
        Me.LblPlazo = New System.Windows.Forms.Label()
        Me.TxtTasaInteres = New System.Windows.Forms.TextBox()
        Me.LblTasaInteres = New System.Windows.Forms.Label()
        Me.TxtCae = New System.Windows.Forms.TextBox()
        Me.LblCae = New System.Windows.Forms.Label()
        CType(Me.DgvCuotas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvCreditos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvCuotas
        '
        Me.DgvCuotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCuotas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cuota, Me.Valor_Cuota, Me.Interes, Me.Gastos, Me.Total, Me.Vencimiento, Me.Dias_Mora})
        Me.DgvCuotas.Location = New System.Drawing.Point(32, 202)
        Me.DgvCuotas.Name = "DgvCuotas"
        Me.DgvCuotas.Size = New System.Drawing.Size(862, 380)
        Me.DgvCuotas.TabIndex = 0
        '
        'Cuota
        '
        Me.Cuota.HeaderText = "Cuota"
        Me.Cuota.Name = "Cuota"
        '
        'Valor_Cuota
        '
        Me.Valor_Cuota.HeaderText = "Valor_Cuota"
        Me.Valor_Cuota.Name = "Valor_Cuota"
        '
        'Interes
        '
        Me.Interes.HeaderText = "Interes"
        Me.Interes.Name = "Interes"
        '
        'Gastos
        '
        Me.Gastos.HeaderText = "Gastos"
        Me.Gastos.Name = "Gastos"
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        '
        'Vencimiento
        '
        Me.Vencimiento.HeaderText = "Vencimiento"
        Me.Vencimiento.Name = "Vencimiento"
        '
        'Dias_Mora
        '
        Me.Dias_Mora.HeaderText = "Dias Mora"
        Me.Dias_Mora.Name = "Dias_Mora"
        '
        'LblRut
        '
        Me.LblRut.AutoSize = True
        Me.LblRut.Location = New System.Drawing.Point(39, 101)
        Me.LblRut.Name = "LblRut"
        Me.LblRut.Size = New System.Drawing.Size(24, 13)
        Me.LblRut.TabIndex = 1
        Me.LblRut.Text = "Rut"
        '
        'TxtRut
        '
        Me.TxtRut.Location = New System.Drawing.Point(119, 98)
        Me.TxtRut.Name = "TxtRut"
        Me.TxtRut.Size = New System.Drawing.Size(103, 20)
        Me.TxtRut.TabIndex = 2
        '
        'TxtDv
        '
        Me.TxtDv.Location = New System.Drawing.Point(228, 97)
        Me.TxtDv.Name = "TxtDv"
        Me.TxtDv.Size = New System.Drawing.Size(21, 20)
        Me.TxtDv.TabIndex = 3
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(42, 132)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(44, 13)
        Me.LblNombre.TabIndex = 4
        Me.LblNombre.Text = "Nombre"
        '
        'TxtNombres
        '
        Me.TxtNombres.Location = New System.Drawing.Point(121, 127)
        Me.TxtNombres.Name = "TxtNombres"
        Me.TxtNombres.Size = New System.Drawing.Size(388, 20)
        Me.TxtNombres.TabIndex = 5
        '
        'LblCredito
        '
        Me.LblCredito.AutoSize = True
        Me.LblCredito.Location = New System.Drawing.Point(42, 168)
        Me.LblCredito.Name = "LblCredito"
        Me.LblCredito.Size = New System.Drawing.Size(40, 13)
        Me.LblCredito.TabIndex = 6
        Me.LblCredito.Text = "Credito"
        '
        'TxtCredito
        '
        Me.TxtCredito.Location = New System.Drawing.Point(121, 161)
        Me.TxtCredito.Name = "TxtCredito"
        Me.TxtCredito.Size = New System.Drawing.Size(67, 20)
        Me.TxtCredito.TabIndex = 7
        '
        'BtnRetrocede
        '
        Me.BtnRetrocede.Location = New System.Drawing.Point(32, 619)
        Me.BtnRetrocede.Name = "BtnRetrocede"
        Me.BtnRetrocede.Size = New System.Drawing.Size(95, 30)
        Me.BtnRetrocede.TabIndex = 8
        Me.BtnRetrocede.Text = "Retrocede"
        Me.BtnRetrocede.UseVisualStyleBackColor = True
        '
        'BtnAvanza
        '
        Me.BtnAvanza.Location = New System.Drawing.Point(799, 619)
        Me.BtnAvanza.Name = "BtnAvanza"
        Me.BtnAvanza.Size = New System.Drawing.Size(95, 30)
        Me.BtnAvanza.TabIndex = 9
        Me.BtnAvanza.Text = "Avanza"
        Me.BtnAvanza.UseVisualStyleBackColor = True
        '
        'BtnInicio
        '
        Me.BtnInicio.Location = New System.Drawing.Point(32, 13)
        Me.BtnInicio.Name = "BtnInicio"
        Me.BtnInicio.Size = New System.Drawing.Size(149, 33)
        Me.BtnInicio.TabIndex = 10
        Me.BtnInicio.Text = "Inicio"
        Me.BtnInicio.UseVisualStyleBackColor = True
        '
        'DgvCreditos
        '
        Me.DgvCreditos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCreditos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Rut, Me.Credito, Me.Cuotas, Me.Tasa, Me.CAE})
        Me.DgvCreditos.Location = New System.Drawing.Point(173, 608)
        Me.DgvCreditos.Name = "DgvCreditos"
        Me.DgvCreditos.Size = New System.Drawing.Size(579, 101)
        Me.DgvCreditos.TabIndex = 11
        '
        'Rut
        '
        Me.Rut.HeaderText = "Rut"
        Me.Rut.Name = "Rut"
        '
        'Credito
        '
        Me.Credito.HeaderText = "Credito"
        Me.Credito.Name = "Credito"
        '
        'TxtApellidos
        '
        Me.TxtApellidos.Location = New System.Drawing.Point(528, 125)
        Me.TxtApellidos.Name = "TxtApellidos"
        Me.TxtApellidos.Size = New System.Drawing.Size(366, 20)
        Me.TxtApellidos.TabIndex = 12
        '
        'TxtUf
        '
        Me.TxtUf.Location = New System.Drawing.Point(450, 20)
        Me.TxtUf.Name = "TxtUf"
        Me.TxtUf.Size = New System.Drawing.Size(133, 20)
        Me.TxtUf.TabIndex = 13
        '
        'LblUf
        '
        Me.LblUf.AutoSize = True
        Me.LblUf.Location = New System.Drawing.Point(306, 20)
        Me.LblUf.Name = "LblUf"
        Me.LblUf.Size = New System.Drawing.Size(21, 13)
        Me.LblUf.TabIndex = 14
        Me.LblUf.Text = "UF"
        '
        'LblFechaActual
        '
        Me.LblFechaActual.AutoSize = True
        Me.LblFechaActual.Location = New System.Drawing.Point(306, 46)
        Me.LblFechaActual.Name = "LblFechaActual"
        Me.LblFechaActual.Size = New System.Drawing.Size(70, 13)
        Me.LblFechaActual.TabIndex = 15
        Me.LblFechaActual.Text = "Fecha Actual"
        '
        'TxtFechaActual
        '
        Me.TxtFechaActual.Location = New System.Drawing.Point(450, 46)
        Me.TxtFechaActual.Name = "TxtFechaActual"
        Me.TxtFechaActual.Size = New System.Drawing.Size(133, 20)
        Me.TxtFechaActual.TabIndex = 16
        '
        'BtnCalculaInteres
        '
        Me.BtnCalculaInteres.Location = New System.Drawing.Point(638, 21)
        Me.BtnCalculaInteres.Name = "BtnCalculaInteres"
        Me.BtnCalculaInteres.Size = New System.Drawing.Size(160, 24)
        Me.BtnCalculaInteres.TabIndex = 17
        Me.BtnCalculaInteres.Text = "Calcula Interes"
        Me.BtnCalculaInteres.UseVisualStyleBackColor = True
        '
        'TxtTasaMaximaConvencional
        '
        Me.TxtTasaMaximaConvencional.Location = New System.Drawing.Point(450, 72)
        Me.TxtTasaMaximaConvencional.Name = "TxtTasaMaximaConvencional"
        Me.TxtTasaMaximaConvencional.Size = New System.Drawing.Size(133, 20)
        Me.TxtTasaMaximaConvencional.TabIndex = 19
        '
        'LblTasaMaximaConvencional
        '
        Me.LblTasaMaximaConvencional.AutoSize = True
        Me.LblTasaMaximaConvencional.Location = New System.Drawing.Point(306, 72)
        Me.LblTasaMaximaConvencional.Name = "LblTasaMaximaConvencional"
        Me.LblTasaMaximaConvencional.Size = New System.Drawing.Size(138, 13)
        Me.LblTasaMaximaConvencional.TabIndex = 18
        Me.LblTasaMaximaConvencional.Text = "Tasa Maxima Convencional"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(772, 65)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(48, 36)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(843, 22)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 36)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "F"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Cuotas
        '
        Me.Cuotas.HeaderText = "Cuotas"
        Me.Cuotas.Name = "Cuotas"
        '
        'Tasa
        '
        Me.Tasa.HeaderText = "Tasa"
        Me.Tasa.Name = "Tasa"
        '
        'CAE
        '
        Me.CAE.HeaderText = "CAE"
        Me.CAE.Name = "CAE"
        '
        'TxtPlazo
        '
        Me.TxtPlazo.Location = New System.Drawing.Point(288, 161)
        Me.TxtPlazo.Name = "TxtPlazo"
        Me.TxtPlazo.Size = New System.Drawing.Size(67, 20)
        Me.TxtPlazo.TabIndex = 23
        '
        'LblPlazo
        '
        Me.LblPlazo.AutoSize = True
        Me.LblPlazo.Location = New System.Drawing.Point(209, 168)
        Me.LblPlazo.Name = "LblPlazo"
        Me.LblPlazo.Size = New System.Drawing.Size(37, 13)
        Me.LblPlazo.TabIndex = 22
        Me.LblPlazo.Text = "PLazo"
        '
        'TxtTasaInteres
        '
        Me.TxtTasaInteres.Location = New System.Drawing.Point(471, 161)
        Me.TxtTasaInteres.Name = "TxtTasaInteres"
        Me.TxtTasaInteres.Size = New System.Drawing.Size(67, 20)
        Me.TxtTasaInteres.TabIndex = 25
        '
        'LblTasaInteres
        '
        Me.LblTasaInteres.AutoSize = True
        Me.LblTasaInteres.Location = New System.Drawing.Point(392, 168)
        Me.LblTasaInteres.Name = "LblTasaInteres"
        Me.LblTasaInteres.Size = New System.Drawing.Size(31, 13)
        Me.LblTasaInteres.TabIndex = 24
        Me.LblTasaInteres.Text = "Tasa"
        '
        'TxtCae
        '
        Me.TxtCae.Location = New System.Drawing.Point(671, 161)
        Me.TxtCae.Name = "TxtCae"
        Me.TxtCae.Size = New System.Drawing.Size(67, 20)
        Me.TxtCae.TabIndex = 27
        '
        'LblCae
        '
        Me.LblCae.AutoSize = True
        Me.LblCae.Location = New System.Drawing.Point(592, 168)
        Me.LblCae.Name = "LblCae"
        Me.LblCae.Size = New System.Drawing.Size(26, 13)
        Me.LblCae.TabIndex = 26
        Me.LblCae.Text = "Cae"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 721)
        Me.Controls.Add(Me.TxtCae)
        Me.Controls.Add(Me.LblCae)
        Me.Controls.Add(Me.TxtTasaInteres)
        Me.Controls.Add(Me.LblTasaInteres)
        Me.Controls.Add(Me.TxtPlazo)
        Me.Controls.Add(Me.LblPlazo)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtTasaMaximaConvencional)
        Me.Controls.Add(Me.LblTasaMaximaConvencional)
        Me.Controls.Add(Me.BtnCalculaInteres)
        Me.Controls.Add(Me.TxtFechaActual)
        Me.Controls.Add(Me.LblFechaActual)
        Me.Controls.Add(Me.LblUf)
        Me.Controls.Add(Me.TxtUf)
        Me.Controls.Add(Me.TxtApellidos)
        Me.Controls.Add(Me.DgvCreditos)
        Me.Controls.Add(Me.BtnInicio)
        Me.Controls.Add(Me.BtnAvanza)
        Me.Controls.Add(Me.BtnRetrocede)
        Me.Controls.Add(Me.TxtCredito)
        Me.Controls.Add(Me.LblCredito)
        Me.Controls.Add(Me.TxtNombres)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.TxtDv)
        Me.Controls.Add(Me.TxtRut)
        Me.Controls.Add(Me.LblRut)
        Me.Controls.Add(Me.DgvCuotas)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DgvCuotas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvCreditos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgvCuotas As System.Windows.Forms.DataGridView
    Friend WithEvents LblRut As System.Windows.Forms.Label
    Friend WithEvents TxtRut As System.Windows.Forms.TextBox
    Friend WithEvents TxtDv As System.Windows.Forms.TextBox
    Friend WithEvents LblNombre As System.Windows.Forms.Label
    Friend WithEvents TxtNombres As System.Windows.Forms.TextBox
    Friend WithEvents LblCredito As System.Windows.Forms.Label
    Friend WithEvents TxtCredito As System.Windows.Forms.TextBox
    Friend WithEvents BtnRetrocede As System.Windows.Forms.Button
    Friend WithEvents BtnAvanza As System.Windows.Forms.Button
    Friend WithEvents BtnInicio As System.Windows.Forms.Button
    Friend WithEvents DgvCreditos As System.Windows.Forms.DataGridView
    Friend WithEvents Rut As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Credito As System.Windows.Forms.DataGridViewTextBoxColumn

    Private Sub BtnInicio_Click(sender As System.Object, e As System.EventArgs) Handles BtnInicio.Click
        Dim auxConsulta As Integer

        'DgvCreditos.RowCount = 0
        TasaMaximaCuonvencional = TxtTasaMaximaConvencional.Text
        ConectarBase()
        LlamarCreditosActivos()
        auxPosicionRegistro = 0
        CargarRegistro(0)

        auxConsulta = MsgBox("Generar Estados de Cuenta Masivo?", vbYesNo)

        If auxConsulta = vbYes Then
            MsgBox("Comienza")
            ProcesoImpresionMasiva()
        End If


    End Sub
    Friend WithEvents TxtApellidos As System.Windows.Forms.TextBox
    Friend WithEvents TxtUf As System.Windows.Forms.TextBox
    Friend WithEvents LblUf As System.Windows.Forms.Label
    Friend WithEvents LblFechaActual As System.Windows.Forms.Label

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles LblFechaActual.Click

    End Sub
    Friend WithEvents TxtFechaActual As System.Windows.Forms.TextBox
    Friend WithEvents BtnCalculaInteres As System.Windows.Forms.Button
    Friend WithEvents TxtTasaMaximaConvencional As System.Windows.Forms.TextBox
    Friend WithEvents LblTasaMaximaConvencional As System.Windows.Forms.Label
    Friend WithEvents Cuota As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Valor_Cuota As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Interes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Gastos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Vencimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dias_Mora As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        FrmEstadoCuenta.Show()

    End Sub

    Private Sub BtnAvanza_Click(sender As System.Object, e As System.EventArgs) Handles BtnAvanza.Click
        LimpiarPantalla()

        'ConectarBase()
        auxPosicionRegistro = auxPosicionRegistro + 1

        CargarRegistro(auxPosicionRegistro)
    End Sub

    Private Sub BtnRetrocede_Click(sender As System.Object, e As System.EventArgs) Handles BtnRetrocede.Click
        LimpiarPantalla()

        'ConectarBase()
        auxPosicionRegistro = auxPosicionRegistro - 1

        If auxPosicionRegistro < 0 Then
            auxPosicionRegistro = 0
        End If

        CargarRegistro(auxPosicionRegistro)
    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim ejemplo As Integer

        ejemplo = Val(TxtUf.Text)

        TxtUf.Text = ejemplo.ToString("N0")
    End Sub
    Friend WithEvents Cuotas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tasa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtPlazo As System.Windows.Forms.TextBox
    Friend WithEvents LblPlazo As System.Windows.Forms.Label
    Friend WithEvents TxtTasaInteres As System.Windows.Forms.TextBox
    Friend WithEvents LblTasaInteres As System.Windows.Forms.Label
    Friend WithEvents TxtCae As System.Windows.Forms.TextBox
    Friend WithEvents LblCae As System.Windows.Forms.Label
End Class
