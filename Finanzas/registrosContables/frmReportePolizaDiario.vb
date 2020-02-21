Public Class frmReportePolizaDiario
    Public fecha1 As Date
    Public fecha2 As Date
    Public var_nEmpresa As String
    Public var_direccion As String
    Public var_rfc As String
    Private Sub frmReportePolizaDiario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rptPoliza As New rptPolizaDiario
        Dim taRegistroVw As New dsProductionTableAdapters.Vw_CXP_RegContableTableAdapter
        Dim dsRegistroVw As New dsProduction
        Dim taRegCont As New dsProductionTableAdapters.CXP_tipoDeDocumentoTableAdapter
        Dim dtPoliza As DataTable
        dtPoliza = New dsProduction.Vw_CXP_RegContableDataTable
        Dim rwCuentas As contpaq.CuentasRow
        Dim dtCuentas As New contpaq.CuentasDataTable
        Dim taRegContD As New dsProductionTableAdapters.Vw_CXP_DetalleCFDITableAdapter
        Dim dtPolizaD As DataTable
        dtPolizaD = New dsProduction.Vw_CXP_DetalleCFDIDataTable


        Try
            If varGlobal_IdEmpresa = "24" Then
                CuentasTableAdapter.Connection.ConnectionString = "Data Source=compaq01\compac;Initial Catalog=ctCONEARFIN;Persist Security Info=True;User ID=finagil;Password=finagil"
            Else
                CuentasTableAdapter.Connection.ConnectionString = "Data Source=compaq01\compac;Initial Catalog=ctFINAGILCONEFINAGIL2015;Persist Security Info=True;User ID=finagil;Password=finagil"
            End If
            'TODO: esta línea de código carga datos en la tabla 'Contpaq.Cuentas' Puede moverla o quitarla según sea necesario.
            Me.CuentasTableAdapter.Fill(Me.Contpaq.Cuentas)
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Error en conexión...")
        End Try

        taRegistroVw.PorRangodeFecha_FillBy1(dtPoliza, varGlobal_IdEmpresa, taRegCont.ObtTipoDeAsiento_ScalarQuery(varGlobal_IdEmpresa), fecha1.AddDays(-1), fecha2)

        Dim uuid As String = ""
        For Each row As dsProduction.Vw_CXP_RegContableRow In dtPoliza.Rows
            CuentasTableAdapter.DatosCtas_FillBy(dtCuentas, row.idCuenta)
            If dtCuentas.Rows.Count >= 1 Then
                rwCuentas = dtCuentas.Rows(0)
                row.cuenta = rwCuentas.Codigo.ToString.Insert(4, "-").Insert(7, "-").Insert(10, "-").Insert(15, "-")
                row.nombre = rwCuentas.Nombre
                'uuid = row.uuid
                'taRegContD.FillBy(dtPolizaD, row.uuid)
            End If
        Next

        taRegContD.Fill(dtPolizaD)

        rptPoliza.SetDataSource(dtPoliza)
        rptPoliza.Subreports(0).SetDataSource(dtPolizaD)
        rptPoliza.Refresh()

        rptPoliza.SetParameterValue("var_nEmpresa", varGlobal_Empresa)
        rptPoliza.SetParameterValue("var_direccion", "direccion")
        rptPoliza.SetParameterValue("var_rfc", varGlobal_rfcEmpresa)
        crvPolizaDiario.ReportSource = rptPoliza
        Refresh()
        WindowState = FormWindowState.Maximized
    End Sub
End Class