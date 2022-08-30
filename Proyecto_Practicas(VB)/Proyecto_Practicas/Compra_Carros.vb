Imports MySql.Data.MySqlClient
Public Class Compra_Carros
    Dim cmd As MySqlCommand
    Dim conn As New MySqlConnection
    Dim objetoconexion As New conexion
    Sub mostrar()
        conn = objetoconexion.AbrirCon
        Dim query As String = "SELECT c.id_compras as 'ID', i_f.vin_carro as 'VIN', s.nombre_sub as 'Subasta', c.lote_compra as 'Lote', c.daño_princ as 'Daño Principal', c.fecha_compra as 'Fecha de Compra', c.costosubasta_compra as 'Costo ($)', c.ubicacion_compra as 'Ubicación' FROM compra_carros c INNER JOIN info_carro i_f ON c.id_carro = i_f.id_carro INNER JOIN subastas s ON c.id_sub =s.id_sub;"
        Dim adpt As New MySqlDataAdapter(query, conn)
        Dim ds As New DataSet()
        adpt.Fill(ds)
        dgvCompraC.DataSource = ds.Tables(0)
        conn.Close()
        conn.Dispose()
    End Sub
    Private Sub Compra_Carros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub
End Class