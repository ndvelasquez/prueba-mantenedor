Public Class frmMuestraVentas
    Dim dt As DataTable
    Private Sub frmMuestraVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub
    Private Sub mostrar()
        Try
            Dim funciones_venta As New fVenta
            dt = New DataTable
            dt = funciones_venta.mostrar_venta
            dataListadoVentas.Columns.Item("Anular").Visible = False

            If dt.Rows.Count <> 0 Then
                dataListadoVentas.DataSource = dt
                dataListadoVentas.ColumnHeadersVisible = True
                dataListadoVentas.Columns.Item("id_cliente").Visible = False
                dataListadoVentas.Columns.Item("id_venta").Visible = False
                dataListadoVentas.Columns.Item("ver_detalle").Visible = True
                noDatos.Visible = False
            Else
                dataListadoVentas.DataSource = Nothing
                dataListadoVentas.ColumnHeadersVisible = False
                noDatos.Visible = True
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

            If cboCampo.Text = "numero comprobante" Then
                dv.RowFilter = "nro_comprobante like '%" & Me.txtTextoABuscar.Text & "%'"
            Else
                dv.RowFilter = cboCampo.Text & " like '%" & Me.txtTextoABuscar.Text & "%'"
            End If

            If dv.Count > 0 Then
                dataListadoVentas.DataSource = dv
            Else
                dataListadoVentas.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub chkAnular_CheckedChanged(sender As Object, e As EventArgs) Handles chkAnular.CheckedChanged
        If chkAnular.CheckState = CheckState.Checked Then
            dataListadoVentas.Columns.Item("Anular").Visible = True
            btnAnular.Visible = True
        Else
            dataListadoVentas.Columns.Item("Anular").Visible = False
            btnAnular.Visible = False
        End If
    End Sub

    Private Sub dataListadoVentas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataListadoVentas.CellContentClick
        If dataListadoVentas.Columns(e.ColumnIndex).Name = "ver_detalle" Then
            frmCompVenta.txtIdCompVenta.Text = dataListadoVentas.Rows(e.RowIndex).Cells("id_venta").Value
            frmCompVenta.Show()
        End If
        If e.ColumnIndex = Me.dataListadoVentas.Columns.Item("Anular").Index Then
            Dim chkCell As DataGridViewCheckBoxCell = Me.dataListadoVentas.Rows(e.RowIndex).Cells("Anular")
            chkCell.Value = Not chkCell.Value
        End If
    End Sub

    Private Sub btnAnular_Click(sender As Object, e As EventArgs) Handles btnAnular.Click
        Dim resultado As DialogResult
        resultado = MessageBox.Show("¿Realmente desea anular los registros seleccionados?", "Anular venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resultado = DialogResult.Yes Then
            Try
                For Each row As DataGridViewRow In dataListadoVentas.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Anular").Value)
                    If marcado Then
                        Dim llavePrimaria As Integer = Convert.ToInt32(row.Cells("id_venta").Value)

                        Dim dts As New vdetalleventa
                        Dim funciones_venta As New fDetalleVenta

                        dts.gidventa = llavePrimaria
                        If funciones_venta.anular_venta(dts) Then

                        Else
                            MessageBox.Show("Registros no anulados", "Anular Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End If
                Next
                mostrar()
                chkAnular.Checked = False
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        buscar()
    End Sub
End Class