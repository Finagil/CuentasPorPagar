<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportePolizaDiario
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
        Me.crvPolizaDiario = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.CuentasTableAdapter = New cuentasPorPagar.contpaqTableAdapters.CuentasTableAdapter()
        Me.Contpaq = New cuentasPorPagar.contpaq()
        CType(Me.Contpaq, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'crvPolizaDiario
        '
        Me.crvPolizaDiario.ActiveViewIndex = -1
        Me.crvPolizaDiario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvPolizaDiario.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvPolizaDiario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvPolizaDiario.Location = New System.Drawing.Point(0, 0)
        Me.crvPolizaDiario.Name = "crvPolizaDiario"
        Me.crvPolizaDiario.Size = New System.Drawing.Size(800, 450)
        Me.crvPolizaDiario.TabIndex = 0
        '
        'CuentasTableAdapter
        '
        Me.CuentasTableAdapter.ClearBeforeFill = True
        '
        'Contpaq
        '
        Me.Contpaq.DataSetName = "contpaq"
        Me.Contpaq.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmReportePolizaDiario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.crvPolizaDiario)
        Me.Name = "frmReportePolizaDiario"
        Me.Text = "frmPolizaDiario"
        CType(Me.Contpaq, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents crvPolizaDiario As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CuentasTableAdapter As contpaqTableAdapters.CuentasTableAdapter
    Friend WithEvents Contpaq As contpaq
End Class
