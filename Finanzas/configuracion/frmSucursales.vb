Public Class frmSucursales
    Private Sub CXP_SucursalesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub frmSucursales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsSeguridad1.SUCURSAL' Puede moverla o quitarla según sea necesario.
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_Sucursales' Puede moverla o quitarla según sea necesario.
        Me.CXP_SucursalesTableAdapter.SucXEmpresa_FillBy(Me.DsProduction.CXP_Sucursales, varGlobal_IdEmpresa)


    End Sub

    Private Sub CXP_SucursalesBindingNavigatorSaveItem_Click_2(sender As Object, e As EventArgs) Handles CXP_SucursalesBindingNavigatorSaveItem.Click
        Me.Validate()
        CXP_SucursalesBindingSource.Current("idEmpresa") = varGlobal_IdEmpresa
        Me.CXP_SucursalesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsProduction)

    End Sub
End Class