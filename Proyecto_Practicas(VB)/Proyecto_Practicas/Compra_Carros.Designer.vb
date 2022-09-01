<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Compra_Carros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Compra_Carros))
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.bMinimizar = New System.Windows.Forms.Button()
        Me.bCerrar = New System.Windows.Forms.Button()
        Me.tbID_CompraCar = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.cbCarro_CompraCar = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cbSub_CompraCar = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbLote_CompraCar = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbDanoPrin_CompraCar = New Guna.UI2.WinForms.Guna2TextBox()
        Me.dtpFecha_CompraCar = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.nudCosto_CompraCar = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbUbi_CompraCar = New Guna.UI2.WinForms.Guna2TextBox()
        Me.dgvCompraC = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbCarroSelec_CompraCar = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.nudCosto_CompraCar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCompraC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gold
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.bMinimizar)
        Me.Panel1.Controls.Add(Me.bCerrar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(840, 35)
        Me.Panel1.TabIndex = 21
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(730, 0)
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
        Me.Button2.Location = New System.Drawing.Point(788, 0)
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
        Me.tbID_CompraCar.Location = New System.Drawing.Point(13, 60)
        Me.tbID_CompraCar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbID_CompraCar.Name = "tbID_CompraCar"
        Me.tbID_CompraCar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbID_CompraCar.PlaceholderText = "ID"
        Me.tbID_CompraCar.ReadOnly = True
        Me.tbID_CompraCar.SelectedText = ""
        Me.tbID_CompraCar.Size = New System.Drawing.Size(49, 30)
        Me.tbID_CompraCar.TabIndex = 22
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
        Me.Guna2Button3.Location = New System.Drawing.Point(648, 162)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.Size = New System.Drawing.Size(180, 38)
        Me.Guna2Button3.TabIndex = 25
        Me.Guna2Button3.Text = "Modificar"
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
        Me.Guna2Button2.Location = New System.Drawing.Point(648, 118)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(180, 38)
        Me.Guna2Button2.TabIndex = 24
        Me.Guna2Button2.Text = "Guardar"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI Black", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(648, 74)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(180, 38)
        Me.Guna2Button1.TabIndex = 23
        Me.Guna2Button1.Text = "Nuevo"
        '
        'cbCarro_CompraCar
        '
        Me.cbCarro_CompraCar.BackColor = System.Drawing.Color.Transparent
        Me.cbCarro_CompraCar.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbCarro_CompraCar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCarro_CompraCar.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbCarro_CompraCar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbCarro_CompraCar.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cbCarro_CompraCar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbCarro_CompraCar.ItemHeight = 30
        Me.cbCarro_CompraCar.Location = New System.Drawing.Point(68, 97)
        Me.cbCarro_CompraCar.Name = "cbCarro_CompraCar"
        Me.cbCarro_CompraCar.Size = New System.Drawing.Size(194, 36)
        Me.cbCarro_CompraCar.TabIndex = 26
        '
        'cbSub_CompraCar
        '
        Me.cbSub_CompraCar.BackColor = System.Drawing.Color.Transparent
        Me.cbSub_CompraCar.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbSub_CompraCar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSub_CompraCar.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbSub_CompraCar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbSub_CompraCar.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSub_CompraCar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbSub_CompraCar.ItemHeight = 30
        Me.cbSub_CompraCar.Location = New System.Drawing.Point(90, 139)
        Me.cbSub_CompraCar.Name = "cbSub_CompraCar"
        Me.cbSub_CompraCar.Size = New System.Drawing.Size(172, 36)
        Me.cbSub_CompraCar.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(9, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 21)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Carro"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(9, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 21)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Subasta"
        '
        'tbLote_CompraCar
        '
        Me.tbLote_CompraCar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbLote_CompraCar.DefaultText = ""
        Me.tbLote_CompraCar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbLote_CompraCar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbLote_CompraCar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbLote_CompraCar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbLote_CompraCar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbLote_CompraCar.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tbLote_CompraCar.ForeColor = System.Drawing.Color.Black
        Me.tbLote_CompraCar.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbLote_CompraCar.Location = New System.Drawing.Point(13, 182)
        Me.tbLote_CompraCar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbLote_CompraCar.Name = "tbLote_CompraCar"
        Me.tbLote_CompraCar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbLote_CompraCar.PlaceholderText = "Lote"
        Me.tbLote_CompraCar.SelectedText = ""
        Me.tbLote_CompraCar.Size = New System.Drawing.Size(249, 30)
        Me.tbLote_CompraCar.TabIndex = 30
        '
        'tbDanoPrin_CompraCar
        '
        Me.tbDanoPrin_CompraCar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbDanoPrin_CompraCar.DefaultText = ""
        Me.tbDanoPrin_CompraCar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbDanoPrin_CompraCar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbDanoPrin_CompraCar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbDanoPrin_CompraCar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbDanoPrin_CompraCar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbDanoPrin_CompraCar.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tbDanoPrin_CompraCar.ForeColor = System.Drawing.Color.Black
        Me.tbDanoPrin_CompraCar.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbDanoPrin_CompraCar.Location = New System.Drawing.Point(13, 220)
        Me.tbDanoPrin_CompraCar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbDanoPrin_CompraCar.Name = "tbDanoPrin_CompraCar"
        Me.tbDanoPrin_CompraCar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbDanoPrin_CompraCar.PlaceholderText = "Daño Principal"
        Me.tbDanoPrin_CompraCar.SelectedText = ""
        Me.tbDanoPrin_CompraCar.Size = New System.Drawing.Size(249, 30)
        Me.tbDanoPrin_CompraCar.TabIndex = 31
        '
        'dtpFecha_CompraCar
        '
        Me.dtpFecha_CompraCar.Checked = True
        Me.dtpFecha_CompraCar.FillColor = System.Drawing.Color.MediumSpringGreen
        Me.dtpFecha_CompraCar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha_CompraCar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.dtpFecha_CompraCar.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha_CompraCar.Location = New System.Drawing.Point(438, 140)
        Me.dtpFecha_CompraCar.MaxDate = New Date(2022, 12, 31, 0, 0, 0, 0)
        Me.dtpFecha_CompraCar.MinDate = New Date(2019, 1, 1, 0, 0, 0, 0)
        Me.dtpFecha_CompraCar.Name = "dtpFecha_CompraCar"
        Me.dtpFecha_CompraCar.Size = New System.Drawing.Size(132, 36)
        Me.dtpFecha_CompraCar.TabIndex = 32
        Me.dtpFecha_CompraCar.Value = New Date(2022, 8, 30, 0, 0, 0, 0)
        '
        'nudCosto_CompraCar
        '
        Me.nudCosto_CompraCar.BackColor = System.Drawing.Color.Transparent
        Me.nudCosto_CompraCar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.nudCosto_CompraCar.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.nudCosto_CompraCar.ForeColor = System.Drawing.Color.Black
        Me.nudCosto_CompraCar.Increment = New Decimal(New Integer() {50, 0, 0, 0})
        Me.nudCosto_CompraCar.Location = New System.Drawing.Point(380, 188)
        Me.nudCosto_CompraCar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nudCosto_CompraCar.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudCosto_CompraCar.Minimum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.nudCosto_CompraCar.Name = "nudCosto_CompraCar"
        Me.nudCosto_CompraCar.Size = New System.Drawing.Size(190, 30)
        Me.nudCosto_CompraCar.TabIndex = 34
        Me.nudCosto_CompraCar.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.nudCosto_CompraCar.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(290, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 21)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Costo ($)"
        '
        'tbUbi_CompraCar
        '
        Me.tbUbi_CompraCar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbUbi_CompraCar.DefaultText = ""
        Me.tbUbi_CompraCar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbUbi_CompraCar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbUbi_CompraCar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbUbi_CompraCar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbUbi_CompraCar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbUbi_CompraCar.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tbUbi_CompraCar.ForeColor = System.Drawing.Color.Black
        Me.tbUbi_CompraCar.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbUbi_CompraCar.Location = New System.Drawing.Point(293, 225)
        Me.tbUbi_CompraCar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbUbi_CompraCar.Name = "tbUbi_CompraCar"
        Me.tbUbi_CompraCar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbUbi_CompraCar.PlaceholderText = "Ubicación de Compra"
        Me.tbUbi_CompraCar.SelectedText = ""
        Me.tbUbi_CompraCar.Size = New System.Drawing.Size(277, 30)
        Me.tbUbi_CompraCar.TabIndex = 36
        '
        'dgvCompraC
        '
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        Me.dgvCompraC.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvCompraC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvCompraC.BackgroundColor = System.Drawing.Color.White
        Me.dgvCompraC.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCompraC.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvCompraC.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCompraC.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvCompraC.ColumnHeadersHeight = 20
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCompraC.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgvCompraC.EnableHeadersVisualStyles = False
        Me.dgvCompraC.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCompraC.Location = New System.Drawing.Point(13, 275)
        Me.dgvCompraC.Name = "dgvCompraC"
        Me.dgvCompraC.ReadOnly = True
        Me.dgvCompraC.RowHeadersVisible = False
        Me.dgvCompraC.RowTemplate.Height = 24
        Me.dgvCompraC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCompraC.Size = New System.Drawing.Size(815, 313)
        Me.dgvCompraC.TabIndex = 37
        Me.dgvCompraC.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvCompraC.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvCompraC.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvCompraC.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvCompraC.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvCompraC.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvCompraC.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCompraC.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCompraC.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvCompraC.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvCompraC.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvCompraC.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvCompraC.ThemeStyle.HeaderStyle.Height = 20
        Me.dgvCompraC.ThemeStyle.ReadOnly = True
        Me.dgvCompraC.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvCompraC.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvCompraC.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvCompraC.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvCompraC.ThemeStyle.RowsStyle.Height = 24
        Me.dgvCompraC.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCompraC.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(289, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 21)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Fecha de Compra"
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
        Me.tbCarroSelec_CompraCar.Location = New System.Drawing.Point(293, 97)
        Me.tbCarroSelec_CompraCar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbCarroSelec_CompraCar.Name = "tbCarroSelec_CompraCar"
        Me.tbCarroSelec_CompraCar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbCarroSelec_CompraCar.PlaceholderForeColor = System.Drawing.Color.White
        Me.tbCarroSelec_CompraCar.PlaceholderText = "Carro Seleccionado"
        Me.tbCarroSelec_CompraCar.ReadOnly = True
        Me.tbCarroSelec_CompraCar.SelectedText = ""
        Me.tbCarroSelec_CompraCar.Size = New System.Drawing.Size(277, 36)
        Me.tbCarroSelec_CompraCar.TabIndex = 39
        '
        'Compra_Carros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 600)
        Me.Controls.Add(Me.tbCarroSelec_CompraCar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgvCompraC)
        Me.Controls.Add(Me.tbUbi_CompraCar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nudCosto_CompraCar)
        Me.Controls.Add(Me.dtpFecha_CompraCar)
        Me.Controls.Add(Me.tbDanoPrin_CompraCar)
        Me.Controls.Add(Me.tbLote_CompraCar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbSub_CompraCar)
        Me.Controls.Add(Me.cbCarro_CompraCar)
        Me.Controls.Add(Me.Guna2Button3)
        Me.Controls.Add(Me.Guna2Button2)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.tbID_CompraCar)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Compra_Carros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compra_Carros"
        Me.Panel1.ResumeLayout(False)
        CType(Me.nudCosto_CompraCar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCompraC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents bMinimizar As Button
    Friend WithEvents bCerrar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents tbID_CompraCar As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cbCarro_CompraCar As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cbSub_CompraCar As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbLote_CompraCar As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbDanoPrin_CompraCar As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dtpFecha_CompraCar As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents nudCosto_CompraCar As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents tbUbi_CompraCar As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dgvCompraC As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents tbCarroSelec_CompraCar As Guna.UI2.WinForms.Guna2TextBox
End Class
