Imports Microsoft.Win32
Imports System.Data.SqlClient
Imports System.IO
Imports System.Collections.Specialized
Imports System.Web
Imports System.Deployment.Application
Imports System.ComponentModel

Public Class lfrInicio

    Dim Hash As New ClaseHash
    Dim taUsuarios As New dsProductionTableAdapters.CXP_UsuariosTableAdapter
    Dim taEmpresas As New dsProductionTableAdapters.CXP_EmpresasTableAdapter
    Dim arrayEmpresas() As String
    Dim t As New dsProduction.CXP_UsuariosDataTable
    Dim dtUsuarios As New DataTable
    Dim rowUsuarios As DataRow
    Dim Usuario As String = ""
    Dim strConnectionSecurity As String
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        Dim f As New mdicuentasPorPagar

        Dim taUsuario As New dsSeguridadTableAdapters.USUARIO2TableAdapter
        Dim dtUsuario As New dsSeguridad.USUARIO2DataTable

        If t.Rows.Count > 0 Then
            rowUsuarios = t.Rows(0)
            If CBool(rowUsuarios.Item("activo")) = True Then
                If (UsernameTextBox.Text = rowUsuarios.Item("usuario")) Then
                    Me.Hide()

                    taUsuario.Fill(dtUsuario, rowUsuarios("usuario"))
                    If dtUsuario.Rows.Count Then

                    End If

                    f.varGlUser = rowUsuarios.Item("usuario")
                    varGlobal_NombreUsuario = rowUsuarios.Item("usuario")
                    f.varGlIdUser = rowUsuarios.Item("idUsuario")
                    varGlobal_IdUsuario = rowUsuarios.Item("idUsuario")
                    f.varGlPerfil = rowUsuarios.Item("perfil")
                    f.varGlEmpresa = cmbEmpresa.SelectedValue
                    varGlobal_IdEmpresa = cmbEmpresa.SelectedValue
                    f.varGlEmpresaD = cmbEmpresa.Text
                    varGlobal_Empresa = cmbEmpresa.Text
                    varGlobal_rfcEmpresa = taEmpresas.ObtRfc_ScalarQuery(cmbEmpresa.SelectedValue)

                    f.ShowDialog()
                Else
                    MsgBox("El usuario es incorrecto...", MsgBoxStyle.Critical)
                End If
            End If
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
    Private Sub UsernameTextBox_LostFocus(sender As Object, e As EventArgs) Handles UsernameTextBox.LostFocus
        If UsernameTextBox.Text <> "" Then
            taUsuarios.ObtEmpresas_FillBy(t, UsernameTextBox.Text)
            If t.Rows.Count > 0 Then
                rowUsuarios = t.Rows(0)
                arrayEmpresas = rowUsuarios.Item("empresas").Split(",")
                CXPEmpresasBindingSource.Filter = "idEmpresas IN (" & rowUsuarios.Item("empresas").ToString & ")"
            Else
                MsgBox("El usuario no existe...", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub lfrInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CXP_EmpresasTableAdapter.Fill(Me.DsProduction.CXP_Empresas)

        Dim rkCurrentUser As RegistryKey = Registry.CurrentUser

        Dim rkTest As RegistryKey = rkCurrentUser.OpenSubKey("Software\INFO100\TESORERIAFINAGIL")
        rkTest = Registry.CurrentUser.OpenSubKey("Software\INFO100\TESORERIAFINAGIL", True)
        strConnectionSecurity = My.Settings.SeguridadNvaConnectionString

        UsernameTextBox.Text = rkTest.GetValue("Usuario").ToString

        taUsuarios.ObtEmpresas_FillBy(t, UsernameTextBox.Text)
    End Sub

End Class
