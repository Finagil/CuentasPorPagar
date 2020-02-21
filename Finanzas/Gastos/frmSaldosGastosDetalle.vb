Public Class frmSaldosGastosDetalle
    Public varFolioSol As Integer
    Public varImpDepsotitado As Decimal
    Public varImpComprobado As Decimal
    Public varImpPorComprobar As Decimal
    Private Sub CXP_ComprobGtosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CXP_ComprobGtosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsProduction)

    End Sub

    Private Sub frmSaldosGastosDetalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_ComprobGtos' Puede moverla o quitarla según sea necesario.
        Me.CXP_ComprobGtosTableAdapter.DetalleComprobacion_FillBy(Me.DsProduction.CXP_ComprobGtos, varFolioSol, CDec(varGlobal_IdEmpresa))
        lblImpDepositado.Text = varImpDepsotitado.ToString("c")
        lblImpComprobado.Text = varImpComprobado.ToString("c")
        lblPorComprobar.Text = varImpPorComprobar.ToString("c")
    End Sub

    Private Sub CXP_ComprobGtosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CXP_ComprobGtosDataGridView.CellContentClick
        If e.ColumnIndex = 0 Then
            System.IO.File.Copy(My.Settings.RutaTmp & "GTS\" & varGlobal_IdEmpresa & "-" & CXP_ComprobGtosDataGridView.Rows(e.RowIndex).Cells(0).Value & ".pdf", "C:\Files\" & varGlobal_IdEmpresa & "-" & CXP_ComprobGtosDataGridView.Rows(e.RowIndex).Cells(0).Value & ".pdf", True)
            System.Diagnostics.Process.Start("C:\Files\" & varGlobal_IdEmpresa & "-" & CXP_ComprobGtosDataGridView.Rows(e.RowIndex).Cells(0).Value & ".pdf")
        End If
    End Sub
End Class