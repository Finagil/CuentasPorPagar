<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSATImpuestos
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
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim EfectoLabel As System.Windows.Forms.Label
        Dim ImpuestoLabel As System.Windows.Forms.Label
        Dim CtaDeImpuestosLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim DescripcionLargaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSATImpuestos))
        Dim Label2 As System.Windows.Forms.Label
        Me.CXP_ImpuestoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.CXP_ImpuestoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.CXP_ImpuestoBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.cmbDescripcion = New System.Windows.Forms.ComboBox()
        Me.cmbEfecto = New System.Windows.Forms.ComboBox()
        Me.ImpuestoTextBox = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.CXP_ImpuestoTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_ImpuestoTableAdapter()
        Me.TableAdapterManager = New cuentasPorPagar.dsProductionTableAdapters.TableAdapterManager()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.CXPCuentasContablesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CXP_CuentasContablesTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_CuentasContablesTableAdapter()
        Me.cmbTipo = New System.Windows.Forms.ComboBox()
        Me.DescripcionLargaTextBox = New System.Windows.Forms.TextBox()
        Me.cmbFactor = New System.Windows.Forms.ComboBox()
        DescripcionLabel = New System.Windows.Forms.Label()
        EfectoLabel = New System.Windows.Forms.Label()
        ImpuestoLabel = New System.Windows.Forms.Label()
        CtaDeImpuestosLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        DescripcionLargaLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.CXP_ImpuestoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CXP_ImpuestoBindingNavigator.SuspendLayout()
        CType(Me.CXP_ImpuestoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPCuentasContablesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(37, 64)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(66, 13)
        DescripcionLabel.TabIndex = 3
        DescripcionLabel.Text = "Descripción:"
        '
        'EfectoLabel
        '
        EfectoLabel.AutoSize = True
        EfectoLabel.Location = New System.Drawing.Point(223, 36)
        EfectoLabel.Name = "EfectoLabel"
        EfectoLabel.Size = New System.Drawing.Size(41, 13)
        EfectoLabel.TabIndex = 5
        EfectoLabel.Text = "Efecto:"
        '
        'ImpuestoLabel
        '
        ImpuestoLabel.AutoSize = True
        ImpuestoLabel.Location = New System.Drawing.Point(261, 64)
        ImpuestoLabel.Name = "ImpuestoLabel"
        ImpuestoLabel.Size = New System.Drawing.Size(53, 13)
        ImpuestoLabel.TabIndex = 8
        ImpuestoLabel.Text = "Impuesto:"
        '
        'CtaDeImpuestosLabel
        '
        CtaDeImpuestosLabel.AutoSize = True
        CtaDeImpuestosLabel.Location = New System.Drawing.Point(11, 90)
        CtaDeImpuestosLabel.Name = "CtaDeImpuestosLabel"
        CtaDeImpuestosLabel.Size = New System.Drawing.Size(92, 13)
        CtaDeImpuestosLabel.TabIndex = 11
        CtaDeImpuestosLabel.Text = "Cta de Impuestos:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(71, 36)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(31, 13)
        Label1.TabIndex = 15
        Label1.Text = "Tipo:"
        '
        'DescripcionLargaLabel
        '
        DescripcionLargaLabel.AutoSize = True
        DescripcionLargaLabel.Location = New System.Drawing.Point(36, 117)
        DescripcionLargaLabel.Name = "DescripcionLargaLabel"
        DescripcionLargaLabel.Size = New System.Drawing.Size(66, 13)
        DescripcionLargaLabel.TabIndex = 15
        DescripcionLargaLabel.Text = "Descripción:"
        '
        'CXP_ImpuestoBindingNavigator
        '
        Me.CXP_ImpuestoBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CXP_ImpuestoBindingNavigator.BindingSource = Me.CXP_ImpuestoBindingSource
        Me.CXP_ImpuestoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CXP_ImpuestoBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CXP_ImpuestoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CXP_ImpuestoBindingNavigatorSaveItem})
        Me.CXP_ImpuestoBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CXP_ImpuestoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CXP_ImpuestoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CXP_ImpuestoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CXP_ImpuestoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CXP_ImpuestoBindingNavigator.Name = "CXP_ImpuestoBindingNavigator"
        Me.CXP_ImpuestoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CXP_ImpuestoBindingNavigator.Size = New System.Drawing.Size(500, 25)
        Me.CXP_ImpuestoBindingNavigator.TabIndex = 0
        Me.CXP_ImpuestoBindingNavigator.Text = "BindingNavigator1"
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
        'CXP_ImpuestoBindingSource
        '
        Me.CXP_ImpuestoBindingSource.DataMember = "CXP_Impuesto"
        Me.CXP_ImpuestoBindingSource.DataSource = Me.DsProduction
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
        'CXP_ImpuestoBindingNavigatorSaveItem
        '
        Me.CXP_ImpuestoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CXP_ImpuestoBindingNavigatorSaveItem.Image = CType(resources.GetObject("CXP_ImpuestoBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CXP_ImpuestoBindingNavigatorSaveItem.Name = "CXP_ImpuestoBindingNavigatorSaveItem"
        Me.CXP_ImpuestoBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CXP_ImpuestoBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'cmbDescripcion
        '
        Me.cmbDescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_ImpuestoBindingSource, "descripcion", True))
        Me.cmbDescripcion.FormattingEnabled = True
        Me.cmbDescripcion.Items.AddRange(New Object() {"ISR", "IVA", "IEPS"})
        Me.cmbDescripcion.Location = New System.Drawing.Point(109, 60)
        Me.cmbDescripcion.Name = "cmbDescripcion"
        Me.cmbDescripcion.Size = New System.Drawing.Size(146, 21)
        Me.cmbDescripcion.TabIndex = 7
        '
        'cmbEfecto
        '
        Me.cmbEfecto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_ImpuestoBindingSource, "efecto", True))
        Me.cmbEfecto.FormattingEnabled = True
        Me.cmbEfecto.Items.AddRange(New Object() {"RET", "TRA"})
        Me.cmbEfecto.Location = New System.Drawing.Point(269, 33)
        Me.cmbEfecto.Name = "cmbEfecto"
        Me.cmbEfecto.Size = New System.Drawing.Size(78, 21)
        Me.cmbEfecto.TabIndex = 8
        '
        'ImpuestoTextBox
        '
        Me.ImpuestoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_ImpuestoBindingSource, "impuesto", True))
        Me.ImpuestoTextBox.Location = New System.Drawing.Point(320, 61)
        Me.ImpuestoTextBox.Name = "ImpuestoTextBox"
        Me.ImpuestoTextBox.ReadOnly = True
        Me.ImpuestoTextBox.Size = New System.Drawing.Size(73, 20)
        Me.ImpuestoTextBox.TabIndex = 9
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(413, 140)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 10
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'CXP_ImpuestoTableAdapter
        '
        Me.CXP_ImpuestoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
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
        Me.TableAdapterManager.CXP_DiariosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_EmpresasTableAdapter = Nothing
        Me.TableAdapterManager.CXP_ImpConTableAdapter = Nothing
        Me.TableAdapterManager.CXP_ImpuestoTableAdapter = Me.CXP_ImpuestoTableAdapter
        Me.TableAdapterManager.CXP_PerfilesTableAdapter = Nothing
        Me.TableAdapterManager.CXP_PerfilesUsuarioTableAdapter = Nothing
        Me.TableAdapterManager.CXP_ProveedoresTableAdapter = Nothing
        Me.TableAdapterManager.CXP_SucursalesTableAdapter = Nothing
        Me.TableAdapterManager.CXP_tipoDeDocumentoTableAdapter = Nothing
        Me.TableAdapterManager.CXP_tipoDocumentoSatTableAdapter = Nothing
        Me.TableAdapterManager.CXP_TipoGastoTableAdapter = Nothing
        Me.TableAdapterManager.CXP_UsuariosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_XmlCfdiTableAdapter = Nothing
        Me.TableAdapterManager.SucursalesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = cuentasPorPagar.dsProductionTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CXP_ImpuestoBindingSource, "ctaDeImpuestos", True))
        Me.ComboBox1.DataSource = Me.CXPCuentasContablesBindingSource
        Me.ComboBox1.DisplayMember = "nombre"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(109, 87)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(379, 21)
        Me.ComboBox1.TabIndex = 13
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
        'cmbTipo
        '
        Me.cmbTipo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_ImpuestoBindingSource, "tipo", True))
        Me.cmbTipo.FormattingEnabled = True
        Me.cmbTipo.Items.AddRange(New Object() {"Federal", "Local"})
        Me.cmbTipo.Location = New System.Drawing.Point(109, 33)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(99, 21)
        Me.cmbTipo.TabIndex = 14
        '
        'DescripcionLargaTextBox
        '
        Me.DescripcionLargaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_ImpuestoBindingSource, "descripcionLarga", True))
        Me.DescripcionLargaTextBox.Location = New System.Drawing.Point(109, 114)
        Me.DescripcionLargaTextBox.Name = "DescripcionLargaTextBox"
        Me.DescripcionLargaTextBox.Size = New System.Drawing.Size(379, 20)
        Me.DescripcionLargaTextBox.TabIndex = 16
        '
        'cmbFactor
        '
        Me.cmbFactor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_ImpuestoBindingSource, "factor", True))
        Me.cmbFactor.FormattingEnabled = True
        Me.cmbFactor.Items.AddRange(New Object() {"Tasa", "Cuota", "Exento"})
        Me.cmbFactor.Location = New System.Drawing.Point(410, 33)
        Me.cmbFactor.Name = "cmbFactor"
        Me.cmbFactor.Size = New System.Drawing.Size(78, 21)
        Me.cmbFactor.TabIndex = 17
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(364, 36)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(40, 13)
        Label2.TabIndex = 18
        Label2.Text = "Factor:"
        '
        'frmSATImpuestos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 183)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.cmbFactor)
        Me.Controls.Add(DescripcionLargaLabel)
        Me.Controls.Add(Me.DescripcionLargaTextBox)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.cmbTipo)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(CtaDeImpuestosLabel)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(ImpuestoLabel)
        Me.Controls.Add(Me.ImpuestoTextBox)
        Me.Controls.Add(Me.cmbEfecto)
        Me.Controls.Add(Me.cmbDescripcion)
        Me.Controls.Add(EfectoLabel)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(Me.CXP_ImpuestoBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmSATImpuestos"
        Me.Text = "Impuestos"
        CType(Me.CXP_ImpuestoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CXP_ImpuestoBindingNavigator.ResumeLayout(False)
        Me.CXP_ImpuestoBindingNavigator.PerformLayout()
        CType(Me.CXP_ImpuestoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPCuentasContablesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DsProduction As dsProduction
    Friend WithEvents CXP_ImpuestoBindingSource As BindingSource
    Friend WithEvents CXP_ImpuestoTableAdapter As dsProductionTableAdapters.CXP_ImpuestoTableAdapter
    Friend WithEvents TableAdapterManager As dsProductionTableAdapters.TableAdapterManager
    Friend WithEvents CXP_ImpuestoBindingNavigator As BindingNavigator
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
    Friend WithEvents CXP_ImpuestoBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents cmbDescripcion As ComboBox
    Friend WithEvents cmbEfecto As ComboBox
    Friend WithEvents ImpuestoTextBox As TextBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents CXPCuentasContablesBindingSource As BindingSource
    Friend WithEvents CXP_CuentasContablesTableAdapter As dsProductionTableAdapters.CXP_CuentasContablesTableAdapter
    Friend WithEvents cmbTipo As ComboBox
    Friend WithEvents DescripcionLargaTextBox As TextBox
    Friend WithEvents cmbFactor As ComboBox
End Class
