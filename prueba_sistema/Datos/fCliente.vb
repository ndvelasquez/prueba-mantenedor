Imports System.Data.SqlClient
Public Class fCliente
    Inherits conexion
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectarBd()
            cmd = New SqlCommand("mostrar_cliente")
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
    Public Function insertar(dts As vcliente) As Boolean
        Try
            conectarBd()
            cmd = New SqlCommand("insertar_cliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cadena_conexion

            cmd.Parameters.AddWithValue("@dni", dts.gdni)
            cmd.Parameters.AddWithValue("@nombres", dts.gnombres)
            cmd.Parameters.AddWithValue("@apellidos", dts.gapellidos)
            cmd.Parameters.AddWithValue("@telefono", dts.gtelefono)
            cmd.Parameters.AddWithValue("@direccion", dts.gdireccion)

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
    Public Function editar(dts As vcliente) As Boolean
        Try
            conectarBd()
            cmd = New SqlCommand("editar_cliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cadena_conexion

            cmd.Parameters.AddWithValue("@idcliente", dts.gidcliente)
            cmd.Parameters.AddWithValue("@dni", dts.gdni)
            cmd.Parameters.AddWithValue("@nombres", dts.gnombres)
            cmd.Parameters.AddWithValue("@apellidos", dts.gapellidos)
            cmd.Parameters.AddWithValue("@telefono", dts.gtelefono)
            cmd.Parameters.AddWithValue("@direccion", dts.gdireccion)

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
    Public Function eliminar(ByVal dts As vcliente) As Boolean
        Try
            conectarBd()
            cmd = New SqlCommand("eliminar_cliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cadena_conexion

            cmd.Parameters.Add("@idcliente", SqlDbType.NVarChar, 50).Value = dts.gidcliente

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class
