Imports MySql.Data.MySqlClient
Imports System.Net
Imports System.IO
Public Class Inventario
    Dim CuRWidth As Integer = Me.Width
    Dim CuRHeight As Integer = Me.Height
    Dim cmd As MySqlCommand
    Dim conn As New MySqlConnection
    Dim objetoconexion As New conexion
    Dim i, i2, i3, i4 As Integer
    Dim costosubasta, dolar, IPRIMA, IVA, CostoP, Impo, Repar As Double
    Dim x As String = ""
    Sub limpiar()
        tbID_inve.Clear()
        cbcarrito_inven.SelectedIndex = -1
        tbTotal_invent.Clear()
        cbestado_invent.SelectedIndex = -1
        tbCarroSelec_CompraCar.Clear()
        rdNo_Soli.Checked = False
        rdSi_soli.Checked = False
        cbcarrito_inven.Focus()
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
            MsgBox(ex.ToString)
            MessageBox.Show("Parece que tenemos un error encontrando el tipo de cambio, te recomendamos editar el PRECIO FINAL.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dolar = 7.75
        End Try
        Label4.Text = "1 USD = " & "Q" & dolar
    End Sub
    Sub cargartotal()
        If cbcarrito_inven.SelectedValue = 0 Then
            Exit Sub
        Else
            Try
                Dim cmd2 As MySqlCommand = New MySqlCommand
                conn = objetoconexion.AbrirCon
                cmd2.Connection = conn
                cmd2.CommandText = "Select * FROM inventario WHERE id_carro='" + cbcarrito_inven.SelectedValue.ToString + "';"
                Dim r As MySqlDataReader
                r = cmd2.ExecuteReader
                If r.HasRows <> True Then
                    r.Read()
                    conn.Close()
                    conn.Dispose()
                    Try
                        Dim query As String = "Select * FROM compra_carros WHERE id_carro='" + cbcarrito_inven.SelectedValue.ToString + "';"
                        Dim adpt As New MySqlDataAdapter(query, conn)
                        Dim row As DataRow = Nothing
                        Using dt As New DataTable()
                            adpt.Fill(dt)
                            If (dt.Rows.Count > 0) Then
                                row = dt.Rows(0)
                            End If
                        End Using
                        costosubasta = Convert.ToString(row("costosubasta_compra"))
                        costosubasta = (costosubasta * dolar)
                    Catch ex As Exception
                        MessageBox.Show("Vaya, parece que el carro seleccionado, no tiene registro de Compra. Por favor, registra la Compra del mismo.", "ERROR AL SELECCIONAR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Asterisk)
                        btndelete_inven.Enabled = False
                        btnmodi_inven.Enabled = False
                        limpiar()
                        Exit Sub
                    End Try
                    Try
                        Dim query2 As String = "Select * FROM facturacion WHERE id_carro='" + cbcarrito_inven.SelectedValue.ToString + "';"
                        Dim adpt2 As New MySqlDataAdapter(query2, conn)
                        Dim row2 As DataRow = Nothing
                        Using dt2 As New DataTable()
                            adpt2.Fill(dt2)
                            If (dt2.Rows.Count > 0) Then
                                row2 = dt2.Rows(0)
                            End If
                        End Using
                        IPRIMA = Convert.ToString(row2("IPRIMA_importe"))
                        IVA = Convert.ToString(row2("IVA_importe"))
                        CostoP = Convert.ToString(row2("placas_factu"))
                    Catch ex As Exception
                        MessageBox.Show("Vaya, parece que el carro seleccionado, no tiene registro de Facturación. Por favor, registra el Proceso de Facturación del mismo.", "ERROR AL SELECCIONAR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Asterisk)
                        btndelete_inven.Enabled = False
                        btnmodi_inven.Enabled = False
                        limpiar()
                        Exit Sub
                    End Try
                    Try
                        Dim query3 As String = "Select * FROM importaciones WHERE id_carro='" + cbcarrito_inven.SelectedValue.ToString + "';"
                        Dim adpt3 As New MySqlDataAdapter(query3, conn)
                        Dim row3 As DataRow = Nothing
                        Using dt3 As New DataTable()
                            adpt3.Fill(dt3)
                            If (dt3.Rows.Count > 0) Then
                                row3 = dt3.Rows(0)
                            End If
                        End Using
                        Impo = Convert.ToString(row3("costo_impo"))
                    Catch ex As Exception
                        MessageBox.Show("Vaya, parece que el carro seleccionado, no tiene registro de Importación. Por favor, registra la Importación del mismo.", "ERROR AL SELECCIONAR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Asterisk)
                        btndelete_inven.Enabled = False
                        btnmodi_inven.Enabled = False
                        limpiar()
                        Exit Sub
                    End Try
                    Try
                        Dim query4 As String = "Select * FROM reparaciones WHERE id_carro='" + cbcarrito_inven.SelectedValue.ToString + "';"
                        Dim adpt4 As New MySqlDataAdapter(query4, conn)
                        Dim row4 As DataRow = Nothing
                        Using dt4 As New DataTable()
                            adpt4.Fill(dt4)
                            If (dt4.Rows.Count > 0) Then
                                row4 = dt4.Rows(0)
                            End If
                        End Using
                        Repar = Convert.ToString(row4("costo_reparacion"))
                    Catch ex As Exception
                        MessageBox.Show("Vaya, parece que el carro seleccionado, no tiene registro de Reparación. Por favor, registra la Compra del mismo.", "ERROR AL SELECCIONAR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Asterisk)
                        btndelete_inven.Enabled = False
                        btnmodi_inven.Enabled = False
                        limpiar()
                        Exit Sub
                    End Try
                    Dim costofinal As Double
                    costofinal = costosubasta + IPRIMA + IVA + Impo + Repar + CostoP
                    tbTotal_invent.Text = CStr(costofinal)
                Else
                    MessageBox.Show("Vaya, parece que el carro seleccionado, ya se encuentra registrado. Si crees que se trata de un error, intenta modificarlo.", "ERROR AL SELECCIONAR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Asterisk)
                    btndelete_inven.Enabled = False
                    btnmodi_inven.Enabled = False
                    limpiar()
                End If
                conn.Close()
                conn.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles btndelete_inven.Click
        If MessageBox.Show("¿Estás seguro de borrar el carro presionado del Inventario?" & vbCrLf & "Esta acción no se puede deshacer.", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = vbOK Then
            conn = objetoconexion.AbrirCon
            Try
                cmd = conn.CreateCommand
                cmd.CommandText = "delete from inventario where id_invent=@id"
                cmd.Parameters.AddWithValue("@id", tbID_inve.Text)
                cmd.ExecuteNonQuery()
                conn.Close()
                conn.Dispose()
                MsgBox("Eliminado Correctamente", vbInformation, "Correcto")
                mostrar()
                limpiar()
            Catch ex As Exception
            End Try
        Else
            limpiar()
            btnguardar_inven.Enabled = False
            btndelete_inven.Enabled = False
            Exit Sub
        End If
    End Sub
    Private Sub btnmodi_inven_Click(sender As Object, e As EventArgs) Handles btnmodi_inven.Click
        conn = objetoconexion.AbrirCon
        Try
            If tbTotal_invent.Text = Nothing Or Not IsNumeric(tbTotal_invent.Text) Or tbTotal_invent.Text = "0" Then
                If Not IsNumeric(tbTotal_invent.Text) Then
                    MessageBox.Show("VAYA, PARECE QUE EL NÚMERO NO ES VÁLIDO, VERIFICAR.", "ERROR AL GUARDAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    tbTotal_invent.Clear()
                    Exit Sub
                End If
                If tbTotal_invent.Text = "0" Then
                    MessageBox.Show("VAYA, PARECE QUE EL NÚMERO INGRESADO ES 0, VERIFICAR.", "ERROR AL GUARDAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Exit Sub
                End If
                MessageBox.Show("ALGUN CAMPO ESTÁ VACÍO", "ERROR AL MODIFICAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                If MessageBox.Show("¿Deseas modificar el valor del Precio Total?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                    i2 = 1
                    tbTotal_invent.ReadOnly = False
                Else
                    If i2 = 1 Then
                        i2 = 0
                        tbTotal_invent.ReadOnly = True
                    End If
                    cmd = conn.CreateCommand
                    cmd.CommandText = "UPDATE inventario SET id_carro=@car,total_invent=@tot,estado_invent=@est,solici_invent=@soli WHERE id_invent=@id"
                    cmd.Parameters.AddWithValue("@id", tbID_inve.Text)
                    cmd.Parameters.AddWithValue("@car", cbcarrito_inven.SelectedValue.ToString)
                    cmd.Parameters.AddWithValue("@tot", tbTotal_invent.Text)
                    cmd.Parameters.AddWithValue("@est", cbestado_invent.SelectedItem)
                    If rdSi_soli.Checked = True Then
                        cmd.Parameters.AddWithValue("@soli", CStr(1))
                    ElseIf rdNo_Soli.Checked = True Then
                        cmd.Parameters.AddWithValue("@soli", CStr(0))
                    End If
                    cmd.ExecuteNonQuery()
                    conn.Close()
                    conn.Dispose()
                    MsgBox("Modificado Correctamente", vbInformation, "Correcto")
                    mostrar()
                    limpiar()
                    cbcarrito_inven.SelectedIndex = -1
                    btnguardar_inven.Enabled = True
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Private Sub tbTotal_invent_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbTotal_invent.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "1234567890"
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
    Private Sub Inventario_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Dim RatioHeight As Double = (Me.Height - CuRHeight) / CuRHeight
        Dim RatioWidth As Double = (Me.Width - CuRWidth) / CuRWidth
        For Each Ctrl1 As Control In Controls
            Ctrl1.Width += Ctrl1.Width * RatioWidth
            Ctrl1.Left += Ctrl1.Left * RatioWidth
            Ctrl1.Top += Ctrl1.Top * RatioHeight
            If Ctrl1.ToString = "Guna.UI2.WinForms.Guna2DataGridView" Then
                Ctrl1.Height += Ctrl1.Height * RatioHeight
            End If
        Next
        CuRHeight = Me.Height
        CuRWidth = Me.Width
    End Sub
    Private Sub dgvInvent_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInvent.CellContentClick
        If Login.token <> 1 And Login.token <> 2 Then
            btnguardar_inven.Enabled = False
            btnmodi_inven.Enabled = False
        Else
            i3 = 1
            btnguardar_inven.Enabled = False
            Dim row As DataGridViewRow = dgvInvent.CurrentRow
            Try
                tbID_inve.Text = row.Cells(0).Value.ToString()
                cbcarrito_inven.Text = row.Cells(1).Value.ToString()
                Dim s = row.Cells(7).Value.ToString
                tbTotal_invent.Text = s.Split("Q")(1)
                cbestado_invent.SelectedItem = row.Cells(8).Value.ToString()
                x = row.Cells(9).Value.ToString()
                If x = "Si" Then
                    rdSi_soli.Checked = True
                ElseIf x = "No" Then
                    rdNo_Soli.Checked = True
                End If
                btndelete_inven.Enabled = True
                btnmodi_inven.Enabled = True
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If
    End Sub
    Private Sub btnguardar_inven_Click(sender As Object, e As EventArgs) Handles btnguardar_inven.Click
        conn = objetoconexion.AbrirCon
        Try
            If cbcarrito_inven.SelectedValue = 0 Or cbcarrito_inven.SelectedIndex = -1 Or (rdSi_soli.Checked = False And rdNo_Soli.Checked = False) Then
                MessageBox.Show("ALGUN CAMPO ESTÁ VACÍO", "ERROR AL GUARDAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                If MessageBox.Show("¿Estás seguro del Costo Total?" & vbCrLf & "Si no es como esperabas puedes editarlos, pulsando 'NO'.", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbNo Then
                    i2 = 1
                    tbTotal_invent.ReadOnly = False
                Else
                    If i2 = 1 Then
                        i2 = 0
                        tbTotal_invent.ReadOnly = True
                    End If
                    cmd = conn.CreateCommand
                    cmd.CommandText = "insert into inventario(id_carro,total_invent,estado_invent,solici_invent)values(@car,@tot,@est,@soli);"
                    cmd.Parameters.AddWithValue("@car", cbcarrito_inven.SelectedValue.ToString)
                    cmd.Parameters.AddWithValue("@tot", tbTotal_invent.Text)
                    cmd.Parameters.AddWithValue("@est", cbestado_invent.SelectedItem)
                    If rdSi_soli.Checked = True Then
                        cmd.Parameters.AddWithValue("@soli", CStr(1))
                    ElseIf rdNo_Soli.Checked = True Then
                        cmd.Parameters.AddWithValue("@soli", CStr(0))
                    End If
                    cmd.ExecuteNonQuery()
                    conn.Close()
                    conn.Dispose()
                    MsgBox("Guardado Correctamente", vbInformation, "Correcto")

                    mostrar()
                    limpiar()
                    cbcarrito_inven.SelectedIndex = -1
                    btnguardar_inven.Enabled = True
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Sub carroselec()
        If cbcarrito_inven.SelectedValue = 0 Then
            Exit Sub
        Else
            conn = objetoconexion.AbrirCon
            Dim query As String = "Select CONCAT(año_carro,' ', marca_carro,' ', modelo_carro) as info1_car FROM info_carro WHERE id_carro='" + cbcarrito_inven.SelectedValue.ToString + "';"
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
    Sub cargarcarros()
        conn = objetoconexion.AbrirCon
        Dim query As String = "Select * FROM info_carro;"
        Dim adpt As New MySqlDataAdapter(query, conn)
        Dim ds As New DataSet()
        adpt.Fill(ds)
        cbcarrito_inven.DataSource = ds.Tables(0)
        cbcarrito_inven.DisplayMember = "vin_carro"
        cbcarrito_inven.ValueMember = "id_carro"
        conn.Close()
        conn.Dispose()
    End Sub
    Sub mostrar()
        conn = objetoconexion.AbrirCon
        Dim query As String = "SELECT inv.id_invent as 'ID', ifc.vin_carro, ifc.año_carro as 'Año', ifc.marca_carro as 'Marca', ifc.modelo_carro as 'Modelo', ifc.color_carro as 'Color', CONCAT(ifc.millaje_carro,' mi') as 'Millaje', CONCAT('Q',inv.total_invent) as 'Total del Vehículo', inv.estado_invent as 'Estado', CASE WHEN inv.solici_invent = 0 THEN 'No' WHEN inv.solici_invent = 1 THEN 'Si' END AS 'Solicitado con Anticipación', ifc.foto_carro as 'URL de Fotografía'FROM inventario inv INNER JOIN info_carro ifc ON inv.id_carro = ifc.id_carro;"
        Dim adpt As New MySqlDataAdapter(query, conn)
        Dim ds As New DataSet()
        adpt.Fill(ds)
        dgvInvent.DataSource = ds.Tables(0)
        conn.Close()
        conn.Dispose()
    End Sub
    Private Sub Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            dgvInvent.Columns(1).Visible = False
            If Login.token = 3 Or Login.token = 4 Then
                MessageBox.Show("No tienes el Acceso Total a este formulario." & vbCrLf & "Si crees que se trata de un error intenta iniciar sesión de nuevo.", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
                For Each Ctrl As Control In Controls
                    If Ctrl.ToString <> "Guna.UI2.WinForms.Guna2DataGridView" Then
                        Ctrl.Enabled = False
                    End If
                Next
            End If
            cargarcambio()
            cargarcarros()
            cbcarrito_inven.SelectedIndex = -1
            btnguardar_inven.Enabled = False
            btnmodi_inven.Enabled = False
            btndelete_inven.Enabled = False
        End If
    End Sub
    Private Sub cbcarrito_inven_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbcarrito_inven.SelectedIndexChanged
        If i3 = 1 Then
            i3 = 0
            carroselec()
            Exit Sub
        End If
        i += 1
        If i >= 4 Then
            carroselec()
            cargartotal()
        End If
    End Sub
    Private Sub btnnuevo_inven_Click(sender As Object, e As EventArgs) Handles btnnuevo_inven.Click
        limpiar()
        btnguardar_inven.Enabled = True
        btndelete_inven.Enabled = False
        btnmodi_inven.Enabled = False
    End Sub
End Class