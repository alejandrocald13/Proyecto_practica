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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Carros))
        Me.Numano_Car = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.tbmar_car = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbmodelo_car = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbcol_car = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbmotor_car = New Guna.UI2.WinForms.Guna2TextBox()
        Me.numcili_car = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.tbID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.dgvCarros = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.rdNo_llaves = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rdSi_llaves = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bMinimizar = New System.Windows.Forms.Button()
        Me.bCerrar = New System.Windows.Forms.Button()
        Me.tbVIN_car = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbURL_car = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.Numano_Car, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numcili_car, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCarros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Numano_Car
        '
        Me.Numano_Car.BackColor = System.Drawing.Color.Transparent
        Me.Numano_Car.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Numano_Car.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Numano_Car.ForeColor = System.Drawing.Color.Black
        Me.Numano_Car.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.Numano_Car.Location = New System.Drawing.Point(63, 100)
        Me.Numano_Car.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Numano_Car.Maximum = New Decimal(New Integer() {2023, 0, 0, 0})
        Me.Numano_Car.Minimum = New Decimal(New Integer() {1910, 0, 0, 0})
        Me.Numano_Car.Name = "Numano_Car"
        Me.Numano_Car.Size = New System.Drawing.Size(161, 31)
        Me.Numano_Car.TabIndex = 1
        Me.Numano_Car.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Numano_Car.Value = New Decimal(New Integer() {1910, 0, 0, 0})
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
        Me.tbmar_car.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbmar_car.ForeColor = System.Drawing.Color.Black
        Me.tbmar_car.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbmar_car.Location = New System.Drawing.Point(13, 137)
        Me.tbmar_car.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.tbmodelo_car.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tbmodelo_car.ForeColor = System.Drawing.Color.Black
        Me.tbmodelo_car.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbmodelo_car.Location = New System.Drawing.Point(13, 173)
        Me.tbmodelo_car.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbmodelo_car.Name = "tbmodelo_car"
        Me.tbmodelo_car.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbmodelo_car.PlaceholderText = "Modelo"
        Me.tbmodelo_car.SelectedText = ""
        Me.tbmodelo_car.Size = New System.Drawing.Size(211, 30)
        Me.tbmodelo_car.TabIndex = 3
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
        Me.tbcol_car.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbcol_car.ForeColor = System.Drawing.Color.Black
        Me.tbcol_car.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbcol_car.Location = New System.Drawing.Point(263, 64)
        Me.tbcol_car.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.tbmotor_car.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbmotor_car.ForeColor = System.Drawing.Color.Black
        Me.tbmotor_car.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbmotor_car.Location = New System.Drawing.Point(263, 137)
        Me.tbmotor_car.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.tbmotor_car.Name = "tbmotor_car"
        Me.tbmotor_car.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbmotor_car.PlaceholderText = "Motor"
        Me.tbmotor_car.SelectedText = ""
        Me.tbmotor_car.Size = New System.Drawing.Size(211, 30)
        Me.tbmotor_car.TabIndex = 7
        '
        'numcili_car
        '
        Me.numcili_car.BackColor = System.Drawing.Color.Transparent
        Me.numcili_car.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.numcili_car.DecimalPlaces = 1
        Me.numcili_car.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numcili_car.ForeColor = System.Drawing.Color.Black
        Me.numcili_car.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.numcili_car.Location = New System.Drawing.Point(346, 101)
        Me.numcili_car.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.numcili_car.Maximum = New Decimal(New Integer() {1500, 0, 0, 0})
        Me.numcili_car.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numcili_car.Name = "numcili_car"
        Me.numcili_car.Size = New System.Drawing.Size(128, 30)
        Me.numcili_car.TabIndex = 8
        Me.numcili_car.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.numcili_car.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'tbID
        '
        Me.tbID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbID.DefaultText = ""
        Me.tbID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbID.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tbID.ForeColor = System.Drawing.Color.Black
        Me.tbID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbID.Location = New System.Drawing.Point(13, 64)
        Me.tbID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbID.Name = "tbID"
        Me.tbID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbID.PlaceholderText = "ID"
        Me.tbID.ReadOnly = True
        Me.tbID.SelectedText = ""
        Me.tbID.Size = New System.Drawing.Size(211, 30)
        Me.tbID.TabIndex = 13
        '
        'Guna2Button1
        '
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI Black", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(871, 64)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(180, 38)
        Me.Guna2Button1.TabIndex = 14
        Me.Guna2Button1.Text = "Nuevo"
        '
        'Guna2Button2
        '
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI Black", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.Location = New System.Drawing.Point(871, 108)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(180, 38)
        Me.Guna2Button2.TabIndex = 15
        Me.Guna2Button2.Text = "Guardar"
        '
        'Guna2Button3
        '
        Me.Guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button3.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Button3.Font = New System.Drawing.Font("Segoe UI Black", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button3.ForeColor = System.Drawing.Color.White
        Me.Guna2Button3.Location = New System.Drawing.Point(871, 155)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.Size = New System.Drawing.Size(180, 38)
        Me.Guna2Button3.TabIndex = 16
        Me.Guna2Button3.Text = "Modificar"
        '
        'dgvCarros
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.dgvCarros.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvCarros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvCarros.BackgroundColor = System.Drawing.Color.White
        Me.dgvCarros.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCarros.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvCarros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCarros.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvCarros.ColumnHeadersHeight = 20
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCarros.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvCarros.EnableHeadersVisualStyles = False
        Me.dgvCarros.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCarros.Location = New System.Drawing.Point(12, 235)
        Me.dgvCarros.Name = "dgvCarros"
        Me.dgvCarros.ReadOnly = True
        Me.dgvCarros.RowHeadersVisible = False
        Me.dgvCarros.RowTemplate.Height = 24
        Me.dgvCarros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCarros.Size = New System.Drawing.Size(1039, 308)
        Me.dgvCarros.TabIndex = 17
        Me.dgvCarros.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvCarros.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvCarros.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvCarros.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvCarros.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvCarros.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvCarros.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCarros.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCarros.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvCarros.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvCarros.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvCarros.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvCarros.ThemeStyle.HeaderStyle.Height = 20
        Me.dgvCarros.ThemeStyle.ReadOnly = True
        Me.dgvCarros.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvCarros.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvCarros.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvCarros.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvCarros.ThemeStyle.RowsStyle.Height = 24
        Me.dgvCarros.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCarros.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Guna2GroupBox1.Controls.Add(Me.rdNo_llaves)
        Me.Guna2GroupBox1.Controls.Add(Me.rdSi_llaves)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Silver
        Me.Guna2GroupBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.DimGray
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(498, 101)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(211, 102)
        Me.Guna2GroupBox1.TabIndex = 19
        Me.Guna2GroupBox1.Text = "Llaves"
        '
        'rdNo_llaves
        '
        Me.rdNo_llaves.AutoSize = True
        Me.rdNo_llaves.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdNo_llaves.CheckedState.BorderThickness = 0
        Me.rdNo_llaves.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdNo_llaves.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rdNo_llaves.CheckedState.InnerOffset = -4
        Me.rdNo_llaves.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdNo_llaves.ForeColor = System.Drawing.Color.Black
        Me.rdNo_llaves.Location = New System.Drawing.Point(126, 58)
        Me.rdNo_llaves.Name = "rdNo_llaves"
        Me.rdNo_llaves.Size = New System.Drawing.Size(43, 19)
        Me.rdNo_llaves.TabIndex = 1
        Me.rdNo_llaves.Text = "No"
        Me.rdNo_llaves.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rdNo_llaves.UncheckedState.BorderThickness = 2
        Me.rdNo_llaves.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rdNo_llaves.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'rdSi_llaves
        '
        Me.rdSi_llaves.AutoSize = True
        Me.rdSi_llaves.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdSi_llaves.CheckedState.BorderThickness = 0
        Me.rdSi_llaves.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdSi_llaves.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rdSi_llaves.CheckedState.InnerOffset = -4
        Me.rdSi_llaves.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdSi_llaves.ForeColor = System.Drawing.Color.Black
        Me.rdSi_llaves.Location = New System.Drawing.Point(40, 58)
        Me.rdSi_llaves.Name = "rdSi_llaves"
        Me.rdSi_llaves.Size = New System.Drawing.Size(36, 19)
        Me.rdSi_llaves.TabIndex = 0
        Me.rdSi_llaves.Text = "Si"
        Me.rdSi_llaves.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rdSi_llaves.UncheckedState.BorderThickness = 2
        Me.rdSi_llaves.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rdSi_llaves.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel1.Controls.Add(Me.bMinimizar)
        Me.Panel1.Controls.Add(Me.bCerrar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1063, 35)
        Me.Panel1.TabIndex = 20
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
        'tbVIN_car
        '
        Me.tbVIN_car.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbVIN_car.DefaultText = ""
        Me.tbVIN_car.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbVIN_car.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbVIN_car.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbVIN_car.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbVIN_car.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbVIN_car.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tbVIN_car.ForeColor = System.Drawing.Color.Black
        Me.tbVIN_car.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbVIN_car.Location = New System.Drawing.Point(498, 64)
        Me.tbVIN_car.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbVIN_car.Name = "tbVIN_car"
        Me.tbVIN_car.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbVIN_car.PlaceholderText = "VIN"
        Me.tbVIN_car.SelectedText = ""
        Me.tbVIN_car.Size = New System.Drawing.Size(211, 30)
        Me.tbVIN_car.TabIndex = 21
        '
        'tbURL_car
        '
        Me.tbURL_car.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbURL_car.DefaultText = ""
        Me.tbURL_car.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbURL_car.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbURL_car.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbURL_car.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbURL_car.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbURL_car.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tbURL_car.ForeColor = System.Drawing.Color.Black
        Me.tbURL_car.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbURL_car.Location = New System.Drawing.Point(263, 173)
        Me.tbURL_car.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.tbURL_car.Name = "tbURL_car"
        Me.tbURL_car.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbURL_car.PlaceholderText = "Fotografía (URL)"
        Me.tbURL_car.SelectedText = ""
        Me.tbURL_car.Size = New System.Drawing.Size(211, 30)
        Me.tbURL_car.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(9, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 21)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Año"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(259, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 21)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Cilindros"
        '
        'Carros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1063, 555)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbURL_car)
        Me.Controls.Add(Me.tbVIN_car)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.dgvCarros)
        Me.Controls.Add(Me.Guna2Button3)
        Me.Controls.Add(Me.Guna2Button2)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.tbID)
        Me.Controls.Add(Me.numcili_car)
        Me.Controls.Add(Me.tbmotor_car)
        Me.Controls.Add(Me.tbcol_car)
        Me.Controls.Add(Me.tbmodelo_car)
        Me.Controls.Add(Me.tbmar_car)
        Me.Controls.Add(Me.Numano_Car)
        Me.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Carros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Carros "
        CType(Me.Numano_Car, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numcili_car, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCarros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Numano_Car As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents tbmar_car As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbmodelo_car As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbcol_car As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbmotor_car As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents numcili_car As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents tbID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dgvCarros As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents bMinimizar As Button
    Friend WithEvents bCerrar As Button
    Friend WithEvents tbVIN_car As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbURL_car As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents rdSi_llaves As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rdNo_llaves As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
