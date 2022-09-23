Imports System.Runtime.InteropServices
Public Class Lista_forms
    Dim SizeNormal, LocationNormal As Object
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Private Sub AbrirFormEnPanel(ByVal Formhijo As Object)
        If Me.PanelContenedor.Controls.Count > 0 Then
            Me.PanelContenedor.Controls.RemoveAt(0)
        End If
        Dim fh As Form = TryCast(Formhijo, Form)
        fh.TopLevel = False
        fh.FormBorderStyle = FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        PanelContenedor.Controls.Add(fh)
        Me.PanelContenedor.Tag = fh
        fh.Show()
    End Sub
    Private Sub btFactu_list_Click(sender As Object, e As EventArgs) Handles btFactu_list.Click
        AbrirFormEnPanel(New Costodefacturación)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MessageBox.Show("¿Deseas cerrar el programa?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            Me.Hide()
            Login.Close()
        ElseIf MessageBox.Show("¿Deseas volver a logearte?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            Me.Hide()
            Login.Show()
            Login.token = 0
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Button14.Visible = False
        Button15.Visible = True
        Size = My.Computer.Screen.WorkingArea.Size
        Location = New Point(0, 0)
    End Sub
    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Button15.Visible = False
        Button14.Visible = True
        Size = SizeNormal
        Location = LocationNormal
    End Sub
    Private Sub Lista_forms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SizeNormal = Size
        LocationNormal = Location
    End Sub
End Class