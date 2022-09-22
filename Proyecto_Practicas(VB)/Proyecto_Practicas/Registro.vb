Imports MySql.Data.MySqlClient
Imports System.Runtime.InteropServices
Public Class Registro
    Public a As Integer = 0
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Sub limpiar()
        tbNomC_regis.Clear()
        tbCorreo_regis.Clear()
        cbpuesto_regis.SelectedIndex = -1
        tbuser_regis.Clear()
        tbpwsd_regis.Clear()
        tbNomC_regis.Focus()
    End Sub
    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Private Sub tbencar_repar_TextChanged(sender As Object, e As EventArgs) Handles tbCorreo_regis.TextChanged
        Dim regexPattern As String = "^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}$"
        Dim emailRegEx As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex(regexPattern)
        Dim result As Boolean = emailRegEx.IsMatch(tbCorreo_regis.Text)
        If tbCorreo_regis.Text = "" Then
            Label2.Text = "Ingresa tu Correo Electrónico"
            Label2.ForeColor = Color.Blue
        Else
            If Not result Then
                Label2.Text = "Correo Inválido X"
                Label2.ForeColor = Color.Red
                a = 0
            End If
            If result Then
                Label2.Text = "Correo Válido ✓"
                Label2.ForeColor = Color.Green
                a = 1
            End If
        End If
    End Sub

    Private Sub bNew_Click(sender As Object, e As EventArgs) Handles bDelete.Click
        limpiar()
    End Sub
    Private Sub Registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = "Ingresa tu Correo Electrónico"
        Label2.ForeColor = Color.Blue
    End Sub
End Class