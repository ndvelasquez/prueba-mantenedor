Public Class frmProducto
    Private dt As DataTable 'para guardar la tabla en memoria
    Dim fValidaciones As New validaMetodos
    Private Sub frmProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub
    Private Sub mostrar()
        Try
            Dim funciones_producto As New fProducto
            dt = New DataTable()
            dt = funciones_producto.mostrar
            dataListadoProductos.Columns.Item("Eliminar").Visible = False

            If dt.Rows.Count <> 0 Then
                dataListadoProductos.DataSource = dt
                dataListadoProductos.Columns.Item("id_producto").Visible = False
                dataListadoProductos.Columns.Item("id_categoria").Visible = False
                dataListadoProductos.ColumnHeadersVisible = True
                noDatos.Visible = False
                cboCampo.Enabled = True
                txtABuscar.Enabled = True
            Else
                dataListadoProductos.DataSource = Nothing
                dataListadoProductos.ColumnHeadersVisible = False
                cboCampo.Enabled = False
                txtABuscar.Enabled = False
                noDatos.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        btnNuevo.Visible = True
        btnGuardar.Visible = True
        btnEditar.Visible = False
    End Sub
    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            dv.RowFilter = cboCampo.Text & " like '%" & txtABuscar.Text & "%'"

            If dv.Count <> 0 Then
                dataListadoProductos.DataSource = dv
                noDatos.Visible = False
            Else
                dataListadoProductos.DataSource = Nothing
                noDatos.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub limpiar()
        txtIdProducto.Text = ""
        txtIdCategoria.Text = ""
        txtNombreProducto.Text = ""
        txtNumDocumento.Text = ""
        txtCategoria.Text = ""
        txtCantidad.Text = "0"
        txtPrecio.Text = ""
        txtIdProducto.Enabled = False
        txtIdCategoria.Enabled = False
        txtNombreProducto.Enabled = False
        txtNumDocumento.Enabled = False
        txtCategoria.Enabled = False
        txtCantidad.Enabled = False
        txtPrecio.Enabled = False
        btnEditar.Visible = False
        btnGuardar.Visible = True
        btnCancelar.Enabled = False
        btnNuevo.Enabled = True
        checkEliminar.Checked = False
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtIdProducto.Enabled = True
        txtIdCategoria.Enabled = True
        txtNombreProducto.Enabled = True
        txtNumDocumento.Enabled = True
        txtCategoria.Enabled = True
        txtCantidad.Enabled = True
        txtPrecio.Enabled = True
        btnCancelar.Enabled = True
        btnNuevo.Enabled = False
        btnBuscarCat.Enabled = True
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Me.ValidateChildren = True And txtNombreProducto.Text <> "" And txtNumDocumento.Text <> "" And txtCategoria.Text <> "" And txtIdCategoria.Text <> "" And txtCantidad.Text <> "" And txtPrecio.Text <> "" Then
            Try
                Dim dts As New vproducto
                Dim funciones_producto As New fProducto
                Dim mensaje As String
                dts.gidcategoria = txtIdCategoria.Text
                dts.gnombreproducto = txtNombreProducto.Text
                dts.gnumDocumento = txtNumDocumento.Text
                dts.gcantidad = txtCantidad.Text
                dts.gprecio = txtPrecio.Text

                If funciones_producto.insertar(dts, mensaje) Then
                    Dim msg As String = mensaje
                    If msg <> "Null" Then
                        MessageBox.Show(msg, "Crear Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                    MessageBox.Show("Producto creado con éxito", "Crear Producto", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                    Else
                        MessageBox.Show("Producto no guardado", "Crear Producto", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()
                    limpiar()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Por favor ingresar los datos correctos", "Ingresar Producto", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        mostrar()
        limpiar()
    End Sub

    Private Sub dataListadoProductos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataListadoProductos.CellContentClick
        If e.ColumnIndex = Me.dataListadoProductos.Columns.Item("Eliminar").Index Then
            Dim chkCell As DataGridViewCheckBoxCell = Me.dataListadoProductos.Rows(e.RowIndex).Cells("Eliminar")
            chkCell.Value = Not chkCell.Value
        End If
    End Sub

    'Declaracion de variables para almacenar datos de una tabla a los campos del formulario
    Dim idProductoText, idCategoriaText As Integer
    Dim nombreProductoText, nombreCategoriaText, precioText As String

    Private Sub txtNombreProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombreProducto.KeyPress
        fValidaciones.LetrasYNumeros(e)
    End Sub

    Private Sub txtNumDocumento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumDocumento.KeyPress
        fValidaciones.soloNumeros(e)
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        fValidaciones.soloNumeros(e)
    End Sub

    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio.KeyPress
        fValidaciones.soloNumeros(e)
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        buscar()
    End Sub

    Private Sub btnBuscarCat_Click(sender As Object, e As EventArgs) Handles btnBuscarCat.Click
        modalCategoria.txtFlag.Text = "1"
        modalCategoria.ShowDialog()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim resultado As DialogResult
        resultado = MessageBox.Show("¿Realmente desea eliminar los registros seleccionados?", "Eliminar Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resultado = DialogResult.Yes Then
            Try
                For Each row As DataGridViewRow In dataListadoProductos.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                    If marcado Then
                        Dim llavePrimaria As Integer = Convert.ToInt32(row.Cells("id_producto").Value)
                        Dim dts As New vproducto
                        Dim funciones_producto As New fProducto

                        dts.gidproducto = llavePrimaria

                        If funciones_producto.eliminar(dts) Then

                        Else
                            MessageBox.Show("Producto(s) no eliminado(s)", "Eliminar Producto", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End If
                Next
                Call mostrar()
                Call limpiar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Eliminación cancelada")
            Call mostrar()
            Call limpiar()
        End If
    End Sub

    Private Sub checkEliminar_CheckedChanged(sender As Object, e As EventArgs) Handles checkEliminar.CheckedChanged
        If checkEliminar.CheckState = CheckState.Checked Then
            dataListadoProductos.Columns.Item("Eliminar").Visible = True
            btnEliminar.Enabled = True
        Else
            dataListadoProductos.Columns.Item("Eliminar").Visible = False
            btnEliminar.Enabled = False
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim resultado As DialogResult
        resultado = MessageBox.Show("¿Desea guardar los datos del producto?", "Modificar Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resultado = DialogResult.Yes Then
            Try
                Dim dts As New vproducto
                Dim funciones_producto As New fProducto
                Dim mensaje As String

                dts.gidproducto = txtIdProducto.Text
                dts.gidcategoria = txtIdCategoria.Text
                dts.gnombreproducto = txtNombreProducto.Text
                dts.gnumDocumento = txtNumDocumento.Text
                dts.gcantidad = txtCantidad.Text
                dts.gprecio = txtPrecio.Text

                If funciones_producto.editar(dts, mensaje) Then
                    Dim msg As String = mensaje
                    If msg <> "Null" Then
                        MessageBox.Show(msg, "Modificar Producto", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                    MessageBox.Show("Producto guardado con éxito", "Modificar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("Producto no guardado", "Modificar Producto", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()
                    limpiar()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub dataListadoProductos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataListadoProductos.CellClick
        If dataListadoProductos.Rows.Count > 0 Then
            idProductoText = dataListadoProductos.Rows(e.RowIndex).Cells("id_producto").Value
            idCategoriaText = dataListadoProductos.Rows(e.RowIndex).Cells("id_categoria").Value.ToString()
            nombreProductoText = dataListadoProductos.Rows(e.RowIndex).Cells("nombre").Value.ToString()
            nombreCategoriaText = dataListadoProductos.Rows(e.RowIndex).Cells("categoria").Value.ToString
            precioText = dataListadoProductos.Rows(e.RowIndex).Cells("precio").Value.ToString()

            txtIdProducto.Text = idProductoText
            txtIdCategoria.Text = idCategoriaText
            txtNombreProducto.Text = nombreProductoText
            txtCategoria.Text = nombreCategoriaText
            txtPrecio.Text = precioText

            txtIdProducto.Enabled = True
            txtIdCategoria.Enabled = True
            txtNombreProducto.Enabled = True
            txtNumDocumento.Enabled = True
            txtCategoria.Enabled = True
            txtCantidad.Enabled = True
            txtPrecio.Enabled = True
            btnCancelar.Enabled = True
            btnNuevo.Enabled = False
            btnEditar.Visible = True
            btnGuardar.Visible = False
        End If
    End Sub

End Class