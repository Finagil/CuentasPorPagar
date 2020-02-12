Option Explicit On
Imports System.Windows.Forms
Imports Microsoft.Win32
Imports System.Data.SqlClient
Imports System.IO
Imports System.Collections.Specialized
Imports System.Web
Imports System.Deployment.Application

Public Class mdicuentasPorPagar
    Public varGlUser As String
    Public varGlIdUser As String
    Public varGlPerfil As String
    Public varGlEmpresa As String
    Public varGlEmpresaD As String
    Dim taPerfil As New dsProductionTableAdapters.CXP_PerfilesUsuarioTableAdapter
    Dim t As New dsProduction.CXP_PerfilesUsuarioDataTable
    Dim dtPerfiles As New DataTable
    Dim drPerfiles As DataRow
    Dim USUARIOX As String


    Private Sub PerfilesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmPerfiles.MdiParent = Me
        frmPerfiles.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub EmpresasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpresasToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmEmpresas.MdiParent = Me
        frmEmpresas.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmUsuario.MdiParent = Me
        frmUsuario.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub MonedasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MonedasToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmSATMonedas.MdiParent = Me
        frmSATMonedas.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub



    Private Sub ImpuestosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImpuestosToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmSATImpuestos.MdiParent = Me
        frmSATImpuestos.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub TipoDeDocumentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoDeDocumentoToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmContTipoDocumentos.MdiParent = Me
        frmContTipoDocumentos.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub BancosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BancosToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        Bancos.MdiParent = Me
        Bancos.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub CuentasContablesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuentasContablesToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmContCuentasContables.MdiParent = Me
        frmContCuentasContables.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub CódigoAgrupalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CódigoAgrupalToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmCodigoAgrupador.MdiParent = Me
        frmCodigoAgrupador.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub CuentasBancariasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuentasBancariasToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmContCuentasBancarias.MdiParent = Me
        frmContCuentasBancarias.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmContProveedoresClientes.MdiParent = Me
        frmContProveedoresClientes.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub PaisesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaisesToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmNacionalidades.MdiParent = Me
        frmNacionalidades.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub mdicuentasPorPagar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Cuentas por Pagar   ** " + varGlEmpresaD
        Dim cn As New SqlConnection()
        Dim strSelect As String
        Dim Usuario As String
        Dim Password As String
        Dim strConnectionSecurity As String
        Dim cm As New SqlCommand()
        Dim dsAgil As New DataSet()
        Dim daMenus As New SqlDataAdapter(cm)
        Dim drMenu As DataRow
        Dim i As Integer
        Dim j As Integer
        Dim k As Integer

        Dim Args() As String
        Try
            Args = AppDomain.CurrentDomain.SetupInformation.ActivationArguments.ActivationData
        Catch ex As Exception
            ReDim Args(1)
            Args(0) = "1"
        End Try

        Try
            Dim rkCurrentUser As RegistryKey = Registry.CurrentUser
            ' Obtain the test key (read-only) and display it.
            Dim rkTest As RegistryKey = rkCurrentUser.OpenSubKey("Software\INFO100\FINANCIERA")
            rkTest.Close()
            rkCurrentUser.Close()
            rkTest = Registry.CurrentUser.OpenSubKey("Software\INFO100\FINANCIERA")
            rkTest.Close()
            rkTest = Registry.CurrentUser.OpenSubKey("Software\INFO100\FINANCIERA", True)
            strConnectionSecurity = My.Settings.SeguridadNvaConnectionString
            Dim cadenacon As String
            cadenacon = rkTest.GetValue("FINANCIERA").ToString
            'Usuario = Mid(cadenacon, InStr(cadenacon, "user ID ="), 10)
            'Password = rkTest.GetValue("Contrasena").ToString
            Usuario = varGlUser 'rkTest.GetValue("Usuario").ToString
            'USUARIOX = Usuario
            'varGlUser = Usuario
            Password = rkTest.GetValue("Contrasena").ToString
            rkTest.Close()

            'If varGlUser <> "desarrollo" And varGlUser <> "lgarciacX" Then
            '    If (InStr(Args(0), "Agil.application") <= 0 And InStr(Args(0), "Finagil.application") <= 0) And varGlUser <> "desarrollo" Then
            '        MessageBox.Show("Faltan argumentos para iniciar esta aplicación. (Error1) " & Args(0) & " " & varGlUser, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '        End
            '    End If
            'End If

        Catch eException As Exception
            Console.WriteLine("The file could not be read:")
            MessageBox.Show(eException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try

        strSelect = "SELECT cve_menu, cve_submenu, cve_ssubmenu, cve_sssubmenu FROM SEG_MAESTRA " &
       "WHERE cve_perfil IN (SELECT PERFILES.cve_perfil FROM PERFILES " &
                             "INNER JOIN USUARIOS_PERFILES ON PERFILES.cve_perfil = USUARIOS_PERFILES.cve_perfil " &
                             "INNER JOIN USUARIO ON USUARIOS_PERFILES.cve_empleado = USUARIO.cve_empleado " &
                             "WHERE nom_sistema = 'TESORERIAFINAGIL' AND (USUARIO.id_usuario = '" & Usuario & "' ))" &
       "ORDER BY cve_menu, cve_submenu, cve_ssubmenu, cve_sssubmenu"

        cn.ConnectionString = strConnectionSecurity

        With cm
            .Connection = cn
            .CommandText = strSelect
        End With

        ' Llenar el DataSet lo cual abre y cierra la conexión

        daMenus.Fill(dsAgil, "Menus")

        'UsuarioGlobalNombre = USER_SEC.ScalarNombre(Usuario)
        'UsuarioGlobalDepto = USER_SEC.ScalarDepto(Usuario)
        'UsuarioGlobalCorreo = USER_SEC.ScalarCorreo(Usuario)

        For Each vLocMnuOpciones As ToolStripMenuItem In Me.MenuStrip.Items
            For Each submenu1 As ToolStripMenuItem In vLocMnuOpciones.DropDownItems
                For Each submenu2a As ToolStripMenuItem In submenu1.DropDownItems
                    submenu2a.Enabled = False
                Next
                submenu1.Enabled = False
            Next
            vLocMnuOpciones.Enabled = False
        Next

        For Each drMenu In dsAgil.Tables("Menus").Rows
            i = drMenu(0) - 1
            j = drMenu(1) - 1
            k = drMenu(2) - 1
            If drMenu(0) = 5 Then
                i = i
            End If

            If i >= 0 Then
                For Each vLocMnuOpciones As ToolStripMenuItem In Me.MenuStrip.Items
                    If j >= 0 Then
                        For Each submenu1 As ToolStripMenuItem In vLocMnuOpciones.DropDownItems
                            For Each submenu2a As ToolStripMenuItem In submenu1.DropDownItems
                                If k >= 0 Then
                                    submenu2a.Enabled = True
                                End If
                            Next
                            submenu1.Enabled = True
                        Next
                    Else
                        vLocMnuOpciones.Enabled = True
                    End If
                Next
            End If

        Next

        tssUsuario.Text = "Usuario: " & varGlUser
        tssEmpresa.Text = "Empresa: " & varGlEmpresaD

        'If varGlUser = "viapolo" Then
        '    For Each vLocMnuOpciones As ToolStripMenuItem In Me.MenuStrip.Items
        '        vLocMnuOpciones.Enabled = True
        '        For Each submenu1 As ToolStripMenuItem In vLocMnuOpciones.DropDownItems
        '            submenu1.Enabled = True
        '            For Each submenu2 As ToolStripMenuItem In submenu1.DropDownItems
        '                submenu2.Enabled = True
        '            Next
        '        Next
        '    Next
        'Else
        '    taPerfil.ObtDetPerfil_FillBy(t, varGlPerfil)
        '    If t.Rows.Count > 0 Then
        '        For Each rows As dsProduction.CXP_PerfilesUsuarioRow In t
        '            For Each vLocMnuOpciones As ToolStripMenuItem In Me.MenuStrip.Items
        '                If rows.Item("menu") = vLocMnuOpciones.Name Then
        '                    vLocMnuOpciones.Enabled = True
        '                    For Each submenu1 As ToolStripMenuItem In vLocMnuOpciones.DropDownItems
        '                        If rows.Item("submenu1") = submenu1.Name Then
        '                            submenu1.Enabled = True
        '                            If rows.Item("submenu2") = "" Then
        '                                For Each submenu2a As ToolStripMenuItem In submenu1.DropDownItems
        '                                    submenu2a.Enabled = True
        '                                Next
        '                            Else
        '                                For Each submenu2 As ToolStripMenuItem In submenu1.DropDownItems
        '                                    If rows.Item("submenu2") = submenu2.Name Then
        '                                        submenu2.Enabled = True
        '                                    End If
        '                                Next
        '                            End If
        '                        End If
        '                    Next
        '                End If
        '            Next
        '        Next
        '    End If
        'End If
    End Sub

    Private Sub NombrePerfilesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NombrePerfilesToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmNombrePerfiles.MdiParent = Me
        frmNombrePerfiles.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub mdicuentasPorPagar_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        lfrInicio.Close()
    End Sub

    Private Sub ConceptosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConceptosToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmConceptos.MdiParent = Me
        frmConceptos.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub TipoDeGastoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoDeGastoToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmTipoGasto.MdiParent = Me
        frmTipoGasto.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub DiariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiariosToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmPolizasDiario.MdiParent = Me
        frmPolizasDiario.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub TipoDeDocumentoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TipoDeDocumentoToolStripMenuItem1.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmSATTipoDocumento.MdiParent = Me
        frmSATTipoDocumento.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub FacturasElectrónicasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturasElectrónicasToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmSolicitudesDePago.MdiParent = Me
        frmSolicitudesDePago.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub SucursalesToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmSucursales.MdiParent = Me
        frmSucursales.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub AutorizadoresToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AutorizadoresToolStripMenuItem1.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmAutorizaciones.MdiParent = Me
        frmAutorizaciones.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub TipoDeCuentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoDeCuentaToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmTipoCuentaContable.MdiParent = Me
        frmTipoCuentaContable.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub TipoDeSolcitudPorConceptoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoDeSolcitudPorConceptoToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmTipoConcepto.MdiParent = Me
        frmTipoConcepto.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub CambiarDeEmpresaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarDeEmpresaToolStripMenuItem.Click
        lfrInicio.Show()
    End Sub

    Private Sub GastosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GastosToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        fmrPolizasDiarioSCuenta.MdiParent = Me
        fmrPolizasDiarioSCuenta.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub



    Private Sub ComprobaciónDeGastosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComprobaciónDeGastosToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmCompGstPDF.MdiParent = Me
        frmCompGstPDF.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub ConComprobanteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConComprobanteToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmCCPDF.MdiParent = Me
        frmCCPDF.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub SinComprobanteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SinComprobanteToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmSCPDF.MdiParent = Me
        frmSCPDF.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub SaldosPorUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaldosPorUsuarioToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmSaldosGastos.MdiParent = Me
        frmSaldosGastos.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub SucursalesToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SucursalesToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmSucursales.MdiParent = Me
        frmSucursales.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub

    Private Sub DepartamentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepartamentosToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        MenuStrip.Enabled = False
        frmDepartamentos.MdiParent = Me
        frmDepartamentos.Show()
        Me.Cursor = Cursors.Default
        MenuStrip.Enabled = True
    End Sub
End Class
