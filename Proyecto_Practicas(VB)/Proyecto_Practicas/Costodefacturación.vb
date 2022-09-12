Public Class Costodefacturación
    Private Sub Costodefacturación_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub dgvClient_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCostodefac.CellContentClick

    End Sub

    Private Sub Guna2TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbirs_cdfac.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "1023456789. "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tbNIT_client_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbplaca_cdfac.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1230456789- "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tbplegal_cdfac_TextChanged(sender As Object, e As EventArgs) Handles tbplegal_cdfac.TextChanged

    End Sub
End Class