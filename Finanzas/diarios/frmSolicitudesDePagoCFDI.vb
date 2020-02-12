Imports System.ComponentModel

Public Class frmSolicitudesDePagoCFDI

    Public total As Decimal = 0
    Public subTotal As Decimal = 0
    Public iva As Decimal = 0
    Public totalRet As Decimal = 0
    Public var_rfcProveedor As String
    Private Sub frmSolicitudesDePagoCFDI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsProduction.vw_CXP_XmlCfdi2_grpUuid' Puede moverla o quitarla según sea necesario.
        Me.Vw_CXP_XmlCfdi2_grpUuidTableAdapter.Fill(Me.DsProduction.vw_CXP_XmlCfdi2_grpUuid)
        Me.CXP_ConceptosTableAdapter.Fill(DsProduction.CXP_Conceptos, varGlobal_IdEmpresa)
        Vw_CXP_XmlCfdi2_grpUuidTableAdapter.ObtCFDiXRfc_FillBy(DsProduction.vw_CXP_XmlCfdi2_grpUuid, var_rfcProveedor, varGlobal_rfcEmpresa)
    End Sub

    Private Sub CXP_XmlCfdiDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CXP_XmlCfdiDataGridView.CellContentClick
        If CXP_XmlCfdiDataGridView.Item("seleccionar", e.RowIndex).Value = True Then
            CXP_XmlCfdiDataGridView.Item("seleccionar", e.RowIndex).Value = False
        Else
            CXP_XmlCfdiDataGridView.Item("seleccionar", e.RowIndex).Value = True
        End If
    End Sub

    Private Sub frmSolicitudesDePagoCFDI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmSolicitudesDePagoCFDI_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim taProveedores As New dsProductionTableAdapters.CXP_ProveedoresTableAdapter
        Dim taCuentas As New dsProductionTableAdapters.CXP_CuentasContablesTableAdapter
        Dim taConceptos As New dsProductionTableAdapters.CXP_ConceptosTableAdapter
        Dim taConceptosImpuestos As New dsProductionTableAdapters.vw_CXP_XmlCfdi2_grpUuidTableAdapter
        Dim taimpuesto As New dsProductionTableAdapters.CXP_ImpuestoTableAdapter
        Dim taCXPPagos As New dsProductionTableAdapters.CXP_PagosTableAdapter
        Dim taEmpresas As New dsProductionTableAdapters.CXP_EmpresasTableAdapter
        Dim folSolPagoFinagil As Integer = 0
        Dim taCFDI2 As New dsProductionTableAdapters.CXP_XmlCfdi2TableAdapter
        Dim tableCFDI2 As New dsProduction.CXP_XmlCfdi2DataTable

        Dim cont As Integer = 0
        Dim cont2 As Integer = 1
        For Each rows As DataGridViewRow In CXP_XmlCfdiDataGridView.Rows
            folSolPagoFinagil = taEmpresas.ConsultaFolio(varGlobal_IdEmpresa)

            If CXP_XmlCfdiDataGridView.Item("seleccionar", cont).Value = True Then
                taCFDI2.SumaImp_FillBy(tableCFDI2, CXP_XmlCfdiDataGridView.Rows("uuid").Cells(7).Value)
                For Each rows2 As dsProduction.CXP_XmlCfdi2Row In tableCFDI2
                    'taCXPPagos.Insert(, 0, folSolPagoFinagil, Date.Now.ToLongDateString, rows2.fechaEmision, rows2.serie, rows2.folio, rows2.uuid, CXP_XmlCfdiDataGridView.Rows(cont).Cells("subTotal").Value, CXP_XmlCfdiDataGridView.Rows(cont).Cells("TotalDataGridViewTextBoxColumn").Value, CDec(CXP_XmlCfdiDataGridView.Rows(cont).Cells("MontoImpuestoDataGridViewTextBoxColumn").Value), CDec(CXP_XmlCfdiDataGridView.Rows(cont).Cells("MontoImpuestoRDataGridViewTextBoxColumn").Value), CXP_XmlCfdiDataGridView.Rows(cont).Cells("descripcion").Value, CXP_XmlCfdiDataGridView.Rows(cont).Cells("concepto").Value, 1, varGlobal_IdUsuario, varGlobal_IdEmpresa, "No Pagada", "#" & Session.Item("mailJefe"), mail, Nothing, Nothing, rows2.moneda, CDate(txtFechaPago.Text), True, Nothing)
                Next

            End If
            cont += 1
        Next
    End Sub


End Class