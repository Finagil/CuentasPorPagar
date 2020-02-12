<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCodigoAgrupador
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
        Dim NivelLabel As System.Windows.Forms.Label
        Dim CodigoAgrupadorLabel As System.Windows.Forms.Label
        Dim NombreCuentaSubcuentaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCodigoAgrupador))
        Me.DsProduction = New cuentasPorPagar.dsProduction()
        Me.CXP_CodigoAgrupadorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CXP_CodigoAgrupadorTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_CodigoAgrupadorTableAdapter()
        Me.TableAdapterManager = New cuentasPorPagar.dsProductionTableAdapters.TableAdapterManager()
        Me.CXP_CodigoAgrupadorBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.CXP_CodigoAgrupadorBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NombreCuentaSubcuentaTextBox = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.cmbNivel = New System.Windows.Forms.ComboBox()
        Me.mtbCodigoAgrupador = New System.Windows.Forms.MaskedTextBox()
        NivelLabel = New System.Windows.Forms.Label()
        CodigoAgrupadorLabel = New System.Windows.Forms.Label()
        NombreCuentaSubcuentaLabel = New System.Windows.Forms.Label()
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXP_CodigoAgrupadorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXP_CodigoAgrupadorBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CXP_CodigoAgrupadorBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'NivelLabel
        '
        NivelLabel.AutoSize = True
        NivelLabel.Location = New System.Drawing.Point(115, 31)
        NivelLabel.Name = "NivelLabel"
        NivelLabel.Size = New System.Drawing.Size(34, 13)
        NivelLabel.TabIndex = 1
        NivelLabel.Text = "Nivel:"
        '
        'CodigoAgrupadorLabel
        '
        CodigoAgrupadorLabel.AutoSize = True
        CodigoAgrupadorLabel.Location = New System.Drawing.Point(268, 31)
        CodigoAgrupadorLabel.Name = "CodigoAgrupadorLabel"
        CodigoAgrupadorLabel.Size = New System.Drawing.Size(95, 13)
        CodigoAgrupadorLabel.TabIndex = 3
        CodigoAgrupadorLabel.Text = "Código Agrupador:"
        '
        'NombreCuentaSubcuentaLabel
        '
        NombreCuentaSubcuentaLabel.AutoSize = True
        NombreCuentaSubcuentaLabel.Location = New System.Drawing.Point(2, 57)
        NombreCuentaSubcuentaLabel.Name = "NombreCuentaSubcuentaLabel"
        NombreCuentaSubcuentaLabel.Size = New System.Drawing.Size(147, 13)
        NombreCuentaSubcuentaLabel.TabIndex = 5
        NombreCuentaSubcuentaLabel.Text = "Nombre Cuenta / Subcuenta:"
        '
        'DsProduction
        '
        Me.DsProduction.DataSetName = "dsProduction"
        Me.DsProduction.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CXP_CodigoAgrupadorBindingSource
        '
        Me.CXP_CodigoAgrupadorBindingSource.DataMember = "CXP_CodigoAgrupador"
        Me.CXP_CodigoAgrupadorBindingSource.DataSource = Me.DsProduction
        '
        'CXP_CodigoAgrupadorTableAdapter
        '
        Me.CXP_CodigoAgrupadorTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CXP_BancosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_c_CodigoPostalTableAdapter = Nothing
        Me.TableAdapterManager.CXP_c_EstadoTableAdapter = Nothing
        Me.TableAdapterManager.CXP_c_MonedaTableAdapter = Nothing
        Me.TableAdapterManager.CXP_c_PaisTableAdapter = Nothing
        Me.TableAdapterManager.CXP_c_RegimenFiscalTableAdapter = Nothing
        Me.TableAdapterManager.CXP_CodigoAgrupadorTableAdapter = Me.CXP_CodigoAgrupadorTableAdapter
        Me.TableAdapterManager.CXP_CuentasContablesTableAdapter = Nothing
        Me.TableAdapterManager.CXP_EmpresasTableAdapter = Nothing
        Me.TableAdapterManager.CXP_ImpuestoTableAdapter = Nothing
        Me.TableAdapterManager.CXP_SucursalesTableAdapter = Nothing
        Me.TableAdapterManager.CXP_tipoDeDocumentoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = cuentasPorPagar.dsProductionTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CXP_CodigoAgrupadorBindingNavigator
        '
        Me.CXP_CodigoAgrupadorBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CXP_CodigoAgrupadorBindingNavigator.BindingSource = Me.CXP_CodigoAgrupadorBindingSource
        Me.CXP_CodigoAgrupadorBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CXP_CodigoAgrupadorBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CXP_CodigoAgrupadorBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CXP_CodigoAgrupadorBindingNavigatorSaveItem})
        Me.CXP_CodigoAgrupadorBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CXP_CodigoAgrupadorBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CXP_CodigoAgrupadorBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CXP_CodigoAgrupadorBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CXP_CodigoAgrupadorBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CXP_CodigoAgrupadorBindingNavigator.Name = "CXP_CodigoAgrupadorBindingNavigator"
        Me.CXP_CodigoAgrupadorBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CXP_CodigoAgrupadorBindingNavigator.Size = New System.Drawing.Size(476, 25)
        Me.CXP_CodigoAgrupadorBindingNavigator.TabIndex = 0
        Me.CXP_CodigoAgrupadorBindingNavigator.Text = "BindingNavigator1"
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
        'CXP_CodigoAgrupadorBindingNavigatorSaveItem
        '
        Me.CXP_CodigoAgrupadorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CXP_CodigoAgrupadorBindingNavigatorSaveItem.Image = CType(resources.GetObject("CXP_CodigoAgrupadorBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CXP_CodigoAgrupadorBindingNavigatorSaveItem.Name = "CXP_CodigoAgrupadorBindingNavigatorSaveItem"
        Me.CXP_CodigoAgrupadorBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CXP_CodigoAgrupadorBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'NombreCuentaSubcuentaTextBox
        '
        Me.NombreCuentaSubcuentaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_CodigoAgrupadorBindingSource, "nombreCuentaSubcuenta", True))
        Me.NombreCuentaSubcuentaTextBox.Location = New System.Drawing.Point(153, 54)
        Me.NombreCuentaSubcuentaTextBox.Name = "NombreCuentaSubcuentaTextBox"
        Me.NombreCuentaSubcuentaTextBox.Size = New System.Drawing.Size(315, 20)
        Me.NombreCuentaSubcuentaTextBox.TabIndex = 6
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(393, 80)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 7
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'cmbNivel
        '
        Me.cmbNivel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_CodigoAgrupadorBindingSource, "nivel", True))
        Me.cmbNivel.FormattingEnabled = True
        Me.cmbNivel.Items.AddRange(New Object() {"1", "2"})
        Me.cmbNivel.Location = New System.Drawing.Point(153, 28)
        Me.cmbNivel.Name = "cmbNivel"
        Me.cmbNivel.Size = New System.Drawing.Size(109, 21)
        Me.cmbNivel.TabIndex = 8
        '
        'mtbCodigoAgrupador
        '
        Me.mtbCodigoAgrupador.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_CodigoAgrupadorBindingSource, "codigoAgrupador", True))
        Me.mtbCodigoAgrupador.Location = New System.Drawing.Point(369, 28)
        Me.mtbCodigoAgrupador.Mask = "000.00"
        Me.mtbCodigoAgrupador.Name = "mtbCodigoAgrupador"
        Me.mtbCodigoAgrupador.Size = New System.Drawing.Size(100, 20)
        Me.mtbCodigoAgrupador.TabIndex = 9
        '
        'frmCodigoAgrupador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 116)
        Me.Controls.Add(Me.mtbCodigoAgrupador)
        Me.Controls.Add(Me.cmbNivel)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(NombreCuentaSubcuentaLabel)
        Me.Controls.Add(Me.NombreCuentaSubcuentaTextBox)
        Me.Controls.Add(CodigoAgrupadorLabel)
        Me.Controls.Add(NivelLabel)
        Me.Controls.Add(Me.CXP_CodigoAgrupadorBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmCodigoAgrupador"
        Me.Text = "Código Agrupador"
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXP_CodigoAgrupadorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXP_CodigoAgrupadorBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CXP_CodigoAgrupadorBindingNavigator.ResumeLayout(False)
        Me.CXP_CodigoAgrupadorBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DsProduction As dsProduction
    Friend WithEvents CXP_CodigoAgrupadorBindingSource As BindingSource
    Friend WithEvents CXP_CodigoAgrupadorTableAdapter As dsProductionTableAdapters.CXP_CodigoAgrupadorTableAdapter
    Friend WithEvents TableAdapterManager As dsProductionTableAdapters.TableAdapterManager
    Friend WithEvents CXP_CodigoAgrupadorBindingNavigator As BindingNavigator
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
    Friend WithEvents CXP_CodigoAgrupadorBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents NombreCuentaSubcuentaTextBox As TextBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents cmbNivel As ComboBox
    Friend WithEvents mtbCodigoAgrupador As MaskedTextBox
End Class
