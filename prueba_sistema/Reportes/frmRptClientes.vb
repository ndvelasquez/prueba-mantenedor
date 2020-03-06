Public Class frmRptClientes
    Private Sub frmRptClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'db_sistema_ventasDataSet.cliente' Puede moverla o quitarla según sea necesario.
        Me.clienteTableAdapter.Fill(Me.db_sistema_ventasDataSet.cliente)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class