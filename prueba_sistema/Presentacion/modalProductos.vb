Public Class modalProductos
    Dim dt As DataTable
    Private Sub modalProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub
    Private Sub mostrar()
        Try
            Dim funciones_producto As New fProducto
            dt = New DataTable
            dt = funciones_producto.mostrar

            If dt.Rows.Count > 0 Then
                dataListadoProductos.DataSource = dt
                dataListadoProductos.ColumnHeadersVisible = True
                dataListadoProductos.Columns.Item("id_categoria").Visible = False
            Else
                dataListadoProductos.DataSource = Nothing
                dataListadoProductos.ColumnHeadersVisible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            dv.RowFilter = cboCampo.Text & " like '%" & Me.txtTextoABuscar.Text & "%'"

            If dv.Count > 0 Then
                dataListadoProductos.DataSource = dv
            Else
                dataListadoProductos.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        buscar()
    End Sub

    Dim idProductoText, stockText As Integer
    Dim nombreProductoText As String
    Dim precioText As Decimal
    Private Sub dataListadoProductos_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataListadoProductos.CellContentDoubleClick
        Try
            If txtFlag.Text = "1" Then
                idProductoText = dataListadoProductos.Rows(e.RowIndex).Cells("id_producto").Value
                stockText = dataListadoProductos.Rows(e.RowIndex).Cells("stock").Value
                nombreProductoText = dataListadoProductos.Rows(e.RowIndex).Cells("nombre").Value.ToString
                precioText = dataListadoProductos.Rows(e.RowIndex).Cells("precio").Value

                frmVenta.txtIdProducto.Text = idProductoText
                frmVenta.txtNombreProducto.Text = nombreProductoText
                frmVenta.txtStock.Text = stockText
                frmVenta.txtPrecio.Text = precioText

                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class