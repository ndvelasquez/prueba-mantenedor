<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInicio
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInicio))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoríasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblHora = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.InventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosToolStripMenuItem, Me.VentaToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.ConfiguraciónToolStripMenuItem, Me.InventarioToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(789, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CategoríasToolStripMenuItem, Me.ProductosToolStripMenuItem1})
        Me.ProductosToolStripMenuItem.Image = CType(resources.GetObject("ProductosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'CategoríasToolStripMenuItem
        '
        Me.CategoríasToolStripMenuItem.Image = CType(resources.GetObject("CategoríasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CategoríasToolStripMenuItem.Name = "CategoríasToolStripMenuItem"
        Me.CategoríasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CategoríasToolStripMenuItem.Text = "Categorías"
        '
        'ProductosToolStripMenuItem1
        '
        Me.ProductosToolStripMenuItem1.Image = CType(resources.GetObject("ProductosToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ProductosToolStripMenuItem1.Name = "ProductosToolStripMenuItem1"
        Me.ProductosToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.ProductosToolStripMenuItem1.Text = "Productos"
        '
        'VentaToolStripMenuItem
        '
        Me.VentaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.GenerarVentaToolStripMenuItem, Me.ConsultarVentasToolStripMenuItem})
        Me.VentaToolStripMenuItem.Image = CType(resources.GetObject("VentaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.VentaToolStripMenuItem.Name = "VentaToolStripMenuItem"
        Me.VentaToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.VentaToolStripMenuItem.Text = "Venta"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Image = CType(resources.GetObject("ClientesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'GenerarVentaToolStripMenuItem
        '
        Me.GenerarVentaToolStripMenuItem.Image = CType(resources.GetObject("GenerarVentaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GenerarVentaToolStripMenuItem.Name = "GenerarVentaToolStripMenuItem"
        Me.GenerarVentaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.GenerarVentaToolStripMenuItem.Text = "Generar venta"
        '
        'ConsultarVentasToolStripMenuItem
        '
        Me.ConsultarVentasToolStripMenuItem.Image = CType(resources.GetObject("ConsultarVentasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ConsultarVentasToolStripMenuItem.Name = "ConsultarVentasToolStripMenuItem"
        Me.ConsultarVentasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ConsultarVentasToolStripMenuItem.Text = "Consultar ventas"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReporteDeProductosToolStripMenuItem, Me.ReporteDeClientesToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Image = CType(resources.GetObject("ReportesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'ReporteDeProductosToolStripMenuItem
        '
        Me.ReporteDeProductosToolStripMenuItem.Image = CType(resources.GetObject("ReporteDeProductosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ReporteDeProductosToolStripMenuItem.Name = "ReporteDeProductosToolStripMenuItem"
        Me.ReporteDeProductosToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.ReporteDeProductosToolStripMenuItem.Text = "Reporte de productos"
        '
        'ReporteDeClientesToolStripMenuItem
        '
        Me.ReporteDeClientesToolStripMenuItem.Image = CType(resources.GetObject("ReporteDeClientesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ReporteDeClientesToolStripMenuItem.Name = "ReporteDeClientesToolStripMenuItem"
        Me.ReporteDeClientesToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.ReporteDeClientesToolStripMenuItem.Text = "Reporte de clientes"
        '
        'ConfiguraciónToolStripMenuItem
        '
        Me.ConfiguraciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuariosToolStripMenuItem})
        Me.ConfiguraciónToolStripMenuItem.Image = CType(resources.GetObject("ConfiguraciónToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ConfiguraciónToolStripMenuItem.Name = "ConfiguraciónToolStripMenuItem"
        Me.ConfiguraciónToolStripMenuItem.Size = New System.Drawing.Size(111, 20)
        Me.ConfiguraciónToolStripMenuItem.Text = "Configuración"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Image = CType(resources.GetObject("UsuariosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Image = CType(resources.GetObject("SalirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.BackColor = System.Drawing.Color.Transparent
        Me.lblHora.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblHora.Location = New System.Drawing.Point(12, 35)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(172, 22)
        Me.lblHora.TabIndex = 7
        Me.lblHora.Text = "Formato de la fecha"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'InventarioToolStripMenuItem
        '
        Me.InventarioToolStripMenuItem.Image = Global.prueba_sistema.My.Resources.Resources.orden
        Me.InventarioToolStripMenuItem.Name = "InventarioToolStripMenuItem"
        Me.InventarioToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.InventarioToolStripMenuItem.Text = "Inventario"
        '
        'frmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(789, 453)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.MenuStrip)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "frmInicio"
        Me.Text = "Sistema de ventas"
        Me.TransparencyKey = System.Drawing.Color.White
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CategoríasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents VentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GenerarVentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteDeProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteDeClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfiguraciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarVentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblHora As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents InventarioToolStripMenuItem As ToolStripMenuItem
End Class
