Imports System.Data.SqlClient
Public Class conexion
    Protected cadena_conexion As SqlConnection
    Public idUsuario As Integer

    Protected Function conectarBd()
        Try
            cadena_conexion = New SqlConnection("data source=(local);initial catalog=db_sistema_ventas;integrated security=true")
            cadena_conexion.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function


    Protected Function desconectarBd()
        Try
            If cadena_conexion.State = ConnectionState.Open Then
                cadena_conexion.Close()
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
