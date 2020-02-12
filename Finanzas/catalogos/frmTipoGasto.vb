Public Class frmTipoGasto
    Private Sub CXP_TipoGastoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CXP_TipoGastoBindingNavigatorSaveItem.Click
        CXP_TipoGastoBindingSource.Current("idEmpresa") = varGlobal_IdEmpresa
        Me.Validate()
        Me.CXP_TipoGastoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsProduction)

    End Sub

    Private Sub frmTipoGasto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_TipoGasto' Puede moverla o quitarla según sea necesario.
        Me.CXP_TipoGastoTableAdapter.Fill(Me.DsProduction.CXP_TipoGasto, mdicuentasPorPagar.varGlEmpresa)

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class