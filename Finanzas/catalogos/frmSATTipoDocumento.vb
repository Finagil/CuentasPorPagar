Public Class frmSATTipoDocumento
    Private Sub CXP_tipoDocumentoSatBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CXP_tipoDocumentoSatBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CXP_tipoDocumentoSatBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsProduction)

    End Sub

    Private Sub frmSATTipoDocumento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_tipoDocumentoSat' Puede moverla o quitarla según sea necesario.
        Me.CXP_tipoDocumentoSatTableAdapter.Fill(Me.DsProduction.CXP_tipoDocumentoSat)

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class