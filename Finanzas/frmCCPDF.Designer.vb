<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCCPDF
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FolioSolicitudDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.RazonSocialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaSolicitudDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPagadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VwCXPMisSolicitudesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProduction = New cuentasPorPagar.dsProduction()
        Me.Vw_CXP_MisSolicitudesTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.Vw_CXP_MisSolicitudesTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwCXPMisSolicitudesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FolioSolicitudDataGridViewTextBoxColumn, Me.RazonSocialDataGridViewTextBoxColumn, Me.FechaSolicitudDataGridViewTextBoxColumn, Me.TotalPagadoDataGridViewTextBoxColumn, Me.usuario})
        Me.DataGridView1.DataSource = Me.VwCXPMisSolicitudesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 31)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(728, 372)
        Me.DataGridView1.TabIndex = 0
        '
        'FolioSolicitudDataGridViewTextBoxColumn
        '
        Me.FolioSolicitudDataGridViewTextBoxColumn.DataPropertyName = "folioSolicitud"
        Me.FolioSolicitudDataGridViewTextBoxColumn.HeaderText = "Folio de Solicitud"
        Me.FolioSolicitudDataGridViewTextBoxColumn.Name = "FolioSolicitudDataGridViewTextBoxColumn"
        Me.FolioSolicitudDataGridViewTextBoxColumn.ReadOnly = True
        Me.FolioSolicitudDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FolioSolicitudDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'RazonSocialDataGridViewTextBoxColumn
        '
        Me.RazonSocialDataGridViewTextBoxColumn.DataPropertyName = "razonSocial"
        Me.RazonSocialDataGridViewTextBoxColumn.HeaderText = "Razón Social"
        Me.RazonSocialDataGridViewTextBoxColumn.Name = "RazonSocialDataGridViewTextBoxColumn"
        Me.RazonSocialDataGridViewTextBoxColumn.ReadOnly = True
        Me.RazonSocialDataGridViewTextBoxColumn.Width = 300
        '
        'FechaSolicitudDataGridViewTextBoxColumn
        '
        Me.FechaSolicitudDataGridViewTextBoxColumn.DataPropertyName = "fechaSolicitud"
        Me.FechaSolicitudDataGridViewTextBoxColumn.HeaderText = "Fecha de Solicitud"
        Me.FechaSolicitudDataGridViewTextBoxColumn.Name = "FechaSolicitudDataGridViewTextBoxColumn"
        Me.FechaSolicitudDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalPagadoDataGridViewTextBoxColumn
        '
        Me.TotalPagadoDataGridViewTextBoxColumn.DataPropertyName = "totalPagado"
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.TotalPagadoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.TotalPagadoDataGridViewTextBoxColumn.HeaderText = "Total Pagado"
        Me.TotalPagadoDataGridViewTextBoxColumn.Name = "TotalPagadoDataGridViewTextBoxColumn"
        Me.TotalPagadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'usuario
        '
        Me.usuario.DataPropertyName = "usuario"
        Me.usuario.HeaderText = "Usuario Emisor"
        Me.usuario.Name = "usuario"
        Me.usuario.ReadOnly = True
        '
        'VwCXPMisSolicitudesBindingSource
        '
        Me.VwCXPMisSolicitudesBindingSource.DataMember = "Vw_CXP_MisSolicitudes"
        Me.VwCXPMisSolicitudesBindingSource.DataSource = Me.DsProduction
        '
        'DsProduction
        '
        Me.DsProduction.DataSetName = "dsProduction"
        Me.DsProduction.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Vw_CXP_MisSolicitudesTableAdapter
        '
        Me.Vw_CXP_MisSolicitudesTableAdapter.ClearBeforeFill = True
        '
        'frmCCPDF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(759, 425)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmCCPDF"
        Me.Text = "Solicitudes de Pago Con Comprobante Fiscal"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwCXPMisSolicitudesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DsProduction As dsProduction
    Friend WithEvents VwCXPMisSolicitudesBindingSource As BindingSource
    Friend WithEvents Vw_CXP_MisSolicitudesTableAdapter As dsProductionTableAdapters.Vw_CXP_MisSolicitudesTableAdapter
    Friend WithEvents FolioSolicitudDataGridViewTextBoxColumn As DataGridViewLinkColumn
    Friend WithEvents RazonSocialDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaSolicitudDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalPagadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents usuario As DataGridViewTextBoxColumn
End Class
