Public Class frmCompVenta
    Private Sub prueba_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'db_sistema_ventasDataSet.genera_comp_venta' Puede moverla o quitarla según sea necesario.
        Me.genera_comp_ventaTableAdapter.Fill(Me.db_sistema_ventasDataSet.genera_comp_venta, idventa:=txtIdCompVenta.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub

End Class