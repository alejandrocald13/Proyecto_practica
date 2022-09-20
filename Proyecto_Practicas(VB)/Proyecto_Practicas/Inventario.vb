Imports MySql.Data.MySqlClient
Public Class Inventario
    Dim cmd As MySqlCommand
    Dim conn As New MySqlConnection
    Dim objetoconexion As New conexion
    Dim i As Integer = 0
    'If Not (Asc(e.KeyChar) = 8) Then
    '    Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZáéíóúÁÉÍÓÚ1234567890-().@#"",;: "
    '    If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
    '        e.KeyChar = ChrW(0)
    '        e.Handled = True
    '    End If
    'End If
    Sub cargartotal()
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
        Dim query As String = "SELECT inv.id_invent as 'ID', ifc.año_carro as 'Año', ifc.marca_carro as 'Marca', ifc.modelo_carro as 'Modelo', ifc.color_carro as 'Color',CONCAT('Q',inv.total_invent) as 'Total del Vehículo', inv.estado_invent as 'Estado', CASE WHEN inv.solici_invent = 0 THEN 'No' WHEN inv.solici_invent = 1 THEN 'Si' END AS 'Solicitado con Anticipación', ifc.foto_carro as 'URL de Fotografía'FROM inventario inv INNER JOIN info_carro ifc ON inv.id_carro = ifc.id_carro;"
        Dim adpt As New MySqlDataAdapter(query, conn)
        Dim ds As New DataSet()
        adpt.Fill(ds)
        dgvInvent.DataSource = ds.Tables(0)
        conn.Close()
        conn.Dispose()
    End Sub
    Private Sub Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
        cargarcarros()
        cbcarrito_inven.SelectedIndex = -1
    End Sub
    Private Sub cbcarrito_inven_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbcarrito_inven.SelectedIndexChanged
        i += 1
        If i >= 4 Then
            carroselec()
            cargartotal()
        End If
    End Sub
End Class