Public Class frmCompGstPDF
    Private Sub frmCompGstPDF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Vw_CXP_MisComprobacionesTableAdapter.Fill(Me.DsProduction.Vw_CXP_MisComprobaciones, varGlobal_IdEmpresa)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = 0 Then
            System.Diagnostics.Process.Start(My.Settings.RutaTMP & "CXP\" & varGlobal_IdEmpresa & "-" & DataGridView1.Rows(e.RowIndex).Cells(0).Value & ".pdf")
        End If
        If e.ColumnIndex = 6 Then
            System.Diagnostics.Process.Start(My.Settings.RutaTMP & "GTS\" & varGlobal_IdEmpresa & "-" & DataGridView1.Rows(e.RowIndex).Cells(6).Value & ".pdf")
        End If
    End Sub
End Class