Imports MySql.Data.MySqlClient
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Security.Cryptography
Public Class Registro
    Public a, b As Integer
    Dim cont, cont1 As Integer
    Dim cmd As MySqlCommand
    Dim conn As New MySqlConnection
    Dim objetoconexion As New conexion
    Dim CuRWidth As Integer = Me.Width
    Dim CuRHeight As Integer = Me.Height
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Sub cargarpuesto()
        conn = objetoconexion.AbrirCon
        Dim query As String = "Select * FROM puestos;"
        Dim adpt As New MySqlDataAdapter(query, conn)
        Dim ds As New DataSet()
        adpt.Fill(ds)
        cbpuesto_regis.DataSource = ds.Tables(0)
        cbpuesto_regis.DisplayMember = "puesto"
        cbpuesto_regis.ValueMember = "id_puestos"
        conn.Close()
        conn.Dispose()
    End Sub
    Sub limpiar()
        tbNomC_regis.Clear()
        tbCorreo_regis.Clear()
        cbpuesto_regis.SelectedIndex = -1
        tbuser_regis.Clear()
        tbpwsd_regis.Clear()
        Label3.Text = ""
        tbpswconf_regis.Clear()
        tbNomC_regis.Focus()
    End Sub
    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs)
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
        If Login.token <> 1 And Login.token <> 2 Then
            MessageBox.Show("No tienes el Acceso Total a este formulario." & vbCrLf & "Si crees que se trata de un error intenta iniciar sesión de nuevo.", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
            For Each Ctrl As Control In Controls
                If Ctrl.ToString <> "Guna.UI2.WinForms.Guna2DataGridView" Then
                    Ctrl.Enabled = False
                End If
            Next
        Else
            Label2.Text = "Ingresa tu Correo Electrónico"
            Label2.ForeColor = Color.Blue
            cargarpuesto()
            cbpuesto_regis.SelectedIndex = -1
        End If
    End Sub
    Private Sub bregister_Click(sender As Object, e As EventArgs) Handles bregister.Click
        If b = 1 And a = 1 Then
            Dim codigo As New UnicodeEncoding()
            Dim SHA As New SHA256CryptoServiceProvider()
            Dim clave As String
            clave = tbpwsd_regis.Text
            Dim hash() As Byte = SHA.ComputeHash(codigo.GetBytes(clave))
            Dim nuevaclave As String
            nuevaclave = Convert.ToBase64String(hash)
            Try
                Dim cmd2 As MySqlCommand = New MySqlCommand
                conn = objetoconexion.AbrirCon
                cmd2.Connection = conn
                cmd2.CommandText = "Select * FROM users WHERE user='" + tbuser_regis.Text + "';"
                Dim r As MySqlDataReader
                r = cmd2.ExecuteReader
                If r.HasRows <> True Then
                    r.Read()
                    conn.Close()
                    conn.Dispose()
                    If tbNomC_regis.Text = Nothing Or tbCorreo_regis.Text = Nothing Or cbpuesto_regis.SelectedIndex = -1 Or tbuser_regis.Text = Nothing Or tbpwsd_regis.Text = Nothing Then
                        MessageBox.Show("ALGUN CAMPO ESTÁ VACÍO", "ERROR AL GUARDAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        conn = objetoconexion.AbrirCon
                        cmd = conn.CreateCommand
                        cmd.CommandText = "insert into users(nombre_completo,correo,id_puesto,user,psw)values(@nom,@cor,@pue,@user,@psw);"
                        cmd.Parameters.AddWithValue("@nom", tbNomC_regis.Text)
                        cmd.Parameters.AddWithValue("@cor", tbCorreo_regis.Text)
                        cmd.Parameters.AddWithValue("@pue", cbpuesto_regis.SelectedValue.ToString)
                        cmd.Parameters.AddWithValue("@user", tbuser_regis.Text)
                        cmd.Parameters.AddWithValue("@psw", nuevaclave)
                        cmd.ExecuteNonQuery()
                        conn.Close()
                        conn.Dispose()
                        limpiar()
                        cbpuesto_regis.SelectedIndex = -1
                        MessageBox.Show("Tus datos fueron registrados correctamente.", "REGISTRO EXITOSO", MessageBoxButtons.OK)
                    End If
                Else
                    MessageBox.Show("Vaya, parece que el Nombre de Usuario ya está registrado. Por favor, eligir otro.", "ERROR AL REGISTRARSE", MessageBoxButtons.RetryCancel, MessageBoxIcon.Asterisk)
                    tbuser_regis.Clear()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        Else
            MessageBox.Show("Vaya, el correo electrónico no es válido o las contraseñas no coinciden.", "ERROR AL REGISTRARSE", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            limpiar()
        End If
    End Sub
    Private Sub bMpswd_Click(sender As Object, e As EventArgs) Handles bMpswd.Click
        If cont >= 1 Then
            tbpwsd_regis.PasswordChar = "•"
            cont = 0
        Else
            tbpwsd_regis.PasswordChar = ""
            cont += 1
        End If
    End Sub
    Private Sub tbuser_regis_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbuser_regis.KeyPress, tbpwsd_regis.KeyPress, tbpswconf_regis.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890_"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub tbNomC_regis_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbNomC_regis.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZáéíóúÁÉÍÓÚ "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Login.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Registro_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Dim RatioHeight As Double = (Me.Height - CuRHeight) / CuRHeight
        Dim RatioWidth As Double = (Me.Width - CuRWidth) / CuRWidth
        For Each Ctrl As Control In Controls
            If Ctrl.ToString = "System.Windows.Forms.Button, Text: " Then
                Ctrl.Top += Ctrl.Top * RatioHeight

            Else
                Ctrl.Width += Ctrl.Width * RatioWidth
                Ctrl.Left += Ctrl.Left * RatioWidth
                Ctrl.Top += Ctrl.Top * RatioHeight
            End If
        Next
        CuRHeight = Me.Height
        CuRWidth = Me.Width
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If cont1 >= 1 Then
            tbpswconf_regis.PasswordChar = "•"
            cont1 = 0
        Else
            tbpswconf_regis.PasswordChar = ""
            cont1 += 1
        End If
    End Sub
    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles tbpswconf_regis.TextChanged
        If tbpswconf_regis.Text = Nothing Or tbpswconf_regis.Text = Nothing Then
            Exit Sub
        End If
        If tbpwsd_regis.Text = tbpswconf_regis.Text Then
            Label3.Text = "Tus contraseñas coinciden ✓"
            Label3.ForeColor = Color.Green
            b = 1
        ElseIf tbpwsd_regis.Text <> tbpswconf_regis.Text Then
            Label3.Text = "¡Tus contraseñas no coinciden! X "
            Label3.ForeColor = Color.Red
            b = 0
        End If
    End Sub
End Class