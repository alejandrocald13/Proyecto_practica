<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ventas))
        Me.cbCarro_ventas = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nudcomision_ventas = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.dtpFecha_CompraCar = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbrevendedor_ventas = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btnmodifi_ventas = New Guna.UI2.WinForms.Guna2Button()
        Me.btnsave_ventas = New Guna.UI2.WinForms.Guna2Button()
        Me.btnnew_ventas = New Guna.UI2.WinForms.Guna2Button()
        Me.tbID_CompraCar = New Guna.UI2.WinForms.Guna2TextBox()
        Me.dgvventas = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbcliente_cliente = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.nudganancias_ventas = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.nudtotal_ventas = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bMinimizar = New System.Windows.Forms.Button()
        Me.bCerrar = New System.Windows.Forms.Button()
        Me.gpSoli_inven = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.rdNo_trasp = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rdSi_trasp = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.cbComision_vent = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.tbCarroSelec_CompraCar = New Guna.UI2.WinForms.Guna2TextBox()
        CType(Me.nudcomision_ventas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvventas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudganancias_ventas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudtotal_ventas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.gpSoli_inven.SuspendLayout()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbCarro_ventas
        '
        Me.cbCarro_ventas.AutoRoundedCorners = True
        Me.cbCarro_ventas.BackColor = System.Drawing.Color.Transparent
        Me.cbCarro_ventas.BorderRadius = 17
        Me.cbCarro_ventas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbCarro_ventas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCarro_ventas.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbCarro_ventas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbCarro_ventas.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cbCarro_ventas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbCarro_ventas.ItemHeight = 30
        Me.cbCarro_ventas.Location = New System.Drawing.Point(72, 96)
        Me.cbCarro_ventas.Name = "cbCarro_ventas"
        Me.cbCarro_ventas.Size = New System.Drawing.Size(207, 36)
        Me.cbCarro_ventas.TabIndex = 57
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(13, 292)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 21)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Fecha de Venta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(8, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 21)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Comisión (Q)"
        '
        'nudcomision_ventas
        '
        Me.nudcomision_ventas.AutoRoundedCorners = True
        Me.nudcomision_ventas.BackColor = System.Drawing.Color.Transparent
        Me.nudcomision_ventas.BorderRadius = 14
        Me.nudcomision_ventas.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.nudcomision_ventas.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.nudcomision_ventas.ForeColor = System.Drawing.Color.Black
        Me.nudcomision_ventas.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.nudcomision_ventas.Location = New System.Drawing.Point(125, 51)
        Me.nudcomision_ventas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nudcomision_ventas.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudcomision_ventas.Name = "nudcomision_ventas"
        Me.nudcomision_ventas.Size = New System.Drawing.Size(185, 30)
        Me.nudcomision_ventas.TabIndex = 52
        Me.nudcomision_ventas.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        '
        'dtpFecha_CompraCar
        '
        Me.dtpFecha_CompraCar.AutoRoundedCorners = True
        Me.dtpFecha_CompraCar.BorderColor = System.Drawing.Color.Transparent
        Me.dtpFecha_CompraCar.BorderRadius = 17
        Me.dtpFecha_CompraCar.Checked = True
        Me.dtpFecha_CompraCar.FillColor = System.Drawing.Color.DarkCyan
        Me.dtpFecha_CompraCar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.dtpFecha_CompraCar.ForeColor = System.Drawing.Color.White
        Me.dtpFecha_CompraCar.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha_CompraCar.Location = New System.Drawing.Point(147, 284)
        Me.dtpFecha_CompraCar.MaxDate = New Date(2022, 12, 31, 0, 0, 0, 0)
        Me.dtpFecha_CompraCar.MinDate = New Date(2019, 1, 1, 0, 0, 0, 0)
        Me.dtpFecha_CompraCar.Name = "dtpFecha_CompraCar"
        Me.dtpFecha_CompraCar.Size = New System.Drawing.Size(132, 36)
        Me.dtpFecha_CompraCar.TabIndex = 51
        Me.dtpFecha_CompraCar.Value = New Date(2022, 9, 21, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(8, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 21)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Revendedor"
        '
        'cbrevendedor_ventas
        '
        Me.cbrevendedor_ventas.AutoRoundedCorners = True
        Me.cbrevendedor_ventas.BackColor = System.Drawing.Color.Transparent
        Me.cbrevendedor_ventas.BorderRadius = 17
        Me.cbrevendedor_ventas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbrevendedor_ventas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbrevendedor_ventas.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbrevendedor_ventas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbrevendedor_ventas.Font = New System.Drawing.Font("Segoe UI Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbrevendedor_ventas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbrevendedor_ventas.ItemHeight = 30
        Me.cbrevendedor_ventas.Location = New System.Drawing.Point(125, 94)
        Me.cbrevendedor_ventas.Name = "cbrevendedor_ventas"
        Me.cbrevendedor_ventas.Size = New System.Drawing.Size(185, 36)
        Me.cbrevendedor_ventas.TabIndex = 46
        '
        'btnmodifi_ventas
        '
        Me.btnmodifi_ventas.AutoRoundedCorners = True
        Me.btnmodifi_ventas.BorderRadius = 18
        Me.btnmodifi_ventas.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnmodifi_ventas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnmodifi_ventas.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnmodifi_ventas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnmodifi_ventas.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnmodifi_ventas.Font = New System.Drawing.Font("Segoe UI Black", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnmodifi_ventas.ForeColor = System.Drawing.Color.White
        Me.btnmodifi_ventas.Location = New System.Drawing.Point(728, 243)
        Me.btnmodifi_ventas.Name = "btnmodifi_ventas"
        Me.btnmodifi_ventas.Size = New System.Drawing.Size(180, 38)
        Me.btnmodifi_ventas.TabIndex = 45
        Me.btnmodifi_ventas.Text = "Modificar"
        '
        'btnsave_ventas
        '
        Me.btnsave_ventas.AutoRoundedCorners = True
        Me.btnsave_ventas.BorderRadius = 18
        Me.btnsave_ventas.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnsave_ventas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnsave_ventas.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnsave_ventas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnsave_ventas.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.btnsave_ventas.Font = New System.Drawing.Font("Segoe UI Black", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnsave_ventas.ForeColor = System.Drawing.Color.White
        Me.btnsave_ventas.Location = New System.Drawing.Point(728, 175)
        Me.btnsave_ventas.Name = "btnsave_ventas"
        Me.btnsave_ventas.Size = New System.Drawing.Size(180, 38)
        Me.btnsave_ventas.TabIndex = 44
        Me.btnsave_ventas.Text = "Guardar"
        '
        'btnnew_ventas
        '
        Me.btnnew_ventas.AutoRoundedCorners = True
        Me.btnnew_ventas.BorderRadius = 18
        Me.btnnew_ventas.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnnew_ventas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnnew_ventas.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnnew_ventas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnnew_ventas.Font = New System.Drawing.Font("Segoe UI Black", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnnew_ventas.ForeColor = System.Drawing.Color.White
        Me.btnnew_ventas.Location = New System.Drawing.Point(728, 96)
        Me.btnnew_ventas.Name = "btnnew_ventas"
        Me.btnnew_ventas.Size = New System.Drawing.Size(180, 38)
        Me.btnnew_ventas.TabIndex = 43
        Me.btnnew_ventas.Text = "Nuevo"
        '
        'tbID_CompraCar
        '
        Me.tbID_CompraCar.AutoRoundedCorners = True
        Me.tbID_CompraCar.BorderRadius = 14
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
        Me.tbID_CompraCar.Location = New System.Drawing.Point(17, 48)
        Me.tbID_CompraCar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbID_CompraCar.Name = "tbID_CompraCar"
        Me.tbID_CompraCar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbID_CompraCar.PlaceholderText = "ID"
        Me.tbID_CompraCar.ReadOnly = True
        Me.tbID_CompraCar.SelectedText = ""
        Me.tbID_CompraCar.Size = New System.Drawing.Size(42, 30)
        Me.tbID_CompraCar.TabIndex = 42
        '
        'dgvventas
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvventas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvventas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvventas.BackgroundColor = System.Drawing.Color.White
        Me.dgvventas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvventas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvventas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(98, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvventas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvventas.ColumnHeadersHeight = 20
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvventas.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvventas.EnableHeadersVisualStyles = False
        Me.dgvventas.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvventas.Location = New System.Drawing.Point(17, 336)
        Me.dgvventas.Name = "dgvventas"
        Me.dgvventas.ReadOnly = True
        Me.dgvventas.RowHeadersVisible = False
        Me.dgvventas.RowTemplate.Height = 24
        Me.dgvventas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvventas.Size = New System.Drawing.Size(891, 293)
        Me.dgvventas.TabIndex = 97
        Me.dgvventas.TabStop = False
        Me.dgvventas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvventas.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvventas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvventas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvventas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvventas.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvventas.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvventas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvventas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvventas.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvventas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvventas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvventas.ThemeStyle.HeaderStyle.Height = 20
        Me.dgvventas.ThemeStyle.ReadOnly = True
        Me.dgvventas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvventas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvventas.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvventas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvventas.ThemeStyle.RowsStyle.Height = 24
        Me.dgvventas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvventas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(13, 243)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 21)
        Me.Label5.TabIndex = 100
        Me.Label5.Text = "Cliente"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(13, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 21)
        Me.Label6.TabIndex = 99
        Me.Label6.Text = "Carro"
        '
        'cbcliente_cliente
        '
        Me.cbcliente_cliente.AutoRoundedCorners = True
        Me.cbcliente_cliente.BackColor = System.Drawing.Color.Transparent
        Me.cbcliente_cliente.BorderRadius = 17
        Me.cbcliente_cliente.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbcliente_cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbcliente_cliente.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbcliente_cliente.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbcliente_cliente.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cbcliente_cliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbcliente_cliente.ItemHeight = 30
        Me.cbcliente_cliente.Location = New System.Drawing.Point(84, 238)
        Me.cbcliente_cliente.Name = "cbcliente_cliente"
        Me.cbcliente_cliente.Size = New System.Drawing.Size(195, 36)
        Me.cbcliente_cliente.TabIndex = 98
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(13, 197)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 21)
        Me.Label7.TabIndex = 105
        Me.Label7.Text = "Ganancia (Q)"
        '
        'nudganancias_ventas
        '
        Me.nudganancias_ventas.AutoRoundedCorners = True
        Me.nudganancias_ventas.BackColor = System.Drawing.Color.Transparent
        Me.nudganancias_ventas.BorderRadius = 14
        Me.nudganancias_ventas.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.nudganancias_ventas.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.nudganancias_ventas.ForeColor = System.Drawing.Color.Black
        Me.nudganancias_ventas.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.nudganancias_ventas.Location = New System.Drawing.Point(130, 194)
        Me.nudganancias_ventas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nudganancias_ventas.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudganancias_ventas.Name = "nudganancias_ventas"
        Me.nudganancias_ventas.Size = New System.Drawing.Size(149, 30)
        Me.nudganancias_ventas.TabIndex = 104
        Me.nudganancias_ventas.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(13, 153)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 21)
        Me.Label8.TabIndex = 107
        Me.Label8.Text = "Total (Q)"
        '
        'nudtotal_ventas
        '
        Me.nudtotal_ventas.AutoRoundedCorners = True
        Me.nudtotal_ventas.BackColor = System.Drawing.Color.Transparent
        Me.nudtotal_ventas.BorderRadius = 14
        Me.nudtotal_ventas.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.nudtotal_ventas.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.nudtotal_ventas.ForeColor = System.Drawing.Color.Black
        Me.nudtotal_ventas.Increment = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudtotal_ventas.Location = New System.Drawing.Point(99, 147)
        Me.nudtotal_ventas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nudtotal_ventas.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudtotal_ventas.Minimum = New Decimal(New Integer() {15000, 0, 0, 0})
        Me.nudtotal_ventas.Name = "nudtotal_ventas"
        Me.nudtotal_ventas.Size = New System.Drawing.Size(180, 30)
        Me.nudtotal_ventas.TabIndex = 106
        Me.nudtotal_ventas.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.nudtotal_ventas.Value = New Decimal(New Integer() {15000, 0, 0, 0})
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Panel1.Controls.Add(Me.bMinimizar)
        Me.Panel1.Controls.Add(Me.bCerrar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(924, 35)
        Me.Panel1.TabIndex = 109
        '
        'bMinimizar
        '
        Me.bMinimizar.FlatAppearance.BorderSize = 0
        Me.bMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.bMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.bMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bMinimizar.Image = CType(resources.GetObject("bMinimizar.Image"), System.Drawing.Image)
        Me.bMinimizar.Location = New System.Drawing.Point(814, 0)
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
        Me.bCerrar.Location = New System.Drawing.Point(872, 0)
        Me.bCerrar.Name = "bCerrar"
        Me.bCerrar.Size = New System.Drawing.Size(52, 35)
        Me.bCerrar.TabIndex = 21
        Me.bCerrar.UseVisualStyleBackColor = True
        '
        'gpSoli_inven
        '
        Me.gpSoli_inven.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.gpSoli_inven.Controls.Add(Me.rdNo_trasp)
        Me.gpSoli_inven.Controls.Add(Me.rdSi_trasp)
        Me.gpSoli_inven.CustomBorderColor = System.Drawing.Color.LightGreen
        Me.gpSoli_inven.CustomBorderThickness = New System.Windows.Forms.Padding(0, 35, 0, 0)
        Me.gpSoli_inven.FillColor = System.Drawing.Color.Transparent
        Me.gpSoli_inven.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpSoli_inven.ForeColor = System.Drawing.Color.Black
        Me.gpSoli_inven.Location = New System.Drawing.Point(357, 238)
        Me.gpSoli_inven.Name = "gpSoli_inven"
        Me.gpSoli_inven.Size = New System.Drawing.Size(325, 82)
        Me.gpSoli_inven.TabIndex = 111
        Me.gpSoli_inven.Text = "Traspaso"
        '
        'rdNo_trasp
        '
        Me.rdNo_trasp.AutoSize = True
        Me.rdNo_trasp.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdNo_trasp.CheckedState.BorderThickness = 0
        Me.rdNo_trasp.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdNo_trasp.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rdNo_trasp.CheckedState.InnerOffset = -4
        Me.rdNo_trasp.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdNo_trasp.ForeColor = System.Drawing.Color.Black
        Me.rdNo_trasp.Location = New System.Drawing.Point(221, 46)
        Me.rdNo_trasp.Name = "rdNo_trasp"
        Me.rdNo_trasp.Size = New System.Drawing.Size(43, 19)
        Me.rdNo_trasp.TabIndex = 1
        Me.rdNo_trasp.Text = "No"
        Me.rdNo_trasp.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rdNo_trasp.UncheckedState.BorderThickness = 2
        Me.rdNo_trasp.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rdNo_trasp.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'rdSi_trasp
        '
        Me.rdSi_trasp.AutoSize = True
        Me.rdSi_trasp.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdSi_trasp.CheckedState.BorderThickness = 0
        Me.rdSi_trasp.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdSi_trasp.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rdSi_trasp.CheckedState.InnerOffset = -4
        Me.rdSi_trasp.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold)
        Me.rdSi_trasp.ForeColor = System.Drawing.Color.Black
        Me.rdSi_trasp.Location = New System.Drawing.Point(76, 46)
        Me.rdSi_trasp.Name = "rdSi_trasp"
        Me.rdSi_trasp.Size = New System.Drawing.Size(36, 19)
        Me.rdSi_trasp.TabIndex = 0
        Me.rdSi_trasp.Text = "Si"
        Me.rdSi_trasp.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rdSi_trasp.UncheckedState.BorderThickness = 2
        Me.rdSi_trasp.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rdSi_trasp.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Guna2GroupBox1.Controls.Add(Me.Label3)
        Me.Guna2GroupBox1.Controls.Add(Me.nudcomision_ventas)
        Me.Guna2GroupBox1.Controls.Add(Me.Label2)
        Me.Guna2GroupBox1.Controls.Add(Me.cbrevendedor_ventas)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.LightGreen
        Me.Guna2GroupBox1.CustomBorderThickness = New System.Windows.Forms.Padding(0, 35, 0, 0)
        Me.Guna2GroupBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(357, 81)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(325, 143)
        Me.Guna2GroupBox1.TabIndex = 112
        Me.Guna2GroupBox1.Text = "Comisión"
        '
        'cbComision_vent
        '
        Me.cbComision_vent.AutoSize = True
        Me.cbComision_vent.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbComision_vent.CheckedState.BorderRadius = 0
        Me.cbComision_vent.CheckedState.BorderThickness = 0
        Me.cbComision_vent.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbComision_vent.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbComision_vent.Location = New System.Drawing.Point(357, 48)
        Me.cbComision_vent.Name = "cbComision_vent"
        Me.cbComision_vent.Size = New System.Drawing.Size(102, 25)
        Me.cbComision_vent.TabIndex = 113
        Me.cbComision_vent.Text = "Comisión"
        Me.cbComision_vent.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.cbComision_vent.UncheckedState.BorderRadius = 0
        Me.cbComision_vent.UncheckedState.BorderThickness = 0
        Me.cbComision_vent.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'tbCarroSelec_CompraCar
        '
        Me.tbCarroSelec_CompraCar.AutoRoundedCorners = True
        Me.tbCarroSelec_CompraCar.BackColor = System.Drawing.Color.Transparent
        Me.tbCarroSelec_CompraCar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tbCarroSelec_CompraCar.BorderRadius = 14
        Me.tbCarroSelec_CompraCar.Cursor = System.Windows.Forms.Cursors.No
        Me.tbCarroSelec_CompraCar.DefaultText = ""
        Me.tbCarroSelec_CompraCar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbCarroSelec_CompraCar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbCarroSelec_CompraCar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbCarroSelec_CompraCar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbCarroSelec_CompraCar.FillColor = System.Drawing.Color.DarkCyan
        Me.tbCarroSelec_CompraCar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbCarroSelec_CompraCar.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.tbCarroSelec_CompraCar.ForeColor = System.Drawing.Color.White
        Me.tbCarroSelec_CompraCar.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbCarroSelec_CompraCar.Location = New System.Drawing.Point(72, 48)
        Me.tbCarroSelec_CompraCar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbCarroSelec_CompraCar.Name = "tbCarroSelec_CompraCar"
        Me.tbCarroSelec_CompraCar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbCarroSelec_CompraCar.PlaceholderForeColor = System.Drawing.Color.White
        Me.tbCarroSelec_CompraCar.PlaceholderText = "Carro Seleccionado"
        Me.tbCarroSelec_CompraCar.ReadOnly = True
        Me.tbCarroSelec_CompraCar.SelectedText = ""
        Me.tbCarroSelec_CompraCar.Size = New System.Drawing.Size(207, 30)
        Me.tbCarroSelec_CompraCar.TabIndex = 114
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 641)
        Me.ControlBox = False
        Me.Controls.Add(Me.tbCarroSelec_CompraCar)
        Me.Controls.Add(Me.cbComision_vent)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.gpSoli_inven)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.nudtotal_ventas)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.nudganancias_ventas)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbcliente_cliente)
        Me.Controls.Add(Me.dgvventas)
        Me.Controls.Add(Me.cbCarro_ventas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpFecha_CompraCar)
        Me.Controls.Add(Me.btnmodifi_ventas)
        Me.Controls.Add(Me.btnsave_ventas)
        Me.Controls.Add(Me.btnnew_ventas)
        Me.Controls.Add(Me.tbID_CompraCar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Ventas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas"
        CType(Me.nudcomision_ventas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvventas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudganancias_ventas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudtotal_ventas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.gpSoli_inven.ResumeLayout(False)
        Me.gpSoli_inven.PerformLayout()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbCarro_ventas As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents nudcomision_ventas As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents dtpFecha_CompraCar As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents cbrevendedor_ventas As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnmodifi_ventas As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnsave_ventas As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnnew_ventas As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents tbID_CompraCar As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dgvventas As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cbcliente_cliente As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents nudganancias_ventas As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents nudtotal_ventas As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents Panel1 As Panel
    Friend WithEvents bMinimizar As Button
    Friend WithEvents bCerrar As Button
    Friend WithEvents gpSoli_inven As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents rdNo_trasp As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rdSi_trasp As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents cbComision_vent As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents tbCarroSelec_CompraCar As Guna.UI2.WinForms.Guna2TextBox
End Class
