
Public Class fmrPolizasDiarioSCuenta

    Dim pFila As Integer = 0
    Dim pColumna As Integer = 0
    Private Sub fmrPolizasDiarioSCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CXP_RegContTableAdapter.Fill(Me.DsProduction1.CXP_RegCont)
        Me.CXP_CuentasContablesTableAdapter.Fill(Me.DsProduction1.CXP_CuentasContables, varGlobal_IdEmpresa)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        ComboBox1.Visible = True
        ComboBox1.Location = New Point(DataGridView1.GetCellDisplayRectangle(pColumna, pFila, True).X, DataGridView1.GetCellDisplayRectangle(pColumna, pFila, True).Y)
        ComboBox1.Focus()
        pFila = e.RowIndex
        pColumna = e.ColumnIndex
    End Sub


    Private Sub ComboBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox1.KeyDown
        Select Case e.KeyData
            Case Keys.Escape And ComboBox1.Visible = True
                ComboBox1.Visible = False
                DataGridView1.Rows(pFila).Cells(1).Value = ComboBox1.SelectedValue
                'DataGridView1.Focus()
            Case Keys.Enter And ComboBox1.Visible = True
                ComboBox1.Visible = False
                DataGridView1.Rows(pFila).Cells(1).Value = ComboBox1.SelectedValue
                'DataGridView1.Focus()
        End Select
    End Sub

    Private Sub ComboBox1_Click(sender As Object, e As EventArgs) Handles ComboBox1.Click
        DataGridView1.Rows(pFila).Cells(1).Value = ComboBox1.SelectedValue
        ComboBox1.Visible = False
    End Sub



    Private Sub DataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView1.KeyDown
        Select Case e.KeyData
            Case Keys.Enter And ComboBox1.Visible = False

                ComboBox1.Visible = True
                ComboBox1.Location = New Point(DataGridView1.GetCellDisplayRectangle(pColumna, pFila, True).X, DataGridView1.GetCellDisplayRectangle(pColumna, pFila, True).Y)
                ComboBox1.Focus()
                pColumna = DataGridView1.CurrentCell.ColumnIndex
                pFila = DataGridView1.CurrentCell.RowIndex
        End Select
    End Sub
End Class