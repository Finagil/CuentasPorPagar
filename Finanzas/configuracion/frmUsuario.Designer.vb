<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuario
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
        Dim NombreLabel As System.Windows.Forms.Label
        Dim UsuarioLabel As System.Windows.Forms.Label
        Dim MailLabel As System.Windows.Forms.Label
        Dim DepartamentoLabel As System.Windows.Forms.Label
        Dim SucursalLabel As System.Windows.Forms.Label
        Dim RfcLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsuario))
        Me.DsProduction = New cuentasPorPagar.dsProduction()
        Me.CXP_UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CXP_UsuariosTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_UsuariosTableAdapter()
        Me.TableAdapterManager = New cuentasPorPagar.dsProductionTableAdapters.TableAdapterManager()
        Me.CXP_UsuariosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.CXP_UsuariosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.cmbUsuarioActual = New System.Windows.Forms.ComboBox()
        Me.USUARIOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsSeguridad = New cuentasPorPagar.dsSeguridad()
        Me.USUARIOTableAdapter = New cuentasPorPagar.dsSeguridadTableAdapters.USUARIOTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.MailTextBox = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.cmbEmpresas = New System.Windows.Forms.ComboBox()
        Me.CXPEmpresasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CXP_EmpresasTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_EmpresasTableAdapter()
        Me.dgvEmpresas = New System.Windows.Forms.DataGridView()
        Me.idEmpresa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.empresa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.eliminar = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.cmbAccesoWeb = New System.Windows.Forms.ComboBox()
        Me.CXPPerfilesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProduction2 = New cuentasPorPagar.dsProduction()
        Me.CXPPerfilesUsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CXP_PerfilesUsuarioTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_PerfilesUsuarioTableAdapter()
        Me.DsProduction1 = New cuentasPorPagar.dsProduction()
        Me.CXP_PerfilesTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_PerfilesTableAdapter()
        Me.btnAgregarUsuario = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.dgvTipoConceptos = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.eliminar2 = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.cmbTipoConcepto = New System.Windows.Forms.ComboBox()
        Me.CXPConceptosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CXPtipoConceptoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.CXPSucursalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ActivoCheckBox = New System.Windows.Forms.CheckBox()
        Me.PwTextBox = New System.Windows.Forms.TextBox()
        Me.RfcTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnAgregarConcepto = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CXP_tipoConceptoTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_tipoConceptoTableAdapter()
        Me.CXP_ConceptosTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_ConceptosTableAdapter()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.CXP_SucursalesTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_SucursalesTableAdapter()
        Me.CXPDepartamentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CXP_DepartamentosTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_DepartamentosTableAdapter()
        NombreLabel = New System.Windows.Forms.Label()
        UsuarioLabel = New System.Windows.Forms.Label()
        MailLabel = New System.Windows.Forms.Label()
        DepartamentoLabel = New System.Windows.Forms.Label()
        SucursalLabel = New System.Windows.Forms.Label()
        RfcLabel = New System.Windows.Forms.Label()
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXP_UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXP_UsuariosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CXP_UsuariosBindingNavigator.SuspendLayout()
        CType(Me.USUARIOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSeguridad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPEmpresasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvEmpresas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPPerfilesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProduction2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPPerfilesUsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProduction1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTipoConceptos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPConceptosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPtipoConceptoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CXPSucursalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.CXPDepartamentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(40, 22)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 1
        NombreLabel.Text = "Nombre:"
        '
        'UsuarioLabel
        '
        UsuarioLabel.AutoSize = True
        UsuarioLabel.Location = New System.Drawing.Point(43, 48)
        UsuarioLabel.Name = "UsuarioLabel"
        UsuarioLabel.Size = New System.Drawing.Size(46, 13)
        UsuarioLabel.TabIndex = 5
        UsuarioLabel.Text = "Usuario:"
        '
        'MailLabel
        '
        MailLabel.AutoSize = True
        MailLabel.Location = New System.Drawing.Point(59, 74)
        MailLabel.Name = "MailLabel"
        MailLabel.Size = New System.Drawing.Size(28, 13)
        MailLabel.TabIndex = 7
        MailLabel.Text = "mail:"
        '
        'DepartamentoLabel
        '
        DepartamentoLabel.AutoSize = True
        DepartamentoLabel.Location = New System.Drawing.Point(12, 100)
        DepartamentoLabel.Name = "DepartamentoLabel"
        DepartamentoLabel.Size = New System.Drawing.Size(77, 13)
        DepartamentoLabel.TabIndex = 9
        DepartamentoLabel.Text = "Departamento:"
        '
        'SucursalLabel
        '
        SucursalLabel.AutoSize = True
        SucursalLabel.Location = New System.Drawing.Point(253, 100)
        SucursalLabel.Name = "SucursalLabel"
        SucursalLabel.Size = New System.Drawing.Size(51, 13)
        SucursalLabel.TabIndex = 11
        SucursalLabel.Text = "Sucursal:"
        '
        'RfcLabel
        '
        RfcLabel.AutoSize = True
        RfcLabel.Location = New System.Drawing.Point(291, 48)
        RfcLabel.Name = "RfcLabel"
        RfcLabel.Size = New System.Drawing.Size(31, 13)
        RfcLabel.TabIndex = 31
        RfcLabel.Text = "RFC:"
        '
        'DsProduction
        '
        Me.DsProduction.DataSetName = "dsProduction"
        Me.DsProduction.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CXP_UsuariosBindingSource
        '
        Me.CXP_UsuariosBindingSource.DataMember = "CXP_Usuarios"
        Me.CXP_UsuariosBindingSource.DataSource = Me.DsProduction
        '
        'CXP_UsuariosTableAdapter
        '
        Me.CXP_UsuariosTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.CXP_ConceptosTableAdapter = Nothing
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
        Me.TableAdapterManager.CXP_UsuariosTableAdapter = Me.CXP_UsuariosTableAdapter
        Me.TableAdapterManager.CXP_XmlCfdi2TableAdapter = Nothing
        Me.TableAdapterManager.CXP_XmlCfdiTableAdapter = Nothing
        Me.TableAdapterManager.SucursalesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = cuentasPorPagar.dsProductionTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CXP_UsuariosBindingNavigator
        '
        Me.CXP_UsuariosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CXP_UsuariosBindingNavigator.BindingSource = Me.CXP_UsuariosBindingSource
        Me.CXP_UsuariosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CXP_UsuariosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CXP_UsuariosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CXP_UsuariosBindingNavigatorSaveItem})
        Me.CXP_UsuariosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CXP_UsuariosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CXP_UsuariosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CXP_UsuariosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CXP_UsuariosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CXP_UsuariosBindingNavigator.Name = "CXP_UsuariosBindingNavigator"
        Me.CXP_UsuariosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CXP_UsuariosBindingNavigator.Size = New System.Drawing.Size(1179, 25)
        Me.CXP_UsuariosBindingNavigator.TabIndex = 0
        Me.CXP_UsuariosBindingNavigator.Text = "BindingNavigator1"
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
        'CXP_UsuariosBindingNavigatorSaveItem
        '
        Me.CXP_UsuariosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CXP_UsuariosBindingNavigatorSaveItem.Image = CType(resources.GetObject("CXP_UsuariosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CXP_UsuariosBindingNavigatorSaveItem.Name = "CXP_UsuariosBindingNavigatorSaveItem"
        Me.CXP_UsuariosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CXP_UsuariosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_UsuariosBindingSource, "nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(93, 19)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.ReadOnly = True
        Me.NombreTextBox.Size = New System.Drawing.Size(384, 20)
        Me.NombreTextBox.TabIndex = 2
        '
        'cmbUsuarioActual
        '
        Me.cmbUsuarioActual.DataSource = Me.USUARIOBindingSource
        Me.cmbUsuarioActual.DisplayMember = "nombrecompleto"
        Me.cmbUsuarioActual.Enabled = False
        Me.cmbUsuarioActual.FormattingEnabled = True
        Me.cmbUsuarioActual.Location = New System.Drawing.Point(112, 46)
        Me.cmbUsuarioActual.Name = "cmbUsuarioActual"
        Me.cmbUsuarioActual.Size = New System.Drawing.Size(304, 21)
        Me.cmbUsuarioActual.TabIndex = 3
        Me.cmbUsuarioActual.ValueMember = "cve_empleado"
        '
        'USUARIOBindingSource
        '
        Me.USUARIOBindingSource.DataMember = "USUARIO"
        Me.USUARIOBindingSource.DataSource = Me.DsSeguridad
        '
        'DsSeguridad
        '
        Me.DsSeguridad.DataSetName = "dsSeguridad"
        Me.DsSeguridad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'USUARIOTableAdapter
        '
        Me.USUARIOTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Usuarios actuales:"
        '
        'UsuarioTextBox
        '
        Me.UsuarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_UsuariosBindingSource, "usuario", True))
        Me.UsuarioTextBox.Location = New System.Drawing.Point(93, 45)
        Me.UsuarioTextBox.Name = "UsuarioTextBox"
        Me.UsuarioTextBox.ReadOnly = True
        Me.UsuarioTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UsuarioTextBox.TabIndex = 6
        '
        'MailTextBox
        '
        Me.MailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_UsuariosBindingSource, "mail", True))
        Me.MailTextBox.Location = New System.Drawing.Point(93, 71)
        Me.MailTextBox.Name = "MailTextBox"
        Me.MailTextBox.Size = New System.Drawing.Size(384, 20)
        Me.MailTextBox.TabIndex = 8
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(1078, 245)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 15
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'cmbEmpresas
        '
        Me.cmbEmpresas.DataSource = Me.CXPEmpresasBindingSource
        Me.cmbEmpresas.DisplayMember = "razonSocial"
        Me.cmbEmpresas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEmpresas.FormattingEnabled = True
        Me.cmbEmpresas.Location = New System.Drawing.Point(101, 22)
        Me.cmbEmpresas.Name = "cmbEmpresas"
        Me.cmbEmpresas.Size = New System.Drawing.Size(236, 21)
        Me.cmbEmpresas.TabIndex = 17
        Me.cmbEmpresas.ValueMember = "idEmpresas"
        '
        'CXPEmpresasBindingSource
        '
        Me.CXPEmpresasBindingSource.DataMember = "CXP_Empresas"
        Me.CXPEmpresasBindingSource.DataSource = Me.DsProduction
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Empresas:"
        '
        'CXP_EmpresasTableAdapter
        '
        Me.CXP_EmpresasTableAdapter.ClearBeforeFill = True
        '
        'dgvEmpresas
        '
        Me.dgvEmpresas.AllowUserToAddRows = False
        Me.dgvEmpresas.AllowUserToDeleteRows = False
        Me.dgvEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmpresas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idEmpresa, Me.empresa, Me.eliminar})
        Me.dgvEmpresas.Location = New System.Drawing.Point(6, 49)
        Me.dgvEmpresas.Name = "dgvEmpresas"
        Me.dgvEmpresas.ReadOnly = True
        Me.dgvEmpresas.Size = New System.Drawing.Size(480, 113)
        Me.dgvEmpresas.TabIndex = 19
        '
        'idEmpresa
        '
        Me.idEmpresa.HeaderText = ""
        Me.idEmpresa.Name = "idEmpresa"
        Me.idEmpresa.ReadOnly = True
        '
        'empresa
        '
        Me.empresa.HeaderText = ""
        Me.empresa.Name = "empresa"
        Me.empresa.ReadOnly = True
        Me.empresa.Width = 250
        '
        'eliminar
        '
        Me.eliminar.HeaderText = ""
        Me.eliminar.Name = "eliminar"
        Me.eliminar.ReadOnly = True
        Me.eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.eliminar.Width = 50
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(343, 21)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 20
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'cmbAccesoWeb
        '
        Me.cmbAccesoWeb.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_UsuariosBindingSource, "perfil", True))
        Me.cmbAccesoWeb.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.CXP_UsuariosBindingSource, "perfil", True))
        Me.cmbAccesoWeb.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CXP_UsuariosBindingSource, "perfil", True))
        Me.cmbAccesoWeb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAccesoWeb.FormattingEnabled = True
        Me.cmbAccesoWeb.Items.AddRange(New Object() {"Si", "No"})
        Me.cmbAccesoWeb.Location = New System.Drawing.Point(173, 19)
        Me.cmbAccesoWeb.Name = "cmbAccesoWeb"
        Me.cmbAccesoWeb.Size = New System.Drawing.Size(121, 21)
        Me.cmbAccesoWeb.TabIndex = 21
        '
        'CXPPerfilesBindingSource
        '
        Me.CXPPerfilesBindingSource.DataMember = "CXP_Perfiles"
        Me.CXPPerfilesBindingSource.DataSource = Me.DsProduction2
        '
        'DsProduction2
        '
        Me.DsProduction2.DataSetName = "dsProduction"
        Me.DsProduction2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CXPPerfilesUsuarioBindingSource
        '
        Me.CXPPerfilesUsuarioBindingSource.DataMember = "CXP_PerfilesUsuario"
        Me.CXPPerfilesUsuarioBindingSource.DataSource = Me.DsProduction
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(86, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "¿Acceso Web?"
        '
        'CXP_PerfilesUsuarioTableAdapter
        '
        Me.CXP_PerfilesUsuarioTableAdapter.ClearBeforeFill = True
        '
        'DsProduction1
        '
        Me.DsProduction1.DataSetName = "dsProduction"
        Me.DsProduction1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CXP_PerfilesTableAdapter
        '
        Me.CXP_PerfilesTableAdapter.ClearBeforeFill = True
        '
        'btnAgregarUsuario
        '
        Me.btnAgregarUsuario.Enabled = False
        Me.btnAgregarUsuario.Location = New System.Drawing.Point(422, 46)
        Me.btnAgregarUsuario.Name = "btnAgregarUsuario"
        Me.btnAgregarUsuario.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregarUsuario.TabIndex = 25
        Me.btnAgregarUsuario.Text = "Agregar"
        Me.btnAgregarUsuario.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(997, 245)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 26
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'dgvTipoConceptos
        '
        Me.dgvTipoConceptos.AllowUserToAddRows = False
        Me.dgvTipoConceptos.AllowUserToDeleteRows = False
        Me.dgvTipoConceptos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTipoConceptos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.descripcion, Me.eliminar2})
        Me.dgvTipoConceptos.Location = New System.Drawing.Point(6, 73)
        Me.dgvTipoConceptos.Name = "dgvTipoConceptos"
        Me.dgvTipoConceptos.ReadOnly = True
        Me.dgvTipoConceptos.Size = New System.Drawing.Size(629, 120)
        Me.dgvTipoConceptos.TabIndex = 27
        '
        'id
        '
        Me.id.HeaderText = ""
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        '
        'descripcion
        '
        Me.descripcion.HeaderText = ""
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        Me.descripcion.Width = 400
        '
        'eliminar2
        '
        Me.eliminar2.HeaderText = ""
        Me.eliminar2.Name = "eliminar2"
        Me.eliminar2.ReadOnly = True
        Me.eliminar2.Width = 50
        '
        'cmbTipoConcepto
        '
        Me.cmbTipoConcepto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbTipoConcepto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTipoConcepto.DataSource = Me.CXPConceptosBindingSource
        Me.cmbTipoConcepto.DisplayMember = "nombre"
        Me.cmbTipoConcepto.FormattingEnabled = True
        Me.cmbTipoConcepto.Location = New System.Drawing.Point(173, 46)
        Me.cmbTipoConcepto.Name = "cmbTipoConcepto"
        Me.cmbTipoConcepto.Size = New System.Drawing.Size(381, 21)
        Me.cmbTipoConcepto.TabIndex = 28
        Me.cmbTipoConcepto.ValueMember = "idConcepto"
        '
        'CXPConceptosBindingSource
        '
        Me.CXPConceptosBindingSource.DataMember = "CXP_Conceptos"
        Me.CXPConceptosBindingSource.DataSource = Me.DsProduction
        '
        'CXPtipoConceptoBindingSource
        '
        Me.CXPtipoConceptoBindingSource.DataMember = "CXP_tipoConcepto"
        Me.CXPtipoConceptoBindingSource.DataSource = Me.DsProduction
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.ActivoCheckBox)
        Me.GroupBox1.Controls.Add(Me.PwTextBox)
        Me.GroupBox1.Controls.Add(RfcLabel)
        Me.GroupBox1.Controls.Add(Me.NombreTextBox)
        Me.GroupBox1.Controls.Add(Me.RfcTextBox)
        Me.GroupBox1.Controls.Add(NombreLabel)
        Me.GroupBox1.Controls.Add(Me.UsuarioTextBox)
        Me.GroupBox1.Controls.Add(UsuarioLabel)
        Me.GroupBox1.Controls.Add(Me.MailTextBox)
        Me.GroupBox1.Controls.Add(MailLabel)
        Me.GroupBox1.Controls.Add(DepartamentoLabel)
        Me.GroupBox1.Controls.Add(SucursalLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(497, 163)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Usuario:"
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CXP_UsuariosBindingSource, "departamento", True))
        Me.ComboBox2.DataSource = Me.CXPDepartamentosBindingSource
        Me.ComboBox2.DisplayMember = "departamento"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(93, 97)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 35
        Me.ComboBox2.ValueMember = "departamento"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CXP_UsuariosBindingSource, "sucursal", True))
        Me.ComboBox1.DataSource = Me.CXPSucursalesBindingSource
        Me.ComboBox1.DisplayMember = "nombreSucursal"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(310, 96)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(167, 21)
        Me.ComboBox1.TabIndex = 34
        Me.ComboBox1.ValueMember = "id_Sucursal"
        '
        'CXPSucursalesBindingSource
        '
        Me.CXPSucursalesBindingSource.DataMember = "CXP_Sucursales"
        Me.CXPSucursalesBindingSource.DataSource = Me.DsProduction
        '
        'ActivoCheckBox
        '
        Me.ActivoCheckBox.Checked = True
        Me.ActivoCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ActivoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CXP_UsuariosBindingSource, "activo", True))
        Me.ActivoCheckBox.Location = New System.Drawing.Point(199, 43)
        Me.ActivoCheckBox.Name = "ActivoCheckBox"
        Me.ActivoCheckBox.Size = New System.Drawing.Size(70, 24)
        Me.ActivoCheckBox.TabIndex = 34
        Me.ActivoCheckBox.Text = "Activo:"
        Me.ActivoCheckBox.UseVisualStyleBackColor = True
        '
        'PwTextBox
        '
        Me.PwTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_UsuariosBindingSource, "pw", True))
        Me.PwTextBox.Location = New System.Drawing.Point(93, 123)
        Me.PwTextBox.Name = "PwTextBox"
        Me.PwTextBox.ReadOnly = True
        Me.PwTextBox.Size = New System.Drawing.Size(384, 20)
        Me.PwTextBox.TabIndex = 33
        '
        'RfcTextBox
        '
        Me.RfcTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_UsuariosBindingSource, "rfc", True))
        Me.RfcTextBox.Location = New System.Drawing.Point(325, 45)
        Me.RfcTextBox.Name = "RfcTextBox"
        Me.RfcTextBox.ReadOnly = True
        Me.RfcTextBox.Size = New System.Drawing.Size(152, 20)
        Me.RfcTextBox.TabIndex = 32
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvEmpresas)
        Me.GroupBox2.Controls.Add(Me.cmbEmpresas)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.btnAgregar)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 250)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(492, 168)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Permisos por Empresa:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnAgregarConcepto)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.cmbAccesoWeb)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.cmbTipoConcepto)
        Me.GroupBox3.Controls.Add(Me.dgvTipoConceptos)
        Me.GroupBox3.Location = New System.Drawing.Point(518, 37)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(641, 202)
        Me.GroupBox3.TabIndex = 31
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Permisos Web:"
        '
        'btnAgregarConcepto
        '
        Me.btnAgregarConcepto.Location = New System.Drawing.Point(560, 45)
        Me.btnAgregarConcepto.Name = "btnAgregarConcepto"
        Me.btnAgregarConcepto.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregarConcepto.TabIndex = 21
        Me.btnAgregarConcepto.Text = "Agregar"
        Me.btnAgregarConcepto.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Tipo de Solicitud por Concepto:"
        '
        'CXP_tipoConceptoTableAdapter
        '
        Me.CXP_tipoConceptoTableAdapter.ClearBeforeFill = True
        '
        'CXP_ConceptosTableAdapter
        '
        Me.CXP_ConceptosTableAdapter.ClearBeforeFill = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(737, 389)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 32
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(524, 391)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(207, 20)
        Me.txtBuscar.TabIndex = 33
        '
        'CXP_SucursalesTableAdapter
        '
        Me.CXP_SucursalesTableAdapter.ClearBeforeFill = True
        '
        'CXPDepartamentosBindingSource
        '
        Me.CXPDepartamentosBindingSource.DataMember = "CXP_Departamentos"
        Me.CXPDepartamentosBindingSource.DataSource = Me.DsProduction
        '
        'CXP_DepartamentosTableAdapter
        '
        Me.CXP_DepartamentosTableAdapter.ClearBeforeFill = True
        '
        'frmUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1179, 439)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAgregarUsuario)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbUsuarioActual)
        Me.Controls.Add(Me.CXP_UsuariosBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmUsuario"
        Me.Text = "Usuarios"
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXP_UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXP_UsuariosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CXP_UsuariosBindingNavigator.ResumeLayout(False)
        Me.CXP_UsuariosBindingNavigator.PerformLayout()
        CType(Me.USUARIOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSeguridad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPEmpresasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvEmpresas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPPerfilesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProduction2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPPerfilesUsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProduction1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTipoConceptos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPConceptosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPtipoConceptoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.CXPSucursalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.CXPDepartamentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DsProduction As dsProduction
    Friend WithEvents CXP_UsuariosBindingSource As BindingSource
    Friend WithEvents CXP_UsuariosTableAdapter As dsProductionTableAdapters.CXP_UsuariosTableAdapter
    Friend WithEvents TableAdapterManager As dsProductionTableAdapters.TableAdapterManager
    Friend WithEvents CXP_UsuariosBindingNavigator As BindingNavigator
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
    Friend WithEvents CXP_UsuariosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents cmbUsuarioActual As ComboBox
    Friend WithEvents DsSeguridad As dsSeguridad
    Friend WithEvents USUARIOBindingSource As BindingSource
    Friend WithEvents USUARIOTableAdapter As dsSeguridadTableAdapters.USUARIOTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents UsuarioTextBox As TextBox
    Friend WithEvents MailTextBox As TextBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents cmbEmpresas As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CXPEmpresasBindingSource As BindingSource
    Friend WithEvents CXP_EmpresasTableAdapter As dsProductionTableAdapters.CXP_EmpresasTableAdapter
    Friend WithEvents dgvEmpresas As DataGridView
    Friend WithEvents btnAgregar As Button
    Friend WithEvents idEmpresa As DataGridViewTextBoxColumn
    Friend WithEvents empresa As DataGridViewTextBoxColumn
    Friend WithEvents eliminar As DataGridViewLinkColumn
    Friend WithEvents cmbAccesoWeb As ComboBox
    Friend WithEvents CXPPerfilesUsuarioBindingSource As BindingSource
    Friend WithEvents Label3 As Label
    Friend WithEvents CXP_PerfilesUsuarioTableAdapter As dsProductionTableAdapters.CXP_PerfilesUsuarioTableAdapter
    Friend WithEvents DsProduction1 As dsProduction
    Friend WithEvents DsProduction2 As dsProduction
    Friend WithEvents CXPPerfilesBindingSource As BindingSource
    Friend WithEvents CXP_PerfilesTableAdapter As dsProductionTableAdapters.CXP_PerfilesTableAdapter
    Friend WithEvents btnAgregarUsuario As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents dgvTipoConceptos As DataGridView
    Friend WithEvents cmbTipoConcepto As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnAgregarConcepto As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents CXPtipoConceptoBindingSource As BindingSource
    Friend WithEvents CXP_tipoConceptoTableAdapter As dsProductionTableAdapters.CXP_tipoConceptoTableAdapter
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents eliminar2 As DataGridViewLinkColumn
    Friend WithEvents RfcTextBox As TextBox
    Friend WithEvents PwTextBox As TextBox
    Friend WithEvents ActivoCheckBox As CheckBox
    Friend WithEvents CXPConceptosBindingSource As BindingSource
    Friend WithEvents CXP_ConceptosTableAdapter As dsProductionTableAdapters.CXP_ConceptosTableAdapter
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents CXPSucursalesBindingSource As BindingSource
    Friend WithEvents CXP_SucursalesTableAdapter As dsProductionTableAdapters.CXP_SucursalesTableAdapter
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents CXPDepartamentosBindingSource As BindingSource
    Friend WithEvents CXP_DepartamentosTableAdapter As dsProductionTableAdapters.CXP_DepartamentosTableAdapter
End Class
