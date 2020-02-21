Public Class frmSCPDF
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = 0 Then
            System.Diagnostics.Process.Start(My.Settings.RutaTmp & "CXP\" & varGlobal_IdEmpresa & "-" & DataGridView1.Rows(e.RowIndex).Cells(0).Value & ".pdf")
        End If
    End Sub

    Private Sub frmSCPDF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Vw_CXP_MisSolicitudesSCTableAdapter.Fill(Me.DsProduction.Vw_CXP_MisSolicitudesSC, varGlobal_IdEmpresa)
    End Sub
End Class