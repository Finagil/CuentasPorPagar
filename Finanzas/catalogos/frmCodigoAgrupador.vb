Public Class frmCodigoAgrupador
    Private Sub CXP_CodigoAgrupadorBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CXP_CodigoAgrupadorBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CXP_CodigoAgrupadorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsProduction)

    End Sub

    Private Sub frmCodigoAgrupador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_CodigoAgrupador' Puede moverla o quitarla según sea necesario.
        Me.CXP_CodigoAgrupadorTableAdapter.Fill(Me.DsProduction.CXP_CodigoAgrupador)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNivel.SelectedIndexChanged

    End Sub
End Class