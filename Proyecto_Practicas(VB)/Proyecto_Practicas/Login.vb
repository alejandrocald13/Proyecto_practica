Imports MySql.Data.MySqlClient
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Security.Cryptography
Public Class Login
    Dim cont = 0
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
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
                Dim codigo As New UnicodeEncoding()
                Dim SHA As New SHA256CryptoServiceProvider()
                Dim clave As String
                clave = tbPswd.Text
                Dim hash() As Byte = SHA.ComputeHash(codigo.GetBytes(clave))
                Dim nuevaclave As String
                nuevaclave = Convert.ToBase64String(hash)
                cmd.CommandText = "SELECT user from users WHERE user='" & tbUser.Text & "' AND psw='" & nuevaclave & "';"
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
    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
End Class
