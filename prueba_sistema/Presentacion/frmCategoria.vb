Imports System.ComponentModel
Public Class frmCategoria
    Dim dt As DataTable
    Dim fValidaciones As New validaMetodos
    Private Sub frmCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub
    Private Sub mostrar()
        Try
            Dim funciones_categoria As New fCategoria
            dt = New DataTable()
            dt = funciones_categoria.mostrar
            dataListadoCat.Columns.Item("Eliminar").Visible = False

            If dt.Rows.Count <> 0 Then
                dataListadoCat.DataSource = dt
                dataListadoCat.Columns.Item("id_categoria").Visible = False
                dataListadoCat.ColumnHeadersVisible = True
                txtBuscarCat.Enabled = True
                Button1.Enabled = True
                noDatos.Visible = False
            Else
                dataListadoCat.DataSource = Nothing
                txtBuscarCat.Enabled = False
                dataListadoCat.ColumnHeadersVisible = False
                Button1.Enabled = False
                noDatos.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        btnNuevo.Enabled = True
        btnGuardar.Visible = True
        btnEditar.Visible = False
    End Sub
    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            dv.RowFilter = "nombre_categoria" & " like '%" & txtBuscarCat.Text & "%'"

            If dv.Count <> 0 Then
                dataListadoCat.DataSource = dv
            Else
                dataListadoCat.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub limpiar()
        txtNombreCategoria.Text = ""
        txtIdCategoria.Enabled = False
        btnEditar.Visible = False
        btnGuardar.Visible = True
        btnNuevo.Enabled = True
        btnCancelar.Enabled = False
        checkEliminarCat.Checked = False
        txtNombreCategoria.Enabled = False
        btnEliminar.Enabled = False
    End Sub

    Private Sub txtNombreCategoria_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombreCategoria.KeyPress
        fValidaciones.soloLetras(e)
    End Sub

    Private Sub txtNombreCategoria_Validating(sender As Object, e As CancelEventArgs) Handles txtNombreCategoria.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorIcon.SetError(sender, "")
        Else
            Me.errorIcon.SetError(sender, "Este campo no puede estar vacío")
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtNombreCategoria.Enabled = True
        btnNuevo.Enabled = False
        btnCancelar.Enabled = True
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
        btnCancelar.Enabled = False
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Me.ValidateChildren = True And txtNombreCategoria.Text <> "" Then
            Try
                Dim dts As New vcategoria
                Dim funciones_categoria As New fCategoria

                dts.gnombre_categoria = txtNombreCategoria.Text

                If funciones_categoria.insertar(dts) Then
                    MessageBox.Show("Categoría creada con éxito", "Crear Categoría", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("Categoría no guardada", "Crear Categoría", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()
                    limpiar()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Por favor ingresar los datos correctos", "Crear Categoría", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    'Variables para mostrar datos en campos del formulario
    Public idCategoriaText As Integer
    Public nombreCategoriaText As String

    Private Sub dataListadoCat_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataListadoCat.CellClick
        If dataListadoCat.Rows.Count > 0 Then
            idCategoriaText = dataListadoCat.Rows(e.RowIndex).Cells("id_categoria").Value
            nombreCategoriaText = dataListadoCat.Rows(e.RowIndex).Cells("nombre_categoria").Value.ToString()

            txtIdCategoria.Text = idCategoriaText
            txtNombreCategoria.Text = nombreCategoriaText

            btnGuardar.Visible = False
            btnEditar.Visible = True
            txtNombreCategoria.Enabled = True
            btnNuevo.Enabled = False
            btnCancelar.Enabled = True
        End If
    End Sub

    Private Sub dataListadoCat_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataListadoCat.CellContentClick
        If e.ColumnIndex = Me.dataListadoCat.Columns.Item("Eliminar").Index Then
            Dim chkCell As DataGridViewCheckBoxCell = Me.dataListadoCat.Rows(e.RowIndex).Cells("Eliminar")
            chkCell.Value = Not chkCell.Value
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim resultado As DialogResult
        resultado = MessageBox.Show("¿Desea Modificar la categoría?", "Modificar Categoría", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resultado = DialogResult.Yes Then
            Try
                Dim dts As New vcategoria
                Dim funciones_categoria As New fCategoria
                dts.gidcategoria = txtIdCategoria.Text
                dts.gnombre_categoria = txtNombreCategoria.Text

                If funciones_categoria.editar(dts) Then
                    MessageBox.Show("Categoría modificada con éxito", "Modificar Categoría", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("Categoría no modificada", "Modificar Categoría", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()
                    limpiar()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim resultado As DialogResult
        resultado = MessageBox.Show("¿Realmente desea eliminar los registros seleccionados?", "Eliminar Categoría", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resultado = DialogResult.Yes Then
            Try
                For Each row As DataGridViewRow In dataListadoCat.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                    If marcado Then
                        Dim llavePrimaria As Integer = Convert.ToInt32(row.Cells("id_categoria").Value)
                        Dim dts As New vcategoria
                        Dim funciones_categoria As New fCategoria

                        dts.gidcategoria = llavePrimaria

                        If funciones_categoria.eliminar(dts) Then

                        Else
                            MessageBox.Show("Categoría(s) no eliminada(s)", "Eliminar Categoría", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End If
                Next
                Call mostrar()
                Call limpiar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Eliminación cancelada", "Eliminar Categoría", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call mostrar()
            Call limpiar()
        End If
    End Sub

    Private Sub checkEliminarCat_CheckedChanged(sender As Object, e As EventArgs) Handles checkEliminarCat.CheckedChanged
        If checkEliminarCat.CheckState = CheckState.Checked Then
            dataListadoCat.Columns.Item("Eliminar").Visible = True
            btnEliminar.Enabled = True
        Else
            dataListadoCat.Columns.Item("Eliminar").Visible = False
            btnEliminar.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        buscar()
    End Sub
End Class