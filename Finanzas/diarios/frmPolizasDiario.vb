Public Class frmPolizasDiario
    Private Sub frmPolizasDiario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.Vw_CXP_RegContable' Puede moverla o quitarla según sea necesario.
        Me.Vw_CXP_RegContableTableAdapter.Fill(Me.DsProduction.Vw_CXP_RegContable, varGlobal_IdEmpresa, 0)
        Me.CXP_tipoDeDocumentoTableAdapter.Fill(Me.DsProduction1.CXP_tipoDeDocumento, varGlobal_IdEmpresa)
    End Sub

    Private Sub cmbTipoDeDocumento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipoDeDocumento.SelectedIndexChanged
        'VwCXPRegContableBindingSource.Filter = "idTipoDocumento = '" & cmbTipoDeDocumento.SelectedValue & "' AND idEmpresa ='" & varGlobal_IdEmpresa & "'"
        Me.Vw_CXP_RegContableTableAdapter.Fill(Me.DsProduction.Vw_CXP_RegContable, varGlobal_IdEmpresa, cmbTipoDeDocumento.SelectedValue)
    End Sub
End Class