Imports MySql.Data.MySqlClient
Public Class Subasta
    Dim cmd As MySqlCommand
    Dim conn As New MySqlConnection
    Dim objetoconexion As New conexion
    Dim i As Integer
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
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Login.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WindowState = FormWindowState.Minimized
    End Sub
End Class