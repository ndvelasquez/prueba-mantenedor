Imports System.Data.SqlClient
Public Class fProducto
    Inherits conexion
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectarBd()
            cmd = New SqlCommand("mostrar_producto")
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
    Public Function mostrar_movimientos(dts As vproducto) As DataTable
        Try
            conectarBd()
            cmd = New SqlCommand("mostrar_movimientos")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cadena_conexion

            cmd.Parameters.AddWithValue("@id_producto", dts.gidproducto)

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
    Public Function insertar(dts As vproducto, ByRef mensaje As String) As Boolean
        Try
            conectarBd()
            cmd = New SqlCommand("insertar_producto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cadena_conexion

            cmd.Parameters.AddWithValue("@id_categoria", dts.gidcategoria)
            cmd.Parameters.AddWithValue("@nombre", dts.gnombreproducto)
            cmd.Parameters.AddWithValue("@num_documento", dts.gnumDocumento)
            cmd.Parameters.AddWithValue("@cantidad", dts.gcantidad)
            cmd.Parameters.AddWithValue("@precio", dts.gprecio)
            cmd.Parameters.Add("@mensaje", SqlDbType.NVarChar, 100).Direction = ParameterDirection.Output
            cmd.Parameters.Add("@observacion", SqlDbType.NVarChar, 100).Value = ""
            cmd.Parameters.Add("@id_producto", SqlDbType.Int).Value = DBNull.Value


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
    Public Function editar(dts As vproducto, ByRef mensaje As String) As Boolean
        Try
            conectarBd()
            cmd = New SqlCommand("editar_producto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cadena_conexion

            cmd.Parameters.AddWithValue("@id_producto", dts.gidproducto)
            cmd.Parameters.AddWithValue("@id_categoria", dts.gidcategoria)
            cmd.Parameters.AddWithValue("@nombre", dts.gnombreproducto)
            cmd.Parameters.AddWithValue("@num_documento", dts.gnumDocumento)
            cmd.Parameters.AddWithValue("@cantidad", dts.gcantidad)
            cmd.Parameters.AddWithValue("@precio", dts.gprecio)
            cmd.Parameters.Add("@mensaje", SqlDbType.NVarChar, 100).Direction = ParameterDirection.Output
            cmd.Parameters.Add("@observacion", SqlDbType.NVarChar, 100).Value = ""

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
    Public Function eliminar(dts As vproducto) As Boolean
        Try
            conectarBd()
            cmd = New SqlCommand("eliminar_producto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cadena_conexion

            cmd.Parameters.Add("@id_producto", SqlDbType.NVarChar, 50).Value = dts.gidproducto

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
