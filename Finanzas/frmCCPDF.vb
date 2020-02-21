Public Class frmCCPDF
    Private Sub frmCCPDF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.Vw_CXP_MisSolicitudes' Puede moverla o quitarla según sea necesario.
        Me.Vw_CXP_MisSolicitudesTableAdapter.Fill(Me.DsProduction.Vw_CXP_MisSolicitudes, varGlobal_IdEmpresa)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = 0 Then
            System.IO.File.Copy("\\server-raid2\TmpFinagil\CXP\" & varGlobal_IdEmpresa & "-" & DataGridView1.Rows(e.RowIndex).Cells(0).Value & ".pdf", "C:\Files\" & varGlobal_IdEmpresa & "-" & DataGridView1.Rows(e.RowIndex).Cells(0).Value & ".pdf", True)
            System.Diagnostics.Process.Start("C:\Files\" & varGlobal_IdEmpresa & "-" & DataGridView1.Rows(e.RowIndex).Cells(0).Value & ".pdf")
        End If
    End Sub
End Class