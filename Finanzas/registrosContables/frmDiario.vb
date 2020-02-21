Public Class frmDiario

    Dim dtRegContable As New dsProduction.CXP_RegContDataTable
    Dim taRegContableVw As New dsProductionTableAdapters.Vw_CXP_RegContableTableAdapter
    Dim taRegCont As New dsProductionTableAdapters.CXP_tipoDeDocumentoTableAdapter
    Dim dtRegContableVw As New dsProduction.Vw_CXP_RegContableDataTable
    Dim taRegContT As New dsProductionTableAdapters.CXP_RegContTableAdapter
    Dim taCuentas As New contpaqTableAdapters.CuentasTableAdapter
    Dim filaR As Integer = 0


    Private Sub frmDiario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    End Sub

    Private Sub FolioTipoDocumentoTextBox_TextChanged(sender As Object, e As EventArgs) Handles FolioTipoDocumentoTextBox.TextChanged
        actualiza()
    End Sub

    Private Sub gvwEventos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvwEventos.CellClick

        If e.ColumnIndex = 7 Then
            pnlActualizaCuenta.Visible = True
            txtCuenta.Focus()
            filaR = e.RowIndex
            Try
                txtCuenta.Text = gvwEventos.Item(7, e.RowIndex).Value
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical, "Error en cuenta")
            End Try
        End If
    End Sub


    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        pnlActualizaCuenta.Visible = False
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        actualizaCuenta()
    End Sub

    Public Sub actualizaCuenta()
        pnlActualizaCuenta.Visible = False
        Dim varCuenta As String = txtCuenta.Text.Replace("-", "")
        If varCuenta <> gvwEventos.Item(7, filaR).Value Then
            If taCuentas.ExisteCuenta_ScalarQuery(varCuenta) <> "NE" Then
                taRegContT.ActualizaCuenta_UpdateQuery(CuentasTableAdapter.ObtieneIdCta_ScalarQuery(varCuenta), gvwEventos.Item(0, filaR).Value)
            Else
                MsgBox("La cuenta contable especificada no existe", MsgBoxStyle.Critical, "Error en cuenta")
            End If
        End If
        actualiza()
    End Sub

    Public Sub actualiza()
        txtConceptos.Text = ""
        Dim totalCargos As Decimal = 0
        Dim totalAbonos As Decimal = 0
        Dim dtConceptos As New dsProduction.CXP_RegContDataTable
        Dim rowConceptos As dsProduction.CXP_RegContRow

        If FolioTipoDocumentoTextBox.Text <> "" And IdTipoDocumentoTextBox.Text <> "" Then
            taRegContableVw.EventoContableDetalle_FillBy1(dtRegContableVw, varGlobal_IdEmpresa, IdTipoDocumentoTextBox.Text, FolioTipoDocumentoTextBox.Text, dtpFecha1.Value.AddDays(-1), dtpFecha2.Value)
            gvwEventos.DataSource = dtRegContableVw

            taRegContT.Conceptos_FillBy1(dtConceptos, IdTipoDocumentoTextBox.Text, FolioTipoDocumentoTextBox.Text, varGlobal_IdEmpresa, dtpFecha1.Value.AddDays(-1), dtpFecha2.Value)
            For Each rowConceptos In dtConceptos.Rows
                txtConceptos.Text += rowConceptos.concepto & "  "
            Next
        End If
        Dim cont As Integer = 0
        Dim dtCuentas As New contpaq.CuentasDataTable
        Dim rwCuentas As contpaq.CuentasRow
        For Each rows As DataGridViewRow In gvwEventos.Rows
            CuentasTableAdapter.DatosCtas_FillBy(dtCuentas, gvwEventos.Item(6, cont).Value)
            If dtCuentas.Rows.Count >= 1 Then
                rwCuentas = dtCuentas.Rows(0)
                gvwEventos.Item(7, cont).Value = rwCuentas.Codigo.ToString.Insert(4, "-").Insert(7, "-").Insert(10, "-").Insert(15, "-")
                gvwEventos.Item(8, cont).Value = rwCuentas.Nombre
            End If
            totalCargos += CDec(gvwEventos.Item(9, cont).Value)
            totalAbonos += CDec(gvwEventos.Item(10, cont).Value)
            cont += 1
        Next
        txtTotalCargos.Text = totalCargos.ToString("c")
        txtTotalAbonos.Text = totalAbonos.ToString("c")

    End Sub

    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        CXP_RegContTableAdapter.DiariosEstatus0_FillBy(DsProduction.CXP_RegCont, varGlobal_IdEmpresa, taRegCont.ObtTipoDeAsiento_ScalarQuery(varGlobal_IdEmpresa), dtpFecha1.Value.AddDays(-1), dtpFecha2.Value)
        actualiza()
    End Sub

    Private Sub txtCuenta_KeyUp(sender As Object, e As KeyEventArgs) Handles txtCuenta.KeyUp
        If e.KeyCode = Keys.Enter Then
            actualizaCuenta()
        ElseIf e.KeyCode = Keys.Escape Then
            pnlActualizaCuenta.Visible = False
        End If
    End Sub

    Private Sub lklFolSolicitud_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklFolSolicitud.LinkClicked
        System.IO.File.Copy(My.Settings.RutaTmp & "CXP\" & varGlobal_IdEmpresa & "-" & lklFolSolicitud.Text & ".pdf", "C:\Files\" & varGlobal_IdEmpresa & "-" & lklFolSolicitud.Text & ".pdf", True)
        System.Diagnostics.Process.Start("C:\Files\" & varGlobal_IdEmpresa & "-" & lklFolSolicitud.Text & ".pdf")
    End Sub

    Private Sub btnGenPoliza_Click(sender As Object, e As EventArgs) Handles btnGenPoliza.Click
        Dim frmPolizaDiario As New frmReportePolizaDiario
        frmReportePolizaDiario.fecha1 = dtpFecha1.Value
        frmReportePolizaDiario.fecha2 = dtpFecha2.Value
        frmReportePolizaDiario.Show()
    End Sub
End Class