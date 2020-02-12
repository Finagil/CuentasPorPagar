Public Class frmPerfiles
    Dim taPerfiles As New dsProductionTableAdapters.CXP_PerfilesUsuarioTableAdapter
    Private Sub frmPerfiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsProduction1.CXP_Perfiles' Puede moverla o quitarla según sea necesario.
        Me.CXP_PerfilesTableAdapter.Fill(Me.DsProduction1.CXP_Perfiles)
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.CXP_PerfilesUsuario' Puede moverla o quitarla según sea necesario.
        Me.CXP_PerfilesUsuarioTableAdapter.Fill(Me.DsProduction.CXP_PerfilesUsuario, cmbNombrePerfil.SelectedValue)

        For Each vLocMnuOpciones As ToolStripMenuItem In mdicuentasPorPagar.MenuStrip.Items
            cmbMenu.Items.Add(vLocMnuOpciones.Name)
            'cmbMenu.Enabled = True
        Next
    End Sub

    Private Sub cmbMenu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMenu.SelectedIndexChanged
        cmbSubMenu1.Text = ""
        cmbSubMenu1.Items.Clear()
        For Each vLocMnuOpciones As ToolStripMenuItem In mdicuentasPorPagar.MenuStrip.Items
            If vLocMnuOpciones.Name = cmbMenu.Text Then
                For Each submenu As ToolStripMenuItem In vLocMnuOpciones.DropDownItems
                    cmbSubMenu1.Items.Add(submenu.Name)
                Next
                cmbSubMenu1.Enabled = True
                chkEscritura.Enabled = True
                chkLectura.Enabled = True
                btnAgregar.Enabled = True
            End If
        Next
        cmbMenu.Enabled = False
    End Sub

    Private Sub cmbSubMenu1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSubMenu1.SelectedIndexChanged
        cmbSubMenu2.Text = ""
        cmbSubMenu2.Items.Clear()
        For Each vLocMnuOpciones As ToolStripMenuItem In mdicuentasPorPagar.MenuStrip.Items
            For Each submenu As ToolStripMenuItem In vLocMnuOpciones.DropDownItems
                If submenu.Name = cmbSubMenu1.Text Then
                    For Each submenu1 As ToolStripMenuItem In submenu.DropDownItems
                        cmbSubMenu2.Items.Add(submenu1.Name)
                    Next
                    cmbSubMenu2.Enabled = True
                End If
            Next
        Next
        cmbSubMenu1.Enabled = False
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        taPerfiles.Insert(cmbMenu.Text.Trim, cmbSubMenu1.Text.Trim, cmbSubMenu2.Text.Trim, chkLectura.Checked, chkEscritura.Checked, cmbNombrePerfil.SelectedValue, chkAccesoWeb.Checked)
        cmbSubMenu1.Text = ""
        cmbSubMenu1.Items.Clear()
        cmbSubMenu2.Text = ""
        cmbSubMenu2.Items.Clear()
        taPerfiles.Fill(DsProduction.CXP_PerfilesUsuario, cmbNombrePerfil.SelectedValue)
        CXP_PerfilesUsuarioDataGridView.Rows.Clear()
        For Each rowsa As dsProduction.CXP_PerfilesUsuarioRow In DsProduction.CXP_PerfilesUsuario.Rows
            CXP_PerfilesUsuarioDataGridView.Rows.Add(rowsa.nombrePerfil, rowsa.menu, rowsa.submenu1, rowsa.submenu2, rowsa.lectura, rowsa.lecturaEscritura, "Eliminar", rowsa.idPerfil)
        Next
        cmbMenu.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CXP_PerfilesUsuarioDataGridView.Rows.Clear()
        taPerfiles.Fill(DsProduction.CXP_PerfilesUsuario, cmbNombrePerfil.SelectedValue)
        For Each rowsa As dsProduction.CXP_PerfilesUsuarioRow In DsProduction.CXP_PerfilesUsuario.Rows
            CXP_PerfilesUsuarioDataGridView.Rows.Add(rowsa.nombrePerfil, rowsa.menu, rowsa.submenu1, rowsa.submenu2, rowsa.lectura, rowsa.lecturaEscritura, "Eliminar", rowsa.idPerfil)
        Next
        'cmbMenu.Enabled = True
        'cmbNombrePerfil.Enabled = False
    End Sub

    Private Sub CXP_PerfilesUsuarioDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CXP_PerfilesUsuarioDataGridView.CellContentClick
        If e.ColumnIndex = 6 Then
            taPerfiles.DeleteQuery(CXP_PerfilesUsuarioDataGridView.Rows(e.RowIndex).Cells(7).Value)
            MsgBox("Se ha eliminado la fila correctamente...")
        End If
        taPerfiles.Fill(DsProduction.CXP_PerfilesUsuario, cmbNombrePerfil.SelectedValue)
        CXP_PerfilesUsuarioDataGridView.Rows.Clear()
        For Each rowsa As dsProduction.CXP_PerfilesUsuarioRow In DsProduction.CXP_PerfilesUsuario.Rows
            CXP_PerfilesUsuarioDataGridView.Rows.Add(rowsa.nombrePerfil, rowsa.menu, rowsa.submenu1, rowsa.submenu2, rowsa.lectura, rowsa.lecturaEscritura, "Eliminar", rowsa.idPerfil)
        Next
    End Sub

    Private Sub cmbSubMenu2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSubMenu2.SelectedIndexChanged
        cmbSubMenu2.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        cmbNombrePerfil.Enabled = True
    End Sub

    Private Sub chkAccesoWeb_CheckedChanged(sender As Object, e As EventArgs) Handles chkAccesoWeb.CheckedChanged

    End Sub

    Private Sub chkAccesoWeb_Click(sender As Object, e As EventArgs) Handles chkAccesoWeb.Click
        taPerfiles.ActWeb_UpdateQuery(chkAccesoWeb.Checked, cmbNombrePerfil.SelectedValue)
    End Sub
End Class