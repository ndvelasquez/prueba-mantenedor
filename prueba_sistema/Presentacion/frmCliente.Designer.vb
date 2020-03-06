<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCliente
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.noDatos = New System.Windows.Forms.LinkLabel()
        Me.dataListado = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.checkEliminar = New System.Windows.Forms.CheckBox()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.comboDatoAFiltrar = New System.Windows.Forms.ComboBox()
        Me.errorIcon = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.txtDni = New System.Windows.Forms.TextBox()
        Me.txtIdCliente = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dataListado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnBuscar)
        Me.GroupBox2.Controls.Add(Me.noDatos)
        Me.GroupBox2.Controls.Add(Me.dataListado)
        Me.GroupBox2.Controls.Add(Me.btnEliminar)
        Me.GroupBox2.Controls.Add(Me.checkEliminar)
        Me.GroupBox2.Controls.Add(Me.txtBuscar)
        Me.GroupBox2.Controls.Add(Me.comboDatoAFiltrar)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox2.Location = New System.Drawing.Point(447, 61)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(459, 405)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lista de clientes"
        '
        'btnBuscar
        '
        Me.btnBuscar.Enabled = False
        Me.btnBuscar.Location = New System.Drawing.Point(308, 20)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(86, 30)
        Me.btnBuscar.TabIndex = 17
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
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
        'dataListado
        '
        Me.dataListado.AllowUserToAddRows = False
        Me.dataListado.AllowUserToDeleteRows = False
        Me.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataListado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.dataListado.Location = New System.Drawing.Point(7, 70)
        Me.dataListado.Name = "dataListado"
        Me.dataListado.ReadOnly = True
        Me.dataListado.Size = New System.Drawing.Size(446, 278)
        Me.dataListado.TabIndex = 16
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
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
        Me.checkEliminar.Location = New System.Drawing.Point(7, 47)
        Me.checkEliminar.Name = "checkEliminar"
        Me.checkEliminar.Size = New System.Drawing.Size(121, 17)
        Me.checkEliminar.TabIndex = 2
        Me.checkEliminar.Text = "Habilitar Eliminar"
        Me.checkEliminar.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(134, 21)
        Me.txtBuscar.MaxLength = 50
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(168, 20)
        Me.txtBuscar.TabIndex = 1
        '
        'comboDatoAFiltrar
        '
        Me.comboDatoAFiltrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboDatoAFiltrar.FormattingEnabled = True
        Me.comboDatoAFiltrar.Items.AddRange(New Object() {"dni", "nombres", "apelllidos"})
        Me.comboDatoAFiltrar.Location = New System.Drawing.Point(7, 20)
        Me.comboDatoAFiltrar.Name = "comboDatoAFiltrar"
        Me.comboDatoAFiltrar.Size = New System.Drawing.Size(121, 21)
        Me.comboDatoAFiltrar.TabIndex = 0
        '
        'errorIcon
        '
        Me.errorIcon.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.errorIcon.ContainerControl = Me
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnEditar)
        Me.GroupBox1.Controls.Add(Me.btnCancelar)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Controls.Add(Me.btnNuevo)
        Me.GroupBox1.Controls.Add(Me.txtDireccion)
        Me.GroupBox1.Controls.Add(Me.txtTelefono)
        Me.GroupBox1.Controls.Add(Me.txtApellidos)
        Me.GroupBox1.Controls.Add(Me.txtNombres)
        Me.GroupBox1.Controls.Add(Me.txtDni)
        Me.GroupBox1.Controls.Add(Me.txtIdCliente)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox1.Location = New System.Drawing.Point(13, 159)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(428, 307)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "DIRECCION"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "TELEFONO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "APELLIDOS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "NOMBRES"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "DNI"
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(153, 257)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(86, 30)
        Me.btnEditar.TabIndex = 19
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.Location = New System.Drawing.Point(285, 257)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(86, 30)
        Me.btnCancelar.TabIndex = 18
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(153, 257)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(86, 30)
        Me.btnGuardar.TabIndex = 17
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(18, 257)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(86, 30)
        Me.btnNuevo.TabIndex = 16
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'txtDireccion
        '
        Me.txtDireccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtDireccion.Enabled = False
        Me.txtDireccion.Location = New System.Drawing.Point(94, 170)
        Me.txtDireccion.MaxLength = 255
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(209, 54)
        Me.txtDireccion.TabIndex = 5
        '
        'txtTelefono
        '
        Me.txtTelefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtTelefono.Enabled = False
        Me.txtTelefono.Location = New System.Drawing.Point(94, 135)
        Me.txtTelefono.MaxLength = 20
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(100, 20)
        Me.txtTelefono.TabIndex = 4
        '
        'txtApellidos
        '
        Me.txtApellidos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtApellidos.Enabled = False
        Me.txtApellidos.Location = New System.Drawing.Point(94, 100)
        Me.txtApellidos.MaxLength = 50
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(209, 20)
        Me.txtApellidos.TabIndex = 3
        '
        'txtNombres
        '
        Me.txtNombres.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtNombres.Enabled = False
        Me.txtNombres.Location = New System.Drawing.Point(94, 65)
        Me.txtNombres.MaxLength = 50
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(209, 20)
        Me.txtNombres.TabIndex = 2
        '
        'txtDni
        '
        Me.txtDni.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtDni.Enabled = False
        Me.txtDni.Location = New System.Drawing.Point(94, 30)
        Me.txtDni.MaxLength = 8
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(100, 20)
        Me.txtDni.TabIndex = 1
        '
        'txtIdCliente
        '
        Me.txtIdCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtIdCliente.Location = New System.Drawing.Point(322, 19)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Size = New System.Drawing.Size(100, 20)
        Me.txtIdCliente.TabIndex = 0
        Me.txtIdCliente.Visible = False
        '
        'frmCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(918, 478)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.MaximizeBox = False
        Me.Name = "frmCliente"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Listado de Clientes"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dataListado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents checkEliminar As CheckBox
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents comboDatoAFiltrar As ComboBox
    Friend WithEvents noDatos As LinkLabel
    Friend WithEvents errorIcon As ErrorProvider
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents txtNombres As TextBox
    Friend WithEvents txtDni As TextBox
    Friend WithEvents txtIdCliente As TextBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents dataListado As DataGridView
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBuscar As Button
End Class
