Public Class frmContProveedoresClientes
    Private Sub CXP_ProveedoresBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CXP_ProveedoresBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CXP_ProveedoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsProduction)
        Dim f As Integer
        For f = 0 To Me.Controls.Count - 1
            If TypeOf Me.Controls(f) Is TextBox Or TypeOf Me.Controls(f) Is CheckBox Or TypeOf Me.Controls(f) Is DateTimePicker Or TypeOf Me.Controls(f) Is ComboBox Then
                Me.Controls(f).Enabled = False
            End If
        Next
        BindingNavigatorAddNewItem.Enabled = True
        CXP_ProveedoresBindingNavigatorSaveItem.Enabled = False
    End Sub

    Private Sub frmContProveedoresClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_Bancos' Puede moverla o quitarla según sea necesario.
        Me.CXP_BancosTableAdapter.Fill(Me.DsProduction.CXP_Bancos)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_c_Pais' Puede moverla o quitarla según sea necesario.
        Me.CXP_c_PaisTableAdapter.Fill(Me.DsProduction.CXP_c_Pais)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_Empresas' Puede moverla o quitarla según sea necesario.
        Me.CXP_EmpresasTableAdapter.Fill(Me.DsProduction.CXP_Empresas)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_CuentasContables' Puede moverla o quitarla según sea necesario.
        Me.CXP_CuentasContablesTableAdapter.Fill(Me.DsProduction.CXP_CuentasContables, mdicuentasPorPagar.varGlEmpresa)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_Sucursales' Puede moverla o quitarla según sea necesario.
        Me.CXP_SucursalesTableAdapter.Fill(Me.DsProduction.CXP_Sucursales)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_Proveedores' Puede moverla o quitarla según sea necesario.
        Me.CXP_ProveedoresTableAdapter.Fill(Me.DsProduction.CXP_Proveedores)
    End Sub

    Private Sub RelacionadoLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub ExtranjeroCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ExtranjeroCheckBox.CheckedChanged

    End Sub

    Private Sub RfcTextBox_LostFocus(sender As Object, e As EventArgs) Handles RfcTextBox.LostFocus
        'utilerias.validaRfc(RfcTextBox.Text.Trim)
        'If utilerias.esFisicaOMoral(RfcTextBox.Text.Trim) = "F" Then
        '    CurpTextBox.Enabled = True
        'ElseIf utilerias.esFisicaOMoral(RfcTextBox.Text.Trim) = "M" Then
        '    CurpTextBox.Enabled = False
        'Else
        '    CurpTextBox.Enabled = False
        'End If
    End Sub

    Private Sub ExtranjeroCheckBox_Click(sender As Object, e As EventArgs) Handles ExtranjeroCheckBox.Click
        If ExtranjeroCheckBox.Checked = True Then
            RfcTextBox.Text = "XEXX010101000"
            CurpTextBox.Enabled = False
            NitTextBox.Enabled = True
            cmbNacionalida.Enabled = True
            cmbNacionalida.Text = ""
        Else
            RfcTextBox.Text = CXP_ProveedoresBindingSource.Current("rfc")
            NitTextBox.Enabled = False
            CXPcPaisBindingSource.Filter = "c_Pais = 'MEX'"
            cmbNacionalida.Text = CXPcPaisBindingSource.Current("Descripcion")
            cmbNacionalida.Enabled = False
        End If
    End Sub


    Private Sub MailTextBox_LostFocus(sender As Object, e As EventArgs) Handles MailTextBox.LostFocus
        If MailTextBox.TextLength > 0 Then
            utilerias.validaMail(MailTextBox.Text.Trim)
        End If
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        Dim f As Integer
        For f = 0 To Me.Controls.Count - 1
            If TypeOf Me.Controls(f) Is TextBox Or TypeOf Me.Controls(f) Is CheckBox Or TypeOf Me.Controls(f) Is DateTimePicker Or TypeOf Me.Controls(f) Is ComboBox Then
                Me.Controls(f).Enabled = True
            End If
        Next
        BindingNavigatorAddNewItem.Enabled = False
        CXP_ProveedoresBindingNavigatorSaveItem.Enabled = True
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        'CXP_ProveedoresBindingSource.Filter = "razonSocial like '%" & 
    End Sub
End Class