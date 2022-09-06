Imports MySql.Data.MySqlClient
Public Class Importacion_Carro
    Dim cmd As MySqlCommand
    Dim conn As New MySqlConnection
    Dim objetoconexion As New conexion
    Dim i = 0
    Sub clin()
        tbID_CompraCar.Clear()
        cbCarro_Compraimpor.SelectedIndex = -1
        tbLoteSelec_Impo.Clear()
        tbencar_impor.Clear()
        tbCarroSelec_CompraCar.Clear()
        tbmeto_impor.Clear()
        nudCosto_impor.Value = 100
        cbCarro_Compraimpor.Focus()
    End Sub
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
    Sub cargarcarrito()
        conn = objetoconexion.AbrirCon
        Dim query As String = "Select * FROM info_carro;"
        Dim adpt As New MySqlDataAdapter(query, conn)
        Dim ds As New DataSet()
        adpt.Fill(ds)
        cbCarro_Compraimpor.DataSource = ds.Tables(0)
        cbCarro_Compraimpor.DisplayMember = "vin_carro"
        cbCarro_Compraimpor.ValueMember = "id_carro"
        conn.Close()
        conn.Dispose()
    End Sub
    Sub sd()
        conn = objetoconexion.AbrirCon
        Dim query As String = "Select * FROM compra_carros;"
        Dim adpt As New MySqlDataAdapter(query, conn)
        Dim ds As New DataSet()
        adpt.Fill(ds)
        Guna2ComboBox1.DataSource = ds.Tables(0)
        Guna2ComboBox1.DisplayMember = "lote_compra"
        Guna2ComboBox1.ValueMember = "id_compras"
        conn.Close()
        conn.Dispose()
    End Sub
    Sub carroselec()
        If cbCarro_Compraimpor.SelectedValue = 0 Then
            Exit Sub
        Else
            conn = objetoconexion.AbrirCon
            Dim query As String = "Select CONCAT(año_carro,' ', marca_carro,' ', modelo_carro) as info1_car FROM info_carro WHERE id_carro='" + cbCarro_Compraimpor.SelectedValue.ToString + "';"
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
        End If
    End Sub
    Sub loteselec()
        If cbCarro_Compraimpor.SelectedValue = 0 Then
            Exit Sub
        Else
            Try
                Dim cmd2 As MySqlCommand = New MySqlCommand
                conn = objetoconexion.AbrirCon
                cmd2.Connection = conn
                cmd2.CommandText = "Select * FROM compra_carros WHERE id_carro='" + cbCarro_Compraimpor.SelectedValue.ToString + "';"
                Dim r As MySqlDataReader
                r = cmd2.ExecuteReader
                If r.HasRows <> False Then
                    r.Read()
                    conn.Close()
                    conn.Dispose()
                    Dim query As String = "Select * FROM compra_carros WHERE id_carro='" + cbCarro_Compraimpor.SelectedValue.ToString + "';"
                    Dim adpt As New MySqlDataAdapter(cmd2.CommandText, conn)
                    Dim row As DataRow = Nothing
                    Using dt As New DataTable()
                        adpt.Fill(dt)
                        If (dt.Rows.Count > 0) Then
                            row = dt.Rows(0)
                        End If
                    End Using
                    Dim n = Convert.ToString(row("lote_compra"))
                    Guna2ComboBox1.SelectedItem = n
                Else
                    MessageBox.Show("Vaya, parece que el carro seleccionado, no tiene lote de Compra. Por favor, registra la compra del mismo.", "ERROR AL SELECCIONAR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Asterisk)
                    cbCarro_Compraimpor.SelectedIndex += -1
                End If
                conn.Close()
                conn.Dispose()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        End If
    End Sub
    Private Sub Importacion_Carro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
        cargarcarrito()
        sd()
        cbCarro_Compraimpor.SelectedIndex = -1
        btnguarda_impor.Enabled = False
    End Sub
    Private Sub cbCarro_Compraimpor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCarro_Compraimpor.SelectedIndexChanged
        i += 1
        If i >= 4 Then
            carroselec()
            loteselec()
        End If
    End Sub
    Private Sub btnnew_impor_Click(sender As Object, e As EventArgs) Handles btnnew_impor.Click
        clin()
        btnguarda_impor.Enabled = True
    End Sub
    Private Sub btnguarda_impor_Click(sender As Object, e As EventArgs) Handles btnguarda_impor.Click
        conn = objetoconexion.AbrirCon
        Try
            If tbencar_impor.Text = "" Or tbmeto_impor.Text = "" Or cbCarro_Compraimpor.SelectedIndex = -1 Then
                MessageBox.Show("ALGUN CAMPO ESTÁ VACÍO", "ERROR AL GUARDAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                cmd = conn.CreateCommand
                cmd.CommandText = "insert into importaciones(id_carro,id_compras,encarg_impo,metodo_impo,costo_impo)values(@car,@com,@encar,@met, @cost);"
                'cmd.Parameters.AddWithValue("@car", cbCarro_Compraimpor.SelectedValue.ToString)
                'cmd.Parameters.AddWithValue("@com", )
                'cmd.Parameters.AddWithValue("@ubi", tbUbi_CompraCar.Text)
                'cmd.ExecuteNonQuery()
                'conn.Close()
                'conn.Dispose()
                'mostrar()
                'l()
                'cbCarro_CompraCar.SelectedIndex = -1
                'cbSub_CompraCar.SelectedIndex = -1
                'Guna2Button2.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
End Class