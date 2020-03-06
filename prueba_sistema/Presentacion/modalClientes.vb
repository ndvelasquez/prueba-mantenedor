Public Class modalClientes
    Dim dt As DataTable
    Private Sub modalClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buscar()
    End Sub
    Private Sub buscar()
        Try
            Dim funciones_venta As New fVenta
            Dim dt = New DataTable
            dt = funciones_venta.buscar_cliente

            If dt.Rows.Count > 0 Then
                dataListadoClientes.DataSource = dt
                dataListadoClientes.ColumnHeadersVisible = True
            Else
                dataListadoClientes.DataSource = Nothing
                dataListadoClientes.ColumnHeadersVisible = False
                MessageBox.Show("Cliente no se encuentra registrado", "Buscar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Dim idClienteText As Integer
    Dim dniClienteText, nombresClienteText, ApellidosClienteText As String
    Private Sub dataListadoClientes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataListadoClientes.CellDoubleClick
        If txtFlag.Text = "1" Then
            idClienteText = dataListadoClientes.Rows(e.RowIndex).Cells("id_cliente").Value
            dniClienteText = dataListadoClientes.Rows(e.RowIndex).Cells("dni").Value.ToString
            nombresClienteText = dataListadoClientes.Rows(e.RowIndex).Cells("nombres").Value.ToString
            ApellidosClienteText = dataListadoClientes.Rows(e.RowIndex).Cells("apellidos").Value.ToString

            frmVenta.txtIdCliente.Text = idClienteText
            frmVenta.txtNombres.Text = nombresClienteText
            frmVenta.txtDni.Text = dniClienteText
            frmVenta.txtApellidos.Text = ApellidosClienteText
            Me.Close()
        End If
    End Sub
End Class