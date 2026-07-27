
Imports System.Data
Imports System.Data.OleDb


Module MOdConexiones
    Public dbConexion As New OleDbConnection
    Public dbComando As New OleDb.OleDbCommand
    Public dbLector As OleDbDataReader

    Public Sub ConectarBase()
        Try
            dbConexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\mmanriquez\Documents\Estado de Cuenta v2\Proyecto Estado de Cuenta\Estado_Cuenta.accdb"
            dbConexion.Open()
        Catch auxError As Exception
            dbConexion.Close()
        End Try
    End Sub

    Public Sub CargarDatosPersonales(auxRut As String)
        Dim sqlStr As String

        sqlStr = "Select Rut, Dv, Nombres, Apellidos from A_Datos_Personales where rut=" & Val(auxRut)

        dbComando = New OleDbCommand(sqlStr, dbConexion)
        dbLector = dbComando.ExecuteReader()

        If (dbLector.Read()) Then

            With Form1
                .TxtDv.Text = dbLector("DV")
                .TxtNombres.Text = dbLector("Nombres")
                .TxtApellidos.Text = dbLector("Apellidos")
            End With

        End If

        dbLector.Close()
        dbLector.Dispose()
        dbComando.Dispose()

    End Sub

    Public Sub CargaRegistrosCredito(auxRut As String, auxCredito As String)
        Dim sqlStr As String
        Dim auxLineas As Integer
        Dim y As Integer
        'Valorea a cargar Grid
        Dim auxCuota As Integer
        Dim auxValor As Integer
        Dim auxInteres As Integer
        Dim auxGastos As Integer
        Dim auxTotal As Integer
        Dim auxVencimiento As String
        Dim auxDiasMora As Integer
        Dim auxFechaDesde As Date
        Dim auxFechaHasta As Date
        Dim auxInteresDia As Double
        Dim auxCalculoTemporal As Double

        sqlStr = "Select * from C_Detalle_Cuotas where rut=" & Val(auxRut) & " and contrato=" & Val(auxCredito) & " order by Fecha_auxiliar asc"

        dbComando = New OleDbCommand(sqlStr, dbConexion)
        dbLector = dbComando.ExecuteReader()

        y = 0

        auxDiasMora = 0
        auxFechaHasta = Form1.TxtFechaActual.Text


        Do While (dbLector.Read())

            auxLineas = Form1.DgvCuotas.RowCount

            Form1.DgvCuotas.RowCount = auxLineas + 1

            'Carga contratos activos
            auxCuota = dbLector("Cuota")
            auxValor = dbLector("Monto")

            auxVencimiento = dbLector("Vencimiento")
            auxFechaDesde = auxVencimiento

            'Colocar condicion si auxDiasMora es negativo "Al dia" o DM cero
            auxDiasMora = DateDiff("d", auxFechaDesde, auxFechaHasta)

            If auxDiasMora <= 0 Then
                auxInteres = 0
                auxGastos = 0
            Else
                'Calcula Interes
                '--------------------------------------------------------------------
                auxInteresDia = TasaMaximaCuonvencional / 30
                auxCalculoTemporal = auxValor * ((auxDiasMora * auxInteresDia) / 100)

                auxInteres = Math.Round(Convert.ToInt64(auxCalculoTemporal), 0)

                '--------------------------------------------------------------------

                'Calcula Gastos
                '--------------------------------------------------------------------

                auxGastos = 0

                If auxDiasMora > 20 Then


                    If (ValorUF * 10) < auxValor Then
                        'Calculo para menores a 10UF
                        'Corresponde a un 9% del valor Cuota
                        auxGastos = auxValor * 9 / 100

                    Else
                        If (ValorUF * 50) < auxValor Then
                            'Calculo para casos entre 10UF y 50UF

                            auxGastos = (ValorUF * 10) * 9 / 100

                            auxGastos = auxGastos + ((auxValor - (ValorUF * 10)) * 6 / 100)
                        Else
                            'Calculo para mayores a 50UF

                            auxGastos = (ValorUF * 10) * 9 / 100

                            auxGastos = auxGastos + (((ValorUF * (50 - 10)) * 6 / 100))

                            auxGastos = auxGastos + ((auxValor - (ValorUF * 50)) * 3 / 100)

                        End If

                    End If


                End If
            End If


            'auxInteres = dbLector("Interes")
            'auxGastos = dbLector("Gastos")
            auxTotal = auxValor + auxInteres + auxGastos



            With Form1
                'Cuota
                .DgvCuotas(0, y).Value = auxCuota
                'Valor
                .DgvCuotas(1, y).Value = auxValor
                'Interes
                .DgvCuotas(2, y).Value = auxInteres
                'Gastos
                .DgvCuotas(3, y).Value = auxGastos
                'Total
                .DgvCuotas(4, y).Value = auxTotal
                'Vencimiento
                .DgvCuotas(5, y).Value = auxVencimiento
                'Dias Mora
                .DgvCuotas(6, y).Value = auxDiasMora
            End With

            y = y + 1

        Loop

        dbLector.Close()
        dbLector.Dispose()
        dbComando.Dispose()

        'Verifica que hay informacion que se rescato del rut

        If Form1.DgvCuotas.RowCount > 1 Then
            'Ok se encontro informacion
        Else
            'Pasar a registro siguiente el ultimo registro no arrojo informacion

        End If


    End Sub


    '******
    Public Sub CargarRegistro(auxPosicion As Integer)
        Form1.TxtRut.Text = Form1.DgvCreditos(0, auxPosicion).Value

        Form1.TxtCredito.Text = Form1.DgvCreditos(1, auxPosicion).Value

        Form1.TxtPlazo.Text = Form1.DgvCreditos(2, auxPosicion).Value

        Form1.TxtTasaInteres.Text = Form1.DgvCreditos(3, auxPosicion).Value

        Form1.TxtCae.Text = Form1.DgvCreditos(4, auxPosicion).Value


        CargarDatosPersonales(Form1.TxtRut.Text)

        CargaRegistrosCredito(Form1.TxtRut.Text, Form1.TxtCredito.Text)

    End Sub

    Public Sub LlamarCreditosActivos()
        Dim sqlStr As String
        Dim auxRut As String
        Dim auxContrato As String
        Dim y As Integer
        Dim auxLineas As Integer
        Dim auxCuotas As String
        Dim auxTasa As String
        Dim auxCAE As String

        sqlStr = "Select Rut, Contrato, Cuotas, Tasa, Cae from B_Contratos order by rut asc, contrato asc"

        dbComando = New OleDbCommand(sqlStr, dbConexion)
        dbLector = dbComando.ExecuteReader()

        y = 0

        Do While (dbLector.Read())

            auxLineas = Form1.DgvCreditos.RowCount

            Form1.DgvCreditos.RowCount = auxLineas + 1

            'Carga contratos activos
            auxRut = dbLector("Rut")
            auxContrato = dbLector("Contrato")
            auxCuotas = dbLector("Cuotas")
            auxTasa = dbLector("Tasa")
            auxCAE = dbLector("CAE")

            With Form1
                'Rut
                .DgvCreditos(0, y).Value = auxRut
                'Credito
                .DgvCreditos(1, y).Value = auxContrato

                'Cuotas
                .DgvCreditos(2, y).Value = auxCuotas
                'Tasa
                .DgvCreditos(3, y).Value = auxTasa
                'CAE
                .DgvCreditos(4, y).Value = auxCAE
            End With

            y = y + 1

        Loop

        CantidadRegistros = y - 1

        dbLector.Close()
        dbLector.Dispose()
        dbComando.Dispose()

    End Sub


    'Public Sub BuscaDatosPersonales(auxRut As String)
    '    Dim sqlStr As String

    '    sqlStr = "Select * from PER_Nombres where rut=" & Val(auxRut)

    '    dbComando = New OleDbCommand(sqlStr, dbConexion)
    '    dbLector = dbComando.ExecuteReader()

    '    If (dbLector.Read()) Then
    '        FrmGestion.TxtDv.Text = dbLector("Dv")
    '        FrmGestion.TxtNombre.Text = dbLector("Nombre")
    '    Else
    '        'No se encontro Nombre
    '    End If

    '    dbLector.Close()
    '    dbLector.Dispose()
    '    dbComando.Dispose()
    'End Sub





End Module
