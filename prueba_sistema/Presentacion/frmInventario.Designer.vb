<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventario
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
        Me.dataListadoInventario = New System.Windows.Forms.DataGridView()
        Me.movimientos = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtABuscar = New System.Windows.Forms.TextBox()
        Me.cboCampo = New System.Windows.Forms.ComboBox()
        CType(Me.dataListadoInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataListadoInventario
        '
        Me.dataListadoInventario.AllowUserToAddRows = False
        Me.dataListadoInventario.AllowUserToDeleteRows = False
        Me.dataListadoInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataListadoInventario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.movimientos})
        Me.dataListadoInventario.Location = New System.Drawing.Point(13, 61)
        Me.dataListadoInventario.Name = "dataListadoInventario"
        Me.dataListadoInventario.ReadOnly = True
        Me.dataListadoInventario.Size = New System.Drawing.Size(600, 434)
        Me.dataListadoInventario.TabIndex = 0
        '
        'movimientos
        '
        Me.movimientos.HeaderText = "Ver movimientos"
        Me.movimientos.Name = "movimientos"
        Me.movimientos.ReadOnly = True
        Me.movimientos.Text = "Ver movimientos"
        Me.movimientos.ToolTipText = "ver los movimientos del producto seleccionado"
        Me.movimientos.UseColumnTextForButtonValue = True
        Me.movimientos.Visible = False
        '
        'btnBuscar
        '
        Me.btnBuscar.Enabled = False
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnBuscar.Location = New System.Drawing.Point(282, 15)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(86, 30)
        Me.btnBuscar.TabIndex = 30
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtABuscar
        '
        Me.txtABuscar.Enabled = False
        Me.txtABuscar.Location = New System.Drawing.Point(145, 21)
        Me.txtABuscar.MaxLength = 100
        Me.txtABuscar.Name = "txtABuscar"
        Me.txtABuscar.Size = New System.Drawing.Size(131, 20)
        Me.txtABuscar.TabIndex = 29
        '
        'cboCampo
        '
        Me.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCampo.FormattingEnabled = True
        Me.cboCampo.Items.AddRange(New Object() {"nombre", "stock", "precio"})
        Me.cboCampo.Location = New System.Drawing.Point(18, 21)
        Me.cboCampo.Name = "cboCampo"
        Me.cboCampo.Size = New System.Drawing.Size(121, 21)
        Me.cboCampo.TabIndex = 28
        '
        'frmInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 507)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtABuscar)
        Me.Controls.Add(Me.cboCampo)
        Me.Controls.Add(Me.dataListadoInventario)
        Me.MaximizeBox = False
        Me.Name = "frmInventario"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Modulo de inventario"
        CType(Me.dataListadoInventario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dataListadoInventario As DataGridView
    Friend WithEvents movimientos As DataGridViewButtonColumn
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtABuscar As TextBox
    Friend WithEvents cboCampo As ComboBox
End Class
