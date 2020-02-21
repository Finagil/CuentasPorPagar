<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmContProveedoresClientes
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
        Dim RazonSocialLabel As System.Windows.Forms.Label
        Dim RfcLabel As System.Windows.Forms.Label
        Dim CurpLabel As System.Windows.Forms.Label
        Dim ExtranjeroLabel As System.Windows.Forms.Label
        Dim NitLabel As System.Windows.Forms.Label
        Dim IdSucursalLabel As System.Windows.Forms.Label
        Dim RelacionadoLabel As System.Windows.Forms.Label
        Dim MontoMaxTransaccionLabel As System.Windows.Forms.Label
        Dim NacionalidadLabel As System.Windows.Forms.Label
        Dim FechaRegistroLabel As System.Windows.Forms.Label
        Dim MailLabel As System.Windows.Forms.Label
        Dim EmpresaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContProveedoresClientes))
        Me.DsProduction = New cuentasPorPagar.dsProduction()
        Me.CXP_ProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CXP_ProveedoresTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_ProveedoresTableAdapter()
        Me.TableAdapterManager = New cuentasPorPagar.dsProductionTableAdapters.TableAdapterManager()
        Me.CXP_CuentasBancariasProvTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_CuentasBancariasProvTableAdapter()
        Me.CXP_CuentasContablesTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_CuentasContablesTableAdapter()
        Me.CXP_SucursalesTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_SucursalesTableAdapter()
        Me.CXP_ProveedoresBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.CXP_ProveedoresBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.RazonSocialTextBox = New System.Windows.Forms.TextBox()
        Me.RfcTextBox = New System.Windows.Forms.TextBox()
        Me.CurpTextBox = New System.Windows.Forms.TextBox()
        Me.ExtranjeroCheckBox = New System.Windows.Forms.CheckBox()
        Me.NitTextBox = New System.Windows.Forms.TextBox()
        Me.RelacionadoCheckBox = New System.Windows.Forms.CheckBox()
        Me.MontoMaxTransaccionTextBox = New System.Windows.Forms.TextBox()
        Me.FechaRegistroDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.MailTextBox = New System.Windows.Forms.TextBox()
        Me.cmbSucursal = New System.Windows.Forms.ComboBox()
        Me.CXPSucursalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CXPCuentasContablesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.CXPEmpresasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CXP_EmpresasTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_EmpresasTableAdapter()
        Me.cmbNacionalida = New System.Windows.Forms.ComboBox()
        Me.CXPcPaisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CXP_c_PaisTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_c_PaisTableAdapter()
        Me.txtBuscaProveedor = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.CXP_CuentasBancariasProvBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CXP_CuentasBancariasProvDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.CXPBancosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CXP_BancosTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_BancosTableAdapter()
        RazonSocialLabel = New System.Windows.Forms.Label()
        RfcLabel = New System.Windows.Forms.Label()
        CurpLabel = New System.Windows.Forms.Label()
        ExtranjeroLabel = New System.Windows.Forms.Label()
        NitLabel = New System.Windows.Forms.Label()
        IdSucursalLabel = New System.Windows.Forms.Label()
        RelacionadoLabel = New System.Windows.Forms.Label()
        MontoMaxTransaccionLabel = New System.Windows.Forms.Label()
        NacionalidadLabel = New System.Windows.Forms.Label()
        FechaRegistroLabel = New System.Windows.Forms.Label()
        MailLabel = New System.Windows.Forms.Label()
        EmpresaLabel = New System.Windows.Forms.Label()
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXP_ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXP_ProveedoresBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CXP_ProveedoresBindingNavigator.SuspendLayout()
        CType(Me.CXPSucursalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPCuentasContablesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPEmpresasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPcPaisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXP_CuentasBancariasProvBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXP_CuentasBancariasProvDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPBancosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RazonSocialLabel
        '
        RazonSocialLabel.AutoSize = True
        RazonSocialLabel.Location = New System.Drawing.Point(32, 48)
        RazonSocialLabel.Name = "RazonSocialLabel"
        RazonSocialLabel.Size = New System.Drawing.Size(73, 13)
        RazonSocialLabel.TabIndex = 1
        RazonSocialLabel.Text = "Razón Social:"
        '
        'RfcLabel
        '
        RfcLabel.AutoSize = True
        RfcLabel.Location = New System.Drawing.Point(73, 74)
        RfcLabel.Name = "RfcLabel"
        RfcLabel.Size = New System.Drawing.Size(31, 13)
        RfcLabel.TabIndex = 3
        RfcLabel.Text = "RFC:"
        '
        'CurpLabel
        '
        CurpLabel.AutoSize = True
        CurpLabel.Location = New System.Drawing.Point(228, 74)
        CurpLabel.Name = "CurpLabel"
        CurpLabel.Size = New System.Drawing.Size(40, 13)
        CurpLabel.TabIndex = 5
        CurpLabel.Text = "CURP:"
        '
        'ExtranjeroLabel
        '
        ExtranjeroLabel.AutoSize = True
        ExtranjeroLabel.Location = New System.Drawing.Point(49, 100)
        ExtranjeroLabel.Name = "ExtranjeroLabel"
        ExtranjeroLabel.Size = New System.Drawing.Size(57, 13)
        ExtranjeroLabel.TabIndex = 7
        ExtranjeroLabel.Text = "Extranjero:"
        '
        'NitLabel
        '
        NitLabel.AutoSize = True
        NitLabel.Location = New System.Drawing.Point(377, 100)
        NitLabel.Name = "NitLabel"
        NitLabel.Size = New System.Drawing.Size(28, 13)
        NitLabel.TabIndex = 9
        NitLabel.Text = "NIT:"
        '
        'IdSucursalLabel
        '
        IdSucursalLabel.AutoSize = True
        IdSucursalLabel.Location = New System.Drawing.Point(542, 101)
        IdSucursalLabel.Name = "IdSucursalLabel"
        IdSucursalLabel.Size = New System.Drawing.Size(51, 13)
        IdSucursalLabel.TabIndex = 11
        IdSucursalLabel.Text = "Sucursal:"
        '
        'RelacionadoLabel
        '
        RelacionadoLabel.AutoSize = True
        RelacionadoLabel.Location = New System.Drawing.Point(524, 125)
        RelacionadoLabel.Name = "RelacionadoLabel"
        RelacionadoLabel.Size = New System.Drawing.Size(70, 13)
        RelacionadoLabel.TabIndex = 13
        RelacionadoLabel.Text = "Relacionado:"
        AddHandler RelacionadoLabel.Click, AddressOf Me.RelacionadoLabel_Click
        '
        'MontoMaxTransaccionLabel
        '
        MontoMaxTransaccionLabel.AutoSize = True
        MontoMaxTransaccionLabel.Location = New System.Drawing.Point(801, 48)
        MontoMaxTransaccionLabel.Name = "MontoMaxTransaccionLabel"
        MontoMaxTransaccionLabel.Size = New System.Drawing.Size(63, 13)
        MontoMaxTransaccionLabel.TabIndex = 19
        MontoMaxTransaccionLabel.Text = "Monto Max:"
        '
        'NacionalidadLabel
        '
        NacionalidadLabel.AutoSize = True
        NacionalidadLabel.Location = New System.Drawing.Point(145, 100)
        NacionalidadLabel.Name = "NacionalidadLabel"
        NacionalidadLabel.Size = New System.Drawing.Size(72, 13)
        NacionalidadLabel.TabIndex = 21
        NacionalidadLabel.Text = "Nacionalidad:"
        '
        'FechaRegistroLabel
        '
        FechaRegistroLabel.AutoSize = True
        FechaRegistroLabel.Location = New System.Drawing.Point(497, 51)
        FechaRegistroLabel.Name = "FechaRegistroLabel"
        FechaRegistroLabel.Size = New System.Drawing.Size(97, 13)
        FechaRegistroLabel.TabIndex = 23
        FechaRegistroLabel.Text = "Fecha de Registro:"
        '
        'MailLabel
        '
        MailLabel.AutoSize = True
        MailLabel.Location = New System.Drawing.Point(74, 125)
        MailLabel.Name = "MailLabel"
        MailLabel.Size = New System.Drawing.Size(28, 13)
        MailLabel.TabIndex = 25
        MailLabel.Text = "mail:"
        '
        'EmpresaLabel
        '
        EmpresaLabel.AutoSize = True
        EmpresaLabel.Location = New System.Drawing.Point(543, 76)
        EmpresaLabel.Name = "EmpresaLabel"
        EmpresaLabel.Size = New System.Drawing.Size(51, 13)
        EmpresaLabel.TabIndex = 27
        EmpresaLabel.Text = "Empresa:"
        '
        'DsProduction
        '
        Me.DsProduction.DataSetName = "dsProduction"
        Me.DsProduction.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CXP_ProveedoresBindingSource
        '
        Me.CXP_ProveedoresBindingSource.DataMember = "CXP_Proveedores"
        Me.CXP_ProveedoresBindingSource.DataSource = Me.DsProduction
        '
        'CXP_ProveedoresTableAdapter
        '
        Me.CXP_ProveedoresTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.CXP_CuentasBancariasProvTableAdapter = Me.CXP_CuentasBancariasProvTableAdapter
        Me.TableAdapterManager.CXP_CuentasBancariasTableAdapter = Nothing
        Me.TableAdapterManager.CXP_CuentasContablesTableAdapter = Me.CXP_CuentasContablesTableAdapter
        Me.TableAdapterManager.CXP_DepartamentosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_DiariosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_EmpresasTableAdapter = Nothing
        Me.TableAdapterManager.CXP_ImpConTableAdapter = Nothing
        Me.TableAdapterManager.CXP_ImpuestoTableAdapter = Nothing
        Me.TableAdapterManager.CXP_PagosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_PerfilesTableAdapter = Nothing
        Me.TableAdapterManager.CXP_PerfilesUsuarioTableAdapter = Nothing
        Me.TableAdapterManager.CXP_ProveedoresTableAdapter = Me.CXP_ProveedoresTableAdapter
        Me.TableAdapterManager.CXP_RegContTableAdapter = Nothing
        Me.TableAdapterManager.CXP_SucursalesTableAdapter = Me.CXP_SucursalesTableAdapter
        Me.TableAdapterManager.CXP_tipoConceptoTableAdapter = Nothing
        Me.TableAdapterManager.CXP_tipoCuentaContableTableAdapter = Nothing
        Me.TableAdapterManager.CXP_tipoDeDocumentoTableAdapter = Nothing
        Me.TableAdapterManager.CXP_tipoDocumentoSatTableAdapter = Nothing
        Me.TableAdapterManager.CXP_TipoGastoTableAdapter = Nothing
        Me.TableAdapterManager.CXP_UsuariosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_XmlCfdi2TableAdapter = Nothing
        Me.TableAdapterManager.CXP_XmlCfdiTableAdapter = Nothing
        Me.TableAdapterManager.SucursalesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = cuentasPorPagar.dsProductionTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CXP_CuentasBancariasProvTableAdapter
        '
        Me.CXP_CuentasBancariasProvTableAdapter.ClearBeforeFill = True
        '
        'CXP_CuentasContablesTableAdapter
        '
        Me.CXP_CuentasContablesTableAdapter.ClearBeforeFill = True
        '
        'CXP_SucursalesTableAdapter
        '
        Me.CXP_SucursalesTableAdapter.ClearBeforeFill = True
        '
        'CXP_ProveedoresBindingNavigator
        '
        Me.CXP_ProveedoresBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CXP_ProveedoresBindingNavigator.BindingSource = Me.CXP_ProveedoresBindingSource
        Me.CXP_ProveedoresBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CXP_ProveedoresBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CXP_ProveedoresBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CXP_ProveedoresBindingNavigatorSaveItem})
        Me.CXP_ProveedoresBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CXP_ProveedoresBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CXP_ProveedoresBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CXP_ProveedoresBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CXP_ProveedoresBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CXP_ProveedoresBindingNavigator.Name = "CXP_ProveedoresBindingNavigator"
        Me.CXP_ProveedoresBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CXP_ProveedoresBindingNavigator.Size = New System.Drawing.Size(990, 25)
        Me.CXP_ProveedoresBindingNavigator.TabIndex = 0
        Me.CXP_ProveedoresBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
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
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
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
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
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
        'CXP_ProveedoresBindingNavigatorSaveItem
        '
        Me.CXP_ProveedoresBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CXP_ProveedoresBindingNavigatorSaveItem.Image = CType(resources.GetObject("CXP_ProveedoresBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CXP_ProveedoresBindingNavigatorSaveItem.Name = "CXP_ProveedoresBindingNavigatorSaveItem"
        Me.CXP_ProveedoresBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CXP_ProveedoresBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'RazonSocialTextBox
        '
        Me.RazonSocialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_ProveedoresBindingSource, "razonSocial", True))
        Me.RazonSocialTextBox.Location = New System.Drawing.Point(111, 45)
        Me.RazonSocialTextBox.Name = "RazonSocialTextBox"
        Me.RazonSocialTextBox.Size = New System.Drawing.Size(378, 20)
        Me.RazonSocialTextBox.TabIndex = 2
        '
        'RfcTextBox
        '
        Me.RfcTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_ProveedoresBindingSource, "rfc", True))
        Me.RfcTextBox.Location = New System.Drawing.Point(111, 71)
        Me.RfcTextBox.Name = "RfcTextBox"
        Me.RfcTextBox.Size = New System.Drawing.Size(111, 20)
        Me.RfcTextBox.TabIndex = 4
        '
        'CurpTextBox
        '
        Me.CurpTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_ProveedoresBindingSource, "curp", True))
        Me.CurpTextBox.Location = New System.Drawing.Point(274, 71)
        Me.CurpTextBox.Name = "CurpTextBox"
        Me.CurpTextBox.Size = New System.Drawing.Size(215, 20)
        Me.CurpTextBox.TabIndex = 6
        '
        'ExtranjeroCheckBox
        '
        Me.ExtranjeroCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CXP_ProveedoresBindingSource, "extranjero", True))
        Me.ExtranjeroCheckBox.Location = New System.Drawing.Point(111, 95)
        Me.ExtranjeroCheckBox.Name = "ExtranjeroCheckBox"
        Me.ExtranjeroCheckBox.Size = New System.Drawing.Size(36, 24)
        Me.ExtranjeroCheckBox.TabIndex = 8
        Me.ExtranjeroCheckBox.UseVisualStyleBackColor = True
        '
        'NitTextBox
        '
        Me.NitTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_ProveedoresBindingSource, "nit", True))
        Me.NitTextBox.Location = New System.Drawing.Point(410, 97)
        Me.NitTextBox.Name = "NitTextBox"
        Me.NitTextBox.Size = New System.Drawing.Size(79, 20)
        Me.NitTextBox.TabIndex = 10
        '
        'RelacionadoCheckBox
        '
        Me.RelacionadoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CXP_ProveedoresBindingSource, "relacionado", True))
        Me.RelacionadoCheckBox.Location = New System.Drawing.Point(600, 120)
        Me.RelacionadoCheckBox.Name = "RelacionadoCheckBox"
        Me.RelacionadoCheckBox.Size = New System.Drawing.Size(44, 24)
        Me.RelacionadoCheckBox.TabIndex = 14
        Me.RelacionadoCheckBox.UseVisualStyleBackColor = True
        '
        'MontoMaxTransaccionTextBox
        '
        Me.MontoMaxTransaccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_ProveedoresBindingSource, "montoMaxTransaccion", True))
        Me.MontoMaxTransaccionTextBox.Location = New System.Drawing.Point(864, 45)
        Me.MontoMaxTransaccionTextBox.Name = "MontoMaxTransaccionTextBox"
        Me.MontoMaxTransaccionTextBox.Size = New System.Drawing.Size(111, 20)
        Me.MontoMaxTransaccionTextBox.TabIndex = 20
        '
        'FechaRegistroDateTimePicker
        '
        Me.FechaRegistroDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CXP_ProveedoresBindingSource, "fechaRegistro", True))
        Me.FechaRegistroDateTimePicker.Location = New System.Drawing.Point(597, 45)
        Me.FechaRegistroDateTimePicker.Name = "FechaRegistroDateTimePicker"
        Me.FechaRegistroDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechaRegistroDateTimePicker.TabIndex = 24
        '
        'MailTextBox
        '
        Me.MailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_ProveedoresBindingSource, "mail", True))
        Me.MailTextBox.Location = New System.Drawing.Point(111, 122)
        Me.MailTextBox.Name = "MailTextBox"
        Me.MailTextBox.Size = New System.Drawing.Size(378, 20)
        Me.MailTextBox.TabIndex = 26
        '
        'cmbSucursal
        '
        Me.cmbSucursal.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CXP_ProveedoresBindingSource, "idSucursal", True))
        Me.cmbSucursal.DataSource = Me.CXPSucursalesBindingSource
        Me.cmbSucursal.DisplayMember = "nombreSucursal"
        Me.cmbSucursal.FormattingEnabled = True
        Me.cmbSucursal.Location = New System.Drawing.Point(597, 97)
        Me.cmbSucursal.Name = "cmbSucursal"
        Me.cmbSucursal.Size = New System.Drawing.Size(378, 21)
        Me.cmbSucursal.TabIndex = 29
        Me.cmbSucursal.ValueMember = "idSucursal"
        '
        'CXPSucursalesBindingSource
        '
        Me.CXPSucursalesBindingSource.DataMember = "CXP_Sucursales"
        Me.CXPSucursalesBindingSource.DataSource = Me.DsProduction
        '
        'CXPCuentasContablesBindingSource
        '
        Me.CXPCuentasContablesBindingSource.DataMember = "CXP_CuentasContables"
        Me.CXPCuentasContablesBindingSource.DataSource = Me.DsProduction
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(900, 365)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 31
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CXP_ProveedoresBindingSource, "empresa", True))
        Me.ComboBox1.DataSource = Me.CXPEmpresasBindingSource
        Me.ComboBox1.DisplayMember = "razonSocial"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(597, 72)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(378, 21)
        Me.ComboBox1.TabIndex = 32
        Me.ComboBox1.ValueMember = "idEmpresas"
        '
        'CXPEmpresasBindingSource
        '
        Me.CXPEmpresasBindingSource.DataMember = "CXP_Empresas"
        Me.CXPEmpresasBindingSource.DataSource = Me.DsProduction
        '
        'CXP_EmpresasTableAdapter
        '
        Me.CXP_EmpresasTableAdapter.ClearBeforeFill = True
        '
        'cmbNacionalida
        '
        Me.cmbNacionalida.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CXP_ProveedoresBindingSource, "nacionalidad", True))
        Me.cmbNacionalida.DataSource = Me.CXPcPaisBindingSource
        Me.cmbNacionalida.DisplayMember = "Descripcion"
        Me.cmbNacionalida.FormattingEnabled = True
        Me.cmbNacionalida.Location = New System.Drawing.Point(223, 97)
        Me.cmbNacionalida.Name = "cmbNacionalida"
        Me.cmbNacionalida.Size = New System.Drawing.Size(146, 21)
        Me.cmbNacionalida.TabIndex = 33
        Me.cmbNacionalida.ValueMember = "c_Pais"
        '
        'CXPcPaisBindingSource
        '
        Me.CXPcPaisBindingSource.DataMember = "CXP_c_Pais"
        Me.CXPcPaisBindingSource.DataSource = Me.DsProduction
        '
        'CXP_c_PaisTableAdapter
        '
        Me.CXP_c_PaisTableAdapter.ClearBeforeFill = True
        '
        'txtBuscaProveedor
        '
        Me.txtBuscaProveedor.Location = New System.Drawing.Point(12, 365)
        Me.txtBuscaProveedor.Name = "txtBuscaProveedor"
        Me.txtBuscaProveedor.Size = New System.Drawing.Size(228, 20)
        Me.txtBuscaProveedor.TabIndex = 38
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(247, 365)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 39
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'CXP_CuentasBancariasProvBindingSource
        '
        Me.CXP_CuentasBancariasProvBindingSource.DataMember = "CXP_CuentasBancariasProv"
        Me.CXP_CuentasBancariasProvBindingSource.DataSource = Me.DsProduction
        '
        'CXP_CuentasBancariasProvDataGridView
        '
        Me.CXP_CuentasBancariasProvDataGridView.AutoGenerateColumns = False
        Me.CXP_CuentasBancariasProvDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CXP_CuentasBancariasProvDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.CXP_CuentasBancariasProvDataGridView.DataSource = Me.CXP_CuentasBancariasProvBindingSource
        Me.CXP_CuentasBancariasProvDataGridView.Location = New System.Drawing.Point(12, 161)
        Me.CXP_CuentasBancariasProvDataGridView.Name = "CXP_CuentasBancariasProvDataGridView"
        Me.CXP_CuentasBancariasProvDataGridView.Size = New System.Drawing.Size(963, 195)
        Me.CXP_CuentasBancariasProvDataGridView.TabIndex = 39
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idCuentas"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idCuentas"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "idProveedor"
        Me.DataGridViewTextBoxColumn2.HeaderText = "idProveedor"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "idBanco"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.CXPBancosBindingSource
        Me.DataGridViewTextBoxColumn3.DisplayMember = "nombreCorto"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Banco"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ValueMember = "idBancos"
        Me.DataGridViewTextBoxColumn3.Width = 400
        '
        'CXPBancosBindingSource
        '
        Me.CXPBancosBindingSource.DataMember = "CXP_Bancos"
        Me.CXPBancosBindingSource.DataSource = Me.DsProduction
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "cuenta"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Cuenta"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 220
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "clabe"
        Me.DataGridViewTextBoxColumn5.HeaderText = "CLABE"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 250
        '
        'CXP_BancosTableAdapter
        '
        Me.CXP_BancosTableAdapter.ClearBeforeFill = True
        '
        'frmContProveedoresClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(990, 400)
        Me.Controls.Add(Me.CXP_CuentasBancariasProvDataGridView)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtBuscaProveedor)
        Me.Controls.Add(Me.cmbNacionalida)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.cmbSucursal)
        Me.Controls.Add(EmpresaLabel)
        Me.Controls.Add(MailLabel)
        Me.Controls.Add(Me.MailTextBox)
        Me.Controls.Add(FechaRegistroLabel)
        Me.Controls.Add(Me.FechaRegistroDateTimePicker)
        Me.Controls.Add(NacionalidadLabel)
        Me.Controls.Add(MontoMaxTransaccionLabel)
        Me.Controls.Add(Me.MontoMaxTransaccionTextBox)
        Me.Controls.Add(RelacionadoLabel)
        Me.Controls.Add(Me.RelacionadoCheckBox)
        Me.Controls.Add(IdSucursalLabel)
        Me.Controls.Add(NitLabel)
        Me.Controls.Add(Me.NitTextBox)
        Me.Controls.Add(ExtranjeroLabel)
        Me.Controls.Add(Me.ExtranjeroCheckBox)
        Me.Controls.Add(CurpLabel)
        Me.Controls.Add(Me.CurpTextBox)
        Me.Controls.Add(RfcLabel)
        Me.Controls.Add(Me.RfcTextBox)
        Me.Controls.Add(RazonSocialLabel)
        Me.Controls.Add(Me.RazonSocialTextBox)
        Me.Controls.Add(Me.CXP_ProveedoresBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmContProveedoresClientes"
        Me.Text = "Proveedores"
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXP_ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXP_ProveedoresBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CXP_ProveedoresBindingNavigator.ResumeLayout(False)
        Me.CXP_ProveedoresBindingNavigator.PerformLayout()
        CType(Me.CXPSucursalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPCuentasContablesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPEmpresasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPcPaisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXP_CuentasBancariasProvBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXP_CuentasBancariasProvDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPBancosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DsProduction As dsProduction
    Friend WithEvents CXP_ProveedoresBindingSource As BindingSource
    Friend WithEvents CXP_ProveedoresTableAdapter As dsProductionTableAdapters.CXP_ProveedoresTableAdapter
    Friend WithEvents TableAdapterManager As dsProductionTableAdapters.TableAdapterManager
    Friend WithEvents CXP_ProveedoresBindingNavigator As BindingNavigator
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
    Friend WithEvents CXP_ProveedoresBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents RazonSocialTextBox As TextBox
    Friend WithEvents RfcTextBox As TextBox
    Friend WithEvents CurpTextBox As TextBox
    Friend WithEvents ExtranjeroCheckBox As CheckBox
    Friend WithEvents NitTextBox As TextBox
    Friend WithEvents RelacionadoCheckBox As CheckBox
    Friend WithEvents MontoMaxTransaccionTextBox As TextBox
    Friend WithEvents FechaRegistroDateTimePicker As DateTimePicker
    Friend WithEvents MailTextBox As TextBox
    Friend WithEvents CXP_SucursalesTableAdapter As dsProductionTableAdapters.CXP_SucursalesTableAdapter
    Friend WithEvents cmbSucursal As ComboBox
    Friend WithEvents CXPSucursalesBindingSource As BindingSource
    Friend WithEvents CXP_CuentasContablesTableAdapter As dsProductionTableAdapters.CXP_CuentasContablesTableAdapter
    Friend WithEvents CXPCuentasContablesBindingSource As BindingSource
    Friend WithEvents btnSalir As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents CXPEmpresasBindingSource As BindingSource
    Friend WithEvents CXP_EmpresasTableAdapter As dsProductionTableAdapters.CXP_EmpresasTableAdapter
    Friend WithEvents cmbNacionalida As ComboBox
    Friend WithEvents CXPcPaisBindingSource As BindingSource
    Friend WithEvents CXP_c_PaisTableAdapter As dsProductionTableAdapters.CXP_c_PaisTableAdapter
    Friend WithEvents txtBuscaProveedor As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents CXP_CuentasBancariasProvBindingSource As BindingSource
    Friend WithEvents CXP_CuentasBancariasProvTableAdapter As dsProductionTableAdapters.CXP_CuentasBancariasProvTableAdapter
    Friend WithEvents CXP_CuentasBancariasProvDataGridView As DataGridView
    Friend WithEvents CXPBancosBindingSource As BindingSource
    Friend WithEvents CXP_BancosTableAdapter As dsProductionTableAdapters.CXP_BancosTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
End Class
