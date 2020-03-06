Imports System.Windows.Forms

Public Class frmInicio

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Ventana " & m_ChildFormNumber

        ChildForm.Show()
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SalirToolStripMenuItem.Click
        Dim respuesta As DialogResult
        respuesta = MessageBox.Show("¿Está seguro que quiere salir?", "Salir del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If respuesta = DialogResult.Yes Then
            Me.Close()
            frmLogin.Close()
            Application.ExitThread()
        End If
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub


    Private m_ChildFormNumber As Integer

    Private Sub InicioToolStripMenuItem_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub CategoríasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoríasToolStripMenuItem.Click
        frmCategoria.MdiParent = Me
        frmCategoria.Show()
    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem1.Click
        frmProducto.MdiParent = Me
        frmProducto.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        frmCliente.MdiParent = Me
        frmCliente.Show()
    End Sub

    Private Sub GenerarVentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerarVentaToolStripMenuItem.Click
        frmVenta.MdiParent = Me
        frmVenta.Show()
    End Sub

    Private Sub ReporteDeProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeProductosToolStripMenuItem.Click
        frmRptProductos.MdiParent = Me
        frmRptProductos.Show()
    End Sub

    Private Sub ReporteDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeClientesToolStripMenuItem.Click
        frmRptClientes.MdiParent = Me
        frmRptClientes.Show()
    End Sub

    Private Sub ConsultarVentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarVentasToolStripMenuItem.Click
        frmMuestraVentas.MdiParent = Me
        frmMuestraVentas.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblHora.Text = DateTime.Now
    End Sub

    Private Sub frmInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblHora.Text = DateTime.Now
    End Sub

    Private Sub frmInicio_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmLogin.Close()
        Application.ExitThread()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        frmUsuario.MdiParent = Me
        frmUsuario.Show()
    End Sub

    Private Sub InventarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventarioToolStripMenuItem.Click
        frmInventario.MdiParent = Me
        frmInventario.Show()
    End Sub
End Class
