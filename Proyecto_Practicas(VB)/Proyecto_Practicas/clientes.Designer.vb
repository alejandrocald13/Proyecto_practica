<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class clientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(clientes))
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tbcorreo_client = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbID_client = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.tbDirec_client = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbNomAp_client = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbNum_client = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbNIT_client = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Btnmodi_cliente = New Guna.UI2.WinForms.Guna2Button()
        Me.btnguarda_client = New Guna.UI2.WinForms.Guna2Button()
        Me.btnnew_client = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvClient = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.tbCUI_client = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvClient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbcorreo_client
        '
        Me.tbcorreo_client.AutoRoundedCorners = True
        Me.tbcorreo_client.BorderRadius = 17
        Me.tbcorreo_client.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbcorreo_client.DefaultText = ""
        Me.tbcorreo_client.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbcorreo_client.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbcorreo_client.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbcorreo_client.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbcorreo_client.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbcorreo_client.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tbcorreo_client.ForeColor = System.Drawing.Color.Black
        Me.tbcorreo_client.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbcorreo_client.Location = New System.Drawing.Point(19, 225)
        Me.tbcorreo_client.Margin = New System.Windows.Forms.Padding(5)
        Me.tbcorreo_client.Name = "tbcorreo_client"
        Me.tbcorreo_client.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbcorreo_client.PlaceholderText = "Correo"
        Me.tbcorreo_client.SelectedText = ""
        Me.tbcorreo_client.Size = New System.Drawing.Size(345, 37)
        Me.tbcorreo_client.TabIndex = 3
        '
        'tbID_client
        '
        Me.tbID_client.AutoRoundedCorners = True
        Me.tbID_client.BorderRadius = 17
        Me.tbID_client.Cursor = System.Windows.Forms.Cursors.No
        Me.tbID_client.DefaultText = ""
        Me.tbID_client.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbID_client.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbID_client.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbID_client.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbID_client.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbID_client.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tbID_client.ForeColor = System.Drawing.Color.Black
        Me.tbID_client.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbID_client.Location = New System.Drawing.Point(19, 85)
        Me.tbID_client.Margin = New System.Windows.Forms.Padding(5)
        Me.tbID_client.Name = "tbID_client"
        Me.tbID_client.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbID_client.PlaceholderText = "ID"
        Me.tbID_client.ReadOnly = True
        Me.tbID_client.SelectedText = ""
        Me.tbID_client.Size = New System.Drawing.Size(57, 37)
        Me.tbID_client.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1079, 43)
        Me.Panel1.TabIndex = 75
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(932, 0)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(69, 43)
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
        Me.Button2.Location = New System.Drawing.Point(1009, 0)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(69, 43)
        Me.Button2.TabIndex = 23
        Me.Button2.UseVisualStyleBackColor = True
        '
        'tbDirec_client
        '
        Me.tbDirec_client.AutoRoundedCorners = True
        Me.tbDirec_client.BorderRadius = 17
        Me.tbDirec_client.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbDirec_client.DefaultText = ""
        Me.tbDirec_client.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbDirec_client.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbDirec_client.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbDirec_client.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbDirec_client.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbDirec_client.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tbDirec_client.ForeColor = System.Drawing.Color.Black
        Me.tbDirec_client.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbDirec_client.Location = New System.Drawing.Point(409, 225)
        Me.tbDirec_client.Margin = New System.Windows.Forms.Padding(5)
        Me.tbDirec_client.Name = "tbDirec_client"
        Me.tbDirec_client.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbDirec_client.PlaceholderText = "Dirección"
        Me.tbDirec_client.SelectedText = ""
        Me.tbDirec_client.Size = New System.Drawing.Size(347, 37)
        Me.tbDirec_client.TabIndex = 6
        '
        'tbNomAp_client
        '
        Me.tbNomAp_client.AutoRoundedCorners = True
        Me.tbNomAp_client.BorderRadius = 17
        Me.tbNomAp_client.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbNomAp_client.DefaultText = ""
        Me.tbNomAp_client.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbNomAp_client.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbNomAp_client.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbNomAp_client.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbNomAp_client.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbNomAp_client.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tbNomAp_client.ForeColor = System.Drawing.Color.Black
        Me.tbNomAp_client.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbNomAp_client.Location = New System.Drawing.Point(19, 132)
        Me.tbNomAp_client.Margin = New System.Windows.Forms.Padding(5)
        Me.tbNomAp_client.Name = "tbNomAp_client"
        Me.tbNomAp_client.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbNomAp_client.PlaceholderText = "Nombre y Apellido"
        Me.tbNomAp_client.SelectedText = ""
        Me.tbNomAp_client.Size = New System.Drawing.Size(345, 37)
        Me.tbNomAp_client.TabIndex = 1
        '
        'tbNum_client
        '
        Me.tbNum_client.AutoRoundedCorners = True
        Me.tbNum_client.BorderRadius = 17
        Me.tbNum_client.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbNum_client.DefaultText = ""
        Me.tbNum_client.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbNum_client.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbNum_client.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbNum_client.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbNum_client.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbNum_client.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tbNum_client.ForeColor = System.Drawing.Color.Black
        Me.tbNum_client.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbNum_client.Location = New System.Drawing.Point(411, 132)
        Me.tbNum_client.Margin = New System.Windows.Forms.Padding(5)
        Me.tbNum_client.Name = "tbNum_client"
        Me.tbNum_client.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbNum_client.PlaceholderText = "Número"
        Me.tbNum_client.SelectedText = ""
        Me.tbNum_client.Size = New System.Drawing.Size(345, 37)
        Me.tbNum_client.TabIndex = 4
        '
        'tbNIT_client
        '
        Me.tbNIT_client.AutoRoundedCorners = True
        Me.tbNIT_client.BorderRadius = 17
        Me.tbNIT_client.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbNIT_client.DefaultText = ""
        Me.tbNIT_client.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbNIT_client.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbNIT_client.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbNIT_client.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbNIT_client.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbNIT_client.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tbNIT_client.ForeColor = System.Drawing.Color.Black
        Me.tbNIT_client.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbNIT_client.Location = New System.Drawing.Point(409, 178)
        Me.tbNIT_client.Margin = New System.Windows.Forms.Padding(5)
        Me.tbNIT_client.MaxLength = 10
        Me.tbNIT_client.Name = "tbNIT_client"
        Me.tbNIT_client.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbNIT_client.PlaceholderText = "NIT"
        Me.tbNIT_client.SelectedText = ""
        Me.tbNIT_client.Size = New System.Drawing.Size(345, 37)
        Me.tbNIT_client.TabIndex = 5
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
        Me.Btnmodi_cliente.Location = New System.Drawing.Point(812, 193)
        Me.Btnmodi_cliente.Margin = New System.Windows.Forms.Padding(4)
        Me.Btnmodi_cliente.Name = "Btnmodi_cliente"
        Me.Btnmodi_cliente.Size = New System.Drawing.Size(240, 47)
        Me.Btnmodi_cliente.TabIndex = 82
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
        Me.btnguarda_client.Location = New System.Drawing.Point(812, 139)
        Me.btnguarda_client.Margin = New System.Windows.Forms.Padding(4)
        Me.btnguarda_client.Name = "btnguarda_client"
        Me.btnguarda_client.Size = New System.Drawing.Size(240, 47)
        Me.btnguarda_client.TabIndex = 81
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
        Me.btnnew_client.Location = New System.Drawing.Point(812, 85)
        Me.btnnew_client.Margin = New System.Windows.Forms.Padding(4)
        Me.btnnew_client.Name = "btnnew_client"
        Me.btnnew_client.Size = New System.Drawing.Size(240, 47)
        Me.btnnew_client.TabIndex = 80
        Me.btnnew_client.Text = "Nuevo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 267)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 28)
        Me.Label1.TabIndex = 83
        '
        'dgvClient
        '
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        Me.dgvClient.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvClient.BackgroundColor = System.Drawing.Color.White
        Me.dgvClient.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvClient.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvClient.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.HotPink
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvClient.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvClient.ColumnHeadersHeight = 20
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvClient.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgvClient.EnableHeadersVisualStyles = False
        Me.dgvClient.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvClient.Location = New System.Drawing.Point(19, 299)
        Me.dgvClient.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvClient.Name = "dgvClient"
        Me.dgvClient.ReadOnly = True
        Me.dgvClient.RowHeadersVisible = False
        Me.dgvClient.RowTemplate.Height = 24
        Me.dgvClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvClient.Size = New System.Drawing.Size(1036, 369)
        Me.dgvClient.TabIndex = 84
        Me.dgvClient.TabStop = False
        Me.dgvClient.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvClient.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvClient.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvClient.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvClient.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvClient.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvClient.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvClient.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvClient.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvClient.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvClient.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvClient.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvClient.ThemeStyle.HeaderStyle.Height = 20
        Me.dgvClient.ThemeStyle.ReadOnly = True
        Me.dgvClient.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvClient.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvClient.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvClient.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvClient.ThemeStyle.RowsStyle.Height = 24
        Me.dgvClient.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvClient.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'tbCUI_client
        '
        Me.tbCUI_client.AutoRoundedCorners = True
        Me.tbCUI_client.BorderRadius = 17
        Me.tbCUI_client.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbCUI_client.DefaultText = ""
        Me.tbCUI_client.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbCUI_client.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbCUI_client.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbCUI_client.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbCUI_client.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbCUI_client.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tbCUI_client.ForeColor = System.Drawing.Color.Black
        Me.tbCUI_client.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbCUI_client.Location = New System.Drawing.Point(19, 178)
        Me.tbCUI_client.Margin = New System.Windows.Forms.Padding(5)
        Me.tbCUI_client.MaxLength = 13
        Me.tbCUI_client.Name = "tbCUI_client"
        Me.tbCUI_client.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbCUI_client.PlaceholderText = "CUI"
        Me.tbCUI_client.SelectedText = ""
        Me.tbCUI_client.Size = New System.Drawing.Size(345, 37)
        Me.tbCUI_client.TabIndex = 2
        '
        'clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1079, 689)
        Me.Controls.Add(Me.tbCUI_client)
        Me.Controls.Add(Me.dgvClient)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btnmodi_cliente)
        Me.Controls.Add(Me.btnguarda_client)
        Me.Controls.Add(Me.btnnew_client)
        Me.Controls.Add(Me.tbNum_client)
        Me.Controls.Add(Me.tbNIT_client)
        Me.Controls.Add(Me.tbNomAp_client)
        Me.Controls.Add(Me.tbDirec_client)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tbcorreo_client)
        Me.Controls.Add(Me.tbID_client)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "clientes"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvClient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbcorreo_client As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbID_client As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents tbDirec_client As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbNomAp_client As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbNum_client As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbNIT_client As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Btnmodi_cliente As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnguarda_client As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnnew_client As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvClient As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents tbCUI_client As Guna.UI2.WinForms.Guna2TextBox
End Class
