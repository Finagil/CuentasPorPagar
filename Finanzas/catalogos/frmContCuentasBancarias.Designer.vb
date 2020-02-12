<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmContCuentasBancarias
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
        Dim NumeroDeCuentaLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim FolioChequeInicialLabel As System.Windows.Forms.Label
        Dim FolioChequeFinalLabel As System.Windows.Forms.Label
        Dim FolioChequeActualLabel As System.Windows.Forms.Label
        Dim FechaInicialLabel As System.Windows.Forms.Label
        Dim SaldoInicialLabel As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContCuentasBancarias))
        Me.DsProduction = New cuentasPorPagar.dsProduction()
        Me.CXP_CuentasBancariasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CXP_CuentasBancariasTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_CuentasBancariasTableAdapter()
        Me.TableAdapterManager = New cuentasPorPagar.dsProductionTableAdapters.TableAdapterManager()
        Me.CXP_c_MonedaTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_c_MonedaTableAdapter()
        Me.CXP_CuentasBancariasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.CXP_CuentasBancariasBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NumeroDeCuentaTextBox = New System.Windows.Forms.TextBox()
        Me.cmbNombre = New System.Windows.Forms.ComboBox()
        Me.CXPBancosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtRFC = New System.Windows.Forms.TextBox()
        Me.cmbMoneda = New System.Windows.Forms.ComboBox()
        Me.CXPcMonedaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FolioChequeInicialTextBox = New System.Windows.Forms.TextBox()
        Me.FolioChequeFinalTextBox = New System.Windows.Forms.TextBox()
        Me.FolioChequeActualTextBox = New System.Windows.Forms.TextBox()
        Me.FechaInicialDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SaldoInicialTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CXP_BancosTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_BancosTableAdapter()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.CXPCuentasContablesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CXP_CuentasContablesTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_CuentasContablesTableAdapter()
        Me.CXP_tipoDeDocumentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CXP_tipoDeDocumentoTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_tipoDeDocumentoTableAdapter()
        NumeroDeCuentaLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        FolioChequeInicialLabel = New System.Windows.Forms.Label()
        FolioChequeFinalLabel = New System.Windows.Forms.Label()
        FolioChequeActualLabel = New System.Windows.Forms.Label()
        FechaInicialLabel = New System.Windows.Forms.Label()
        SaldoInicialLabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXP_CuentasBancariasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXP_CuentasBancariasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CXP_CuentasBancariasBindingNavigator.SuspendLayout()
        CType(Me.CXPBancosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPcMonedaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPCuentasContablesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXP_tipoDeDocumentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NumeroDeCuentaLabel
        '
        NumeroDeCuentaLabel.AutoSize = True
        NumeroDeCuentaLabel.Location = New System.Drawing.Point(56, 31)
        NumeroDeCuentaLabel.Name = "NumeroDeCuentaLabel"
        NumeroDeCuentaLabel.Size = New System.Drawing.Size(101, 13)
        NumeroDeCuentaLabel.TabIndex = 1
        NumeroDeCuentaLabel.Text = "Número De Cuenta:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(110, 57)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 3
        NombreLabel.Text = "Nombre:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(124, 110)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(31, 13)
        Label1.TabIndex = 7
        Label1.Text = "RFC:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(57, 83)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(98, 13)
        Label2.TabIndex = 8
        Label2.Text = "Intitución Bancaria:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(344, 109)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(49, 13)
        Label3.TabIndex = 10
        Label3.Text = "Moneda:"
        '
        'FolioChequeInicialLabel
        '
        FolioChequeInicialLabel.AutoSize = True
        FolioChequeInicialLabel.Location = New System.Drawing.Point(427, 136)
        FolioChequeInicialLabel.Name = "FolioChequeInicialLabel"
        FolioChequeInicialLabel.Size = New System.Drawing.Size(102, 13)
        FolioChequeInicialLabel.TabIndex = 11
        FolioChequeInicialLabel.Text = "Folio Cheque Inicial:"
        '
        'FolioChequeFinalLabel
        '
        FolioChequeFinalLabel.AutoSize = True
        FolioChequeFinalLabel.Location = New System.Drawing.Point(432, 162)
        FolioChequeFinalLabel.Name = "FolioChequeFinalLabel"
        FolioChequeFinalLabel.Size = New System.Drawing.Size(97, 13)
        FolioChequeFinalLabel.TabIndex = 13
        FolioChequeFinalLabel.Text = "Folio Cheque Final:"
        '
        'FolioChequeActualLabel
        '
        FolioChequeActualLabel.AutoSize = True
        FolioChequeActualLabel.Location = New System.Drawing.Point(424, 188)
        FolioChequeActualLabel.Name = "FolioChequeActualLabel"
        FolioChequeActualLabel.Size = New System.Drawing.Size(105, 13)
        FolioChequeActualLabel.TabIndex = 15
        FolioChequeActualLabel.Text = "Folio Cheque Actual:"
        '
        'FechaInicialLabel
        '
        FechaInicialLabel.AutoSize = True
        FechaInicialLabel.Location = New System.Drawing.Point(38, 165)
        FechaInicialLabel.Name = "FechaInicialLabel"
        FechaInicialLabel.Size = New System.Drawing.Size(117, 13)
        FechaInicialLabel.TabIndex = 17
        FechaInicialLabel.Text = "Fecha del Saldo Inicial:"
        '
        'SaldoInicialLabel
        '
        SaldoInicialLabel.AutoSize = True
        SaldoInicialLabel.Location = New System.Drawing.Point(90, 136)
        SaldoInicialLabel.Name = "SaldoInicialLabel"
        SaldoInicialLabel.Size = New System.Drawing.Size(67, 13)
        SaldoInicialLabel.TabIndex = 19
        SaldoInicialLabel.Text = "Saldo Inicial:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(66, 188)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(89, 13)
        Label4.TabIndex = 24
        Label4.Text = "Cuenta Contable:"
        '
        'DsProduction
        '
        Me.DsProduction.DataSetName = "dsProduction"
        Me.DsProduction.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CXP_CuentasBancariasBindingSource
        '
        Me.CXP_CuentasBancariasBindingSource.DataMember = "CXP_CuentasBancarias"
        Me.CXP_CuentasBancariasBindingSource.DataSource = Me.DsProduction
        '
        'CXP_CuentasBancariasTableAdapter
        '
        Me.CXP_CuentasBancariasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CXP_BancosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_c_CodigoPostalTableAdapter = Nothing
        Me.TableAdapterManager.CXP_c_EstadoTableAdapter = Nothing
        Me.TableAdapterManager.CXP_c_MonedaTableAdapter = Me.CXP_c_MonedaTableAdapter
        Me.TableAdapterManager.CXP_c_PaisTableAdapter = Nothing
        Me.TableAdapterManager.CXP_c_RegimenFiscalTableAdapter = Nothing
        Me.TableAdapterManager.CXP_CodigoAgrupadorTableAdapter = Nothing
        Me.TableAdapterManager.CXP_ConceptosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_CuentasBancariasTableAdapter = Me.CXP_CuentasBancariasTableAdapter
        Me.TableAdapterManager.CXP_CuentasContablesTableAdapter = Nothing
        Me.TableAdapterManager.CXP_DiariosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_EmpresasTableAdapter = Nothing
        Me.TableAdapterManager.CXP_ImpuestoTableAdapter = Nothing
        Me.TableAdapterManager.CXP_PerfilesTableAdapter = Nothing
        Me.TableAdapterManager.CXP_PerfilesUsuarioTableAdapter = Nothing
        Me.TableAdapterManager.CXP_ProveedoresTableAdapter = Nothing
        Me.TableAdapterManager.CXP_SucursalesTableAdapter = Nothing
        Me.TableAdapterManager.CXP_tipoDeDocumentoTableAdapter = Nothing
        Me.TableAdapterManager.CXP_TipoGastoTableAdapter = Nothing
        Me.TableAdapterManager.CXP_UsuariosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = cuentasPorPagar.dsProductionTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CXP_c_MonedaTableAdapter
        '
        Me.CXP_c_MonedaTableAdapter.ClearBeforeFill = True
        '
        'CXP_CuentasBancariasBindingNavigator
        '
        Me.CXP_CuentasBancariasBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CXP_CuentasBancariasBindingNavigator.BindingSource = Me.CXP_CuentasBancariasBindingSource
        Me.CXP_CuentasBancariasBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CXP_CuentasBancariasBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CXP_CuentasBancariasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CXP_CuentasBancariasBindingNavigatorSaveItem})
        Me.CXP_CuentasBancariasBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CXP_CuentasBancariasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CXP_CuentasBancariasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CXP_CuentasBancariasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CXP_CuentasBancariasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CXP_CuentasBancariasBindingNavigator.Name = "CXP_CuentasBancariasBindingNavigator"
        Me.CXP_CuentasBancariasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CXP_CuentasBancariasBindingNavigator.Size = New System.Drawing.Size(720, 25)
        Me.CXP_CuentasBancariasBindingNavigator.TabIndex = 0
        Me.CXP_CuentasBancariasBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
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
        'CXP_CuentasBancariasBindingNavigatorSaveItem
        '
        Me.CXP_CuentasBancariasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CXP_CuentasBancariasBindingNavigatorSaveItem.Image = CType(resources.GetObject("CXP_CuentasBancariasBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CXP_CuentasBancariasBindingNavigatorSaveItem.Name = "CXP_CuentasBancariasBindingNavigatorSaveItem"
        Me.CXP_CuentasBancariasBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CXP_CuentasBancariasBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'NumeroDeCuentaTextBox
        '
        Me.NumeroDeCuentaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_CuentasBancariasBindingSource, "numeroDeCuenta", True))
        Me.NumeroDeCuentaTextBox.Location = New System.Drawing.Point(161, 28)
        Me.NumeroDeCuentaTextBox.Name = "NumeroDeCuentaTextBox"
        Me.NumeroDeCuentaTextBox.Size = New System.Drawing.Size(233, 20)
        Me.NumeroDeCuentaTextBox.TabIndex = 2
        '
        'cmbNombre
        '
        Me.cmbNombre.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CXP_CuentasBancariasBindingSource, "idBancoSat", True))
        Me.cmbNombre.DataSource = Me.CXPBancosBindingSource
        Me.cmbNombre.DisplayMember = "razonSocial"
        Me.cmbNombre.FormattingEnabled = True
        Me.cmbNombre.Location = New System.Drawing.Point(161, 80)
        Me.cmbNombre.Name = "cmbNombre"
        Me.cmbNombre.Size = New System.Drawing.Size(471, 21)
        Me.cmbNombre.TabIndex = 4
        Me.cmbNombre.ValueMember = "claveBanco"
        '
        'CXPBancosBindingSource
        '
        Me.CXPBancosBindingSource.DataMember = "CXP_Bancos"
        Me.CXPBancosBindingSource.DataSource = Me.DsProduction
        '
        'txtRFC
        '
        Me.txtRFC.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXPBancosBindingSource, "rfc", True))
        Me.txtRFC.Location = New System.Drawing.Point(161, 107)
        Me.txtRFC.Name = "txtRFC"
        Me.txtRFC.ReadOnly = True
        Me.txtRFC.Size = New System.Drawing.Size(111, 20)
        Me.txtRFC.TabIndex = 5
        '
        'cmbMoneda
        '
        Me.cmbMoneda.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CXP_CuentasBancariasBindingSource, "idMoneda", True))
        Me.cmbMoneda.DataSource = Me.CXPcMonedaBindingSource
        Me.cmbMoneda.DisplayMember = "c_NombreMoneda"
        Me.cmbMoneda.FormattingEnabled = True
        Me.cmbMoneda.Location = New System.Drawing.Point(399, 106)
        Me.cmbMoneda.Name = "cmbMoneda"
        Me.cmbMoneda.Size = New System.Drawing.Size(233, 21)
        Me.cmbMoneda.TabIndex = 9
        Me.cmbMoneda.ValueMember = "c_Moneda"
        '
        'CXPcMonedaBindingSource
        '
        Me.CXPcMonedaBindingSource.DataMember = "CXP_c_Moneda"
        Me.CXPcMonedaBindingSource.DataSource = Me.DsProduction
        '
        'FolioChequeInicialTextBox
        '
        Me.FolioChequeInicialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_CuentasBancariasBindingSource, "folioChequeInicial", True))
        Me.FolioChequeInicialTextBox.Location = New System.Drawing.Point(532, 133)
        Me.FolioChequeInicialTextBox.Name = "FolioChequeInicialTextBox"
        Me.FolioChequeInicialTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FolioChequeInicialTextBox.TabIndex = 12
        '
        'FolioChequeFinalTextBox
        '
        Me.FolioChequeFinalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_CuentasBancariasBindingSource, "folioChequeFinal", True))
        Me.FolioChequeFinalTextBox.Location = New System.Drawing.Point(532, 159)
        Me.FolioChequeFinalTextBox.Name = "FolioChequeFinalTextBox"
        Me.FolioChequeFinalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FolioChequeFinalTextBox.TabIndex = 14
        '
        'FolioChequeActualTextBox
        '
        Me.FolioChequeActualTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_CuentasBancariasBindingSource, "folioChequeActual", True))
        Me.FolioChequeActualTextBox.Location = New System.Drawing.Point(532, 185)
        Me.FolioChequeActualTextBox.Name = "FolioChequeActualTextBox"
        Me.FolioChequeActualTextBox.ReadOnly = True
        Me.FolioChequeActualTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FolioChequeActualTextBox.TabIndex = 16
        '
        'FechaInicialDateTimePicker
        '
        Me.FechaInicialDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CXP_CuentasBancariasBindingSource, "fechaInicial", True))
        Me.FechaInicialDateTimePicker.Location = New System.Drawing.Point(161, 159)
        Me.FechaInicialDateTimePicker.Name = "FechaInicialDateTimePicker"
        Me.FechaInicialDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechaInicialDateTimePicker.TabIndex = 18
        '
        'SaldoInicialTextBox
        '
        Me.SaldoInicialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_CuentasBancariasBindingSource, "saldoInicial", True))
        Me.SaldoInicialTextBox.Location = New System.Drawing.Point(161, 133)
        Me.SaldoInicialTextBox.Name = "SaldoInicialTextBox"
        Me.SaldoInicialTextBox.Size = New System.Drawing.Size(111, 20)
        Me.SaldoInicialTextBox.TabIndex = 20
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(557, 213)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CXP_BancosTableAdapter
        '
        Me.CXP_BancosTableAdapter.ClearBeforeFill = True
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_CuentasBancariasBindingSource, "nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(161, 54)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(471, 20)
        Me.NombreTextBox.TabIndex = 22
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CXP_CuentasBancariasBindingSource, "cuentaCont", True))
        Me.ComboBox1.DataSource = Me.CXPCuentasContablesBindingSource
        Me.ComboBox1.DisplayMember = "nombre"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(161, 186)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox1.TabIndex = 23
        Me.ComboBox1.ValueMember = "idCuentaContable"
        '
        'CXPCuentasContablesBindingSource
        '
        Me.CXPCuentasContablesBindingSource.DataMember = "CXP_CuentasContables"
        Me.CXPCuentasContablesBindingSource.DataSource = Me.DsProduction
        '
        'CXP_CuentasContablesTableAdapter
        '
        Me.CXP_CuentasContablesTableAdapter.ClearBeforeFill = True
        '
        'CXP_tipoDeDocumentoBindingSource
        '
        Me.CXP_tipoDeDocumentoBindingSource.DataMember = "CXP_tipoDeDocumento"
        Me.CXP_tipoDeDocumentoBindingSource.DataSource = Me.DsProduction
        '
        'CXP_tipoDeDocumentoTableAdapter
        '
        Me.CXP_tipoDeDocumentoTableAdapter.ClearBeforeFill = True
        '
        'frmContCuentasBancarias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 256)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(SaldoInicialLabel)
        Me.Controls.Add(Me.SaldoInicialTextBox)
        Me.Controls.Add(FechaInicialLabel)
        Me.Controls.Add(Me.FechaInicialDateTimePicker)
        Me.Controls.Add(FolioChequeActualLabel)
        Me.Controls.Add(Me.FolioChequeActualTextBox)
        Me.Controls.Add(FolioChequeFinalLabel)
        Me.Controls.Add(Me.FolioChequeFinalTextBox)
        Me.Controls.Add(FolioChequeInicialLabel)
        Me.Controls.Add(Me.FolioChequeInicialTextBox)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.cmbMoneda)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.txtRFC)
        Me.Controls.Add(Me.cmbNombre)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(NumeroDeCuentaLabel)
        Me.Controls.Add(Me.NumeroDeCuentaTextBox)
        Me.Controls.Add(Me.CXP_CuentasBancariasBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmContCuentasBancarias"
        Me.Text = "Cuentas Bancarias"
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXP_CuentasBancariasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXP_CuentasBancariasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CXP_CuentasBancariasBindingNavigator.ResumeLayout(False)
        Me.CXP_CuentasBancariasBindingNavigator.PerformLayout()
        CType(Me.CXPBancosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPcMonedaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPCuentasContablesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXP_tipoDeDocumentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DsProduction As dsProduction
    Friend WithEvents CXP_CuentasBancariasBindingSource As BindingSource
    Friend WithEvents CXP_CuentasBancariasTableAdapter As dsProductionTableAdapters.CXP_CuentasBancariasTableAdapter
    Friend WithEvents TableAdapterManager As dsProductionTableAdapters.TableAdapterManager
    Friend WithEvents CXP_CuentasBancariasBindingNavigator As BindingNavigator
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
    Friend WithEvents CXP_CuentasBancariasBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CXP_c_MonedaTableAdapter As dsProductionTableAdapters.CXP_c_MonedaTableAdapter
    Friend WithEvents NumeroDeCuentaTextBox As TextBox
    Friend WithEvents cmbNombre As ComboBox
    Friend WithEvents txtRFC As TextBox
    Friend WithEvents cmbMoneda As ComboBox
    Friend WithEvents FolioChequeInicialTextBox As TextBox
    Friend WithEvents FolioChequeFinalTextBox As TextBox
    Friend WithEvents FolioChequeActualTextBox As TextBox
    Friend WithEvents FechaInicialDateTimePicker As DateTimePicker
    Friend WithEvents SaldoInicialTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents CXPcMonedaBindingSource As BindingSource
    Friend WithEvents CXPBancosBindingSource As BindingSource
    Friend WithEvents CXP_BancosTableAdapter As dsProductionTableAdapters.CXP_BancosTableAdapter
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents CXPCuentasContablesBindingSource As BindingSource
    Friend WithEvents CXP_CuentasContablesTableAdapter As dsProductionTableAdapters.CXP_CuentasContablesTableAdapter
    Friend WithEvents CXP_tipoDeDocumentoBindingSource As BindingSource
    Friend WithEvents CXP_tipoDeDocumentoTableAdapter As dsProductionTableAdapters.CXP_tipoDeDocumentoTableAdapter
End Class
