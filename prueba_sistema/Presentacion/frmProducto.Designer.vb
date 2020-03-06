<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProducto
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtCategoria = New System.Windows.Forms.TextBox()
        Me.txtNumDocumento = New System.Windows.Forms.TextBox()
        Me.txtNombreProducto = New System.Windows.Forms.TextBox()
        Me.txtIdProducto = New System.Windows.Forms.TextBox()
        Me.errorIcon = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.checkEliminar = New System.Windows.Forms.CheckBox()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.noDatos = New System.Windows.Forms.LinkLabel()
        Me.dataListadoProductos = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCantidad = New System.Windows.Forms.NumericUpDown()
        Me.txtIdCategoria = New System.Windows.Forms.TextBox()
        Me.btnBuscarCat = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtABuscar = New System.Windows.Forms.TextBox()
        Me.cboCampo = New System.Windows.Forms.ComboBox()
        CType(Me.errorIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataListadoProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "PRECIO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "CANTIDAD"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "CATEGORIA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "NUM. DOCUMENTO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "NOMBRE"
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(153, 257)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(86, 30)
        Me.btnEditar.TabIndex = 9
        Me.btnEditar.Text = "Guardar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.Location = New System.Drawing.Point(285, 257)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(86, 30)
        Me.btnCancelar.TabIndex = 10
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(153, 257)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(86, 30)
        Me.btnGuardar.TabIndex = 8
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(18, 257)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(86, 30)
        Me.btnNuevo.TabIndex = 7
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'txtPrecio
        '
        Me.txtPrecio.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtPrecio.Enabled = False
        Me.txtPrecio.Location = New System.Drawing.Point(136, 170)
        Me.txtPrecio.MaxLength = 12
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 6
        '
        'txtCategoria
        '
        Me.txtCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtCategoria.Enabled = False
        Me.txtCategoria.Location = New System.Drawing.Point(136, 100)
        Me.txtCategoria.MaxLength = 50
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.ReadOnly = True
        Me.txtCategoria.Size = New System.Drawing.Size(127, 20)
        Me.txtCategoria.TabIndex = 3
        '
        'txtNumDocumento
        '
        Me.txtNumDocumento.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtNumDocumento.Enabled = False
        Me.txtNumDocumento.Location = New System.Drawing.Point(135, 65)
        Me.txtNumDocumento.MaxLength = 255
        Me.txtNumDocumento.Name = "txtNumDocumento"
        Me.txtNumDocumento.Size = New System.Drawing.Size(209, 20)
        Me.txtNumDocumento.TabIndex = 2
        '
        'txtNombreProducto
        '
        Me.txtNombreProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtNombreProducto.Enabled = False
        Me.txtNombreProducto.Location = New System.Drawing.Point(135, 30)
        Me.txtNombreProducto.MaxLength = 50
        Me.txtNombreProducto.Name = "txtNombreProducto"
        Me.txtNombreProducto.Size = New System.Drawing.Size(209, 20)
        Me.txtNombreProducto.TabIndex = 1
        '
        'txtIdProducto
        '
        Me.txtIdProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtIdProducto.Location = New System.Drawing.Point(343, 116)
        Me.txtIdProducto.Name = "txtIdProducto"
        Me.txtIdProducto.Size = New System.Drawing.Size(100, 20)
        Me.txtIdProducto.TabIndex = 0
        Me.txtIdProducto.Visible = False
        '
        'errorIcon
        '
        Me.errorIcon.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.errorIcon.ContainerControl = Me
        '
        'btnEliminar
        '
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.Location = New System.Drawing.Point(6, 355)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(86, 30)
        Me.btnEliminar.TabIndex = 14
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'checkEliminar
        '
        Me.checkEliminar.AutoSize = True
        Me.checkEliminar.Location = New System.Drawing.Point(6, 52)
        Me.checkEliminar.Name = "checkEliminar"
        Me.checkEliminar.Size = New System.Drawing.Size(121, 17)
        Me.checkEliminar.TabIndex = 2
        Me.checkEliminar.Text = "Habilitar Eliminar"
        Me.checkEliminar.UseVisualStyleBackColor = True
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'noDatos
        '
        Me.noDatos.AutoSize = True
        Me.noDatos.Location = New System.Drawing.Point(177, 203)
        Me.noDatos.Name = "noDatos"
        Me.noDatos.Size = New System.Drawing.Size(176, 13)
        Me.noDatos.TabIndex = 15
        Me.noDatos.TabStop = True
        Me.noDatos.Text = "No existen datos para mostrar"
        '
        'dataListadoProductos
        '
        Me.dataListadoProductos.AllowUserToAddRows = False
        Me.dataListadoProductos.AllowUserToDeleteRows = False
        Me.dataListadoProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataListadoProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.dataListadoProductos.Location = New System.Drawing.Point(7, 75)
        Me.dataListadoProductos.Name = "dataListadoProductos"
        Me.dataListadoProductos.ReadOnly = True
        Me.dataListadoProductos.Size = New System.Drawing.Size(446, 273)
        Me.dataListadoProductos.TabIndex = 16
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCantidad)
        Me.GroupBox1.Controls.Add(Me.txtIdCategoria)
        Me.GroupBox1.Controls.Add(Me.btnBuscarCat)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnEditar)
        Me.GroupBox1.Controls.Add(Me.btnCancelar)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Controls.Add(Me.btnNuevo)
        Me.GroupBox1.Controls.Add(Me.txtPrecio)
        Me.GroupBox1.Controls.Add(Me.txtCategoria)
        Me.GroupBox1.Controls.Add(Me.txtNumDocumento)
        Me.GroupBox1.Controls.Add(Me.txtNombreProducto)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox1.Location = New System.Drawing.Point(21, 139)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(428, 307)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento"
        '
        'txtCantidad
        '
        Me.txtCantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtCantidad.Location = New System.Drawing.Point(136, 135)
        Me.txtCantidad.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(47, 20)
        Me.txtCantidad.TabIndex = 4
        '
        'txtIdCategoria
        '
        Me.txtIdCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtIdCategoria.Location = New System.Drawing.Point(136, 100)
        Me.txtIdCategoria.MaxLength = 32454
        Me.txtIdCategoria.Name = "txtIdCategoria"
        Me.txtIdCategoria.Size = New System.Drawing.Size(36, 20)
        Me.txtIdCategoria.TabIndex = 26
        Me.txtIdCategoria.Visible = False
        '
        'btnBuscarCat
        '
        Me.btnBuscarCat.Enabled = False
        Me.btnBuscarCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarCat.Location = New System.Drawing.Point(269, 100)
        Me.btnBuscarCat.Name = "btnBuscarCat"
        Me.btnBuscarCat.Size = New System.Drawing.Size(28, 20)
        Me.btnBuscarCat.TabIndex = 4
        Me.btnBuscarCat.Text = "..."
        Me.btnBuscarCat.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBuscarCat.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnBuscar)
        Me.GroupBox2.Controls.Add(Me.txtABuscar)
        Me.GroupBox2.Controls.Add(Me.cboCampo)
        Me.GroupBox2.Controls.Add(Me.noDatos)
        Me.GroupBox2.Controls.Add(Me.dataListadoProductos)
        Me.GroupBox2.Controls.Add(Me.btnEliminar)
        Me.GroupBox2.Controls.Add(Me.checkEliminar)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox2.Location = New System.Drawing.Point(455, 41)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(459, 405)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lista de productos"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(271, 20)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(86, 30)
        Me.btnBuscar.TabIndex = 27
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtABuscar
        '
        Me.txtABuscar.Location = New System.Drawing.Point(134, 20)
        Me.txtABuscar.MaxLength = 100
        Me.txtABuscar.Name = "txtABuscar"
        Me.txtABuscar.Size = New System.Drawing.Size(131, 20)
        Me.txtABuscar.TabIndex = 18
        '
        'cboCampo
        '
        Me.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCampo.FormattingEnabled = True
        Me.cboCampo.Items.AddRange(New Object() {"nombre", "stock", "precio"})
        Me.cboCampo.Location = New System.Drawing.Point(7, 20)
        Me.cboCampo.Name = "cboCampo"
        Me.cboCampo.Size = New System.Drawing.Size(121, 21)
        Me.cboCampo.TabIndex = 17
        '
        'frmProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(922, 460)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtIdProducto)
        Me.MaximizeBox = False
        Me.Name = "frmProducto"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Listado de productos"
        CType(Me.errorIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataListadoProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtCategoria As TextBox
    Friend WithEvents txtNumDocumento As TextBox
    Friend WithEvents txtNombreProducto As TextBox
    Friend WithEvents txtIdProducto As TextBox
    Friend WithEvents errorIcon As ErrorProvider
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents noDatos As LinkLabel
    Friend WithEvents dataListadoProductos As DataGridView
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents btnEliminar As Button
    Friend WithEvents checkEliminar As CheckBox
    Friend WithEvents btnBuscarCat As Button
    Friend WithEvents txtIdCategoria As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtABuscar As TextBox
    Friend WithEvents cboCampo As ComboBox
    Friend WithEvents txtCantidad As NumericUpDown
End Class
