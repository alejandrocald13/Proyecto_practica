Imports System.Net
Imports System.IO
Imports MySql.Data.MySqlClient
'Imports System.Runtime.InteropServices
Public Class Costodefacturación
    Dim cmd As MySqlCommand
    Dim conn As New MySqlConnection
    Dim objetoconexion As New conexion
    Dim dolar As Double = 0.00
    Dim i As Integer = 0
    Dim i2 As Integer
    Dim CuRWidth As Integer = Me.Width
    Dim CuRHeight As Integer = Me.Height
    '<DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    'Private Shared Sub ReleaseCapture()
    'End Sub
    '<DllImport("user32.DLL", EntryPoint:="SendMessage")>
    'Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    'End Sub
    Sub cargarIPRIMAeIVA()
        If cbCarro_Cdfac.SelectedValue = 0 Then
            Exit Sub
        Else
            Try
                Dim cmd2 As MySqlCommand = New MySqlCommand
                conn = objetoconexion.AbrirCon
                cmd2.Connection = conn
                cmd2.CommandText = "Select * FROM compra_carros WHERE id_carro='" + cbCarro_Cdfac.SelectedValue.ToString + "';"
                Dim r As MySqlDataReader
                r = cmd2.ExecuteReader
                If r.HasRows <> False Then
                    r.Read()
                    conn.Close()
                    conn.Dispose()
                    Dim query As String = "Select * FROM compra_carros WHERE id_carro='" + cbCarro_Cdfac.SelectedValue.ToString + "';"
                    Dim adpt As New MySqlDataAdapter(query, conn)
                    Dim row As DataRow = Nothing
                    Using dt As New DataTable()
                        adpt.Fill(dt)
                        If (dt.Rows.Count > 0) Then
                            row = dt.Rows(0)
                        End If
                    End Using
                    Dim costosubasta = Convert.ToString(row("costosubasta_compra"))
                    tbIPRIMA_impo.Text = (costosubasta * dolar) * 0.2
                    tbIVA_impo.Text = (costosubasta * dolar) * 0.12
                Else
                    MessageBox.Show("Vaya, parece que el carro seleccionado, no tiene registro de Importación. Por favor, registra la Importación del mismo.", "ERROR AL SELECCIONAR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Asterisk)
                    limpiar()
                End If
                conn.Close()
                conn.Dispose()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub
    Sub limpiar()
        cbCarro_Cdfac.SelectedIndex = -1
        tbID_cdfac.Clear()
        tbEncargselec_Impo.Clear()
        tbCarroSelec_CompraCar.Clear()
        tbLoteSelec_Impo.Clear()
        tbIVA_impo.Clear()
        tbIPRIMA_impo.Clear()
        tbCostoPlacas_Impo.Clear()
        cbCarro_Cdfac.Focus()
    End Sub
    Sub encargselec()
        If cbCarro_Cdfac.SelectedValue = 0 Then
            Exit Sub
        Else
            Try
                Dim cmd2 As MySqlCommand = New MySqlCommand
                conn = objetoconexion.AbrirCon
                cmd2.Connection = conn
                cmd2.CommandText = "Select * FROM importaciones WHERE id_carro='" + cbCarro_Cdfac.SelectedValue.ToString + "';"
                Dim r As MySqlDataReader
                r = cmd2.ExecuteReader
                If r.HasRows <> False Then
                    r.Read()
                    conn.Close()
                    conn.Dispose()
                    Dim query As String = "Select * FROM importaciones WHERE id_carro='" + cbCarro_Cdfac.SelectedValue.ToString + "';"
                    Dim adpt As New MySqlDataAdapter(cmd2.CommandText, conn)
                    Dim row As DataRow = Nothing
                    Using dt As New DataTable()
                        adpt.Fill(dt)
                        If (dt.Rows.Count > 0) Then
                            row = dt.Rows(0)
                        End If
                    End Using
                    tbEncargselec_Impo.Text = Convert.ToString(row("encarg_impo"))
                    Label2.Text = Convert.ToString(row("id_impo"))
                    Label2.Visible = False
                Else
                    MessageBox.Show("Vaya, parece que el carro seleccionado, no tiene registro de Importación. Por favor, registra la Importación del mismo.", "ERROR AL SELECCIONAR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Asterisk)
                    limpiar()
                End If
                conn.Close()
                conn.Dispose()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        End If
    End Sub
    Sub loteselec()
        If cbCarro_Cdfac.SelectedValue = 0 Then
            Exit Sub
        Else
            Try
                Dim cmd2 As MySqlCommand = New MySqlCommand
                conn = objetoconexion.AbrirCon
                cmd2.Connection = conn
                cmd2.CommandText = "Select * FROM compra_carros WHERE id_carro='" + cbCarro_Cdfac.SelectedValue.ToString + "';"
                Dim r As MySqlDataReader
                r = cmd2.ExecuteReader
                If r.HasRows <> False Then
                    r.Read()
                    conn.Close()
                    conn.Dispose()
                    Dim query As String = "Select * FROM compra_carros WHERE id_carro='" + cbCarro_Cdfac.SelectedValue.ToString + "';"
                    Dim adpt As New MySqlDataAdapter(cmd2.CommandText, conn)
                    Dim row As DataRow = Nothing
                    Using dt As New DataTable()
                        adpt.Fill(dt)
                        If (dt.Rows.Count > 0) Then
                            row = dt.Rows(0)
                        End If
                    End Using
                    tbLoteSelec_Impo.Text = Convert.ToString(row("lote_compra"))
                    Label1.Text = Convert.ToString(row("id_compras"))
                    Label1.Visible = False
                Else
                    MessageBox.Show("Vaya, parece que el carro seleccionado, no tiene lote de Compra. Por favor, registra la compra del mismo.", "ERROR AL SELECCIONAR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Asterisk)
                    limpiar()
                End If
                conn.Close()
                conn.Dispose()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        End If
    End Sub
    Sub carroselec()
        If cbCarro_Cdfac.SelectedValue = 0 Then
            Exit Sub
        Else
            conn = objetoconexion.AbrirCon
            Dim query As String = "Select CONCAT(año_carro,' ', marca_carro,' ', modelo_carro) as info1_car FROM info_carro WHERE id_carro='" + cbCarro_Cdfac.SelectedValue.ToString + "';"
            Dim adpt As New MySqlDataAdapter(query, conn)
            Try
                Dim row As DataRow = Nothing
                Using dt As New DataTable()
                    adpt.Fill(dt)
                    If (dt.Rows.Count > 0) Then
                        row = dt.Rows(0)
                    End If
                End Using
                tbCarroSelec_CompraCar.Text = Convert.ToString(row("info1_car"))
                conn.Close()
                conn.Dispose()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub
    Sub cargarcarro()
        conn = objetoconexion.AbrirCon
        Dim query As String = "Select * FROM info_carro;"
        Dim adpt As New MySqlDataAdapter(query, conn)
        Dim ds As New DataSet()
        adpt.Fill(ds)
        cbCarro_Cdfac.DataSource = ds.Tables(0)
        cbCarro_Cdfac.DisplayMember = "vin_carro"
        cbCarro_Cdfac.ValueMember = "id_carro"
        conn.Close()
        conn.Dispose()
    End Sub
    Sub cargarcambio()
        Try
            Dim client As New WebClient
            Dim pagina As Stream = client.OpenRead("https://www.google.com/finance/quote/USD-GTQ?sa=X&ved=2ahUKEwj50aS746H6AhWZfDABHaiYCIsQmY0JegQIBxAb")
            Dim lector As New StreamReader(pagina)
            Dim MIHTML As String = lector.ReadToEnd
            Dim Cambio_moneda As String = MIHTML.Remove(0, MIHTML.IndexOf("class=" & """" & "YMlKec fxKbKc" & """") + 22)
            dolar = Cambio_moneda.Substring(0, Cambio_moneda.IndexOf("<"))
            dolar = Math.Round(dolar, 2)
        Catch ex As Exception
            MessageBox.Show("Parece que tenemos un error encontrando el tipo de cambio, te recomendamos editar el IPRIMA e IVA.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dolar = 7.75
        End Try
        Label4.Text = "1 USD = " & "Q" & dolar
    End Sub
    Sub mostrar()
        conn = objetoconexion.AbrirCon
        Dim query As String = "SELECT f.id_factu as 'ID', ifc.vin_carro as 'VIN', cc.lote_compra as 'Lote de Compra', impo.encarg_impo as 'Encargado de Importación', CONCAT('Q',f.IPRIMA_importe) as 'IPRIMA', CONCAT('Q',f.IVA_importe) as 'IVA', CONCAT('Q',f.placas_factu) as 'Costo de Placas (Q)' FROM facturacion f INNER JOIN info_carro ifc ON f.id_carro = ifc.id_carro INNER JOIN compra_carros cc ON cc.id_compras = f.id_compras INNER JOIN importaciones impo ON f.id_impo = impo.id_impo;"
        Dim adpt As New MySqlDataAdapter(query, conn)
        Dim ds As New DataSet()
        adpt.Fill(ds)
        dgvCostodefac.DataSource = ds.Tables(0)
        conn.Close()
        conn.Dispose()
    End Sub
    Private Sub Guna2TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbCostoPlacas_Impo.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "1023456789. "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub Costodefacturación_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Login.token <> 1 Then
            MessageBox.Show("No tienes el Acceso Total a este formulario." & vbCrLf & "Si crees que se trata de un error intenta iniciar sesión de nuevo.", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
            For Each Ctrl As Control In Controls
                If Ctrl.ToString <> "Guna.UI2.WinForms.Guna2DataGridView" Then
                    Ctrl.Enabled = False
                End If
            Next
            If Login.token = 2 Then
                mostrar()
            End If
        Else
            mostrar()
            cargarcarro()
            cargarcambio()
            cbCarro_Cdfac.SelectedIndex = -1
            btnguarda_client.Enabled = False
            Btnmodi_cliente.Enabled = False
        End If
    End Sub
    Private Sub cbCarro_Cdfac_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCarro_Cdfac.SelectedIndexChanged
        i += 1
        If i >= 4 Then
            carroselec()
            loteselec()
            encargselec()
            cargarIPRIMAeIVA()
        End If
    End Sub
    Private Sub btnnew_client_Click(sender As Object, e As EventArgs) Handles btnnew_client.Click
        limpiar()
        btnguarda_client.Enabled = True
    End Sub
    Private Sub btnguarda_client_Click(sender As Object, e As EventArgs) Handles btnguarda_client.Click
        Try
            Dim cmd2 As MySqlCommand = New MySqlCommand
            conn = objetoconexion.AbrirCon
            cmd2.Connection = conn
            cmd2.CommandText = "Select * FROM facturacion WHERE id_carro='" + cbCarro_Cdfac.SelectedValue.ToString + "';"
            Dim r As MySqlDataReader
            r = cmd2.ExecuteReader
            If r.HasRows <> True Then
                r.Read()
                conn.Close()
                conn.Dispose()
                If cbCarro_Cdfac.SelectedIndex = -1 Or tbCostoPlacas_Impo.Text = Nothing Or Not IsNumeric(tbCostoPlacas_Impo.Text) Or tbCostoPlacas_Impo.Text = "0" Then
                    If Not IsNumeric(tbCostoPlacas_Impo.Text) Then
                        MessageBox.Show("VAYA, PARECE QUE EL NÚMERO NO ES VÁLIDO, VERIFICAR.", "ERROR AL GUARDAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        tbCostoPlacas_Impo.Clear()
                        Exit Sub
                    End If
                    If tbCostoPlacas_Impo.Text = "0" Then
                        MessageBox.Show("VAYA, PARECE QUE EL NÚMERO INGRESADO ES 0, VERIFICAR.", "ERROR AL GUARDAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    MessageBox.Show("ALGUN CAMPO ESTÁ VACÍO", "ERROR AL GUARDAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    If MessageBox.Show("¿Estás seguro de los valores del IPRIMA e IVA?" & vbCrLf & "Si no son de tu agrado puedes editarlos, pulsando 'NO'.", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbNo Then
                        i2 = 1
                        tbIPRIMA_impo.ReadOnly = False
                        tbIVA_impo.ReadOnly = False
                    Else
                        If i2 = 1 Then
                            i2 = 0
                            tbIPRIMA_impo.ReadOnly = True
                            tbIVA_impo.ReadOnly = True
                        End If
                        conn = objetoconexion.AbrirCon
                        cmd = conn.CreateCommand
                        cmd.CommandText = "insert into facturacion(id_carro,id_compras,id_impo,IPRIMA_importe,IVA_importe,placas_factu)values(@car,@com,@impo,@IPRIMA,@IVA,@plac);"
                        cmd.Parameters.AddWithValue("@car", cbCarro_Cdfac.SelectedValue.ToString)
                        cmd.Parameters.AddWithValue("@com", Label1.Text)
                        cmd.Parameters.AddWithValue("@impo", Label2.Text)
                        cmd.Parameters.AddWithValue("@IPRIMA", tbIPRIMA_impo.Text)
                        cmd.Parameters.AddWithValue("@IVA", tbIVA_impo.Text)
                        cmd.Parameters.AddWithValue("@plac", tbCostoPlacas_Impo.Text)
                        cmd.ExecuteNonQuery()
                        conn.Close()
                        conn.Dispose()


                        mostrar()
                        limpiar()
                        cbCarro_Cdfac.SelectedIndex = -1
                        btnguarda_client.Enabled = False
                    End If
                End If
            Else
                MessageBox.Show("Vaya, parece que el carro seleccionado ya está registrado. Si cometiste un error, intenta modificarlo.", "ERROR AL GUARDAR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Asterisk)
                limpiar()
                limpiar()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Private Sub Btnmodi_cliente_Click(sender As Object, e As EventArgs) Handles Btnmodi_cliente.Click
        conn = objetoconexion.AbrirCon
        Try
            If cbCarro_Cdfac.SelectedIndex = 1 Or tbCostoPlacas_Impo.Text = Nothing Or Not IsNumeric(tbCostoPlacas_Impo.Text) Or tbCostoPlacas_Impo.Text = "0" Then
                If Not IsNumeric(tbCostoPlacas_Impo.Text) Then
                    MessageBox.Show("VAYA, PARECE QUE EL NÚMERO NO ES VÁLIDO, VERIFICAR.", "ERROR AL GUARDAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    tbCostoPlacas_Impo.Clear()
                    Exit Sub
                End If
                If tbCostoPlacas_Impo.Text = "0" Then
                    MessageBox.Show("VAYA, PARECE QUE EL NÚMERO INGRESADO ES 0, VERIFICAR.", "ERROR AL GUARDAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Exit Sub
                End If
                MessageBox.Show("ALGUN CAMPO ESTÁ VACÍO", "ERROR AL MODIFICAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                If MessageBox.Show("¿Deseas modificar los valores del IPRIMA e IVA?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                    i2 = 1
                    tbIPRIMA_impo.ReadOnly = False
                    tbIVA_impo.ReadOnly = False
                Else
                    If i2 = 1 Then
                        i2 = 0
                        tbIPRIMA_impo.ReadOnly = True
                        tbIVA_impo.ReadOnly = True
                    End If
                    cmd = conn.CreateCommand
                    cmd.CommandText = "UPDATE facturacion SET id_carro=@car,id_compras=@com,id_impo=@impo,IPRIMA_importe=@IPRIMA,IVA_importe=@IVA,placas_factu=@plac WHERE id_factu=@id"
                    cmd.Parameters.AddWithValue("@id", tbID_cdfac.Text)
                    cmd.Parameters.AddWithValue("@car", cbCarro_Cdfac.SelectedValue.ToString)
                    cmd.Parameters.AddWithValue("@com", Label1.Text)
                    cmd.Parameters.AddWithValue("@impo", Label2.Text)
                    cmd.Parameters.AddWithValue("@IPRIMA", tbIPRIMA_impo.Text)
                    cmd.Parameters.AddWithValue("@IVA", tbIVA_impo.Text)
                    cmd.Parameters.AddWithValue("@plac", tbCostoPlacas_Impo.Text)
                    cmd.ExecuteNonQuery()
                    conn.Close()
                    conn.Dispose()
                    MsgBox("Modificado correctamente", vbInformation, "Correcto")
                    mostrar()
                    limpiar()
                    cbCarro_Cdfac.SelectedIndex = -1
                    Btnmodi_cliente.Enabled = False
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Private Sub dgvCostodefac_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCostodefac.CellContentClick
        If Login.token <> 1 Then
            btnguarda_client.Enabled = False
            Btnmodi_cliente.Enabled = False
        Else
            btnguarda_client.Enabled = False
            Dim row As DataGridViewRow = dgvCostodefac.CurrentRow
            Try
                tbID_cdfac.Text = row.Cells(0).Value.ToString()
                cbCarro_Cdfac.Text = row.Cells(1).Value.ToString()
                Dim IPRI = row.Cells(4).Value.ToString
                tbIPRIMA_impo.Text = IPRI.Split("Q")(1)
                Dim IVA = row.Cells(5).Value.ToString
                tbIVA_impo.Text = IVA.Split("Q")(1)
                Dim costp = row.Cells(6).Value.ToString
                tbCostoPlacas_Impo.Text = costp.Split("Q")(1)
                Btnmodi_cliente.Enabled = True
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Login.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub tbIPRIMA_impo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbIPRIMA_impo.KeyPress, tbIVA_impo.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "1234567890. "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub Costodefacturación_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
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