Public Class frmCliente
    Private dt As DataTable 'para guardar la tabla en memoria
    Dim fValidaciones As New validaMetodos

    Private Sub frmCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub
    Private Sub mostrar()
        Try
            Dim funciones_cliente As New fCliente
            dt = New DataTable()
            dt = funciones_cliente.mostrar
            dataListado.Columns.Item("Eliminar").Visible = False

            If dt.Rows.Count <> 0 Then
                dataListado.DataSource = dt
                dataListado.Columns.Item("id_cliente").Visible = False
                dataListado.ColumnHeadersVisible = True
                txtBuscar.Enabled = True
                btnBuscar.Enabled = True
                noDatos.Visible = False
            Else
                dataListado.DataSource = Nothing
                txtBuscar.Enabled = False
                btnBuscar.Enabled = False
                dataListado.ColumnHeadersVisible = False
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

            dv.RowFilter = comboDatoAFiltrar.Text & " like '%" & txtBuscar.Text & "%'"

            If dv.Count <> 0 Then
                dataListado.DataSource = dv
            Else
                dataListado.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub limpiar()
        txtDni.Text = ""
        txtNombres.Text = ""
        txtApellidos.Text = ""
        txtTelefono.Text = ""
        txtDireccion.Text = ""
        txtIdCliente.Text = ""
        btnEditar.Visible = False
        btnGuardar.Visible = True
        btnCancelar.Enabled = False
        btnEliminar.Enabled = False
        checkEliminar.Checked = False
        btnNuevo.Enabled = True
        txtDni.Enabled = False
        txtNombres.Enabled = False
        txtApellidos.Enabled = False
        txtDireccion.Enabled = False
        txtTelefono.Enabled = False
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Me.ValidateChildren = True And txtDni.Text <> "" And txtNombres.Text <> "" And txtApellidos.Text <> "" And txtTelefono.Text <> "" And txtDireccion.Text <> "" Then
            Try
                Dim dts As New vcliente
                Dim funciones_cliente As New fCliente

                dts.gdni = txtDni.Text
                dts.gnombres = txtNombres.Text
                dts.gapellidos = txtApellidos.Text
                dts.gtelefono = txtTelefono.Text
                dts.gdireccion = txtDireccion.Text

                If funciones_cliente.insertar(dts) Then
                    MessageBox.Show("Cliente creado con éxito", "Crear Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("Cliente no guardado", "Crear Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()
                    limpiar()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Por favor ingresar los datos correctos", "Ingresar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtDni.Enabled = True
        txtNombres.Enabled = True
        txtApellidos.Enabled = True
        txtDireccion.Enabled = True
        txtTelefono.Enabled = True
        btnNuevo.Enabled = False
        btnCancelar.Enabled = True
    End Sub

    Private Sub txtDni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDni.KeyPress
        fValidaciones.soloNumeros(e)
    End Sub
    Private Sub txtNombres_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombres.KeyPress
        fValidaciones.soloLetras(e)
    End Sub
    Private Sub txtApellidos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellidos.KeyPress
        fValidaciones.soloLetras(e)
    End Sub
    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        fValidaciones.formatoTelefono(e)
    End Sub

    Private Sub txtDni_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtDni.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorIcon.SetError(sender, "")
        Else
            Me.errorIcon.SetError(sender, "el campo no puede estar vacío")
        End If
    End Sub
    Private Sub txtNombres_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNombres.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorIcon.SetError(sender, "")
        Else
            Me.errorIcon.SetError(sender, "el campo no puede estar vacío")
        End If
    End Sub
    Private Sub txtApellidos_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtApellidos.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorIcon.SetError(sender, "")
        Else
            Me.errorIcon.SetError(sender, "el campo no puede estar vacío")
        End If
    End Sub
    Private Sub txtTelefono_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtTelefono.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorIcon.SetError(sender, "")
        Else
            Me.errorIcon.SetError(sender, "el campo no puede estar vacío")
        End If
    End Sub
    Private Sub txtDireccion_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtDireccion.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorIcon.SetError(sender, "")
        Else
            Me.errorIcon.SetError(sender, "el campo no puede estar vacío")
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim resultado As DialogResult
        resultado = MessageBox.Show("¿Desea modificar los datos del cliente?", "Modificar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resultado = DialogResult.Yes Then
            Try
                Dim dts As New vcliente
                Dim funciones_cliente As New fCliente

                dts.gidcliente = txtIdCliente.Text
                dts.gdni = txtDni.Text
                dts.gnombres = txtNombres.Text
                dts.gapellidos = txtApellidos.Text
                dts.gtelefono = txtTelefono.Text
                dts.gdireccion = txtDireccion.Text

                If funciones_cliente.editar(dts) Then
                    MessageBox.Show("Cliente modificado con éxito", "Modificar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("Cliente no modificado", "Modificar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()
                    limpiar()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
        btnCancelar.Enabled = False
    End Sub

    Private Sub checkEliminar_CheckedChanged(sender As Object, e As EventArgs) Handles checkEliminar.CheckedChanged
        If checkEliminar.CheckState = CheckState.Checked Then
            dataListado.Columns.Item("Eliminar").Visible = True
            btnEliminar.Enabled = True
        Else
            dataListado.Columns.Item("Eliminar").Visible = False
            btnEliminar.Enabled = False
        End If
    End Sub

    'Variables de campos del formulario
    Public idClienteText As Integer
    Public dniText, nombresText, apellidosText, telefonoText, direccionText As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        buscar()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim resultado As DialogResult
        resultado = MessageBox.Show("¿Realmente desea eliminar los registros seleccionados?", "Eliminar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resultado = DialogResult.Yes Then
            Try
                For Each row As DataGridViewRow In dataListado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                    If marcado Then
                        Dim llavePrimaria As Integer = Convert.ToInt32(row.Cells("id_cliente").Value)
                        Dim dts As New vcliente
                        Dim funciones_cliente As New fCliente

                        dts.gidcliente = llavePrimaria

                        If funciones_cliente.eliminar(dts) Then

                        Else
                            MessageBox.Show("Cliente(s) no eliminado(s)", "Eliminar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub dataListado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataListado.CellClick
        If dataListado.Rows.Count > 0 Then
            idClienteText = dataListado.Rows(e.RowIndex).Cells("id_cliente").Value
            dniText = dataListado.Rows(e.RowIndex).Cells("dni").Value.ToString()
            nombresText = dataListado.Rows(e.RowIndex).Cells("nombres").Value.ToString()
            apellidosText = dataListado.Rows(e.RowIndex).Cells("apellidos").Value.ToString()
            telefonoText = dataListado.Rows(e.RowIndex).Cells("telefono").Value.ToString()
            direccionText = dataListado.Rows(e.RowIndex).Cells("direccion").Value.ToString()

            txtIdCliente.Text = idClienteText
            txtDni.Text = dniText
            txtNombres.Text = nombresText
            txtApellidos.Text = apellidosText
            txtTelefono.Text = telefonoText
            txtDireccion.Text = direccionText

            btnEditar.Visible = True
            btnGuardar.Visible = False
            txtDni.Enabled = True
            txtNombres.Enabled = True
            txtApellidos.Enabled = True
            txtDireccion.Enabled = True
            txtTelefono.Enabled = True
            btnCancelar.Enabled = True
            btnNuevo.Enabled = False
        End If
    End Sub
    Private Sub dataListado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataListado.CellContentClick
        If e.ColumnIndex = Me.dataListado.Columns.Item("Eliminar").Index Then
            Dim chkCell As DataGridViewCheckBoxCell = Me.dataListado.Rows(e.RowIndex).Cells("Eliminar")
            chkCell.Value = Not chkCell.Value
        End If
    End Sub
End Class