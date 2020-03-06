<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuario
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
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.chkEstatus = New System.Windows.Forms.CheckBox()
        Me.txtIdUsu = New System.Windows.Forms.TextBox()
        Me.txtDniUsu = New System.Windows.Forms.TextBox()
        Me.txtNombresUsu = New System.Windows.Forms.TextBox()
        Me.txtApellidosUsu = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.chkEliminar = New System.Windows.Forms.CheckBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.lblNoDatos = New System.Windows.Forms.LinkLabel()
        Me.gridUsuarios = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.cboCampo = New System.Windows.Forms.ComboBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.gridUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnEditar)
        Me.GroupBox1.Controls.Add(Me.btnCancelar)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Controls.Add(Me.btnNuevo)
        Me.GroupBox1.Controls.Add(Me.chkEstatus)
        Me.GroupBox1.Controls.Add(Me.txtIdUsu)
        Me.GroupBox1.Controls.Add(Me.txtDniUsu)
        Me.GroupBox1.Controls.Add(Me.txtNombresUsu)
        Me.GroupBox1.Controls.Add(Me.txtApellidosUsu)
        Me.GroupBox1.Controls.Add(Me.txtUsername)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox1.Location = New System.Drawing.Point(12, 125)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(400, 306)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento"
        '
        'btnEditar
        '
        Me.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditar.Location = New System.Drawing.Point(133, 262)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(86, 30)
        Me.btnEditar.TabIndex = 9
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        Me.btnEditar.Visible = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.Location = New System.Drawing.Point(248, 262)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(86, 30)
        Me.btnCancelar.TabIndex = 10
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.Location = New System.Drawing.Point(133, 262)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(86, 30)
        Me.btnGuardar.TabIndex = 8
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevo.Location = New System.Drawing.Point(22, 262)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(86, 30)
        Me.btnNuevo.TabIndex = 7
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'chkEstatus
        '
        Me.chkEstatus.AutoSize = True
        Me.chkEstatus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkEstatus.Enabled = False
        Me.chkEstatus.Location = New System.Drawing.Point(9, 196)
        Me.chkEstatus.Name = "chkEstatus"
        Me.chkEstatus.Size = New System.Drawing.Size(71, 17)
        Me.chkEstatus.TabIndex = 6
        Me.chkEstatus.Text = "ACTIVO"
        Me.chkEstatus.UseVisualStyleBackColor = True
        '
        'txtIdUsu
        '
        Me.txtIdUsu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtIdUsu.Location = New System.Drawing.Point(342, 19)
        Me.txtIdUsu.Name = "txtIdUsu"
        Me.txtIdUsu.Size = New System.Drawing.Size(52, 20)
        Me.txtIdUsu.TabIndex = 11
        Me.txtIdUsu.Visible = False
        '
        'txtDniUsu
        '
        Me.txtDniUsu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtDniUsu.Enabled = False
        Me.txtDniUsu.Location = New System.Drawing.Point(104, 30)
        Me.txtDniUsu.MaxLength = 8
        Me.txtDniUsu.Name = "txtDniUsu"
        Me.txtDniUsu.Size = New System.Drawing.Size(190, 20)
        Me.txtDniUsu.TabIndex = 1
        '
        'txtNombresUsu
        '
        Me.txtNombresUsu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtNombresUsu.Enabled = False
        Me.txtNombresUsu.Location = New System.Drawing.Point(104, 65)
        Me.txtNombresUsu.MaxLength = 100
        Me.txtNombresUsu.Name = "txtNombresUsu"
        Me.txtNombresUsu.Size = New System.Drawing.Size(190, 20)
        Me.txtNombresUsu.TabIndex = 2
        '
        'txtApellidosUsu
        '
        Me.txtApellidosUsu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtApellidosUsu.Enabled = False
        Me.txtApellidosUsu.Location = New System.Drawing.Point(104, 100)
        Me.txtApellidosUsu.MaxLength = 100
        Me.txtApellidosUsu.Name = "txtApellidosUsu"
        Me.txtApellidosUsu.Size = New System.Drawing.Size(190, 20)
        Me.txtApellidosUsu.TabIndex = 3
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtUsername.Enabled = False
        Me.txtUsername.Location = New System.Drawing.Point(104, 135)
        Me.txtUsername.MaxLength = 100
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(190, 20)
        Me.txtUsername.TabIndex = 4
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtPassword.Enabled = False
        Me.txtPassword.Location = New System.Drawing.Point(104, 170)
        Me.txtPassword.MaxLength = 100
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(190, 20)
        Me.txtPassword.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "CONTRASEÑA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "USUARIO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "APELLIDOS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NOMBRES"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DNI"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnBuscar)
        Me.GroupBox2.Controls.Add(Me.chkEliminar)
        Me.GroupBox2.Controls.Add(Me.btnEliminar)
        Me.GroupBox2.Controls.Add(Me.lblNoDatos)
        Me.GroupBox2.Controls.Add(Me.gridUsuarios)
        Me.GroupBox2.Controls.Add(Me.txtBuscar)
        Me.GroupBox2.Controls.Add(Me.cboCampo)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox2.Location = New System.Drawing.Point(418, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(492, 404)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado de usuarios"
        '
        'btnBuscar
        '
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.Enabled = False
        Me.btnBuscar.Location = New System.Drawing.Point(300, 14)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(86, 30)
        Me.btnBuscar.TabIndex = 12
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'chkEliminar
        '
        Me.chkEliminar.AutoSize = True
        Me.chkEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkEliminar.Location = New System.Drawing.Point(7, 47)
        Me.chkEliminar.Name = "chkEliminar"
        Me.chkEliminar.Size = New System.Drawing.Size(121, 17)
        Me.chkEliminar.TabIndex = 13
        Me.chkEliminar.Text = "Habilitar Eliminar"
        Me.chkEliminar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.Location = New System.Drawing.Point(7, 368)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(86, 30)
        Me.btnEliminar.TabIndex = 17
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'lblNoDatos
        '
        Me.lblNoDatos.AutoSize = True
        Me.lblNoDatos.Location = New System.Drawing.Point(166, 189)
        Me.lblNoDatos.Name = "lblNoDatos"
        Me.lblNoDatos.Size = New System.Drawing.Size(176, 13)
        Me.lblNoDatos.TabIndex = 3
        Me.lblNoDatos.TabStop = True
        Me.lblNoDatos.Text = "No existen datos para mostrar"
        '
        'gridUsuarios
        '
        Me.gridUsuarios.AllowUserToAddRows = False
        Me.gridUsuarios.AllowUserToDeleteRows = False
        Me.gridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.gridUsuarios.Location = New System.Drawing.Point(7, 68)
        Me.gridUsuarios.Name = "gridUsuarios"
        Me.gridUsuarios.ReadOnly = True
        Me.gridUsuarios.Size = New System.Drawing.Size(479, 294)
        Me.gridUsuarios.TabIndex = 2
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'txtBuscar
        '
        Me.txtBuscar.Enabled = False
        Me.txtBuscar.Location = New System.Drawing.Point(135, 20)
        Me.txtBuscar.MaxLength = 100
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(147, 20)
        Me.txtBuscar.TabIndex = 11
        '
        'cboCampo
        '
        Me.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCampo.FormattingEnabled = True
        Me.cboCampo.Items.AddRange(New Object() {"dni", "nombres", "apellidos", "username", "password", "estatus"})
        Me.cboCampo.Location = New System.Drawing.Point(7, 20)
        Me.cboCampo.Name = "cboCampo"
        Me.cboCampo.Size = New System.Drawing.Size(121, 21)
        Me.cboCampo.TabIndex = 0
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(922, 443)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "frmUsuario"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Mantenedor de usuarios"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.gridUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnNuevo As Button
    Friend WithEvents chkEstatus As CheckBox
    Friend WithEvents txtIdUsu As TextBox
    Friend WithEvents txtDniUsu As TextBox
    Friend WithEvents txtNombresUsu As TextBox
    Friend WithEvents txtApellidosUsu As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents cboCampo As ComboBox
    Friend WithEvents gridUsuarios As DataGridView
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents lblNoDatos As LinkLabel
    Friend WithEvents chkEliminar As CheckBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents btnBuscar As Button
End Class
