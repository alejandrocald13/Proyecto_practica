<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Carros
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.CBid_car = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Numano_Careeeeeeeeeeeeeeeeee = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.tbmar_car = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbmodelo_car = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbllaves_car = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbcol_car = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbmotor_car = New Guna.UI2.WinForms.Guna2TextBox()
        Me.numcili_car = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.tburl_car = New Guna.UI2.WinForms.Guna2TextBox()
        CType(Me.Numano_Careeeeeeeeeeeeeeeeee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numcili_car, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CBid_car
        '
        Me.CBid_car.BackColor = System.Drawing.Color.Transparent
        Me.CBid_car.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBid_car.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBid_car.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBid_car.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBid_car.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBid_car.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CBid_car.ItemHeight = 30
        Me.CBid_car.Location = New System.Drawing.Point(29, 14)
        Me.CBid_car.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CBid_car.Name = "CBid_car"
        Me.CBid_car.Size = New System.Drawing.Size(231, 36)
        Me.CBid_car.TabIndex = 0
        '
        'Numano_Careeeeeeeeeeeeeeeeee
        '
        Me.Numano_Careeeeeeeeeeeeeeeeee.BackColor = System.Drawing.Color.Transparent
        Me.Numano_Careeeeeeeeeeeeeeeeee.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Numano_Careeeeeeeeeeeeeeeeee.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Numano_Careeeeeeeeeeeeeeeeee.ForeColor = System.Drawing.Color.Black
        Me.Numano_Careeeeeeeeeeeeeeeeee.Location = New System.Drawing.Point(29, 56)
        Me.Numano_Careeeeeeeeeeeeeeeeee.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Numano_Careeeeeeeeeeeeeeeeee.Maximum = New Decimal(New Integer() {2023, 0, 0, 0})
        Me.Numano_Careeeeeeeeeeeeeeeeee.Name = "Numano_Careeeeeeeeeeeeeeeeee"
        Me.Numano_Careeeeeeeeeeeeeeeeee.Size = New System.Drawing.Size(172, 31)
        Me.Numano_Careeeeeeeeeeeeeeeeee.TabIndex = 1
        '
        'tbmar_car
        '
        Me.tbmar_car.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbmar_car.DefaultText = ""
        Me.tbmar_car.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbmar_car.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbmar_car.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbmar_car.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbmar_car.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbmar_car.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold)
        Me.tbmar_car.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbmar_car.Location = New System.Drawing.Point(29, 93)
        Me.tbmar_car.Name = "tbmar_car"
        Me.tbmar_car.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbmar_car.PlaceholderText = "Marca "
        Me.tbmar_car.SelectedText = ""
        Me.tbmar_car.Size = New System.Drawing.Size(211, 30)
        Me.tbmar_car.TabIndex = 2
        '
        'tbmodelo_car
        '
        Me.tbmodelo_car.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbmodelo_car.DefaultText = ""
        Me.tbmodelo_car.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbmodelo_car.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbmodelo_car.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbmodelo_car.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbmodelo_car.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbmodelo_car.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold)
        Me.tbmodelo_car.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbmodelo_car.Location = New System.Drawing.Point(29, 129)
        Me.tbmodelo_car.Name = "tbmodelo_car"
        Me.tbmodelo_car.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbmodelo_car.PlaceholderText = "Modelo"
        Me.tbmodelo_car.SelectedText = ""
        Me.tbmodelo_car.Size = New System.Drawing.Size(211, 30)
        Me.tbmodelo_car.TabIndex = 3
        '
        'tbllaves_car
        '
        Me.tbllaves_car.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbllaves_car.DefaultText = ""
        Me.tbllaves_car.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbllaves_car.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbllaves_car.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbllaves_car.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbllaves_car.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbllaves_car.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold)
        Me.tbllaves_car.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbllaves_car.Location = New System.Drawing.Point(29, 201)
        Me.tbllaves_car.Name = "tbllaves_car"
        Me.tbllaves_car.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbllaves_car.PlaceholderText = "Llaves"
        Me.tbllaves_car.SelectedText = ""
        Me.tbllaves_car.Size = New System.Drawing.Size(211, 30)
        Me.tbllaves_car.TabIndex = 5
        '
        'tbcol_car
        '
        Me.tbcol_car.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbcol_car.DefaultText = ""
        Me.tbcol_car.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbcol_car.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbcol_car.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbcol_car.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbcol_car.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbcol_car.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold)
        Me.tbcol_car.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbcol_car.Location = New System.Drawing.Point(29, 165)
        Me.tbcol_car.Name = "tbcol_car"
        Me.tbcol_car.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbcol_car.PlaceholderText = "Color"
        Me.tbcol_car.SelectedText = ""
        Me.tbcol_car.Size = New System.Drawing.Size(211, 30)
        Me.tbcol_car.TabIndex = 4
        '
        'tbmotor_car
        '
        Me.tbmotor_car.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbmotor_car.DefaultText = ""
        Me.tbmotor_car.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbmotor_car.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbmotor_car.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbmotor_car.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbmotor_car.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbmotor_car.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold)
        Me.tbmotor_car.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbmotor_car.Location = New System.Drawing.Point(29, 274)
        Me.tbmotor_car.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.tbmotor_car.Name = "tbmotor_car"
        Me.tbmotor_car.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbmotor_car.PlaceholderText = "Motor"
        Me.tbmotor_car.SelectedText = ""
        Me.tbmotor_car.Size = New System.Drawing.Size(211, 33)
        Me.tbmotor_car.TabIndex = 7
        '
        'numcili_car
        '
        Me.numcili_car.BackColor = System.Drawing.Color.Transparent
        Me.numcili_car.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.numcili_car.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numcili_car.ForeColor = System.Drawing.Color.Black
        Me.numcili_car.Location = New System.Drawing.Point(29, 237)
        Me.numcili_car.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.numcili_car.Maximum = New Decimal(New Integer() {1500, 0, 0, 0})
        Me.numcili_car.Name = "numcili_car"
        Me.numcili_car.Size = New System.Drawing.Size(172, 31)
        Me.numcili_car.TabIndex = 8
        '
        'tburl_car
        '
        Me.tburl_car.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tburl_car.DefaultText = ""
        Me.tburl_car.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tburl_car.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tburl_car.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tburl_car.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tburl_car.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tburl_car.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold)
        Me.tburl_car.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tburl_car.Location = New System.Drawing.Point(29, 313)
        Me.tburl_car.Name = "tburl_car"
        Me.tburl_car.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tburl_car.PlaceholderText = "Url del carro "
        Me.tburl_car.SelectedText = ""
        Me.tburl_car.Size = New System.Drawing.Size(211, 30)
        Me.tburl_car.TabIndex = 10
        '
        'Carros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1063, 449)
        Me.Controls.Add(Me.tburl_car)
        Me.Controls.Add(Me.numcili_car)
        Me.Controls.Add(Me.tbmotor_car)
        Me.Controls.Add(Me.tbllaves_car)
        Me.Controls.Add(Me.tbcol_car)
        Me.Controls.Add(Me.tbmodelo_car)
        Me.Controls.Add(Me.tbmar_car)
        Me.Controls.Add(Me.Numano_Careeeeeeeeeeeeeeeeee)
        Me.Controls.Add(Me.CBid_car)
        Me.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Carros"
        Me.Text = "Carros "
        CType(Me.Numano_Careeeeeeeeeeeeeeeeee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numcili_car, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CBid_car As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Numano_Careeeeeeeeeeeeeeeeee As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents tbmar_car As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbmodelo_car As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbllaves_car As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbcol_car As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbmotor_car As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents numcili_car As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents tburl_car As Guna.UI2.WinForms.Guna2TextBox
End Class
