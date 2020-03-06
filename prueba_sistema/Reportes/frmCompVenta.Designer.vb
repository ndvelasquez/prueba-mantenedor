<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompVenta
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
        Me.genera_comp_ventaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.db_sistema_ventasDataSet = New prueba_sistema.db_sistema_ventasDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.genera_comp_ventaTableAdapter = New prueba_sistema.db_sistema_ventasDataSetTableAdapters.genera_comp_ventaTableAdapter()
        Me.txtIdCompVenta = New System.Windows.Forms.TextBox()
        CType(Me.genera_comp_ventaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.db_sistema_ventasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'genera_comp_ventaBindingSource
        '
        Me.genera_comp_ventaBindingSource.DataMember = "genera_comp_venta"
        Me.genera_comp_ventaBindingSource.DataSource = Me.db_sistema_ventasDataSet
        '
        'db_sistema_ventasDataSet
        '
        Me.db_sistema_ventasDataSet.DataSetName = "db_sistema_ventasDataSet"
        Me.db_sistema_ventasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.genera_comp_ventaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "prueba_sistema.rptCompVenta.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(674, 489)
        Me.ReportViewer1.TabIndex = 0
        '
        'genera_comp_ventaTableAdapter
        '
        Me.genera_comp_ventaTableAdapter.ClearBeforeFill = True
        '
        'txtIdCompVenta
        '
        Me.txtIdCompVenta.Location = New System.Drawing.Point(433, 204)
        Me.txtIdCompVenta.Name = "txtIdCompVenta"
        Me.txtIdCompVenta.Size = New System.Drawing.Size(100, 20)
        Me.txtIdCompVenta.TabIndex = 1
        Me.txtIdCompVenta.Visible = False
        '
        'frmCompVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 489)
        Me.Controls.Add(Me.txtIdCompVenta)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmCompVenta"
        Me.Text = "prueba"
        CType(Me.genera_comp_ventaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.db_sistema_ventasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents genera_comp_ventaBindingSource As BindingSource
    Friend WithEvents db_sistema_ventasDataSet As db_sistema_ventasDataSet
    Friend WithEvents genera_comp_ventaTableAdapter As db_sistema_ventasDataSetTableAdapters.genera_comp_ventaTableAdapter
    Friend WithEvents txtIdCompVenta As TextBox
End Class
