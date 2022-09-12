<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Costodefacturación
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvCostodefac = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btnmodi_cliente = New Guna.UI2.WinForms.Guna2Button()
        Me.btnguarda_client = New Guna.UI2.WinForms.Guna2Button()
        Me.btnnew_client = New Guna.UI2.WinForms.Guna2Button()
        Me.tbplaca_cdfac = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbplegal_cdfac = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbID_cdfac = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cbCarro_Cdfac = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbcom_Cdfac = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cbfact_cdfac = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbimpo_cdfac = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbirs_cdfac = New Guna.UI2.WinForms.Guna2TextBox()
        CType(Me.dgvCostodefac, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCostodefac
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        Me.dgvCostodefac.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvCostodefac.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvCostodefac.BackgroundColor = System.Drawing.Color.White
        Me.dgvCostodefac.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCostodefac.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvCostodefac.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.HotPink
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCostodefac.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvCostodefac.ColumnHeadersHeight = 20
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCostodefac.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvCostodefac.EnableHeadersVisualStyles = False
        Me.dgvCostodefac.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCostodefac.Location = New System.Drawing.Point(81, 277)
        Me.dgvCostodefac.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvCostodefac.Name = "dgvCostodefac"
        Me.dgvCostodefac.ReadOnly = True
        Me.dgvCostodefac.RowHeadersVisible = False
        Me.dgvCostodefac.RowTemplate.Height = 24
        Me.dgvCostodefac.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCostodefac.Size = New System.Drawing.Size(1036, 319)
        Me.dgvCostodefac.TabIndex = 96
        Me.dgvCostodefac.TabStop = False
        Me.dgvCostodefac.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvCostodefac.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvCostodefac.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvCostodefac.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvCostodefac.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvCostodefac.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvCostodefac.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCostodefac.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCostodefac.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvCostodefac.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvCostodefac.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvCostodefac.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvCostodefac.ThemeStyle.HeaderStyle.Height = 20
        Me.dgvCostodefac.ThemeStyle.ReadOnly = True
        Me.dgvCostodefac.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvCostodefac.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvCostodefac.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvCostodefac.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvCostodefac.ThemeStyle.RowsStyle.Height = 24
        Me.dgvCostodefac.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCostodefac.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(98, 143)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 28)
        Me.Label1.TabIndex = 95
        '
        'Btnmodi_cliente
        '
        Me.Btnmodi_cliente.AutoRoundedCorners = True
        Me.Btnmodi_cliente.BorderRadius = 22
        Me.Btnmodi_cliente.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Btnmodi_cliente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Btnmodi_cliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btnmodi_cliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Btnmodi_cliente.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btnmodi_cliente.Font = New System.Drawing.Font("Segoe UI Black", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Btnmodi_cliente.ForeColor = System.Drawing.Color.White
        Me.Btnmodi_cliente.Location = New System.Drawing.Point(833, 115)
        Me.Btnmodi_cliente.Margin = New System.Windows.Forms.Padding(4)
        Me.Btnmodi_cliente.Name = "Btnmodi_cliente"
        Me.Btnmodi_cliente.Size = New System.Drawing.Size(240, 47)
        Me.Btnmodi_cliente.TabIndex = 94
        Me.Btnmodi_cliente.Text = "Modificar"
        '
        'btnguarda_client
        '
        Me.btnguarda_client.AutoRoundedCorners = True
        Me.btnguarda_client.BorderRadius = 22
        Me.btnguarda_client.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnguarda_client.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnguarda_client.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnguarda_client.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnguarda_client.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.btnguarda_client.Font = New System.Drawing.Font("Segoe UI Black", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnguarda_client.ForeColor = System.Drawing.Color.White
        Me.btnguarda_client.Location = New System.Drawing.Point(833, 61)
        Me.btnguarda_client.Margin = New System.Windows.Forms.Padding(4)
        Me.btnguarda_client.Name = "btnguarda_client"
        Me.btnguarda_client.Size = New System.Drawing.Size(240, 47)
        Me.btnguarda_client.TabIndex = 93
        Me.btnguarda_client.Text = "Guardar"
        '
        'btnnew_client
        '
        Me.btnnew_client.AutoRoundedCorners = True
        Me.btnnew_client.BackColor = System.Drawing.Color.Transparent
        Me.btnnew_client.BorderRadius = 22
        Me.btnnew_client.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnnew_client.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnnew_client.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnnew_client.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnnew_client.Font = New System.Drawing.Font("Segoe UI Black", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnnew_client.ForeColor = System.Drawing.Color.White
        Me.btnnew_client.Location = New System.Drawing.Point(833, 7)
        Me.btnnew_client.Margin = New System.Windows.Forms.Padding(4)
        Me.btnnew_client.Name = "btnnew_client"
        Me.btnnew_client.Size = New System.Drawing.Size(240, 47)
        Me.btnnew_client.TabIndex = 92
        Me.btnnew_client.Text = "Nuevo"
        '
        'tbplaca_cdfac
        '
        Me.tbplaca_cdfac.AutoRoundedCorners = True
        Me.tbplaca_cdfac.BorderRadius = 17
        Me.tbplaca_cdfac.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbplaca_cdfac.DefaultText = ""
        Me.tbplaca_cdfac.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbplaca_cdfac.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbplaca_cdfac.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbplaca_cdfac.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbplaca_cdfac.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbplaca_cdfac.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tbplaca_cdfac.ForeColor = System.Drawing.Color.Black
        Me.tbplaca_cdfac.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbplaca_cdfac.Location = New System.Drawing.Point(469, 78)
        Me.tbplaca_cdfac.Margin = New System.Windows.Forms.Padding(5)
        Me.tbplaca_cdfac.MaxLength = 9
        Me.tbplaca_cdfac.Name = "tbplaca_cdfac"
        Me.tbplaca_cdfac.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbplaca_cdfac.PlaceholderText = "Placas "
        Me.tbplaca_cdfac.SelectedText = ""
        Me.tbplaca_cdfac.Size = New System.Drawing.Size(345, 37)
        Me.tbplaca_cdfac.TabIndex = 90
        '
        'tbplegal_cdfac
        '
        Me.tbplegal_cdfac.AutoRoundedCorners = True
        Me.tbplegal_cdfac.BorderRadius = 17
        Me.tbplegal_cdfac.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbplegal_cdfac.DefaultText = ""
        Me.tbplegal_cdfac.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbplegal_cdfac.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbplegal_cdfac.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbplegal_cdfac.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbplegal_cdfac.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbplegal_cdfac.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tbplegal_cdfac.ForeColor = System.Drawing.Color.Black
        Me.tbplegal_cdfac.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbplegal_cdfac.Location = New System.Drawing.Point(467, 125)
        Me.tbplegal_cdfac.Margin = New System.Windows.Forms.Padding(5)
        Me.tbplegal_cdfac.Name = "tbplegal_cdfac"
        Me.tbplegal_cdfac.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbplegal_cdfac.PlaceholderText = "Proceso legal"
        Me.tbplegal_cdfac.SelectedText = ""
        Me.tbplegal_cdfac.Size = New System.Drawing.Size(347, 37)
        Me.tbplegal_cdfac.TabIndex = 91
        '
        'tbID_cdfac
        '
        Me.tbID_cdfac.AutoRoundedCorners = True
        Me.tbID_cdfac.BorderRadius = 17
        Me.tbID_cdfac.Cursor = System.Windows.Forms.Cursors.No
        Me.tbID_cdfac.DefaultText = ""
        Me.tbID_cdfac.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbID_cdfac.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbID_cdfac.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbID_cdfac.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbID_cdfac.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbID_cdfac.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tbID_cdfac.ForeColor = System.Drawing.Color.Black
        Me.tbID_cdfac.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbID_cdfac.Location = New System.Drawing.Point(40, 7)
        Me.tbID_cdfac.Margin = New System.Windows.Forms.Padding(5)
        Me.tbID_cdfac.Name = "tbID_cdfac"
        Me.tbID_cdfac.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbID_cdfac.PlaceholderText = "ID"
        Me.tbID_cdfac.ReadOnly = True
        Me.tbID_cdfac.SelectedText = ""
        Me.tbID_cdfac.Size = New System.Drawing.Size(57, 37)
        Me.tbID_cdfac.TabIndex = 85
        '
        'cbCarro_Cdfac
        '
        Me.cbCarro_Cdfac.AutoRoundedCorners = True
        Me.cbCarro_Cdfac.BackColor = System.Drawing.Color.Transparent
        Me.cbCarro_Cdfac.BorderRadius = 17
        Me.cbCarro_Cdfac.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbCarro_Cdfac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCarro_Cdfac.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbCarro_Cdfac.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbCarro_Cdfac.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cbCarro_Cdfac.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbCarro_Cdfac.ItemHeight = 30
        Me.cbCarro_Cdfac.Location = New System.Drawing.Point(142, 71)
        Me.cbCarro_Cdfac.Margin = New System.Windows.Forms.Padding(4)
        Me.cbCarro_Cdfac.Name = "cbCarro_Cdfac"
        Me.cbCarro_Cdfac.Size = New System.Drawing.Size(257, 36)
        Me.cbCarro_Cdfac.TabIndex = 100
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(35, 133)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 28)
        Me.Label2.TabIndex = 99
        Me.Label2.Text = "Compra"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(35, 80)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 28)
        Me.Label3.TabIndex = 98
        Me.Label3.Text = "Carro"
        '
        'cbcom_Cdfac
        '
        Me.cbcom_Cdfac.AutoRoundedCorners = True
        Me.cbcom_Cdfac.BackColor = System.Drawing.Color.Transparent
        Me.cbcom_Cdfac.BorderRadius = 17
        Me.cbcom_Cdfac.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbcom_Cdfac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbcom_Cdfac.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbcom_Cdfac.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbcom_Cdfac.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cbcom_Cdfac.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbcom_Cdfac.ItemHeight = 30
        Me.cbcom_Cdfac.Location = New System.Drawing.Point(142, 126)
        Me.cbcom_Cdfac.Margin = New System.Windows.Forms.Padding(4)
        Me.cbcom_Cdfac.Name = "cbcom_Cdfac"
        Me.cbcom_Cdfac.Size = New System.Drawing.Size(257, 36)
        Me.cbcom_Cdfac.TabIndex = 97
        '
        'cbfact_cdfac
        '
        Me.cbfact_cdfac.AutoRoundedCorners = True
        Me.cbfact_cdfac.BackColor = System.Drawing.Color.Transparent
        Me.cbfact_cdfac.BorderRadius = 17
        Me.cbfact_cdfac.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbfact_cdfac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbfact_cdfac.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbfact_cdfac.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbfact_cdfac.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cbfact_cdfac.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbfact_cdfac.ItemHeight = 30
        Me.cbfact_cdfac.Location = New System.Drawing.Point(142, 181)
        Me.cbfact_cdfac.Margin = New System.Windows.Forms.Padding(4)
        Me.cbfact_cdfac.Name = "cbfact_cdfac"
        Me.cbfact_cdfac.Size = New System.Drawing.Size(257, 36)
        Me.cbfact_cdfac.TabIndex = 105
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(-6, 233)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 28)
        Me.Label4.TabIndex = 104
        Me.Label4.Text = "Importacion "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(7, 181)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 28)
        Me.Label5.TabIndex = 103
        Me.Label5.Text = "Facturacion"
        '
        'cbimpo_cdfac
        '
        Me.cbimpo_cdfac.AutoRoundedCorners = True
        Me.cbimpo_cdfac.BackColor = System.Drawing.Color.Transparent
        Me.cbimpo_cdfac.BorderRadius = 17
        Me.cbimpo_cdfac.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbimpo_cdfac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbimpo_cdfac.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbimpo_cdfac.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbimpo_cdfac.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cbimpo_cdfac.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbimpo_cdfac.ItemHeight = 30
        Me.cbimpo_cdfac.Location = New System.Drawing.Point(142, 233)
        Me.cbimpo_cdfac.Margin = New System.Windows.Forms.Padding(4)
        Me.cbimpo_cdfac.Name = "cbimpo_cdfac"
        Me.cbimpo_cdfac.Size = New System.Drawing.Size(257, 36)
        Me.cbimpo_cdfac.TabIndex = 102
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(98, 253)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 28)
        Me.Label6.TabIndex = 101
        '
        'tbirs_cdfac
        '
        Me.tbirs_cdfac.AutoRoundedCorners = True
        Me.tbirs_cdfac.BorderRadius = 17
        Me.tbirs_cdfac.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbirs_cdfac.DefaultText = ""
        Me.tbirs_cdfac.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbirs_cdfac.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbirs_cdfac.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbirs_cdfac.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbirs_cdfac.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbirs_cdfac.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tbirs_cdfac.ForeColor = System.Drawing.Color.Black
        Me.tbirs_cdfac.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbirs_cdfac.Location = New System.Drawing.Point(467, 172)
        Me.tbirs_cdfac.Margin = New System.Windows.Forms.Padding(5)
        Me.tbirs_cdfac.Name = "tbirs_cdfac"
        Me.tbirs_cdfac.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbirs_cdfac.PlaceholderText = "IRS "
        Me.tbirs_cdfac.SelectedText = ""
        Me.tbirs_cdfac.Size = New System.Drawing.Size(347, 37)
        Me.tbirs_cdfac.TabIndex = 106
        '
        'Costodefacturación
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1295, 681)
        Me.Controls.Add(Me.tbirs_cdfac)
        Me.Controls.Add(Me.cbfact_cdfac)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbimpo_cdfac)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbCarro_Cdfac)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbcom_Cdfac)
        Me.Controls.Add(Me.dgvCostodefac)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btnmodi_cliente)
        Me.Controls.Add(Me.btnguarda_client)
        Me.Controls.Add(Me.btnnew_client)
        Me.Controls.Add(Me.tbplaca_cdfac)
        Me.Controls.Add(Me.tbplegal_cdfac)
        Me.Controls.Add(Me.tbID_cdfac)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Name = "Costodefacturación"
        Me.Text = "Costodefacturación"
        CType(Me.dgvCostodefac, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvCostodefac As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Btnmodi_cliente As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnguarda_client As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnnew_client As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents tbplaca_cdfac As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbplegal_cdfac As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbID_cdfac As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cbCarro_Cdfac As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbcom_Cdfac As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cbfact_cdfac As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cbimpo_cdfac As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbirs_cdfac As Guna.UI2.WinForms.Guna2TextBox
End Class
