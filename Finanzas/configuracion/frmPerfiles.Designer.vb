<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPerfiles
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
        Me.DsSeguridad = New cuentasPorPagar.dsSeguridad()
        Me.DsSeguridadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.USUARIOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.USUARIOTableAdapter = New cuentasPorPagar.dsSeguridadTableAdapters.USUARIOTableAdapter()
        Me.cmbMenu = New System.Windows.Forms.ComboBox()
        Me.cmbSubMenu1 = New System.Windows.Forms.ComboBox()
        Me.cmbSubMenu2 = New System.Windows.Forms.ComboBox()
        Me.chkLectura = New System.Windows.Forms.CheckBox()
        Me.chkEscritura = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CXP_PerfilesUsuarioDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.eliminar = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DsProduction = New cuentasPorPagar.dsProduction()
        Me.CXP_PerfilesUsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CXP_PerfilesUsuarioTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_PerfilesUsuarioTableAdapter()
        Me.TableAdapterManager = New cuentasPorPagar.dsProductionTableAdapters.TableAdapterManager()
        Me.cmbNombrePerfil = New System.Windows.Forms.ComboBox()
        Me.CXPPerfilesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProduction1 = New cuentasPorPagar.dsProduction()
        Me.CXP_PerfilesTableAdapter = New cuentasPorPagar.dsProductionTableAdapters.CXP_PerfilesTableAdapter()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.chkAccesoWeb = New System.Windows.Forms.CheckBox()
        CType(Me.DsSeguridad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSeguridadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USUARIOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXP_PerfilesUsuarioDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXP_PerfilesUsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CXPPerfilesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProduction1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DsSeguridad
        '
        Me.DsSeguridad.DataSetName = "dsSeguridad"
        Me.DsSeguridad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DsSeguridadBindingSource
        '
        Me.DsSeguridadBindingSource.DataSource = Me.DsSeguridad
        Me.DsSeguridadBindingSource.Position = 0
        '
        'USUARIOBindingSource
        '
        Me.USUARIOBindingSource.DataMember = "USUARIO"
        Me.USUARIOBindingSource.DataSource = Me.DsSeguridadBindingSource
        '
        'USUARIOTableAdapter
        '
        Me.USUARIOTableAdapter.ClearBeforeFill = True
        '
        'cmbMenu
        '
        Me.cmbMenu.DropDownWidth = 121
        Me.cmbMenu.FormattingEnabled = True
        Me.cmbMenu.Location = New System.Drawing.Point(12, 85)
        Me.cmbMenu.Name = "cmbMenu"
        Me.cmbMenu.Size = New System.Drawing.Size(200, 21)
        Me.cmbMenu.TabIndex = 1
        '
        'cmbSubMenu1
        '
        Me.cmbSubMenu1.FormattingEnabled = True
        Me.cmbSubMenu1.Location = New System.Drawing.Point(218, 85)
        Me.cmbSubMenu1.Name = "cmbSubMenu1"
        Me.cmbSubMenu1.Size = New System.Drawing.Size(200, 21)
        Me.cmbSubMenu1.TabIndex = 2
        '
        'cmbSubMenu2
        '
        Me.cmbSubMenu2.FormattingEnabled = True
        Me.cmbSubMenu2.Location = New System.Drawing.Point(427, 85)
        Me.cmbSubMenu2.Name = "cmbSubMenu2"
        Me.cmbSubMenu2.Size = New System.Drawing.Size(200, 21)
        Me.cmbSubMenu2.TabIndex = 3
        '
        'chkLectura
        '
        Me.chkLectura.AutoSize = True
        Me.chkLectura.Location = New System.Drawing.Point(632, 87)
        Me.chkLectura.Name = "chkLectura"
        Me.chkLectura.Size = New System.Drawing.Size(62, 17)
        Me.chkLectura.TabIndex = 4
        Me.chkLectura.Text = "Lectura"
        Me.chkLectura.UseVisualStyleBackColor = True
        '
        'chkEscritura
        '
        Me.chkEscritura.AutoSize = True
        Me.chkEscritura.Location = New System.Drawing.Point(700, 87)
        Me.chkEscritura.Name = "chkEscritura"
        Me.chkEscritura.Size = New System.Drawing.Size(114, 17)
        Me.chkEscritura.TabIndex = 5
        Me.chkEscritura.Text = "Lectura / Escritura"
        Me.chkEscritura.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Menú"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(215, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Submenú"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(424, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Submenú"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(820, 83)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(60, 23)
        Me.btnAgregar.TabIndex = 9
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Nombre perfil:"
        '
        'CXP_PerfilesUsuarioDataGridView
        '
        Me.CXP_PerfilesUsuarioDataGridView.AllowUserToAddRows = False
        Me.CXP_PerfilesUsuarioDataGridView.AllowUserToDeleteRows = False
        Me.CXP_PerfilesUsuarioDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.CXP_PerfilesUsuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CXP_PerfilesUsuarioDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewCheckBoxColumn2, Me.eliminar, Me.DataGridViewTextBoxColumn1})
        Me.CXP_PerfilesUsuarioDataGridView.Location = New System.Drawing.Point(12, 127)
        Me.CXP_PerfilesUsuarioDataGridView.Name = "CXP_PerfilesUsuarioDataGridView"
        Me.CXP_PerfilesUsuarioDataGridView.ReadOnly = True
        Me.CXP_PerfilesUsuarioDataGridView.Size = New System.Drawing.Size(934, 192)
        Me.CXP_PerfilesUsuarioDataGridView.TabIndex = 11
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Perfil"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Menú"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Sub Menú 1"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.Width = 210
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Sub Menú 2"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn4.Width = 210
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Lectura"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Width = 50
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.HeaderText = "Lectura Escritura"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.ReadOnly = True
        '
        'eliminar
        '
        Me.eliminar.HeaderText = "Eliminar"
        Me.eliminar.Name = "eliminar"
        Me.eliminar.ReadOnly = True
        Me.eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 30
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(296, 30)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DsProduction
        '
        Me.DsProduction.DataSetName = "dsProduction"
        Me.DsProduction.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CXP_PerfilesUsuarioBindingSource
        '
        Me.CXP_PerfilesUsuarioBindingSource.DataMember = "CXP_PerfilesUsuario"
        Me.CXP_PerfilesUsuarioBindingSource.DataSource = Me.DsProduction
        '
        'CXP_PerfilesUsuarioTableAdapter
        '
        Me.CXP_PerfilesUsuarioTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.CXP_CodigoAgrupadorTableAdapter = Nothing
        Me.TableAdapterManager.CXP_ConceptosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_CuentasBancariasTableAdapter = Nothing
        Me.TableAdapterManager.CXP_CuentasContablesTableAdapter = Nothing
        Me.TableAdapterManager.CXP_DiariosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_EmpresasTableAdapter = Nothing
        Me.TableAdapterManager.CXP_ImpuestoTableAdapter = Nothing
        Me.TableAdapterManager.CXP_PerfilesTableAdapter = Nothing
        Me.TableAdapterManager.CXP_PerfilesUsuarioTableAdapter = Me.CXP_PerfilesUsuarioTableAdapter
        Me.TableAdapterManager.CXP_ProveedoresTableAdapter = Nothing
        Me.TableAdapterManager.CXP_SucursalesTableAdapter = Nothing
        Me.TableAdapterManager.CXP_tipoDeDocumentoTableAdapter = Nothing
        Me.TableAdapterManager.CXP_tipoDocumentoSatTableAdapter = Nothing
        Me.TableAdapterManager.CXP_TipoGastoTableAdapter = Nothing
        Me.TableAdapterManager.CXP_UsuariosTableAdapter = Nothing
        Me.TableAdapterManager.CXP_XmlCfdiTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = cuentasPorPagar.dsProductionTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'cmbNombrePerfil
        '
        Me.cmbNombrePerfil.DataSource = Me.CXPPerfilesBindingSource
        Me.cmbNombrePerfil.DisplayMember = "nombrePerfil"
        Me.cmbNombrePerfil.FormattingEnabled = True
        Me.cmbNombrePerfil.Location = New System.Drawing.Point(91, 32)
        Me.cmbNombrePerfil.Name = "cmbNombrePerfil"
        Me.cmbNombrePerfil.Size = New System.Drawing.Size(199, 21)
        Me.cmbNombrePerfil.TabIndex = 13
        Me.cmbNombrePerfil.ValueMember = "idPerf"
        '
        'CXPPerfilesBindingSource
        '
        Me.CXPPerfilesBindingSource.DataMember = "CXP_Perfiles"
        Me.CXPPerfilesBindingSource.DataSource = Me.DsProduction1
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
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(885, 83)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(60, 23)
        Me.btnCancelar.TabIndex = 14
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'chkAccesoWeb
        '
        Me.chkAccesoWeb.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkAccesoWeb.AutoSize = True
        Me.chkAccesoWeb.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.CXP_PerfilesUsuarioBindingSource, "web", True))
        Me.chkAccesoWeb.Location = New System.Drawing.Point(632, 54)
        Me.chkAccesoWeb.Name = "chkAccesoWeb"
        Me.chkAccesoWeb.Size = New System.Drawing.Size(79, 23)
        Me.chkAccesoWeb.TabIndex = 15
        Me.chkAccesoWeb.Text = "Acceso Web"
        Me.chkAccesoWeb.UseVisualStyleBackColor = True
        '
        'frmPerfiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 335)
        Me.Controls.Add(Me.chkAccesoWeb)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.cmbNombrePerfil)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CXP_PerfilesUsuarioDataGridView)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkEscritura)
        Me.Controls.Add(Me.chkLectura)
        Me.Controls.Add(Me.cmbSubMenu2)
        Me.Controls.Add(Me.cmbSubMenu1)
        Me.Controls.Add(Me.cmbMenu)
        Me.Name = "frmPerfiles"
        Me.Text = "Perfiles"
        CType(Me.DsSeguridad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSeguridadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USUARIOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXP_PerfilesUsuarioDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProduction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXP_PerfilesUsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CXPPerfilesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProduction1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DsSeguridadBindingSource As BindingSource
    Friend WithEvents DsSeguridad As dsSeguridad
    Friend WithEvents USUARIOBindingSource As BindingSource
    Friend WithEvents USUARIOTableAdapter As dsSeguridadTableAdapters.USUARIOTableAdapter
    Friend WithEvents cmbMenu As ComboBox
    Friend WithEvents cmbSubMenu1 As ComboBox
    Friend WithEvents cmbSubMenu2 As ComboBox
    Friend WithEvents chkLectura As CheckBox
    Friend WithEvents chkEscritura As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents DsProduction As dsProduction
    Friend WithEvents CXP_PerfilesUsuarioBindingSource As BindingSource
    Friend WithEvents CXP_PerfilesUsuarioTableAdapter As dsProductionTableAdapters.CXP_PerfilesUsuarioTableAdapter
    Friend WithEvents TableAdapterManager As dsProductionTableAdapters.TableAdapterManager
    Friend WithEvents CXP_PerfilesUsuarioDataGridView As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents cmbNombrePerfil As ComboBox
    Friend WithEvents DsProduction1 As dsProduction
    Friend WithEvents CXPPerfilesBindingSource As BindingSource
    Friend WithEvents CXP_PerfilesTableAdapter As dsProductionTableAdapters.CXP_PerfilesTableAdapter
    Friend WithEvents btnCancelar As Button
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As DataGridViewCheckBoxColumn
    Friend WithEvents eliminar As DataGridViewLinkColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents chkAccesoWeb As CheckBox
End Class
