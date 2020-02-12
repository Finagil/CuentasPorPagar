Public Class frmNacionalidades
    Private Sub CXP_c_PaisBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CXP_c_PaisBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CXP_c_PaisBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsProduction)

    End Sub

    Private Sub frmNacionalidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_c_Pais' Puede moverla o quitarla según sea necesario.
        Me.CXP_c_PaisTableAdapter.Fill(Me.DsProduction.CXP_c_Pais)

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        CXP_c_PaisBindingSource.Filter = "Descripcion like'%%" & txtBuscar.Text.Trim & "'"
    End Sub
End Class