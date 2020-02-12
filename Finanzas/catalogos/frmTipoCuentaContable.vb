Public Class frmTipoCuentaContable
    Private Sub CXP_tipoCuentaContableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CXP_tipoCuentaContableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CXP_tipoCuentaContableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsProduction)

    End Sub

    Private Sub frmTipoCuentaContable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_tipoCuentaContable' Puede moverla o quitarla según sea necesario.
        Me.CXP_tipoCuentaContableTableAdapter.Fill(Me.DsProduction.CXP_tipoCuentaContable)

    End Sub
End Class