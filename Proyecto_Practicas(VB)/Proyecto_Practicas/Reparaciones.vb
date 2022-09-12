Imports MySql.Data.MySqlClient
Public Class Reparaciones
    Dim cmd As MySqlCommand
    Dim conn As New MySqlConnection
    Dim objetoconexion As New conexion
    Dim i = 0
    Sub loteselec()
        If cbCarro_repar.SelectedValue = 0 Then
            Exit Sub
        Else
            Try
                Dim cmd2 As MySqlCommand = New MySqlCommand
                conn = objetoconexion.AbrirCon
                cmd2.Connection = conn
                cmd2.CommandText = "Select * FROM compra_carros WHERE id_carro='" + cbCarro_repar.SelectedValue.ToString + "';"
                Dim r As MySqlDataReader
                r = cmd2.ExecuteReader
                If r.HasRows <> False Then
                    r.Read()
                    conn.Close()
                    conn.Dispose()
                    Dim query As String = "Select * FROM compra_carros WHERE id_carro='" + cbCarro_repar.SelectedValue.ToString + "';"
                    Dim adpt As New MySqlDataAdapter(cmd2.CommandText, conn)
                    Dim row As DataRow = Nothing
                    Using dt As New DataTable()
                        adpt.Fill(dt)
                        If (dt.Rows.Count > 0) Then
                            row = dt.Rows(0)
                        End If
                    End Using
                    tbLoteSelec_repar.Text = Convert.ToString(row("lote_compra"))
                    Label2.Text = Convert.ToString(row("id_compras"))
                    Label2.Visible = False
                Else
                    MessageBox.Show("Vaya, parece que el carro seleccionado, no tiene lote de Compra. Por favor, registra la compra del mismo.", "ERROR AL SELECCIONAR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Asterisk)
                    cbCarro_repar.SelectedIndex += -1
                End If
                conn.Close()
                conn.Dispose()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub
    Sub txt()
        If cbCarro_repar.SelectedValue = 0 Then
            Exit Sub
        Else
            conn = objetoconexion.AbrirCon
            Dim query As String = "Select CONCAT(año_carro,' ', marca_carro,' ', modelo_carro) as info1_car FROM info_carro WHERE id_carro='" + cbCarro_repar.SelectedValue.ToString + "';"
            Dim adpt As New MySqlDataAdapter(query, conn)
            Try
                Dim row As DataRow = Nothing
                Using dt As New DataTable()
                    adpt.Fill(dt)
                    If (dt.Rows.Count > 0) Then
                        row = dt.Rows(0)
                    End If
                End Using
                tbCarroSelec_repar.Text = Convert.ToString(row("info1_car"))
                conn.Close()
                conn.Dispose()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub
    Sub cargarcarro()
        conn = objetoconexion.AbrirCon
        Dim query As String = "Select * FROM info_carro;"
        Dim adpt As New MySqlDataAdapter(query, conn)
        Dim ds As New DataSet()
        adpt.Fill(ds)
        cbCarro_repar.DataSource = ds.Tables(0)
        cbCarro_repar.DisplayMember = "vin_carro"
        cbCarro_repar.ValueMember = "id_carro"
        conn.Close()
        conn.Dispose()
    End Sub
    Sub limpiar()
        tbID_repar.Clear()
        cbCarro_repar.SelectedIndex = -1
        tbLoteSelec_repar.Clear()
        nudCosto_repar.Value = 100
        tbCarroSelec_repar.Clear()
        tbencar_repar.Clear()
        tbDanos_repar.Clear()
        dtpEntrada_repar.Value = Now
        dtpEntrega_repar.Value = Now
        cbCarro_repar.Focus()
    End Sub
    Sub mostrar()
        conn = objetoconexion.AbrirCon
        Dim query As String = "SELECT r.id_reparaciones as 'ID', ifc.vin_carro as 'VIN', cc.lote_compra as 'Lote de Compra', r.danos_repar as 'Daños/Mantenimiento', r.encarg_reparacion as 'Encargado', r.fechae_reparacion as 'Fecha de Entrada', r.fechad_reparacion as 'Fecha de Entrega',CONCAT('Q',r.costo_reparacion) as 'Costo (Q)' FROM reparaciones r INNER JOIN info_carro ifc ON r.id_carro = ifc.id_carro INNER JOIN compra_carros cc ON cc.id_compras = r.id_compras;"
        Dim adpt As New MySqlDataAdapter(query, conn)
        Dim ds As New DataSet()
        adpt.Fill(ds)
        dgvRepar.DataSource = ds.Tables(0)
        conn.Close()
        conn.Dispose()
    End Sub
    Private Sub Reparaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
        cargarcarro()
        cbCarro_repar.SelectedIndex = -1
        bSave.Enabled = False
        bUpdate.Enabled = False
    End Sub
    Private Sub bNew_Click(sender As Object, e As EventArgs) Handles bNew.Click
        limpiar()
        limpiar()
        bSave.Enabled = True
    End Sub
    Private Sub cbCarro_repar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCarro_repar.SelectedIndexChanged
        i += 1
        If i >= 4 Then
            txt()
            loteselec()
        End If
    End Sub
    Private Sub bSave_Click(sender As Object, e As EventArgs) Handles bSave.Click
        conn = objetoconexion.AbrirCon
        Try
            Dim cmd2 As MySqlCommand = New MySqlCommand
            conn = objetoconexion.AbrirCon
            cmd2.Connection = conn
            cmd2.CommandText = "Select * FROM reparaciones WHERE id_carro='" + cbCarro_repar.SelectedValue.ToString + "';"
            Dim r As MySqlDataReader
            r = cmd2.ExecuteReader
            If r.HasRows <> True Then
                r.Read()
                conn.Close()
                conn.Dispose()
                If nudCosto_repar.Value = 100 Or tbencar_repar.Text = "" Or cbCarro_repar.SelectedIndex = -1 Then
                    MessageBox.Show("ALGUN CAMPO ESTÁ VACÍO", "ERROR AL GUARDAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    cmd = conn.CreateCommand
                    cmd.CommandText = "insert into reparaciones(id_carro,id_compras,costo_reparacion,encarg_reparacion,fechae_reparacion,fechad_reparacion,danos_repar)values(@car,@com,@cost,@encar, @fecha1,@fecha2,@danos);"
                    cmd.Parameters.AddWithValue("@car", cbCarro_repar.SelectedValue.ToString)
                    cmd.Parameters.AddWithValue("@com", Label2.Text)
                    cmd.Parameters.AddWithValue("@cost", nudCosto_repar.Value)
                    cmd.Parameters.AddWithValue("@encar", tbencar_repar.Text)
                    cmd.Parameters.AddWithValue("@fecha1", dtpEntrada_repar.Value.Date)
                    cmd.Parameters.AddWithValue("@fecha2", dtpEntrega_repar.Value.Date)
                    cmd.Parameters.AddWithValue("@danos", tbDanos_repar.Text)
                    cmd.ExecuteNonQuery()
                    conn.Close()
                    conn.Dispose()
                    mostrar()
                    limpiar()
                    cbCarro_repar.SelectedIndex = -1
                    bSave.Enabled = False
                End If
            Else
                MessageBox.Show("Vaya, parece que el carro seleccionado ya está registrado. Si cometiste un error, intenta modificarlo.", "ERROR AL GUARDAR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Asterisk)
                limpiar()
                limpiar()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Private Sub dgvRepar_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRepar.CellContentClick
        bSave.Enabled = False
        Dim row As DataGridViewRow = dgvRepar.CurrentRow
        Try
            tbID_repar.Text = row.Cells(0).Value.ToString()
            cbCarro_repar.Text = row.Cells(1).Value.ToString()
            tbDanos_repar.Text = row.Cells(3).Value.ToString()
            tbencar_repar.Text = row.Cells(4).Value.ToString()
            dtpEntrada_repar.Value = row.Cells(5).Value
            dtpEntrega_repar.Value = row.Cells(6).Value
            Dim x = row.Cells(7).Value.ToString()
            nudCosto_repar.Value = x.Split("Q")(1)
            bUpdate.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Private Sub bUpdate_Click(sender As Object, e As EventArgs) Handles bUpdate.Click
        conn = objetoconexion.AbrirCon
        Try
            Dim cmd2 As MySqlCommand = New MySqlCommand
            conn = objetoconexion.AbrirCon
            cmd2.Connection = conn
            cmd2.CommandText = "Select * FROM reparaciones WHERE id_carro='" + cbCarro_repar.SelectedValue.ToString + "';"
            Dim r As MySqlDataReader
            r = cmd2.ExecuteReader
            If r.HasRows <> True Then
                r.Read()
                conn.Close()
                conn.Dispose()
                If nudCosto_repar.Value = 100 Or tbencar_repar.Text = "" Or cbCarro_repar.SelectedIndex = -1 Then
                    MessageBox.Show("ALGUN CAMPO ESTÁ VACÍO", "ERROR AL MODIFICAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    cmd = conn.CreateCommand
                    cmd.CommandText = "UPDATE reparaciones SET id_carro=@car,id_compras=@com,costo_reparacion=@cost,encarg_reparacion=@encar,fechae_reparacion=@fecha1,fechad_reparacion=@fecha2,danos_repar=@danos WHERE id_reparaciones=@id"
                    cmd.Parameters.AddWithValue("@id", tbID_repar.Text)
                    cmd.Parameters.AddWithValue("@car", cbCarro_repar.SelectedValue.ToString)
                    cmd.Parameters.AddWithValue("@com", Label2.Text)
                    cmd.Parameters.AddWithValue("@cost", nudCosto_repar.Value)
                    cmd.Parameters.AddWithValue("@encar", tbencar_repar.Text)
                    cmd.Parameters.AddWithValue("@fecha1", dtpEntrada_repar.Value.Date)
                    cmd.Parameters.AddWithValue("@fecha2", dtpEntrega_repar.Value.Date)
                    cmd.Parameters.AddWithValue("@danos", tbDanos_repar.Text)
                    cmd.ExecuteNonQuery()
                    conn.Close()
                    conn.Dispose()
                    mostrar()
                    limpiar()
                    limpiar()
                    bUpdate.Enabled = False
                End If
            Else
                MessageBox.Show("Vaya, parece que el carro seleccionado ya está registrado. Selecciona otro.", "ERROR AL GUARDAR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Asterisk)
                limpiar()
                limpiar()
                bUpdate.Enabled = False
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Login.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub tbencar_repar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbencar_repar.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZáéíóúÁÉÍÓÚ "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tbDanos_repar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbDanos_repar.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZáéíóúÁÉÍÓÚ1234567890-().@#"",;: "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
End Class