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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cbimpor_inven = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.dgvCompraC = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.tbUbi_CompraCar = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbDanoPrin_CompraCar = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbLote_CompraCar = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Carro = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbcarro_inventario = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btnmodi_inven = New Guna.UI2.WinForms.Guna2Button()
        Me.btnguardar_inven = New Guna.UI2.WinForms.Guna2Button()
        Me.btnnuevo_inven = New Guna.UI2.WinForms.Guna2Button()
        Me.tbID_inve = New Guna.UI2.WinForms.Guna2TextBox()
        CType(Me.dgvCompraC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbimpor_inven
        '
        Me.cbimpor_inven.AutoRoundedCorners = True
        Me.cbimpor_inven.BackColor = System.Drawing.Color.Transparent
        Me.cbimpor_inven.BorderRadius = 17
        Me.cbimpor_inven.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbimpor_inven.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbimpor_inven.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbimpor_inven.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbimpor_inven.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cbimpor_inven.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbimpor_inven.ItemHeight = 30
        Me.cbimpor_inven.Location = New System.Drawing.Point(147, 50)
        Me.cbimpor_inven.Margin = New System.Windows.Forms.Padding(4)
        Me.cbimpor_inven.Name = "cbimpor_inven"
        Me.cbimpor_inven.Size = New System.Drawing.Size(257, 36)
        Me.cbimpor_inven.TabIndex = 58
        '
        'dgvCompraC
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        Me.dgvCompraC.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvCompraC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvCompraC.BackgroundColor = System.Drawing.Color.White
        Me.dgvCompraC.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCompraC.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvCompraC.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCompraC.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvCompraC.ColumnHeadersHeight = 20
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCompraC.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvCompraC.EnableHeadersVisualStyles = False
        Me.dgvCompraC.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCompraC.Location = New System.Drawing.Point(73, 190)
        Me.dgvCompraC.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvCompraC.Name = "dgvCompraC"
        Me.dgvCompraC.ReadOnly = True
        Me.dgvCompraC.RowHeadersVisible = False
        Me.dgvCompraC.RowTemplate.Height = 24
        Me.dgvCompraC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCompraC.Size = New System.Drawing.Size(1087, 385)
        Me.dgvCompraC.TabIndex = 55
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
        'tbUbi_CompraCar
        '
        Me.tbUbi_CompraCar.AutoRoundedCorners = True
        Me.tbUbi_CompraCar.BorderRadius = 17
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
        Me.tbUbi_CompraCar.Location = New System.Drawing.Point(413, 50)
        Me.tbUbi_CompraCar.Margin = New System.Windows.Forms.Padding(5)
        Me.tbUbi_CompraCar.Name = "tbUbi_CompraCar"
        Me.tbUbi_CompraCar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbUbi_CompraCar.PlaceholderText = "Solicitud"
        Me.tbUbi_CompraCar.SelectedText = ""
        Me.tbUbi_CompraCar.Size = New System.Drawing.Size(369, 37)
        Me.tbUbi_CompraCar.TabIndex = 54
        '
        'tbDanoPrin_CompraCar
        '
        Me.tbDanoPrin_CompraCar.AutoRoundedCorners = True
        Me.tbDanoPrin_CompraCar.BorderRadius = 17
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
        Me.tbDanoPrin_CompraCar.Location = New System.Drawing.Point(413, 144)
        Me.tbDanoPrin_CompraCar.Margin = New System.Windows.Forms.Padding(5)
        Me.tbDanoPrin_CompraCar.Name = "tbDanoPrin_CompraCar"
        Me.tbDanoPrin_CompraCar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbDanoPrin_CompraCar.PlaceholderText = "Estado "
        Me.tbDanoPrin_CompraCar.SelectedText = ""
        Me.tbDanoPrin_CompraCar.Size = New System.Drawing.Size(369, 37)
        Me.tbDanoPrin_CompraCar.TabIndex = 50
        '
        'tbLote_CompraCar
        '
        Me.tbLote_CompraCar.AutoRoundedCorners = True
        Me.tbLote_CompraCar.BorderRadius = 17
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
        Me.tbLote_CompraCar.Location = New System.Drawing.Point(413, 97)
        Me.tbLote_CompraCar.Margin = New System.Windows.Forms.Padding(5)
        Me.tbLote_CompraCar.Name = "tbLote_CompraCar"
        Me.tbLote_CompraCar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbLote_CompraCar.PlaceholderText = "Total "
        Me.tbLote_CompraCar.SelectedText = ""
        Me.tbLote_CompraCar.Size = New System.Drawing.Size(369, 37)
        Me.tbLote_CompraCar.TabIndex = 49
        '
        'Carro
        '
        Me.Carro.AutoSize = True
        Me.Carro.BackColor = System.Drawing.Color.Transparent
        Me.Carro.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Carro.ForeColor = System.Drawing.Color.Black
        Me.Carro.Location = New System.Drawing.Point(68, 112)
        Me.Carro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Carro.Name = "Carro"
        Me.Carro.Size = New System.Drawing.Size(89, 28)
        Me.Carro.TabIndex = 48
        Me.Carro.Text = "Subasta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(24, 58)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 28)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Inventario"
        '
        'cbcarro_inventario
        '
        Me.cbcarro_inventario.AutoRoundedCorners = True
        Me.cbcarro_inventario.BackColor = System.Drawing.Color.Transparent
        Me.cbcarro_inventario.BorderRadius = 17
        Me.cbcarro_inventario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbcarro_inventario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbcarro_inventario.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbcarro_inventario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbcarro_inventario.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cbcarro_inventario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbcarro_inventario.ItemHeight = 30
        Me.cbcarro_inventario.Location = New System.Drawing.Point(176, 102)
        Me.cbcarro_inventario.Margin = New System.Windows.Forms.Padding(4)
        Me.cbcarro_inventario.Name = "cbcarro_inventario"
        Me.cbcarro_inventario.Size = New System.Drawing.Size(228, 36)
        Me.cbcarro_inventario.TabIndex = 46
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
        Me.btnmodi_inven.Location = New System.Drawing.Point(920, 130)
        Me.btnmodi_inven.Margin = New System.Windows.Forms.Padding(4)
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
        Me.btnguardar_inven.Location = New System.Drawing.Point(920, 76)
        Me.btnguardar_inven.Margin = New System.Windows.Forms.Padding(4)
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
        Me.btnnuevo_inven.Location = New System.Drawing.Point(920, 22)
        Me.btnnuevo_inven.Margin = New System.Windows.Forms.Padding(4)
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
        Me.tbID_inve.Location = New System.Drawing.Point(73, 5)
        Me.tbID_inve.Margin = New System.Windows.Forms.Padding(5)
        Me.tbID_inve.Name = "tbID_inve"
        Me.tbID_inve.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbID_inve.PlaceholderText = "ID"
        Me.tbID_inve.ReadOnly = True
        Me.tbID_inve.SelectedText = ""
        Me.tbID_inve.Size = New System.Drawing.Size(65, 37)
        Me.tbID_inve.TabIndex = 42
        '
        'Inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1230, 690)
        Me.Controls.Add(Me.cbimpor_inven)
        Me.Controls.Add(Me.dgvCompraC)
        Me.Controls.Add(Me.tbUbi_CompraCar)
        Me.Controls.Add(Me.tbDanoPrin_CompraCar)
        Me.Controls.Add(Me.tbLote_CompraCar)
        Me.Controls.Add(Me.Carro)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbcarro_inventario)
        Me.Controls.Add(Me.btnmodi_inven)
        Me.Controls.Add(Me.btnguardar_inven)
        Me.Controls.Add(Me.btnnuevo_inven)
        Me.Controls.Add(Me.tbID_inve)
        Me.Name = "Inventario"
        Me.Text = "Inventario"
        CType(Me.dgvCompraC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbimpor_inven As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents dgvCompraC As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents tbUbi_CompraCar As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbDanoPrin_CompraCar As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbLote_CompraCar As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Carro As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbcarro_inventario As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnmodi_inven As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnguardar_inven As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnnuevo_inven As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents tbID_inve As Guna.UI2.WinForms.Guna2TextBox
End Class
