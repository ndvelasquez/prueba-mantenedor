Public Class frmMovimientos
    Dim dt As DataTable
    Private Sub frmMovimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub
    Private Sub mostrar()
        Try
            dt = New DataTable
            Dim funciones_producto As New fProducto
            Dim dts As New vproducto
            dts.gidproducto = txtIdProducto.Text
            dt = funciones_producto.mostrar_movimientos(dts)

            If dt.Rows.Count <> 0 Then
                dataListadoMovimientos.DataSource = dt
                dataListadoMovimientos.ColumnHeadersVisible = True
            Else
                dataListadoMovimientos.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class