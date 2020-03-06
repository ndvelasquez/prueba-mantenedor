<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCategoria
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
        Me.txtIdCategoria = New System.Windows.Forms.TextBox()
        Me.txtNombreCategoria = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.noDatos = New System.Windows.Forms.LinkLabel()
        Me.dataListadoCat = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.txtBuscarCat = New System.Windows.Forms.TextBox()
        Me.checkEliminarCat = New System.Windows.Forms.CheckBox()
        Me.errorIcon = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dataListadoCat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnEditar)
        Me.GroupBox1.Controls.Add(Me.btnCancelar)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Controls.Add(Me.btnNuevo)
        Me.GroupBox1.Controls.Add(Me.txtIdCategoria)
        Me.GroupBox1.Controls.Add(Me.txtNombreCategoria)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox1.Location = New System.Drawing.Point(12, 140)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(310, 239)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento"
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(116, 202)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 23)
        Me.btnEditar.TabIndex = 6
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.Location = New System.Drawing.Point(224, 202)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(116, 202)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 4
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(10, 202)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 3
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'txtIdCategoria
        '
        Me.txtIdCategoria.Location = New System.Drawing.Point(80, 57)
        Me.txtIdCategoria.Name = "txtIdCategoria"
        Me.txtIdCategoria.Size = New System.Drawing.Size(100, 20)
        Me.txtIdCategoria.TabIndex = 2
        Me.txtIdCategoria.Visible = False
        '
        'txtNombreCategoria
        '
        Me.txtNombreCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtNombreCategoria.Enabled = False
        Me.txtNombreCategoria.Location = New System.Drawing.Point(80, 30)
        Me.txtNombreCategoria.MaxLength = 100
        Me.txtNombreCategoria.Name = "txtNombreCategoria"
        Me.txtNombreCategoria.Size = New System.Drawing.Size(169, 20)
        Me.txtNombreCategoria.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.btnEliminar)
        Me.GroupBox2.Controls.Add(Me.noDatos)
        Me.GroupBox2.Controls.Add(Me.dataListadoCat)
        Me.GroupBox2.Controls.Add(Me.txtBuscarCat)
        Me.GroupBox2.Controls.Add(Me.checkEliminarCat)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox2.Location = New System.Drawing.Point(328, 59)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(435, 320)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado de categorías"
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(136, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.Location = New System.Drawing.Point(6, 283)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 5
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'noDatos
        '
        Me.noDatos.AutoSize = True
        Me.noDatos.Location = New System.Drawing.Point(121, 186)
        Me.noDatos.Name = "noDatos"
        Me.noDatos.Size = New System.Drawing.Size(156, 13)
        Me.noDatos.TabIndex = 4
        Me.noDatos.TabStop = True
        Me.noDatos.Text = "No hay datos para mostrar"
        '
        'dataListadoCat
        '
        Me.dataListadoCat.AllowUserToAddRows = False
        Me.dataListadoCat.AllowUserToDeleteRows = False
        Me.dataListadoCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataListadoCat.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.dataListadoCat.Location = New System.Drawing.Point(7, 81)
        Me.dataListadoCat.Name = "dataListadoCat"
        Me.dataListadoCat.ReadOnly = True
        Me.dataListadoCat.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dataListadoCat.Size = New System.Drawing.Size(422, 196)
        Me.dataListadoCat.TabIndex = 3
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'txtBuscarCat
        '
        Me.txtBuscarCat.Location = New System.Drawing.Point(7, 19)
        Me.txtBuscarCat.MaxLength = 100
        Me.txtBuscarCat.Name = "txtBuscarCat"
        Me.txtBuscarCat.Size = New System.Drawing.Size(123, 20)
        Me.txtBuscarCat.TabIndex = 2
        Me.txtBuscarCat.Text = "Ingrese el nombre a buscar"
        '
        'checkEliminarCat
        '
        Me.checkEliminarCat.AutoSize = True
        Me.checkEliminarCat.Location = New System.Drawing.Point(7, 52)
        Me.checkEliminarCat.Name = "checkEliminarCat"
        Me.checkEliminarCat.Size = New System.Drawing.Size(121, 17)
        Me.checkEliminarCat.TabIndex = 0
        Me.checkEliminarCat.Text = "Habilitar Eliminar"
        Me.checkEliminarCat.UseVisualStyleBackColor = True
        '
        'errorIcon
        '
        Me.errorIcon.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.errorIcon.ContainerControl = Me
        '
        'frmCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(775, 391)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "frmCategoria"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Listado de Categorías"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dataListadoCat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtIdCategoria As TextBox
    Friend WithEvents txtNombreCategoria As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents checkEliminarCat As CheckBox
    Friend WithEvents txtBuscarCat As TextBox
    Friend WithEvents dataListadoCat As DataGridView
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents noDatos As LinkLabel
    Friend WithEvents errorIcon As ErrorProvider
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Button1 As Button
End Class
