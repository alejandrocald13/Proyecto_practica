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
        Me.cbCarro_ventas = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nudcomision_ventas = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.dtpFecha_CompraCar = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbrevendedor_ventas = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btnmodifi_ventas = New Guna.UI2.WinForms.Guna2Button()
        Me.btnsave_ventas = New Guna.UI2.WinForms.Guna2Button()
        Me.btnnew_ventas = New Guna.UI2.WinForms.Guna2Button()
        Me.tbID_CompraCar = New Guna.UI2.WinForms.Guna2TextBox()
        Me.dgvventas = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.cbventas_ventas = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbcliente_cliente = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.tbtraspaso_ventas = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.nudganancias_ventas = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.nudtotal_ventas = New Guna.UI2.WinForms.Guna2NumericUpDown()
        CType(Me.nudcomision_ventas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvventas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudganancias_ventas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudtotal_ventas, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.cbCarro_ventas.Location = New System.Drawing.Point(144, 166)
        Me.cbCarro_ventas.Margin = New System.Windows.Forms.Padding(4)
        Me.cbCarro_ventas.Name = "cbCarro_ventas"
        Me.cbCarro_ventas.Size = New System.Drawing.Size(257, 36)
        Me.cbCarro_ventas.TabIndex = 57
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(494, 205)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(181, 28)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Fecha de Compra"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(468, 52)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 28)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Comision ($)"
        '
        'nudcomision_ventas
        '
        Me.nudcomision_ventas.AutoRoundedCorners = True
        Me.nudcomision_ventas.BackColor = System.Drawing.Color.Transparent
        Me.nudcomision_ventas.BorderRadius = 17
        Me.nudcomision_ventas.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.nudcomision_ventas.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.nudcomision_ventas.ForeColor = System.Drawing.Color.Black
        Me.nudcomision_ventas.Increment = New Decimal(New Integer() {50, 0, 0, 0})
        Me.nudcomision_ventas.Location = New System.Drawing.Point(616, 43)
        Me.nudcomision_ventas.Margin = New System.Windows.Forms.Padding(5)
        Me.nudcomision_ventas.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudcomision_ventas.Minimum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.nudcomision_ventas.Name = "nudcomision_ventas"
        Me.nudcomision_ventas.Size = New System.Drawing.Size(253, 37)
        Me.nudcomision_ventas.TabIndex = 52
        Me.nudcomision_ventas.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.nudcomision_ventas.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'dtpFecha_CompraCar
        '
        Me.dtpFecha_CompraCar.AutoRoundedCorners = True
        Me.dtpFecha_CompraCar.BorderRadius = 21
        Me.dtpFecha_CompraCar.Checked = True
        Me.dtpFecha_CompraCar.FillColor = System.Drawing.Color.MediumSpringGreen
        Me.dtpFecha_CompraCar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.dtpFecha_CompraCar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.dtpFecha_CompraCar.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha_CompraCar.Location = New System.Drawing.Point(693, 196)
        Me.dtpFecha_CompraCar.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFecha_CompraCar.MaxDate = New Date(2022, 12, 31, 0, 0, 0, 0)
        Me.dtpFecha_CompraCar.MinDate = New Date(2019, 1, 1, 0, 0, 0, 0)
        Me.dtpFecha_CompraCar.Name = "dtpFecha_CompraCar"
        Me.dtpFecha_CompraCar.Size = New System.Drawing.Size(176, 44)
        Me.dtpFecha_CompraCar.TabIndex = 51
        Me.dtpFecha_CompraCar.Value = New Date(2022, 9, 1, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(4, 117)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 28)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Revendedor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(7, 63)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 28)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Venta "
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
        Me.cbrevendedor_ventas.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cbrevendedor_ventas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbrevendedor_ventas.ItemHeight = 30
        Me.cbrevendedor_ventas.Location = New System.Drawing.Point(144, 117)
        Me.cbrevendedor_ventas.Margin = New System.Windows.Forms.Padding(4)
        Me.cbrevendedor_ventas.Name = "cbrevendedor_ventas"
        Me.cbrevendedor_ventas.Size = New System.Drawing.Size(254, 36)
        Me.cbrevendedor_ventas.TabIndex = 46
        '
        'btnmodifi_ventas
        '
        Me.btnmodifi_ventas.AutoRoundedCorners = True
        Me.btnmodifi_ventas.BorderRadius = 22
        Me.btnmodifi_ventas.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnmodifi_ventas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnmodifi_ventas.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnmodifi_ventas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnmodifi_ventas.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnmodifi_ventas.Font = New System.Drawing.Font("Segoe UI Black", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnmodifi_ventas.ForeColor = System.Drawing.Color.White
        Me.btnmodifi_ventas.Location = New System.Drawing.Point(967, 127)
        Me.btnmodifi_ventas.Margin = New System.Windows.Forms.Padding(4)
        Me.btnmodifi_ventas.Name = "btnmodifi_ventas"
        Me.btnmodifi_ventas.Size = New System.Drawing.Size(240, 47)
        Me.btnmodifi_ventas.TabIndex = 45
        Me.btnmodifi_ventas.Text = "Modificar"
        '
        'btnsave_ventas
        '
        Me.btnsave_ventas.AutoRoundedCorners = True
        Me.btnsave_ventas.BorderRadius = 22
        Me.btnsave_ventas.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnsave_ventas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnsave_ventas.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnsave_ventas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnsave_ventas.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.btnsave_ventas.Font = New System.Drawing.Font("Segoe UI Black", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnsave_ventas.ForeColor = System.Drawing.Color.White
        Me.btnsave_ventas.Location = New System.Drawing.Point(967, 73)
        Me.btnsave_ventas.Margin = New System.Windows.Forms.Padding(4)
        Me.btnsave_ventas.Name = "btnsave_ventas"
        Me.btnsave_ventas.Size = New System.Drawing.Size(240, 47)
        Me.btnsave_ventas.TabIndex = 44
        Me.btnsave_ventas.Text = "Guardar"
        '
        'btnnew_ventas
        '
        Me.btnnew_ventas.AutoRoundedCorners = True
        Me.btnnew_ventas.BorderRadius = 22
        Me.btnnew_ventas.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnnew_ventas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnnew_ventas.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnnew_ventas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnnew_ventas.Font = New System.Drawing.Font("Segoe UI Black", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnnew_ventas.ForeColor = System.Drawing.Color.White
        Me.btnnew_ventas.Location = New System.Drawing.Point(967, 19)
        Me.btnnew_ventas.Margin = New System.Windows.Forms.Padding(4)
        Me.btnnew_ventas.Name = "btnnew_ventas"
        Me.btnnew_ventas.Size = New System.Drawing.Size(240, 47)
        Me.btnnew_ventas.TabIndex = 43
        Me.btnnew_ventas.Text = "Nuevo"
        '
        'tbID_CompraCar
        '
        Me.tbID_CompraCar.AutoRoundedCorners = True
        Me.tbID_CompraCar.BorderRadius = 17
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
        Me.tbID_CompraCar.Location = New System.Drawing.Point(31, 10)
        Me.tbID_CompraCar.Margin = New System.Windows.Forms.Padding(5)
        Me.tbID_CompraCar.Name = "tbID_CompraCar"
        Me.tbID_CompraCar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbID_CompraCar.PlaceholderText = "ID"
        Me.tbID_CompraCar.ReadOnly = True
        Me.tbID_CompraCar.SelectedText = ""
        Me.tbID_CompraCar.Size = New System.Drawing.Size(65, 37)
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
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.HotPink
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
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvventas.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvventas.EnableHeadersVisualStyles = False
        Me.dgvventas.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvventas.Location = New System.Drawing.Point(-7, 302)
        Me.dgvventas.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvventas.Name = "dgvventas"
        Me.dgvventas.ReadOnly = True
        Me.dgvventas.RowHeadersVisible = False
        Me.dgvventas.RowTemplate.Height = 24
        Me.dgvventas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvventas.Size = New System.Drawing.Size(1036, 319)
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
        'cbventas_ventas
        '
        Me.cbventas_ventas.AutoRoundedCorners = True
        Me.cbventas_ventas.BackColor = System.Drawing.Color.Transparent
        Me.cbventas_ventas.BorderRadius = 17
        Me.cbventas_ventas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbventas_ventas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbventas_ventas.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbventas_ventas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbventas_ventas.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cbventas_ventas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbventas_ventas.ItemHeight = 30
        Me.cbventas_ventas.Location = New System.Drawing.Point(141, 63)
        Me.cbventas_ventas.Margin = New System.Windows.Forms.Padding(4)
        Me.cbventas_ventas.Name = "cbventas_ventas"
        Me.cbventas_ventas.Size = New System.Drawing.Size(257, 36)
        Me.cbventas_ventas.TabIndex = 101
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(7, 223)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 28)
        Me.Label5.TabIndex = 100
        Me.Label5.Text = "Cliente"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(7, 166)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 28)
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
        Me.cbcliente_cliente.Location = New System.Drawing.Point(144, 220)
        Me.cbcliente_cliente.Margin = New System.Windows.Forms.Padding(4)
        Me.cbcliente_cliente.Name = "cbcliente_cliente"
        Me.cbcliente_cliente.Size = New System.Drawing.Size(257, 36)
        Me.cbcliente_cliente.TabIndex = 98
        '
        'tbtraspaso_ventas
        '
        Me.tbtraspaso_ventas.AutoRoundedCorners = True
        Me.tbtraspaso_ventas.BorderRadius = 17
        Me.tbtraspaso_ventas.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbtraspaso_ventas.DefaultText = ""
        Me.tbtraspaso_ventas.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbtraspaso_ventas.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbtraspaso_ventas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbtraspaso_ventas.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbtraspaso_ventas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbtraspaso_ventas.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tbtraspaso_ventas.ForeColor = System.Drawing.Color.Black
        Me.tbtraspaso_ventas.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbtraspaso_ventas.Location = New System.Drawing.Point(498, 248)
        Me.tbtraspaso_ventas.Margin = New System.Windows.Forms.Padding(5)
        Me.tbtraspaso_ventas.Name = "tbtraspaso_ventas"
        Me.tbtraspaso_ventas.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbtraspaso_ventas.PlaceholderText = "Traspaso "
        Me.tbtraspaso_ventas.SelectedText = ""
        Me.tbtraspaso_ventas.Size = New System.Drawing.Size(369, 37)
        Me.tbtraspaso_ventas.TabIndex = 103
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(471, 99)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 28)
        Me.Label7.TabIndex = 105
        Me.Label7.Text = "Ganancia ($)"
        '
        'nudganancias_ventas
        '
        Me.nudganancias_ventas.AutoRoundedCorners = True
        Me.nudganancias_ventas.BackColor = System.Drawing.Color.Transparent
        Me.nudganancias_ventas.BorderRadius = 17
        Me.nudganancias_ventas.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.nudganancias_ventas.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.nudganancias_ventas.ForeColor = System.Drawing.Color.Black
        Me.nudganancias_ventas.Increment = New Decimal(New Integer() {50, 0, 0, 0})
        Me.nudganancias_ventas.Location = New System.Drawing.Point(614, 90)
        Me.nudganancias_ventas.Margin = New System.Windows.Forms.Padding(5)
        Me.nudganancias_ventas.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudganancias_ventas.Minimum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.nudganancias_ventas.Name = "nudganancias_ventas"
        Me.nudganancias_ventas.Size = New System.Drawing.Size(253, 37)
        Me.nudganancias_ventas.TabIndex = 104
        Me.nudganancias_ventas.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.nudganancias_ventas.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(510, 146)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 28)
        Me.Label8.TabIndex = 107
        Me.Label8.Text = "Total ($)"
        '
        'nudtotal_ventas
        '
        Me.nudtotal_ventas.AutoRoundedCorners = True
        Me.nudtotal_ventas.BackColor = System.Drawing.Color.Transparent
        Me.nudtotal_ventas.BorderRadius = 17
        Me.nudtotal_ventas.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.nudtotal_ventas.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.nudtotal_ventas.ForeColor = System.Drawing.Color.Black
        Me.nudtotal_ventas.Increment = New Decimal(New Integer() {50, 0, 0, 0})
        Me.nudtotal_ventas.Location = New System.Drawing.Point(616, 137)
        Me.nudtotal_ventas.Margin = New System.Windows.Forms.Padding(5)
        Me.nudtotal_ventas.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudtotal_ventas.Minimum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.nudtotal_ventas.Name = "nudtotal_ventas"
        Me.nudtotal_ventas.Size = New System.Drawing.Size(253, 37)
        Me.nudtotal_ventas.TabIndex = 106
        Me.nudtotal_ventas.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.nudtotal_ventas.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1505, 551)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.nudtotal_ventas)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.nudganancias_ventas)
        Me.Controls.Add(Me.tbtraspaso_ventas)
        Me.Controls.Add(Me.cbventas_ventas)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbcliente_cliente)
        Me.Controls.Add(Me.dgvventas)
        Me.Controls.Add(Me.cbCarro_ventas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nudcomision_ventas)
        Me.Controls.Add(Me.dtpFecha_CompraCar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbrevendedor_ventas)
        Me.Controls.Add(Me.btnmodifi_ventas)
        Me.Controls.Add(Me.btnsave_ventas)
        Me.Controls.Add(Me.btnnew_ventas)
        Me.Controls.Add(Me.tbID_CompraCar)
        Me.Name = "Ventas"
        Me.Text = "Ventas"
        CType(Me.nudcomision_ventas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvventas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudganancias_ventas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudtotal_ventas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbCarro_ventas As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents nudcomision_ventas As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents dtpFecha_CompraCar As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbrevendedor_ventas As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnmodifi_ventas As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnsave_ventas As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnnew_ventas As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents tbID_CompraCar As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dgvventas As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents cbventas_ventas As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cbcliente_cliente As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents tbtraspaso_ventas As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents nudganancias_ventas As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents nudtotal_ventas As Guna.UI2.WinForms.Guna2NumericUpDown
End Class
