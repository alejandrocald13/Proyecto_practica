﻿Imports MySql.Data.MySqlClient
Imports System.Runtime.InteropServices
Public Class Importacion_Carro
    Dim cmd As MySqlCommand
    Dim conn As New MySqlConnection
    Dim objetoconexion As New conexion
    Dim i = 0
    Dim CuRWidth As Integer = Me.Width
    Dim CuRHeight As Integer = Me.Height
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Sub clin()
        tbID_impo.Clear()
        cbCarro_Compraimpor.SelectedIndex = -1
        tbLoteSelec_Impo.Clear()
        tbencar_impor.Clear()
        tbCarroSelec_CompraCar.Clear()
        tbmeto_impor.Clear()
        Guna2TextBox1.Clear()
        nudCosto_impor.Value = 100
        cbCarro_Compraimpor.Focus()
    End Sub
    Sub mostrar()
        conn = objetoconexion.AbrirCon
        Dim query As String = "SELECT i.id_impo as 'ID', ifc.vin_carro as 'VIN', cc.lote_compra as 'Lote de Compra', i.encarg_impo as 'Encargado', i.metodo_impo as 'Método', CONCAT('Q',i.costo_impo) as 'Costo (Q)' FROM importaciones i INNER JOIN info_carro ifc ON i.id_carro = ifc.id_carro INNER JOIN compra_carros cc ON cc.id_compras =i.id_compras;"
        Dim adpt As New MySqlDataAdapter(query, conn)
        Dim ds As New DataSet()
        adpt.Fill(ds)
        dgvImpo.DataSource = ds.Tables(0)
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
                    tbLoteSelec_Impo.Text = Convert.ToString(row("lote_compra"))
                    Label2.Text = Convert.ToString(row("id_compras"))
                    Label2.Visible = False
                Else
                    MessageBox.Show("Vaya, parece que el carro seleccionado, no tiene lote de Compra. Por favor, registra la compra del mismo.", "ERROR AL SELECCIONAR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Asterisk)
                    cbCarro_Compraimpor.SelectedIndex = -1
                End If
                conn.Close()
                conn.Dispose()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        End If
    End Sub
    Sub ubiselec()
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
                    Guna2TextBox1.Text = Convert.ToString(row("ubicacion_compra"))
                Else
                    MessageBox.Show("Vaya, parece que el carro seleccionado, no tiene ubicación de compra. Por favor, registra la compra del mismo.", "ERROR AL SELECCIONAR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Asterisk)
                    cbCarro_Compraimpor.SelectedIndex = -1
                End If
                conn.Close()
                conn.Dispose()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        End If
    End Sub
    Private Sub Importacion_Carro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            cargarcarrito()
            cbCarro_Compraimpor.SelectedIndex = -1
            btnguarda_impor.Enabled = False
            Btnmodi_impor.Enabled = False
        End If
    End Sub
    Private Sub cbCarro_Compraimpor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCarro_Compraimpor.SelectedIndexChanged
        i += 1
        If i >= 4 Then
            carroselec()
            loteselec()
            ubiselec()
        End If
    End Sub
    Private Sub btnnew_impor_Click(sender As Object, e As EventArgs) Handles btnnew_impor.Click
        clin()
        btnguarda_impor.Enabled = True
    End Sub
    Private Sub btnguarda_impor_Click(sender As Object, e As EventArgs) Handles btnguarda_impor.Click
        Try
            Dim cmd2 As MySqlCommand = New MySqlCommand
            conn = objetoconexion.AbrirCon
            cmd2.Connection = conn
            cmd2.CommandText = "Select * FROM importaciones WHERE id_carro='" + cbCarro_Compraimpor.SelectedValue.ToString + "';"
            Dim r As MySqlDataReader
            r = cmd2.ExecuteReader
            If r.HasRows <> True Then
                r.Read()
                conn.Close()
                conn.Dispose()
                If tbencar_impor.Text = "" Or tbmeto_impor.Text = "" Or cbCarro_Compraimpor.SelectedIndex = -1 Then
                    MessageBox.Show("ALGUN CAMPO ESTÁ VACÍO", "ERROR AL GUARDAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    conn = objetoconexion.AbrirCon
                    cmd = conn.CreateCommand
                    cmd.CommandText = "insert into importaciones(id_carro,id_compras,encarg_impo,metodo_impo,costo_impo)values(@car,@com,@encar,@met, @cost);"
                    cmd.Parameters.AddWithValue("@car", cbCarro_Compraimpor.SelectedValue.ToString)
                    cmd.Parameters.AddWithValue("@com", Label2.Text)
                    cmd.Parameters.AddWithValue("@encar", tbencar_impor.Text)
                    cmd.Parameters.AddWithValue("@met", tbmeto_impor.Text)
                    cmd.Parameters.AddWithValue("@cost", nudCosto_impor.Value)
                    cmd.ExecuteNonQuery()
                    conn.Close()
                    conn.Dispose()
                    MsgBox("Guardado Correctamente", vbInformation, "Correcto")

                    mostrar()
                    clin()
                    cbCarro_Compraimpor.SelectedIndex = -1
                    btnguarda_impor.Enabled = False
                End If
            Else
                MessageBox.Show("Vaya, parece que el carro seleccionado ya está registrado. Si cometiste un error, intenta modificarlo.", "ERROR AL GUARDAR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Asterisk)
                clin()
                clin()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Private Sub dgvCompraC_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvImpo.CellContentClick
        If Login.token <> 1 Then
            btnguarda_impor.Enabled = False
            Btnmodi_impor.Enabled = False
        Else
            btnguarda_impor.Enabled = False
            Dim row As DataGridViewRow = dgvImpo.CurrentRow
            Try
                tbID_impo.Text = row.Cells(0).Value.ToString()
                cbCarro_Compraimpor.Text = row.Cells(1).Value.ToString()
                tbencar_impor.Text = row.Cells(3).Value.ToString()
                tbmeto_impor.Text = row.Cells(4).Value.ToString()
                Dim x = row.Cells(5).Value.ToString()
                nudCosto_impor.Value = x.Split("Q")(1)
                Btnmodi_impor.Enabled = True
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If
    End Sub
    Private Sub Btnmodi_impor_Click(sender As Object, e As EventArgs) Handles Btnmodi_impor.Click
        conn = objetoconexion.AbrirCon
        Try
            If tbencar_impor.Text = "" Or tbmeto_impor.Text = "" Or cbCarro_Compraimpor.SelectedIndex = -1 Then
                MessageBox.Show("ALGUN CAMPO ESTÁ VACÍO", "ERROR AL MODIFICAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                cmd = conn.CreateCommand
                cmd.CommandText = "UPDATE importaciones SET id_carro=@car,id_compras=@com,encarg_impo=@encar,metodo_impo=@met,costo_impo=@cost WHERE id_impo=@id"
                cmd.Parameters.AddWithValue("@id", tbID_impo.Text)
                cmd.Parameters.AddWithValue("@car", cbCarro_Compraimpor.SelectedValue.ToString)
                cmd.Parameters.AddWithValue("@com", Label2.Text)
                cmd.Parameters.AddWithValue("@encar", tbencar_impor.Text)
                cmd.Parameters.AddWithValue("@met", tbmeto_impor.Text)
                cmd.Parameters.AddWithValue("@cost", nudCosto_impor.Value)
                cmd.ExecuteNonQuery()
                conn.Close()
                conn.Dispose()
                MsgBox("Modificado Correctamente", vbInformation, "Correcto")
                mostrar()
                clin()
                Btnmodi_impor.Enabled = False
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Login.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub tbencar_impor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbencar_impor.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZáéíóúÁÉÍÓÚ "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub tbmeto_impor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbmeto_impor.KeyPress
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
    Private Sub Importacion_Carro_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
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