<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Importacion_Carro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Importacion_Carro))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cbCarro_Compraimpor = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nudCosto_impor = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbSub_Compraimpor = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Btnmodi_impor = New Guna.UI2.WinForms.Guna2Button()
        Me.btnguarda_impor = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.tbID_CompraCar = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbmetodo_impor = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.bMinimizar = New System.Windows.Forms.Button()
        Me.bCerrar = New System.Windows.Forms.Button()
        Me.dgvCompraC = New Guna.UI2.WinForms.Guna2DataGridView()
        CType(Me.nudCosto_impor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvCompraC, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.cbCarro_Compraimpor.Location = New System.Drawing.Point(95, 118)
        Me.cbCarro_Compraimpor.Margin = New System.Windows.Forms.Padding(4)
        Me.cbCarro_Compraimpor.Name = "cbCarro_Compraimpor"
        Me.cbCarro_Compraimpor.Size = New System.Drawing.Size(330, 36)
        Me.cbCarro_Compraimpor.TabIndex = 58
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(464, 183)
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
        Me.nudCosto_impor.Location = New System.Drawing.Point(590, 174)
        Me.nudCosto_impor.Margin = New System.Windows.Forms.Padding(5)
        Me.nudCosto_impor.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudCosto_impor.Minimum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.nudCosto_impor.Name = "nudCosto_impor"
        Me.nudCosto_impor.Size = New System.Drawing.Size(238, 37)
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
        Me.Label2.Location = New System.Drawing.Point(20, 175)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 28)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Lote de Compra"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(20, 123)
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
        Me.cbSub_Compraimpor.Location = New System.Drawing.Point(197, 175)
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
        Me.Btnmodi_impor.Location = New System.Drawing.Point(908, 184)
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
        Me.btnguarda_impor.Location = New System.Drawing.Point(908, 130)
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
        Me.Guna2Button1.Location = New System.Drawing.Point(908, 76)
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
        Me.tbID_CompraCar.Location = New System.Drawing.Point(25, 72)
        Me.tbID_CompraCar.Margin = New System.Windows.Forms.Padding(5)
        Me.tbID_CompraCar.Name = "tbID_CompraCar"
        Me.tbID_CompraCar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbID_CompraCar.PlaceholderText = "ID"
        Me.tbID_CompraCar.ReadOnly = True
        Me.tbID_CompraCar.SelectedText = ""
        Me.tbID_CompraCar.Size = New System.Drawing.Size(57, 37)
        Me.tbID_CompraCar.TabIndex = 42
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
        Me.tbmetodo_impor.Location = New System.Drawing.Point(26, 231)
        Me.tbmetodo_impor.Margin = New System.Windows.Forms.Padding(5)
        Me.tbmetodo_impor.Name = "tbmetodo_impor"
        Me.tbmetodo_impor.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbmetodo_impor.PlaceholderText = "Encargado de Importación"
        Me.tbmetodo_impor.SelectedText = ""
        Me.tbmetodo_impor.Size = New System.Drawing.Size(400, 37)
        Me.tbmetodo_impor.TabIndex = 54
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
        Me.Guna2TextBox1.Location = New System.Drawing.Point(460, 118)
        Me.Guna2TextBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderText = "Método de Importación"
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.Size = New System.Drawing.Size(368, 37)
        Me.Guna2TextBox1.TabIndex = 59
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGreen
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.bMinimizar)
        Me.Panel1.Controls.Add(Me.bCerrar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1174, 43)
        Me.Panel1.TabIndex = 60
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(1028, 0)
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
        Me.Button2.Location = New System.Drawing.Point(1105, 0)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(69, 43)
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
        Me.bMinimizar.Location = New System.Drawing.Point(1271, 0)
        Me.bMinimizar.Margin = New System.Windows.Forms.Padding(4)
        Me.bMinimizar.Name = "bMinimizar"
        Me.bMinimizar.Size = New System.Drawing.Size(69, 43)
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
        Me.bCerrar.Location = New System.Drawing.Point(1348, 0)
        Me.bCerrar.Margin = New System.Windows.Forms.Padding(4)
        Me.bCerrar.Name = "bCerrar"
        Me.bCerrar.Size = New System.Drawing.Size(69, 43)
        Me.bCerrar.TabIndex = 21
        Me.bCerrar.UseVisualStyleBackColor = True
        '
        'dgvCompraC
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvCompraC.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCompraC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvCompraC.BackgroundColor = System.Drawing.Color.White
        Me.dgvCompraC.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCompraC.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvCompraC.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCompraC.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCompraC.ColumnHeadersHeight = 20
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCompraC.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvCompraC.EnableHeadersVisualStyles = False
        Me.dgvCompraC.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCompraC.Location = New System.Drawing.Point(26, 298)
        Me.dgvCompraC.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvCompraC.Name = "dgvCompraC"
        Me.dgvCompraC.ReadOnly = True
        Me.dgvCompraC.RowHeadersVisible = False
        Me.dgvCompraC.RowTemplate.Height = 24
        Me.dgvCompraC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCompraC.Size = New System.Drawing.Size(1122, 385)
        Me.dgvCompraC.TabIndex = 61
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
        'Importacion_Carro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1174, 696)
        Me.Controls.Add(Me.dgvCompraC)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Guna2TextBox1)
        Me.Controls.Add(Me.cbCarro_Compraimpor)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Importacion_Carro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Importaion"
        CType(Me.nudCosto_impor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvCompraC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbCarro_Compraimpor As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents nudCosto_impor As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbSub_Compraimpor As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Btnmodi_impor As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnguarda_impor As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents tbID_CompraCar As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbmetodo_impor As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents bMinimizar As Button
    Friend WithEvents bCerrar As Button
    Friend WithEvents dgvCompraC As Guna.UI2.WinForms.Guna2DataGridView
End Class
