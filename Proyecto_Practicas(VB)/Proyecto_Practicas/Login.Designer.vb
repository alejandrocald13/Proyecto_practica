<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.tbUser = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbPswd = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bMinimizar = New System.Windows.Forms.Button()
        Me.bCerrar = New System.Windows.Forms.Button()
        Me.bMpswd = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbUser
        '
        Me.tbUser.AutoRoundedCorners = True
        Me.tbUser.BorderColor = System.Drawing.Color.Silver
        Me.tbUser.BorderRadius = 18
        Me.tbUser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbUser.DefaultText = ""
        Me.tbUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbUser.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tbUser.ForeColor = System.Drawing.Color.Black
        Me.tbUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbUser.Location = New System.Drawing.Point(65, 109)
        Me.tbUser.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.tbUser.Name = "tbUser"
        Me.tbUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbUser.PlaceholderForeColor = System.Drawing.Color.LightGray
        Me.tbUser.PlaceholderText = "Usuario"
        Me.tbUser.SelectedText = ""
        Me.tbUser.Size = New System.Drawing.Size(350, 38)
        Me.tbUser.TabIndex = 0
        '
        'tbPswd
        '
        Me.tbPswd.AutoRoundedCorners = True
        Me.tbPswd.BorderColor = System.Drawing.Color.Silver
        Me.tbPswd.BorderRadius = 18
        Me.tbPswd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbPswd.DefaultText = ""
        Me.tbPswd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbPswd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbPswd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbPswd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbPswd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbPswd.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tbPswd.ForeColor = System.Drawing.Color.Black
        Me.tbPswd.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbPswd.Location = New System.Drawing.Point(65, 169)
        Me.tbPswd.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.tbPswd.Name = "tbPswd"
        Me.tbPswd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(183)
        Me.tbPswd.PlaceholderForeColor = System.Drawing.Color.LightGray
        Me.tbPswd.PlaceholderText = "Contraseña"
        Me.tbPswd.SelectedText = ""
        Me.tbPswd.Size = New System.Drawing.Size(350, 39)
        Me.tbPswd.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(111, 49)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(260, 45)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "INICIAR SESIÓN"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.AutoRoundedCorners = True
        Me.Guna2Button1.BorderRadius = 25
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.CornflowerBlue
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI Black", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(136, 230)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(235, 52)
        Me.Guna2Button1.TabIndex = 3
        Me.Guna2Button1.Text = "Iniciar Sesión"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LimeGreen
        Me.Panel1.Controls.Add(Me.bMinimizar)
        Me.Panel1.Controls.Add(Me.bCerrar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(490, 36)
        Me.Panel1.TabIndex = 4
        '
        'bMinimizar
        '
        Me.bMinimizar.BackColor = System.Drawing.Color.LimeGreen
        Me.bMinimizar.FlatAppearance.BorderSize = 0
        Me.bMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.bMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.bMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bMinimizar.Image = CType(resources.GetObject("bMinimizar.Image"), System.Drawing.Image)
        Me.bMinimizar.Location = New System.Drawing.Point(412, 0)
        Me.bMinimizar.Name = "bMinimizar"
        Me.bMinimizar.Size = New System.Drawing.Size(36, 36)
        Me.bMinimizar.TabIndex = 1
        Me.bMinimizar.UseVisualStyleBackColor = False
        '
        'bCerrar
        '
        Me.bCerrar.FlatAppearance.BorderSize = 0
        Me.bCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.bCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.bCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCerrar.Image = CType(resources.GetObject("bCerrar.Image"), System.Drawing.Image)
        Me.bCerrar.Location = New System.Drawing.Point(454, 0)
        Me.bCerrar.Name = "bCerrar"
        Me.bCerrar.Size = New System.Drawing.Size(36, 36)
        Me.bCerrar.TabIndex = 0
        Me.bCerrar.UseVisualStyleBackColor = True
        '
        'bMpswd
        '
        Me.bMpswd.BackColor = System.Drawing.Color.White
        Me.bMpswd.BackgroundImage = CType(resources.GetObject("bMpswd.BackgroundImage"), System.Drawing.Image)
        Me.bMpswd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bMpswd.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.bMpswd.FlatAppearance.BorderSize = 0
        Me.bMpswd.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.bMpswd.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.bMpswd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bMpswd.Location = New System.Drawing.Point(354, 171)
        Me.bMpswd.Name = "bMpswd"
        Me.bMpswd.Size = New System.Drawing.Size(45, 35)
        Me.bMpswd.TabIndex = 5
        Me.bMpswd.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 310)
        Me.ControlBox = False
        Me.Controls.Add(Me.bMpswd)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbPswd)
        Me.Controls.Add(Me.tbUser)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio de Sesión"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbUser As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbPswd As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents bCerrar As Button
    Friend WithEvents bMinimizar As Button
    Friend WithEvents bMpswd As Button
End Class
