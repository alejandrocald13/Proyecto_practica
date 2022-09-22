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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.bMinimizar = New System.Windows.Forms.Button()
        Me.bCerrar = New System.Windows.Forms.Button()
        Me.tbNomC_regis = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbCorreo_regis = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cbpuesto_regis = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.tbuser_regis = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbpwsd_regis = New Guna.UI2.WinForms.Guna2TextBox()
        Me.bDelete = New Guna.UI2.WinForms.Guna2Button()
        Me.bregister = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.YellowGreen
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.bMinimizar)
        Me.Panel1.Controls.Add(Me.bCerrar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(447, 35)
        Me.Panel1.TabIndex = 60
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(330, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(52, 35)
        Me.Button1.TabIndex = 24
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(388, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(52, 35)
        Me.Button2.TabIndex = 23
        Me.Button2.UseVisualStyleBackColor = True
        '
        'bMinimizar
        '
        Me.bMinimizar.FlatAppearance.BorderSize = 0
        Me.bMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.bMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.bMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bMinimizar.Image = CType(resources.GetObject("bMinimizar.Image"), System.Drawing.Image)
        Me.bMinimizar.Location = New System.Drawing.Point(953, 0)
        Me.bMinimizar.Name = "bMinimizar"
        Me.bMinimizar.Size = New System.Drawing.Size(52, 35)
        Me.bMinimizar.TabIndex = 22
        Me.bMinimizar.UseVisualStyleBackColor = True
        '
        'bCerrar
        '
        Me.bCerrar.FlatAppearance.BorderSize = 0
        Me.bCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.bCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.bCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCerrar.Image = CType(resources.GetObject("bCerrar.Image"), System.Drawing.Image)
        Me.bCerrar.Location = New System.Drawing.Point(1011, 0)
        Me.bCerrar.Name = "bCerrar"
        Me.bCerrar.Size = New System.Drawing.Size(52, 35)
        Me.bCerrar.TabIndex = 21
        Me.bCerrar.UseVisualStyleBackColor = True
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
        Me.tbNomC_regis.TabIndex = 74
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
        Me.tbCorreo_regis.TabIndex = 73
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
        Me.cbpuesto_regis.TabIndex = 77
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
        Me.tbuser_regis.TabIndex = 78
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
        Me.tbpwsd_regis.Location = New System.Drawing.Point(85, 274)
        Me.tbpwsd_regis.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbpwsd_regis.Name = "tbpwsd_regis"
        Me.tbpwsd_regis.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbpwsd_regis.PlaceholderText = "Contraseña"
        Me.tbpwsd_regis.SelectedText = ""
        Me.tbpwsd_regis.Size = New System.Drawing.Size(277, 30)
        Me.tbpwsd_regis.TabIndex = 79
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
        Me.bDelete.Location = New System.Drawing.Point(13, 333)
        Me.bDelete.Name = "bDelete"
        Me.bDelete.Size = New System.Drawing.Size(180, 38)
        Me.bDelete.TabIndex = 80
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
        Me.bregister.Location = New System.Drawing.Point(244, 333)
        Me.bregister.Name = "bregister"
        Me.bregister.Size = New System.Drawing.Size(180, 38)
        Me.bregister.TabIndex = 81
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
        Me.Label2.Location = New System.Drawing.Point(108, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 21)
        Me.Label2.TabIndex = 84
        '
        'Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(447, 393)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bregister)
        Me.Controls.Add(Me.bDelete)
        Me.Controls.Add(Me.tbpwsd_regis)
        Me.Controls.Add(Me.tbuser_regis)
        Me.Controls.Add(Me.cbpuesto_regis)
        Me.Controls.Add(Me.tbNomC_regis)
        Me.Controls.Add(Me.tbCorreo_regis)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Registro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents bMinimizar As Button
    Friend WithEvents bCerrar As Button
    Friend WithEvents tbNomC_regis As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbCorreo_regis As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cbpuesto_regis As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents tbuser_regis As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbpwsd_regis As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents bDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents bregister As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
