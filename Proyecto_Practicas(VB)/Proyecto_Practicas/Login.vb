﻿Imports MySql.Data.MySqlClient
Public Class Login
    Dim cont = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bCerrar.Click
        Me.Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles bMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Sub l()
        tbUser.Clear()
        tbPswd.Clear()
    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If tbUser.Text = "" Or tbPswd.Text = "" Then
            MessageBox.Show("Vaya, parece que algun campo está vacío.", "ERROR AL INICIAR SESIÓN", MessageBoxButtons.RetryCancel, MessageBoxIcon.Asterisk)
        Else
            Dim cmd As MySqlCommand = New MySqlCommand
            Dim conn As New MySqlConnection
            Try
                cmd.Connection = conn
                conn.ConnectionString = "Server=localhost;Database=importadora_roca;Uid=root;Pwd=;Convert Zero Datetime=True;"
                conn.Open()
            Catch ex As Exception

            End Try
            Try
                cmd.CommandText = "SELECT user from users WHERE user='" & tbUser.Text & "' AND psw='" & tbPswd.Text & "';"
                Dim r As MySqlDataReader
                r = cmd.ExecuteReader
                If r.HasRows <> False Then
                    r.Read()
                    l()
                    MessageBox.Show("¡Inicio de Sesión Correcto!")
                    Carros.Show()
                    Me.Hide()
                Else
                    l()
                    MessageBox.Show("Datos incorrectos, por favor registrarse.", "ERROR AL INICIAR SESIÓN", MessageBoxButtons.RetryCancel, MessageBoxIcon.Asterisk)
                End If
                conn.Close()
                conn.Dispose()
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If
    End Sub
    Private Sub bMpswd_Click(sender As Object, e As EventArgs) Handles bMpswd.Click
        If cont >= 1 Then
            tbPswd.PasswordChar = "•"
            cont = 0
        Else
            tbPswd.PasswordChar = ""
            cont += 1
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    'Sub cargarcombox()
    '    conn.Open()
    '    Dim query As String = "Select * FROM proveedores;"
    '    Dim adpt As New MySqlDataAdapter(query, conn)
    '    Dim ds As New DataSet()
    '    adpt.Fill(ds)
    '    ComboBox2.DataSource = ds.Tables(0)
    '    ComboBox2.DisplayMember = "nombre_proveedor"
    '    ComboBox2.ValueMember = "id_proveedor"
    '    conn.Close()
    'End Sub
    'ELIMINAR
    'conn = objetoconexion.AbrirCon

    '    Try
    '        cmd = conn.CreateCommand
    '        cmd.CommandText = "delete from consolas_videojuegos where id_cons=@id"
    '        cmd.Parameters.AddWithValue("@id", TextBox10.Text)
    '        cmd.ExecuteNonQuery()
    '        conn.Close()
    '        conn.Dispose()
    '        mostrar3()
    '        limpiar3()
    '    Catch ex As Exception
    'End Try
End Class
