Imports MySql.Data.MySqlClient
Imports System.Runtime.InteropServices
Public Class Subasta
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
    Sub cle()
        tbID.Clear()
        tbNombre_Sub.Clear()
        tbURL_Sub.Clear()
        tbID.Focus()
    End Sub
    Sub mostrarsub()
        conn = objetoconexion.AbrirCon
        Dim query As String = "SELECT id_sub as 'ID', nombre_sub as 'Nombre',url_sub as 'URL' FROM subastas;"
        Dim adpt As New MySqlDataAdapter(query, conn)
        Dim ds As New DataSet()
        adpt.Fill(ds)
        dgvSubastas.DataSource = ds.Tables(0)
        conn.Close()
        conn.Dispose()
    End Sub
    Private Sub Subasta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarsub()
        Guna2Button2.Enabled = False
        Guna2Button3.Enabled = False
    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        cle()
        Guna2Button2.Enabled = True
    End Sub
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        conn = objetoconexion.AbrirCon
        Try
            If tbNombre_Sub.Text = "" Or tbURL_Sub.Text = "" Then
                MessageBox.Show("ALGUN CAMPO ESTÁ VACÍO", "ERROR AL GUARDAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                cmd = conn.CreateCommand
                cmd.CommandText = "insert into subastas(id_sub,nombre_sub,url_sub)values(NULL,@nom,@url);"
                cmd.Parameters.AddWithValue("@nom", tbNombre_Sub.Text)
                cmd.Parameters.AddWithValue("@url", tbURL_Sub.Text)
                cmd.ExecuteNonQuery()
                conn.Close()
                conn.Dispose()
                mostrarsub()
                cle()
                Guna2Button2.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        conn = objetoconexion.AbrirCon
        Try
            If tbNombre_Sub.Text = "" Or tbURL_Sub.Text = "" Then
                MessageBox.Show("ALGUN CAMPO ESTÁ VACÍO", "ERROR AL GUARDAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                cmd = conn.CreateCommand
                cmd.CommandText = "UPDATE subastas SET nombre_sub=@nom,url_sub=@url WHERE id_sub=@id"
                cmd.Parameters.AddWithValue("@id", tbID.Text)
                cmd.Parameters.AddWithValue("@nom", tbNombre_Sub.Text)
                cmd.Parameters.AddWithValue("@url", tbURL_Sub.Text)
                cmd.ExecuteNonQuery()
                conn.Close()
                conn.Dispose()
                mostrarsub()
                cle()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Private Sub dgvSubastas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSubastas.CellContentClick
        Guna2Button2.Enabled = False
        Dim row As DataGridViewRow = dgvSubastas.CurrentRow
        Try
            tbID.Text = row.Cells(0).Value.ToString()
            tbNombre_Sub.Text = row.Cells(1).Value.ToString()
            tbURL_Sub.Text = row.Cells(2).Value.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Login.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub tbNombre_Sub_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbNombre_Sub.KeyPress
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
    Private Sub Subasta_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
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