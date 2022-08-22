Imports MySql.Data.MySqlClient
Public Class Carros
    Dim cmd As MySqlCommand
    Dim conn As New MySqlConnection
    Dim objetoconexion As New conexion
    Private Sub bCerrar_Click(sender As Object, e As EventArgs) Handles bCerrar.Click
        Me.Hide()
        Login.Close()
    End Sub
    Private Sub bMinimizar_Click(sender As Object, e As EventArgs) Handles bMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Sub limpiar()
        tbID.Clear()
        Numano_Car.Value = 1500
        tbmar_car.Clear()
        tbmodelo_car.Clear()
        tbcol_car.Clear()
        numcili_car.Value = 1500
        tbmotor_car.Clear()
        tburl_car.Clear()
        Numano_Car.Focus()
    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        limpiar()
    End Sub
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        conn = objetoconexion.AbrirCon
        Try
            If tbmar_car.Text = "" Or tbmodelo_car.Text = "" Or tbcol_car.Text = "" Then
                MessageBox.Show("ALGUN CAMPO ESTÁ VACÍO", "ERROR AL GUARDAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                cmd = conn.CreateCommand
                cmd.CommandText = "insert into info_carro(id_carro,año_carro,marca_carro,modelo_carro,color_carro,vin_carro,cilindros_carro,llaves_carro,motor_carro,foto_carro)values(NULL,@cod,@nom,@mod,@Fab,@Foto,@Desc,@prec,@prov);"
                cmd.Parameters.AddWithValue("@ano", CStr(Numano_Car.Value))
                cmd.Parameters.AddWithValue("@mar", tbmar_car.Text)
                cmd.Parameters.AddWithValue("@mod", tbmodelo_car.Text)
                cmd.Parameters.AddWithValue("@col", tbcol_car.Text)
                cmd.Parameters.AddWithValue("@vin", )
                cmd.Parameters.AddWithValue("@cilin", TextBox11.Text)
                cmd.Parameters.AddWithValue("@lla", NumericUpDown1.Value)
                cmd.Parameters.AddWithValue("@motor", ComboBox2.SelectedValue)
                cmd.Parameters.AddWithValue("@fot", ComboBox2.SelectedValue)
                cmd.ExecuteNonQuery()
                conn.Close()
                conn.Dispose()
                mostrar()
                limpiar()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
End Class