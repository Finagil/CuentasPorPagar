Public Class frmUsuario

    Dim taDatosUsuarios As New dsSeguridadTableAdapters.USUARIOTableAdapter
    Dim taUsuarios As New dsProductionTableAdapters.CXP_UsuariosTableAdapter
    Dim taEmpresas As New dsProductionTableAdapters.CXP_EmpresasTableAdapter
    Dim taTConceptos As New dsProductionTableAdapters.CXP_tipoConceptoTableAdapter
    Dim taConceptos As New dsProductionTableAdapters.CXP_ConceptosTableAdapter
    Dim Hash As New ClaseHash
    Dim arrayEmpresas() As String
    Dim arrayConceptos() As String
    Dim concatEmpresas As String = ""
    Dim concatConceptos As String = ""
    Private Sub frmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_Departamentos' Puede moverla o quitarla según sea necesario.
        Me.CXP_DepartamentosTableAdapter.Fill(Me.DsProduction.CXP_Departamentos)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_Sucursales' Puede moverla o quitarla según sea necesario.
        Me.CXP_SucursalesTableAdapter.Fill(Me.DsProduction.CXP_Sucursales)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_tipoConcepto' Puede moverla o quitarla según sea necesario.
        'Me.CXP_tipoConceptoTableAdapter.Fill(Me.DsProduction.CXP_tipoConcepto)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction2.CXP_Perfiles' Puede moverla o quitarla según sea necesario.
        Me.CXP_PerfilesTableAdapter.Fill(Me.DsProduction2.CXP_Perfiles)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction1.Vw_CXP_NombrePerfiles' Puede moverla o quitarla según sea necesario.

        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_Empresas' Puede moverla o quitarla según sea necesario.
        Me.CXP_EmpresasTableAdapter.Fill(Me.DsProduction.CXP_Empresas)
        'TODO: esta línea de código carga datos en la tabla 'DsSeguridad.USUARIO' Puede moverla o quitarla según sea necesario.
        Me.USUARIOTableAdapter.Fill(Me.DsSeguridad.USUARIO)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_Usuarios' Puede moverla o quitarla según sea necesario.
        Me.CXP_UsuariosTableAdapter.Fill(Me.DsProduction.CXP_Usuarios)
        'TODO: esta línea de código carga datos en la tabla 'DsSeguridad.USUARIO' Puede moverla o quitarla según sea necesario.
        Me.USUARIOTableAdapter.Fill(Me.DsSeguridad.USUARIO)

        Me.CXP_ConceptosTableAdapter.ConcptoesNombreEmpresa_FillBy(Me.DsProduction.CXP_Conceptos, varGlobal_IdEmpresa)

        ActivoCheckBox.Checked = True
        actualiza()
    End Sub

    Private Sub CXP_UsuariosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CXP_UsuariosBindingNavigatorSaveItem.Click
        'If RfcTextBox.Text.Length < 12 Then
        '    MsgBox("El RFC no es correcto, el usuario no quedará regustrado, favor de pedir la corrección del RFC en sl sistema de Finagil y posteriormente continue", MsgBoxStyle.Information, "Datos incompletos")
        '    Exit Sub
        '    Me.Close()
        '    CXP_UsuariosTableAdapter.Dispose()
        'End If
        cmbUsuarioActual.Enabled = False
            btnAgregarUsuario.Enabled = False

        Me.Validate()
        Me.CXP_UsuariosBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DsProduction)

        CXP_UsuariosTableAdapter.Dispose()

        Dim contador As Integer = 0
            For Each rows As DataGridViewRow In dgvEmpresas.Rows
                concatEmpresas = concatEmpresas & dgvEmpresas.Item(0, contador).Value & ","
                contador = contador + 1
            Next
            taUsuarios.ActEmpresas_UpdateQuery(concatEmpresas, CXP_UsuariosBindingSource.Current("idUsuario"))
            concatEmpresas = ""
            Dim contador2 As Integer = 0
            For Each rows As DataGridViewRow In dgvTipoConceptos.Rows
                concatConceptos = concatConceptos & dgvTipoConceptos.Item(0, contador2).Value & ","
                contador2 = contador2 + 1
            Next
            taUsuarios.ActConceptos_UpdateQuery(concatConceptos, CXP_UsuariosBindingSource.Current("idUsuario"))
            concatConceptos = ""

        Me.CXP_UsuariosTableAdapter.Fill(Me.DsProduction.CXP_Usuarios)

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub



    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim valor As Integer = cmbEmpresas.SelectedValue
        Dim cont As Integer = 0

        For Each rows As DataGridViewRow In dgvEmpresas.Rows
            If dgvEmpresas.Item(0, cont).Value = valor Then
                MsgBox("Ya se encuentra la empresa actual...", MsgBoxStyle.Critical)
                Exit Sub
            End If
            cont = cont + 1
        Next

        dgvEmpresas.Rows.Add(cmbEmpresas.SelectedValue, cmbEmpresas.Text, "Eliminar")

    End Sub

    Private Sub dgvEmpresas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmpresas.CellContentClick
        If e.ColumnIndex = 2 Then
            dgvEmpresas.Rows.Remove(dgvEmpresas.CurrentRow)
        End If
    End Sub

    Private Sub UsuarioTextBox_TextChanged(sender As Object, e As EventArgs) Handles UsuarioTextBox.TextChanged
        actualiza()
    End Sub

    Private Sub actualiza()
        If UsuarioTextBox.Text <> "" Then
            dgvEmpresas.Rows.Clear()
            arrayEmpresas = taUsuarios.ObtEmpr_ScalarQuery(UsuarioTextBox.Text).ToString.Split(",") 'CXP_UsuariosBindingSource.Current("empresas").ToString.Split(",")
            For i As Integer = 0 To arrayEmpresas.Length - 1
                If arrayEmpresas(i) <> "" Then
                    dgvEmpresas.Rows.Add()
                    dgvEmpresas.Item(0, i).Value = arrayEmpresas(i)
                    dgvEmpresas.Item(1, i).Value = taEmpresas.ObtEmpresa_ScalarQuery(arrayEmpresas(i))
                    dgvEmpresas.Item(2, i).Value = "Eliminar"
                End If
            Next

            dgvTipoConceptos.Rows.Clear()
            arrayConceptos = taUsuarios.ObtConceptos_ScalarQuery(UsuarioTextBox.Text).ToString.Split(",") 'CXP_UsuariosBindingSource.Current("empresas").ToString.Split(",")
            For i2 As Integer = 0 To arrayConceptos.Length - 1
                If arrayConceptos(i2) <> "" Then
                    dgvTipoConceptos.Rows.Add()
                    dgvTipoConceptos.Item(0, i2).Value = arrayConceptos(i2)
                    dgvTipoConceptos.Item(1, i2).Value = taConceptos.ObtConcepto_ScalarQuery(arrayConceptos(i2)) 'taTConceptos.ObtTipoConcepto_ScalarQuery(arrayConceptos(i2))
                    dgvTipoConceptos.Item(2, i2).Value = "Eliminar"
                End If
            Next
        End If
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        ActivoCheckBox.Checked = True
        cmbUsuarioActual.Enabled = True
        btnAgregarUsuario.Enabled = True
        dgvEmpresas.Rows.Clear()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        cmbUsuarioActual.Enabled = False
        btnAgregarUsuario.Enabled = False
    End Sub

    Private Sub btnAgregarUsuario_Click(sender As Object, e As EventArgs) Handles btnAgregarUsuario.Click
        Dim dtabla As DataTable
        dtabla = New dsProduction.CXP_UsuariosDataTable

        taUsuarios.Fill(dtabla)

        For Each rows As dsProduction.CXP_UsuariosRow In dtabla.Rows
            If rows.idUsuarioProd = USUARIOBindingSource.Current("cve_empleado") Then
                MsgBox("Ya se encuentra el usuario actual...", MsgBoxStyle.Critical)
                Exit Sub
            End If
        Next


        NombreTextBox.Text = USUARIOBindingSource.Current("nombrecompleto")
        UsuarioTextBox.Text = USUARIOBindingSource.Current("id_usuario")
        MailTextBox.Text = USUARIOBindingSource.Current("correo")
        'DepartamentoTextBox.Text = USUARIOBindingSource.Current("id_depto")
        'SucursalTextBox.Text = USUARIOBindingSource.Current("id_sucursal")
        CXP_UsuariosBindingSource.Current("idUsuarioProd") = USUARIOBindingSource.Current("cve_empleado")
        RfcTextBox.Text = USUARIOBindingSource.Current("rfc").ToString.Trim
        PwTextBox.Text = USUARIOBindingSource.Current("password")
        ActivoCheckBox.Checked = True
        cmbAccesoWeb.SelectedItem = 0

    End Sub

    Private Sub btnAgregarConcepto_Click(sender As Object, e As EventArgs) Handles btnAgregarConcepto.Click
        Dim valor As Integer = cmbTipoConcepto.SelectedValue
        Dim cont As Integer = 0

        For Each rows As DataGridViewRow In dgvTipoConceptos.Rows
            If dgvTipoConceptos.Item(0, cont).Value = valor Then
                MsgBox("Ya se encuentra el tipo de concepto actual...", MsgBoxStyle.Critical)
                Exit Sub
            End If
            cont = cont + 1
        Next

        dgvTipoConceptos.Rows.Add(cmbTipoConcepto.SelectedValue, cmbTipoConcepto.Text, "Eliminar")
    End Sub

    Private Sub dgvTipoConceptos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTipoConceptos.CellContentClick
        If e.ColumnIndex = 2 Then
            dgvTipoConceptos.Rows.Remove(dgvTipoConceptos.CurrentRow)
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        CXP_UsuariosBindingSource.Filter = "nombre like '%" & txtBuscar.Text & "%'"
    End Sub
End Class