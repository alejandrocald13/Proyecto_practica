Imports MySql.Data.MySqlClient
Imports System.Runtime.InteropServices
Public Class clientes
    Dim cmd As MySqlCommand
    Dim conn As New MySqlConnection
    Dim objetoconexion As New conexion
    Public a As Integer = 0
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Sub mostrar()
        conn = objetoconexion.AbrirCon
        Dim query As String = "SELECT id_clien as 'ID', nom_clien as 'Nombre y Apellido', CUI_clien as 'CUI', direc_clien as 'Dirección Completa', correo_clien as 'Correo Electrónico', num_clien as 'Número Telefónico', NIT_clien as 'NIT' FROM clientes"
        Dim adpt As New MySqlDataAdapter(query, conn)
        Dim ds As New DataSet()
        adpt.Fill(ds)
        dgvClient.DataSource = ds.Tables(0)
        conn.Close()
        conn.Dispose()
    End Sub
    Sub limpiar()
        tbID_client.Clear()
        tbNomAp_client.Clear()
        tbCUI_client.Clear()
        tbcorreo_client.Clear()
        tbNum_client.Clear()
        tbNIT_client.Clear()
        tbDirec_client.Clear()
        tbNomAp_client.Focus()
    End Sub
    Private Sub tbcorreo_client_TextChanged(sender As Object, e As EventArgs) Handles tbcorreo_client.TextChanged
        Dim regexPattern As String = "^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}$"
        Dim emailRegEx As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex(regexPattern)
        Dim result As Boolean = emailRegEx.IsMatch(tbcorreo_client.Text)
        If tbcorreo_client.Text = "" Then
            Label1.Text = ""
        Else
            If Not result Then
                Label1.Text = "Correo Inválido X"
                Label1.ForeColor = Color.Red
                a = 0
            End If
            If result Then
                Label1.Text = "Correo Válido ✓"
                Label1.ForeColor = Color.Green
                a = 1
            End If
        End If

    End Sub
    Private Sub clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = Nothing
        mostrar()
        btnguarda_client.Enabled = False
        Btnmodi_cliente.Enabled = False
    End Sub
    Private Sub btnnew_client_Click(sender As Object, e As EventArgs) Handles btnnew_client.Click
        limpiar()
        btnguarda_client.Enabled = True
    End Sub
    Private Sub btnguarda_client_Click(sender As Object, e As EventArgs) Handles btnguarda_client.Click
        conn = objetoconexion.AbrirCon
        Try
            If a = 0 Then
                MessageBox.Show("EL CORREO NO ES VÁLIDO", "ERROR AL GUARDAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Exit Sub
            End If
            If tbNomAp_client.Text = "" Or tbCUI_client.Text = "" Or tbNIT_client.Text = "" Then
                MessageBox.Show("ALGUN CAMPO ESTÁ VACÍO", "ERROR AL GUARDAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                cmd = conn.CreateCommand
                cmd.CommandText = "insert into clientes(nom_clien,direc_clien,correo_clien,num_clien,NIT_clien,CUI_clien)values(@nom,@direc,@correo,@num, @NIT,@CUI);"
                cmd.Parameters.AddWithValue("@nom", tbNomAp_client.Text)
                cmd.Parameters.AddWithValue("@direc", tbDirec_client.Text)
                cmd.Parameters.AddWithValue("@correo", tbcorreo_client.Text)
                cmd.Parameters.AddWithValue("@num", tbNum_client.Text)
                cmd.Parameters.AddWithValue("@NIT", tbNIT_client.Text)
                cmd.Parameters.AddWithValue("@CUI", tbCUI_client.Text)
                cmd.ExecuteNonQuery()
                conn.Close()
                conn.Dispose()
                mostrar()
                limpiar()
                btnguarda_client.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Private Sub Btnmodi_cliente_Click(sender As Object, e As EventArgs) Handles Btnmodi_cliente.Click
        conn = objetoconexion.AbrirCon
        Try
            If a = 0 Then
                MessageBox.Show("EL CORREO NO ES VÁLIDO", "ERROR AL MODIFICAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Exit Sub
            End If
            If tbNomAp_client.Text = "" Or tbCUI_client.Text = "" Or tbNIT_client.Text = "" Then
                MessageBox.Show("ALGUN CAMPO ESTÁ VACÍO", "ERROR AL MODIFICAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                cmd = conn.CreateCommand
                cmd.CommandText = "UPDATE clientes SET nom_clien=@nom,direc_clien=@direc,correo_clien=@correo,num_clien=@num,NIT_clien=@NIT,CUI_clien=@CUI WHERE id_clien=@id"
                cmd.Parameters.AddWithValue("@id", tbID_client.Text)
                cmd.Parameters.AddWithValue("@nom", tbNomAp_client.Text)
                cmd.Parameters.AddWithValue("@direc", tbDirec_client.Text)
                cmd.Parameters.AddWithValue("@correo", tbcorreo_client.Text)
                cmd.Parameters.AddWithValue("@num", tbNum_client.Text)
                cmd.Parameters.AddWithValue("@NIT", tbNIT_client.Text)
                cmd.Parameters.AddWithValue("@CUI", tbCUI_client.Text)
                cmd.ExecuteNonQuery()
                conn.Close()
                conn.Dispose()
                mostrar()
                limpiar()
                Btnmodi_cliente.Enabled = False
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub dgvClient_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClient.CellContentClick
        btnguarda_client.Enabled = False
        Dim row As DataGridViewRow = dgvClient.CurrentRow
        Try
            tbID_client.Text = row.Cells(0).Value.ToString()
            tbNomAp_client.Text = row.Cells(1).Value.ToString()
            tbCUI_client.Text = row.Cells(2).Value.ToString()
            tbDirec_client.Text = row.Cells(3).Value.ToString()
            tbcorreo_client.Text = row.Cells(4).Value.ToString
            tbNum_client.Text = row.Cells(5).Value.ToString
            tbNIT_client.Text = row.Cells(6).Value.ToString
            Btnmodi_cliente.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Login.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub tbNomAp_client_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbNomAp_client.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZáéíóúÁÉÍÓÚ- "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tbCUI_client_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbCUI_client.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "1230456789 "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tbcorreo_client_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbcorreo_client.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZáéíóúÁÉÍÓÚ1234567890-().@ "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tbNum_client_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbNum_client.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "1234567890 "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tbNIT_client_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbNIT_client.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "1230456789"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tbDirec_client_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbDirec_client.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZáéíóúÁÉÍÓÚ1234567890-().@ "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
End Class