Public Class frmInventario
    Dim dt As DataTable
    Private Sub frmInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub
    Private Sub mostrar()
        Try
            Dim funciones_producto As New fProducto
            dt = New DataTable
            dt = funciones_producto.mostrar

            If dt.Rows.Count <> 0 Then
                dataListadoInventario.DataSource = dt
                dataListadoInventario.Columns.Item("movimientos").Visible = True
                dataListadoInventario.ColumnHeadersVisible = True
                dataListadoInventario.Columns.Item("id_producto").Visible = False
                dataListadoInventario.Columns.Item("id_categoria").Visible = False
                cboCampo.Enabled = True
                txtABuscar.Enabled = True
                btnBuscar.Enabled = True
            Else
                dataListadoInventario.DataSource = Nothing
                dataListadoInventario.Columns.Item("movimientos").Visible = False
                dataListadoInventario.ColumnHeadersVisible = False
                cboCampo.Enabled = False
                txtABuscar.Enabled = False
                btnBuscar.Enabled = False
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

            dv.RowFilter = cboCampo.Text & " like '%" & txtABuscar.Text & "%'"

            If dv.Count <> 0 Then
                dataListadoInventario.DataSource = dv
            Else
                dataListadoInventario.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        buscar()
    End Sub

    Private Sub dataListadoInventario_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataListadoInventario.CellContentClick
        If dataListadoInventario.Columns(e.ColumnIndex).Name = "movimientos" Then
            frmMovimientos.txtIdProducto.Text = dataListadoInventario.Rows(e.RowIndex).Cells("id_producto").Value
            frmMovimientos.Show()
        End If
    End Sub
End Class