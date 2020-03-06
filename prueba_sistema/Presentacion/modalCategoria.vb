Public Class modalCategoria
    Dim dt As DataTable
    Private Sub modalCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub
    Private Sub mostrar()
        Try
            Dim funciones_categoria As New fCategoria
            dt = New DataTable()
            dt = funciones_categoria.mostrar

            If dt.Rows.Count <> 0 Then
                dataListadoCat.DataSource = dt
                dataListadoCat.ColumnHeadersVisible = True
            Else
                dataListadoCat.DataSource = Nothing
                dataListadoCat.ColumnHeadersVisible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Dim idCategoriaText As Integer
    Dim nombreCategoriaText As String
    Private Sub dataListadoCat_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataListadoCat.CellDoubleClick
        If txtFlag.Text = "1" Then
            idCategoriaText = dataListadoCat.Rows(e.RowIndex).Cells("id_categoria").Value
            nombreCategoriaText = dataListadoCat.Rows(e.RowIndex).Cells("nombre_categoria").Value

            frmProducto.txtIdCategoria.Text = idCategoriaText
            frmProducto.txtCategoria.Text = nombreCategoriaText
            Me.Close()
        End If
    End Sub
End Class