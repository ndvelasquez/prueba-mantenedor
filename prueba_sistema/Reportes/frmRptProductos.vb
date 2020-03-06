Public Class frmRptProductos
    Private Sub frmRptProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'db_sistema_ventasDataSet.mostrar_producto' Puede moverla o quitarla según sea necesario.
        Me.mostrar_productoTableAdapter.Fill(Me.db_sistema_ventasDataSet.mostrar_producto)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class