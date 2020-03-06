Public Class frmVenta
    Dim dt As New DataTable
    Dim fValidaciones As New validaMetodos
    Private Sub ActualizaDatosVenta()
        txtValorVenta.Text = AcumuladorVenta
        txtSubTotal.Text = subTotal
        txtIGV.Text = igv
        txtPrecioTotal.Text = precioTotal
        If txtDescuento.Text <> "" Then
            txtValorVenta.Text = AcumuladorVenta
            txtSubTotal.Text = subTotal
            txtIGV.Text = igv
            txtPrecioTotal.Text = precioTotal
        Else
            txtValorVenta.Text = AcumuladorVenta
            txtSubTotal.Text = subTotal
            txtIGV.Text = igv
            txtPrecioTotal.Text = precioTotal
        End If
    End Sub


    Private Sub frmVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dt.Columns.Add("id_producto")
        dt.Columns.Add("Nombre")
        dt.Columns.Add("cantidad")
        dt.Columns.Add("precio_unitario")
    End Sub

    Private Sub btnBuscaProducto_Click(sender As Object, e As EventArgs) Handles btnBuscaProducto.Click
        modalProductos.txtFlag.Text = "1"
        modalProductos.ShowDialog()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        modalClientes.txtFlag.Text = "1"
        modalClientes.ShowDialog()
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs)
        fValidaciones.soloNumeros(e)
    End Sub

    Private Sub txtNumComprobante_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumComprobante.KeyPress
        fValidaciones.soloNumeros(e)
    End Sub

    'Variables para calcular descuento, subtotal, igv y precio total
    Dim valorVenta, subTotal, igv, precioTotal, AcumuladorVenta As Decimal
    Dim valorDescuento As Integer
    Dim descuento As Decimal

    Private Sub gridProductos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridProductos.CellContentClick
        If gridProductos.Columns(e.ColumnIndex).Name = "Eliminar" Then
            AcumuladorVenta = AcumuladorVenta - gridProductos.CurrentRow.Cells.Item("precio_unitario").Value
            valorVenta = AcumuladorVenta
            igv = valorVenta * (18 / 100)
            subTotal = valorVenta - igv
            precioTotal = subTotal + igv
            gridProductos.Rows.Remove(gridProductos.CurrentRow)
            ActualizaDatosVenta()
        End If
    End Sub

    Private Sub btnGenerarVenta_Click(sender As Object, e As EventArgs) Handles btnGenerarVenta.Click
        If txtIdCliente.Text <> "" And txtNumComprobante.Text <> "" And gridProductos.Rows.Count > 0 Then
            Dim dts As New vventa
            Dim funciones_venta As New fVenta
            Dim mensaje As String

            dts.gtipocombrobante = cmbTipoComprobante.Text
            dts.gnumcomprobante = txtNumComprobante.Text

            If funciones_venta.valida_venta(dts, mensaje) Then
                Dim msg As String
                msg = mensaje
                If msg <> "Null" Then
                    MessageBox.Show(msg, "Generar Venta", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If
            Try
                Dim id_venta As Integer

                dts.gidcliente = txtIdCliente.Text
                dts.gfechaventa = fechaVenta.Text
                dts.gtipocombrobante = cmbTipoComprobante.Text
                dts.gnumcomprobante = txtNumComprobante.Text

                If funciones_venta.insertar(dts, id_venta) Then
                    Dim dtsDVenta As New vdetalleventa
                    Dim funciones_detalle_venta As New fDetalleVenta
                    For Each row As DataGridViewRow In gridProductos.Rows
                        Dim _idVenta, _idProducto, _cantidad As Integer
                        Dim _precioUnitario As Decimal
                        _idVenta = id_venta
                        _idProducto = row.Cells("id_producto").Value
                        _cantidad = row.Cells("cantidad").Value
                        _precioUnitario = row.Cells("precio_unitario").Value
                        dtsDVenta.gidventa = _idVenta
                        dtsDVenta.gidproducto = _idProducto
                        dtsDVenta.gcantidad = _cantidad
                        dtsDVenta.gpreciounitario = _precioUnitario
                        If funciones_detalle_venta.insertar_detalle_venta(dtsDVenta) Then
                        End If
                    Next
                    MessageBox.Show("Venta generada con éxito", "Generar Venta", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    gridProductos.DataSource = Nothing
                    frmCompVenta.txtIdCompVenta.Text = id_venta
                    frmCompVenta.Show()
                    limpiar()
                Else
                    MessageBox.Show("Venta no generada", "Generar Venta", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    limpiar()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Por favor ingresar los datos solicitados", "Generar Venta", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub txtDescuento_TextChanged(sender As Object, e As EventArgs) Handles txtDescuento.TextChanged
        If txtDescuento.Text = "" Then
            descuento = Nothing
            valorVenta = AcumuladorVenta
            subTotal = valorVenta - igv
            precioTotal = subTotal + igv
            ActualizaDatosVenta()
        Else
            valorDescuento = Convert.ToInt32(txtDescuento.Text)
            descuento = valorVenta * (valorDescuento / 100)
            valorVenta = valorVenta - descuento
            subTotal = valorVenta - igv
            precioTotal = subTotal + igv
            ActualizaDatosVenta()
        End If
    End Sub


    Private Sub txtNumComprobante_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNumComprobante.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            ErrorIcon.SetError(sender, "")
        Else
            ErrorIcon.SetError(sender, "el campo no puede estar vacío")
        End If
    End Sub

    Private Sub txtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                modalClientes.txtFlag.Text = "1"
                modalClientes.Show()
        End Select
    End Sub

    Private Sub btnAddCliente_Click(sender As Object, e As EventArgs) Handles btnAddCliente.Click
        frmCliente.Show()
    End Sub

    Private Sub txtCantidad_ValueChanged(sender As Object, e As EventArgs) Handles txtCantidad.ValueChanged
        Dim precioUnitario As Decimal
        Dim precio As Decimal
        Dim cantidad As Integer
        If txtPrecio.Text = "" Or txtIdProducto.Text = "" Then
            txtPrecioU.Text = ""
            precio = Nothing
            cantidad = Nothing
        Else
            precio = Convert.ToDecimal(txtPrecio.Text)
            cantidad = Convert.ToInt32(txtCantidad.Value)
            precioUnitario = precio * cantidad
            txtPrecioU.Text = precioUnitario
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtIdProducto.Text <> "" Then

            If gridProductos.Rows.Count > 0 Then
                For Each row As DataGridViewRow In gridProductos.Rows
                    If txtIdProducto.Text = row.Cells("id_producto").Value.ToString Then
                        MessageBox.Show("El producto ya se encuentra agregado", "Agregar Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                Next
            End If

            If txtCantidad.Value > 0 Then

                If Convert.ToInt32(txtCantidad.Value) > Convert.ToInt32(txtStock.Text) Then
                    MessageBox.Show("La cantidad supera el stock disponible", "Agregar Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    'Agregar Datos
                    Dim row As DataRow = dt.NewRow()
                    row("id_producto") = txtIdProducto.Text
                    row("Nombre") = txtNombreProducto.Text
                    row("cantidad") = txtCantidad.Value
                    row("precio_unitario") = txtPrecioU.Text
                    dt.Rows.Add(row)
                    gridProductos.Columns.Item("Eliminar").Visible = True
                    'Agrega montos para calcular precio total
                    AcumuladorVenta = AcumuladorVenta + Convert.ToDecimal(txtPrecioU.Text)
                    valorVenta = AcumuladorVenta
                    igv = valorVenta * (18 / 100)
                    subTotal = valorVenta - igv
                    precioTotal = subTotal + igv
                    'enlazar los datos de la tabla con el dataGridView
                    gridProductos.DataSource = dt
                    ActualizaDatosVenta()
                    'Limpiar campos
                    txtIdProducto.Text = ""
                    txtNombreProducto.Text = ""
                    txtStock.Text = ""
                    txtPrecio.Text = ""
                    txtCantidad.Value = 0
                    txtPrecioU.Text = ""
                End If

            Else
                MessageBox.Show("Debes ingresar una cantidad", "Agregar producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            MessageBox.Show("Debe seleccionar un producto", "Agregar producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub txtDescuento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescuento.KeyPress
        fValidaciones.soloNumeros(e)
    End Sub

    Private Sub limpiar()
        txtIdCliente.Text = ""
        txtBuscar.Text = ""
        txtDni.Text = ""
        txtNombres.Text = ""
        txtApellidos.Text = ""
        cmbTipoComprobante.Text = "BOLETA"
        txtNumComprobante.Text = ""
        txtIdProducto.Text = ""
        txtNombreProducto.Text = ""
        txtStock.Text = ""
        txtPrecio.Text = ""
        txtCantidad.Value = 0
        txtPrecioU.Text = ""
        txtValorVenta.Text = ""
        txtDescuento.Text = ""
        txtSubTotal.Text = ""
        txtIGV.Text = ""
        txtPrecioTotal.Text = ""
        valorVenta = Nothing
        subTotal = Nothing
        igv = Nothing
        descuento = Nothing
        AcumuladorVenta = Nothing
        valorDescuento = Nothing
        precioTotal = Nothing
        dt.Rows.Clear()
        ActualizaDatosVenta()
    End Sub
End Class