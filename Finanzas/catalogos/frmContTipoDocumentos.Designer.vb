<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContTipoDocumentos
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
        Dim ClaveTipoDocumentoLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim FechaRegistroLabel As System.Windows.Forms.Label
        Dim DocumentoDeLabel As System.Windows.Forms.Label
        Dim FolioInicialLabel As System.Windows.Forms.Label
        Dim FolioFinalLabel As System.Windows.Forms.Label
        Dim FolioActualLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContTipoDocumentos))
        Me.DsProduction = New cuentasPorPagar.dsProduction()
        Me.CXP_tipoDeDocumentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CXP_tipoDeDocumentoTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_tipoDeDocumentoTableAdapter()
        Me.TableAdapterManager = New cuentasPorPagar.dsProductionTableAdapters.TableAdapterManager()
        Me.CXP_tipoDeDocumentoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.CXP_tipoDeDocumentoBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ClaveTipoDocumentoTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.FechaRegistroDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FolioInicialTextBox = New System.Windows.Forms.TextBox()
        Me.FolioFinalTextBox = New System.Windows.Forms.TextBox()
        Me.FolioActualTextBox = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        ClaveTipoDocumentoLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        FechaRegistroLabel = New System.Windows.Forms.Label()
        DocumentoDeLabel = New System.Windows.Forms.Label()
        FolioInicialLabel = New System.Windows.Forms.Label()
        FolioFinalLabel = New System.Windows.Forms.Label()
        FolioActualLabel = New System.Windows.Forms.Label()
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXP_tipoDeDocumentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXP_tipoDeDocumentoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CXP_tipoDeDocumentoBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'ClaveTipoDocumentoLabel
        '
        ClaveTipoDocumentoLabel.AutoSize = True
        ClaveTipoDocumentoLabel.Location = New System.Drawing.Point(16, 31)
        ClaveTipoDocumentoLabel.Name = "ClaveTipoDocumentoLabel"
        ClaveTipoDocumentoLabel.Size = New System.Drawing.Size(93, 13)
        ClaveTipoDocumentoLabel.TabIndex = 1
        ClaveTipoDocumentoLabel.Text = "Clave Tipo Docto:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(64, 56)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 3
        NombreLabel.Text = "Nombre:"
        '
        'FechaRegistroLabel
        '
        FechaRegistroLabel.AutoSize = True
        FechaRegistroLabel.Location = New System.Drawing.Point(233, 31)
        FechaRegistroLabel.Name = "FechaRegistroLabel"
        FechaRegistroLabel.Size = New System.Drawing.Size(78, 13)
        FechaRegistroLabel.TabIndex = 5
        FechaRegistroLabel.Text = "Fecha de Reg:"
        '
        'DocumentoDeLabel
        '
        DocumentoDeLabel.AutoSize = True
        DocumentoDeLabel.Location = New System.Drawing.Point(331, 82)
        DocumentoDeLabel.Name = "DocumentoDeLabel"
        DocumentoDeLabel.Size = New System.Drawing.Size(80, 13)
        DocumentoDeLabel.TabIndex = 9
        DocumentoDeLabel.Text = "Documento de:"
        '
        'FolioInicialLabel
        '
        FolioInicialLabel.AutoSize = True
        FolioInicialLabel.Location = New System.Drawing.Point(50, 82)
        FolioInicialLabel.Name = "FolioInicialLabel"
        FolioInicialLabel.Size = New System.Drawing.Size(62, 13)
        FolioInicialLabel.TabIndex = 15
        FolioInicialLabel.Text = "Folio Inicial:"
        '
        'FolioFinalLabel
        '
        FolioFinalLabel.AutoSize = True
        FolioFinalLabel.Location = New System.Drawing.Point(55, 108)
        FolioFinalLabel.Name = "FolioFinalLabel"
        FolioFinalLabel.Size = New System.Drawing.Size(57, 13)
        FolioFinalLabel.TabIndex = 17
        FolioFinalLabel.Text = "Folio Final:"
        '
        'FolioActualLabel
        '
        FolioActualLabel.AutoSize = True
        FolioActualLabel.Location = New System.Drawing.Point(47, 134)
        FolioActualLabel.Name = "FolioActualLabel"
        FolioActualLabel.Size = New System.Drawing.Size(65, 13)
        FolioActualLabel.TabIndex = 19
        FolioActualLabel.Text = "Folio Actual:"
        '
        'DsProduction
        '
        Me.DsProduction.DataSetName = "dsProduction"
        Me.DsProduction.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.TableAdapterManager.CXP_ImpuestoTableAdapter = Nothing
        Me.TableAdapterManager.CXP_PerfilesTableAdapter = Nothing
        Me.TableAdapterManager.CXP_PerfilesUsuarioTableAdapter = Nothing
        Me.TableAdapterManager.CXP_ProveedoresTableAdapter = Nothing
        Me.TableAdapterManager.CXP_SucursalesTableAdapter = Nothing
        Me.TableAdapterManager.CXP_tipoDeDocumentoTableAdapter = Me.CXP_tipoDeDocumentoTableAdapter
        Me.TableAdapterManager.CXP_tipoDocumentoSatTableAdapter = Nothing
        Me.TableAdapterManager.CXP_TipoGastoTableAdapter = Nothing
        Me.TableAdapterManager.CXP_UsuariosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_XmlCfdiTableAdapter = Nothing
        Me.TableAdapterManager.SucursalesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = cuentasPorPagar.dsProductionTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CXP_tipoDeDocumentoBindingNavigator
        '
        Me.CXP_tipoDeDocumentoBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CXP_tipoDeDocumentoBindingNavigator.BindingSource = Me.CXP_tipoDeDocumentoBindingSource
        Me.CXP_tipoDeDocumentoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CXP_tipoDeDocumentoBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CXP_tipoDeDocumentoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CXP_tipoDeDocumentoBindingNavigatorSaveItem})
        Me.CXP_tipoDeDocumentoBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CXP_tipoDeDocumentoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CXP_tipoDeDocumentoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CXP_tipoDeDocumentoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CXP_tipoDeDocumentoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CXP_tipoDeDocumentoBindingNavigator.Name = "CXP_tipoDeDocumentoBindingNavigator"
        Me.CXP_tipoDeDocumentoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CXP_tipoDeDocumentoBindingNavigator.Size = New System.Drawing.Size(527, 25)
        Me.CXP_tipoDeDocumentoBindingNavigator.TabIndex = 0
        Me.CXP_tipoDeDocumentoBindingNavigator.Text = "BindingNavigator1"
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
        'CXP_tipoDeDocumentoBindingNavigatorSaveItem
        '
        Me.CXP_tipoDeDocumentoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CXP_tipoDeDocumentoBindingNavigatorSaveItem.Image = CType(resources.GetObject("CXP_tipoDeDocumentoBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CXP_tipoDeDocumentoBindingNavigatorSaveItem.Name = "CXP_tipoDeDocumentoBindingNavigatorSaveItem"
        Me.CXP_tipoDeDocumentoBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CXP_tipoDeDocumentoBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'ClaveTipoDocumentoTextBox
        '
        Me.ClaveTipoDocumentoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_tipoDeDocumentoBindingSource, "claveTipoDocumento", True))
        Me.ClaveTipoDocumentoTextBox.Location = New System.Drawing.Point(115, 28)
        Me.ClaveTipoDocumentoTextBox.Name = "ClaveTipoDocumentoTextBox"
        Me.ClaveTipoDocumentoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ClaveTipoDocumentoTextBox.TabIndex = 2
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_tipoDeDocumentoBindingSource, "nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(115, 53)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(402, 20)
        Me.NombreTextBox.TabIndex = 4
        '
        'FechaRegistroDateTimePicker
        '
        Me.FechaRegistroDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CXP_tipoDeDocumentoBindingSource, "fechaRegistro", True))
        Me.FechaRegistroDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_tipoDeDocumentoBindingSource, "fechaRegistro", True))
        Me.FechaRegistroDateTimePicker.Enabled = False
        Me.FechaRegistroDateTimePicker.Location = New System.Drawing.Point(317, 28)
        Me.FechaRegistroDateTimePicker.Name = "FechaRegistroDateTimePicker"
        Me.FechaRegistroDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechaRegistroDateTimePicker.TabIndex = 6
        '
        'FolioInicialTextBox
        '
        Me.FolioInicialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_tipoDeDocumentoBindingSource, "folioInicial", True))
        Me.FolioInicialTextBox.Location = New System.Drawing.Point(115, 79)
        Me.FolioInicialTextBox.Name = "FolioInicialTextBox"
        Me.FolioInicialTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FolioInicialTextBox.TabIndex = 16
        '
        'FolioFinalTextBox
        '
        Me.FolioFinalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_tipoDeDocumentoBindingSource, "folioFinal", True))
        Me.FolioFinalTextBox.Location = New System.Drawing.Point(115, 105)
        Me.FolioFinalTextBox.Name = "FolioFinalTextBox"
        Me.FolioFinalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FolioFinalTextBox.TabIndex = 18
        '
        'FolioActualTextBox
        '
        Me.FolioActualTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_tipoDeDocumentoBindingSource, "folioActual", True))
        Me.FolioActualTextBox.Location = New System.Drawing.Point(115, 131)
        Me.FolioActualTextBox.Name = "FolioActualTextBox"
        Me.FolioActualTextBox.ReadOnly = True
        Me.FolioActualTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FolioActualTextBox.TabIndex = 20
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(442, 131)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 21
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXP_tipoDeDocumentoBindingSource, "documentoDe", True))
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Ingreso", "Egreso", "Diario"})
        Me.ComboBox1.Location = New System.Drawing.Point(417, 79)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox1.TabIndex = 22
        '
        'frmContTipoDocumentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 164)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(FolioActualLabel)
        Me.Controls.Add(Me.FolioActualTextBox)
        Me.Controls.Add(FolioFinalLabel)
        Me.Controls.Add(Me.FolioFinalTextBox)
        Me.Controls.Add(FolioInicialLabel)
        Me.Controls.Add(Me.FolioInicialTextBox)
        Me.Controls.Add(DocumentoDeLabel)
        Me.Controls.Add(FechaRegistroLabel)
        Me.Controls.Add(Me.FechaRegistroDateTimePicker)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(ClaveTipoDocumentoLabel)
        Me.Controls.Add(Me.ClaveTipoDocumentoTextBox)
        Me.Controls.Add(Me.CXP_tipoDeDocumentoBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmContTipoDocumentos"
        Me.Text = "Tipo de Poliza"
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXP_tipoDeDocumentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXP_tipoDeDocumentoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CXP_tipoDeDocumentoBindingNavigator.ResumeLayout(False)
        Me.CXP_tipoDeDocumentoBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DsProduction As dsProduction
    Friend WithEvents CXP_tipoDeDocumentoBindingSource As BindingSource
    Friend WithEvents CXP_tipoDeDocumentoTableAdapter As dsProductionTableAdapters.CXP_tipoDeDocumentoTableAdapter
    Friend WithEvents TableAdapterManager As dsProductionTableAdapters.TableAdapterManager
    Friend WithEvents CXP_tipoDeDocumentoBindingNavigator As BindingNavigator
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
    Friend WithEvents CXP_tipoDeDocumentoBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ClaveTipoDocumentoTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents FechaRegistroDateTimePicker As DateTimePicker
    Friend WithEvents FolioInicialTextBox As TextBox
    Friend WithEvents FolioFinalTextBox As TextBox
    Friend WithEvents FolioActualTextBox As TextBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents ComboBox1 As ComboBox
End Class
