Public Class frmSATMonedas
    Private Sub CXP_c_MonedaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CXP_c_MonedaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CXP_c_MonedaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsProduction)

    End Sub

    Private Sub frmSATMonedas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_c_Moneda' Puede moverla o quitarla según sea necesario.
        Me.CXP_c_MonedaTableAdapter.Fill(Me.DsProduction.CXP_c_Moneda)

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        CXP_c_MonedaBindingSource.Filter = "c_NombreMoneda like '%" & txtBuscar.Text & "%'"
    End Sub
End Class