Public Class frmTipoConcepto
    Private Sub CXP_tipoConceptoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CXP_tipoConceptoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CXP_tipoConceptoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsProduction)

    End Sub

    Private Sub frmTipoConcepto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_tipoConcepto' Puede moverla o quitarla según sea necesario.
        Me.CXP_tipoConceptoTableAdapter.Fill(Me.DsProduction.CXP_tipoConcepto)

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class