Imports System.Data.SqlClient
Public Class fCategoria
    Inherits conexion
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectarBd()
            cmd = New SqlCommand("mostrar_categoria")
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
    Public Function insertar(dts As vcategoria) As Boolean
        Try
            conectarBd()
            cmd = New SqlCommand("insertar_categoria")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cadena_conexion

            cmd.Parameters.AddWithValue("@nombre_categoria", dts.gnombre_categoria)

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
    Public Function editar(dts As vcategoria) As Boolean
        Try
            conectarBd()
            cmd = New SqlCommand("editar_categoria")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cadena_conexion

            cmd.Parameters.AddWithValue("@id_categoria", dts.gidcategoria)
            cmd.Parameters.AddWithValue("@nombre_categoria", dts.gnombre_categoria)

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
    Public Function eliminar(ByVal dts As vcategoria) As Boolean
        Try
            conectarBd()
            cmd = New SqlCommand("eliminar_categoria")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cadena_conexion

            cmd.Parameters.Add("@id_categoria", SqlDbType.NVarChar, 50).Value = dts.gidcategoria

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
