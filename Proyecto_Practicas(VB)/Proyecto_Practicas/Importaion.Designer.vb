<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Importaion
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
        Me.cbCarro_Compraimpor = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.tbCarroSelec_CompraCar = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbmetodo_impor = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nudCosto_impor = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbSub_Compraimpor = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Btnmodi_impor = New Guna.UI2.WinForms.Guna2Button()
        Me.btnguarda_impor = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.tbID_CompraCar = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        CType(Me.nudCosto_impor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbCarro_Compraimpor
        '
        Me.cbCarro_Compraimpor.BackColor = System.Drawing.Color.Transparent
        Me.cbCarro_Compraimpor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbCarro_Compraimpor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCarro_Compraimpor.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbCarro_Compraimpor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbCarro_Compraimpor.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCarro_Compraimpor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbCarro_Compraimpor.ItemHeight = 30
        Me.cbCarro_Compraimpor.Location = New System.Drawing.Point(99, 1)
        Me.cbCarro_Compraimpor.Margin = New System.Windows.Forms.Padding(4)
        Me.cbCarro_Compraimpor.Name = "cbCarro_Compraimpor"
        Me.cbCarro_Compraimpor.Size = New System.Drawing.Size(257, 36)
        Me.cbCarro_Compraimpor.TabIndex = 58
        '
        'tbCarroSelec_CompraCar
        '
        Me.tbCarroSelec_CompraCar.BackColor = System.Drawing.Color.Transparent
        Me.tbCarroSelec_CompraCar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tbCarroSelec_CompraCar.Cursor = System.Windows.Forms.Cursors.No
        Me.tbCarroSelec_CompraCar.DefaultText = ""
        Me.tbCarroSelec_CompraCar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbCarroSelec_CompraCar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbCarroSelec_CompraCar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbCarroSelec_CompraCar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbCarroSelec_CompraCar.FillColor = System.Drawing.Color.DodgerBlue
        Me.tbCarroSelec_CompraCar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbCarroSelec_CompraCar.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.tbCarroSelec_CompraCar.ForeColor = System.Drawing.Color.White
        Me.tbCarroSelec_CompraCar.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbCarroSelec_CompraCar.Location = New System.Drawing.Point(460, -1)
        Me.tbCarroSelec_CompraCar.Margin = New System.Windows.Forms.Padding(5)
        Me.tbCarroSelec_CompraCar.Name = "tbCarroSelec_CompraCar"
        Me.tbCarroSelec_CompraCar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbCarroSelec_CompraCar.PlaceholderForeColor = System.Drawing.Color.White
        Me.tbCarroSelec_CompraCar.PlaceholderText = "Carro Seleccionado"
        Me.tbCarroSelec_CompraCar.ReadOnly = True
        Me.tbCarroSelec_CompraCar.SelectedText = ""
        Me.tbCarroSelec_CompraCar.Size = New System.Drawing.Size(369, 44)
        Me.tbCarroSelec_CompraCar.TabIndex = 57
        '
        'tbmetodo_impor
        '
        Me.tbmetodo_impor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbmetodo_impor.DefaultText = ""
        Me.tbmetodo_impor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbmetodo_impor.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbmetodo_impor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbmetodo_impor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbmetodo_impor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbmetodo_impor.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tbmetodo_impor.ForeColor = System.Drawing.Color.Black
        Me.tbmetodo_impor.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbmetodo_impor.Location = New System.Drawing.Point(460, 102)
        Me.tbmetodo_impor.Margin = New System.Windows.Forms.Padding(5)
        Me.tbmetodo_impor.Name = "tbmetodo_impor"
        Me.tbmetodo_impor.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbmetodo_impor.PlaceholderText = "Metodo de compra "
        Me.tbmetodo_impor.SelectedText = ""
        Me.tbmetodo_impor.Size = New System.Drawing.Size(369, 37)
        Me.tbmetodo_impor.TabIndex = 54
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(456, 60)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 28)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Costo ($)"
        '
        'nudCosto_impor
        '
        Me.nudCosto_impor.BackColor = System.Drawing.Color.Transparent
        Me.nudCosto_impor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.nudCosto_impor.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.nudCosto_impor.ForeColor = System.Drawing.Color.Black
        Me.nudCosto_impor.Increment = New Decimal(New Integer() {50, 0, 0, 0})
        Me.nudCosto_impor.Location = New System.Drawing.Point(576, 56)
        Me.nudCosto_impor.Margin = New System.Windows.Forms.Padding(5)
        Me.nudCosto_impor.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudCosto_impor.Minimum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.nudCosto_impor.Name = "nudCosto_impor"
        Me.nudCosto_impor.Size = New System.Drawing.Size(253, 37)
        Me.nudCosto_impor.TabIndex = 52
        Me.nudCosto_impor.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.nudCosto_impor.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(24, 61)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 28)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Subasta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(24, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 28)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Carro"
        '
        'cbSub_Compraimpor
        '
        Me.cbSub_Compraimpor.BackColor = System.Drawing.Color.Transparent
        Me.cbSub_Compraimpor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbSub_Compraimpor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSub_Compraimpor.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbSub_Compraimpor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbSub_Compraimpor.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSub_Compraimpor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbSub_Compraimpor.ItemHeight = 30
        Me.cbSub_Compraimpor.Location = New System.Drawing.Point(128, 53)
        Me.cbSub_Compraimpor.Margin = New System.Windows.Forms.Padding(4)
        Me.cbSub_Compraimpor.Name = "cbSub_Compraimpor"
        Me.cbSub_Compraimpor.Size = New System.Drawing.Size(228, 36)
        Me.cbSub_Compraimpor.TabIndex = 46
        '
        'Btnmodi_impor
        '
        Me.Btnmodi_impor.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Btnmodi_impor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Btnmodi_impor.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btnmodi_impor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Btnmodi_impor.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btnmodi_impor.Font = New System.Drawing.Font("Segoe UI Black", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Btnmodi_impor.ForeColor = System.Drawing.Color.White
        Me.Btnmodi_impor.Location = New System.Drawing.Point(918, 126)
        Me.Btnmodi_impor.Margin = New System.Windows.Forms.Padding(4)
        Me.Btnmodi_impor.Name = "Btnmodi_impor"
        Me.Btnmodi_impor.Size = New System.Drawing.Size(240, 47)
        Me.Btnmodi_impor.TabIndex = 45
        Me.Btnmodi_impor.Text = "Modificar"
        '
        'btnguarda_impor
        '
        Me.btnguarda_impor.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnguarda_impor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnguarda_impor.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnguarda_impor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnguarda_impor.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.btnguarda_impor.Font = New System.Drawing.Font("Segoe UI Black", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnguarda_impor.ForeColor = System.Drawing.Color.White
        Me.btnguarda_impor.Location = New System.Drawing.Point(918, 72)
        Me.btnguarda_impor.Margin = New System.Windows.Forms.Padding(4)
        Me.btnguarda_impor.Name = "btnguarda_impor"
        Me.btnguarda_impor.Size = New System.Drawing.Size(240, 47)
        Me.btnguarda_impor.TabIndex = 44
        Me.btnguarda_impor.Text = "Guardar"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI Black", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(918, 18)
        Me.Guna2Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(240, 47)
        Me.Guna2Button1.TabIndex = 43
        Me.Guna2Button1.Text = "Nuevo"
        '
        'tbID_CompraCar
        '
        Me.tbID_CompraCar.Cursor = System.Windows.Forms.Cursors.No
        Me.tbID_CompraCar.DefaultText = ""
        Me.tbID_CompraCar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbID_CompraCar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbID_CompraCar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbID_CompraCar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbID_CompraCar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbID_CompraCar.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tbID_CompraCar.ForeColor = System.Drawing.Color.Black
        Me.tbID_CompraCar.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbID_CompraCar.Location = New System.Drawing.Point(86, -46)
        Me.tbID_CompraCar.Margin = New System.Windows.Forms.Padding(5)
        Me.tbID_CompraCar.Name = "tbID_CompraCar"
        Me.tbID_CompraCar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbID_CompraCar.PlaceholderText = "ID"
        Me.tbID_CompraCar.ReadOnly = True
        Me.tbID_CompraCar.SelectedText = ""
        Me.tbID_CompraCar.Size = New System.Drawing.Size(65, 37)
        Me.tbID_CompraCar.TabIndex = 42
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(43, 169)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 28)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Importacion"
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.DefaultText = ""
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2TextBox1.ForeColor = System.Drawing.Color.Black
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Location = New System.Drawing.Point(48, 202)
        Me.Guna2TextBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderText = "Importación"
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.Size = New System.Drawing.Size(1110, 353)
        Me.Guna2TextBox1.TabIndex = 61
        '
        'Importaion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1254, 696)
        Me.Controls.Add(Me.Guna2TextBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbCarro_Compraimpor)
        Me.Controls.Add(Me.tbCarroSelec_CompraCar)
        Me.Controls.Add(Me.tbmetodo_impor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nudCosto_impor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbSub_Compraimpor)
        Me.Controls.Add(Me.Btnmodi_impor)
        Me.Controls.Add(Me.btnguarda_impor)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.tbID_CompraCar)
        Me.Name = "Importaion"
        Me.Text = "Importaion"
        CType(Me.nudCosto_impor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbCarro_Compraimpor As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents tbCarroSelec_CompraCar As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbmetodo_impor As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents nudCosto_impor As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbSub_Compraimpor As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Btnmodi_impor As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnguarda_impor As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents tbID_CompraCar As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
End Class
