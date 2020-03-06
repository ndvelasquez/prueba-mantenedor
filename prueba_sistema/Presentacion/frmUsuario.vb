Public Class frmUsuario
    Dim dt As DataTable

    Private Sub soloLetras(ByRef e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub soloNumeros(ByRef e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub frmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub
    Private Sub mostrar()
        Try
            Dim func_usuario As New fUsuario
            dt = New DataTable
            dt = func_usuario.mostrar_usuario
            gridUsuarios.Columns.Item("Eliminar").Visible = False
            If dt.Rows.Count <> 0 Then
                gridUsuarios.DataSource = dt
                gridUsuarios.Columns.Item("id_usuario").Visible = False
                gridUsuarios.ColumnHeadersVisible = True
                txtBuscar.Enabled = True
                lblNoDatos.Visible = False
                btnBuscar.Enabled = True
            Else
                gridUsuarios.DataSource = Nothing
                gridUsuarios.ColumnHeadersVisible = False
                txtBuscar.Enabled = False
                lblNoDatos.Visible = True
                btnBuscar.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        btnEditar.Visible = False
        btnGuardar.Visible = True
    End Sub
    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            dv.RowFilter = cboCampo.Text & " like '%" & txtBuscar.Text & "%'"

            If dv.Count <> 0 Then
                gridUsuarios.DataSource = dv
                lblNoDatos.Visible = False
            Else
                gridUsuarios.DataSource = Nothing
                lblNoDatos.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub limpiar()
        txtDniUsu.Clear()
        txtNombresUsu.Clear()
        txtApellidosUsu.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
        txtBuscar.Clear()
        btnNuevo.Enabled = True
        txtDniUsu.Enabled = False
        txtDniUsu.Enabled = False
        txtNombresUsu.Enabled = False
        txtApellidosUsu.Enabled = False
        txtUsername.Enabled = False
        txtPassword.Enabled = False
        chkEstatus.Enabled = False
        btnCancelar.Enabled = False
        chkEstatus.Checked = False
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim resultado As DialogResult
        resultado = MessageBox.Show("¿Desea editar los datos del usuario?", "Editar usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If resultado = DialogResult.Yes Then
            Try
                Dim dts As New vusuario
                Dim func_usuario As New fUsuario

                dts.gidusuario = txtIdUsu.Text
                dts.gdni = txtDniUsu.Text
                dts.gnombres = txtNombresUsu.Text
                dts.gapellidos = txtApellidosUsu.Text
                dts.gusername = txtUsername.Text
                dts.gpassword = txtPassword.Text

                If chkEstatus.Checked = False Then
                    dts.gestatus = 2
                Else
                    dts.gestatus = 1
                End If

                If func_usuario.editar_usuario(dts) Then
                    MessageBox.Show("Usuario modificado con éxito", "Modificar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("Usuario no modificado", "Modificar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Me.ValidateChildren = True And txtDniUsu.Text <> "" And txtNombresUsu.Text <> "" And txtApellidosUsu.Text <> "" And txtUsername.Text <> "" And txtPassword.Text <> "" Then
            Try
                Dim dts As New vusuario
                Dim func_usuario As New fUsuario

                dts.gdni = txtDniUsu.Text
                dts.gnombres = txtNombresUsu.Text
                dts.gapellidos = txtApellidosUsu.Text
                dts.gusername = txtUsername.Text
                dts.gpassword = txtPassword.Text

                If func_usuario.insertar_usuario(dts) Then
                    MessageBox.Show("Usuario creado con éxito", "Crear Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("Usuario no creado", "Crear Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()
                    limpiar()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        buscar()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim resultado As DialogResult
        resultado = MessageBox.Show("¿Desea borrar los registros seleccionados?", "Eliminar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
        If resultado = DialogResult.Yes Then
            Try
                For Each row As DataGridViewRow In gridUsuarios.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                    If marcado Then
                        Dim llavePrimaria As Integer = Convert.ToInt32(row.Cells("id_usuario").Value)
                        Dim dts As New vusuario
                        Dim func_usuario As New fUsuario
                        dts.gidusuario = llavePrimaria

                        If func_usuario.eliminar_usuario(dts) Then

                        Else
                            MessageBox.Show("Usuario(s) no eliminado(s)", "Eliminar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End If
                Next
                mostrar()
                limpiar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub gridUsuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridUsuarios.CellContentClick
        If e.ColumnIndex = Me.gridUsuarios.Columns.Item("Eliminar").Index Then
            Dim chkCell As DataGridViewCheckBoxCell = Me.gridUsuarios.Rows(e.RowIndex).Cells("Eliminar")
            chkCell.Value = Not chkCell.Value
        End If
    End Sub

    Private Sub chkEliminar_CheckedChanged(sender As Object, e As EventArgs) Handles chkEliminar.CheckedChanged
        If chkEliminar.Checked = True Then
            gridUsuarios.Columns.Item("Eliminar").Visible = True
            btnEliminar.Enabled = True
        Else
            gridUsuarios.Columns.Item("Eliminar").Visible = False
            btnEliminar.Enabled = False
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
        mostrar()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtDniUsu.Enabled = True
        txtDniUsu.Enabled = True
        txtNombresUsu.Enabled = True
        txtApellidosUsu.Enabled = True
        txtUsername.Enabled = True
        txtPassword.Enabled = True
        chkEstatus.Enabled = True
        btnCancelar.Enabled = True
        btnNuevo.Enabled = False
    End Sub


    Dim idUsuarioText, estatusText As Integer
    Dim dniUsuarioText, nombresUsuarioText, apellidosUsuarioText, usernameText, passwordText As String

    Private Sub txtApellidosUsu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellidosUsu.KeyPress
        soloLetras(e)
    End Sub

    Private Sub txtNombresUsu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombresUsu.KeyPress
        soloLetras(e)
    End Sub

    Private Sub txtDniUsu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDniUsu.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub gridUsuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridUsuarios.CellClick
        If gridUsuarios.Rows.Count <> 0 Then
            idUsuarioText = gridUsuarios.Rows(e.RowIndex).Cells("id_usuario").Value
            dniUsuarioText = gridUsuarios.Rows(e.RowIndex).Cells("dni").Value.ToString()
            nombresUsuarioText = gridUsuarios.Rows(e.RowIndex).Cells("nombres").Value.ToString()
            apellidosUsuarioText = gridUsuarios.Rows(e.RowIndex).Cells("apellidos").Value.ToString()
            usernameText = gridUsuarios.Rows(e.RowIndex).Cells("username").Value.ToString()
            passwordText = gridUsuarios.Rows(e.RowIndex).Cells("password").Value.ToString()
            estatusText = gridUsuarios.Rows(e.RowIndex).Cells("estatus").Value
            If estatusText = 1 Then
                chkEstatus.Checked = True
            Else
                chkEstatus.Checked = False
            End If
            txtIdUsu.Text = idUsuarioText
            txtDniUsu.Text = dniUsuarioText
            txtNombresUsu.Text = nombresUsuarioText
            txtApellidosUsu.Text = apellidosUsuarioText
            txtUsername.Text = usernameText
            txtPassword.Text = passwordText

            txtDniUsu.Enabled = True
            txtDniUsu.Enabled = True
            txtNombresUsu.Enabled = True
            txtApellidosUsu.Enabled = True
            txtUsername.Enabled = True
            txtPassword.Enabled = True
            chkEstatus.Enabled = True
            btnCancelar.Enabled = True
            btnNuevo.Enabled = False
            btnEditar.Visible = True
            btnGuardar.Visible = False
        End If
    End Sub
End Class