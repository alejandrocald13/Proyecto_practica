﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cbCarro_Compraimpor = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nudCosto_impor = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btnmodi_impor = New Guna.UI2.WinForms.Guna2Button()
        Me.btnguarda_impor = New Guna.UI2.WinForms.Guna2Button()
        Me.btnnew_impor = New Guna.UI2.WinForms.Guna2Button()
        Me.tbID_CompraCar = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbencar_impor = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbmeto_impor = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.bMinimizar = New System.Windows.Forms.Button()
        Me.bCerrar = New System.Windows.Forms.Button()
        Me.dgvCompraC = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.tbCarroSelec_CompraCar = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbLoteSelec_Impo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2ComboBox1 = New Guna.UI2.WinForms.Guna2ComboBox()
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
        Me.cbCarro_Compraimpor.Location = New System.Drawing.Point(71, 99)
        Me.cbCarro_Compraimpor.Name = "cbCarro_Compraimpor"
        Me.cbCarro_Compraimpor.Size = New System.Drawing.Size(248, 36)
        Me.cbCarro_Compraimpor.TabIndex = 58
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(352, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 21)
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
        Me.nudCosto_impor.Location = New System.Drawing.Point(442, 142)
        Me.nudCosto_impor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nudCosto_impor.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudCosto_impor.Minimum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.nudCosto_impor.Name = "nudCosto_impor"
        Me.nudCosto_impor.Size = New System.Drawing.Size(178, 30)
        Me.nudCosto_impor.TabIndex = 52
        Me.nudCosto_impor.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.nudCosto_impor.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(15, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 21)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Carro"
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
        Me.Btnmodi_impor.Location = New System.Drawing.Point(681, 150)
        Me.Btnmodi_impor.Name = "Btnmodi_impor"
        Me.Btnmodi_impor.Size = New System.Drawing.Size(180, 38)
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
        Me.btnguarda_impor.Location = New System.Drawing.Point(681, 106)
        Me.btnguarda_impor.Name = "btnguarda_impor"
        Me.btnguarda_impor.Size = New System.Drawing.Size(180, 38)
        Me.btnguarda_impor.TabIndex = 44
        Me.btnguarda_impor.Text = "Guardar"
        '
        'btnnew_impor
        '
        Me.btnnew_impor.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnnew_impor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnnew_impor.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnnew_impor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnnew_impor.Font = New System.Drawing.Font("Segoe UI Black", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnnew_impor.ForeColor = System.Drawing.Color.White
        Me.btnnew_impor.Location = New System.Drawing.Point(681, 62)
        Me.btnnew_impor.Name = "btnnew_impor"
        Me.btnnew_impor.Size = New System.Drawing.Size(180, 38)
        Me.btnnew_impor.TabIndex = 43
        Me.btnnew_impor.Text = "Nuevo"
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
        Me.tbID_CompraCar.Location = New System.Drawing.Point(19, 58)
        Me.tbID_CompraCar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbID_CompraCar.Name = "tbID_CompraCar"
        Me.tbID_CompraCar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbID_CompraCar.PlaceholderText = "ID"
        Me.tbID_CompraCar.ReadOnly = True
        Me.tbID_CompraCar.SelectedText = ""
        Me.tbID_CompraCar.Size = New System.Drawing.Size(43, 30)
        Me.tbID_CompraCar.TabIndex = 42
        '
        'tbencar_impor
        '
        Me.tbencar_impor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbencar_impor.DefaultText = ""
        Me.tbencar_impor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbencar_impor.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbencar_impor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbencar_impor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbencar_impor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbencar_impor.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tbencar_impor.ForeColor = System.Drawing.Color.Black
        Me.tbencar_impor.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbencar_impor.Location = New System.Drawing.Point(20, 180)
        Me.tbencar_impor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbencar_impor.Name = "tbencar_impor"
        Me.tbencar_impor.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbencar_impor.PlaceholderText = "Encargado de Importación"
        Me.tbencar_impor.SelectedText = ""
        Me.tbencar_impor.Size = New System.Drawing.Size(300, 30)
        Me.tbencar_impor.TabIndex = 54
        '
        'tbmeto_impor
        '
        Me.tbmeto_impor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbmeto_impor.DefaultText = ""
        Me.tbmeto_impor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbmeto_impor.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbmeto_impor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbmeto_impor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbmeto_impor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbmeto_impor.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tbmeto_impor.ForeColor = System.Drawing.Color.Black
        Me.tbmeto_impor.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbmeto_impor.Location = New System.Drawing.Point(346, 96)
        Me.tbmeto_impor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbmeto_impor.Name = "tbmeto_impor"
        Me.tbmeto_impor.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbmeto_impor.PlaceholderText = "Método de Importación"
        Me.tbmeto_impor.SelectedText = ""
        Me.tbmeto_impor.Size = New System.Drawing.Size(276, 30)
        Me.tbmeto_impor.TabIndex = 59
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.bMinimizar)
        Me.Panel1.Controls.Add(Me.bCerrar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(880, 35)
        Me.Panel1.TabIndex = 60
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(771, 0)
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
        Me.Button2.Location = New System.Drawing.Point(829, 0)
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
        'dgvCompraC
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.dgvCompraC.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvCompraC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvCompraC.BackgroundColor = System.Drawing.Color.White
        Me.dgvCompraC.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCompraC.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvCompraC.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCompraC.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvCompraC.ColumnHeadersHeight = 20
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCompraC.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvCompraC.EnableHeadersVisualStyles = False
        Me.dgvCompraC.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCompraC.Location = New System.Drawing.Point(26, 241)
        Me.dgvCompraC.Name = "dgvCompraC"
        Me.dgvCompraC.ReadOnly = True
        Me.dgvCompraC.RowHeadersVisible = False
        Me.dgvCompraC.RowTemplate.Height = 24
        Me.dgvCompraC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCompraC.Size = New System.Drawing.Size(842, 313)
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
        Me.tbCarroSelec_CompraCar.Location = New System.Drawing.Point(347, 58)
        Me.tbCarroSelec_CompraCar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbCarroSelec_CompraCar.Name = "tbCarroSelec_CompraCar"
        Me.tbCarroSelec_CompraCar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbCarroSelec_CompraCar.PlaceholderForeColor = System.Drawing.Color.White
        Me.tbCarroSelec_CompraCar.PlaceholderText = "Carro Seleccionado"
        Me.tbCarroSelec_CompraCar.ReadOnly = True
        Me.tbCarroSelec_CompraCar.SelectedText = ""
        Me.tbCarroSelec_CompraCar.Size = New System.Drawing.Size(275, 30)
        Me.tbCarroSelec_CompraCar.TabIndex = 62
        '
        'tbLoteSelec_Impo
        '
        Me.tbLoteSelec_Impo.BackColor = System.Drawing.Color.Transparent
        Me.tbLoteSelec_Impo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tbLoteSelec_Impo.Cursor = System.Windows.Forms.Cursors.No
        Me.tbLoteSelec_Impo.DefaultText = ""
        Me.tbLoteSelec_Impo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbLoteSelec_Impo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbLoteSelec_Impo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbLoteSelec_Impo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbLoteSelec_Impo.FillColor = System.Drawing.Color.DodgerBlue
        Me.tbLoteSelec_Impo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbLoteSelec_Impo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.tbLoteSelec_Impo.ForeColor = System.Drawing.Color.White
        Me.tbLoteSelec_Impo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbLoteSelec_Impo.Location = New System.Drawing.Point(19, 142)
        Me.tbLoteSelec_Impo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbLoteSelec_Impo.Name = "tbLoteSelec_Impo"
        Me.tbLoteSelec_Impo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbLoteSelec_Impo.PlaceholderForeColor = System.Drawing.Color.White
        Me.tbLoteSelec_Impo.PlaceholderText = "Lote de Compra"
        Me.tbLoteSelec_Impo.ReadOnly = True
        Me.tbLoteSelec_Impo.SelectedText = ""
        Me.tbLoteSelec_Impo.Size = New System.Drawing.Size(300, 30)
        Me.tbLoteSelec_Impo.TabIndex = 63
        '
        'Guna2ComboBox1
        '
        Me.Guna2ComboBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox1.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Guna2ComboBox1.ItemHeight = 30
        Me.Guna2ComboBox1.Location = New System.Drawing.Point(346, 180)
        Me.Guna2ComboBox1.Name = "Guna2ComboBox1"
        Me.Guna2ComboBox1.Size = New System.Drawing.Size(248, 36)
        Me.Guna2ComboBox1.TabIndex = 64
        '
        'Importacion_Carro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 566)
        Me.Controls.Add(Me.Guna2ComboBox1)
        Me.Controls.Add(Me.tbLoteSelec_Impo)
        Me.Controls.Add(Me.tbCarroSelec_CompraCar)
        Me.Controls.Add(Me.dgvCompraC)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tbmeto_impor)
        Me.Controls.Add(Me.cbCarro_Compraimpor)
        Me.Controls.Add(Me.tbencar_impor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nudCosto_impor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btnmodi_impor)
        Me.Controls.Add(Me.btnguarda_impor)
        Me.Controls.Add(Me.btnnew_impor)
        Me.Controls.Add(Me.tbID_CompraCar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
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
    Friend WithEvents Label1 As Label
    Friend WithEvents Btnmodi_impor As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnguarda_impor As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnnew_impor As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents tbID_CompraCar As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbencar_impor As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbmeto_impor As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents bMinimizar As Button
    Friend WithEvents bCerrar As Button
    Friend WithEvents dgvCompraC As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents tbCarroSelec_CompraCar As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbLoteSelec_Impo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2ComboBox1 As Guna.UI2.WinForms.Guna2ComboBox
End Class
