Public Class frmDepartamentos
    Private Sub CXP_DepartamentosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CXP_DepartamentosBindingNavigatorSaveItem.Click
        Me.Validate()
        CXP_DepartamentosBindingSource.Current("idEmpresa") = varGlobal_IdEmpresa
        Me.CXP_DepartamentosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsProduction)

    End Sub

    Private Sub frmDepartamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_Departamentos' Puede moverla o quitarla según sea necesario.
        Me.CXP_DepartamentosTableAdapter.PorEmpresa_FillBy(Me.DsProduction.CXP_Departamentos, varGlobal_IdEmpresa)

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class