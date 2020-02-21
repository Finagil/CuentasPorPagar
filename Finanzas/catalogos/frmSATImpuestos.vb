Public Class frmSATImpuestos
    Private Sub CXP_ImpuestoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CXP_ImpuestoBindingNavigatorSaveItem.Click
        CXP_ImpuestoBindingSource.Current("idEmpresa") = varGlobal_IdEmpresa
        Me.Validate()
        Me.CXP_ImpuestoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsProduction)

    End Sub

    Private Sub frmSATImpuestos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If varGlobal_IdEmpresa = "24" Then
            CuentasTableAdapter.Connection.ConnectionString = "Data Source=compaq01\compac;Initial Catalog=ctCONEARFIN;Persist Security Info=True;User ID=finagil;Password=finagil"
        Else
            CuentasTableAdapter.Connection.ConnectionString = "Data Source=compaq01\compac;Initial Catalog=ctFINAGILCONEFINAGIL2015;Persist Security Info=True;User ID=finagil;Password=finagil"
        End If

        Me.CuentasTableAdapter.Fill(Me.Contpaq.Cuentas)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_CuentasContables' Puede moverla o quitarla según sea necesario.
        Me.CXP_CuentasContablesTableAdapter.Fill(Me.DsProduction.CXP_CuentasContables, varGlobal_IdEmpresa)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_Impuesto' Puede moverla o quitarla según sea necesario.
        Me.CXP_ImpuestoTableAdapter.Fill(Me.DsProduction.CXP_Impuesto, varGlobal_IdEmpresa)

        If cmbTipo.Text = "Local" Then
            cmbDescripcion.Enabled = False
            cmbFactor.Enabled = False
        Else
            cmbDescripcion.Enabled = True
            cmbFactor.Enabled = True
        End If

    End Sub

    Private Sub cmbDescripcion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDescripcion.SelectedIndexChanged
        If cmbDescripcion.Text = "ISR" Then
            ImpuestoTextBox.Text = "001"
        ElseIf cmbDescripcion.Text = "IVA" Then
            ImpuestoTextBox.Text = "002"
        ElseIf cmbDescripcion.Text = "IEPS" Then
            ImpuestoTextBox.Text = "003"
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub cmbEfecto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEfecto.SelectedIndexChanged
        If cmbEfecto.Text = "TRA" And cmbDescripcion.Text = "ISR" Then
            MsgBox("El impuesto ISR no puede ser trasladado", MsgBoxStyle.Information)
            cmbEfecto.Text = "RET"
        End If
    End Sub

    Private Sub cmbEfecto_LostFocus(sender As Object, e As EventArgs) Handles cmbEfecto.LostFocus
        If cmbEfecto.Text = "TRA" And cmbDescripcion.Text = "ISR" Then
            MsgBox("El impuesto ISR no puede ser trasladado", MsgBoxStyle.Information)
            cmbEfecto.Text = "RET"
        End If
    End Sub

    Private Sub cmbTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipo.SelectedIndexChanged
        If cmbTipo.Text = "Local" Then
            cmbDescripcion.Enabled = False
            cmbFactor.Enabled = False
        Else
            cmbDescripcion.Enabled = True
            cmbFactor.Enabled = True
        End If
    End Sub

    Private Sub cmbFactor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFactor.SelectedIndexChanged

    End Sub
End Class