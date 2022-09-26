Imports MySql.Data.MySqlClient
Imports System.Runtime.InteropServices
Public Class Carros
    Dim cmd As MySqlCommand
    Dim conn As New MySqlConnection
    Dim objetoconexion As New conexion
    Dim x As String = ""
    Dim CuRWidth As Integer = Me.Width
    Dim CuRHeight As Integer = Me.Height
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub bCerrar_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Login.Close()
    End Sub
    Private Sub bMinimizar_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Sub limpiar()
        tbID.Clear()
        Numano_Car.Value = 1910
        tbmar_car.Clear()
        tbmodelo_car.Clear()
        tbcol_car.Clear()
        numcili_car.Value = 1.0
        tbmotor_car.Clear()
        tbURL_car.Clear()
        tbVIN_car.Clear()
        If rdSi_llaves.Checked = True Or rdNo_llaves.Checked = True Then
            rdSi_llaves.Checked = False
            rdNo_llaves.Checked = False
        End If
        tbMillaje_carro.Clear()
        Numano_Car.Focus()
    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        limpiar()
        Guna2Button2.Enabled = True
        Guna2Button3.Enabled = False
    End Sub
    Sub mostrar()
        conn = objetoconexion.AbrirCon
        Dim query As String = "SELECT id_carro as 'ID', año_carro as 'Año',marca_carro as 'Marca', modelo_carro as 'Modelo', color_carro as 'Color', vin_carro as 'VIN', cilindros_carro as 'Cilindros', motor_carro as 'Motor', CASE WHEN llaves_carro = 0 THEN 'No' WHEN llaves_carro = 1 THEN 'Si' END AS 'Contiene Llaves', CONCAT(millaje_carro,' mi') as 'Millaje', foto_carro as 'Fotografía del Carro (URL)' FROM info_carro;"
        Dim adpt As New MySqlDataAdapter(query, conn)
        Dim ds As New DataSet()
        adpt.Fill(ds)
        dgvCarros.DataSource = ds.Tables(0)
        conn.Close()
        conn.Dispose()
    End Sub
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        conn = objetoconexion.AbrirCon
        Try
            If tbmar_car.Text = "" Or tbmodelo_car.Text = "" Or tbcol_car.Text = "" Or (rdSi_llaves.Checked = False And rdNo_llaves.Checked = False) Then
                MessageBox.Show("ALGUN CAMPO ESTÁ VACÍO", "ERROR AL GUARDAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                cmd = conn.CreateCommand
                cmd.CommandText = "insert into info_carro(id_carro,año_carro,marca_carro,modelo_carro,color_carro,vin_carro,cilindros_carro,motor_carro,llaves_carro,millaje_carro,foto_carro)values(NULL,@ano,@mar,@mod,@col,@vin,@cilin,@motor,@lla,@mi,@fot);"
                cmd.Parameters.AddWithValue("@ano", CStr(Numano_Car.Value))
                cmd.Parameters.AddWithValue("@mar", tbmar_car.Text)
                cmd.Parameters.AddWithValue("@mod", tbmodelo_car.Text)
                cmd.Parameters.AddWithValue("@col", tbcol_car.Text)
                cmd.Parameters.AddWithValue("@vin", tbVIN_car.Text)
                cmd.Parameters.AddWithValue("@cilin", CStr(numcili_car.Value))
                If rdSi_llaves.Checked = True Then
                    cmd.Parameters.AddWithValue("@lla", CStr(1))
                ElseIf rdNo_llaves.Checked = True Then
                    cmd.Parameters.AddWithValue("@lla", CStr(0))
                End If
                cmd.Parameters.AddWithValue("@motor", tbmotor_car.Text)
                cmd.Parameters.AddWithValue("@mi", tbMillaje_carro.Text)
                cmd.Parameters.AddWithValue("@fot", tbURL_car.Text)
                cmd.ExecuteNonQuery()
                conn.Close()
                conn.Dispose()
                MsgBox("Guardado Correctamente", vbInformation, "Correcto")
                mostrar()
                limpiar()


                Guna2Button2.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Private Sub Carros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Login.token <> 1 Then
            MessageBox.Show("No tienes el Acceso Total a este formulario. Si crees que se trata de un error intenta iniciar sesión de nuevo.", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
            For Each Ctrl As Control In Controls
                If Ctrl.ToString = "Guna.UI2.WinForms.Guna2DataGridView" Then
                Else
                    Ctrl.Enabled = False
                End If
            Next
            If Login.token = 2 Then

            End If
        End If
        mostrar()
        Guna2Button2.Enabled = False
        Guna2Button3.Enabled = False
    End Sub
    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        conn = objetoconexion.AbrirCon
        Try
            If tbmar_car.Text = "" Or tbmodelo_car.Text = "" Or tbcol_car.Text = "" Or (rdSi_llaves.Checked = False And rdNo_llaves.Checked = False) Then
                MessageBox.Show("ALGUN CAMPO ESTÁ VACÍO", "ERROR AL MODIFICAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                cmd = conn.CreateCommand
                cmd.CommandText = "UPDATE info_carro SET año_carro=@ano,marca_carro=@mar,modelo_carro=@mod,color_carro=@col,vin_carro=@vin,cilindros_carro=@cilin,motor_carro=@motor,llaves_carro=@lla,millaje_carro=@mi,foto_carro=@fot WHERE id_carro=@id"
                cmd.Parameters.AddWithValue("@id", tbID.Text)
                cmd.Parameters.AddWithValue("@ano", CStr(Numano_Car.Value))
                cmd.Parameters.AddWithValue("@mar", tbmar_car.Text)
                cmd.Parameters.AddWithValue("@mod", tbmodelo_car.Text)
                cmd.Parameters.AddWithValue("@col", tbcol_car.Text)
                cmd.Parameters.AddWithValue("@vin", tbVIN_car.Text)
                cmd.Parameters.AddWithValue("@cilin", CStr(numcili_car.Value))
                If rdSi_llaves.Checked = True Then
                    cmd.Parameters.AddWithValue("@lla", CStr(1))
                ElseIf rdNo_llaves.Checked = True Then
                    cmd.Parameters.AddWithValue("@lla", CStr(0))
                End If
                cmd.Parameters.AddWithValue("@motor", tbmotor_car.Text)
                cmd.Parameters.AddWithValue("@mi", tbMillaje_carro.Text)
                cmd.Parameters.AddWithValue("@fot", tbURL_car.Text)
                cmd.ExecuteNonQuery()
                conn.Close()
                conn.Dispose()
                MsgBox("Modificado Correctamente", vbInformation, "Correcto")
                mostrar()
                limpiar()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Private Sub dgvCarros_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCarros.CellContentClick
        If Login.token = 1 Then
            Guna2Button2.Enabled = False
            Guna2Button3.Enabled = False
        Else
            Guna2Button2.Enabled = False
            Guna2Button3.Enabled = True
            Dim row As DataGridViewRow = dgvCarros.CurrentRow
            Try
                tbID.Text = row.Cells(0).Value.ToString()
                Numano_Car.Value = row.Cells(1).Value
                tbmar_car.Text = row.Cells(2).Value.ToString()
                tbmodelo_car.Text = row.Cells(3).Value.ToString()
                tbcol_car.Text = row.Cells(4).Value.ToString()
                tbVIN_car.Text = row.Cells(5).Value.ToString()
                numcili_car.Value = row.Cells(6).Value
                tbmotor_car.Text = row.Cells(7).Value
                x = row.Cells(8).Value.ToString()
                If x = "Si" Then
                    rdSi_llaves.Checked = True
                ElseIf x = "No" Then
                    rdNo_llaves.Checked = True
                End If
                Dim s = row.Cells(9).Value.ToString()
                tbMillaje_carro.Text = s.Split("mi")(0)
                tbURL_car.Text = row.Cells(10).Value.ToString()
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If
    End Sub

    Private Sub tbmar_car_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbmar_car.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZáéíóúÁÉÍÓÚ "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub tbmodelo_car_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbmodelo_car.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub tbcol_car_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbcol_car.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZáéíóúÁÉÍÓÚ "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tbVIN_car_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbVIN_car.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZáéíóúÁÉÍÓÚ1234567890/.-()# "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tbmotor_car_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbmotor_car.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZáéíóúÁÉÍÓÚ1234567890/.-()# "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub Guna2TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbMillaje_carro.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "1234567890 "
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
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)
    End Sub
    Private Sub Carros_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
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