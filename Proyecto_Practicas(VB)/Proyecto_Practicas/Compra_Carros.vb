Imports MySql.Data.MySqlClient
Imports System.Runtime.InteropServices
Public Class Compra_Carros
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
    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        conn = objetoconexion.AbrirCon
        Try
            If tbLote_CompraCar.Text = "" Or tbDanoPrin_CompraCar.Text = "" Or cbCarro_CompraCar.SelectedIndex = -1 Then
                MessageBox.Show("ALGUN CAMPO ESTÁ VACÍO", "ERROR AL MODIFICAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                cmd = conn.CreateCommand
                cmd.CommandText = "UPDATE compra_carros SET id_carro=@carro,id_sub=@sub,lote_compra=@lote, daño_princ=@dano, fecha_compra=@fec, costosubasta_compra=@cost, ubicacion_compra=@ubi WHERE id_compras=@id"
                cmd.Parameters.AddWithValue("@id", tbID_CompraCar.Text)
                cmd.Parameters.AddWithValue("@carro", cbCarro_CompraCar.SelectedValue.ToString)
                cmd.Parameters.AddWithValue("@sub", cbSub_CompraCar.SelectedValue.ToString)
                cmd.Parameters.AddWithValue("@lote", tbLote_CompraCar.Text)
                cmd.Parameters.AddWithValue("@dano", tbDanoPrin_CompraCar.Text)
                cmd.Parameters.AddWithValue("@fec", dtpFecha_CompraCar.Value.Date)
                cmd.Parameters.AddWithValue("@cost", nudCosto_CompraCar.Value)
                cmd.Parameters.AddWithValue("@ubi", tbUbi_CompraCar.Text)
                cmd.ExecuteNonQuery()
                conn.Close()
                conn.Dispose()
                MsgBox("Modificado Correctamente", vbInformation, "Correcto")
                mostrar()
                l()
                cbCarro_CompraCar.SelectedIndex = -1
                cbSub_CompraCar.SelectedIndex = -1
                Guna2Button3.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        conn = objetoconexion.AbrirCon
        Try
            If tbLote_CompraCar.Text = "" Or tbDanoPrin_CompraCar.Text = "" Or cbCarro_CompraCar.SelectedIndex = -1 Then
                MessageBox.Show("ALGUN CAMPO ESTÁ VACÍO", "ERROR AL GUARDAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                cmd = conn.CreateCommand
                cmd.CommandText = "insert into compra_carros(id_compras,id_carro,id_sub,lote_compra, daño_princ,fecha_compra, costosubasta_compra, ubicacion_compra)values(NULL,@carro,@sub,@lote,@dano, @fec, @cost,@ubi);"
                cmd.Parameters.AddWithValue("@carro", cbCarro_CompraCar.SelectedValue.ToString)
                cmd.Parameters.AddWithValue("@sub", cbSub_CompraCar.SelectedValue.ToString)
                cmd.Parameters.AddWithValue("@lote", tbLote_CompraCar.Text)
                cmd.Parameters.AddWithValue("@dano", tbDanoPrin_CompraCar.Text)
                cmd.Parameters.AddWithValue("@fec", dtpFecha_CompraCar.Value.Date)
                cmd.Parameters.AddWithValue("@cost", nudCosto_CompraCar.Value)
                cmd.Parameters.AddWithValue("@ubi", tbUbi_CompraCar.Text)
                cmd.ExecuteNonQuery()
                conn.Close()
                conn.Dispose()
                MsgBox("Guardado Correctamente", vbInformation, "Correcto")
                mostrar()
                l()
                cbCarro_CompraCar.SelectedIndex = -1
                cbSub_CompraCar.SelectedIndex = -1
                Guna2Button2.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Sub l()
        tbID_CompraCar.Clear()
        tbLote_CompraCar.Clear()
        tbDanoPrin_CompraCar.Clear()
        tbCarroSelec_CompraCar.Clear()
        dtpFecha_CompraCar.Value = Now
        cbCarro_CompraCar.SelectedIndex = -1
        cbSub_CompraCar.SelectedIndex = -1
        tbCarroSelec_CompraCar.Clear()
        nudCosto_CompraCar.Value = 100
        tbUbi_CompraCar.Clear()
        cbCarro_CompraCar.Focus()
    End Sub
    Sub txtbox()
        If cbCarro_CompraCar.SelectedValue = 0 Then
            Exit Sub
        Else
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
        End If
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
        dgvCompraCarro.DataSource = ds.Tables(0)
        conn.Close()
        conn.Dispose()
    End Sub
    Private Sub Compra_Carros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            mostrar()
            cargarcarro()
            cargarsub()
            cbCarro_CompraCar.SelectedIndex = -1
            cbSub_CompraCar.SelectedIndex = -1
            Guna2Button2.Enabled = False
            Guna2Button3.Enabled = False
            dtpFecha_CompraCar.Value = Now
        End If
    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        i = 2
        l()
        cbCarro_CompraCar.SelectedIndex = -1
        cbSub_CompraCar.SelectedIndex = -1
        Guna2Button2.Enabled = True
        Guna2Button3.Enabled = False
    End Sub
    Private Sub cbCarro_CompraCar_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbCarro_CompraCar.SelectedIndexChanged
        i += 1
        If i >= 4 Then
            txtbox()
        End If
    End Sub
    Private Sub dgvCompraC_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCompraCarro.CellContentClick
        If Login.token <> 1 Then
            Guna2Button2.Enabled = False
            Guna2Button3.Enabled = False
        Else
            Guna2Button2.Enabled = False
            Dim row As DataGridViewRow = dgvCompraCarro.CurrentRow
            Try
                tbID_CompraCar.Text = row.Cells(0).Value.ToString()
                cbCarro_CompraCar.Text = row.Cells(1).Value.ToString()
                cbSub_CompraCar.Text = row.Cells(2).Value.ToString()
                tbLote_CompraCar.Text = row.Cells(3).Value.ToString()
                tbDanoPrin_CompraCar.Text = row.Cells(4).Value.ToString()
                dtpFecha_CompraCar.Value = row.Cells(5).Value
                nudCosto_CompraCar.Value = row.Cells(6).Value
                tbUbi_CompraCar.Text = row.Cells(7).Value.ToString()
                Guna2Button3.Enabled = True
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Login.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub tbDanoPrin_CompraCar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbDanoPrin_CompraCar.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZáéíóúÁÉÍÓÚ1234567890-().@#"",;: "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tbLote_CompraCar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbLote_CompraCar.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZáéíóúÁÉÍÓÚ1234567890-().@#"",;: "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tbUbi_CompraCar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbUbi_CompraCar.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZáéíóúÁÉÍÓÚ1234567890-().@#"",;: "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs)
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Private Sub Compra_Carros_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
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