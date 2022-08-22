Public Class Carros
    Private Sub Carros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpano_car.Format = DateTimePickerFormat.Custom
        dtpano_car.CustomFormat = "yyyy"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show(dtpano_car.ToString)

    End Sub
End Class