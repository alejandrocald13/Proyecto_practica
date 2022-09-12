Imports MySql.Data.MySqlClient
Public Class Revendedores
    Dim cmd As MySqlCommand
    Dim conn As New MySqlConnection
    Dim objetoconexion As New conexion
    Dim i As Integer
    Sub limpiar()
        tbID_reven.Clear()
        tbNombre_reven.Clear()
        tbApellido_revend.Clear()
        tbCUI_reven.Clear()
        tbNum_reven.Clear()
        tbNombre_reven.Focus()
    End Sub
    Sub mostrar()
        conn = objetoconexion.AbrirCon
        Dim query As String = "SELECT id_revend as 'ID', CONCAT(apelli_revend, ' , ',nom_revend) as 'Nombre Completo',CUI_revend as 'CUI', num_revend as 'Número' FROM revendedores;"
        Dim adpt As New MySqlDataAdapter(query, conn)
        Dim ds As New DataSet()
        adpt.Fill(ds)
        dgvRevendedores.DataSource = ds.Tables(0)
        conn.Close()
        conn.Dispose()
    End Sub
    Private Sub Revendedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
        tbNombre_reven.Focus()
        Guna2Button2.Enabled = False
        Guna2Button3.Enabled = False
        Guna2Button4.Enabled = False
    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        limpiar()
        Guna2Button2.Enabled = True
    End Sub
    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        conn = objetoconexion.AbrirCon
        Try
            If tbNombre_reven.Text = "" Or tbApellido_revend.Text = "" Or tbCUI_reven.Text = "" Or tbNum_reven.Text = "" Then
                MessageBox.Show("ALGUN CAMPO ESTÁ VACÍO", "ERROR AL MODIFICAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                cmd = conn.CreateCommand
                cmd.CommandText = "UPDATE revendedores SET nom_revend=@nom,apelli_revend=@apell,CUI_revend=@CUI, num_revend=@num WHERE id_revend=@id"
                cmd.Parameters.AddWithValue("@id", tbID_reven.Text)
                cmd.Parameters.AddWithValue("@nom", tbNombre_reven.Text)
                cmd.Parameters.AddWithValue("@apell", tbApellido_revend.Text)
                cmd.Parameters.AddWithValue("@CUI", tbCUI_reven.Text)
                cmd.Parameters.AddWithValue("@num", tbNum_reven.Text)
                cmd.ExecuteNonQuery()
                conn.Close()
                conn.Dispose()
                mostrar()
                limpiar()
                Guna2Button3.Enabled = False
                Guna2Button4.Enabled = False
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub dgvRevendedores_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRevendedores.CellContentClick
        Guna2Button2.Enabled = False
        Dim row As DataGridViewRow = dgvRevendedores.CurrentRow
        Try
            tbID_reven.Text = row.Cells(0).Value.ToString()
            Dim x = row.Cells(1).Value.ToString()
            tbApellido_revend.Text = x.Split(" ")(0) & " " & x.Split(" ")(1)
            tbNombre_reven.Text = x.Split(" ")(3) & " " & x.Split(" ")(4)
            tbCUI_reven.Text = row.Cells(2).Value.ToString()
            tbNum_reven.Text = row.Cells(3).Value.ToString()
            Guna2Button3.Enabled = True
            Guna2Button4.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        conn = objetoconexion.AbrirCon
        Try
            If tbNombre_reven.Text = "" Or tbApellido_revend.Text = "" Or tbCUI_reven.Text = "" Or tbNum_reven.Text = "" Then
                MessageBox.Show("ALGUN CAMPO ESTÁ VACÍO", "ERROR AL GUARDAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                cmd = conn.CreateCommand
                cmd.CommandText = "insert into revendedores(id_revend,nom_revend,apelli_revend,CUI_revend, num_revend)values(NULL,@nom,@apell,@CUI,@num);"
                cmd.Parameters.AddWithValue("@nom", tbNombre_reven.Text)
                cmd.Parameters.AddWithValue("@apell", tbApellido_revend.Text)
                cmd.Parameters.AddWithValue("@CUI", tbCUI_reven.Text)
                cmd.Parameters.AddWithValue("@num", tbNum_reven.Text)
                cmd.ExecuteNonQuery()
                conn.Close()
                conn.Dispose()
                mostrar()
                limpiar()
                Guna2Button2.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        If MessageBox.Show("¿Estás seguro de borrar la fila presionada?" & vbCrLf & "Esta acción no se puede deshacer.", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = vbOK Then
            conn = objetoconexion.AbrirCon
            Try
                cmd = conn.CreateCommand
                cmd.CommandText = "delete from revendedores where id_revend=@id"
                cmd.Parameters.AddWithValue("@id", tbID_reven.Text)
                cmd.ExecuteNonQuery()
                conn.Close()
                conn.Dispose()
                mostrar()
                limpiar()
            Catch ex As Exception
            End Try
        Else
            limpiar()
            Guna2Button3.Enabled = False
            Guna2Button4.Enabled = False
            Exit Sub
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Login.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub tbNombre_reven_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbNombre_reven.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZáéíóúÁÉÍÓÚ "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tbApellido_revend_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbApellido_revend.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZáéíóúÁÉÍÓÚ "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tbCUI_reven_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbCUI_reven.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "1230456789 "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tbNum_reven_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbNum_reven.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "1234567890 "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
End Class