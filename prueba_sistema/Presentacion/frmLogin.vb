Public Class frmLogin
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        valida_usuario()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frmLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                valida_usuario()
        End Select
    End Sub

    Private Sub valida_usuario()
        Try
            Dim dts As New vusuario
            Dim func_usuario As New fUsuario
            Dim mensaje As String

            dts.gusername = txtUsuario.Text
            dts.gpassword = txtClave.Text

            If func_usuario.verifica_usuario(dts, mensaje) Then
                Dim msg As String = mensaje
                If msg = "Null" Then
                    Me.Hide()
                    frmInicio.Show()
                Else
                    MessageBox.Show(mensaje, "Iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtClave.Clear()
                End If
            Else
                MessageBox.Show("Usuario o contraseña incorrectos", "Iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtClave.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtClave_KeyDown(sender As Object, e As KeyEventArgs) Handles txtClave.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                valida_usuario()
        End Select
    End Sub
End Class