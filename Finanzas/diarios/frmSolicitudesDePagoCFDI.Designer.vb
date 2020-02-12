<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSolicitudesDePagoCFDI
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.CXP_XmlCfdiDataGridView = New System.Windows.Forms.DataGridView()
        Me.CXPConceptosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProduction = New cuentasPorPagar.dsProduction()
        Me.VwCXPXmlCfdi2grpUuidBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FolioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaEmision = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.moneda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.folio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.serie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.uuid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vw_CXP_XmlCfdi2_grpUuidTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.vw_CXP_XmlCfdi2_grpUuidTableAdapter()
        Me.CXP_ConceptosTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_ConceptosTableAdapter()
        Me.seleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FechaEmisionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonedaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FolioDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SerieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UuidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ParcialidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sugerenciaImporte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sugerenciaPorcentaje = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.concepto = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.MontoImpuestoRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoImpuestoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.CXP_XmlCfdiDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPConceptosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwCXPXmlCfdi2grpUuidBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CXP_XmlCfdiDataGridView
        '
        Me.CXP_XmlCfdiDataGridView.AllowUserToAddRows = False
        Me.CXP_XmlCfdiDataGridView.AllowUserToDeleteRows = False
        Me.CXP_XmlCfdiDataGridView.AllowUserToOrderColumns = True
        Me.CXP_XmlCfdiDataGridView.AllowUserToResizeColumns = False
        Me.CXP_XmlCfdiDataGridView.AllowUserToResizeRows = False
        Me.CXP_XmlCfdiDataGridView.AutoGenerateColumns = False
        Me.CXP_XmlCfdiDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.CXP_XmlCfdiDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.CXP_XmlCfdiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CXP_XmlCfdiDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.seleccionar, Me.FechaEmisionDataGridViewTextBoxColumn, Me.FPagoDataGridViewTextBoxColumn, Me.MPagoDataGridViewTextBoxColumn, Me.MonedaDataGridViewTextBoxColumn, Me.FolioDataGridViewTextBoxColumn1, Me.SerieDataGridViewTextBoxColumn, Me.UuidDataGridViewTextBoxColumn, Me.SubTotalDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn, Me.ParcialidadDataGridViewTextBoxColumn, Me.TotalADataGridViewTextBoxColumn, Me.sugerenciaImporte, Me.sugerenciaPorcentaje, Me.descripcion, Me.concepto, Me.MontoImpuestoRDataGridViewTextBoxColumn, Me.MontoImpuestoDataGridViewTextBoxColumn})
        Me.CXP_XmlCfdiDataGridView.DataSource = Me.VwCXPXmlCfdi2grpUuidBindingSource
        Me.CXP_XmlCfdiDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CXP_XmlCfdiDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.CXP_XmlCfdiDataGridView.Name = "CXP_XmlCfdiDataGridView"
        Me.CXP_XmlCfdiDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.CXP_XmlCfdiDataGridView.RowHeadersVisible = False
        Me.CXP_XmlCfdiDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.CXP_XmlCfdiDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CXP_XmlCfdiDataGridView.Size = New System.Drawing.Size(1277, 361)
        Me.CXP_XmlCfdiDataGridView.TabIndex = 7
        '
        'CXPConceptosBindingSource
        '
        Me.CXPConceptosBindingSource.DataMember = "CXP_Conceptos"
        Me.CXPConceptosBindingSource.DataSource = Me.DsProduction
        '
        'DsProduction
        '
        Me.DsProduction.DataSetName = "dsProduction"
        Me.DsProduction.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VwCXPXmlCfdi2grpUuidBindingSource
        '
        Me.VwCXPXmlCfdi2grpUuidBindingSource.DataMember = "vw_CXP_XmlCfdi2_grpUuid"
        Me.VwCXPXmlCfdi2grpUuidBindingSource.DataSource = Me.DsProduction
        '
        'FolioDataGridViewTextBoxColumn
        '
        Me.FolioDataGridViewTextBoxColumn.DataPropertyName = "folio"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.FolioDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle10
        Me.FolioDataGridViewTextBoxColumn.HeaderText = "Folio Int"
        Me.FolioDataGridViewTextBoxColumn.Name = "FolioDataGridViewTextBoxColumn"
        Me.FolioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'fechaEmision
        '
        Me.fechaEmision.DataPropertyName = "fechaEmision"
        Me.fechaEmision.HeaderText = "fechaEmision"
        Me.fechaEmision.Name = "fechaEmision"
        '
        'fPago
        '
        Me.fPago.DataPropertyName = "fPago"
        Me.fPago.HeaderText = "fPago"
        Me.fPago.Name = "fPago"
        '
        'mPago
        '
        Me.mPago.DataPropertyName = "mPago"
        Me.mPago.HeaderText = "mPago"
        Me.mPago.Name = "mPago"
        '
        'moneda
        '
        Me.moneda.DataPropertyName = "moneda"
        Me.moneda.HeaderText = "moneda"
        Me.moneda.Name = "moneda"
        '
        'folio
        '
        Me.folio.DataPropertyName = "folio"
        Me.folio.HeaderText = "folio"
        Me.folio.Name = "folio"
        '
        'serie
        '
        Me.serie.DataPropertyName = "serie"
        Me.serie.HeaderText = "serie"
        Me.serie.Name = "serie"
        '
        'uuid
        '
        Me.uuid.DataPropertyName = "uuid"
        Me.uuid.HeaderText = "uuid"
        Me.uuid.Name = "uuid"
        '
        'Vw_CXP_XmlCfdi2_grpUuidTableAdapter
        '
        Me.Vw_CXP_XmlCfdi2_grpUuidTableAdapter.ClearBeforeFill = True
        '
        'CXP_ConceptosTableAdapter
        '
        Me.CXP_ConceptosTableAdapter.ClearBeforeFill = True
        '
        'seleccionar
        '
        Me.seleccionar.HeaderText = "Selec"
        Me.seleccionar.Name = "seleccionar"
        Me.seleccionar.Width = 30
        '
        'FechaEmisionDataGridViewTextBoxColumn
        '
        Me.FechaEmisionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FechaEmisionDataGridViewTextBoxColumn.DataPropertyName = "fechaEmision"
        Me.FechaEmisionDataGridViewTextBoxColumn.HeaderText = "Fecha Emisión"
        Me.FechaEmisionDataGridViewTextBoxColumn.Name = "FechaEmisionDataGridViewTextBoxColumn"
        Me.FechaEmisionDataGridViewTextBoxColumn.Width = 101
        '
        'FPagoDataGridViewTextBoxColumn
        '
        Me.FPagoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.FPagoDataGridViewTextBoxColumn.DataPropertyName = "fPago"
        Me.FPagoDataGridViewTextBoxColumn.HeaderText = "F Pago"
        Me.FPagoDataGridViewTextBoxColumn.Name = "FPagoDataGridViewTextBoxColumn"
        Me.FPagoDataGridViewTextBoxColumn.Width = 66
        '
        'MPagoDataGridViewTextBoxColumn
        '
        Me.MPagoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.MPagoDataGridViewTextBoxColumn.DataPropertyName = "mPago"
        Me.MPagoDataGridViewTextBoxColumn.HeaderText = "M Pago"
        Me.MPagoDataGridViewTextBoxColumn.Name = "MPagoDataGridViewTextBoxColumn"
        Me.MPagoDataGridViewTextBoxColumn.Width = 69
        '
        'MonedaDataGridViewTextBoxColumn
        '
        Me.MonedaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.MonedaDataGridViewTextBoxColumn.DataPropertyName = "moneda"
        Me.MonedaDataGridViewTextBoxColumn.HeaderText = "Moneda"
        Me.MonedaDataGridViewTextBoxColumn.Name = "MonedaDataGridViewTextBoxColumn"
        Me.MonedaDataGridViewTextBoxColumn.Width = 71
        '
        'FolioDataGridViewTextBoxColumn1
        '
        Me.FolioDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FolioDataGridViewTextBoxColumn1.DataPropertyName = "folio"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.FolioDataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle1
        Me.FolioDataGridViewTextBoxColumn1.HeaderText = "Folio"
        Me.FolioDataGridViewTextBoxColumn1.Name = "FolioDataGridViewTextBoxColumn1"
        Me.FolioDataGridViewTextBoxColumn1.Width = 54
        '
        'SerieDataGridViewTextBoxColumn
        '
        Me.SerieDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SerieDataGridViewTextBoxColumn.DataPropertyName = "serie"
        Me.SerieDataGridViewTextBoxColumn.HeaderText = "Serie"
        Me.SerieDataGridViewTextBoxColumn.Name = "SerieDataGridViewTextBoxColumn"
        Me.SerieDataGridViewTextBoxColumn.Width = 56
        '
        'UuidDataGridViewTextBoxColumn
        '
        Me.UuidDataGridViewTextBoxColumn.DataPropertyName = "uuid"
        Me.UuidDataGridViewTextBoxColumn.HeaderText = "UUID"
        Me.UuidDataGridViewTextBoxColumn.Name = "UuidDataGridViewTextBoxColumn"
        '
        'SubTotalDataGridViewTextBoxColumn
        '
        Me.SubTotalDataGridViewTextBoxColumn.DataPropertyName = "subTotal"
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.SubTotalDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.SubTotalDataGridViewTextBoxColumn.HeaderText = "SubTotal"
        Me.SubTotalDataGridViewTextBoxColumn.Name = "SubTotalDataGridViewTextBoxColumn"
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "total"
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.TotalDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        '
        'ParcialidadDataGridViewTextBoxColumn
        '
        Me.ParcialidadDataGridViewTextBoxColumn.DataPropertyName = "Parcialidad"
        Me.ParcialidadDataGridViewTextBoxColumn.HeaderText = "Parcialidad"
        Me.ParcialidadDataGridViewTextBoxColumn.Name = "ParcialidadDataGridViewTextBoxColumn"
        Me.ParcialidadDataGridViewTextBoxColumn.Width = 30
        '
        'TotalADataGridViewTextBoxColumn
        '
        Me.TotalADataGridViewTextBoxColumn.DataPropertyName = "totalA"
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.TotalADataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.TotalADataGridViewTextBoxColumn.HeaderText = "Imp Parcialidades"
        Me.TotalADataGridViewTextBoxColumn.Name = "TotalADataGridViewTextBoxColumn"
        '
        'sugerenciaImporte
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = Nothing
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.sugerenciaImporte.DefaultCellStyle = DataGridViewCellStyle5
        Me.sugerenciaImporte.HeaderText = "$ Sugerido"
        Me.sugerenciaImporte.Name = "sugerenciaImporte"
        '
        'sugerenciaPorcentaje
        '
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Silver
        Me.sugerenciaPorcentaje.DefaultCellStyle = DataGridViewCellStyle6
        Me.sugerenciaPorcentaje.HeaderText = "% Sugerido"
        Me.sugerenciaPorcentaje.Name = "sugerenciaPorcentaje"
        '
        'descripcion
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Silver
        Me.descripcion.DefaultCellStyle = DataGridViewCellStyle7
        Me.descripcion.HeaderText = "Descripción"
        Me.descripcion.Name = "descripcion"
        '
        'concepto
        '
        Me.concepto.DataSource = Me.CXPConceptosBindingSource
        Me.concepto.DisplayMember = "nombre"
        Me.concepto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.concepto.HeaderText = "Concepto"
        Me.concepto.Name = "concepto"
        Me.concepto.ValueMember = "idConcepto"
        Me.concepto.Width = 200
        '
        'MontoImpuestoRDataGridViewTextBoxColumn
        '
        Me.MontoImpuestoRDataGridViewTextBoxColumn.DataPropertyName = "montoImpuestoR"
        DataGridViewCellStyle8.Format = "C2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.MontoImpuestoRDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle8
        Me.MontoImpuestoRDataGridViewTextBoxColumn.HeaderText = "Imp Retenidos"
        Me.MontoImpuestoRDataGridViewTextBoxColumn.Name = "MontoImpuestoRDataGridViewTextBoxColumn"
        '
        'MontoImpuestoDataGridViewTextBoxColumn
        '
        Me.MontoImpuestoDataGridViewTextBoxColumn.DataPropertyName = "montoImpuesto"
        DataGridViewCellStyle9.Format = "C2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.MontoImpuestoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle9
        Me.MontoImpuestoDataGridViewTextBoxColumn.HeaderText = "Imp Trasladados"
        Me.MontoImpuestoDataGridViewTextBoxColumn.Name = "MontoImpuestoDataGridViewTextBoxColumn"
        '
        'frmSolicitudesDePagoCFDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1277, 361)
        Me.Controls.Add(Me.CXP_XmlCfdiDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "frmSolicitudesDePagoCFDI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comprobantes del Proveedor"
        CType(Me.CXP_XmlCfdiDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPConceptosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwCXPXmlCfdi2grpUuidBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CXP_XmlCfdiDataGridView As DataGridView
    Friend WithEvents FolioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents fechaEmision As DataGridViewTextBoxColumn
    Friend WithEvents fPago As DataGridViewTextBoxColumn
    Friend WithEvents mPago As DataGridViewTextBoxColumn
    Friend WithEvents moneda As DataGridViewTextBoxColumn
    Friend WithEvents folio As DataGridViewTextBoxColumn
    Friend WithEvents serie As DataGridViewTextBoxColumn
    Friend WithEvents uuid As DataGridViewTextBoxColumn
    Friend WithEvents DsProduction As dsProduction
    Friend WithEvents VwCXPXmlCfdi2grpUuidBindingSource As BindingSource
    Friend WithEvents Vw_CXP_XmlCfdi2_grpUuidTableAdapter As dsProductionTableAdapters.vw_CXP_XmlCfdi2_grpUuidTableAdapter
    Friend WithEvents CXPConceptosBindingSource As BindingSource
    Friend WithEvents CXP_ConceptosTableAdapter As dsProductionTableAdapters.CXP_ConceptosTableAdapter
    Friend WithEvents seleccionar As DataGridViewCheckBoxColumn
    Friend WithEvents FechaEmisionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FPagoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MPagoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MonedaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FolioDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents SerieDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UuidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubTotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ParcialidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents sugerenciaImporte As DataGridViewTextBoxColumn
    Friend WithEvents sugerenciaPorcentaje As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents concepto As DataGridViewComboBoxColumn
    Friend WithEvents MontoImpuestoRDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MontoImpuestoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
