Public Class frmAutorizaciones
    Private Sub frmAutorizaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsSeguridad1.USUARIO1' Puede moverla o quitarla según sea necesario.
        Me.USUARIO1TableAdapter.Fill(Me.DsSeguridad1.USUARIO1)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_Sucursales' Puede moverla o quitarla según sea necesario.
        Me.CXP_SucursalesTableAdapter.Fill(Me.DsProduction.CXP_Sucursales)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_Autorizaciones' Puede moverla o quitarla según sea necesario.
        Me.CXP_AutorizacionesTableAdapter.Fill(Me.DsProduction.CXP_Autorizaciones)
        'TODO: esta línea de código carga datos en la tabla 'DsSeguridad.USUARIO' Puede moverla o quitarla según sea necesario.
        Me.USUARIOTableAdapter.Fill(Me.DsSeguridad.USUARIO)
        'TODO: esta línea de código carga datos en la tabla 'DsSeguridad.USUARIO' Puede moverla o quitarla según sea necesario.
        Me.USUARIOTableAdapter.Fill(Me.DsSeguridad.USUARIO)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_Sucursales' Puede moverla o quitarla según sea necesario.
        Me.CXP_SucursalesTableAdapter.Fill(Me.DsProduction.CXP_Sucursales)

    End Sub

    Private Sub CXP_AutorizacionesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CXP_AutorizacionesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CXP_AutorizacionesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsProduction)

    End Sub

    Private Sub cmbSucursal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSucursal.SelectedIndexChanged
        txtSucursal.Text = cmbSucursal.SelectedValue
    End Sub

    Private Sub cmbDepartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDepartamento.SelectedIndexChanged
        txtDepartamento.Text = cmbDepartamento.SelectedValue
    End Sub
End Class