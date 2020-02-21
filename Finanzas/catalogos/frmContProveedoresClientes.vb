Public Class frmContProveedoresClientes
    Private Sub CXP_ProveedoresBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CXP_ProveedoresBindingNavigatorSaveItem.Click

        If Me.ValidaCuentas() = "Ok" Then
            Me.CXP_CuentasBancariasProvBindingSource.Current("idProveedor") = Me.CXP_ProveedoresBindingSource.Current("idProveedor")
            Me.Validate()
            Me.CXP_ProveedoresBindingSource.EndEdit()
            Me.CXP_CuentasBancariasProvBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DsProduction)
            MsgBox("Actualización correcta", MsgBoxStyle.Information, "Actualización de registros")
        End If

        If Me.ValidaCuentas() = "Ok1" Then
            Me.Validate()
            Me.CXP_ProveedoresBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DsProduction)
            MsgBox("Actualización correcta", MsgBoxStyle.Information, "Actualización de registros")
        End If
        'Dim f As Integer
        'For f = 0 To Me.Controls.Count - 1
        '    If TypeOf Me.Controls(f) Is TextBox Or TypeOf Me.Controls(f) Is CheckBox Or TypeOf Me.Controls(f) Is DateTimePicker Or TypeOf Me.Controls(f) Is ComboBox Then
        '        Me.Controls(f).Enabled = False
        '    End If
        'Next
        'BindingNavigatorAddNewItem.Enabled = True
        'CXP_ProveedoresBindingNavigatorSaveItem.Enabled = False
    End Sub

    Function ValidaCuentas()
        Dim varOk As String = ""
        For Each fCuentas As DataGridViewRow In CXP_CuentasBancariasProvDataGridView.Rows

            If fCuentas.Cells(3).Value IsNot Nothing Then
                If fCuentas.Cells(3).Value.ToString.Length <> 10 And IsNumeric(fCuentas.Cells(3).Value) Then
                    MsgBox("La cuenta bancaria debe de ser numerica y con longitud igual a 10", MsgBoxStyle.Critical, "Error en cuentas bancarias")
                    varOk = "Err"
                    Exit Function
                End If
            End If

            If fCuentas.Cells(4).Value IsNot Nothing Then
                If fCuentas.Cells(4).Value.ToString.Length <> 16 And IsNumeric(fCuentas.Cells(4).Value) Then
                    MsgBox("La cuenta CLABE debe de ser numerica y con longitud igual a 18", MsgBoxStyle.Critical, "Error en cuentas CLABE")
                    varOk = "Err"
                    Exit Function
                Else
                    varOk = "Ok"
                End If
            End If

            If CXP_CuentasBancariasProvDataGridView.Rows.Count = 1 And fCuentas.Cells(2).Value Is Nothing Then
                varOk = "Ok1"
            End If
        Next

        Return varOk
    End Function

    Private Sub frmContProveedoresClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_Bancos' Puede moverla o quitarla según sea necesario.
        Me.CXP_BancosTableAdapter.Fill(Me.DsProduction.CXP_Bancos)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_CuentasBancariasProv' Puede moverla o quitarla según sea necesario.
        Me.CXP_CuentasBancariasProvTableAdapter.Fill(Me.DsProduction.CXP_CuentasBancariasProv)
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

        actualizaCuentas()
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

    Public Sub actualizaCuentas()
        CXP_CuentasBancariasProvBindingSource.Filter = "idProveedor=" & CXP_ProveedoresBindingSource.Current("idProveedor")
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Me.CXP_ProveedoresBindingSource.Filter = "razonSocial like '%" & txtBuscaProveedor.Text & "%'"
    End Sub

    Private Sub RazonSocialTextBox_TextChanged(sender As Object, e As EventArgs) Handles RazonSocialTextBox.TextChanged
        actualizaCuentas()
    End Sub

End Class