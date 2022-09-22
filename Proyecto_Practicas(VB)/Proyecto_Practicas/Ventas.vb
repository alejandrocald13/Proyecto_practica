Imports MySql.Data.MySqlClient
Public Class Ventas
    Dim cmd As MySqlCommand
    Dim conn As New MySqlConnection
    Dim objetoconexion As New conexion
    Dim i As Integer
    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2GroupBox1.Enabled = False
        mostrar()
        cargarcarrito()
        cargarclientes()
        cargarrevend()
        cbCarro_ventas.SelectedIndex = -1
        cbcliente_cliente.SelectedIndex = -1
        cbrevendedor_ventas.SelectedIndex = -1
        btnsave_ventas.Enabled = False
        btnmodifi_ventas.Enabled = False
    End Sub
    Sub limpiar()
        tbID_CompraCar.Clear()
        tbCarroSelec_CompraCar.Clear()
        cbCarro_ventas.SelectedIndex = -1
        nudtotal_ventas.Value = 15000
        nudganancias_ventas.Value = 0
        cbcliente_cliente.SelectedIndex = -1
        cbrevendedor_ventas.SelectedIndex = -1
        dtpFecha_CompraCar.Value = Now.Date
        cbComision_vent.Checked = False
        nudcomision_ventas.Value = 0
        rdNo_trasp.Checked = False
        rdSi_trasp.Checked = False
        cbCarro_ventas.Focus()
    End Sub
    Sub cargarrevend()
        conn = objetoconexion.AbrirCon
        Dim query As String = "Select CONCAT(apelli_revend,' ',nom_revend) as info2, id_revend FROM revendedores;"
        Dim adpt As New MySqlDataAdapter(query, conn)
        Dim ds As New DataSet()
        adpt.Fill(ds)
        cbrevendedor_ventas.DataSource = ds.Tables(0)
        cbrevendedor_ventas.DisplayMember = "info2"
        cbrevendedor_ventas.ValueMember = "id_revend"
        conn.Close()
        conn.Dispose()
    End Sub
    Sub cargarclientes()
        conn = objetoconexion.AbrirCon
        Dim query As String = "Select * FROM clientes;"
        Dim adpt As New MySqlDataAdapter(query, conn)
        Dim ds As New DataSet()
        adpt.Fill(ds)
        cbcliente_cliente.DataSource = ds.Tables(0)
        cbcliente_cliente.DisplayMember = "nom_clien"
        cbcliente_cliente.ValueMember = "id_clien"
        conn.Close()
        conn.Dispose()
    End Sub
    Sub carroselec()
        If cbCarro_ventas.SelectedValue = 0 Then
            Exit Sub
        Else
            conn = objetoconexion.AbrirCon
            Dim query As String = "Select CONCAT(año_carro,' ', marca_carro,' ', modelo_carro) as info1_car FROM info_carro WHERE id_carro='" + cbCarro_ventas.SelectedValue.ToString + "';"
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
    Sub cargarcarrito()
        conn = objetoconexion.AbrirCon
        Dim query As String = "Select * FROM info_carro;"
        Dim adpt As New MySqlDataAdapter(query, conn)
        Dim ds As New DataSet()
        adpt.Fill(ds)
        cbCarro_ventas.DataSource = ds.Tables(0)
        cbCarro_ventas.DisplayMember = "vin_carro"
        cbCarro_ventas.ValueMember = "id_carro"
        conn.Close()
        conn.Dispose()
    End Sub
    Sub mostrar()
        conn = objetoconexion.AbrirCon
        Dim query As String = "SELECT v.id_venta as 'ID',c.nom_clien as 'Nombre del Cliente', CASE WHEN v.traspaso_venta = 0 THEN 'No' WHEN v.traspaso_venta = 1 THEN 'Si' END AS 'Traspaso', v.fecha_venta as 'Fecha de Venta', ifc.vin_carro as 'VIN', ifc.año_carro as 'Año', ifc.marca_carro as 'Marca', ifc.modelo_carro as 'Modelo', ifc.color_carro as 'Color', CONCAT(ifc.millaje_carro,' mi') as 'Millaje', CONCAT(r.apelli_revend,' ', r.nom_revend) as 'Revendedor', v.comision_venta as 'Comisión', v.ganancia_venta as 'Ganancia', v.total_venta as 'Total de Venta' FROM ventas v INNER JOIN info_carro ifc ON v.id_carro = ifc.id_carro INNER JOIN revendedores r ON v.id_revend= r.id_revend INNER JOIN clientes c ON v.id_clien = c.id_clien;"
        Dim adpt As New MySqlDataAdapter(query, conn)
        Dim ds As New DataSet()
        adpt.Fill(ds)
        dgvventas.DataSource = ds.Tables(0)
        conn.Close()
        conn.Dispose()
    End Sub
    Private Sub Guna2TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1230456789- "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub cbComision_vent_CheckedChanged(sender As Object, e As EventArgs) Handles cbComision_vent.CheckedChanged
        If cbComision_vent.Checked = True Then
            Guna2GroupBox1.Enabled = True
        Else
            Guna2GroupBox1.Enabled = False
        End If
    End Sub
    Private Sub cbCarro_ventas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCarro_ventas.SelectedIndexChanged
        i += 1
        If i >= 4 Then
            carroselec()
        End If
    End Sub
    Private Sub btnnew_ventas_Click(sender As Object, e As EventArgs) Handles btnnew_ventas.Click
        limpiar()
        cbCarro_ventas.SelectedIndex = -1
        tbCarroSelec_CompraCar.Clear()
        btnsave_ventas.Enabled = True
    End Sub
    Private Sub btnsave_ventas_Click(sender As Object, e As EventArgs) Handles btnsave_ventas.Click
        Try
            If cbCarro_ventas.SelectedValue = 0 Or cbcliente_cliente.SelectedIndex = -1 Or (rdSi_trasp.Checked = False And rdNo_trasp.Checked = False) Then
                MessageBox.Show("ALGUN CAMPO ESTÁ VACÍO", "ERROR AL GUARDAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                conn = objetoconexion.AbrirCon
                cmd = conn.CreateCommand
                cmd.CommandText = "insert into ventas(id_carro,id_revend,comision_venta,total_venta,ganancia_venta,id_clien,fecha_venta,traspaso_venta)values(@car,@rev,@com,@tot,@gan,@cli,@fech,@tras);"
                cmd.Parameters.AddWithValue("@car", cbCarro_ventas.SelectedValue.ToString)
                If cbComision_vent.Checked = False Then
                    cmd.Parameters.AddWithValue("@rev", CStr(3))
                    cmd.Parameters.AddWithValue("@com", CStr(0))
                ElseIf cbComision_vent.Checked = True Then
                    cmd.Parameters.AddWithValue("@rev", cbrevendedor_ventas.SelectedValue.ToString)
                    cmd.Parameters.AddWithValue("@com", nudcomision_ventas.Value)
                End If
                cmd.Parameters.AddWithValue("@tot", nudtotal_ventas.Value)
                cmd.Parameters.AddWithValue("@gan", nudganancias_ventas.Value)
                cmd.Parameters.AddWithValue("@cli", cbcliente_cliente.SelectedValue.ToString)
                cmd.Parameters.AddWithValue("@fech", dtpFecha_CompraCar.Value.Date)
                If rdSi_trasp.Checked = True Then
                    cmd.Parameters.AddWithValue("@tras", CStr(1))
                ElseIf rdNo_trasp.Checked = True Then
                    cmd.Parameters.AddWithValue("@tras", CStr(0))
                End If
                cmd.ExecuteNonQuery()
                conn.Close()
                conn.Dispose()
                mostrar()
                limpiar()
                cbCarro_ventas.SelectedIndex = -1
                tbCarroSelec_CompraCar.Clear()
                btnsave_ventas.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
End Class