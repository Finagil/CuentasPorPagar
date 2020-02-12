Public Class frmContTipoDocumentos
    Private Sub CXP_tipoDeDocumentoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CXP_tipoDeDocumentoBindingNavigatorSaveItem.Click
        CXP_tipoDeDocumentoBindingSource.Current("idEmpresa") = varGlobal_IdEmpresa
        Me.Validate()
        Me.CXP_tipoDeDocumentoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsProduction)

    End Sub

    Private Sub frmSATTipoDocumentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_tipoDeDocumento' Puede moverla o quitarla según sea necesario.
        Me.CXP_tipoDeDocumentoTableAdapter.Fill(Me.DsProduction.CXP_tipoDeDocumento, varGlobal_IdEmpresa)

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub FolioInicialTextBox_TextChanged(sender As Object, e As EventArgs) Handles FolioInicialTextBox.TextChanged
        FolioActualTextBox.Text = FolioInicialTextBox.Text
    End Sub
End Class