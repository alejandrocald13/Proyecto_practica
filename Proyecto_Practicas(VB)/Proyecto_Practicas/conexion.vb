Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports System.Configuration
Public Class conexion
    Private servidor, database, usuario, password As String
    Public Sub New()
        Try
            servidor = System.Configuration.ConfigurationManager.AppSettings("servidor").ToString
            database = System.Configuration.ConfigurationManager.AppSettings("database").ToString
            usuario = System.Configuration.ConfigurationManager.AppSettings("usuario").ToString
            password = System.Configuration.ConfigurationManager.AppSettings("password").ToString
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Public Function AbrirCon() As MySqlConnection
        Dim MySqlConnectionString As String
        Dim conn As New MySqlConnection
        Try
            MySqlConnectionString = "Server=" + servidor + ";" & "Database=" + database + ";" & "Uid=" + usuario + ";" & "Pwd=" + password + ";Convert Zero Datetime=True;"
            conn = New MySqlConnection(MySqlConnectionString)
            conn.Open()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Return conn
    End Function
End Class
