<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptClientes
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.db_sistema_ventasDataSet = New prueba_sistema.db_sistema_ventasDataSet()
        Me.clienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.clienteTableAdapter = New prueba_sistema.db_sistema_ventasDataSetTableAdapters.clienteTableAdapter()
        CType(Me.db_sistema_ventasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.clienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.clienteBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "prueba_sistema.rptClientes.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'db_sistema_ventasDataSet
        '
        Me.db_sistema_ventasDataSet.DataSetName = "db_sistema_ventasDataSet"
        Me.db_sistema_ventasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'clienteBindingSource
        '
        Me.clienteBindingSource.DataMember = "cliente"
        Me.clienteBindingSource.DataSource = Me.db_sistema_ventasDataSet
        '
        'clienteTableAdapter
        '
        Me.clienteTableAdapter.ClearBeforeFill = True
        '
        'frmRptClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmRptClientes"
        Me.Text = "Reporte de clientes"
        CType(Me.db_sistema_ventasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.clienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents clienteBindingSource As BindingSource
    Friend WithEvents db_sistema_ventasDataSet As db_sistema_ventasDataSet
    Friend WithEvents clienteTableAdapter As db_sistema_ventasDataSetTableAdapters.clienteTableAdapter
End Class
