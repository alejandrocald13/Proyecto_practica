<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Costodefacturación
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvCostodefac = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Btnmodi_cliente = New Guna.UI2.WinForms.Guna2Button()
        Me.btnguarda_client = New Guna.UI2.WinForms.Guna2Button()
        Me.btnnew_client = New Guna.UI2.WinForms.Guna2Button()
        Me.tbID_cdfac = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cbCarro_Cdfac = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbLoteSelec_Impo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbCarroSelec_CompraCar = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbEncargselec_Impo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbIPRIMA_impo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbIVA_impo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbCostoPlacas_Impo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dgvCostodefac, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCostodefac
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvCostodefac.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCostodefac.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvCostodefac.BackgroundColor = System.Drawing.Color.White
        Me.dgvCostodefac.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCostodefac.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvCostodefac.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(115, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCostodefac.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCostodefac.ColumnHeadersHeight = 20
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCostodefac.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvCostodefac.EnableHeadersVisualStyles = False
        Me.dgvCostodefac.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCostodefac.Location = New System.Drawing.Point(13, 228)
        Me.dgvCostodefac.Name = "dgvCostodefac"
        Me.dgvCostodefac.ReadOnly = True
        Me.dgvCostodefac.RowHeadersVisible = False
        Me.dgvCostodefac.RowTemplate.Height = 24
        Me.dgvCostodefac.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCostodefac.Size = New System.Drawing.Size(795, 268)
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
        'Btnmodi_cliente
        '
        Me.Btnmodi_cliente.AutoRoundedCorners = True
        Me.Btnmodi_cliente.BorderRadius = 18
        Me.Btnmodi_cliente.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Btnmodi_cliente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Btnmodi_cliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btnmodi_cliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Btnmodi_cliente.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btnmodi_cliente.Font = New System.Drawing.Font("Segoe UI Black", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Btnmodi_cliente.ForeColor = System.Drawing.Color.White
        Me.Btnmodi_cliente.Location = New System.Drawing.Point(628, 166)
        Me.Btnmodi_cliente.Name = "Btnmodi_cliente"
        Me.Btnmodi_cliente.Size = New System.Drawing.Size(180, 38)
        Me.Btnmodi_cliente.TabIndex = 94
        Me.Btnmodi_cliente.Text = "Modificar"
        '
        'btnguarda_client
        '
        Me.btnguarda_client.AutoRoundedCorners = True
        Me.btnguarda_client.BorderRadius = 18
        Me.btnguarda_client.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnguarda_client.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnguarda_client.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnguarda_client.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnguarda_client.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.btnguarda_client.Font = New System.Drawing.Font("Segoe UI Black", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnguarda_client.ForeColor = System.Drawing.Color.White
        Me.btnguarda_client.Location = New System.Drawing.Point(628, 120)
        Me.btnguarda_client.Name = "btnguarda_client"
        Me.btnguarda_client.Size = New System.Drawing.Size(180, 38)
        Me.btnguarda_client.TabIndex = 93
        Me.btnguarda_client.Text = "Guardar"
        '
        'btnnew_client
        '
        Me.btnnew_client.AutoRoundedCorners = True
        Me.btnnew_client.BackColor = System.Drawing.Color.Transparent
        Me.btnnew_client.BorderRadius = 18
        Me.btnnew_client.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnnew_client.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnnew_client.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnnew_client.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnnew_client.Font = New System.Drawing.Font("Segoe UI Black", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnnew_client.ForeColor = System.Drawing.Color.White
        Me.btnnew_client.Location = New System.Drawing.Point(628, 76)
        Me.btnnew_client.Name = "btnnew_client"
        Me.btnnew_client.Size = New System.Drawing.Size(180, 38)
        Me.btnnew_client.TabIndex = 92
        Me.btnnew_client.Text = "Nuevo"
        '
        'tbID_cdfac
        '
        Me.tbID_cdfac.AutoRoundedCorners = True
        Me.tbID_cdfac.BorderRadius = 14
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
        Me.tbID_cdfac.Location = New System.Drawing.Point(13, 54)
        Me.tbID_cdfac.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbID_cdfac.Name = "tbID_cdfac"
        Me.tbID_cdfac.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbID_cdfac.PlaceholderText = "ID"
        Me.tbID_cdfac.ReadOnly = True
        Me.tbID_cdfac.SelectedText = ""
        Me.tbID_cdfac.Size = New System.Drawing.Size(43, 30)
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
        Me.cbCarro_Cdfac.Location = New System.Drawing.Point(88, 85)
        Me.cbCarro_Cdfac.Name = "cbCarro_Cdfac"
        Me.cbCarro_Cdfac.Size = New System.Drawing.Size(194, 36)
        Me.cbCarro_Cdfac.TabIndex = 100
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(12, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 21)
        Me.Label3.TabIndex = 98
        Me.Label3.Text = "Carro"
        '
        'tbLoteSelec_Impo
        '
        Me.tbLoteSelec_Impo.AutoRoundedCorners = True
        Me.tbLoteSelec_Impo.BackColor = System.Drawing.Color.Transparent
        Me.tbLoteSelec_Impo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tbLoteSelec_Impo.BorderRadius = 14
        Me.tbLoteSelec_Impo.Cursor = System.Windows.Forms.Cursors.No
        Me.tbLoteSelec_Impo.DefaultText = ""
        Me.tbLoteSelec_Impo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbLoteSelec_Impo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbLoteSelec_Impo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbLoteSelec_Impo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbLoteSelec_Impo.FillColor = System.Drawing.Color.SteelBlue
        Me.tbLoteSelec_Impo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbLoteSelec_Impo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.tbLoteSelec_Impo.ForeColor = System.Drawing.Color.White
        Me.tbLoteSelec_Impo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbLoteSelec_Impo.Location = New System.Drawing.Point(13, 128)
        Me.tbLoteSelec_Impo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbLoteSelec_Impo.Name = "tbLoteSelec_Impo"
        Me.tbLoteSelec_Impo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbLoteSelec_Impo.PlaceholderForeColor = System.Drawing.Color.White
        Me.tbLoteSelec_Impo.PlaceholderText = "Lote de Compra"
        Me.tbLoteSelec_Impo.ReadOnly = True
        Me.tbLoteSelec_Impo.SelectedText = ""
        Me.tbLoteSelec_Impo.Size = New System.Drawing.Size(269, 30)
        Me.tbLoteSelec_Impo.TabIndex = 109
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
        Me.tbCarroSelec_CompraCar.FillColor = System.Drawing.Color.DarkGreen
        Me.tbCarroSelec_CompraCar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbCarroSelec_CompraCar.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.tbCarroSelec_CompraCar.ForeColor = System.Drawing.Color.White
        Me.tbCarroSelec_CompraCar.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbCarroSelec_CompraCar.Location = New System.Drawing.Point(323, 54)
        Me.tbCarroSelec_CompraCar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbCarroSelec_CompraCar.Name = "tbCarroSelec_CompraCar"
        Me.tbCarroSelec_CompraCar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbCarroSelec_CompraCar.PlaceholderForeColor = System.Drawing.Color.White
        Me.tbCarroSelec_CompraCar.PlaceholderText = "Carro Seleccionado"
        Me.tbCarroSelec_CompraCar.ReadOnly = True
        Me.tbCarroSelec_CompraCar.SelectedText = ""
        Me.tbCarroSelec_CompraCar.Size = New System.Drawing.Size(275, 30)
        Me.tbCarroSelec_CompraCar.TabIndex = 108
        '
        'tbEncargselec_Impo
        '
        Me.tbEncargselec_Impo.AutoRoundedCorners = True
        Me.tbEncargselec_Impo.BackColor = System.Drawing.Color.Transparent
        Me.tbEncargselec_Impo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tbEncargselec_Impo.BorderRadius = 14
        Me.tbEncargselec_Impo.Cursor = System.Windows.Forms.Cursors.No
        Me.tbEncargselec_Impo.DefaultText = ""
        Me.tbEncargselec_Impo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbEncargselec_Impo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbEncargselec_Impo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbEncargselec_Impo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbEncargselec_Impo.FillColor = System.Drawing.Color.SteelBlue
        Me.tbEncargselec_Impo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbEncargselec_Impo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.tbEncargselec_Impo.ForeColor = System.Drawing.Color.White
        Me.tbEncargselec_Impo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbEncargselec_Impo.Location = New System.Drawing.Point(13, 166)
        Me.tbEncargselec_Impo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbEncargselec_Impo.Name = "tbEncargselec_Impo"
        Me.tbEncargselec_Impo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbEncargselec_Impo.PlaceholderForeColor = System.Drawing.Color.White
        Me.tbEncargselec_Impo.PlaceholderText = "Encargado de Importación"
        Me.tbEncargselec_Impo.ReadOnly = True
        Me.tbEncargselec_Impo.SelectedText = ""
        Me.tbEncargselec_Impo.Size = New System.Drawing.Size(269, 30)
        Me.tbEncargselec_Impo.TabIndex = 112
        '
        'tbIPRIMA_impo
        '
        Me.tbIPRIMA_impo.AutoRoundedCorners = True
        Me.tbIPRIMA_impo.BackColor = System.Drawing.Color.Transparent
        Me.tbIPRIMA_impo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tbIPRIMA_impo.BorderRadius = 14
        Me.tbIPRIMA_impo.Cursor = System.Windows.Forms.Cursors.No
        Me.tbIPRIMA_impo.DefaultText = ""
        Me.tbIPRIMA_impo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbIPRIMA_impo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbIPRIMA_impo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbIPRIMA_impo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbIPRIMA_impo.FillColor = System.Drawing.Color.SteelBlue
        Me.tbIPRIMA_impo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbIPRIMA_impo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.tbIPRIMA_impo.ForeColor = System.Drawing.Color.White
        Me.tbIPRIMA_impo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbIPRIMA_impo.Location = New System.Drawing.Point(323, 129)
        Me.tbIPRIMA_impo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbIPRIMA_impo.Name = "tbIPRIMA_impo"
        Me.tbIPRIMA_impo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbIPRIMA_impo.PlaceholderForeColor = System.Drawing.Color.White
        Me.tbIPRIMA_impo.PlaceholderText = "IPRIMA (Q)"
        Me.tbIPRIMA_impo.ReadOnly = True
        Me.tbIPRIMA_impo.SelectedText = ""
        Me.tbIPRIMA_impo.Size = New System.Drawing.Size(275, 30)
        Me.tbIPRIMA_impo.TabIndex = 113
        '
        'tbIVA_impo
        '
        Me.tbIVA_impo.AutoRoundedCorners = True
        Me.tbIVA_impo.BackColor = System.Drawing.Color.Transparent
        Me.tbIVA_impo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tbIVA_impo.BorderRadius = 14
        Me.tbIVA_impo.Cursor = System.Windows.Forms.Cursors.No
        Me.tbIVA_impo.DefaultText = ""
        Me.tbIVA_impo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbIVA_impo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbIVA_impo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbIVA_impo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbIVA_impo.FillColor = System.Drawing.Color.SteelBlue
        Me.tbIVA_impo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbIVA_impo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.tbIVA_impo.ForeColor = System.Drawing.Color.White
        Me.tbIVA_impo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbIVA_impo.Location = New System.Drawing.Point(323, 166)
        Me.tbIVA_impo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbIVA_impo.Name = "tbIVA_impo"
        Me.tbIVA_impo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbIVA_impo.PlaceholderForeColor = System.Drawing.Color.White
        Me.tbIVA_impo.PlaceholderText = "IVA (Q)"
        Me.tbIVA_impo.ReadOnly = True
        Me.tbIVA_impo.SelectedText = ""
        Me.tbIVA_impo.Size = New System.Drawing.Size(275, 30)
        Me.tbIVA_impo.TabIndex = 114
        '
        'tbCostoPlacas_Impo
        '
        Me.tbCostoPlacas_Impo.AutoRoundedCorners = True
        Me.tbCostoPlacas_Impo.BackColor = System.Drawing.Color.Transparent
        Me.tbCostoPlacas_Impo.BorderRadius = 14
        Me.tbCostoPlacas_Impo.Cursor = System.Windows.Forms.Cursors.No
        Me.tbCostoPlacas_Impo.DefaultText = ""
        Me.tbCostoPlacas_Impo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbCostoPlacas_Impo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbCostoPlacas_Impo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbCostoPlacas_Impo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbCostoPlacas_Impo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbCostoPlacas_Impo.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tbCostoPlacas_Impo.ForeColor = System.Drawing.Color.Black
        Me.tbCostoPlacas_Impo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbCostoPlacas_Impo.Location = New System.Drawing.Point(322, 91)
        Me.tbCostoPlacas_Impo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbCostoPlacas_Impo.Name = "tbCostoPlacas_Impo"
        Me.tbCostoPlacas_Impo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbCostoPlacas_Impo.PlaceholderText = "Costo de Placas (Q)"
        Me.tbCostoPlacas_Impo.SelectedText = ""
        Me.tbCostoPlacas_Impo.Size = New System.Drawing.Size(278, 30)
        Me.tbCostoPlacas_Impo.TabIndex = 115
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(192, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 116
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 117
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Green
        Me.Label4.Location = New System.Drawing.Point(661, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 21)
        Me.Label4.TabIndex = 118
        '
        'Costodefacturación
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(823, 518)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbCostoPlacas_Impo)
        Me.Controls.Add(Me.tbIVA_impo)
        Me.Controls.Add(Me.tbIPRIMA_impo)
        Me.Controls.Add(Me.tbEncargselec_Impo)
        Me.Controls.Add(Me.tbLoteSelec_Impo)
        Me.Controls.Add(Me.tbCarroSelec_CompraCar)
        Me.Controls.Add(Me.cbCarro_Cdfac)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvCostodefac)
        Me.Controls.Add(Me.Btnmodi_cliente)
        Me.Controls.Add(Me.btnguarda_client)
        Me.Controls.Add(Me.btnnew_client)
        Me.Controls.Add(Me.tbID_cdfac)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Costodefacturación"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Costodefacturación"
        CType(Me.dgvCostodefac, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvCostodefac As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Btnmodi_cliente As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnguarda_client As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnnew_client As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents tbID_cdfac As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cbCarro_Cdfac As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbLoteSelec_Impo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbCarroSelec_CompraCar As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbEncargselec_Impo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbIPRIMA_impo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbIVA_impo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbCostoPlacas_Impo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
End Class
