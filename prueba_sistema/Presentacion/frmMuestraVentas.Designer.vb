<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMuestraVentas
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
        Me.Db_sistema_ventasDataSet = New prueba_sistema.db_sistema_ventasDataSet()
        Me.MostrarventaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Mostrar_ventaTableAdapter = New prueba_sistema.db_sistema_ventasDataSetTableAdapters.mostrar_ventaTableAdapter()
        Me.noDatos = New System.Windows.Forms.Label()
        Me.chkAnular = New System.Windows.Forms.CheckBox()
        Me.cboCampo = New System.Windows.Forms.ComboBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnAnular = New System.Windows.Forms.Button()
        Me.txtTextoABuscar = New System.Windows.Forms.TextBox()
        Me.dataListadoVentas = New System.Windows.Forms.DataGridView()
        Me.Anular = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ver_detalle = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.Db_sistema_ventasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MostrarventaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataListadoVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Db_sistema_ventasDataSet
        '
        Me.Db_sistema_ventasDataSet.DataSetName = "db_sistema_ventasDataSet"
        Me.Db_sistema_ventasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MostrarventaBindingSource
        '
        Me.MostrarventaBindingSource.DataMember = "mostrar_venta"
        Me.MostrarventaBindingSource.DataSource = Me.Db_sistema_ventasDataSet
        '
        'Mostrar_ventaTableAdapter
        '
        Me.Mostrar_ventaTableAdapter.ClearBeforeFill = True
        '
        'noDatos
        '
        Me.noDatos.AutoSize = True
        Me.noDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.noDatos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.noDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.noDatos.ForeColor = System.Drawing.Color.SteelBlue
        Me.noDatos.Location = New System.Drawing.Point(318, 213)
        Me.noDatos.Name = "noDatos"
        Me.noDatos.Size = New System.Drawing.Size(202, 18)
        Me.noDatos.TabIndex = 1
        Me.noDatos.Text = "No se encontraron registros"
        '
        'chkAnular
        '
        Me.chkAnular.AutoSize = True
        Me.chkAnular.Location = New System.Drawing.Point(12, 59)
        Me.chkAnular.Name = "chkAnular"
        Me.chkAnular.Size = New System.Drawing.Size(97, 17)
        Me.chkAnular.TabIndex = 2
        Me.chkAnular.Text = "Habilitar Anular"
        Me.chkAnular.UseVisualStyleBackColor = True
        '
        'cboCampo
        '
        Me.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCampo.FormattingEnabled = True
        Me.cboCampo.Items.AddRange(New Object() {"fecha", "numero comprobante", "comprobante", "dni", "nombres", "apellidos"})
        Me.cboCampo.Location = New System.Drawing.Point(13, 13)
        Me.cboCampo.Name = "cboCampo"
        Me.cboCampo.Size = New System.Drawing.Size(121, 21)
        Me.cboCampo.TabIndex = 3
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnBuscar.Location = New System.Drawing.Point(250, 13)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 4
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnAnular
        '
        Me.btnAnular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnular.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnAnular.Location = New System.Drawing.Point(13, 449)
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(107, 28)
        Me.btnAnular.TabIndex = 5
        Me.btnAnular.Text = "Anular venta(s)"
        Me.btnAnular.UseVisualStyleBackColor = True
        Me.btnAnular.Visible = False
        '
        'txtTextoABuscar
        '
        Me.txtTextoABuscar.Location = New System.Drawing.Point(141, 13)
        Me.txtTextoABuscar.Name = "txtTextoABuscar"
        Me.txtTextoABuscar.Size = New System.Drawing.Size(100, 20)
        Me.txtTextoABuscar.TabIndex = 6
        '
        'dataListadoVentas
        '
        Me.dataListadoVentas.AllowUserToAddRows = False
        Me.dataListadoVentas.AllowUserToDeleteRows = False
        Me.dataListadoVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataListadoVentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Anular, Me.ver_detalle})
        Me.dataListadoVentas.Location = New System.Drawing.Point(13, 83)
        Me.dataListadoVentas.Name = "dataListadoVentas"
        Me.dataListadoVentas.ReadOnly = True
        Me.dataListadoVentas.Size = New System.Drawing.Size(811, 360)
        Me.dataListadoVentas.TabIndex = 7
        '
        'Anular
        '
        Me.Anular.HeaderText = "Anular"
        Me.Anular.Name = "Anular"
        Me.Anular.ReadOnly = True
        '
        'ver_detalle
        '
        Me.ver_detalle.HeaderText = "ver detalle"
        Me.ver_detalle.Name = "ver_detalle"
        Me.ver_detalle.ReadOnly = True
        Me.ver_detalle.Text = "ver detalle"
        Me.ver_detalle.ToolTipText = "ver detalle de la venta"
        Me.ver_detalle.UseColumnTextForButtonValue = True
        Me.ver_detalle.Visible = False
        '
        'frmMuestraVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(836, 482)
        Me.Controls.Add(Me.noDatos)
        Me.Controls.Add(Me.dataListadoVentas)
        Me.Controls.Add(Me.txtTextoABuscar)
        Me.Controls.Add(Me.btnAnular)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.cboCampo)
        Me.Controls.Add(Me.chkAnular)
        Me.Name = "frmMuestraVentas"
        Me.Text = "Listado de ventas"
        CType(Me.Db_sistema_ventasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MostrarventaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataListadoVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Db_sistema_ventasDataSet As db_sistema_ventasDataSet
    Friend WithEvents MostrarventaBindingSource As BindingSource
    Friend WithEvents Mostrar_ventaTableAdapter As db_sistema_ventasDataSetTableAdapters.mostrar_ventaTableAdapter
    Friend WithEvents noDatos As Label
    Friend WithEvents chkAnular As CheckBox
    Friend WithEvents cboCampo As ComboBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnAnular As Button
    Friend WithEvents txtTextoABuscar As TextBox
    Friend WithEvents dataListadoVentas As DataGridView
    Friend WithEvents Anular As DataGridViewCheckBoxColumn
    Friend WithEvents ver_detalle As DataGridViewButtonColumn
End Class
