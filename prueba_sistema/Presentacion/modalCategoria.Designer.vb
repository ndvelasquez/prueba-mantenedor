<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class modalCategoria
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dataListadoCat = New System.Windows.Forms.DataGridView()
        Me.txtFlag = New System.Windows.Forms.TextBox()
        CType(Me.dataListadoCat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataListadoCat
        '
        Me.dataListadoCat.AllowUserToAddRows = False
        Me.dataListadoCat.AllowUserToDeleteRows = False
        Me.dataListadoCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataListadoCat.Location = New System.Drawing.Point(12, 36)
        Me.dataListadoCat.Name = "dataListadoCat"
        Me.dataListadoCat.ReadOnly = True
        Me.dataListadoCat.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dataListadoCat.Size = New System.Drawing.Size(286, 287)
        Me.dataListadoCat.TabIndex = 4
        '
        'txtFlag
        '
        Me.txtFlag.Location = New System.Drawing.Point(13, 13)
        Me.txtFlag.MaxLength = 1
        Me.txtFlag.Name = "txtFlag"
        Me.txtFlag.Size = New System.Drawing.Size(24, 20)
        Me.txtFlag.TabIndex = 5
        Me.txtFlag.Visible = False
        '
        'modalCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(310, 335)
        Me.Controls.Add(Me.txtFlag)
        Me.Controls.Add(Me.dataListadoCat)
        Me.MaximizeBox = False
        Me.Name = "modalCategoria"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Listado de Categorías"
        CType(Me.dataListadoCat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dataListadoCat As DataGridView
    Friend WithEvents txtFlag As TextBox
End Class
