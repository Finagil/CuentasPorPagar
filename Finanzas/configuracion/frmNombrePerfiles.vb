Public Class frmNombrePerfiles
    Private Sub CXP_PerfilesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CXP_PerfilesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CXP_PerfilesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsProduction)

    End Sub

    Private Sub frmNombrePerfiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_Perfiles' Puede moverla o quitarla según sea necesario.
        Me.CXP_PerfilesTableAdapter.Fill(Me.DsProduction.CXP_Perfiles)

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class