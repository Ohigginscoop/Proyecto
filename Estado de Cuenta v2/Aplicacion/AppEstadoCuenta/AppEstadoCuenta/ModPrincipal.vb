Imports Microsoft.VisualBasic
Imports System.Globalization
Imports System.IO

Module ModPrincipal
    Public CantidadRegistros As Integer
    Public TasaMaximaCuonvencional As Double
    Public ValorUF As Double
    Public auxPosicionRegistro As Integer
    Public directory As String
    Public fileName As String
    Public cantidadEstadosImprimir As Integer

    Sub LimpiarPantalla()

        With Form1
            .TxtRut.Text = ""
            .TxtDv.Text = ""
            .TxtNombres.Text = ""
            .TxtApellidos.Text = ""
            .TxtCredito.Text = ""
            .DgvCuotas.RowCount = 1
        End With

    End Sub

    Sub LimpiarEstadoCuenta()

        With FrmEstadoCuenta

            'Numero de Cuota
            .LblCuota1.Text = ""
            .LblCuota2.Text = ""
            .LblCuota3.Text = ""
            .LblCuota4.Text = ""
            .LblCuota5.Text = ""
            .LblCuota6.Text = ""
            .LblCuota7.Text = ""
            .LblCuota8.Text = ""
            .LblCuota9.Text = ""
            .LblCuota10.Text = ""
            .LblCuota11.Text = ""

            'Dias Atraso
            .LblDiasAtraso1.Text = ""
            .LblDiasAtraso2.Text = ""
            .LblDiasAtraso3.Text = ""
            .LblDiasAtraso4.Text = ""
            .LblDiasAtraso5.Text = ""
            .LblDiasAtraso6.Text = ""
            .LblDiasAtraso7.Text = ""
            .LblDiasAtraso8.Text = ""
            .LblDiasAtraso9.Text = ""
            .LblDiasAtraso10.Text = ""
            .LblDiasAtraso11.Text = ""

            'Gastos
            .LblGastos1.Text = ""
            .LblGastos2.Text = ""
            .LblGastos3.Text = ""
            .LblGastos4.Text = ""
            .LblGastos5.Text = ""
            .LblGastos6.Text = ""
            .LblGastos7.Text = ""
            .LblGastos8.Text = ""
            .LblGastos9.Text = ""
            .LblGastos10.Text = ""
            .LblGastos11.Text = ""

            'Interes
            .LblInteres1.Text = ""
            .LblInteres2.Text = ""
            .LblInteres3.Text = ""
            .LblInteres4.Text = ""
            .LblInteres5.Text = ""
            .LblInteres6.Text = ""
            .LblInteres7.Text = ""
            .LblInteres8.Text = ""
            .LblInteres9.Text = ""
            .LblInteres10.Text = ""
            .LblInteres11.Text = ""

            'Total
            .LblTotal1.Text = ""
            .LblTotal2.Text = ""
            .LblTotal3.Text = ""
            .LblTotal4.Text = ""
            .LblTotal5.Text = ""
            .LblTotal6.Text = ""
            .LblTotal7.Text = ""
            .LblTotal8.Text = ""
            .LblTotal9.Text = ""
            .LblTotal10.Text = ""
            .LblTotal11.Text = ""

            'Valor
            .LblValor1.Text = ""
            .LblValor2.Text = ""
            .LblValor3.Text = ""
            .LblValor4.Text = ""
            .LblValor5.Text = ""
            .LblValor6.Text = ""
            .LblValor7.Text = ""
            .LblValor8.Text = ""
            .LblValor9.Text = ""
            .LblValor10.Text = ""
            .LblValor11.Text = ""

            'Vencimiento
            .LblVencimiento1.Text = ""
            .LblVencimiento2.Text = ""
            .LblVencimiento3.Text = ""
            .LblVencimiento4.Text = ""
            .LblVencimiento5.Text = ""
            .LblVencimiento6.Text = ""
            .LblVencimiento7.Text = ""
            .LblVencimiento8.Text = ""
            .LblVencimiento9.Text = ""
            .LblVencimiento10.Text = ""
            .LblVencimiento11.Text = ""

            'Proximos Vencimientos
            .LblFechaProximoVencimiento1.Text = ""
            .LblMontoProximoVencimiento1.Text = ""
            .LblFechaProximoVencimiento2.Text = ""
            .LblMontoProximoVencimiento2.Text = ""
            .LblFechaProximoVencimiento3.Text = ""
            .LblMontoProximoVencimiento3.Text = ""


        End With
    End Sub

    Sub ProcesoImpresionMasiva()
        Dim x As Integer
        'Proceso Impresion Masivo

        cantidadEstadosImprimir = Form1.DgvCreditos.RowCount

        MsgBox(cantidadEstadosImprimir)

        For x = 0 To cantidadEstadosImprimir
            'Inicia Proceso
            CargarRegistro(x)
            FrmEstadoCuenta.Show()
            ImprimePDFEstadoCuenta()
            FrmEstadoCuenta.Close()


            If x = 10 Then
                Exit For
            End If
        Next



    End Sub


    Sub CargarDatosEstadoCuenta()
        Dim auxTest As Integer
        Dim auxTotalPagar As Integer
        Dim auxLineas As Integer
        Dim y As Integer
        Dim auxPaso As Integer

        'MsgBox(     numero.ToString("n0", New CultureInfo("es-ES"))     )





        auxTest = 0
        auxTotalPagar = 0

        auxLineas = Form1.DgvCuotas.RowCount

        'Form1.DgvCuotas.RowCount = auxLineas + 1

        y = 0
        auxPaso = 0

        With Form1

            FrmEstadoCuenta.LblRut.Text = .TxtRut.Text & "-" & .TxtDv.Text
            FrmEstadoCuenta.LblNombre.Text = .TxtNombres.Text & " " & .TxtApellidos.Text
            FrmEstadoCuenta.LblCredito.Text = .TxtCredito.Text
            FrmEstadoCuenta.LblFechaEstado.Text = .TxtFechaActual.Text


            FrmEstadoCuenta.LblPlazo.Text = .TxtPlazo.Text
            FrmEstadoCuenta.LblTasaInteres.Text = .TxtTasaInteres.Text
            FrmEstadoCuenta.LblCae.Text = .TxtCae.Text





            'Se pregunta por el primer dato de dias mora disponible
            auxTest = .DgvCuotas(6, y).Value



            If auxTest >= 0 Then
                'Si hay detalle de cuotas vancidas

                '----------------------------------------------------------------
                '--- Primera cuota mas atrasada
                '----------------------------------------------------------------

                'Se pregunta por el primer dato de dias mora disponible que sigue
                auxTest = .DgvCuotas(6, y).Value

                If y <= auxLineas And auxTest > 0 Then
                    'Completa primera linea
                    'Numero Cuota
                    FrmEstadoCuenta.LblCuota1.Text = .DgvCuotas(0, y).Value
                    'Vencimiento
                    FrmEstadoCuenta.LblVencimiento1.Text = .DgvCuotas(5, y).Value
                    'Dias Atraso
                    FrmEstadoCuenta.LblDiasAtraso1.Text = .DgvCuotas(6, y).Value
                    'Valor Cuota
                    auxPaso = .DgvCuotas(1, y).Value
                    FrmEstadoCuenta.LblValor1.Text = auxPaso.ToString("n0", New CultureInfo("es-ES"))
                    'Interes
                    auxPaso = .DgvCuotas(2, y).Value
                    FrmEstadoCuenta.LblInteres1.Text = auxPaso.ToString("n0", New CultureInfo("es-ES"))
                    'Gastos
                    auxPaso = .DgvCuotas(3, y).Value
                    FrmEstadoCuenta.LblGastos1.Text = auxPaso.ToString("n0", New CultureInfo("es-ES"))
                    'Total



                    auxPaso = .DgvCuotas(4, y).Value

                    auxTotalPagar = auxTotalPagar + auxPaso

                    FrmEstadoCuenta.LblTotal1.Text = auxPaso.ToString("n0", New CultureInfo("es-ES"))



                    y = y + 1

                End If


                '----------------------------------------------------------------
                '--- Segunda cuota mas atrasada
                '----------------------------------------------------------------

                'Se pregunta por el primer dato de dias mora disponible que sigue
                auxTest = .DgvCuotas(6, y).Value

                If y <= auxLineas And auxTest > 0 Then
                    'Completa primera linea
                    'Numero Cuota
                    FrmEstadoCuenta.LblCuota2.Text = .DgvCuotas(0, y).Value
                    'Vencimiento
                    FrmEstadoCuenta.LblVencimiento2.Text = .DgvCuotas(5, y).Value
                    'Dias Atraso
                    FrmEstadoCuenta.LblDiasAtraso2.Text = .DgvCuotas(6, y).Value
                    'Valor Cuota
                    auxPaso = .DgvCuotas(1, y).Value
                    FrmEstadoCuenta.LblValor2.Text = auxPaso.ToString("n0", New CultureInfo("es-ES"))
                    'Interes
                    auxPaso = .DgvCuotas(2, y).Value
                    FrmEstadoCuenta.LblInteres2.Text = auxPaso.ToString("n0", New CultureInfo("es-ES"))
                    'Gastos
                    auxPaso = .DgvCuotas(3, y).Value
                    FrmEstadoCuenta.LblGastos2.Text = auxPaso.ToString("n0", New CultureInfo("es-ES"))
                    'Total



                    auxPaso = .DgvCuotas(4, y).Value

                    auxTotalPagar = auxTotalPagar + auxPaso

                    FrmEstadoCuenta.LblTotal2.Text = auxPaso.ToString("n0", New CultureInfo("es-ES"))

                    ' auxTotalPagar = auxTotalPagar + Val(FrmEstadoCuenta.LblTotal2.Text)

                    y = y + 1

                End If


                '----------------------------------------------------------------
                '--- Tercera cuota mas atrasada
                '----------------------------------------------------------------

                'Se pregunta por el primer dato de dias mora disponible que sigue
                auxTest = .DgvCuotas(6, y).Value

                If y <= auxLineas And auxTest > 0 Then
                    'Completa primera linea
                    'Numero Cuota
                    FrmEstadoCuenta.LblCuota3.Text = .DgvCuotas(0, y).Value
                    'Vencimiento
                    FrmEstadoCuenta.LblVencimiento3.Text = .DgvCuotas(5, y).Value
                    'Dias Atraso
                    FrmEstadoCuenta.LblDiasAtraso3.Text = .DgvCuotas(6, y).Value
                    'Valor Cuota
                    auxPaso = .DgvCuotas(1, y).Value
                    FrmEstadoCuenta.LblValor3.Text = auxPaso.ToString("n0", New CultureInfo("es-ES"))
                    'Interes
                    auxPaso = .DgvCuotas(2, y).Value
                    FrmEstadoCuenta.LblInteres3.Text = auxPaso.ToString("n0", New CultureInfo("es-ES"))
                    'Gastos
                    auxPaso = .DgvCuotas(3, y).Value
                    FrmEstadoCuenta.LblGastos3.Text = auxPaso.ToString("n0", New CultureInfo("es-ES"))
                    'Total



                    auxPaso = .DgvCuotas(4, y).Value

                    auxTotalPagar = auxTotalPagar + auxPaso

                    FrmEstadoCuenta.LblTotal3.Text = auxPaso.ToString("n0", New CultureInfo("es-ES"))

                    'auxTotalPagar = auxTotalPagar + Val(FrmEstadoCuenta.LblTotal3.Text)

                    y = y + 1

                End If


                '----------------------------------------------------------------
                '--- Cuarta cuota mas atrasada
                '----------------------------------------------------------------

                'Se pregunta por el primer dato de dias mora disponible que sigue
                auxTest = .DgvCuotas(6, y).Value

                If y <= auxLineas And auxTest > 0 Then
                    'Completa primera linea
                    'Numero Cuota
                    FrmEstadoCuenta.LblCuota4.Text = .DgvCuotas(0, y).Value
                    'Vencimiento
                    FrmEstadoCuenta.LblVencimiento4.Text = .DgvCuotas(5, y).Value
                    'Dias Atraso
                    FrmEstadoCuenta.LblDiasAtraso4.Text = .DgvCuotas(6, y).Value
                    'Valor Cuota
                    auxPaso = .DgvCuotas(1, y).Value
                    FrmEstadoCuenta.LblValor4.Text = auxPaso.ToString("n0", New CultureInfo("es-ES"))
                    'Interes
                    auxPaso = .DgvCuotas(2, y).Value
                    FrmEstadoCuenta.LblInteres4.Text = auxPaso.ToString("n0", New CultureInfo("es-ES"))
                    'Gastos
                    auxPaso = .DgvCuotas(3, y).Value
                    FrmEstadoCuenta.LblGastos4.Text = auxPaso.ToString("n0", New CultureInfo("es-ES"))

                    'Total
                    auxPaso = .DgvCuotas(4, y).Value
                    auxTotalPagar = auxTotalPagar + auxPaso
                    FrmEstadoCuenta.LblTotal4.Text = auxPaso.ToString("n0", New CultureInfo("es-ES"))

                    y = y + 1

                End If


                '----------------------------------------------------------------
                '--- Quinta cuota mas atrasada
                '----------------------------------------------------------------

                'Se pregunta por el primer dato de dias mora disponible que sigue
                auxTest = .DgvCuotas(6, y).Value

                If y <= auxLineas And auxTest > 0 Then
                    'Completa primera linea
                    'Numero Cuota
                    FrmEstadoCuenta.LblCuota5.Text = .DgvCuotas(0, y).Value
                    'Vencimiento
                    FrmEstadoCuenta.LblVencimiento5.Text = .DgvCuotas(5, y).Value
                    'Dias Atraso
                    FrmEstadoCuenta.LblDiasAtraso5.Text = .DgvCuotas(6, y).Value
                    'Valor Cuota
                    auxPaso = .DgvCuotas(1, y).Value
                    FrmEstadoCuenta.LblValor5.Text = auxPaso.ToString("n0", New CultureInfo("es-ES"))
                    'Interes
                    auxPaso = .DgvCuotas(2, y).Value
                    FrmEstadoCuenta.LblInteres5.Text = auxPaso.ToString("n0", New CultureInfo("es-ES"))
                    'Gastos
                    auxPaso = .DgvCuotas(3, y).Value
                    FrmEstadoCuenta.LblGastos5.Text = auxPaso.ToString("n0", New CultureInfo("es-ES"))

                    'Total
                    auxPaso = .DgvCuotas(4, y).Value
                    auxTotalPagar = auxTotalPagar + auxPaso
                    FrmEstadoCuenta.LblTotal5.Text = auxPaso.ToString("n0", New CultureInfo("es-ES"))

                    y = y + 1

                End If

                '----------------------------------------------------------------
                '--- Sexta cuota mas atrasada
                '----------------------------------------------------------------

                'Se pregunta por el primer dato de dias mora disponible que sigue
                auxTest = .DgvCuotas(6, y).Value

                If y <= auxLineas And auxTest > 0 Then
                    'Completa primera linea
                    'Numero Cuota
                    FrmEstadoCuenta.LblCuota6.Text = .DgvCuotas(0, y).Value
                    'Vencimiento
                    FrmEstadoCuenta.LblVencimiento6.Text = .DgvCuotas(5, y).Value
                    'Dias Atraso
                    FrmEstadoCuenta.LblDiasAtraso6.Text = .DgvCuotas(6, y).Value
                    'Valor Cuota
                    auxPaso = .DgvCuotas(1, y).Value
                    FrmEstadoCuenta.LblValor6.Text = auxPaso.ToString("n0", New CultureInfo("es-ES"))
                    'Interes
                    auxPaso = .DgvCuotas(2, y).Value
                    FrmEstadoCuenta.LblInteres6.Text = auxPaso.ToString("n0", New CultureInfo("es-ES"))
                    'Gastos
                    auxPaso = .DgvCuotas(3, y).Value
                    FrmEstadoCuenta.LblGastos6.Text = auxPaso.ToString("n0", New CultureInfo("es-ES"))

                    'Total
                    auxPaso = .DgvCuotas(4, y).Value
                    auxTotalPagar = auxTotalPagar + auxPaso
                    FrmEstadoCuenta.LblTotal6.Text = auxPaso.ToString("n0", New CultureInfo("es-ES"))

                    y = y + 1

                End If

                '----------------------------------------------------------------
                '--- Septima cuota mas atrasada
                '----------------------------------------------------------------

                'Se pregunta por el primer dato de dias mora disponible que sigue
                auxTest = .DgvCuotas(6, y).Value

                If y <= auxLineas And auxTest > 0 Then
                    'Completa primera linea
                    'Numero Cuota
                    FrmEstadoCuenta.LblCuota7.Text = .DgvCuotas(0, y).Value
                    'Vencimiento
                    FrmEstadoCuenta.LblVencimiento7.Text = .DgvCuotas(5, y).Value
                    'Dias Atraso
                    FrmEstadoCuenta.LblDiasAtraso7.Text = .DgvCuotas(6, y).Value
                    'Valor Cuota
                    auxPaso = .DgvCuotas(1, y).Value
                    FrmEstadoCuenta.LblValor7.Text = auxPaso.ToString("n0", New CultureInfo("es-ES"))
                    'Interes
                    auxPaso = .DgvCuotas(2, y).Value
                    FrmEstadoCuenta.LblInteres7.Text = auxPaso.ToString("n0", New CultureInfo("es-ES"))
                    'Gastos
                    auxPaso = .DgvCuotas(3, y).Value
                    FrmEstadoCuenta.LblGastos7.Text = auxPaso.ToString("n0", New CultureInfo("es-ES"))

                    'Total
                    auxPaso = .DgvCuotas(4, y).Value
                    auxTotalPagar = auxTotalPagar + auxPaso
                    FrmEstadoCuenta.LblTotal7.Text = auxPaso.ToString("n0", New CultureInfo("es-ES"))

                    y = y + 1

                End If


                '----------------------------------------------------------------
                '--- Octava cuota mas atrasada
                '----------------------------------------------------------------

                'Se pregunta por el primer dato de dias mora disponible que sigue
                auxTest = .DgvCuotas(6, y).Value

                If y <= auxLineas And auxTest > 0 Then
                    'Completa primera linea
                    'Numero Cuota
                    FrmEstadoCuenta.LblCuota8.Text = .DgvCuotas(0, y).Value
                    'Vencimiento
                    FrmEstadoCuenta.LblVencimiento8.Text = .DgvCuotas(5, y).Value
                    'Dias Atraso
                    FrmEstadoCuenta.LblDiasAtraso8.Text = .DgvCuotas(6, y).Value
                    'Valor Cuota
                    auxPaso = .DgvCuotas(1, y).Value
                    FrmEstadoCuenta.LblValor8.Text = auxPaso.ToString("n0", New CultureInfo("es-ES"))
                    'Interes
                    auxPaso = .DgvCuotas(2, y).Value
                    FrmEstadoCuenta.LblInteres8.Text = auxPaso.ToString("n0", New CultureInfo("es-ES"))
                    'Gastos
                    auxPaso = .DgvCuotas(3, y).Value
                    FrmEstadoCuenta.LblGastos8.Text = auxPaso.ToString("n0", New CultureInfo("es-ES"))

                    'Total
                    auxPaso = .DgvCuotas(4, y).Value
                    auxTotalPagar = auxTotalPagar + auxPaso
                    FrmEstadoCuenta.LblTotal8.Text = auxPaso.ToString("n0", New CultureInfo("es-ES"))

                    y = y + 1

                End If

                '----------------------------------------------------------------
                '--- Novena cuota mas atrasada
                '----------------------------------------------------------------

                'Se pregunta por el primer dato de dias mora disponible que sigue
                auxTest = .DgvCuotas(6, y).Value

                If y <= auxLineas And auxTest > 0 Then
                    'Completa primera linea
                    'Numero Cuota
                    FrmEstadoCuenta.LblCuota9.Text = .DgvCuotas(0, y).Value
                    'Vencimiento
                    FrmEstadoCuenta.LblVencimiento9.Text = .DgvCuotas(5, y).Value
                    'Dias Atraso
                    FrmEstadoCuenta.LblDiasAtraso9.Text = .DgvCuotas(6, y).Value
                    'Valor Cuota
                    auxPaso = .DgvCuotas(1, y).Value
                    FrmEstadoCuenta.LblValor9.Text = auxPaso.ToString("n0", New CultureInfo("es-ES"))
                    'Interes
                    auxPaso = .DgvCuotas(2, y).Value
                    FrmEstadoCuenta.LblInteres9.Text = auxPaso.ToString("n0", New CultureInfo("es-ES"))
                    'Gastos
                    auxPaso = .DgvCuotas(3, y).Value
                    FrmEstadoCuenta.LblGastos9.Text = auxPaso.ToString("n0", New CultureInfo("es-ES"))

                    'Total
                    auxPaso = .DgvCuotas(4, y).Value
                    auxTotalPagar = auxTotalPagar + auxPaso
                    FrmEstadoCuenta.LblTotal9.Text = auxPaso.ToString("n0", New CultureInfo("es-ES"))

                    y = y + 1

                End If


                '----------------------------------------------------------------
                '--- Decima cuota mas atrasada
                '----------------------------------------------------------------

                'Se pregunta por el primer dato de dias mora disponible que sigue
                auxTest = .DgvCuotas(6, y).Value

                If y <= auxLineas And auxTest > 0 Then
                    'Completa primera linea
                    'Numero Cuota
                    FrmEstadoCuenta.LblCuota10.Text = .DgvCuotas(0, y).Value
                    'Vencimiento
                    FrmEstadoCuenta.LblVencimiento10.Text = .DgvCuotas(5, y).Value
                    'Dias Atraso
                    FrmEstadoCuenta.LblDiasAtraso10.Text = .DgvCuotas(6, y).Value
                    'Valor Cuota
                    auxPaso = .DgvCuotas(1, y).Value
                    FrmEstadoCuenta.LblValor10.Text = auxPaso.ToString("n0", New CultureInfo("es-ES"))
                    'Interes
                    auxPaso = .DgvCuotas(2, y).Value
                    FrmEstadoCuenta.LblInteres10.Text = auxPaso.ToString("n0", New CultureInfo("es-ES"))
                    'Gastos
                    auxPaso = .DgvCuotas(3, y).Value
                    FrmEstadoCuenta.LblGastos10.Text = auxPaso.ToString("n0", New CultureInfo("es-ES"))

                    'Total
                    auxPaso = .DgvCuotas(4, y).Value
                    auxTotalPagar = auxTotalPagar + auxPaso
                    FrmEstadoCuenta.LblTotal10.Text = auxPaso.ToString("n0", New CultureInfo("es-ES"))

                    y = y + 1

                End If


                '----------------------------------------------------------------
                '--- Onceava cuota mas atrasada
                '----------------------------------------------------------------

                'Se pregunta por el primer dato de dias mora disponible que sigue
                auxTest = .DgvCuotas(6, y).Value

                If y <= auxLineas And auxTest > 0 Then
                    'Completa primera linea
                    'Numero Cuota
                    FrmEstadoCuenta.LblCuota11.Text = .DgvCuotas(0, y).Value
                    'Vencimiento
                    FrmEstadoCuenta.LblVencimiento11.Text = .DgvCuotas(5, y).Value
                    'Dias Atraso
                    FrmEstadoCuenta.LblDiasAtraso11.Text = .DgvCuotas(6, y).Value
                    'Valor Cuota
                    auxPaso = .DgvCuotas(1, y).Value
                    FrmEstadoCuenta.LblValor11.Text = auxPaso.ToString("n0", New CultureInfo("es-ES"))
                    'Interes
                    auxPaso = .DgvCuotas(2, y).Value
                    FrmEstadoCuenta.LblInteres11.Text = auxPaso.ToString("n0", New CultureInfo("es-ES"))
                    'Gastos
                    auxPaso = .DgvCuotas(3, y).Value
                    FrmEstadoCuenta.LblGastos11.Text = auxPaso.ToString("n0", New CultureInfo("es-ES"))

                    'Total
                    auxPaso = .DgvCuotas(4, y).Value
                    auxTotalPagar = auxTotalPagar + auxPaso
                    FrmEstadoCuenta.LblTotal11.Text = auxPaso.ToString("n0", New CultureInfo("es-ES"))

                    y = y + 1

                End If

                '----------------------------------------------------------------
                '--- Fin Cuotas Morosas
                '----------------------------------------------------------------



            End If

            'Total a pagar
            FrmEstadoCuenta.LblTotalAPagar.Text = auxTotalPagar.ToString("n0", New CultureInfo("es-ES"))
            'auxTotalPagar


            If y <= auxLineas Then
                'Hay Datos para cargar en Estado de Cuenta

                'Se pregunta por el primer dato de dias mora disponible que sigue
                auxTest = .DgvCuotas(6, y).Value

                If auxTest <= 0 Then

                    'Primer Proximo Vencimiento
                    FrmEstadoCuenta.LblFechaProximoVencimiento1.Text = .DgvCuotas(5, y).Value
                    auxPaso = .DgvCuotas(4, y).Value
                    FrmEstadoCuenta.LblMontoProximoVencimiento1.Text = auxPaso.ToString("n0", New CultureInfo("es-ES"))

                    y = y + 1
                    auxTest = .DgvCuotas(6, y).Value

                    If auxTest <= 0 Then

                        'Segundo Proximo Vencimiento
                        FrmEstadoCuenta.LblFechaProximoVencimiento2.Text = .DgvCuotas(5, y).Value
                        auxPaso = .DgvCuotas(4, y).Value
                        FrmEstadoCuenta.LblMontoProximoVencimiento2.Text = auxPaso.ToString("n0", New CultureInfo("es-ES"))

                        y = y + 1
                        auxTest = .DgvCuotas(6, y).Value

                        If auxTest <= 0 Then
                            'Segundo Proximo Vencimiento
                            FrmEstadoCuenta.LblFechaProximoVencimiento3.Text = .DgvCuotas(5, y).Value
                            auxPaso = .DgvCuotas(4, y).Value
                            FrmEstadoCuenta.LblMontoProximoVencimiento3.Text = auxPaso.ToString("n0", New CultureInfo("es-ES"))

                            y = y + 1
                            auxTest = .DgvCuotas(6, y).Value

                        End If

                    End If

                End If

            End If


        End With
    End Sub


    Sub ImprimePDFEstadoCuenta()

        Dim auxPaso As String

        auxPaso = ""
        auxPaso = "Estado Cuenta " & Microsoft.VisualBasic.Strings.Right("0000000000" & FrmEstadoCuenta.LblRut.Text, 10) & "-" & Microsoft.VisualBasic.Strings.Right("000000" & FrmEstadoCuenta.LblCredito.Text, 8)

        'Parametros impresion PDF Windows
        With FrmEstadoCuenta.PrintDocumentPDF
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

End Module
