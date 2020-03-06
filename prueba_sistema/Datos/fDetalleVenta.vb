Imports System.Data.SqlClient
Public Class fDetalleVenta
    Inherits conexion
    Dim cmd As New SqlCommand

    Public Function insertar_detalle_venta(dts As vdetalleventa) As Boolean
        Try
            conectarBd()
            cmd = New SqlCommand("insertar_detalle_venta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cadena_conexion

            cmd.Parameters.AddWithValue("@id_venta", dts.gidventa)
            cmd.Parameters.AddWithValue("@id_producto", dts.gidproducto)
            cmd.Parameters.AddWithValue("@cantidad", dts.gcantidad)
            cmd.Parameters.AddWithValue("@precio_unitario", dts.gpreciounitario)
            cmd.Parameters.Add("@num_documento", SqlDbType.NVarChar, 50).Value = ""

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
    Public Function editar_detalle_venta(dts As vdetalleventa) As Boolean
        Try
            conectarBd()
            cmd = New SqlCommand("editar_detalle_venta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cadena_conexion

            cmd.Parameters.AddWithValue("@id_detalle_venta", dts.giddetalleventa)
            cmd.Parameters.AddWithValue("@id_venta", dts.gidventa)
            cmd.Parameters.AddWithValue("@id_producto", dts.gidproducto)
            cmd.Parameters.AddWithValue("@cantidad", dts.gcantidad)
            cmd.Parameters.AddWithValue("@precio_unitario", dts.gpreciounitario)

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
    Public Function anular_venta(dts As vdetalleventa) As Boolean
        Try
            conectarBd()
            cmd = New SqlCommand("anular_venta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cadena_conexion

            cmd.Parameters.Add("@id_venta", SqlDbType.NVarChar, 50).Value = dts.gidventa

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
