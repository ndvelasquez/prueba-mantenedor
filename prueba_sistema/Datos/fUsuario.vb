Imports System.Data.SqlClient
Public Class fUsuario
    Inherits conexion
    Dim cmd As New SqlCommand

    Public Function verifica_usuario(dts As vusuario, ByRef mensaje As String)
        conectarBd()
        Try
            cmd = New SqlCommand("verifica_usuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cadena_conexion

            cmd.Parameters.AddWithValue("@username", dts.gusername)
            cmd.Parameters.AddWithValue("@password", dts.gpassword)
            cmd.Parameters.Add("@mensaje", SqlDbType.NVarChar, 100).Direction = ParameterDirection.Output


            If cmd.ExecuteNonQuery Then
                mensaje = cmd.Parameters.Item("@mensaje").Value
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectarBd()
        End Try
    End Function

    Public Function mostrar_usuario() As DataTable
        conectarBd()
        Try
            cmd = New SqlCommand("mostrar_usuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cadena_conexion

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectarBd()
        End Try
    End Function

    Public Function insertar_usuario(dts As vusuario) As Boolean
        conectarBd()
        Try
            cmd = New SqlCommand("insertar_usuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cadena_conexion

            cmd.Parameters.AddWithValue("@nombres", dts.gnombres)
            cmd.Parameters.AddWithValue("@apellidos", dts.gapellidos)
            cmd.Parameters.AddWithValue("@dni", dts.gdni)
            cmd.Parameters.AddWithValue("@username", dts.gusername)
            cmd.Parameters.AddWithValue("@password", dts.gpassword)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectarBd()
        End Try
    End Function

    Public Function editar_usuario(dts As vusuario) As Boolean
        conectarBd()
        Try
            cmd = New SqlCommand("editar_usuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cadena_conexion

            cmd.Parameters.AddWithValue("@id_usuario", dts.gidusuario)
            cmd.Parameters.AddWithValue("@nombres", dts.gnombres)
            cmd.Parameters.AddWithValue("@apellidos", dts.gapellidos)
            cmd.Parameters.AddWithValue("@dni", dts.gdni)
            cmd.Parameters.AddWithValue("@username", dts.gusername)
            cmd.Parameters.AddWithValue("@password", dts.gpassword)
            cmd.Parameters.AddWithValue("@estatus", dts.gestatus)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectarBd()
        End Try
    End Function

    Public Function eliminar_usuario(dts As vusuario) As Boolean
        conectarBd()
        Try
            cmd = New SqlCommand("eliminar_usuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cadena_conexion

            cmd.Parameters.Add("@id_usuario", SqlDbType.NVarChar, 50).Value = dts.gidusuario

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectarBd()
        End Try
    End Function
End Class
