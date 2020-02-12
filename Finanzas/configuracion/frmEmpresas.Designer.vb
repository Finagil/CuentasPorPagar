<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEmpresas
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
        Dim IdRegimenFiscalLabel As System.Windows.Forms.Label
        Dim CondicionesDePagoLabel As System.Windows.Forms.Label
        Dim IdMonedaLabel As System.Windows.Forms.Label
        Dim CodigoPostalLabel As System.Windows.Forms.Label
        Dim PaisLabel As System.Windows.Forms.Label
        Dim EstadoLabel As System.Windows.Forms.Label
        Dim DelegacionLabel As System.Windows.Forms.Label
        Dim ColoniaLabel As System.Windows.Forms.Label
        Dim NumeroExteriorLabel As System.Windows.Forms.Label
        Dim NumeroInteriorLabel As System.Windows.Forms.Label
        Dim CalleLabel As System.Windows.Forms.Label
        Dim RazonSocialLabel As System.Windows.Forms.Label
        Dim FolioSolLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim MesesFacturasLabel As System.Windows.Forms.Label
        Dim MontoOIngresosLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmpresas))
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.gbxInformaciongeneral = New System.Windows.Forms.GroupBox()
        Me.cmbRegimenFiscal = New System.Windows.Forms.ComboBox()
        Me.CXP_EmpresasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProduction = New cuentasPorPagar.dsProduction()
        Me.CXPcRegimenFiscalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbMoneda = New System.Windows.Forms.ComboBox()
        Me.CXPcMonedaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.CFDIEstadoNominaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CodigoPostalTextBox = New System.Windows.Forms.TextBox()
        Me.cmbPais = New System.Windows.Forms.ComboBox()
        Me.CXPcPaisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CondicionesDePagoTextBox = New System.Windows.Forms.TextBox()
        Me.DelegacionTextBox = New System.Windows.Forms.TextBox()
        Me.ColoniaTextBox = New System.Windows.Forms.TextBox()
        Me.NumeroExteriorTextBox = New System.Windows.Forms.TextBox()
        Me.NumeroInteriorTextBox = New System.Windows.Forms.TextBox()
        Me.CalleTextBox = New System.Windows.Forms.TextBox()
        Me.RfcTextBox = New System.Windows.Forms.TextBox()
        Me.CXPcEstadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RazonSocialTextBox = New System.Windows.Forms.TextBox()
        Me.CXPcMonedaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FolioSolTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CXP_EmpresasTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_EmpresasTableAdapter()
        Me.TableAdapterManager = New cuentasPorPagar.dsProductionTableAdapters.TableAdapterManager()
        Me.CXP_tipoDeDocumentoTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_tipoDeDocumentoTableAdapter()
        Me.CXP_ConceptosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CXP_ConceptosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.cmbPolizaDiario = New System.Windows.Forms.ComboBox()
        Me.CXPtipoDeDocumentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CXP_c_PaisTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_c_PaisTableAdapter()
        Me.CXP_c_EstadoTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_c_EstadoTableAdapter()
        Me.CXP_c_MonedaTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_c_MonedaTableAdapter()
        Me.CXP_c_RegimenFiscalTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_c_RegimenFiscalTableAdapter()
        Me.CFDI_Estado_NominaTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CFDI_Estado_NominaTableAdapter()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.CXPConceptosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CXP_ConceptosTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_ConceptosTableAdapter()
        Me.cmbConceptoReembolso = New System.Windows.Forms.ComboBox()
        Me.CXPConceptosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProduction1 = New cuentasPorPagar.dsProduction()
        Me.cmbConceptoPagoContratos = New System.Windows.Forms.ComboBox()
        Me.CXPConceptosBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MesesFacturasTextBox = New System.Windows.Forms.TextBox()
        Me.MontoOIngresosTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CXPConceptosBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        IdRegimenFiscalLabel = New System.Windows.Forms.Label()
        CondicionesDePagoLabel = New System.Windows.Forms.Label()
        IdMonedaLabel = New System.Windows.Forms.Label()
        CodigoPostalLabel = New System.Windows.Forms.Label()
        PaisLabel = New System.Windows.Forms.Label()
        EstadoLabel = New System.Windows.Forms.Label()
        DelegacionLabel = New System.Windows.Forms.Label()
        ColoniaLabel = New System.Windows.Forms.Label()
        NumeroExteriorLabel = New System.Windows.Forms.Label()
        NumeroInteriorLabel = New System.Windows.Forms.Label()
        CalleLabel = New System.Windows.Forms.Label()
        RazonSocialLabel = New System.Windows.Forms.Label()
        FolioSolLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        MesesFacturasLabel = New System.Windows.Forms.Label()
        MontoOIngresosLabel = New System.Windows.Forms.Label()
        Me.gbxInformaciongeneral.SuspendLayout()
        CType(Me.CXP_EmpresasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPcRegimenFiscalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPcMonedaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CFDIEstadoNominaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPcPaisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPcEstadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPcMonedaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXP_ConceptosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CXP_ConceptosBindingNavigator.SuspendLayout()
        CType(Me.CXPtipoDeDocumentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPConceptosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPConceptosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProduction1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPConceptosBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPConceptosBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdRegimenFiscalLabel
        '
        IdRegimenFiscalLabel.AutoSize = True
        IdRegimenFiscalLabel.Location = New System.Drawing.Point(348, 133)
        IdRegimenFiscalLabel.Name = "IdRegimenFiscalLabel"
        IdRegimenFiscalLabel.Size = New System.Drawing.Size(82, 13)
        IdRegimenFiscalLabel.TabIndex = 50
        IdRegimenFiscalLabel.Text = "Regimen Fiscal:"
        '
        'CondicionesDePagoLabel
        '
        CondicionesDePagoLabel.AutoSize = True
        CondicionesDePagoLabel.Location = New System.Drawing.Point(439, 107)
        CondicionesDePagoLabel.Name = "CondicionesDePagoLabel"
        CondicionesDePagoLabel.Size = New System.Drawing.Size(111, 13)
        CondicionesDePagoLabel.TabIndex = 48
        CondicionesDePagoLabel.Text = "Condiciones de Pago:"
        '
        'IdMonedaLabel
        '
        IdMonedaLabel.AutoSize = True
        IdMonedaLabel.Location = New System.Drawing.Point(43, 130)
        IdMonedaLabel.Name = "IdMonedaLabel"
        IdMonedaLabel.Size = New System.Drawing.Size(49, 13)
        IdMonedaLabel.TabIndex = 46
        IdMonedaLabel.Text = "Moneda:"
        '
        'CodigoPostalLabel
        '
        CodigoPostalLabel.AutoSize = True
        CodigoPostalLabel.Location = New System.Drawing.Point(270, 78)
        CodigoPostalLabel.Name = "CodigoPostalLabel"
        CodigoPostalLabel.Size = New System.Drawing.Size(75, 13)
        CodigoPostalLabel.TabIndex = 44
        CodigoPostalLabel.Text = "Código Postal:"
        '
        'PaisLabel
        '
        PaisLabel.AutoSize = True
        PaisLabel.Location = New System.Drawing.Point(451, 52)
        PaisLabel.Name = "PaisLabel"
        PaisLabel.Size = New System.Drawing.Size(30, 13)
        PaisLabel.TabIndex = 42
        PaisLabel.Text = "Pais:"
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Location = New System.Drawing.Point(439, 77)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(43, 13)
        EstadoLabel.TabIndex = 40
        EstadoLabel.Text = "Estado:"
        '
        'DelegacionLabel
        '
        DelegacionLabel.AutoSize = True
        DelegacionLabel.Location = New System.Drawing.Point(29, 104)
        DelegacionLabel.Name = "DelegacionLabel"
        DelegacionLabel.Size = New System.Drawing.Size(64, 13)
        DelegacionLabel.TabIndex = 38
        DelegacionLabel.Text = "Delegación:"
        '
        'ColoniaLabel
        '
        ColoniaLabel.AutoSize = True
        ColoniaLabel.Location = New System.Drawing.Point(48, 78)
        ColoniaLabel.Name = "ColoniaLabel"
        ColoniaLabel.Size = New System.Drawing.Size(45, 13)
        ColoniaLabel.TabIndex = 36
        ColoniaLabel.Text = "Colonia:"
        '
        'NumeroExteriorLabel
        '
        NumeroExteriorLabel.AutoSize = True
        NumeroExteriorLabel.Location = New System.Drawing.Point(215, 52)
        NumeroExteriorLabel.Name = "NumeroExteriorLabel"
        NumeroExteriorLabel.Size = New System.Drawing.Size(85, 13)
        NumeroExteriorLabel.TabIndex = 34
        NumeroExteriorLabel.Text = "Número Exterior:"
        '
        'NumeroInteriorLabel
        '
        NumeroInteriorLabel.AutoSize = True
        NumeroInteriorLabel.Location = New System.Drawing.Point(10, 52)
        NumeroInteriorLabel.Name = "NumeroInteriorLabel"
        NumeroInteriorLabel.Size = New System.Drawing.Size(82, 13)
        NumeroInteriorLabel.TabIndex = 32
        NumeroInteriorLabel.Text = "Número Interior:"
        '
        'CalleLabel
        '
        CalleLabel.AutoSize = True
        CalleLabel.Location = New System.Drawing.Point(59, 26)
        CalleLabel.Name = "CalleLabel"
        CalleLabel.Size = New System.Drawing.Size(33, 13)
        CalleLabel.TabIndex = 30
        CalleLabel.Text = "Calle:"
        '
        'RazonSocialLabel
        '
        RazonSocialLabel.AutoSize = True
        RazonSocialLabel.Location = New System.Drawing.Point(30, 36)
        RazonSocialLabel.Name = "RazonSocialLabel"
        RazonSocialLabel.Size = New System.Drawing.Size(73, 13)
        RazonSocialLabel.TabIndex = 26
        RazonSocialLabel.Text = "Razón Social:"
        '
        'FolioSolLabel
        '
        FolioSolLabel.AutoSize = True
        FolioSolLabel.Location = New System.Drawing.Point(58, 236)
        FolioSolLabel.Name = "FolioSolLabel"
        FolioSolLabel.Size = New System.Drawing.Size(118, 13)
        FolioSolLabel.TabIndex = 33
        FolioSolLabel.Text = "Folio Solicitud de Pago:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(520, 26)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(31, 13)
        Label1.TabIndex = 56
        Label1.Text = "RFC:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(93, 266)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(83, 13)
        Label3.TabIndex = 39
        Label3.Text = "Póliza de Diario:"
        AddHandler Label3.Click, AddressOf Me.Label3_Click
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(41, 293)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(112, 13)
        Label5.TabIndex = 44
        Label5.Text = "Concepto Reembolso:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(375, 293)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(108, 13)
        Label6.TabIndex = 45
        Label6.Text = "Concepto Pago Ctos:"
        '
        'MesesFacturasLabel
        '
        MesesFacturasLabel.AutoSize = True
        MesesFacturasLabel.Location = New System.Drawing.Point(66, 347)
        MesesFacturasLabel.Name = "MesesFacturasLabel"
        MesesFacturasLabel.Size = New System.Drawing.Size(85, 13)
        MesesFacturasLabel.TabIndex = 45
        MesesFacturasLabel.Text = "Meses Facturas:"
        '
        'MontoOIngresosLabel
        '
        MontoOIngresosLabel.AutoSize = True
        MontoOIngresosLabel.Location = New System.Drawing.Point(282, 347)
        MontoOIngresosLabel.Name = "MontoOIngresosLabel"
        MontoOIngresosLabel.Size = New System.Drawing.Size(111, 13)
        MontoOIngresosLabel.TabIndex = 46
        MontoOIngresosLabel.Text = "Monto Otros Ingresos:"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(625, 331)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 29
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'gbxInformaciongeneral
        '
        Me.gbxInformaciongeneral.Controls.Add(Label1)
        Me.gbxInformaciongeneral.Controls.Add(Me.cmbRegimenFiscal)
        Me.gbxInformaciongeneral.Controls.Add(Me.cmbMoneda)
        Me.gbxInformaciongeneral.Controls.Add(Me.cmbEstado)
        Me.gbxInformaciongeneral.Controls.Add(Me.CodigoPostalTextBox)
        Me.gbxInformaciongeneral.Controls.Add(Me.cmbPais)
        Me.gbxInformaciongeneral.Controls.Add(IdRegimenFiscalLabel)
        Me.gbxInformaciongeneral.Controls.Add(CondicionesDePagoLabel)
        Me.gbxInformaciongeneral.Controls.Add(IdMonedaLabel)
        Me.gbxInformaciongeneral.Controls.Add(Me.CondicionesDePagoTextBox)
        Me.gbxInformaciongeneral.Controls.Add(CodigoPostalLabel)
        Me.gbxInformaciongeneral.Controls.Add(PaisLabel)
        Me.gbxInformaciongeneral.Controls.Add(EstadoLabel)
        Me.gbxInformaciongeneral.Controls.Add(DelegacionLabel)
        Me.gbxInformaciongeneral.Controls.Add(Me.DelegacionTextBox)
        Me.gbxInformaciongeneral.Controls.Add(ColoniaLabel)
        Me.gbxInformaciongeneral.Controls.Add(Me.ColoniaTextBox)
        Me.gbxInformaciongeneral.Controls.Add(NumeroExteriorLabel)
        Me.gbxInformaciongeneral.Controls.Add(Me.NumeroExteriorTextBox)
        Me.gbxInformaciongeneral.Controls.Add(NumeroInteriorLabel)
        Me.gbxInformaciongeneral.Controls.Add(Me.NumeroInteriorTextBox)
        Me.gbxInformaciongeneral.Controls.Add(CalleLabel)
        Me.gbxInformaciongeneral.Controls.Add(Me.CalleTextBox)
        Me.gbxInformaciongeneral.Controls.Add(Me.RfcTextBox)
        Me.gbxInformaciongeneral.Location = New System.Drawing.Point(12, 62)
        Me.gbxInformaciongeneral.Name = "gbxInformaciongeneral"
        Me.gbxInformaciongeneral.Size = New System.Drawing.Size(688, 165)
        Me.gbxInformaciongeneral.TabIndex = 30
        Me.gbxInformaciongeneral.TabStop = False
        Me.gbxInformaciongeneral.Text = "Información General:"
        '
        'cmbRegimenFiscal
        '
        Me.cmbRegimenFiscal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_EmpresasBindingSource, "idRegimenFiscal", True))
        Me.cmbRegimenFiscal.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CXP_EmpresasBindingSource, "idRegimenFiscal", True))
        Me.cmbRegimenFiscal.DataSource = Me.CXPcRegimenFiscalBindingSource
        Me.cmbRegimenFiscal.DisplayMember = "c_NombreRegimenfiscal"
        Me.cmbRegimenFiscal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRegimenFiscal.FormattingEnabled = True
        Me.cmbRegimenFiscal.Location = New System.Drawing.Point(436, 130)
        Me.cmbRegimenFiscal.Name = "cmbRegimenFiscal"
        Me.cmbRegimenFiscal.Size = New System.Drawing.Size(237, 21)
        Me.cmbRegimenFiscal.TabIndex = 55
        Me.cmbRegimenFiscal.ValueMember = "c_RegimenFiscal"
        '
        'CXP_EmpresasBindingSource
        '
        Me.CXP_EmpresasBindingSource.DataMember = "CXP_Empresas"
        Me.CXP_EmpresasBindingSource.DataSource = Me.DsProduction
        '
        'DsProduction
        '
        Me.DsProduction.DataSetName = "dsProduction"
        Me.DsProduction.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CXPcRegimenFiscalBindingSource
        '
        Me.CXPcRegimenFiscalBindingSource.DataMember = "CXP_c_RegimenFiscal"
        Me.CXPcRegimenFiscalBindingSource.DataSource = Me.DsProduction
        '
        'cmbMoneda
        '
        Me.cmbMoneda.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_EmpresasBindingSource, "idMoneda", True))
        Me.cmbMoneda.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CXP_EmpresasBindingSource, "idMoneda", True))
        Me.cmbMoneda.DataSource = Me.CXPcMonedaBindingSource1
        Me.cmbMoneda.DisplayMember = "c_Moneda"
        Me.cmbMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMoneda.FormattingEnabled = True
        Me.cmbMoneda.Location = New System.Drawing.Point(99, 128)
        Me.cmbMoneda.Name = "cmbMoneda"
        Me.cmbMoneda.Size = New System.Drawing.Size(243, 21)
        Me.cmbMoneda.TabIndex = 54
        Me.cmbMoneda.ValueMember = "c_Moneda"
        '
        'CXPcMonedaBindingSource1
        '
        Me.CXPcMonedaBindingSource1.DataMember = "CXP_c_Moneda"
        Me.CXPcMonedaBindingSource1.DataSource = Me.DsProduction
        '
        'cmbEstado
        '
        Me.cmbEstado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_EmpresasBindingSource, "estado", True))
        Me.cmbEstado.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CXP_EmpresasBindingSource, "estado", True))
        Me.cmbEstado.DataSource = Me.CFDIEstadoNominaBindingSource
        Me.cmbEstado.DisplayMember = "NombreEstado"
        Me.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Location = New System.Drawing.Point(487, 74)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(186, 21)
        Me.cmbEstado.TabIndex = 53
        Me.cmbEstado.ValueMember = "Estado"
        '
        'CFDIEstadoNominaBindingSource
        '
        Me.CFDIEstadoNominaBindingSource.DataMember = "CFDI_Estado_Nomina"
        Me.CFDIEstadoNominaBindingSource.DataSource = Me.DsProduction
        '
        'CodigoPostalTextBox
        '
        Me.CodigoPostalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_EmpresasBindingSource, "codigoPostal", True))
        Me.CodigoPostalTextBox.Location = New System.Drawing.Point(351, 75)
        Me.CodigoPostalTextBox.Name = "CodigoPostalTextBox"
        Me.CodigoPostalTextBox.Size = New System.Drawing.Size(72, 20)
        Me.CodigoPostalTextBox.TabIndex = 34
        '
        'cmbPais
        '
        Me.cmbPais.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_EmpresasBindingSource, "pais", True))
        Me.cmbPais.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CXP_EmpresasBindingSource, "pais", True))
        Me.cmbPais.DataSource = Me.CXPcPaisBindingSource
        Me.cmbPais.DisplayMember = "Descripcion"
        Me.cmbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPais.FormattingEnabled = True
        Me.cmbPais.Location = New System.Drawing.Point(487, 49)
        Me.cmbPais.Name = "cmbPais"
        Me.cmbPais.Size = New System.Drawing.Size(186, 21)
        Me.cmbPais.TabIndex = 52
        Me.cmbPais.ValueMember = "c_Pais"
        '
        'CXPcPaisBindingSource
        '
        Me.CXPcPaisBindingSource.DataMember = "CXP_c_Pais"
        Me.CXPcPaisBindingSource.DataSource = Me.DsProduction
        '
        'CondicionesDePagoTextBox
        '
        Me.CondicionesDePagoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_EmpresasBindingSource, "condicionesDePago", True))
        Me.CondicionesDePagoTextBox.Location = New System.Drawing.Point(557, 104)
        Me.CondicionesDePagoTextBox.Name = "CondicionesDePagoTextBox"
        Me.CondicionesDePagoTextBox.Size = New System.Drawing.Size(116, 20)
        Me.CondicionesDePagoTextBox.TabIndex = 49
        '
        'DelegacionTextBox
        '
        Me.DelegacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_EmpresasBindingSource, "delegacion", True))
        Me.DelegacionTextBox.Location = New System.Drawing.Point(98, 101)
        Me.DelegacionTextBox.Name = "DelegacionTextBox"
        Me.DelegacionTextBox.Size = New System.Drawing.Size(325, 20)
        Me.DelegacionTextBox.TabIndex = 39
        '
        'ColoniaTextBox
        '
        Me.ColoniaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_EmpresasBindingSource, "colonia", True))
        Me.ColoniaTextBox.Location = New System.Drawing.Point(98, 75)
        Me.ColoniaTextBox.Name = "ColoniaTextBox"
        Me.ColoniaTextBox.Size = New System.Drawing.Size(166, 20)
        Me.ColoniaTextBox.TabIndex = 37
        '
        'NumeroExteriorTextBox
        '
        Me.NumeroExteriorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_EmpresasBindingSource, "numeroExterior", True))
        Me.NumeroExteriorTextBox.Location = New System.Drawing.Point(306, 49)
        Me.NumeroExteriorTextBox.Name = "NumeroExteriorTextBox"
        Me.NumeroExteriorTextBox.Size = New System.Drawing.Size(117, 20)
        Me.NumeroExteriorTextBox.TabIndex = 35
        '
        'NumeroInteriorTextBox
        '
        Me.NumeroInteriorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_EmpresasBindingSource, "numeroInterior", True))
        Me.NumeroInteriorTextBox.Location = New System.Drawing.Point(98, 49)
        Me.NumeroInteriorTextBox.Name = "NumeroInteriorTextBox"
        Me.NumeroInteriorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NumeroInteriorTextBox.TabIndex = 33
        '
        'CalleTextBox
        '
        Me.CalleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_EmpresasBindingSource, "calle", True))
        Me.CalleTextBox.Location = New System.Drawing.Point(98, 23)
        Me.CalleTextBox.Name = "CalleTextBox"
        Me.CalleTextBox.Size = New System.Drawing.Size(325, 20)
        Me.CalleTextBox.TabIndex = 31
        '
        'RfcTextBox
        '
        Me.RfcTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_EmpresasBindingSource, "rfc", True))
        Me.RfcTextBox.Location = New System.Drawing.Point(557, 23)
        Me.RfcTextBox.Name = "RfcTextBox"
        Me.RfcTextBox.Size = New System.Drawing.Size(116, 20)
        Me.RfcTextBox.TabIndex = 29
        '
        'CXPcEstadoBindingSource
        '
        Me.CXPcEstadoBindingSource.DataMember = "CXP_c_Estado"
        Me.CXPcEstadoBindingSource.DataSource = Me.DsProduction
        '
        'RazonSocialTextBox
        '
        Me.RazonSocialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_EmpresasBindingSource, "razonSocial", True))
        Me.RazonSocialTextBox.Location = New System.Drawing.Point(111, 33)
        Me.RazonSocialTextBox.Name = "RazonSocialTextBox"
        Me.RazonSocialTextBox.Size = New System.Drawing.Size(589, 20)
        Me.RazonSocialTextBox.TabIndex = 33
        '
        'FolioSolTextBox
        '
        Me.FolioSolTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_EmpresasBindingSource, "folioSol", True))
        Me.FolioSolTextBox.Location = New System.Drawing.Point(176, 233)
        Me.FolioSolTextBox.Name = "FolioSolTextBox"
        Me.FolioSolTextBox.ReadOnly = True
        Me.FolioSolTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FolioSolTextBox.TabIndex = 34
        Me.FolioSolTextBox.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(282, 236)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Folio Comprobación de Gts:"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_EmpresasBindingSource, "folioCom", True))
        Me.TextBox1.Location = New System.Drawing.Point(425, 236)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 36
        Me.TextBox1.Text = "0"
        '
        'CXP_EmpresasTableAdapter
        '
        Me.CXP_EmpresasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CFDI_Estado_NominaTableAdapter = Nothing
        Me.TableAdapterManager.CXP_AutorizacionesTableAdapter = Nothing
        Me.TableAdapterManager.CXP_BancosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_c_CodigoPostalTableAdapter = Nothing
        Me.TableAdapterManager.CXP_c_EstadoTableAdapter = Nothing
        Me.TableAdapterManager.CXP_c_MonedaTableAdapter = Nothing
        Me.TableAdapterManager.CXP_c_PaisTableAdapter = Nothing
        Me.TableAdapterManager.CXP_c_RegimenFiscalTableAdapter = Nothing
        Me.TableAdapterManager.CXP_CodigoAgrupadorTableAdapter = Nothing
        Me.TableAdapterManager.CXP_ComprobGtosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_ConceptosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_CuentasBancariasTableAdapter = Nothing
        Me.TableAdapterManager.CXP_CuentasContablesTableAdapter = Nothing
        Me.TableAdapterManager.CXP_DepartamentosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_DiariosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_EmpresasTableAdapter = Me.CXP_EmpresasTableAdapter
        Me.TableAdapterManager.CXP_ImpConTableAdapter = Nothing
        Me.TableAdapterManager.CXP_ImpuestoTableAdapter = Nothing
        Me.TableAdapterManager.CXP_PagosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_PerfilesTableAdapter = Nothing
        Me.TableAdapterManager.CXP_PerfilesUsuarioTableAdapter = Nothing
        Me.TableAdapterManager.CXP_ProveedoresTableAdapter = Nothing
        Me.TableAdapterManager.CXP_RegContTableAdapter = Nothing
        Me.TableAdapterManager.CXP_SucursalesTableAdapter = Nothing
        Me.TableAdapterManager.CXP_tipoConceptoTableAdapter = Nothing
        Me.TableAdapterManager.CXP_tipoCuentaContableTableAdapter = Nothing
        Me.TableAdapterManager.CXP_tipoDeDocumentoTableAdapter = Me.CXP_tipoDeDocumentoTableAdapter
        Me.TableAdapterManager.CXP_tipoDocumentoSatTableAdapter = Nothing
        Me.TableAdapterManager.CXP_TipoGastoTableAdapter = Nothing
        Me.TableAdapterManager.CXP_UsuariosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_XmlCfdi2TableAdapter = Nothing
        Me.TableAdapterManager.CXP_XmlCfdiTableAdapter = Nothing
        Me.TableAdapterManager.SucursalesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = cuentasPorPagar.dsProductionTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CXP_tipoDeDocumentoTableAdapter
        '
        Me.CXP_tipoDeDocumentoTableAdapter.ClearBeforeFill = True
        '
        'CXP_ConceptosBindingNavigator
        '
        Me.CXP_ConceptosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CXP_ConceptosBindingNavigator.BindingSource = Me.CXP_EmpresasBindingSource
        Me.CXP_ConceptosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CXP_ConceptosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CXP_ConceptosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CXP_ConceptosBindingNavigatorSaveItem})
        Me.CXP_ConceptosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CXP_ConceptosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CXP_ConceptosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CXP_ConceptosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CXP_ConceptosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CXP_ConceptosBindingNavigator.Name = "CXP_ConceptosBindingNavigator"
        Me.CXP_ConceptosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CXP_ConceptosBindingNavigator.Size = New System.Drawing.Size(720, 25)
        Me.CXP_ConceptosBindingNavigator.TabIndex = 37
        Me.CXP_ConceptosBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Enabled = False
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Enabled = False
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Enabled = False
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Enabled = False
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Enabled = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Enabled = False
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Enabled = False
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'CXP_ConceptosBindingNavigatorSaveItem
        '
        Me.CXP_ConceptosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CXP_ConceptosBindingNavigatorSaveItem.Image = CType(resources.GetObject("CXP_ConceptosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CXP_ConceptosBindingNavigatorSaveItem.Name = "CXP_ConceptosBindingNavigatorSaveItem"
        Me.CXP_ConceptosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CXP_ConceptosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'cmbPolizaDiario
        '
        Me.cmbPolizaDiario.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CXP_EmpresasBindingSource, "idPolizaD", True))
        Me.cmbPolizaDiario.DataSource = Me.CXPtipoDeDocumentoBindingSource
        Me.cmbPolizaDiario.DisplayMember = "claveTipoDocumento"
        Me.cmbPolizaDiario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPolizaDiario.FormattingEnabled = True
        Me.cmbPolizaDiario.Location = New System.Drawing.Point(176, 263)
        Me.cmbPolizaDiario.Name = "cmbPolizaDiario"
        Me.cmbPolizaDiario.Size = New System.Drawing.Size(100, 21)
        Me.cmbPolizaDiario.TabIndex = 38
        Me.cmbPolizaDiario.ValueMember = "idTipoDeDocumento"
        '
        'CXPtipoDeDocumentoBindingSource
        '
        Me.CXPtipoDeDocumentoBindingSource.DataMember = "CXP_tipoDeDocumento"
        Me.CXPtipoDeDocumentoBindingSource.DataSource = Me.DsProduction
        Me.CXPtipoDeDocumentoBindingSource.Filter = "documentoDe = 'Diario'"
        '
        'CXP_c_PaisTableAdapter
        '
        Me.CXP_c_PaisTableAdapter.ClearBeforeFill = True
        '
        'CXP_c_EstadoTableAdapter
        '
        Me.CXP_c_EstadoTableAdapter.ClearBeforeFill = True
        '
        'CXP_c_MonedaTableAdapter
        '
        Me.CXP_c_MonedaTableAdapter.ClearBeforeFill = True
        '
        'CXP_c_RegimenFiscalTableAdapter
        '
        Me.CXP_c_RegimenFiscalTableAdapter.ClearBeforeFill = True
        '
        'CFDI_Estado_NominaTableAdapter
        '
        Me.CFDI_Estado_NominaTableAdapter.ClearBeforeFill = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CXP_EmpresasBindingSource, "idConceptoGastos", True))
        Me.ComboBox1.DataSource = Me.CXPConceptosBindingSource
        Me.ComboBox1.DisplayMember = "nombre"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(425, 261)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(275, 21)
        Me.ComboBox1.TabIndex = 40
        Me.ComboBox1.ValueMember = "idConcepto"
        '
        'CXPConceptosBindingSource
        '
        Me.CXPConceptosBindingSource.DataMember = "CXP_Conceptos"
        Me.CXPConceptosBindingSource.DataSource = Me.DsProduction
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(327, 266)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Concepto Gastos:"
        '
        'CXP_ConceptosTableAdapter
        '
        Me.CXP_ConceptosTableAdapter.ClearBeforeFill = True
        '
        'cmbConceptoReembolso
        '
        Me.cmbConceptoReembolso.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CXP_EmpresasBindingSource, "idConceptoReembolos", True))
        Me.cmbConceptoReembolso.DataSource = Me.CXPConceptosBindingSource1
        Me.cmbConceptoReembolso.DisplayMember = "nombre"
        Me.cmbConceptoReembolso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbConceptoReembolso.FormattingEnabled = True
        Me.cmbConceptoReembolso.Location = New System.Drawing.Point(156, 290)
        Me.cmbConceptoReembolso.Name = "cmbConceptoReembolso"
        Me.cmbConceptoReembolso.Size = New System.Drawing.Size(211, 21)
        Me.cmbConceptoReembolso.TabIndex = 42
        Me.cmbConceptoReembolso.ValueMember = "idConcepto"
        '
        'CXPConceptosBindingSource1
        '
        Me.CXPConceptosBindingSource1.DataMember = "CXP_Conceptos"
        Me.CXPConceptosBindingSource1.DataSource = Me.DsProduction
        '
        'DsProduction1
        '
        Me.DsProduction1.DataSetName = "dsProduction"
        Me.DsProduction1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbConceptoPagoContratos
        '
        Me.cmbConceptoPagoContratos.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CXP_EmpresasBindingSource, "idConceptoPagoCtos", True))
        Me.cmbConceptoPagoContratos.DataSource = Me.CXPConceptosBindingSource2
        Me.cmbConceptoPagoContratos.DisplayMember = "nombre"
        Me.cmbConceptoPagoContratos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbConceptoPagoContratos.FormattingEnabled = True
        Me.cmbConceptoPagoContratos.Location = New System.Drawing.Point(489, 290)
        Me.cmbConceptoPagoContratos.Name = "cmbConceptoPagoContratos"
        Me.cmbConceptoPagoContratos.Size = New System.Drawing.Size(211, 21)
        Me.cmbConceptoPagoContratos.TabIndex = 43
        Me.cmbConceptoPagoContratos.ValueMember = "idConcepto"
        '
        'CXPConceptosBindingSource2
        '
        Me.CXPConceptosBindingSource2.DataMember = "CXP_Conceptos"
        Me.CXPConceptosBindingSource2.DataSource = Me.DsProduction
        '
        'MesesFacturasTextBox
        '
        Me.MesesFacturasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_EmpresasBindingSource, "mesesFacturas", True))
        Me.MesesFacturasTextBox.Location = New System.Drawing.Point(156, 344)
        Me.MesesFacturasTextBox.Name = "MesesFacturasTextBox"
        Me.MesesFacturasTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MesesFacturasTextBox.TabIndex = 46
        Me.MesesFacturasTextBox.Text = "0"
        '
        'MontoOIngresosTextBox
        '
        Me.MontoOIngresosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_EmpresasBindingSource, "montoOIngresos", True))
        Me.MontoOIngresosTextBox.Location = New System.Drawing.Point(394, 344)
        Me.MontoOIngresosTextBox.Name = "MontoOIngresosTextBox"
        Me.MontoOIngresosTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MontoOIngresosTextBox.TabIndex = 47
        Me.MontoOIngresosTextBox.Text = "0"
        '
        'ComboBox2
        '
        Me.ComboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CXP_EmpresasBindingSource, "idConceptoOIngresos", True))
        Me.ComboBox2.DataSource = Me.CXPConceptosBindingSource3
        Me.ComboBox2.DisplayMember = "nombre"
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(156, 318)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(211, 21)
        Me.ComboBox2.TabIndex = 48
        Me.ComboBox2.ValueMember = "idConcepto"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 321)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 13)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Concepto Otros Ingresos:"
        '
        'CXPConceptosBindingSource3
        '
        Me.CXPConceptosBindingSource3.DataMember = "CXP_Conceptos"
        Me.CXPConceptosBindingSource3.DataSource = Me.DsProduction
        '
        'frmEmpresas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(720, 385)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(MontoOIngresosLabel)
        Me.Controls.Add(Me.MontoOIngresosTextBox)
        Me.Controls.Add(MesesFacturasLabel)
        Me.Controls.Add(Me.MesesFacturasTextBox)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Me.cmbConceptoPagoContratos)
        Me.Controls.Add(Me.cmbConceptoReembolso)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.cmbPolizaDiario)
        Me.Controls.Add(Me.CXP_ConceptosBindingNavigator)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(FolioSolLabel)
        Me.Controls.Add(Me.FolioSolTextBox)
        Me.Controls.Add(Me.RazonSocialTextBox)
        Me.Controls.Add(Me.gbxInformaciongeneral)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(RazonSocialLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmEmpresas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Empresa"
        Me.gbxInformaciongeneral.ResumeLayout(False)
        Me.gbxInformaciongeneral.PerformLayout()
        CType(Me.CXP_EmpresasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPcRegimenFiscalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPcMonedaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CFDIEstadoNominaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPcPaisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPcEstadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPcMonedaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXP_ConceptosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CXP_ConceptosBindingNavigator.ResumeLayout(False)
        Me.CXP_ConceptosBindingNavigator.PerformLayout()
        CType(Me.CXPtipoDeDocumentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPConceptosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPConceptosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProduction1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPConceptosBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPConceptosBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSalir As Button
    Friend WithEvents gbxInformaciongeneral As GroupBox
    Friend WithEvents CondicionesDePagoTextBox As TextBox
    Friend WithEvents DelegacionTextBox As TextBox
    Friend WithEvents ColoniaTextBox As TextBox
    Friend WithEvents NumeroExteriorTextBox As TextBox
    Friend WithEvents NumeroInteriorTextBox As TextBox
    Friend WithEvents CalleTextBox As TextBox
    Friend WithEvents RfcTextBox As TextBox
    Friend WithEvents cmbPais As ComboBox
    Friend WithEvents CXP_c_CodigoPostalTableAdapter As dsProductionTableAdapters.CXP_c_CodigoPostalTableAdapter
    Friend WithEvents RazonSocialTextBox As TextBox
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents CodigoPostalTextBox As TextBox
    Friend WithEvents CXPcMonedaBindingSource As BindingSource
    Friend WithEvents cmbMoneda As ComboBox
    Friend WithEvents cmbRegimenFiscal As ComboBox
    Friend WithEvents FolioSolTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DsProduction As dsProduction
    Friend WithEvents CXP_EmpresasBindingSource As BindingSource
    Friend WithEvents CXP_EmpresasTableAdapter As dsProductionTableAdapters.CXP_EmpresasTableAdapter
    Friend WithEvents TableAdapterManager As dsProductionTableAdapters.TableAdapterManager
    Friend WithEvents CXP_ConceptosBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents CXP_ConceptosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents cmbPolizaDiario As ComboBox
    Friend WithEvents CXP_tipoDeDocumentoTableAdapter As dsProductionTableAdapters.CXP_tipoDeDocumentoTableAdapter
    Friend WithEvents CXPtipoDeDocumentoBindingSource As BindingSource
    Friend WithEvents CXPcPaisBindingSource As BindingSource
    Friend WithEvents CXP_c_PaisTableAdapter As dsProductionTableAdapters.CXP_c_PaisTableAdapter
    Friend WithEvents CXPcEstadoBindingSource As BindingSource
    Friend WithEvents CXP_c_EstadoTableAdapter As dsProductionTableAdapters.CXP_c_EstadoTableAdapter
    Friend WithEvents CXPcMonedaBindingSource1 As BindingSource
    Friend WithEvents CXP_c_MonedaTableAdapter As dsProductionTableAdapters.CXP_c_MonedaTableAdapter
    Friend WithEvents CXPcRegimenFiscalBindingSource As BindingSource
    Friend WithEvents CXP_c_RegimenFiscalTableAdapter As dsProductionTableAdapters.CXP_c_RegimenFiscalTableAdapter
    Friend WithEvents CFDIEstadoNominaBindingSource As BindingSource
    Friend WithEvents CFDI_Estado_NominaTableAdapter As dsProductionTableAdapters.CFDI_Estado_NominaTableAdapter
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents CXPConceptosBindingSource As BindingSource
    Friend WithEvents Label4 As Label
    Friend WithEvents CXP_ConceptosTableAdapter As dsProductionTableAdapters.CXP_ConceptosTableAdapter
    Friend WithEvents cmbConceptoReembolso As ComboBox
    Friend WithEvents cmbConceptoPagoContratos As ComboBox
    Friend WithEvents CXPConceptosBindingSource1 As BindingSource
    Friend WithEvents DsProduction1 As dsProduction
    Friend WithEvents CXPConceptosBindingSource2 As BindingSource
    Friend WithEvents MesesFacturasTextBox As TextBox
    Friend WithEvents MontoOIngresosTextBox As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents CXPConceptosBindingSource3 As BindingSource
    Friend WithEvents Label7 As Label
End Class
