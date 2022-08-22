<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Carros
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
        Me.CBid_car = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.tbmod_car = New Guna.UI2.WinForms.Guna2TextBox()
        Me.dtpano_car = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
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
        Me.CBid_car.Location = New System.Drawing.Point(12, 12)
        Me.CBid_car.Name = "CBid_car"
        Me.CBid_car.Size = New System.Drawing.Size(174, 36)
        Me.CBid_car.TabIndex = 0
        '
        'tbmod_car
        '
        Me.tbmod_car.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbmod_car.DefaultText = ""
        Me.tbmod_car.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbmod_car.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbmod_car.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbmod_car.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbmod_car.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbmod_car.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold)
        Me.tbmod_car.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbmod_car.Location = New System.Drawing.Point(12, 108)
        Me.tbmod_car.Name = "tbmod_car"
        Me.tbmod_car.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbmod_car.PlaceholderText = ""
        Me.tbmod_car.SelectedText = ""
        Me.tbmod_car.Size = New System.Drawing.Size(199, 38)
        Me.tbmod_car.TabIndex = 1
        '
        'dtpano_car
        '
        Me.dtpano_car.Checked = True
        Me.dtpano_car.FillColor = System.Drawing.Color.White
        Me.dtpano_car.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpano_car.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpano_car.Location = New System.Drawing.Point(12, 55)
        Me.dtpano_car.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpano_car.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpano_car.Name = "dtpano_car"
        Me.dtpano_car.Size = New System.Drawing.Size(199, 47)
        Me.dtpano_car.TabIndex = 2
        Me.dtpano_car.Value = New Date(2022, 8, 22, 9, 50, 21, 39)
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(91, 199)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Carros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 389)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dtpano_car)
        Me.Controls.Add(Me.tbmod_car)
        Me.Controls.Add(Me.CBid_car)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Carros"
        Me.Text = "Carros "
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CBid_car As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents tbmod_car As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dtpano_car As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Button1 As Button
End Class
