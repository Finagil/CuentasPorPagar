<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDiario
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
        Dim IdTipoDocumentoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDiario))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.CXPRegContBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.BindingNavigatorBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdTipoDocumentoTextBox = New System.Windows.Forms.TextBox()
        Me.FolioTipoDocumentoTextBox = New System.Windows.Forms.TextBox()
        Me.gvwEventos = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fila = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.claveTipoDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.folioTipoDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nConcepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.abono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.referencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.concepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VwCXPRegContableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Contpaq = New cuentasPorPagar.contpaq()
        Me.CuentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CuentasTableAdapter = New cuentasPorPagar.contpaqTableAdapters.CuentasTableAdapter()
        Me.pnlActualizaCuenta = New System.Windows.Forms.Panel()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCuenta = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTotalCargos = New System.Windows.Forms.TextBox()
        Me.txtTotalAbonos = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lklFolSolicitud = New System.Windows.Forms.LinkLabel()
        Me.CXPRegContBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_CXP_RegContableTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.Vw_CXP_RegContableTableAdapter()
        Me.CXP_RegContTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_RegContTableAdapter()
        Me.TableAdapterManager = New cuentasPorPagar.dsProductionTableAdapters.TableAdapterManager()
        Me.CxP_RegContTableAdapter1 = New cuentasPorPagar.dsProductionTableAdapters.CXP_RegContTableAdapter()
        Me.TableAdapterManager1 = New cuentasPorPagar.dsProductionTableAdapters.TableAdapterManager()
        Me.txtConceptos = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpFecha1 = New System.Windows.Forms.DateTimePicker()
        Me.dtpFecha2 = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.btnGenPoliza = New System.Windows.Forms.Button()
        IdTipoDocumentoLabel = New System.Windows.Forms.Label()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.CXPRegContBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwEventos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwCXPRegContableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Contpaq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlActualizaCuenta.SuspendLayout()
        CType(Me.CXPRegContBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdTipoDocumentoLabel
        '
        IdTipoDocumentoLabel.AutoSize = True
        IdTipoDocumentoLabel.Location = New System.Drawing.Point(1024, 20)
        IdTipoDocumentoLabel.Name = "IdTipoDocumentoLabel"
        IdTipoDocumentoLabel.Size = New System.Drawing.Size(10, 13)
        IdTipoDocumentoLabel.TabIndex = 2
        IdTipoDocumentoLabel.Text = "-"
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.BindingSource = Me.CXPRegContBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BindingNavigatorBindingNavigatorSaveItem})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(1248, 25)
        Me.BindingNavigator1.TabIndex = 0
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Enabled = False
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'CXPRegContBindingSource
        '
        Me.CXPRegContBindingSource.DataMember = "CXP_RegCont"
        Me.CXPRegContBindingSource.DataSource = Me.DsProduction
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
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Enabled = False
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
        'BindingNavigatorBindingNavigatorSaveItem
        '
        Me.BindingNavigatorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorBindingNavigatorSaveItem.Enabled = False
        Me.BindingNavigatorBindingNavigatorSaveItem.Image = CType(resources.GetObject("BindingNavigatorBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorBindingNavigatorSaveItem.Name = "BindingNavigatorBindingNavigatorSaveItem"
        Me.BindingNavigatorBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdTipoDocumentoTextBox
        '
        Me.IdTipoDocumentoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXPRegContBindingSource, "idTipoDocumento", True))
        Me.IdTipoDocumentoTextBox.Location = New System.Drawing.Point(965, 17)
        Me.IdTipoDocumentoTextBox.Name = "IdTipoDocumentoTextBox"
        Me.IdTipoDocumentoTextBox.ReadOnly = True
        Me.IdTipoDocumentoTextBox.Size = New System.Drawing.Size(53, 20)
        Me.IdTipoDocumentoTextBox.TabIndex = 3
        '
        'FolioTipoDocumentoTextBox
        '
        Me.FolioTipoDocumentoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXPRegContBindingSource, "folioTipoDocumento", True))
        Me.FolioTipoDocumentoTextBox.Location = New System.Drawing.Point(1040, 17)
        Me.FolioTipoDocumentoTextBox.Name = "FolioTipoDocumentoTextBox"
        Me.FolioTipoDocumentoTextBox.ReadOnly = True
        Me.FolioTipoDocumentoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FolioTipoDocumentoTextBox.TabIndex = 5
        '
        'gvwEventos
        '
        Me.gvwEventos.AllowUserToAddRows = False
        Me.gvwEventos.AllowUserToDeleteRows = False
        Me.gvwEventos.AutoGenerateColumns = False
        Me.gvwEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvwEventos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Fila, Me.claveTipoDocumento, Me.folioTipoDocumento, Me.fecha, Me.nConcepto, Me.idCuenta, Me.cuenta, Me.DataGridViewTextBoxColumn2, Me.cargo, Me.abono, Me.referencia, Me.concepto})
        Me.gvwEventos.DataSource = Me.VwCXPRegContableBindingSource
        Me.gvwEventos.Location = New System.Drawing.Point(12, 45)
        Me.gvwEventos.Name = "gvwEventos"
        Me.gvwEventos.ReadOnly = True
        Me.gvwEventos.RowHeadersVisible = False
        Me.gvwEventos.Size = New System.Drawing.Size(1216, 340)
        Me.gvwEventos.TabIndex = 6
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idReg"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 40
        '
        'Fila
        '
        Me.Fila.DataPropertyName = "Fila"
        Me.Fila.HeaderText = "-"
        Me.Fila.Name = "Fila"
        Me.Fila.ReadOnly = True
        Me.Fila.Width = 20
        '
        'claveTipoDocumento
        '
        Me.claveTipoDocumento.DataPropertyName = "claveTipoDocumento"
        Me.claveTipoDocumento.HeaderText = "Tipo Póliza"
        Me.claveTipoDocumento.Name = "claveTipoDocumento"
        Me.claveTipoDocumento.ReadOnly = True
        Me.claveTipoDocumento.Width = 80
        '
        'folioTipoDocumento
        '
        Me.folioTipoDocumento.DataPropertyName = "folioTipoDocumento"
        Me.folioTipoDocumento.HeaderText = "Póliza"
        Me.folioTipoDocumento.Name = "folioTipoDocumento"
        Me.folioTipoDocumento.ReadOnly = True
        Me.folioTipoDocumento.Width = 70
        '
        'fecha
        '
        Me.fecha.DataPropertyName = "fecha"
        DataGridViewCellStyle4.Format = "d"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.fecha.DefaultCellStyle = DataGridViewCellStyle4
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        Me.fecha.Width = 70
        '
        'nConcepto
        '
        Me.nConcepto.DataPropertyName = "nConcepto"
        Me.nConcepto.HeaderText = "Concepto"
        Me.nConcepto.Name = "nConcepto"
        Me.nConcepto.ReadOnly = True
        Me.nConcepto.Width = 220
        '
        'idCuenta
        '
        Me.idCuenta.DataPropertyName = "idCuenta"
        Me.idCuenta.HeaderText = "Id Cuenta"
        Me.idCuenta.Name = "idCuenta"
        Me.idCuenta.ReadOnly = True
        Me.idCuenta.Visible = False
        '
        'cuenta
        '
        Me.cuenta.HeaderText = "Cuenta"
        Me.cuenta.Name = "cuenta"
        Me.cuenta.ReadOnly = True
        Me.cuenta.Width = 120
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre cuenta"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'cargo
        '
        Me.cargo.DataPropertyName = "cargo"
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.cargo.DefaultCellStyle = DataGridViewCellStyle5
        Me.cargo.HeaderText = "Cargo"
        Me.cargo.Name = "cargo"
        Me.cargo.ReadOnly = True
        '
        'abono
        '
        Me.abono.DataPropertyName = "abono"
        DataGridViewCellStyle6.Format = "C2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.abono.DefaultCellStyle = DataGridViewCellStyle6
        Me.abono.HeaderText = "Abono"
        Me.abono.Name = "abono"
        Me.abono.ReadOnly = True
        '
        'referencia
        '
        Me.referencia.DataPropertyName = "referencia"
        Me.referencia.HeaderText = "Referencia"
        Me.referencia.Name = "referencia"
        Me.referencia.ReadOnly = True
        Me.referencia.Width = 300
        '
        'concepto
        '
        Me.concepto.DataPropertyName = "concepto"
        Me.concepto.HeaderText = "Descripción"
        Me.concepto.Name = "concepto"
        Me.concepto.ReadOnly = True
        Me.concepto.Width = 300
        '
        'VwCXPRegContableBindingSource
        '
        Me.VwCXPRegContableBindingSource.DataMember = "Vw_CXP_RegContable"
        Me.VwCXPRegContableBindingSource.DataSource = Me.DsProduction
        '
        'Contpaq
        '
        Me.Contpaq.DataSetName = "contpaq"
        Me.Contpaq.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CuentasBindingSource
        '
        Me.CuentasBindingSource.DataMember = "Cuentas"
        Me.CuentasBindingSource.DataSource = Me.Contpaq
        '
        'CuentasTableAdapter
        '
        Me.CuentasTableAdapter.ClearBeforeFill = True
        '
        'pnlActualizaCuenta
        '
        Me.pnlActualizaCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlActualizaCuenta.Controls.Add(Me.btnCancelar)
        Me.pnlActualizaCuenta.Controls.Add(Me.btnAceptar)
        Me.pnlActualizaCuenta.Controls.Add(Me.Label1)
        Me.pnlActualizaCuenta.Controls.Add(Me.txtCuenta)
        Me.pnlActualizaCuenta.Location = New System.Drawing.Point(478, 163)
        Me.pnlActualizaCuenta.Name = "pnlActualizaCuenta"
        Me.pnlActualizaCuenta.Size = New System.Drawing.Size(283, 93)
        Me.pnlActualizaCuenta.TabIndex = 8
        Me.pnlActualizaCuenta.Visible = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(183, 57)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(20, 58)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 2
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(223, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Por favor ingrese la cuenta contable correcta:"
        '
        'txtCuenta
        '
        Me.txtCuenta.Location = New System.Drawing.Point(4, 31)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(274, 20)
        Me.txtCuenta.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(967, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Póliza:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(441, 389)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Cargo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(613, 389)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Abono:"
        '
        'txtTotalCargos
        '
        Me.txtTotalCargos.Location = New System.Drawing.Point(444, 405)
        Me.txtTotalCargos.Name = "txtTotalCargos"
        Me.txtTotalCargos.ReadOnly = True
        Me.txtTotalCargos.Size = New System.Drawing.Size(157, 20)
        Me.txtTotalCargos.TabIndex = 15
        '
        'txtTotalAbonos
        '
        Me.txtTotalAbonos.Location = New System.Drawing.Point(616, 405)
        Me.txtTotalAbonos.Name = "txtTotalAbonos"
        Me.txtTotalAbonos.ReadOnly = True
        Me.txtTotalAbonos.Size = New System.Drawing.Size(157, 20)
        Me.txtTotalAbonos.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1164, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Solicitud:"
        '
        'lklFolSolicitud
        '
        Me.lklFolSolicitud.AutoSize = True
        Me.lklFolSolicitud.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CXPRegContBindingSource, "folioSolicitud", True))
        Me.lklFolSolicitud.Location = New System.Drawing.Point(1168, 20)
        Me.lklFolSolicitud.Name = "lklFolSolicitud"
        Me.lklFolSolicitud.Size = New System.Drawing.Size(10, 13)
        Me.lklFolSolicitud.TabIndex = 19
        Me.lklFolSolicitud.TabStop = True
        Me.lklFolSolicitud.Text = "-"
        '
        'CXPRegContBindingSource1
        '
        Me.CXPRegContBindingSource1.DataMember = "Vw_CXP_RegContable"
        Me.CXPRegContBindingSource1.DataSource = Me.DsProduction
        '
        'Vw_CXP_RegContableTableAdapter
        '
        Me.Vw_CXP_RegContableTableAdapter.ClearBeforeFill = True
        '
        'CXP_RegContTableAdapter
        '
        Me.CXP_RegContTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.CXP_RegContTableAdapter = Me.CXP_RegContTableAdapter
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
        'CxP_RegContTableAdapter1
        '
        Me.CxP_RegContTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.CFDI_Estado_NominaTableAdapter = Nothing
        Me.TableAdapterManager1.CXP_AutorizacionesTableAdapter = Nothing
        Me.TableAdapterManager1.CXP_BancosTableAdapter = Nothing
        Me.TableAdapterManager1.CXP_c_CodigoPostalTableAdapter = Nothing
        Me.TableAdapterManager1.CXP_c_EstadoTableAdapter = Nothing
        Me.TableAdapterManager1.CXP_c_MonedaTableAdapter = Nothing
        Me.TableAdapterManager1.CXP_c_PaisTableAdapter = Nothing
        Me.TableAdapterManager1.CXP_c_RegimenFiscalTableAdapter = Nothing
        Me.TableAdapterManager1.CXP_CodigoAgrupadorTableAdapter = Nothing
        Me.TableAdapterManager1.CXP_ComprobGtosTableAdapter = Nothing
        Me.TableAdapterManager1.CXP_ConceptosTableAdapter = Nothing
        Me.TableAdapterManager1.CXP_CuentasBancariasProvTableAdapter = Nothing
        Me.TableAdapterManager1.CXP_CuentasBancariasTableAdapter = Nothing
        Me.TableAdapterManager1.CXP_CuentasContablesTableAdapter = Nothing
        Me.TableAdapterManager1.CXP_DepartamentosTableAdapter = Nothing
        Me.TableAdapterManager1.CXP_DiariosTableAdapter = Nothing
        Me.TableAdapterManager1.CXP_EmpresasTableAdapter = Nothing
        Me.TableAdapterManager1.CXP_ImpConTableAdapter = Nothing
        Me.TableAdapterManager1.CXP_ImpuestoTableAdapter = Nothing
        Me.TableAdapterManager1.CXP_PagosTableAdapter = Nothing
        Me.TableAdapterManager1.CXP_PerfilesTableAdapter = Nothing
        Me.TableAdapterManager1.CXP_PerfilesUsuarioTableAdapter = Nothing
        Me.TableAdapterManager1.CXP_ProveedoresTableAdapter = Nothing
        Me.TableAdapterManager1.CXP_RegContTableAdapter = Me.CxP_RegContTableAdapter1
        Me.TableAdapterManager1.CXP_SucursalesTableAdapter = Nothing
        Me.TableAdapterManager1.CXP_tipoConceptoTableAdapter = Nothing
        Me.TableAdapterManager1.CXP_tipoCuentaContableTableAdapter = Nothing
        Me.TableAdapterManager1.CXP_tipoDeDocumentoTableAdapter = Nothing
        Me.TableAdapterManager1.CXP_tipoDocumentoSatTableAdapter = Nothing
        Me.TableAdapterManager1.CXP_TipoGastoTableAdapter = Nothing
        Me.TableAdapterManager1.CXP_UsuariosTableAdapter = Nothing
        Me.TableAdapterManager1.CXP_XmlCfdi2TableAdapter = Nothing
        Me.TableAdapterManager1.CXP_XmlCfdiTableAdapter = Nothing
        Me.TableAdapterManager1.SucursalesTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = cuentasPorPagar.dsProductionTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'txtConceptos
        '
        Me.txtConceptos.Location = New System.Drawing.Point(12, 405)
        Me.txtConceptos.Multiline = True
        Me.txtConceptos.Name = "txtConceptos"
        Me.txtConceptos.ReadOnly = True
        Me.txtConceptos.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtConceptos.Size = New System.Drawing.Size(408, 39)
        Me.txtConceptos.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 389)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Concepto: "
        '
        'dtpFecha1
        '
        Me.dtpFecha1.Location = New System.Drawing.Point(417, 16)
        Me.dtpFecha1.Name = "dtpFecha1"
        Me.dtpFecha1.Size = New System.Drawing.Size(200, 20)
        Me.dtpFecha1.TabIndex = 22
        '
        'dtpFecha2
        '
        Me.dtpFecha2.Location = New System.Drawing.Point(665, 16)
        Me.dtpFecha2.Name = "dtpFecha2"
        Me.dtpFecha2.Size = New System.Drawing.Size(200, 20)
        Me.dtpFecha2.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(346, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Consulta del"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(634, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(15, 13)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "al"
        '
        'btnProcesar
        '
        Me.btnProcesar.Location = New System.Drawing.Point(871, 15)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(75, 23)
        Me.btnProcesar.TabIndex = 26
        Me.btnProcesar.Text = "Procesar"
        Me.btnProcesar.UseVisualStyleBackColor = True
        '
        'btnGenPoliza
        '
        Me.btnGenPoliza.Location = New System.Drawing.Point(1075, 397)
        Me.btnGenPoliza.Name = "btnGenPoliza"
        Me.btnGenPoliza.Size = New System.Drawing.Size(153, 23)
        Me.btnGenPoliza.TabIndex = 27
        Me.btnGenPoliza.Text = "Generar Póliza"
        Me.btnGenPoliza.UseVisualStyleBackColor = True
        '
        'frmDiario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1248, 456)
        Me.Controls.Add(Me.btnGenPoliza)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtpFecha2)
        Me.Controls.Add(Me.dtpFecha1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtConceptos)
        Me.Controls.Add(Me.lklFolSolicitud)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTotalAbonos)
        Me.Controls.Add(Me.txtTotalCargos)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pnlActualizaCuenta)
        Me.Controls.Add(Me.gvwEventos)
        Me.Controls.Add(Me.FolioTipoDocumentoTextBox)
        Me.Controls.Add(IdTipoDocumentoLabel)
        Me.Controls.Add(Me.IdTipoDocumentoTextBox)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmDiario"
        Me.Text = "Diarios "
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.CXPRegContBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwEventos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwCXPRegContableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Contpaq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlActualizaCuenta.ResumeLayout(False)
        Me.pnlActualizaCuenta.PerformLayout()
        CType(Me.CXPRegContBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DsProduction As dsProduction
    Friend WithEvents CXP_RegContTableAdapter As dsProductionTableAdapters.CXP_RegContTableAdapter
    Friend WithEvents TableAdapterManager As dsProductionTableAdapters.TableAdapterManager
    Friend WithEvents BindingNavigator1 As BindingNavigator
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
    Friend WithEvents CXPRegContBindingSource As BindingSource
    Friend WithEvents IdTipoDocumentoTextBox As TextBox
    Friend WithEvents FolioTipoDocumentoTextBox As TextBox
    Friend WithEvents gvwEventos As DataGridView
    Friend WithEvents CXPRegContBindingSource1 As BindingSource
    Friend WithEvents CxP_RegContTableAdapter1 As dsProductionTableAdapters.CXP_RegContTableAdapter
    Friend WithEvents TableAdapterManager1 As dsProductionTableAdapters.TableAdapterManager
    Friend WithEvents BindingNavigatorBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Vw_CXP_RegContableTableAdapter As dsProductionTableAdapters.Vw_CXP_RegContableTableAdapter
    Friend WithEvents VwCXPRegContableBindingSource As BindingSource
    Friend WithEvents Contpaq As contpaq
    Friend WithEvents CuentasBindingSource As BindingSource
    Friend WithEvents CuentasTableAdapter As contpaqTableAdapters.CuentasTableAdapter
    Friend WithEvents pnlActualizaCuenta As Panel
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCuenta As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTotalCargos As TextBox
    Friend WithEvents txtTotalAbonos As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lklFolSolicitud As LinkLabel
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Fila As DataGridViewTextBoxColumn
    Friend WithEvents claveTipoDocumento As DataGridViewTextBoxColumn
    Friend WithEvents folioTipoDocumento As DataGridViewTextBoxColumn
    Friend WithEvents fecha As DataGridViewTextBoxColumn
    Friend WithEvents nConcepto As DataGridViewTextBoxColumn
    Friend WithEvents idCuenta As DataGridViewTextBoxColumn
    Friend WithEvents cuenta As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents cargo As DataGridViewTextBoxColumn
    Friend WithEvents abono As DataGridViewTextBoxColumn
    Friend WithEvents referencia As DataGridViewTextBoxColumn
    Friend WithEvents concepto As DataGridViewTextBoxColumn
    Friend WithEvents txtConceptos As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpFecha1 As DateTimePicker
    Friend WithEvents dtpFecha2 As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnProcesar As Button
    Friend WithEvents btnGenPoliza As Button
End Class
