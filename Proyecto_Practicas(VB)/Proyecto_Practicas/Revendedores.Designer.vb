<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Revendedores
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
        Me.dgvRevendedores = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.tbCUI_reven = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbNombre_reven = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbID_reven = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
        Me.tbApellido_revend = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbNum_reven = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.dgvRevendedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvRevendedores
        '
        Me.dgvRevendedores.AllowUserToAddRows = False
        Me.dgvRevendedores.AllowUserToDeleteRows = False
        Me.dgvRevendedores.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvRevendedores.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRevendedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRevendedores.BackgroundColor = System.Drawing.Color.White
        Me.dgvRevendedores.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvRevendedores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvRevendedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(190, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRevendedores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvRevendedores.ColumnHeadersHeight = 20
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(231, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRevendedores.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvRevendedores.EnableHeadersVisualStyles = False
        Me.dgvRevendedores.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvRevendedores.Location = New System.Drawing.Point(13, 201)
        Me.dgvRevendedores.Name = "dgvRevendedores"
        Me.dgvRevendedores.ReadOnly = True
        Me.dgvRevendedores.RowHeadersVisible = False
        Me.dgvRevendedores.RowTemplate.Height = 24
        Me.dgvRevendedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRevendedores.Size = New System.Drawing.Size(612, 237)
        Me.dgvRevendedores.TabIndex = 35
        Me.dgvRevendedores.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvRevendedores.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvRevendedores.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvRevendedores.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvRevendedores.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvRevendedores.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvRevendedores.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvRevendedores.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvRevendedores.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvRevendedores.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvRevendedores.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvRevendedores.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvRevendedores.ThemeStyle.HeaderStyle.Height = 20
        Me.dgvRevendedores.ThemeStyle.ReadOnly = True
        Me.dgvRevendedores.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvRevendedores.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvRevendedores.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvRevendedores.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvRevendedores.ThemeStyle.RowsStyle.Height = 24
        Me.dgvRevendedores.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvRevendedores.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'tbCUI_reven
        '
        Me.tbCUI_reven.AutoRoundedCorners = True
        Me.tbCUI_reven.BorderRadius = 14
        Me.tbCUI_reven.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbCUI_reven.DefaultText = ""
        Me.tbCUI_reven.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbCUI_reven.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbCUI_reven.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbCUI_reven.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbCUI_reven.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbCUI_reven.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tbCUI_reven.ForeColor = System.Drawing.Color.Black
        Me.tbCUI_reven.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbCUI_reven.Location = New System.Drawing.Point(254, 109)
        Me.tbCUI_reven.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.tbCUI_reven.MaxLength = 13
        Me.tbCUI_reven.Name = "tbCUI_reven"
        Me.tbCUI_reven.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbCUI_reven.PlaceholderText = "CUI"
        Me.tbCUI_reven.SelectedText = ""
        Me.tbCUI_reven.Size = New System.Drawing.Size(211, 30)
        Me.tbCUI_reven.TabIndex = 3
        '
        'tbNombre_reven
        '
        Me.tbNombre_reven.AutoRoundedCorners = True
        Me.tbNombre_reven.BorderRadius = 14
        Me.tbNombre_reven.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbNombre_reven.DefaultText = ""
        Me.tbNombre_reven.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbNombre_reven.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbNombre_reven.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbNombre_reven.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbNombre_reven.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbNombre_reven.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tbNombre_reven.ForeColor = System.Drawing.Color.Black
        Me.tbNombre_reven.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbNombre_reven.Location = New System.Drawing.Point(13, 109)
        Me.tbNombre_reven.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbNombre_reven.Name = "tbNombre_reven"
        Me.tbNombre_reven.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbNombre_reven.PlaceholderText = "Nombres"
        Me.tbNombre_reven.SelectedText = ""
        Me.tbNombre_reven.Size = New System.Drawing.Size(211, 30)
        Me.tbNombre_reven.TabIndex = 1
        '
        'tbID_reven
        '
        Me.tbID_reven.AutoRoundedCorners = True
        Me.tbID_reven.BorderRadius = 14
        Me.tbID_reven.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbID_reven.DefaultText = ""
        Me.tbID_reven.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbID_reven.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbID_reven.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbID_reven.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbID_reven.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbID_reven.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tbID_reven.ForeColor = System.Drawing.Color.Black
        Me.tbID_reven.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbID_reven.Location = New System.Drawing.Point(13, 59)
        Me.tbID_reven.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbID_reven.Name = "tbID_reven"
        Me.tbID_reven.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbID_reven.PlaceholderText = "ID"
        Me.tbID_reven.ReadOnly = True
        Me.tbID_reven.SelectedText = ""
        Me.tbID_reven.Size = New System.Drawing.Size(211, 30)
        Me.tbID_reven.TabIndex = 32
        '
        'Guna2Button3
        '
        Me.Guna2Button3.AutoRoundedCorners = True
        Me.Guna2Button3.BorderRadius = 14
        Me.Guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button3.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Button3.Font = New System.Drawing.Font("Segoe UI Black", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button3.ForeColor = System.Drawing.Color.White
        Me.Guna2Button3.Location = New System.Drawing.Point(497, 117)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.Size = New System.Drawing.Size(118, 30)
        Me.Guna2Button3.TabIndex = 31
        Me.Guna2Button3.Text = "Modificar"
        '
        'Guna2Button2
        '
        Me.Guna2Button2.AutoRoundedCorners = True
        Me.Guna2Button2.BorderRadius = 14
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI Black", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.Location = New System.Drawing.Point(497, 81)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(118, 30)
        Me.Guna2Button2.TabIndex = 30
        Me.Guna2Button2.Text = "Guardar"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.AutoRoundedCorners = True
        Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.BorderRadius = 14
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI Black", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(497, 45)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(118, 30)
        Me.Guna2Button1.TabIndex = 29
        Me.Guna2Button1.Text = "Nuevo"
        '
        'Guna2Button4
        '
        Me.Guna2Button4.AutoRoundedCorners = True
        Me.Guna2Button4.BorderRadius = 14
        Me.Guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button4.FillColor = System.Drawing.Color.Red
        Me.Guna2Button4.Font = New System.Drawing.Font("Segoe UI Black", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button4.ForeColor = System.Drawing.Color.White
        Me.Guna2Button4.Location = New System.Drawing.Point(497, 153)
        Me.Guna2Button4.Name = "Guna2Button4"
        Me.Guna2Button4.Size = New System.Drawing.Size(118, 30)
        Me.Guna2Button4.TabIndex = 38
        Me.Guna2Button4.Text = "Eliminar"
        '
        'tbApellido_revend
        '
        Me.tbApellido_revend.AutoRoundedCorners = True
        Me.tbApellido_revend.BorderRadius = 14
        Me.tbApellido_revend.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbApellido_revend.DefaultText = ""
        Me.tbApellido_revend.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbApellido_revend.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbApellido_revend.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbApellido_revend.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbApellido_revend.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbApellido_revend.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tbApellido_revend.ForeColor = System.Drawing.Color.Black
        Me.tbApellido_revend.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbApellido_revend.Location = New System.Drawing.Point(13, 153)
        Me.tbApellido_revend.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbApellido_revend.Name = "tbApellido_revend"
        Me.tbApellido_revend.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbApellido_revend.PlaceholderText = "Apellidos"
        Me.tbApellido_revend.SelectedText = ""
        Me.tbApellido_revend.Size = New System.Drawing.Size(211, 30)
        Me.tbApellido_revend.TabIndex = 2
        '
        'tbNum_reven
        '
        Me.tbNum_reven.AutoRoundedCorners = True
        Me.tbNum_reven.BorderRadius = 14
        Me.tbNum_reven.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbNum_reven.DefaultText = ""
        Me.tbNum_reven.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbNum_reven.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbNum_reven.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbNum_reven.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbNum_reven.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbNum_reven.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tbNum_reven.ForeColor = System.Drawing.Color.Black
        Me.tbNum_reven.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbNum_reven.Location = New System.Drawing.Point(254, 153)
        Me.tbNum_reven.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.tbNum_reven.MaxLength = 8
        Me.tbNum_reven.Name = "tbNum_reven"
        Me.tbNum_reven.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbNum_reven.PlaceholderText = "Número"
        Me.tbNum_reven.SelectedText = ""
        Me.tbNum_reven.Size = New System.Drawing.Size(211, 30)
        Me.tbNum_reven.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(265, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(315, 25)
        Me.Label5.TabIndex = 121
        Me.Label5.Text = "REGISTRO DE REVENDEDORES"
        '
        'Revendedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 435)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbApellido_revend)
        Me.Controls.Add(Me.Guna2Button4)
        Me.Controls.Add(Me.tbNum_reven)
        Me.Controls.Add(Me.dgvRevendedores)
        Me.Controls.Add(Me.tbCUI_reven)
        Me.Controls.Add(Me.tbNombre_reven)
        Me.Controls.Add(Me.tbID_reven)
        Me.Controls.Add(Me.Guna2Button3)
        Me.Controls.Add(Me.Guna2Button2)
        Me.Controls.Add(Me.Guna2Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Revendedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Revendedores"
        CType(Me.dgvRevendedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvRevendedores As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents tbCUI_reven As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbNombre_reven As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbID_reven As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents tbApellido_revend As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbNum_reven As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
End Class
