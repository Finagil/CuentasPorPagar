Public Class frmSolicitudesDePago
    Private Sub CXP_DiariosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CXP_DiariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsProduction)

    End Sub

    Private Sub frmSolicitudesDePago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_Conceptos' Puede moverla o quitarla según sea necesario.
        Me.CXP_ConceptosTableAdapter.Fill(Me.DsProduction.CXP_Conceptos, mdicuentasPorPagar.varGlEmpresa)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_XmlCfdi' Puede moverla o quitarla según sea necesario.
        'Me.CXP_XmlCfdiTableAdapter.Fill(Me.DsProduction.CXP_XmlCfdi)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_Proveedores' Puede moverla o quitarla según sea necesario.
        Me.CXP_ProveedoresTableAdapter.Fill(Me.DsProduction.CXP_Proveedores)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_Diarios' Puede moverla o quitarla según sea necesario.
        Me.CXP_DiariosTableAdapter.Fill(Me.DsProduction.CXP_Diarios)
    End Sub

    Private Sub txtBuscaProveedor_TextChanged(sender As Object, e As EventArgs) Handles txtBuscaProveedor.TextChanged
        If txtBuscaProveedor.Text.Length > 4 Then
            CXPProveedoresBindingSource.Filter = "rfc like '%" & txtBuscaProveedor.Text.Trim & "%' or razonSocial like '%" & txtBuscaProveedor.Text.Trim & "%'"
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProveedores.SelectedIndexChanged
        If Not cmbProveedores.SelectedValue Is Nothing Then
            'If RfcTextBox.Text.Length > 10 Then
            Dim fCFDI As New frmSolicitudesDePagoCFDI
            Dim mdiCFDI As New mdicuentasPorPagar
            mdiCFDI = MdiParent
            fCFDI.var_rfcProveedor = CXP_ProveedoresTableAdapter.ObtieneRFC_ScalarQuery(cmbProveedores.SelectedValue)
            Me.Cursor = Cursors.WaitCursor
            fCFDI.MdiParent = mdiCFDI
            fCFDI.Show()
            Me.Cursor = Cursors.Default
            'End If
        End If
    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbProveedores.KeyPress
        If Keys.Enter Then
            If Not cmbProveedores.SelectedValue Is Nothing Then
                'If RfcTextBox.Text.Length > 10 Then
                Dim fCFDI As New frmSolicitudesDePagoCFDI
                Dim mdiCFDI As New mdicuentasPorPagar
                mdiCFDI = MdiParent
                fCFDI.var_rfcProveedor = CXP_ProveedoresTableAdapter.ObtieneRFC_ScalarQuery(cmbProveedores.SelectedValue)
                Me.Cursor = Cursors.WaitCursor
                    fCFDI.MdiParent = mdiCFDI
                    fCFDI.Show()
                    Me.Cursor = Cursors.Default
                'End If
            End If
        End If
    End Sub
End Class