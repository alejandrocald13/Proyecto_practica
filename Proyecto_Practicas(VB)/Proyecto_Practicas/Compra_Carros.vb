Imports MySql.Data.MySqlClient
Public Class Compra_Carros
    Dim cmd As MySqlCommand
    Dim conn As New MySqlConnection
    Dim objetoconexion As New conexion
    Dim i As Integer
    Sub l()
        tbID_CompraCar.Clear()
        cbCarro_CompraCar.SelectedIndex = -1
    End Sub
    Sub sepa()
        conn = objetoconexion.AbrirCon
        Dim query As String = "Select CONCAT(año_carro,' ', marca_carro,' ', modelo_carro) as info1_car FROM info_carro WHERE id_carro='" + cbCarro_CompraCar.SelectedValue.ToString + "';"
        Dim adpt As New MySqlDataAdapter(query, conn)
        Try
            Dim row As DataRow = Nothing
            Using dt As New DataTable()
                adpt.Fill(dt)
                If (dt.Rows.Count > 0) Then
                    row = dt.Rows(0)
                End If
            End Using
            tbCarroSelec_CompraCar.Text = Convert.ToString(row("info1_car"))
            conn.Close()
            conn.Dispose()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Sub cargarcarro()
        conn = objetoconexion.AbrirCon
        Dim query As String = "Select * FROM info_carro;"
        Dim adpt As New MySqlDataAdapter(query, conn)
        Dim ds As New DataSet()
        adpt.Fill(ds)
        cbCarro_CompraCar.DataSource = ds.Tables(0)
        cbCarro_CompraCar.DisplayMember = "vin_carro"
        cbCarro_CompraCar.ValueMember = "id_carro"
    End Sub
    Sub cargarsub()
        conn = objetoconexion.AbrirCon
        Dim query As String = "Select * FROM subastas;"
        Dim adpt As New MySqlDataAdapter(query, conn)
        Dim ds As New DataSet()
        adpt.Fill(ds)
        cbSub_CompraCar.DataSource = ds.Tables(0)
        cbSub_CompraCar.DisplayMember = "nombre_sub"
        cbSub_CompraCar.ValueMember = "id_sub"
        conn.Close()
        conn.Dispose()
    End Sub
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
        cargarcarro()
        cargarsub()
        cbCarro_CompraCar.SelectedIndex = -1
        cbSub_CompraCar.SelectedIndex = -1
    End Sub
    Private Sub cbCarro_CompraCar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCarro_CompraCar.SelectedIndexChanged
        i += 1
        If i >= 4 Then
            sepa()
        End If
    End Sub
End Class