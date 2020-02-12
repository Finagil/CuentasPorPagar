<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAutorizaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAutorizaciones))
        Dim MailLabel As System.Windows.Forms.Label
        Me.DsProduction = New cuentasPorPagar.dsProduction()
        Me.CXP_AutorizacionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CXP_AutorizacionesTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_AutorizacionesTableAdapter()
        Me.TableAdapterManager = New cuentasPorPagar.dsProductionTableAdapters.TableAdapterManager()
        Me.CXP_SucursalesTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_SucursalesTableAdapter()
        Me.CXP_AutorizacionesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.CXP_AutorizacionesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.cmbSucursal = New System.Windows.Forms.ComboBox()
        Me.CXPSucursalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbDepartamento = New System.Windows.Forms.ComboBox()
        Me.USUARIO1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsSeguridad1 = New cuentasPorPagar.dsSeguridad()
        Me.txtEncargadoJefe = New System.Windows.Forms.TextBox()
        Me.DsSeguridad = New cuentasPorPagar.dsSeguridad()
        Me.USUARIOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.USUARIOTableAdapter = New cuentasPorPagar.dsSeguridadTableAdapters.USUARIOTableAdapter()
        Me.USUARIO1TableAdapter = New cuentasPorPagar.dsSeguridadTableAdapters.USUARIO1TableAdapter()
        Me.txtDepartamento = New System.Windows.Forms.TextBox()
        Me.txtSucursal = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MailTextBox = New System.Windows.Forms.TextBox()
        MailLabel = New System.Windows.Forms.Label()
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXP_AutorizacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXP_AutorizacionesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CXP_AutorizacionesBindingNavigator.SuspendLayout()
        CType(Me.CXPSucursalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USUARIO1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSeguridad1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSeguridad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USUARIOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DsProduction
        '
        Me.DsProduction.DataSetName = "dsProduction"
        Me.DsProduction.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CXP_AutorizacionesBindingSource
        '
        Me.CXP_AutorizacionesBindingSource.DataMember = "CXP_Autorizaciones"
        Me.CXP_AutorizacionesBindingSource.DataSource = Me.DsProduction
        '
        'CXP_AutorizacionesTableAdapter
        '
        Me.CXP_AutorizacionesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CXP_AutorizacionesTableAdapter = Me.CXP_AutorizacionesTableAdapter
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
        Me.TableAdapterManager.CXP_DiariosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_EmpresasTableAdapter = Nothing
        Me.TableAdapterManager.CXP_ImpuestoTableAdapter = Nothing
        Me.TableAdapterManager.CXP_PerfilesTableAdapter = Nothing
        Me.TableAdapterManager.CXP_PerfilesUsuarioTableAdapter = Nothing
        Me.TableAdapterManager.CXP_ProveedoresTableAdapter = Nothing
        Me.TableAdapterManager.CXP_SucursalesTableAdapter = Me.CXP_SucursalesTableAdapter
        Me.TableAdapterManager.CXP_tipoDeDocumentoTableAdapter = Nothing
        Me.TableAdapterManager.CXP_tipoDocumentoSatTableAdapter = Nothing
        Me.TableAdapterManager.CXP_TipoGastoTableAdapter = Nothing
        Me.TableAdapterManager.CXP_UsuariosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_XmlCfdiTableAdapter = Nothing
        Me.TableAdapterManager.SucursalesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = cuentasPorPagar.dsProductionTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CXP_SucursalesTableAdapter
        '
        Me.CXP_SucursalesTableAdapter.ClearBeforeFill = True
        '
        'CXP_AutorizacionesBindingNavigator
        '
        Me.CXP_AutorizacionesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CXP_AutorizacionesBindingNavigator.BindingSource = Me.CXP_AutorizacionesBindingSource
        Me.CXP_AutorizacionesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CXP_AutorizacionesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CXP_AutorizacionesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CXP_AutorizacionesBindingNavigatorSaveItem})
        Me.CXP_AutorizacionesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CXP_AutorizacionesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CXP_AutorizacionesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CXP_AutorizacionesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CXP_AutorizacionesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CXP_AutorizacionesBindingNavigator.Name = "CXP_AutorizacionesBindingNavigator"
        Me.CXP_AutorizacionesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CXP_AutorizacionesBindingNavigator.Size = New System.Drawing.Size(483, 25)
        Me.CXP_AutorizacionesBindingNavigator.TabIndex = 0
        Me.CXP_AutorizacionesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
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
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'CXP_AutorizacionesBindingNavigatorSaveItem
        '
        Me.CXP_AutorizacionesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CXP_AutorizacionesBindingNavigatorSaveItem.Image = CType(resources.GetObject("CXP_AutorizacionesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CXP_AutorizacionesBindingNavigatorSaveItem.Name = "CXP_AutorizacionesBindingNavigatorSaveItem"
        Me.CXP_AutorizacionesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CXP_AutorizacionesBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'cmbSucursal
        '
        Me.cmbSucursal.DataSource = Me.CXPSucursalesBindingSource
        Me.cmbSucursal.DisplayMember = "nombreSucursal"
        Me.cmbSucursal.FormattingEnabled = True
        Me.cmbSucursal.Location = New System.Drawing.Point(96, 38)
        Me.cmbSucursal.Name = "cmbSucursal"
        Me.cmbSucursal.Size = New System.Drawing.Size(294, 21)
        Me.cmbSucursal.TabIndex = 0
        Me.cmbSucursal.ValueMember = "idSucursal"
        '
        'CXPSucursalesBindingSource
        '
        Me.CXPSucursalesBindingSource.DataMember = "CXP_Sucursales"
        Me.CXPSucursalesBindingSource.DataSource = Me.DsProduction
        '
        'cmbDepartamento
        '
        Me.cmbDepartamento.DataSource = Me.USUARIO1BindingSource
        Me.cmbDepartamento.DisplayMember = "id_depto"
        Me.cmbDepartamento.FormattingEnabled = True
        Me.cmbDepartamento.Location = New System.Drawing.Point(96, 64)
        Me.cmbDepartamento.Name = "cmbDepartamento"
        Me.cmbDepartamento.Size = New System.Drawing.Size(182, 21)
        Me.cmbDepartamento.TabIndex = 2
        Me.cmbDepartamento.ValueMember = "id_depto"
        '
        'USUARIO1BindingSource
        '
        Me.USUARIO1BindingSource.DataMember = "USUARIO1"
        Me.USUARIO1BindingSource.DataSource = Me.DsSeguridad1
        '
        'DsSeguridad1
        '
        Me.DsSeguridad1.DataSetName = "dsSeguridad"
        Me.DsSeguridad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtEncargadoJefe
        '
        Me.txtEncargadoJefe.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_AutorizacionesBindingSource, "encargadoJefe", True))
        Me.txtEncargadoJefe.Location = New System.Drawing.Point(96, 91)
        Me.txtEncargadoJefe.Name = "txtEncargadoJefe"
        Me.txtEncargadoJefe.Size = New System.Drawing.Size(364, 20)
        Me.txtEncargadoJefe.TabIndex = 4
        '
        'DsSeguridad
        '
        Me.DsSeguridad.DataSetName = "dsSeguridad"
        Me.DsSeguridad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'USUARIOBindingSource
        '
        Me.USUARIOBindingSource.DataMember = "USUARIO"
        Me.USUARIOBindingSource.DataSource = Me.DsSeguridad
        Me.USUARIOBindingSource.Filter = ""
        '
        'USUARIOTableAdapter
        '
        Me.USUARIOTableAdapter.ClearBeforeFill = True
        '
        'USUARIO1TableAdapter
        '
        Me.USUARIO1TableAdapter.ClearBeforeFill = True
        '
        'txtDepartamento
        '
        Me.txtDepartamento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_AutorizacionesBindingSource, "departamento", True))
        Me.txtDepartamento.Location = New System.Drawing.Point(284, 65)
        Me.txtDepartamento.Name = "txtDepartamento"
        Me.txtDepartamento.ReadOnly = True
        Me.txtDepartamento.Size = New System.Drawing.Size(176, 20)
        Me.txtDepartamento.TabIndex = 3
        '
        'txtSucursal
        '
        Me.txtSucursal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_AutorizacionesBindingSource, "idSucursal", True))
        Me.txtSucursal.Location = New System.Drawing.Point(399, 39)
        Me.txtSucursal.Name = "txtSucursal"
        Me.txtSucursal.ReadOnly = True
        Me.txtSucursal.Size = New System.Drawing.Size(61, 20)
        Me.txtSucursal.TabIndex = 1
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(385, 146)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Sucursal:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Departamento:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Jefe/Enc:"
        '
        'MailLabel
        '
        MailLabel.AutoSize = True
        MailLabel.Location = New System.Drawing.Point(62, 120)
        MailLabel.Name = "MailLabel"
        MailLabel.Size = New System.Drawing.Size(29, 13)
        MailLabel.TabIndex = 10
        MailLabel.Text = "Mail:"
        '
        'MailTextBox
        '
        Me.MailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_AutorizacionesBindingSource, "mail", True))
        Me.MailTextBox.Location = New System.Drawing.Point(96, 117)
        Me.MailTextBox.Name = "MailTextBox"
        Me.MailTextBox.Size = New System.Drawing.Size(364, 20)
        Me.MailTextBox.TabIndex = 11
        '
        'frmAutorizaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 184)
        Me.Controls.Add(MailLabel)
        Me.Controls.Add(Me.MailTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.txtSucursal)
        Me.Controls.Add(Me.txtDepartamento)
        Me.Controls.Add(Me.txtEncargadoJefe)
        Me.Controls.Add(Me.cmbDepartamento)
        Me.Controls.Add(Me.cmbSucursal)
        Me.Controls.Add(Me.CXP_AutorizacionesBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmAutorizaciones"
        Me.Text = "Autorizaciones"
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXP_AutorizacionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXP_AutorizacionesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CXP_AutorizacionesBindingNavigator.ResumeLayout(False)
        Me.CXP_AutorizacionesBindingNavigator.PerformLayout()
        CType(Me.CXPSucursalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USUARIO1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSeguridad1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSeguridad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USUARIOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DsProduction As dsProduction
    Friend WithEvents CXP_AutorizacionesBindingSource As BindingSource
    Friend WithEvents CXP_AutorizacionesTableAdapter As dsProductionTableAdapters.CXP_AutorizacionesTableAdapter
    Friend WithEvents TableAdapterManager As dsProductionTableAdapters.TableAdapterManager
    Friend WithEvents CXP_AutorizacionesBindingNavigator As BindingNavigator
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
    Friend WithEvents CXP_AutorizacionesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CXP_SucursalesTableAdapter As dsProductionTableAdapters.CXP_SucursalesTableAdapter
    Friend WithEvents cmbSucursal As ComboBox
    Friend WithEvents cmbDepartamento As ComboBox
    Friend WithEvents txtEncargadoJefe As TextBox
    Friend WithEvents CXPSucursalesBindingSource As BindingSource
    Friend WithEvents DsSeguridad As dsSeguridad
    Friend WithEvents USUARIOBindingSource As BindingSource
    Friend WithEvents USUARIOTableAdapter As dsSeguridadTableAdapters.USUARIOTableAdapter
    Friend WithEvents DsSeguridad1 As dsSeguridad
    Friend WithEvents USUARIO1BindingSource As BindingSource
    Friend WithEvents USUARIO1TableAdapter As dsSeguridadTableAdapters.USUARIO1TableAdapter
    Friend WithEvents txtDepartamento As TextBox
    Friend WithEvents txtSucursal As TextBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents MailTextBox As TextBox
End Class
