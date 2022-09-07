<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Reparaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reparaciones))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cbCarro_repar = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.tbCarroSelec_repar = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nudCosto_repar = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bUpdate = New Guna.UI2.WinForms.Guna2Button()
        Me.bSave = New Guna.UI2.WinForms.Guna2Button()
        Me.bNew = New Guna.UI2.WinForms.Guna2Button()
        Me.tbID_repar = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.bMinimizar = New System.Windows.Forms.Button()
        Me.bCerrar = New System.Windows.Forms.Button()
        Me.tbLoteSelec_repar = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbencar_repar = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpEntrega_repar = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.dtpEntrada_repar = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.dgvRepar = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.tbDanos_repar = New Guna.UI2.WinForms.Guna2TextBox()
        CType(Me.nudCosto_repar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvRepar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbCarro_repar
        '
        Me.cbCarro_repar.AutoRoundedCorners = True
        Me.cbCarro_repar.BackColor = System.Drawing.Color.Transparent
        Me.cbCarro_repar.BorderRadius = 17
        Me.cbCarro_repar.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbCarro_repar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCarro_repar.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbCarro_repar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbCarro_repar.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cbCarro_repar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbCarro_repar.ItemHeight = 30
        Me.cbCarro_repar.Location = New System.Drawing.Point(85, 97)
        Me.cbCarro_repar.Name = "cbCarro_repar"
        Me.cbCarro_repar.Size = New System.Drawing.Size(194, 36)
        Me.cbCarro_repar.TabIndex = 58
        '
        'tbCarroSelec_repar
        '
        Me.tbCarroSelec_repar.AutoRoundedCorners = True
        Me.tbCarroSelec_repar.BackColor = System.Drawing.Color.Transparent
        Me.tbCarroSelec_repar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tbCarroSelec_repar.BorderRadius = 14
        Me.tbCarroSelec_repar.Cursor = System.Windows.Forms.Cursors.No
        Me.tbCarroSelec_repar.DefaultText = ""
        Me.tbCarroSelec_repar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbCarroSelec_repar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbCarroSelec_repar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbCarroSelec_repar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbCarroSelec_repar.FillColor = System.Drawing.Color.DodgerBlue
        Me.tbCarroSelec_repar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbCarroSelec_repar.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.tbCarroSelec_repar.ForeColor = System.Drawing.Color.White
        Me.tbCarroSelec_repar.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbCarroSelec_repar.Location = New System.Drawing.Point(310, 60)
        Me.tbCarroSelec_repar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbCarroSelec_repar.Name = "tbCarroSelec_repar"
        Me.tbCarroSelec_repar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbCarroSelec_repar.PlaceholderForeColor = System.Drawing.Color.White
        Me.tbCarroSelec_repar.PlaceholderText = "Carro Seleccionado"
        Me.tbCarroSelec_repar.ReadOnly = True
        Me.tbCarroSelec_repar.SelectedText = ""
        Me.tbCarroSelec_repar.Size = New System.Drawing.Size(277, 30)
        Me.tbCarroSelec_repar.TabIndex = 57
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(306, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 21)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Fecha de Entrada"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(26, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 21)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Costo (Q)"
        '
        'nudCosto_repar
        '
        Me.nudCosto_repar.AutoRoundedCorners = True
        Me.nudCosto_repar.BackColor = System.Drawing.Color.Transparent
        Me.nudCosto_repar.BorderRadius = 14
        Me.nudCosto_repar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.nudCosto_repar.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.nudCosto_repar.ForeColor = System.Drawing.Color.Black
        Me.nudCosto_repar.Increment = New Decimal(New Integer() {50, 0, 0, 0})
        Me.nudCosto_repar.Location = New System.Drawing.Point(118, 178)
        Me.nudCosto_repar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nudCosto_repar.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudCosto_repar.Minimum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.nudCosto_repar.Name = "nudCosto_repar"
        Me.nudCosto_repar.Size = New System.Drawing.Size(163, 30)
        Me.nudCosto_repar.TabIndex = 52
        Me.nudCosto_repar.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.nudCosto_repar.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(26, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 21)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Carro"
        '
        'bUpdate
        '
        Me.bUpdate.AutoRoundedCorners = True
        Me.bUpdate.BorderRadius = 18
        Me.bUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.bUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.bUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.bUpdate.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bUpdate.Font = New System.Drawing.Font("Segoe UI Black", 10.8!, System.Drawing.FontStyle.Bold)
        Me.bUpdate.ForeColor = System.Drawing.Color.White
        Me.bUpdate.Location = New System.Drawing.Point(698, 158)
        Me.bUpdate.Name = "bUpdate"
        Me.bUpdate.Size = New System.Drawing.Size(180, 38)
        Me.bUpdate.TabIndex = 45
        Me.bUpdate.Text = "Modificar"
        '
        'bSave
        '
        Me.bSave.AutoRoundedCorners = True
        Me.bSave.BorderRadius = 18
        Me.bSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.bSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.bSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.bSave.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.bSave.Font = New System.Drawing.Font("Segoe UI Black", 10.8!, System.Drawing.FontStyle.Bold)
        Me.bSave.ForeColor = System.Drawing.Color.White
        Me.bSave.Location = New System.Drawing.Point(698, 114)
        Me.bSave.Name = "bSave"
        Me.bSave.Size = New System.Drawing.Size(180, 38)
        Me.bSave.TabIndex = 44
        Me.bSave.Text = "Guardar"
        '
        'bNew
        '
        Me.bNew.AutoRoundedCorners = True
        Me.bNew.BorderRadius = 18
        Me.bNew.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.bNew.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.bNew.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bNew.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.bNew.Font = New System.Drawing.Font("Segoe UI Black", 10.8!, System.Drawing.FontStyle.Bold)
        Me.bNew.ForeColor = System.Drawing.Color.White
        Me.bNew.Location = New System.Drawing.Point(698, 70)
        Me.bNew.Name = "bNew"
        Me.bNew.Size = New System.Drawing.Size(180, 38)
        Me.bNew.TabIndex = 43
        Me.bNew.Text = "Nuevo"
        '
        'tbID_repar
        '
        Me.tbID_repar.AutoRoundedCorners = True
        Me.tbID_repar.BorderRadius = 14
        Me.tbID_repar.Cursor = System.Windows.Forms.Cursors.No
        Me.tbID_repar.DefaultText = ""
        Me.tbID_repar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbID_repar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbID_repar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbID_repar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbID_repar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbID_repar.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tbID_repar.ForeColor = System.Drawing.Color.Black
        Me.tbID_repar.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbID_repar.Location = New System.Drawing.Point(30, 60)
        Me.tbID_repar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbID_repar.Name = "tbID_repar"
        Me.tbID_repar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbID_repar.PlaceholderText = "ID"
        Me.tbID_repar.ReadOnly = True
        Me.tbID_repar.SelectedText = ""
        Me.tbID_repar.Size = New System.Drawing.Size(49, 30)
        Me.tbID_repar.TabIndex = 42
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SlateBlue
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.bMinimizar)
        Me.Panel1.Controls.Add(Me.bCerrar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(902, 35)
        Me.Panel1.TabIndex = 59
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(792, 0)
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
        Me.Button2.Location = New System.Drawing.Point(850, 0)
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
        'tbLoteSelec_repar
        '
        Me.tbLoteSelec_repar.AutoRoundedCorners = True
        Me.tbLoteSelec_repar.BackColor = System.Drawing.Color.Transparent
        Me.tbLoteSelec_repar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tbLoteSelec_repar.BorderRadius = 14
        Me.tbLoteSelec_repar.Cursor = System.Windows.Forms.Cursors.No
        Me.tbLoteSelec_repar.DefaultText = ""
        Me.tbLoteSelec_repar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbLoteSelec_repar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbLoteSelec_repar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbLoteSelec_repar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbLoteSelec_repar.FillColor = System.Drawing.Color.DodgerBlue
        Me.tbLoteSelec_repar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbLoteSelec_repar.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.tbLoteSelec_repar.ForeColor = System.Drawing.Color.White
        Me.tbLoteSelec_repar.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbLoteSelec_repar.Location = New System.Drawing.Point(30, 140)
        Me.tbLoteSelec_repar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbLoteSelec_repar.Name = "tbLoteSelec_repar"
        Me.tbLoteSelec_repar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbLoteSelec_repar.PlaceholderForeColor = System.Drawing.Color.White
        Me.tbLoteSelec_repar.PlaceholderText = "Lote de Compra"
        Me.tbLoteSelec_repar.ReadOnly = True
        Me.tbLoteSelec_repar.SelectedText = ""
        Me.tbLoteSelec_repar.Size = New System.Drawing.Size(249, 30)
        Me.tbLoteSelec_repar.TabIndex = 64
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(223, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 65
        '
        'tbencar_repar
        '
        Me.tbencar_repar.AutoRoundedCorners = True
        Me.tbencar_repar.BorderRadius = 14
        Me.tbencar_repar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbencar_repar.DefaultText = ""
        Me.tbencar_repar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbencar_repar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbencar_repar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbencar_repar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbencar_repar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbencar_repar.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tbencar_repar.ForeColor = System.Drawing.Color.Black
        Me.tbencar_repar.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbencar_repar.Location = New System.Drawing.Point(31, 216)
        Me.tbencar_repar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbencar_repar.Name = "tbencar_repar"
        Me.tbencar_repar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbencar_repar.PlaceholderText = "Encargado de Reparación"
        Me.tbencar_repar.SelectedText = ""
        Me.tbencar_repar.Size = New System.Drawing.Size(250, 30)
        Me.tbencar_repar.TabIndex = 66
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(306, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 21)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "Fecha de Entrega"
        '
        'dtpEntrega_repar
        '
        Me.dtpEntrega_repar.AutoRoundedCorners = True
        Me.dtpEntrega_repar.BackColor = System.Drawing.Color.Transparent
        Me.dtpEntrega_repar.BorderRadius = 14
        Me.dtpEntrega_repar.Checked = True
        Me.dtpEntrega_repar.FillColor = System.Drawing.Color.MediumSpringGreen
        Me.dtpEntrega_repar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.dtpEntrega_repar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.dtpEntrega_repar.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEntrega_repar.Location = New System.Drawing.Point(455, 139)
        Me.dtpEntrega_repar.MaxDate = New Date(2022, 12, 31, 0, 0, 0, 0)
        Me.dtpEntrega_repar.MinDate = New Date(2019, 1, 1, 0, 0, 0, 0)
        Me.dtpEntrega_repar.Name = "dtpEntrega_repar"
        Me.dtpEntrega_repar.Size = New System.Drawing.Size(132, 30)
        Me.dtpEntrega_repar.TabIndex = 67
        Me.dtpEntrega_repar.Value = New Date(2022, 9, 1, 0, 0, 0, 0)
        '
        'dtpEntrada_repar
        '
        Me.dtpEntrada_repar.AutoRoundedCorners = True
        Me.dtpEntrada_repar.BackColor = System.Drawing.Color.Transparent
        Me.dtpEntrada_repar.BorderRadius = 14
        Me.dtpEntrada_repar.Checked = True
        Me.dtpEntrada_repar.FillColor = System.Drawing.Color.MediumSpringGreen
        Me.dtpEntrada_repar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.dtpEntrada_repar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.dtpEntrada_repar.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEntrada_repar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtpEntrada_repar.Location = New System.Drawing.Point(455, 99)
        Me.dtpEntrada_repar.MaxDate = New Date(2022, 12, 31, 0, 0, 0, 0)
        Me.dtpEntrada_repar.MinDate = New Date(2019, 1, 1, 0, 0, 0, 0)
        Me.dtpEntrada_repar.Name = "dtpEntrada_repar"
        Me.dtpEntrada_repar.Size = New System.Drawing.Size(132, 30)
        Me.dtpEntrada_repar.TabIndex = 70
        Me.dtpEntrada_repar.Value = New Date(2022, 9, 1, 0, 0, 0, 0)
        '
        'dgvRepar
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvRepar.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRepar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvRepar.BackgroundColor = System.Drawing.Color.White
        Me.dgvRepar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvRepar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvRepar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.HotPink
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRepar.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvRepar.ColumnHeadersHeight = 20
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRepar.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvRepar.EnableHeadersVisualStyles = False
        Me.dgvRepar.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvRepar.Location = New System.Drawing.Point(29, 266)
        Me.dgvRepar.Name = "dgvRepar"
        Me.dgvRepar.ReadOnly = True
        Me.dgvRepar.RowHeadersVisible = False
        Me.dgvRepar.RowTemplate.Height = 24
        Me.dgvRepar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRepar.Size = New System.Drawing.Size(849, 277)
        Me.dgvRepar.TabIndex = 71
        Me.dgvRepar.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvRepar.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvRepar.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvRepar.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvRepar.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvRepar.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvRepar.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvRepar.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvRepar.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvRepar.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvRepar.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvRepar.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvRepar.ThemeStyle.HeaderStyle.Height = 20
        Me.dgvRepar.ThemeStyle.ReadOnly = True
        Me.dgvRepar.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvRepar.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvRepar.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvRepar.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvRepar.ThemeStyle.RowsStyle.Height = 24
        Me.dgvRepar.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvRepar.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'tbDanos_repar
        '
        Me.tbDanos_repar.AutoRoundedCorners = True
        Me.tbDanos_repar.BorderRadius = 14
        Me.tbDanos_repar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbDanos_repar.DefaultText = ""
        Me.tbDanos_repar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbDanos_repar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbDanos_repar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbDanos_repar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbDanos_repar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbDanos_repar.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tbDanos_repar.ForeColor = System.Drawing.Color.Black
        Me.tbDanos_repar.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbDanos_repar.Location = New System.Drawing.Point(310, 178)
        Me.tbDanos_repar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbDanos_repar.Name = "tbDanos_repar"
        Me.tbDanos_repar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbDanos_repar.PlaceholderText = "Daños/Mantenimiento"
        Me.tbDanos_repar.SelectedText = ""
        Me.tbDanos_repar.Size = New System.Drawing.Size(277, 30)
        Me.tbDanos_repar.TabIndex = 72
        '
        'Reparaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(902, 564)
        Me.Controls.Add(Me.tbDanos_repar)
        Me.Controls.Add(Me.dgvRepar)
        Me.Controls.Add(Me.dtpEntrada_repar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtpEntrega_repar)
        Me.Controls.Add(Me.tbencar_repar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbLoteSelec_repar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cbCarro_repar)
        Me.Controls.Add(Me.tbCarroSelec_repar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nudCosto_repar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bUpdate)
        Me.Controls.Add(Me.bSave)
        Me.Controls.Add(Me.bNew)
        Me.Controls.Add(Me.tbID_repar)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Reparaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reparaciones"
        CType(Me.nudCosto_repar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvRepar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbCarro_repar As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents tbCarroSelec_repar As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents nudCosto_repar As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents bUpdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents bSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents bNew As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents tbID_repar As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents bMinimizar As Button
    Friend WithEvents bCerrar As Button
    Friend WithEvents tbLoteSelec_repar As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbencar_repar As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpEntrega_repar As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents dtpEntrada_repar As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents dgvRepar As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents tbDanos_repar As Guna.UI2.WinForms.Guna2TextBox
End Class
