<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSATMonedas
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
        Dim C_MonedaLabel As System.Windows.Forms.Label
        Dim C_NombreMonedaLabel As System.Windows.Forms.Label
        Dim C_DecimalesLabel As System.Windows.Forms.Label
        Dim C_SimboloLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSATMonedas))
        Me.DsProduction = New cuentasPorPagar.dsProduction()
        Me.CXP_c_MonedaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CXP_c_MonedaTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_c_MonedaTableAdapter()
        Me.TableAdapterManager = New cuentasPorPagar.dsProductionTableAdapters.TableAdapterManager()
        Me.CXP_c_MonedaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.CXP_c_MonedaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.C_MonedaTextBox = New System.Windows.Forms.TextBox()
        Me.C_NombreMonedaTextBox = New System.Windows.Forms.TextBox()
        Me.C_DecimalesTextBox = New System.Windows.Forms.TextBox()
        Me.C_SimboloTextBox = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        C_MonedaLabel = New System.Windows.Forms.Label()
        C_NombreMonedaLabel = New System.Windows.Forms.Label()
        C_DecimalesLabel = New System.Windows.Forms.Label()
        C_SimboloLabel = New System.Windows.Forms.Label()
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXP_c_MonedaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXP_c_MonedaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CXP_c_MonedaBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'C_MonedaLabel
        '
        C_MonedaLabel.AutoSize = True
        C_MonedaLabel.Location = New System.Drawing.Point(50, 40)
        C_MonedaLabel.Name = "C_MonedaLabel"
        C_MonedaLabel.Size = New System.Drawing.Size(61, 13)
        C_MonedaLabel.TabIndex = 1
        C_MonedaLabel.Text = "Id Moneda:"
        '
        'C_NombreMonedaLabel
        '
        C_NombreMonedaLabel.AutoSize = True
        C_NombreMonedaLabel.Location = New System.Drawing.Point(19, 66)
        C_NombreMonedaLabel.Name = "C_NombreMonedaLabel"
        C_NombreMonedaLabel.Size = New System.Drawing.Size(89, 13)
        C_NombreMonedaLabel.TabIndex = 3
        C_NombreMonedaLabel.Text = "Nombre Moneda:"
        '
        'C_DecimalesLabel
        '
        C_DecimalesLabel.AutoSize = True
        C_DecimalesLabel.Location = New System.Drawing.Point(49, 92)
        C_DecimalesLabel.Name = "C_DecimalesLabel"
        C_DecimalesLabel.Size = New System.Drawing.Size(59, 13)
        C_DecimalesLabel.TabIndex = 5
        C_DecimalesLabel.Text = "Decimales:"
        '
        'C_SimboloLabel
        '
        C_SimboloLabel.AutoSize = True
        C_SimboloLabel.Location = New System.Drawing.Point(263, 92)
        C_SimboloLabel.Name = "C_SimboloLabel"
        C_SimboloLabel.Size = New System.Drawing.Size(47, 13)
        C_SimboloLabel.TabIndex = 7
        C_SimboloLabel.Text = "Simbolo:"
        '
        'DsProduction
        '
        Me.DsProduction.DataSetName = "dsProduction"
        Me.DsProduction.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CXP_c_MonedaBindingSource
        '
        Me.CXP_c_MonedaBindingSource.DataMember = "CXP_c_Moneda"
        Me.CXP_c_MonedaBindingSource.DataSource = Me.DsProduction
        '
        'CXP_c_MonedaTableAdapter
        '
        Me.CXP_c_MonedaTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.CXP_CuentasBancariasTableAdapter = Nothing
        Me.TableAdapterManager.CXP_CuentasContablesTableAdapter = Nothing
        Me.TableAdapterManager.CXP_EmpresasTableAdapter = Nothing
        Me.TableAdapterManager.CXP_ImpuestoTableAdapter = Nothing
        Me.TableAdapterManager.CXP_ProveedoresTableAdapter = Nothing
        Me.TableAdapterManager.CXP_SucursalesTableAdapter = Nothing
        Me.TableAdapterManager.CXP_tipoDeDocumentoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = cuentasPorPagar.dsProductionTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CXP_c_MonedaBindingNavigator
        '
        Me.CXP_c_MonedaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CXP_c_MonedaBindingNavigator.BindingSource = Me.CXP_c_MonedaBindingSource
        Me.CXP_c_MonedaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CXP_c_MonedaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CXP_c_MonedaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CXP_c_MonedaBindingNavigatorSaveItem})
        Me.CXP_c_MonedaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CXP_c_MonedaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CXP_c_MonedaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CXP_c_MonedaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CXP_c_MonedaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CXP_c_MonedaBindingNavigator.Name = "CXP_c_MonedaBindingNavigator"
        Me.CXP_c_MonedaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CXP_c_MonedaBindingNavigator.Size = New System.Drawing.Size(433, 25)
        Me.CXP_c_MonedaBindingNavigator.TabIndex = 0
        Me.CXP_c_MonedaBindingNavigator.Text = "BindingNavigator1"
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
        'CXP_c_MonedaBindingNavigatorSaveItem
        '
        Me.CXP_c_MonedaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CXP_c_MonedaBindingNavigatorSaveItem.Image = CType(resources.GetObject("CXP_c_MonedaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CXP_c_MonedaBindingNavigatorSaveItem.Name = "CXP_c_MonedaBindingNavigatorSaveItem"
        Me.CXP_c_MonedaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CXP_c_MonedaBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'C_MonedaTextBox
        '
        Me.C_MonedaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_c_MonedaBindingSource, "c_Moneda", True))
        Me.C_MonedaTextBox.Location = New System.Drawing.Point(114, 37)
        Me.C_MonedaTextBox.Name = "C_MonedaTextBox"
        Me.C_MonedaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.C_MonedaTextBox.TabIndex = 2
        '
        'C_NombreMonedaTextBox
        '
        Me.C_NombreMonedaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_c_MonedaBindingSource, "c_NombreMoneda", True))
        Me.C_NombreMonedaTextBox.Location = New System.Drawing.Point(114, 63)
        Me.C_NombreMonedaTextBox.Name = "C_NombreMonedaTextBox"
        Me.C_NombreMonedaTextBox.Size = New System.Drawing.Size(302, 20)
        Me.C_NombreMonedaTextBox.TabIndex = 4
        '
        'C_DecimalesTextBox
        '
        Me.C_DecimalesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_c_MonedaBindingSource, "c_Decimales", True))
        Me.C_DecimalesTextBox.Location = New System.Drawing.Point(114, 89)
        Me.C_DecimalesTextBox.Name = "C_DecimalesTextBox"
        Me.C_DecimalesTextBox.Size = New System.Drawing.Size(100, 20)
        Me.C_DecimalesTextBox.TabIndex = 6
        '
        'C_SimboloTextBox
        '
        Me.C_SimboloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_c_MonedaBindingSource, "c_Simbolo", True))
        Me.C_SimboloTextBox.Location = New System.Drawing.Point(316, 89)
        Me.C_SimboloTextBox.Name = "C_SimboloTextBox"
        Me.C_SimboloTextBox.Size = New System.Drawing.Size(100, 20)
        Me.C_SimboloTextBox.TabIndex = 8
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(341, 161)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 9
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(22, 164)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(192, 20)
        Me.txtBuscar.TabIndex = 10
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(220, 162)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 11
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'frmSATMonedas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 196)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(C_SimboloLabel)
        Me.Controls.Add(Me.C_SimboloTextBox)
        Me.Controls.Add(C_DecimalesLabel)
        Me.Controls.Add(Me.C_DecimalesTextBox)
        Me.Controls.Add(C_NombreMonedaLabel)
        Me.Controls.Add(Me.C_NombreMonedaTextBox)
        Me.Controls.Add(C_MonedaLabel)
        Me.Controls.Add(Me.C_MonedaTextBox)
        Me.Controls.Add(Me.CXP_c_MonedaBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmSATMonedas"
        Me.Text = "Monedas"
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXP_c_MonedaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXP_c_MonedaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CXP_c_MonedaBindingNavigator.ResumeLayout(False)
        Me.CXP_c_MonedaBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DsProduction As dsProduction
    Friend WithEvents CXP_c_MonedaBindingSource As BindingSource
    Friend WithEvents CXP_c_MonedaTableAdapter As dsProductionTableAdapters.CXP_c_MonedaTableAdapter
    Friend WithEvents TableAdapterManager As dsProductionTableAdapters.TableAdapterManager
    Friend WithEvents CXP_c_MonedaBindingNavigator As BindingNavigator
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
    Friend WithEvents CXP_c_MonedaBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents C_MonedaTextBox As TextBox
    Friend WithEvents C_NombreMonedaTextBox As TextBox
    Friend WithEvents C_DecimalesTextBox As TextBox
    Friend WithEvents C_SimboloTextBox As TextBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents btnBuscar As Button
End Class
