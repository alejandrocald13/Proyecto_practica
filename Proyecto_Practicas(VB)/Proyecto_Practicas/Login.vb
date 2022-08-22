Imports MySql.Data.MySqlClient
Public Class Login
    Dim conn As New MySqlConnection
    Dim objetoconexion As New conexion
    Dim cmd As MySqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bCerrar.Click
        Me.Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles bMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
