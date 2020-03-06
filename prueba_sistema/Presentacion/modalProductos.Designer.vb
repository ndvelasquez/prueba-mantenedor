<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modalProductos
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
        Me.dataListadoProductos = New System.Windows.Forms.DataGridView()
        Me.txtFlag = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTextoABuscar = New System.Windows.Forms.TextBox()
        Me.cboCampo = New System.Windows.Forms.ComboBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        CType(Me.dataListadoProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataListadoProductos
        '
        Me.dataListadoProductos.AllowUserToAddRows = False
        Me.dataListadoProductos.AllowUserToDeleteRows = False
        Me.dataListadoProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataListadoProductos.Location = New System.Drawing.Point(12, 63)
        Me.dataListadoProductos.Name = "dataListadoProductos"
        Me.dataListadoProductos.ReadOnly = True
        Me.dataListadoProductos.Size = New System.Drawing.Size(589, 240)
        Me.dataListadoProductos.TabIndex = 0
        '
        'txtFlag
        '
        Me.txtFlag.Location = New System.Drawing.Point(565, 12)
        Me.txtFlag.MaxLength = 1
        Me.txtFlag.Name = "txtFlag"
        Me.txtFlag.ReadOnly = True
        Me.txtFlag.Size = New System.Drawing.Size(36, 20)
        Me.txtFlag.TabIndex = 1
        Me.txtFlag.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(23, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Buscar Producto"
        '
        'txtTextoABuscar
        '
        Me.txtTextoABuscar.Location = New System.Drawing.Point(153, 29)
        Me.txtTextoABuscar.Name = "txtTextoABuscar"
        Me.txtTextoABuscar.Size = New System.Drawing.Size(109, 20)
        Me.txtTextoABuscar.TabIndex = 3
        '
        'cboCampo
        '
        Me.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCampo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCampo.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.cboCampo.FormattingEnabled = True
        Me.cboCampo.Items.AddRange(New Object() {"nombre", "categoria"})
        Me.cboCampo.Location = New System.Drawing.Point(26, 29)
        Me.cboCampo.Name = "cboCampo"
        Me.cboCampo.Size = New System.Drawing.Size(121, 21)
        Me.cboCampo.TabIndex = 4
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnBuscar.Location = New System.Drawing.Point(269, 29)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 5
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'modalProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 315)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.cboCampo)
        Me.Controls.Add(Me.txtTextoABuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFlag)
        Me.Controls.Add(Me.dataListadoProductos)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MaximizeBox = False
        Me.Name = "modalProductos"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Listado de Productos"
        CType(Me.dataListadoProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dataListadoProductos As DataGridView
    Friend WithEvents txtFlag As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTextoABuscar As TextBox
    Friend WithEvents cboCampo As ComboBox
    Friend WithEvents btnBuscar As Button
End Class
