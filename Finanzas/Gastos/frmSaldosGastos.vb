
Imports System.IO.Stream
Imports System.IO
Imports System.Text
Public Class frmSaldosGastos


    Private Sub frmSaldosGastos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim taEmpresa As New dsProductionTableAdapters.CXP_EmpresasTableAdapter

        'TODO: esta línea de código carga datos en la tabla 'DsProduction.Vw_CXP_SaldoComprobacionGastos' Puede moverla o quitarla según sea necesario.
        Me.Vw_CXP_SaldoComprobacionGastosTableAdapter.Fill(Me.DsProduction.Vw_CXP_SaldoComprobacionGastos, varGlobal_IdEmpresa, taEmpresa.ObtConceptoGts_ScalarQuery(varGlobal_IdEmpresa))
    End Sub

    Private Sub Vw_CXP_SaldoComprobacionGastosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Vw_CXP_SaldoComprobacionGastosDataGridView.CellContentClick
        If e.ColumnIndex = 0 Then
            System.IO.File.Copy("\\server-raid2\TmpFinagil\CXP\" & varGlobal_IdEmpresa & "-" & Vw_CXP_SaldoComprobacionGastosDataGridView.Rows(e.RowIndex).Cells(0).Value & ".pdf", "C:\Files\" & varGlobal_IdEmpresa & "-" & Vw_CXP_SaldoComprobacionGastosDataGridView.Rows(e.RowIndex).Cells(0).Value & ".pdf", True)
            System.Diagnostics.Process.Start("C:\Files\" & varGlobal_IdEmpresa & "-" & Vw_CXP_SaldoComprobacionGastosDataGridView.Rows(e.RowIndex).Cells(0).Value & ".pdf")
        ElseIf e.ColumnIndex <> 0 Then
            Dim frmDet As New frmSaldosGastosDetalle
            frmDet.varFolioSol = Vw_CXP_SaldoComprobacionGastosDataGridView.Rows(e.RowIndex).Cells(0).Value
            frmDet.varImpDepsotitado = Vw_CXP_SaldoComprobacionGastosDataGridView.Rows(e.RowIndex).Cells(4).Value
            frmDet.varImpComprobado = CDec(Vw_CXP_SaldoComprobacionGastosDataGridView.Rows(e.RowIndex).Cells(4).Value) - CDec(Vw_CXP_SaldoComprobacionGastosDataGridView.Rows(e.RowIndex).Cells(6).Value)
            frmDet.varImpPorComprobar = Vw_CXP_SaldoComprobacionGastosDataGridView.Rows(e.RowIndex).Cells(6).Value
            frmDet.Show()
        End If
    End Sub
End Class