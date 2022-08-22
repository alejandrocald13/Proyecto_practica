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
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

    End Sub
    'Pasar click en DataGrid
    'Dim row As DataGridViewRow = DataGridView1.CurrentRow
    'Try
    '        TextBox10.Text = row.Cells(0).Value.ToString()
    '        TextBox7.Text = row.Cells(1).Value.ToString()
    '        TextBox8.Text = row.Cells(2).Value.ToString()
    '        TextBox9.Text = row.Cells(3).Value.ToString()
    '        ComboBox1.SelectedItem = row.Cells(4).Value.ToString()
    '        TextBox12.Text = row.Cells(5).Value.ToString()
    '        TextBox11.Text = row.Cells(6).Value.ToString()
    '        NumericUpDown1.Value = row.Cells(7).Value
    '        ComboBox2.SelectedItem = row.Cells(8).Value.ToString()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.ToString())
    '    End Try
    'Sub cargarcombox()
    '    conn.Open()
    '    Dim query As String = "SELECT * FROM proveedores;"
    '    Dim adpt As New MySqlDataAdapter(query, conn)
    '    Dim ds As New DataSet()
    '    adpt.Fill(ds)
    '    ComboBox2.DataSource = ds.Tables(0)
    '    ComboBox2.DisplayMember = "nombre_proveedor"
    '    ComboBox2.ValueMember = "id_proveedor"
    '    conn.Close()
    'End Sub
    'conn = objetoconexion.AbrirCon
    'ACTUALIZAR
    'Try
    'If ComboBox1.SelectedIndex = -1 Or ComboBox2.SelectedIndex = -1 Then
    '            MessageBox.Show("PUEDE QUE LA SELECCIÓN PARA PROVEEDORES Y/O FABRICANTES ESTÉ VACÍA", "ERROR AL MODIFICAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
    '        Else
    '            cont += 1
    '            cmd = conn.CreateCommand
    '            cmd.CommandText = "update consolas_videojuegos set codigo_cons=@cod,nombre_cons=@nom,mod_cons=@mod,id_fab=@Fab,foto_cons=@Foto,desc_cons=@Desc,precio_cons=@prec,id_proveedor=@prov WHERE id_cons=@id;"
    '            cmd.Parameters.AddWithValue("@id", TextBox10.Text)
    '            cmd.Parameters.AddWithValue("@cod", TextBox7.Text)
    '            cmd.Parameters.AddWithValue("@nom", TextBox8.Text)
    '            cmd.Parameters.AddWithValue("@mod", TextBox9.Text)
    '            cmd.Parameters.AddWithValue("@Fab", ComboBox1.SelectedValue)
    '            cmd.Parameters.AddWithValue("@Foto", TextBox12.Text)
    '            cmd.Parameters.AddWithValue("@Desc", TextBox11.Text)
    '            cmd.Parameters.AddWithValue("@prec", NumericUpDown1.Value)
    '            cmd.Parameters.AddWithValue("@prov", ComboBox2.SelectedValue)
    '            cmd.ExecuteNonQuery()
    '            conn.Close()
    '            conn.Dispose()
    '            mostrar3()
    '            limpiar3()
    '        End If
    'Catch ex As Exception
    '        MessageBox.Show(ex.ToString())
    '    End Try
    'ELIMINAR
    'conn = objetoconexion.AbrirCon

    '    Try
    '        cmd = conn.CreateCommand
    '        cmd.CommandText = "delete from consolas_videojuegos where id_cons=@id"
    '        cmd.Parameters.AddWithValue("@id", TextBox10.Text)
    '        cmd.ExecuteNonQuery()
    '        conn.Close()
    '        conn.Dispose()
    '        mostrar3()
    '        limpiar3()
    '    Catch ex As Exception
    'End Try
    'Private Sub mostrar()
    '    conn = objetoconexion.AbrirCon
    '    Dim query As String = "SELECT c.id_cons as 'ID', c.codigo_cons as 'Codigo', c.nombre_cons as 'Nombre', c.mod_cons as 'Modelo', f.nombre_fab as 'Fabricante', c.foto_cons as 'Fotografía (URL)', c.desc_cons as 'Descripcion', c.precio_cons as 'Precio', p.nombre_proveedor as 'Nombre Proveedor' FROM consolas_videojuegos c INNER JOIN proveedores p ON c.id_proveedor = p.id_proveedor INNER JOIN fabricante f ON c.id_fab = f.id_fab;"
    '    Dim adpt As New MySqlDataAdapter(query, conn)
    '    Dim ds As New DataSet()
    '    adpt.Fill(ds)
    '    DataGridView1.DataSource = ds.Tables(0)
    '    conn.Close()
    '    conn.Dispose()
    'End Sub

    'INSERTAR:
    'conn = objetoconexion.AbrirCon
    '    Try
    'If TextBox7.Text = "" Or TextBox8.Text = "" Or TextBox9.Text = "" Then
    '            MessageBox.Show("ALGUN CAMPO ESTÁ VACÍO", "ERROR AL GUARDAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
    '        Else
    '            cmd = conn.CreateCommand
    '            cmd.CommandText = "insert into consolas_videojuegos(id_cons,codigo_cons,nombre_cons,mod_cons,id_fab,foto_cons,desc_cons,precio_cons,id_proveedor)values(NULL,@cod,@nom,@mod,@Fab,@Foto,@Desc,@prec,@prov);"
    '            cmd.Parameters.AddWithValue("@cod", TextBox7.Text)
    '            cmd.Parameters.AddWithValue("@nom", TextBox8.Text)
    '            cmd.Parameters.AddWithValue("@mod", TextBox9.Text)
    '            cmd.Parameters.AddWithValue("@Fab", ComboBox1.SelectedValue)
    '            cmd.Parameters.AddWithValue("@Foto", TextBox12.Text)
    '            cmd.Parameters.AddWithValue("@Desc", TextBox11.Text)
    '            cmd.Parameters.AddWithValue("@prec", NumericUpDown1.Value)
    '            cmd.Parameters.AddWithValue("@prov", ComboBox2.SelectedValue)
    '            cmd.ExecuteNonQuery()
    '            conn.Close()
    '            conn.Dispose()
    '            mostrar()
    '            limpiar()
    '        End If
    'Catch ex As Exception
    '        MessageBox.Show(ex.ToString())
    '    End Try
End Class
