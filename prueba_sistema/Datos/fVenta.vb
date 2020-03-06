Imports System.Data.SqlClient
Public Class fVenta
    Inherits conexion
    Dim cmd As New SqlCommand

    Public Function mostrar_venta() As DataTable
        Try
            conectarBd()
            cmd = New SqlCommand("mostrar_venta")
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
        End Try
    End Function

    Public Function buscar_cliente() As DataTable
        Try
            conectarBd()
            cmd = New SqlCommand("buscar_cliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cadena_conexion

            cmd.Parameters.AddWithValue("@nombre", frmVenta.cmbCriterio.Text)
            cmd.Parameters.AddWithValue("@filtro", frmVenta.txtBuscar.Text)
            cmd.Parameters.Add("@columna", SqlDbType.NVarChar, 50).Value = ""

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
        End Try
    End Function
    Public Function valida_venta(dts As vventa, ByRef mensaje As String) As Boolean
        Try
            conectarBd()
            cmd = New SqlCommand("verifica_venta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cadena_conexion

            cmd.Parameters.AddWithValue("@tipo_comprobante", frmVenta.cmbTipoComprobante.Text)
            cmd.Parameters.AddWithValue("@num_comprobante", frmVenta.txtNumComprobante.Text)
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
    Public Function insertar(dts As vventa, ByRef id_venta As Integer) As Boolean
        Try
            conectarBd()
            cmd = New SqlCommand("insertar_venta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cadena_conexion

            cmd.Parameters.AddWithValue("@id_cliente", dts.gidcliente)
            cmd.Parameters.AddWithValue("@fecha_venta", dts.gfechaventa)
            cmd.Parameters.AddWithValue("@tipo_documento", dts.gtipocombrobante)
            cmd.Parameters.AddWithValue("@num_documento", dts.gnumcomprobante)
            cmd.Parameters.Add("@id_ventaI", SqlDbType.Int).Direction = ParameterDirection.Output
            If cmd.ExecuteNonQuery Then
                id_venta = cmd.Parameters.Item("@id_ventaI").Value
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
    Public Function editar(dts As vventa) As Boolean
        Try
            conectarBd()
            cmd = New SqlCommand("editar_venta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cadena_conexion

            cmd.Parameters.AddWithValue("@id_venta", dts.gidventa)
            cmd.Parameters.AddWithValue("@id_cliente", dts.gidcliente)
            cmd.Parameters.AddWithValue("@fecha_venta", dts.gfechaventa)
            cmd.Parameters.AddWithValue("@tipo_comprobante", dts.gtipocombrobante)
            cmd.Parameters.AddWithValue("@num_comprobante", dts.gnumcomprobante)

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
    Public Function eliminar(dts As vventa) As Boolean
        Try
            conectarBd()
            cmd = New SqlCommand("eliminar_venta")
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
