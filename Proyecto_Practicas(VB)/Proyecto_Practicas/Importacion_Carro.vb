Imports MySql.Data.MySqlClient
Public Class Importacion_Carro
    Dim cmd As MySqlCommand
    Dim conn As New MySqlConnection
    Dim objetoconexion As New conexion
    Sub mostrar()
        conn = objetoconexion.AbrirCon
        Dim query As String = "SELECT i.id_impo as 'ID', ifc.vin_carro as 'VIN', cc.lote_compra as 'Lote de Compra', i.encarg_impo as 'Encargado de Importación', i.metodo_impo as 'Método de Importación', i.costo_impo as 'Costo de Importación' FROM importaciones i INNER JOIN info_carro ifc ON i.id_carro = ifc.id_carro INNER JOIN compra_carros cc ON cc.id_compras =i.id_compras;"
        Dim adpt As New MySqlDataAdapter(query, conn)
        Dim ds As New DataSet()
        adpt.Fill(ds)
        dgvCompraC.DataSource = ds.Tables(0)
        conn.Close()
        conn.Dispose()
    End Sub
    Private Sub Importacion_Carro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub
End Class