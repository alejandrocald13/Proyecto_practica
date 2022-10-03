<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventario
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvInvent = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnmodi_inven = New Guna.UI2.WinForms.Guna2Button()
        Me.btnguardar_inven = New Guna.UI2.WinForms.Guna2Button()
        Me.btnnuevo_inven = New Guna.UI2.WinForms.Guna2Button()
        Me.tbID_inve = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbCarroSelec_CompraCar = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cbcarrito_inven = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.gpSoli_inven = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.rdNo_Soli = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rdSi_soli = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.cbestado_invent = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbTotal_invent = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btndelete_inven = New Guna.UI2.WinForms.Guna2Button()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.dgvInvent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpSoli_inven.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvInvent
        '
        Me.dgvInvent.AllowUserToAddRows = False
        Me.dgvInvent.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvInvent.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvInvent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvInvent.BackgroundColor = System.Drawing.Color.White
        Me.dgvInvent.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvInvent.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvInvent.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Green
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvInvent.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvInvent.ColumnHeadersHeight = 20
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvInvent.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvInvent.EnableHeadersVisualStyles = False
        Me.dgvInvent.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvInvent.Location = New System.Drawing.Point(17, 311)
        Me.dgvInvent.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvInvent.Name = "dgvInvent"
        Me.dgvInvent.ReadOnly = True
        Me.dgvInvent.RowHeadersVisible = False
        Me.dgvInvent.RowTemplate.Height = 24
        Me.dgvInvent.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.dgvInvent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInvent.Size = New System.Drawing.Size(1057, 398)
        Me.dgvInvent.TabIndex = 55
        Me.dgvInvent.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvInvent.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvInvent.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvInvent.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvInvent.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvInvent.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvInvent.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvInvent.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvInvent.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvInvent.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvInvent.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvInvent.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvInvent.ThemeStyle.HeaderStyle.Height = 20
        Me.dgvInvent.ThemeStyle.ReadOnly = True
        Me.dgvInvent.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvInvent.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvInvent.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvInvent.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvInvent.ThemeStyle.RowsStyle.Height = 24
        Me.dgvInvent.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvInvent.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(16, 127)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 28)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Carro"
        '
        'btnmodi_inven
        '
        Me.btnmodi_inven.AutoRoundedCorners = True
        Me.btnmodi_inven.BorderRadius = 22
        Me.btnmodi_inven.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnmodi_inven.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnmodi_inven.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnmodi_inven.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnmodi_inven.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnmodi_inven.Font = New System.Drawing.Font("Segoe UI Black", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnmodi_inven.ForeColor = System.Drawing.Color.White
        Me.btnmodi_inven.Location = New System.Drawing.Point(835, 177)
        Me.btnmodi_inven.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnmodi_inven.Name = "btnmodi_inven"
        Me.btnmodi_inven.Size = New System.Drawing.Size(240, 47)
        Me.btnmodi_inven.TabIndex = 45
        Me.btnmodi_inven.Text = "Modificar"
        '
        'btnguardar_inven
        '
        Me.btnguardar_inven.AutoRoundedCorners = True
        Me.btnguardar_inven.BorderRadius = 22
        Me.btnguardar_inven.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnguardar_inven.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnguardar_inven.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnguardar_inven.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnguardar_inven.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.btnguardar_inven.Font = New System.Drawing.Font("Segoe UI Black", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnguardar_inven.ForeColor = System.Drawing.Color.White
        Me.btnguardar_inven.Location = New System.Drawing.Point(835, 123)
        Me.btnguardar_inven.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnguardar_inven.Name = "btnguardar_inven"
        Me.btnguardar_inven.Size = New System.Drawing.Size(240, 47)
        Me.btnguardar_inven.TabIndex = 44
        Me.btnguardar_inven.Text = "Guardar"
        '
        'btnnuevo_inven
        '
        Me.btnnuevo_inven.AutoRoundedCorners = True
        Me.btnnuevo_inven.BorderRadius = 22
        Me.btnnuevo_inven.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnnuevo_inven.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnnuevo_inven.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnnuevo_inven.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnnuevo_inven.Font = New System.Drawing.Font("Segoe UI Black", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnnuevo_inven.ForeColor = System.Drawing.Color.White
        Me.btnnuevo_inven.Location = New System.Drawing.Point(835, 69)
        Me.btnnuevo_inven.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnnuevo_inven.Name = "btnnuevo_inven"
        Me.btnnuevo_inven.Size = New System.Drawing.Size(240, 47)
        Me.btnnuevo_inven.TabIndex = 43
        Me.btnnuevo_inven.Text = "Nuevo"
        '
        'tbID_inve
        '
        Me.tbID_inve.AutoRoundedCorners = True
        Me.tbID_inve.BorderRadius = 17
        Me.tbID_inve.Cursor = System.Windows.Forms.Cursors.No
        Me.tbID_inve.DefaultText = ""
        Me.tbID_inve.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbID_inve.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbID_inve.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbID_inve.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbID_inve.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbID_inve.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tbID_inve.ForeColor = System.Drawing.Color.Black
        Me.tbID_inve.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbID_inve.Location = New System.Drawing.Point(17, 69)
        Me.tbID_inve.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.tbID_inve.Name = "tbID_inve"
        Me.tbID_inve.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbID_inve.PlaceholderText = "ID"
        Me.tbID_inve.ReadOnly = True
        Me.tbID_inve.SelectedText = ""
        Me.tbID_inve.Size = New System.Drawing.Size(55, 37)
        Me.tbID_inve.TabIndex = 42
        '
        'tbCarroSelec_CompraCar
        '
        Me.tbCarroSelec_CompraCar.AutoRoundedCorners = True
        Me.tbCarroSelec_CompraCar.BackColor = System.Drawing.Color.Transparent
        Me.tbCarroSelec_CompraCar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tbCarroSelec_CompraCar.BorderRadius = 17
        Me.tbCarroSelec_CompraCar.Cursor = System.Windows.Forms.Cursors.No
        Me.tbCarroSelec_CompraCar.DefaultText = ""
        Me.tbCarroSelec_CompraCar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbCarroSelec_CompraCar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbCarroSelec_CompraCar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbCarroSelec_CompraCar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbCarroSelec_CompraCar.FillColor = System.Drawing.Color.LightGreen
        Me.tbCarroSelec_CompraCar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbCarroSelec_CompraCar.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.tbCarroSelec_CompraCar.ForeColor = System.Drawing.Color.Black
        Me.tbCarroSelec_CompraCar.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbCarroSelec_CompraCar.Location = New System.Drawing.Point(416, 69)
        Me.tbCarroSelec_CompraCar.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.tbCarroSelec_CompraCar.Name = "tbCarroSelec_CompraCar"
        Me.tbCarroSelec_CompraCar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbCarroSelec_CompraCar.PlaceholderForeColor = System.Drawing.Color.Black
        Me.tbCarroSelec_CompraCar.PlaceholderText = "Carro Seleccionado"
        Me.tbCarroSelec_CompraCar.ReadOnly = True
        Me.tbCarroSelec_CompraCar.SelectedText = ""
        Me.tbCarroSelec_CompraCar.Size = New System.Drawing.Size(367, 37)
        Me.tbCarroSelec_CompraCar.TabIndex = 109
        '
        'cbcarrito_inven
        '
        Me.cbcarrito_inven.AutoRoundedCorners = True
        Me.cbcarrito_inven.BackColor = System.Drawing.Color.Transparent
        Me.cbcarrito_inven.BorderRadius = 17
        Me.cbcarrito_inven.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbcarrito_inven.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbcarrito_inven.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbcarrito_inven.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbcarrito_inven.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cbcarrito_inven.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbcarrito_inven.ItemHeight = 30
        Me.cbcarrito_inven.Location = New System.Drawing.Point(108, 116)
        Me.cbcarrito_inven.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbcarrito_inven.Name = "cbcarrito_inven"
        Me.cbcarrito_inven.Size = New System.Drawing.Size(257, 36)
        Me.cbcarrito_inven.TabIndex = 58
        '
        'gpSoli_inven
        '
        Me.gpSoli_inven.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.gpSoli_inven.Controls.Add(Me.rdNo_Soli)
        Me.gpSoli_inven.Controls.Add(Me.rdSi_soli)
        Me.gpSoli_inven.CustomBorderColor = System.Drawing.Color.LightGreen
        Me.gpSoli_inven.CustomBorderThickness = New System.Windows.Forms.Padding(0, 35, 0, 0)
        Me.gpSoli_inven.FillColor = System.Drawing.Color.Transparent
        Me.gpSoli_inven.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpSoli_inven.ForeColor = System.Drawing.Color.Black
        Me.gpSoli_inven.Location = New System.Drawing.Point(416, 175)
        Me.gpSoli_inven.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gpSoli_inven.Name = "gpSoli_inven"
        Me.gpSoli_inven.Size = New System.Drawing.Size(367, 94)
        Me.gpSoli_inven.TabIndex = 110
        Me.gpSoli_inven.Text = "Solicitado"
        '
        'rdNo_Soli
        '
        Me.rdNo_Soli.AutoSize = True
        Me.rdNo_Soli.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdNo_Soli.CheckedState.BorderThickness = 0
        Me.rdNo_Soli.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdNo_Soli.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rdNo_Soli.CheckedState.InnerOffset = -4
        Me.rdNo_Soli.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdNo_Soli.ForeColor = System.Drawing.Color.Black
        Me.rdNo_Soli.Location = New System.Drawing.Point(245, 57)
        Me.rdNo_Soli.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdNo_Soli.Name = "rdNo_Soli"
        Me.rdNo_Soli.Size = New System.Drawing.Size(52, 24)
        Me.rdNo_Soli.TabIndex = 1
        Me.rdNo_Soli.Text = "No"
        Me.rdNo_Soli.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rdNo_Soli.UncheckedState.BorderThickness = 2
        Me.rdNo_Soli.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rdNo_Soli.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'rdSi_soli
        '
        Me.rdSi_soli.AutoSize = True
        Me.rdSi_soli.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdSi_soli.CheckedState.BorderThickness = 0
        Me.rdSi_soli.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdSi_soli.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rdSi_soli.CheckedState.InnerOffset = -4
        Me.rdSi_soli.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold)
        Me.rdSi_soli.ForeColor = System.Drawing.Color.Black
        Me.rdSi_soli.Location = New System.Drawing.Point(67, 57)
        Me.rdSi_soli.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdSi_soli.Name = "rdSi_soli"
        Me.rdSi_soli.Size = New System.Drawing.Size(44, 24)
        Me.rdSi_soli.TabIndex = 0
        Me.rdSi_soli.Text = "Si"
        Me.rdSi_soli.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rdSi_soli.UncheckedState.BorderThickness = 2
        Me.rdSi_soli.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rdSi_soli.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'cbestado_invent
        '
        Me.cbestado_invent.AutoRoundedCorners = True
        Me.cbestado_invent.BackColor = System.Drawing.Color.Transparent
        Me.cbestado_invent.BorderRadius = 17
        Me.cbestado_invent.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbestado_invent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbestado_invent.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbestado_invent.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbestado_invent.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cbestado_invent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbestado_invent.ItemHeight = 30
        Me.cbestado_invent.Items.AddRange(New Object() {"Disponible", "Reparación", "Espertaje", "Importación"})
        Me.cbestado_invent.Location = New System.Drawing.Point(108, 224)
        Me.cbestado_invent.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbestado_invent.Name = "cbestado_invent"
        Me.cbestado_invent.Size = New System.Drawing.Size(257, 36)
        Me.cbestado_invent.TabIndex = 111
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(16, 235)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 28)
        Me.Label2.TabIndex = 112
        Me.Label2.Text = "Estado"
        '
        'tbTotal_invent
        '
        Me.tbTotal_invent.AutoRoundedCorners = True
        Me.tbTotal_invent.BackColor = System.Drawing.Color.Transparent
        Me.tbTotal_invent.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tbTotal_invent.BorderRadius = 17
        Me.tbTotal_invent.Cursor = System.Windows.Forms.Cursors.No
        Me.tbTotal_invent.DefaultText = ""
        Me.tbTotal_invent.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbTotal_invent.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbTotal_invent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbTotal_invent.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbTotal_invent.FillColor = System.Drawing.Color.DeepSkyBlue
        Me.tbTotal_invent.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbTotal_invent.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.tbTotal_invent.ForeColor = System.Drawing.Color.White
        Me.tbTotal_invent.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbTotal_invent.Location = New System.Drawing.Point(17, 175)
        Me.tbTotal_invent.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.tbTotal_invent.Name = "tbTotal_invent"
        Me.tbTotal_invent.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbTotal_invent.PlaceholderForeColor = System.Drawing.Color.White
        Me.tbTotal_invent.PlaceholderText = "Costo Total"
        Me.tbTotal_invent.ReadOnly = True
        Me.tbTotal_invent.SelectedText = ""
        Me.tbTotal_invent.Size = New System.Drawing.Size(349, 37)
        Me.tbTotal_invent.TabIndex = 113
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Green
        Me.Label4.Location = New System.Drawing.Point(504, 129)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 28)
        Me.Label4.TabIndex = 119
        '
        'btndelete_inven
        '
        Me.btndelete_inven.AutoRoundedCorners = True
        Me.btndelete_inven.BorderRadius = 22
        Me.btndelete_inven.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btndelete_inven.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btndelete_inven.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btndelete_inven.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btndelete_inven.FillColor = System.Drawing.Color.Red
        Me.btndelete_inven.Font = New System.Drawing.Font("Segoe UI Black", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btndelete_inven.ForeColor = System.Drawing.Color.White
        Me.btndelete_inven.Location = New System.Drawing.Point(835, 231)
        Me.btndelete_inven.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btndelete_inven.Name = "btndelete_inven"
        Me.btndelete_inven.Size = New System.Drawing.Size(240, 47)
        Me.btndelete_inven.TabIndex = 120
        Me.btndelete_inven.Text = "Eliminar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(495, 16)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(164, 29)
        Me.Label5.TabIndex = 123
        Me.Label5.Text = "INVENTARIO"
        '
        'Inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1101, 690)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btndelete_inven)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbTotal_invent)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbestado_invent)
        Me.Controls.Add(Me.gpSoli_inven)
        Me.Controls.Add(Me.tbCarroSelec_CompraCar)
        Me.Controls.Add(Me.cbcarrito_inven)
        Me.Controls.Add(Me.dgvInvent)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnmodi_inven)
        Me.Controls.Add(Me.btnguardar_inven)
        Me.Controls.Add(Me.btnnuevo_inven)
        Me.Controls.Add(Me.tbID_inve)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Inventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventario"
        CType(Me.dgvInvent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpSoli_inven.ResumeLayout(False)
        Me.gpSoli_inven.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvInvent As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnmodi_inven As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnguardar_inven As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnnuevo_inven As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents tbID_inve As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbCarroSelec_CompraCar As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cbcarrito_inven As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents gpSoli_inven As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents rdNo_Soli As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rdSi_soli As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents cbestado_invent As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbTotal_invent As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btndelete_inven As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label5 As Label
End Class
