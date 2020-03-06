<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modalClientes
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
        Me.dataListadoClientes = New System.Windows.Forms.DataGridView()
        Me.txtFlag = New System.Windows.Forms.TextBox()
        CType(Me.dataListadoClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataListadoClientes
        '
        Me.dataListadoClientes.AllowUserToAddRows = False
        Me.dataListadoClientes.AllowUserToDeleteRows = False
        Me.dataListadoClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataListadoClientes.Location = New System.Drawing.Point(12, 40)
        Me.dataListadoClientes.Name = "dataListadoClientes"
        Me.dataListadoClientes.ReadOnly = True
        Me.dataListadoClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dataListadoClientes.Size = New System.Drawing.Size(552, 257)
        Me.dataListadoClientes.TabIndex = 5
        '
        'txtFlag
        '
        Me.txtFlag.Location = New System.Drawing.Point(13, 13)
        Me.txtFlag.MaxLength = 1
        Me.txtFlag.Name = "txtFlag"
        Me.txtFlag.Size = New System.Drawing.Size(36, 20)
        Me.txtFlag.TabIndex = 6
        Me.txtFlag.Visible = False
        '
        'modalClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 309)
        Me.Controls.Add(Me.txtFlag)
        Me.Controls.Add(Me.dataListadoClientes)
        Me.MaximizeBox = False
        Me.Name = "modalClientes"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Listado de clientes"
        CType(Me.dataListadoClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dataListadoClientes As DataGridView
    Friend WithEvents txtFlag As TextBox
End Class
