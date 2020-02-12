Public Class Bancos
    Private Sub CXP_BancosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CXP_BancosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CXP_BancosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsProduction)
    End Sub

    Private Sub frmSatBancos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_Bancos' Puede moverla o quitarla según sea necesario.
        Me.CXP_BancosTableAdapter.Fill(Me.DsProduction.CXP_Bancos)
    End Sub
End Class