<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVenta
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAddCliente = New System.Windows.Forms.Button()
        Me.txtIdCliente = New System.Windows.Forms.TextBox()
        Me.txtDni = New System.Windows.Forms.TextBox()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.cmbCriterio = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbTipoComprobante = New System.Windows.Forms.ComboBox()
        Me.fechaVenta = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNumComprobante = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNombreProducto = New System.Windows.Forms.TextBox()
        Me.btnBuscaProducto = New System.Windows.Forms.Button()
        Me.txtIdProducto = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtCantidad = New System.Windows.Forms.NumericUpDown()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtPrecioU = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.gridProductos = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnGenerarVenta = New System.Windows.Forms.Button()
        Me.txtPrecioTotal = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtIGV = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtValorVenta = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ErrorIcon = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.ErrorIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAddCliente)
        Me.GroupBox1.Controls.Add(Me.txtIdCliente)
        Me.GroupBox1.Controls.Add(Me.txtDni)
        Me.GroupBox1.Controls.Add(Me.txtNombres)
        Me.GroupBox1.Controls.Add(Me.txtApellidos)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.txtBuscar)
        Me.GroupBox1.Controls.Add(Me.cmbCriterio)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(425, 171)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del cliente"
        '
        'btnAddCliente
        '
        Me.btnAddCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddCliente.Location = New System.Drawing.Point(281, 52)
        Me.btnAddCliente.Name = "btnAddCliente"
        Me.btnAddCliente.Size = New System.Drawing.Size(104, 21)
        Me.btnAddCliente.TabIndex = 10
        Me.btnAddCliente.Text = "Añadir Cliente"
        Me.btnAddCliente.UseVisualStyleBackColor = True
        '
        'txtIdCliente
        '
        Me.txtIdCliente.Location = New System.Drawing.Point(135, 146)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Size = New System.Drawing.Size(100, 20)
        Me.txtIdCliente.TabIndex = 9
        Me.txtIdCliente.Visible = False
        '
        'txtDni
        '
        Me.txtDni.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtDni.Location = New System.Drawing.Point(135, 60)
        Me.txtDni.MaxLength = 8
        Me.txtDni.Name = "txtDni"
        Me.txtDni.ReadOnly = True
        Me.txtDni.Size = New System.Drawing.Size(100, 20)
        Me.txtDni.TabIndex = 8
        '
        'txtNombres
        '
        Me.txtNombres.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtNombres.Location = New System.Drawing.Point(135, 90)
        Me.txtNombres.MaxLength = 100
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.ReadOnly = True
        Me.txtNombres.Size = New System.Drawing.Size(221, 20)
        Me.txtNombres.TabIndex = 7
        '
        'txtApellidos
        '
        Me.txtApellidos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtApellidos.Location = New System.Drawing.Point(135, 120)
        Me.txtApellidos.MaxLength = 100
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.ReadOnly = True
        Me.txtApellidos.Size = New System.Drawing.Size(221, 20)
        Me.txtApellidos.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "APELLIDOS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "NOMBRES"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "DNI"
        '
        'btnBuscar
        '
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.Location = New System.Drawing.Point(281, 20)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 21)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtBuscar.Location = New System.Drawing.Point(135, 20)
        Me.txtBuscar.MaxLength = 100
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(139, 20)
        Me.txtBuscar.TabIndex = 1
        '
        'cmbCriterio
        '
        Me.cmbCriterio.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmbCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCriterio.FormattingEnabled = True
        Me.cmbCriterio.Items.AddRange(New Object() {"dni", "nombres", "apellidos"})
        Me.cmbCriterio.Location = New System.Drawing.Point(7, 20)
        Me.cmbCriterio.Name = "cmbCriterio"
        Me.cmbCriterio.Size = New System.Drawing.Size(121, 21)
        Me.cmbCriterio.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbTipoComprobante)
        Me.GroupBox2.Controls.Add(Me.fechaVenta)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtNumComprobante)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox2.Location = New System.Drawing.Point(444, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(427, 90)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'cmbTipoComprobante
        '
        Me.cmbTipoComprobante.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.cmbTipoComprobante.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmbTipoComprobante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoComprobante.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbTipoComprobante.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoComprobante.FormattingEnabled = True
        Me.cmbTipoComprobante.Items.AddRange(New Object() {"BOLETA", "FACTURA"})
        Me.cmbTipoComprobante.Location = New System.Drawing.Point(10, 45)
        Me.cmbTipoComprobante.Name = "cmbTipoComprobante"
        Me.cmbTipoComprobante.Size = New System.Drawing.Size(121, 21)
        Me.cmbTipoComprobante.TabIndex = 10
        '
        'fechaVenta
        '
        Me.fechaVenta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechaVenta.Location = New System.Drawing.Point(297, 45)
        Me.fechaVenta.Name = "fechaVenta"
        Me.fechaVenta.Size = New System.Drawing.Size(98, 20)
        Me.fechaVenta.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(294, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Fecha"
        '
        'txtNumComprobante
        '
        Me.txtNumComprobante.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtNumComprobante.Location = New System.Drawing.Point(153, 45)
        Me.txtNumComprobante.MaxLength = 50
        Me.txtNumComprobante.Name = "txtNumComprobante"
        Me.txtNumComprobante.Size = New System.Drawing.Size(121, 20)
        Me.txtNumComprobante.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(150, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Num. Comprobante"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Tipo de comprobante"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtPrecio)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.txtStock)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.txtNombreProducto)
        Me.GroupBox3.Controls.Add(Me.btnBuscaProducto)
        Me.GroupBox3.Controls.Add(Me.txtIdProducto)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox3.Location = New System.Drawing.Point(13, 190)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(425, 100)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos del producto"
        '
        'txtPrecio
        '
        Me.txtPrecio.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtPrecio.Location = New System.Drawing.Point(325, 54)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.ReadOnly = True
        Me.txtPrecio.Size = New System.Drawing.Size(94, 20)
        Me.txtPrecio.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(264, 54)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 13)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "PRECIO"
        '
        'txtStock
        '
        Me.txtStock.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtStock.Location = New System.Drawing.Point(325, 22)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.ReadOnly = True
        Me.txtStock.Size = New System.Drawing.Size(31, 20)
        Me.txtStock.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(261, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "STOCK"
        '
        'txtNombreProducto
        '
        Me.txtNombreProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtNombreProducto.Location = New System.Drawing.Point(88, 55)
        Me.txtNombreProducto.MaxLength = 100
        Me.txtNombreProducto.Name = "txtNombreProducto"
        Me.txtNombreProducto.ReadOnly = True
        Me.txtNombreProducto.Size = New System.Drawing.Size(100, 20)
        Me.txtNombreProducto.TabIndex = 4
        '
        'btnBuscaProducto
        '
        Me.btnBuscaProducto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscaProducto.Location = New System.Drawing.Point(199, 25)
        Me.btnBuscaProducto.Name = "btnBuscaProducto"
        Me.btnBuscaProducto.Size = New System.Drawing.Size(36, 20)
        Me.btnBuscaProducto.TabIndex = 3
        Me.btnBuscaProducto.Text = "..."
        Me.btnBuscaProducto.UseVisualStyleBackColor = True
        '
        'txtIdProducto
        '
        Me.txtIdProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtIdProducto.Location = New System.Drawing.Point(88, 25)
        Me.txtIdProducto.Name = "txtIdProducto"
        Me.txtIdProducto.ReadOnly = True
        Me.txtIdProducto.Size = New System.Drawing.Size(100, 20)
        Me.txtIdProducto.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 55)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "NOMBRE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "CODIGO"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtCantidad)
        Me.GroupBox4.Controls.Add(Me.btnCancelar)
        Me.GroupBox4.Controls.Add(Me.btnAdd)
        Me.GroupBox4.Controls.Add(Me.txtPrecioU)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox4.Location = New System.Drawing.Point(13, 297)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(425, 73)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        '
        'txtCantidad
        '
        Me.txtCantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.ForeColor = System.Drawing.Color.Black
        Me.txtCantidad.Location = New System.Drawing.Point(88, 19)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(53, 20)
        Me.txtCantidad.TabIndex = 6
        '
        'btnCancelar
        '
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Location = New System.Drawing.Point(310, 47)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Location = New System.Drawing.Point(310, 18)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Agregar"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtPrecioU
        '
        Me.txtPrecioU.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtPrecioU.Location = New System.Drawing.Point(204, 20)
        Me.txtPrecioU.MaxLength = 10
        Me.txtPrecioU.Name = "txtPrecioU"
        Me.txtPrecioU.ReadOnly = True
        Me.txtPrecioU.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecioU.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(151, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "TOTAL"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(10, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "CANTIDAD"
        '
        'gridProductos
        '
        Me.gridProductos.AllowUserToAddRows = False
        Me.gridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.gridProductos.Location = New System.Drawing.Point(13, 376)
        Me.gridProductos.Name = "gridProductos"
        Me.gridProductos.ReadOnly = True
        Me.gridProductos.Size = New System.Drawing.Size(858, 169)
        Me.gridProductos.TabIndex = 4
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.UseColumnTextForButtonValue = True
        Me.Eliminar.Visible = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnGenerarVenta)
        Me.GroupBox5.Controls.Add(Me.txtPrecioTotal)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.txtIGV)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.txtSubTotal)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.txtDescuento)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.txtValorVenta)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox5.Location = New System.Drawing.Point(13, 551)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(858, 79)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Detalles de la venta"
        '
        'btnGenerarVenta
        '
        Me.btnGenerarVenta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenerarVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerarVenta.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnGenerarVenta.Location = New System.Drawing.Point(645, 19)
        Me.btnGenerarVenta.Name = "btnGenerarVenta"
        Me.btnGenerarVenta.Size = New System.Drawing.Size(122, 54)
        Me.btnGenerarVenta.TabIndex = 6
        Me.btnGenerarVenta.Text = "Generar Venta"
        Me.btnGenerarVenta.UseVisualStyleBackColor = True
        '
        'txtPrecioTotal
        '
        Me.txtPrecioTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtPrecioTotal.Location = New System.Drawing.Point(498, 44)
        Me.txtPrecioTotal.MaxLength = 50
        Me.txtPrecioTotal.Name = "txtPrecioTotal"
        Me.txtPrecioTotal.ReadOnly = True
        Me.txtPrecioTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecioTotal.TabIndex = 9
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(495, 26)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(105, 13)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "TOTAL A PAGAR"
        '
        'txtIGV
        '
        Me.txtIGV.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtIGV.Location = New System.Drawing.Point(380, 44)
        Me.txtIGV.MaxLength = 50
        Me.txtIGV.Name = "txtIGV"
        Me.txtIGV.ReadOnly = True
        Me.txtIGV.Size = New System.Drawing.Size(100, 20)
        Me.txtIGV.TabIndex = 7
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(406, 26)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(36, 13)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "I.G.V"
        '
        'txtSubTotal
        '
        Me.txtSubTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtSubTotal.Location = New System.Drawing.Point(256, 44)
        Me.txtSubTotal.MaxLength = 50
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtSubTotal.TabIndex = 5
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(264, 26)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(76, 13)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "SUB TOTAL"
        '
        'txtDescuento
        '
        Me.txtDescuento.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtDescuento.Location = New System.Drawing.Point(135, 44)
        Me.txtDescuento.MaxLength = 10
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(100, 20)
        Me.txtDescuento.TabIndex = 3
        Me.txtDescuento.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(136, 26)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(83, 13)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "DESCUENTO"
        '
        'txtValorVenta
        '
        Me.txtValorVenta.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtValorVenta.Location = New System.Drawing.Point(10, 44)
        Me.txtValorVenta.MaxLength = 50
        Me.txtValorVenta.Name = "txtValorVenta"
        Me.txtValorVenta.ReadOnly = True
        Me.txtValorVenta.Size = New System.Drawing.Size(100, 20)
        Me.txtValorVenta.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(10, 26)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(93, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "VALOR VENTA"
        '
        'ErrorIcon
        '
        Me.ErrorIcon.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorIcon.ContainerControl = Me
        '
        'frmVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(883, 645)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.gridProductos)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmVenta"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Venta de Productos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.ErrorIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtDni As TextBox
    Friend WithEvents txtNombres As TextBox
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents cmbCriterio As ComboBox
    Friend WithEvents txtIdCliente As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents fechaVenta As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNumComprobante As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtStock As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtNombreProducto As TextBox
    Friend WithEvents btnBuscaProducto As Button
    Friend WithEvents txtIdProducto As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtPrecioU As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents gridProductos As DataGridView
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btnGenerarVenta As Button
    Friend WithEvents txtPrecioTotal As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtIGV As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtSubTotal As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtDescuento As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtValorVenta As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Eliminar As DataGridViewButtonColumn
    Friend WithEvents ErrorIcon As ErrorProvider
    Friend WithEvents txtCantidad As NumericUpDown
    Friend WithEvents cmbTipoComprobante As ComboBox
    Friend WithEvents btnAddCliente As Button
End Class
