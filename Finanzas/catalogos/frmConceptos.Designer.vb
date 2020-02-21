<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConceptos
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
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ImpuestoLabel As System.Windows.Forms.Label
        Dim CuentaProvLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim IdConceptoLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConceptos))
        Me.CXP_ConceptosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.CXP_ConceptosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProduction = New cuentasPorPagar.dsProduction()
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
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.cmbCtaCargoSol = New System.Windows.Forms.ComboBox()
        Me.CuentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Contpaq = New cuentasPorPagar.contpaq()
        Me.cmbImpuesto = New System.Windows.Forms.ComboBox()
        Me.CXPImpuestoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CXPTipoGastoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.dgvImpuestos = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.impuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.eliminar = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.idImpuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.cmbCtaAbonoSol = New System.Windows.Forms.ComboBox()
        Me.CuentasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProduction1 = New cuentasPorPagar.dsProduction()
        Me.IdConceptoTextBox = New System.Windows.Forms.TextBox()
        Me.VwCXPImpConBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProduction2 = New cuentasPorPagar.dsProduction()
        Me.CXP_ConceptosTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_ConceptosTableAdapter()
        Me.TableAdapterManager = New cuentasPorPagar.dsProductionTableAdapters.TableAdapterManager()
        Me.CXP_CuentasContablesTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_CuentasContablesTableAdapter()
        Me.CXP_ImpuestoTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_ImpuestoTableAdapter()
        Me.CXP_TipoGastoTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_TipoGastoTableAdapter()
        Me.Vw_CXP_ImpConTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.Vw_CXP_ImpConTableAdapter()
        Me.CXPtipoDeDocumentoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CXP_tipoDeDocumentoTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_tipoDeDocumentoTableAdapter()
        Me.CXPtipoConceptoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProduction3 = New cuentasPorPagar.dsProduction()
        Me.CXP_tipoConceptoTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_tipoConceptoTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lnkEliminar4 = New System.Windows.Forms.LinkLabel()
        Me.lnkEliminar3 = New System.Windows.Forms.LinkLabel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lnkElimina2 = New System.Windows.Forms.LinkLabel()
        Me.lnkElimina1 = New System.Windows.Forms.LinkLabel()
        Me.cmbCtaCargoPago = New System.Windows.Forms.ComboBox()
        Me.CuentasBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContpaqBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbCtaAbonoPago = New System.Windows.Forms.ComboBox()
        Me.CuentasBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.EventoContableCheckBox = New System.Windows.Forms.CheckBox()
        Me.CuentasTableAdapter = New cuentasPorPagar.contpaqTableAdapters.CuentasTableAdapter()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.OmisionECCheckBox = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dgvImpuestosP = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewLinkColumn1 = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmbImpuestosP = New System.Windows.Forms.ComboBox()
        Me.btnAgregarP = New System.Windows.Forms.Button()
        NombreLabel = New System.Windows.Forms.Label()
        ImpuestoLabel = New System.Windows.Forms.Label()
        CuentaProvLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        IdConceptoLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.CXP_ConceptosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CXP_ConceptosBindingNavigator.SuspendLayout()
        CType(Me.CXP_ConceptosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Contpaq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPImpuestoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPTipoGastoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvImpuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuentasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProduction1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwCXPImpConBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProduction2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPtipoDeDocumentoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPtipoConceptoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProduction3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.CuentasBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContpaqBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuentasBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvImpuestosP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(8, 34)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(56, 13)
        NombreLabel.TabIndex = 1
        NombreLabel.Text = "Concepto:"
        '
        'ImpuestoLabel
        '
        ImpuestoLabel.AutoSize = True
        ImpuestoLabel.Location = New System.Drawing.Point(18, 26)
        ImpuestoLabel.Name = "ImpuestoLabel"
        ImpuestoLabel.Size = New System.Drawing.Size(53, 13)
        ImpuestoLabel.TabIndex = 7
        ImpuestoLabel.Text = "Impuesto:"
        '
        'CuentaProvLabel
        '
        CuentaProvLabel.AutoSize = True
        CuentaProvLabel.Location = New System.Drawing.Point(7, 63)
        CuentaProvLabel.Name = "CuentaProvLabel"
        CuentaProvLabel.Size = New System.Drawing.Size(78, 13)
        CuentaProvLabel.TabIndex = 22
        CuentaProvLabel.Text = "Cuenta Abono:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(7, 23)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(75, 13)
        Label1.TabIndex = 25
        Label1.Text = "Cuenta Cargo:"
        '
        'IdConceptoLabel
        '
        IdConceptoLabel.AutoSize = True
        IdConceptoLabel.Location = New System.Drawing.Point(23, 549)
        IdConceptoLabel.Name = "IdConceptoLabel"
        IdConceptoLabel.Size = New System.Drawing.Size(68, 13)
        IdConceptoLabel.TabIndex = 26
        IdConceptoLabel.Text = "Id Concepto:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(4, 70)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(78, 13)
        Label3.TabIndex = 26
        Label3.Text = "Cuenta Abono:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(6, 22)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(75, 13)
        Label4.TabIndex = 27
        Label4.Text = "Cuenta Cargo:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(18, 26)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(53, 13)
        Label2.TabIndex = 7
        Label2.Text = "Impuesto:"
        '
        'CXP_ConceptosBindingNavigator
        '
        Me.CXP_ConceptosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CXP_ConceptosBindingNavigator.BindingSource = Me.CXP_ConceptosBindingSource
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
        Me.CXP_ConceptosBindingNavigator.Size = New System.Drawing.Size(997, 25)
        Me.CXP_ConceptosBindingNavigator.TabIndex = 0
        Me.CXP_ConceptosBindingNavigator.Text = "BindingNavigator1"
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
        'CXP_ConceptosBindingSource
        '
        Me.CXP_ConceptosBindingSource.DataMember = "CXP_Conceptos"
        Me.CXP_ConceptosBindingSource.DataSource = Me.DsProduction
        '
        'DsProduction
        '
        Me.DsProduction.DataSetName = "dsProduction"
        Me.DsProduction.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'CXP_ConceptosBindingNavigatorSaveItem
        '
        Me.CXP_ConceptosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CXP_ConceptosBindingNavigatorSaveItem.Image = CType(resources.GetObject("CXP_ConceptosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CXP_ConceptosBindingNavigatorSaveItem.Name = "CXP_ConceptosBindingNavigatorSaveItem"
        Me.CXP_ConceptosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CXP_ConceptosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_ConceptosBindingSource, "nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(88, 34)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(412, 20)
        Me.NombreTextBox.TabIndex = 0
        '
        'cmbCtaCargoSol
        '
        Me.cmbCtaCargoSol.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbCtaCargoSol.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCtaCargoSol.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CXP_ConceptosBindingSource, "cuentaEgreso", True))
        Me.cmbCtaCargoSol.DataSource = Me.CuentasBindingSource
        Me.cmbCtaCargoSol.DisplayMember = "nCuenta"
        Me.cmbCtaCargoSol.FormattingEnabled = True
        Me.cmbCtaCargoSol.Location = New System.Drawing.Point(100, 15)
        Me.cmbCtaCargoSol.Name = "cmbCtaCargoSol"
        Me.cmbCtaCargoSol.Size = New System.Drawing.Size(362, 21)
        Me.cmbCtaCargoSol.TabIndex = 2
        Me.cmbCtaCargoSol.ValueMember = "Id"
        '
        'CuentasBindingSource
        '
        Me.CuentasBindingSource.DataMember = "Cuentas"
        Me.CuentasBindingSource.DataSource = Me.Contpaq
        '
        'Contpaq
        '
        Me.Contpaq.DataSetName = "contpaq"
        Me.Contpaq.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbImpuesto
        '
        Me.cmbImpuesto.DataSource = Me.CXPImpuestoBindingSource
        Me.cmbImpuesto.DisplayMember = "descripcionLarga"
        Me.cmbImpuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbImpuesto.FormattingEnabled = True
        Me.cmbImpuesto.Location = New System.Drawing.Point(77, 23)
        Me.cmbImpuesto.Name = "cmbImpuesto"
        Me.cmbImpuesto.Size = New System.Drawing.Size(327, 21)
        Me.cmbImpuesto.TabIndex = 4
        Me.cmbImpuesto.ValueMember = "idImpuesto"
        '
        'CXPImpuestoBindingSource
        '
        Me.CXPImpuestoBindingSource.DataMember = "CXP_Impuesto"
        Me.CXPImpuestoBindingSource.DataSource = Me.DsProduction
        '
        'CXPTipoGastoBindingSource
        '
        Me.CXPTipoGastoBindingSource.DataMember = "CXP_TipoGasto"
        Me.CXPTipoGastoBindingSource.DataSource = Me.DsProduction
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(899, 539)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 7
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'dgvImpuestos
        '
        Me.dgvImpuestos.AllowUserToAddRows = False
        Me.dgvImpuestos.AllowUserToDeleteRows = False
        Me.dgvImpuestos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvImpuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvImpuestos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.impuesto, Me.cuenta, Me.eliminar, Me.idImpuesto})
        Me.dgvImpuestos.Location = New System.Drawing.Point(12, 55)
        Me.dgvImpuestos.Name = "dgvImpuestos"
        Me.dgvImpuestos.ReadOnly = True
        Me.dgvImpuestos.RowHeadersVisible = False
        Me.dgvImpuestos.Size = New System.Drawing.Size(460, 108)
        Me.dgvImpuestos.TabIndex = 6
        '
        'id
        '
        Me.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.id.HeaderText = "Id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Width = 41
        '
        'impuesto
        '
        Me.impuesto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.impuesto.HeaderText = "Impuesto"
        Me.impuesto.Name = "impuesto"
        Me.impuesto.ReadOnly = True
        Me.impuesto.Width = 75
        '
        'cuenta
        '
        Me.cuenta.HeaderText = "Cuenta"
        Me.cuenta.Name = "cuenta"
        Me.cuenta.ReadOnly = True
        Me.cuenta.Width = 200
        '
        'eliminar
        '
        Me.eliminar.HeaderText = "Eliminar"
        Me.eliminar.Name = "eliminar"
        Me.eliminar.ReadOnly = True
        Me.eliminar.Width = 50
        '
        'idImpuesto
        '
        Me.idImpuesto.HeaderText = "IdImpuesto"
        Me.idImpuesto.Name = "idImpuesto"
        Me.idImpuesto.ReadOnly = True
        Me.idImpuesto.Visible = False
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(410, 22)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(62, 23)
        Me.btnAgregar.TabIndex = 5
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'cmbCtaAbonoSol
        '
        Me.cmbCtaAbonoSol.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbCtaAbonoSol.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCtaAbonoSol.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CXP_ConceptosBindingSource, "cuentaProv", True))
        Me.cmbCtaAbonoSol.DataSource = Me.CuentasBindingSource1
        Me.cmbCtaAbonoSol.DisplayMember = "nCuenta"
        Me.cmbCtaAbonoSol.FormattingEnabled = True
        Me.cmbCtaAbonoSol.Location = New System.Drawing.Point(100, 60)
        Me.cmbCtaAbonoSol.Name = "cmbCtaAbonoSol"
        Me.cmbCtaAbonoSol.Size = New System.Drawing.Size(362, 21)
        Me.cmbCtaAbonoSol.TabIndex = 3
        Me.cmbCtaAbonoSol.ValueMember = "Id"
        '
        'CuentasBindingSource1
        '
        Me.CuentasBindingSource1.DataMember = "Cuentas"
        Me.CuentasBindingSource1.DataSource = Me.Contpaq
        '
        'DsProduction1
        '
        Me.DsProduction1.DataSetName = "dsProduction"
        Me.DsProduction1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IdConceptoTextBox
        '
        Me.IdConceptoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_ConceptosBindingSource, "idConcepto", True))
        Me.IdConceptoTextBox.Location = New System.Drawing.Point(96, 546)
        Me.IdConceptoTextBox.Name = "IdConceptoTextBox"
        Me.IdConceptoTextBox.ReadOnly = True
        Me.IdConceptoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdConceptoTextBox.TabIndex = 27
        '
        'VwCXPImpConBindingSource
        '
        Me.VwCXPImpConBindingSource.DataMember = "Vw_CXP_ImpCon"
        Me.VwCXPImpConBindingSource.DataSource = Me.DsProduction2
        '
        'DsProduction2
        '
        Me.DsProduction2.DataSetName = "dsProduction"
        Me.DsProduction2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CXP_ConceptosTableAdapter
        '
        Me.CXP_ConceptosTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.CXP_ConceptosTableAdapter = Me.CXP_ConceptosTableAdapter
        Me.TableAdapterManager.CXP_CuentasBancariasProvTableAdapter = Nothing
        Me.TableAdapterManager.CXP_CuentasBancariasTableAdapter = Nothing
        Me.TableAdapterManager.CXP_CuentasContablesTableAdapter = Nothing
        Me.TableAdapterManager.CXP_DepartamentosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_DiariosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_EmpresasTableAdapter = Nothing
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
        Me.TableAdapterManager.CXP_tipoDeDocumentoTableAdapter = Nothing
        Me.TableAdapterManager.CXP_tipoDocumentoSatTableAdapter = Nothing
        Me.TableAdapterManager.CXP_TipoGastoTableAdapter = Nothing
        Me.TableAdapterManager.CXP_UsuariosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_XmlCfdi2TableAdapter = Nothing
        Me.TableAdapterManager.CXP_XmlCfdiTableAdapter = Nothing
        Me.TableAdapterManager.SucursalesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = cuentasPorPagar.dsProductionTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CXP_CuentasContablesTableAdapter
        '
        Me.CXP_CuentasContablesTableAdapter.ClearBeforeFill = True
        '
        'CXP_ImpuestoTableAdapter
        '
        Me.CXP_ImpuestoTableAdapter.ClearBeforeFill = True
        '
        'CXP_TipoGastoTableAdapter
        '
        Me.CXP_TipoGastoTableAdapter.ClearBeforeFill = True
        '
        'Vw_CXP_ImpConTableAdapter
        '
        Me.Vw_CXP_ImpConTableAdapter.ClearBeforeFill = True
        '
        'CXPtipoDeDocumentoBindingSource1
        '
        Me.CXPtipoDeDocumentoBindingSource1.DataMember = "CXP_tipoDeDocumento"
        Me.CXPtipoDeDocumentoBindingSource1.DataSource = Me.DsProduction
        Me.CXPtipoDeDocumentoBindingSource1.Filter = "documentoDe = 'Egreso'"
        '
        'CXP_tipoDeDocumentoTableAdapter
        '
        Me.CXP_tipoDeDocumentoTableAdapter.ClearBeforeFill = True
        '
        'CXPtipoConceptoBindingSource
        '
        Me.CXPtipoConceptoBindingSource.DataMember = "CXP_tipoConcepto"
        Me.CXPtipoConceptoBindingSource.DataSource = Me.DsProduction3
        '
        'DsProduction3
        '
        Me.DsProduction3.DataSetName = "dsProduction"
        Me.DsProduction3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CXP_tipoConceptoTableAdapter
        '
        Me.CXP_tipoConceptoTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lnkEliminar4)
        Me.GroupBox1.Controls.Add(Me.lnkEliminar3)
        Me.GroupBox1.Controls.Add(Me.cmbCtaCargoSol)
        Me.GroupBox1.Controls.Add(CuentaProvLabel)
        Me.GroupBox1.Controls.Add(Me.cmbCtaAbonoSol)
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(508, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(468, 108)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Solicitud de pago:"
        '
        'lnkEliminar4
        '
        Me.lnkEliminar4.AutoSize = True
        Me.lnkEliminar4.Location = New System.Drawing.Point(403, 87)
        Me.lnkEliminar4.Name = "lnkEliminar4"
        Me.lnkEliminar4.Size = New System.Drawing.Size(43, 13)
        Me.lnkEliminar4.TabIndex = 27
        Me.lnkEliminar4.TabStop = True
        Me.lnkEliminar4.Text = "Eliminar"
        '
        'lnkEliminar3
        '
        Me.lnkEliminar3.AutoSize = True
        Me.lnkEliminar3.Location = New System.Drawing.Point(403, 39)
        Me.lnkEliminar3.Name = "lnkEliminar3"
        Me.lnkEliminar3.Size = New System.Drawing.Size(43, 13)
        Me.lnkEliminar3.TabIndex = 26
        Me.lnkEliminar3.TabStop = True
        Me.lnkEliminar3.Text = "Eliminar"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lnkElimina2)
        Me.GroupBox2.Controls.Add(Me.lnkElimina1)
        Me.GroupBox2.Controls.Add(Label3)
        Me.GroupBox2.Controls.Add(Label4)
        Me.GroupBox2.Controls.Add(Me.cmbCtaCargoPago)
        Me.GroupBox2.Controls.Add(Me.cmbCtaAbonoPago)
        Me.GroupBox2.Location = New System.Drawing.Point(508, 272)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(470, 113)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pago:"
        '
        'lnkElimina2
        '
        Me.lnkElimina2.AutoSize = True
        Me.lnkElimina2.Location = New System.Drawing.Point(406, 94)
        Me.lnkElimina2.Name = "lnkElimina2"
        Me.lnkElimina2.Size = New System.Drawing.Size(43, 13)
        Me.lnkElimina2.TabIndex = 35
        Me.lnkElimina2.TabStop = True
        Me.lnkElimina2.Text = "Eliminar"
        '
        'lnkElimina1
        '
        Me.lnkElimina1.AutoSize = True
        Me.lnkElimina1.Location = New System.Drawing.Point(403, 43)
        Me.lnkElimina1.Name = "lnkElimina1"
        Me.lnkElimina1.Size = New System.Drawing.Size(43, 13)
        Me.lnkElimina1.TabIndex = 34
        Me.lnkElimina1.TabStop = True
        Me.lnkElimina1.Text = "Eliminar"
        '
        'cmbCtaCargoPago
        '
        Me.cmbCtaCargoPago.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbCtaCargoPago.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCtaCargoPago.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CXP_ConceptosBindingSource, "ctaCargoPago", True))
        Me.cmbCtaCargoPago.DataSource = Me.CuentasBindingSource2
        Me.cmbCtaCargoPago.DisplayMember = "nCuenta"
        Me.cmbCtaCargoPago.FormattingEnabled = True
        Me.cmbCtaCargoPago.Location = New System.Drawing.Point(100, 19)
        Me.cmbCtaCargoPago.Name = "cmbCtaCargoPago"
        Me.cmbCtaCargoPago.Size = New System.Drawing.Size(362, 21)
        Me.cmbCtaCargoPago.TabIndex = 0
        Me.cmbCtaCargoPago.ValueMember = "Id"
        '
        'CuentasBindingSource2
        '
        Me.CuentasBindingSource2.DataMember = "Cuentas"
        Me.CuentasBindingSource2.DataSource = Me.ContpaqBindingSource
        '
        'ContpaqBindingSource
        '
        Me.ContpaqBindingSource.DataSource = Me.Contpaq
        Me.ContpaqBindingSource.Position = 0
        '
        'cmbCtaAbonoPago
        '
        Me.cmbCtaAbonoPago.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbCtaAbonoPago.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCtaAbonoPago.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CXP_ConceptosBindingSource, "ctaAbonoPago", True))
        Me.cmbCtaAbonoPago.DataSource = Me.CuentasBindingSource3
        Me.cmbCtaAbonoPago.DisplayMember = "nCuenta"
        Me.cmbCtaAbonoPago.FormattingEnabled = True
        Me.cmbCtaAbonoPago.Location = New System.Drawing.Point(100, 67)
        Me.cmbCtaAbonoPago.Name = "cmbCtaAbonoPago"
        Me.cmbCtaAbonoPago.Size = New System.Drawing.Size(362, 21)
        Me.cmbCtaAbonoPago.TabIndex = 33
        Me.cmbCtaAbonoPago.ValueMember = "Id"
        '
        'CuentasBindingSource3
        '
        Me.CuentasBindingSource3.DataMember = "Cuentas"
        Me.CuentasBindingSource3.DataSource = Me.Contpaq
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvImpuestos)
        Me.GroupBox3.Controls.Add(ImpuestoLabel)
        Me.GroupBox3.Controls.Add(Me.cmbImpuesto)
        Me.GroupBox3.Controls.Add(Me.btnAgregar)
        Me.GroupBox3.Location = New System.Drawing.Point(11, 75)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(489, 179)
        Me.GroupBox3.TabIndex = 33
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Impuestos Solicitud:"
        '
        'EventoContableCheckBox
        '
        Me.EventoContableCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CXP_ConceptosBindingSource, "eventoContable", True))
        Me.EventoContableCheckBox.Location = New System.Drawing.Point(516, 533)
        Me.EventoContableCheckBox.Name = "EventoContableCheckBox"
        Me.EventoContableCheckBox.Size = New System.Drawing.Size(173, 37)
        Me.EventoContableCheckBox.TabIndex = 30
        Me.EventoContableCheckBox.Text = "Sin Comprobante"
        Me.EventoContableCheckBox.UseVisualStyleBackColor = True
        '
        'CuentasTableAdapter
        '
        Me.CuentasTableAdapter.ClearBeforeFill = True
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(551, 34)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(207, 20)
        Me.txtBuscar.TabIndex = 34
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(764, 32)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 35
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'OmisionECCheckBox
        '
        Me.OmisionECCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CXP_ConceptosBindingSource, "omisionEC", True))
        Me.OmisionECCheckBox.Location = New System.Drawing.Point(638, 539)
        Me.OmisionECCheckBox.Name = "OmisionECCheckBox"
        Me.OmisionECCheckBox.Size = New System.Drawing.Size(158, 24)
        Me.OmisionECCheckBox.TabIndex = 36
        Me.OmisionECCheckBox.Text = "Omite Evento Contable"
        Me.OmisionECCheckBox.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dgvImpuestosP)
        Me.GroupBox4.Controls.Add(Label2)
        Me.GroupBox4.Controls.Add(Me.cmbImpuestosP)
        Me.GroupBox4.Controls.Add(Me.btnAgregarP)
        Me.GroupBox4.Location = New System.Drawing.Point(11, 272)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(489, 179)
        Me.GroupBox4.TabIndex = 34
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Impuestos Pago:"
        '
        'dgvImpuestosP
        '
        Me.dgvImpuestosP.AllowUserToAddRows = False
        Me.dgvImpuestosP.AllowUserToDeleteRows = False
        Me.dgvImpuestosP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvImpuestosP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvImpuestosP.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewLinkColumn1, Me.DataGridViewTextBoxColumn4})
        Me.dgvImpuestosP.Location = New System.Drawing.Point(12, 55)
        Me.dgvImpuestosP.Name = "dgvImpuestosP"
        Me.dgvImpuestosP.ReadOnly = True
        Me.dgvImpuestosP.RowHeadersVisible = False
        Me.dgvImpuestosP.Size = New System.Drawing.Size(460, 108)
        Me.dgvImpuestosP.TabIndex = 6
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 41
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.HeaderText = "Impuesto"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 75
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cuenta"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 200
        '
        'DataGridViewLinkColumn1
        '
        Me.DataGridViewLinkColumn1.HeaderText = "Eliminar"
        Me.DataGridViewLinkColumn1.Name = "DataGridViewLinkColumn1"
        Me.DataGridViewLinkColumn1.ReadOnly = True
        Me.DataGridViewLinkColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "IdImpuesto"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'cmbImpuestosP
        '
        Me.cmbImpuestosP.DataSource = Me.CXPImpuestoBindingSource
        Me.cmbImpuestosP.DisplayMember = "descripcionLarga"
        Me.cmbImpuestosP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbImpuestosP.FormattingEnabled = True
        Me.cmbImpuestosP.Location = New System.Drawing.Point(77, 23)
        Me.cmbImpuestosP.Name = "cmbImpuestosP"
        Me.cmbImpuestosP.Size = New System.Drawing.Size(327, 21)
        Me.cmbImpuestosP.TabIndex = 4
        Me.cmbImpuestosP.ValueMember = "idImpuesto"
        '
        'btnAgregarP
        '
        Me.btnAgregarP.Location = New System.Drawing.Point(410, 22)
        Me.btnAgregarP.Name = "btnAgregarP"
        Me.btnAgregarP.Size = New System.Drawing.Size(62, 23)
        Me.btnAgregarP.TabIndex = 5
        Me.btnAgregarP.Text = "Agregar"
        Me.btnAgregarP.UseVisualStyleBackColor = True
        '
        'frmConceptos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(997, 575)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.OmisionECCheckBox)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.EventoContableCheckBox)
        Me.Controls.Add(IdConceptoLabel)
        Me.Controls.Add(Me.IdConceptoTextBox)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(Me.CXP_ConceptosBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmConceptos"
        Me.Text = "Conceptos"
        CType(Me.CXP_ConceptosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CXP_ConceptosBindingNavigator.ResumeLayout(False)
        Me.CXP_ConceptosBindingNavigator.PerformLayout()
        CType(Me.CXP_ConceptosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Contpaq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPImpuestoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPTipoGastoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvImpuestos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuentasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProduction1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwCXPImpConBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProduction2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPtipoDeDocumentoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPtipoConceptoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProduction3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.CuentasBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContpaqBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuentasBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgvImpuestosP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DsProduction As dsProduction
    Friend WithEvents CXP_ConceptosBindingSource As BindingSource
    Friend WithEvents CXP_ConceptosTableAdapter As dsProductionTableAdapters.CXP_ConceptosTableAdapter
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
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents cmbCtaCargoSol As ComboBox
    Friend WithEvents CXP_CuentasContablesTableAdapter As dsProductionTableAdapters.CXP_CuentasContablesTableAdapter
    Friend WithEvents cmbImpuesto As ComboBox
    Friend WithEvents CXPImpuestoBindingSource As BindingSource
    Friend WithEvents CXP_ImpuestoTableAdapter As dsProductionTableAdapters.CXP_ImpuestoTableAdapter
    Friend WithEvents btnSalir As Button
    Friend WithEvents CXPTipoGastoBindingSource As BindingSource
    Friend WithEvents CXP_TipoGastoTableAdapter As dsProductionTableAdapters.CXP_TipoGastoTableAdapter
    Friend WithEvents dgvImpuestos As DataGridView
    Friend WithEvents btnAgregar As Button
    Friend WithEvents cmbCtaAbonoSol As ComboBox
    Friend WithEvents DsProduction1 As dsProduction
    Friend WithEvents IdConceptoTextBox As TextBox
    Friend WithEvents DsProduction2 As dsProduction
    Friend WithEvents VwCXPImpConBindingSource As BindingSource
    Friend WithEvents Vw_CXP_ImpConTableAdapter As dsProductionTableAdapters.Vw_CXP_ImpConTableAdapter
    Friend WithEvents CXPtipoDeDocumentoBindingSource1 As BindingSource
    Friend WithEvents CXP_tipoDeDocumentoTableAdapter As dsProductionTableAdapters.CXP_tipoDeDocumentoTableAdapter
    Friend WithEvents DsProduction3 As dsProduction
    Friend WithEvents CXPtipoConceptoBindingSource As BindingSource
    Friend WithEvents CXP_tipoConceptoTableAdapter As dsProductionTableAdapters.CXP_tipoConceptoTableAdapter
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmbCtaCargoPago As ComboBox
    Friend WithEvents cmbCtaAbonoPago As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents EventoContableCheckBox As CheckBox
    Friend WithEvents lnkElimina1 As LinkLabel
    Friend WithEvents lnkElimina2 As LinkLabel
    Friend WithEvents lnkEliminar3 As LinkLabel
    Friend WithEvents lnkEliminar4 As LinkLabel
    Friend WithEvents Contpaq As contpaq
    Friend WithEvents CuentasBindingSource As BindingSource
    Friend WithEvents CuentasTableAdapter As contpaqTableAdapters.CuentasTableAdapter
    Friend WithEvents CuentasBindingSource1 As BindingSource
    Friend WithEvents CuentasBindingSource2 As BindingSource
    Friend WithEvents ContpaqBindingSource As BindingSource
    Friend WithEvents CuentasBindingSource3 As BindingSource
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents impuesto As DataGridViewTextBoxColumn
    Friend WithEvents cuenta As DataGridViewTextBoxColumn
    Friend WithEvents eliminar As DataGridViewLinkColumn
    Friend WithEvents idImpuesto As DataGridViewTextBoxColumn
    Friend WithEvents OmisionECCheckBox As CheckBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents dgvImpuestosP As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewLinkColumn1 As DataGridViewLinkColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents cmbImpuestosP As ComboBox
    Friend WithEvents btnAgregarP As Button
End Class
