<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registro))
        Me.tbNomC_regis = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbCorreo_regis = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cbpuesto_regis = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.tbuser_regis = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbpwsd_regis = New Guna.UI2.WinForms.Guna2TextBox()
        Me.bDelete = New Guna.UI2.WinForms.Guna2Button()
        Me.bregister = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bMpswd = New System.Windows.Forms.Button()
        Me.tbpswconf_regis = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tbNomC_regis
        '
        Me.tbNomC_regis.AutoRoundedCorners = True
        Me.tbNomC_regis.BorderRadius = 14
        Me.tbNomC_regis.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbNomC_regis.DefaultText = ""
        Me.tbNomC_regis.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbNomC_regis.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbNomC_regis.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbNomC_regis.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbNomC_regis.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbNomC_regis.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tbNomC_regis.ForeColor = System.Drawing.Color.Black
        Me.tbNomC_regis.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbNomC_regis.Location = New System.Drawing.Point(85, 55)
        Me.tbNomC_regis.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbNomC_regis.Name = "tbNomC_regis"
        Me.tbNomC_regis.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbNomC_regis.PlaceholderText = "Nombre Completo"
        Me.tbNomC_regis.SelectedText = ""
        Me.tbNomC_regis.Size = New System.Drawing.Size(277, 30)
        Me.tbNomC_regis.TabIndex = 1
        '
        'tbCorreo_regis
        '
        Me.tbCorreo_regis.AutoRoundedCorners = True
        Me.tbCorreo_regis.BorderRadius = 14
        Me.tbCorreo_regis.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbCorreo_regis.DefaultText = ""
        Me.tbCorreo_regis.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbCorreo_regis.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbCorreo_regis.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbCorreo_regis.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbCorreo_regis.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbCorreo_regis.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tbCorreo_regis.ForeColor = System.Drawing.Color.Black
        Me.tbCorreo_regis.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbCorreo_regis.Location = New System.Drawing.Point(85, 103)
        Me.tbCorreo_regis.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbCorreo_regis.Name = "tbCorreo_regis"
        Me.tbCorreo_regis.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbCorreo_regis.PlaceholderText = "Correo Electrónico"
        Me.tbCorreo_regis.SelectedText = ""
        Me.tbCorreo_regis.Size = New System.Drawing.Size(277, 30)
        Me.tbCorreo_regis.TabIndex = 2
        '
        'cbpuesto_regis
        '
        Me.cbpuesto_regis.AutoRoundedCorners = True
        Me.cbpuesto_regis.BackColor = System.Drawing.Color.Transparent
        Me.cbpuesto_regis.BorderRadius = 17
        Me.cbpuesto_regis.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbpuesto_regis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbpuesto_regis.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbpuesto_regis.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbpuesto_regis.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cbpuesto_regis.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbpuesto_regis.ItemHeight = 30
        Me.cbpuesto_regis.Location = New System.Drawing.Point(168, 171)
        Me.cbpuesto_regis.Name = "cbpuesto_regis"
        Me.cbpuesto_regis.Size = New System.Drawing.Size(194, 36)
        Me.cbpuesto_regis.TabIndex = 3
        '
        'tbuser_regis
        '
        Me.tbuser_regis.AutoRoundedCorners = True
        Me.tbuser_regis.BorderRadius = 14
        Me.tbuser_regis.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbuser_regis.DefaultText = ""
        Me.tbuser_regis.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbuser_regis.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbuser_regis.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbuser_regis.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbuser_regis.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbuser_regis.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tbuser_regis.ForeColor = System.Drawing.Color.Black
        Me.tbuser_regis.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbuser_regis.Location = New System.Drawing.Point(85, 225)
        Me.tbuser_regis.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbuser_regis.Name = "tbuser_regis"
        Me.tbuser_regis.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbuser_regis.PlaceholderText = "Usuario (ID)"
        Me.tbuser_regis.SelectedText = ""
        Me.tbuser_regis.Size = New System.Drawing.Size(277, 30)
        Me.tbuser_regis.TabIndex = 4
        '
        'tbpwsd_regis
        '
        Me.tbpwsd_regis.AutoRoundedCorners = True
        Me.tbpwsd_regis.BorderRadius = 14
        Me.tbpwsd_regis.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbpwsd_regis.DefaultText = ""
        Me.tbpwsd_regis.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbpwsd_regis.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbpwsd_regis.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbpwsd_regis.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbpwsd_regis.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbpwsd_regis.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tbpwsd_regis.ForeColor = System.Drawing.Color.Black
        Me.tbpwsd_regis.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbpwsd_regis.Location = New System.Drawing.Point(85, 270)
        Me.tbpwsd_regis.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbpwsd_regis.Name = "tbpwsd_regis"
        Me.tbpwsd_regis.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.tbpwsd_regis.PlaceholderText = "Contraseña"
        Me.tbpwsd_regis.SelectedText = ""
        Me.tbpwsd_regis.Size = New System.Drawing.Size(277, 30)
        Me.tbpwsd_regis.TabIndex = 5
        '
        'bDelete
        '
        Me.bDelete.AutoRoundedCorners = True
        Me.bDelete.BorderRadius = 18
        Me.bDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.bDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.bDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.bDelete.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.bDelete.Font = New System.Drawing.Font("Segoe UI Black", 10.8!, System.Drawing.FontStyle.Bold)
        Me.bDelete.ForeColor = System.Drawing.Color.White
        Me.bDelete.Location = New System.Drawing.Point(12, 403)
        Me.bDelete.Name = "bDelete"
        Me.bDelete.Size = New System.Drawing.Size(180, 38)
        Me.bDelete.TabIndex = 7
        Me.bDelete.Text = "Borrar"
        '
        'bregister
        '
        Me.bregister.AutoRoundedCorners = True
        Me.bregister.BorderRadius = 18
        Me.bregister.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.bregister.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.bregister.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bregister.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.bregister.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.bregister.Font = New System.Drawing.Font("Segoe UI Black", 10.8!, System.Drawing.FontStyle.Bold)
        Me.bregister.ForeColor = System.Drawing.Color.White
        Me.bregister.Location = New System.Drawing.Point(243, 403)
        Me.bregister.Name = "bregister"
        Me.bregister.Size = New System.Drawing.Size(180, 38)
        Me.bregister.TabIndex = 8
        Me.bregister.Text = "Registrar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(91, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 21)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "Puesto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(105, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 21)
        Me.Label2.TabIndex = 84
        '
        'bMpswd
        '
        Me.bMpswd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bMpswd.AutoSize = True
        Me.bMpswd.BackColor = System.Drawing.Color.Transparent
        Me.bMpswd.BackgroundImage = CType(resources.GetObject("bMpswd.BackgroundImage"), System.Drawing.Image)
        Me.bMpswd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bMpswd.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.bMpswd.FlatAppearance.BorderSize = 0
        Me.bMpswd.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar
        Me.bMpswd.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ScrollBar
        Me.bMpswd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bMpswd.Location = New System.Drawing.Point(185, 271)
        Me.bMpswd.Name = "bMpswd"
        Me.bMpswd.Size = New System.Drawing.Size(30, 26)
        Me.bMpswd.TabIndex = 85
        Me.bMpswd.TabStop = False
        Me.bMpswd.UseVisualStyleBackColor = False
        '
        'tbpswconf_regis
        '
        Me.tbpswconf_regis.AutoRoundedCorners = True
        Me.tbpswconf_regis.BorderRadius = 14
        Me.tbpswconf_regis.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbpswconf_regis.DefaultText = ""
        Me.tbpswconf_regis.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbpswconf_regis.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbpswconf_regis.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbpswconf_regis.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbpswconf_regis.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbpswconf_regis.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tbpswconf_regis.ForeColor = System.Drawing.Color.Black
        Me.tbpswconf_regis.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbpswconf_regis.Location = New System.Drawing.Point(85, 317)
        Me.tbpswconf_regis.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbpswconf_regis.Name = "tbpswconf_regis"
        Me.tbpswconf_regis.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.tbpswconf_regis.PlaceholderText = "Confirmar Contraseña"
        Me.tbpswconf_regis.SelectedText = ""
        Me.tbpswconf_regis.Size = New System.Drawing.Size(277, 30)
        Me.tbpswconf_regis.TabIndex = 6
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.AutoSize = True
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ScrollBar
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(185, 318)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(30, 26)
        Me.Button3.TabIndex = 87
        Me.Button3.TabStop = False
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(92, 360)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 21)
        Me.Label3.TabIndex = 88
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(207, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 25)
        Me.Label5.TabIndex = 121
        Me.Label5.Text = "REGISTRARSE"
        '
        'Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(447, 459)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.tbpswconf_regis)
        Me.Controls.Add(Me.bMpswd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bregister)
        Me.Controls.Add(Me.bDelete)
        Me.Controls.Add(Me.tbpwsd_regis)
        Me.Controls.Add(Me.tbuser_regis)
        Me.Controls.Add(Me.cbpuesto_regis)
        Me.Controls.Add(Me.tbNomC_regis)
        Me.Controls.Add(Me.tbCorreo_regis)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Registro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbNomC_regis As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbCorreo_regis As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cbpuesto_regis As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents tbuser_regis As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbpwsd_regis As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents bDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents bregister As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents bMpswd As Button
    Friend WithEvents tbpswconf_regis As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
End Class
