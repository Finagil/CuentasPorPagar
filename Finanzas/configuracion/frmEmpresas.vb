Public Class frmEmpresas
    Private Sub frmEmpresas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CFDI_Estado_Nomina' Puede moverla o quitarla según sea necesario.
        Me.CFDI_Estado_NominaTableAdapter.Fill(Me.DsProduction.CFDI_Estado_Nomina)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_c_RegimenFiscal' Puede moverla o quitarla según sea necesario.
        Me.CXP_c_RegimenFiscalTableAdapter.Fill(Me.DsProduction.CXP_c_RegimenFiscal)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_c_Moneda' Puede moverla o quitarla según sea necesario.
        Me.CXP_c_MonedaTableAdapter.Fill(Me.DsProduction.CXP_c_Moneda)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_c_Pais' Puede moverla o quitarla según sea necesario.
        Me.CXP_c_PaisTableAdapter.Fill(Me.DsProduction.CXP_c_Pais)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_Empresas' Puede moverla o quitarla según sea necesario.
        Me.CXP_EmpresasTableAdapter.Fill(Me.DsProduction.CXP_Empresas)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_Empresas' Puede moverla o quitarla según sea necesario.
        Me.CXP_EmpresasTableAdapter.Fill(Me.DsProduction.CXP_Empresas)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_c_Pais' Puede moverla o quitarla según sea necesario.
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_Empresas' Puede moverla o quitarla según sea necesario.
        Me.CXP_tipoDeDocumentoTableAdapter.Fill(Me.DsProduction.CXP_tipoDeDocumento, varGlobal_IdEmpresa)
        Me.CXP_ConceptosTableAdapter.Fill(Me.DsProduction.CXP_Conceptos, varGlobal_IdEmpresa)
        CXP_EmpresasBindingSource.Filter = "idEmpresas ='" & varGlobal_IdEmpresa & "'"
    End Sub

    Private Sub CXP_SucursalesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Try
            Me.Validate()
            Me.CXP_EmpresasBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DsProduction)
            Me.CXP_EmpresasTableAdapter.Fill(Me.DsProduction.CXP_Empresas)
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub RfcTextBox_LostFocus(sender As Object, e As EventArgs) Handles RfcTextBox.LostFocus
        utilerias.validaRfc(RfcTextBox.Text.Trim)
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CXP_ConceptosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CXP_ConceptosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CXP_EmpresasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsProduction)
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class