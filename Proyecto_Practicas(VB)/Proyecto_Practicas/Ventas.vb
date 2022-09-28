Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Public Class Ventas
    Dim cmd As MySqlCommand
    Dim conn As New MySqlConnection
    Dim objetoconexion As New conexion
    Dim i As Integer
    Dim CuRWidth As Integer = Me.Width
    Dim CuRHeight As Integer = Me.Height
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Login.token <> 1 Then
            MessageBox.Show("No tienes el Acceso Total a este formulario." & vbCrLf & "Si crees que se trata de un error intenta iniciar sesión de nuevo.", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
            For Each Ctrl As Control In Controls
                If Ctrl.ToString <> "Guna.UI2.WinForms.Guna2DataGridView" Then
                    Ctrl.Enabled = False
                End If
            Next
            If Login.token = 2 Then
                mostrar()
            End If
        Else
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
        End If
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
        Dim query As String = "SELECT v.id_venta as 'ID',c.nom_clien as 'Nombre del Cliente', CASE WHEN v.traspaso_venta = 0 THEN 'No' WHEN v.traspaso_venta = 1 THEN 'Si' END AS 'Traspaso', v.fecha_venta as 'Fecha de Venta', ifc.vin_carro as 'VIN', ifc.año_carro as 'Año', ifc.marca_carro as 'Marca', ifc.modelo_carro as 'Modelo', ifc.color_carro as 'Color', CONCAT(ifc.millaje_carro,' mi') as 'Millaje', CONCAT(r.apelli_revend,' ', r.nom_revend) as 'Revendedor', CONCAT('Q',v.comision_venta) as 'Comisión', CONCAT('Q',v.ganancia_venta) as 'Ganancia', CONCAT('Q',v.total_venta) as 'Total de Venta' FROM ventas v INNER JOIN info_carro ifc ON v.id_carro = ifc.id_carro INNER JOIN revendedores r ON v.id_revend= r.id_revend INNER JOIN clientes c ON v.id_clien = c.id_clien;"
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

            If cbCarro_ventas.SelectedValue = 0 Or cbcliente_cliente.SelectedIndex = -1 Or (rdSi_trasp.Checked = False And rdNo_trasp.Checked = False) Or (cbComision_vent.Checked = True And cbrevendedor_ventas.SelectedIndex = -1) Then
                MessageBox.Show("ALGUN CAMPO ESTÁ VACÍO", "ERROR AL GUARDAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                Dim cmd2 As MySqlCommand = New MySqlCommand
                conn = objetoconexion.AbrirCon
                cmd2.Connection = conn
                cmd2.CommandText = "Select * FROM ventas WHERE id_carro='" + cbCarro_ventas.SelectedValue.ToString + "';"
                Dim r As MySqlDataReader
                r = cmd2.ExecuteReader
                If r.HasRows <> True Then
                    r.Read()
                    conn.Close()
                    conn.Dispose()
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
                    MsgBox("Guardado Correctamente", vbInformation, "Correcto")
                    mostrar()
                    limpiar()
                    cbCarro_ventas.SelectedIndex = -1
                    tbCarroSelec_CompraCar.Clear()
                    btnsave_ventas.Enabled = False
                Else
                    MessageBox.Show("Vaya, parece que el carro seleccionado ya está registrado. Si cometiste un error, intenta modificarlo.", "ERROR AL GUARDAR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Asterisk)
                    limpiar()
                    limpiar()
                End If
                btnsave_ventas.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Private Sub btnmodifi_ventas_Click(sender As Object, e As EventArgs) Handles btnmodifi_ventas.Click
        conn = objetoconexion.AbrirCon
        Try
            If cbCarro_ventas.SelectedValue = 0 Or cbcliente_cliente.SelectedIndex = -1 Or (rdSi_trasp.Checked = False And rdNo_trasp.Checked = False) Or (cbComision_vent.Checked = True And cbrevendedor_ventas.SelectedIndex = -1) Then
                MessageBox.Show("ALGUN CAMPO ESTÁ VACÍO", "ERROR AL MODIFICAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                cmd = conn.CreateCommand
                cmd.CommandText = "UPDATE ventas SET id_carro=@car,id_revend=@rev,comision_venta=@com,total_venta=@tot,ganancia_venta=@gan,id_clien=@cli,fecha_venta=@fech,traspaso_venta=@tras WHERE id_venta=@id"
                cmd.Parameters.AddWithValue("@id", tbID_CompraCar.Text)
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
                MsgBox("Modificado Correctamente", vbInformation, "Correcto")
                mostrar()
                limpiar()
                cbCarro_ventas.SelectedIndex = -1
                tbCarroSelec_CompraCar.Clear()
                btnmodifi_ventas.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub dgvventas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvventas.CellContentClick
        If Login.token <> 1 Then
            btnmodifi_ventas.Enabled = False
            btnsave_ventas.Enabled = False
        Else
            btnsave_ventas.Enabled = False
            Dim row As DataGridViewRow = dgvventas.CurrentRow
            Try
                tbID_CompraCar.Text = row.Cells(0).Value.ToString()
                cbcliente_cliente.Text = row.Cells(1).Value.ToString()
                Dim x = row.Cells(2).Value.ToString
                If x = "Si" Then
                    rdSi_trasp.Checked = True
                ElseIf x = "No" Then
                    rdNo_trasp.Checked = True
                End If
                dtpFecha_CompraCar.Value = row.Cells(3).Value.ToString()
                cbCarro_ventas.Text = row.Cells(4).Value.ToString()
                cbrevendedor_ventas.Text = row.Cells(10).Value.ToString()
                Dim s = row.Cells(11).Value.ToString
                nudcomision_ventas.Value = s.Split("Q")(1)
                If row.Cells(10).Value.ToString() <> "NAC NAC" Then
                    cbComision_vent.Checked = True
                Else
                    cbComision_vent.Checked = False
                End If
                Dim s2 = row.Cells(12).Value.ToString
                nudganancias_ventas.Value = s2.Split("Q")(1)
                Dim s3 = row.Cells(13).Value.ToString
                nudtotal_ventas.Value = s3.Split("Q")(1)
                btnmodifi_ventas.Enabled = True
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If
    End Sub
    Private Sub bCerrar_Click(sender As Object, e As EventArgs)
        Hide()
        Login.Close()
    End Sub
    Private Sub bMinimizar_Click(sender As Object, e As EventArgs)
        WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs)
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Private Sub Ventas_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Dim RatioHeight As Double = (Me.Height - CuRHeight) / CuRHeight
        Dim RatioWidth As Double = (Me.Width - CuRWidth) / CuRWidth
        For Each Ctrl As Control In Controls
            Ctrl.Width += Ctrl.Width * RatioWidth
            Ctrl.Left += Ctrl.Left * RatioWidth
            Ctrl.Top += Ctrl.Top * RatioHeight
            If Ctrl.ToString = "Guna.UI2.WinForms.Guna2DataGridView" Then
                Ctrl.Height += Ctrl.Height * RatioHeight
            End If
        Next
        CuRHeight = Me.Height
        CuRWidth = Me.Width
    End Sub
End Class