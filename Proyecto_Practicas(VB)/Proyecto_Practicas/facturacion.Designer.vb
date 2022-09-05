<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class facturacion
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
        Me.cbCarro_CompraCar = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.tbUbi_CompraCar = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbDanoPrin_CompraCar = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbLote_CompraCar = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbSub_CompraCar = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btnmodificar_factura = New Guna.UI2.WinForms.Guna2Button()
        Me.btnguardar_factura = New Guna.UI2.WinForms.Guna2Button()
        Me.btnnuevo_factura = New Guna.UI2.WinForms.Guna2Button()
        Me.tbID_CompraCar = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Guna2ComboBox1 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.SuspendLayout()
        '
        'cbCarro_CompraCar
        '
        Me.cbCarro_CompraCar.BackColor = System.Drawing.Color.Transparent
        Me.cbCarro_CompraCar.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbCarro_CompraCar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCarro_CompraCar.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbCarro_CompraCar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbCarro_CompraCar.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCarro_CompraCar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbCarro_CompraCar.ItemHeight = 30
        Me.cbCarro_CompraCar.Location = New System.Drawing.Point(141, 59)
        Me.cbCarro_CompraCar.Margin = New System.Windows.Forms.Padding(4)
        Me.cbCarro_CompraCar.Name = "cbCarro_CompraCar"
        Me.cbCarro_CompraCar.Size = New System.Drawing.Size(257, 36)
        Me.cbCarro_CompraCar.TabIndex = 57
        '
        'tbUbi_CompraCar
        '
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
        Me.tbUbi_CompraCar.Location = New System.Drawing.Point(419, 67)
        Me.tbUbi_CompraCar.Margin = New System.Windows.Forms.Padding(5)
        Me.tbUbi_CompraCar.Name = "tbUbi_CompraCar"
        Me.tbUbi_CompraCar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbUbi_CompraCar.PlaceholderText = "Proceso legal"
        Me.tbUbi_CompraCar.SelectedText = ""
        Me.tbUbi_CompraCar.Size = New System.Drawing.Size(369, 37)
        Me.tbUbi_CompraCar.TabIndex = 54
        '
        'tbDanoPrin_CompraCar
        '
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
        Me.tbDanoPrin_CompraCar.Location = New System.Drawing.Point(170, 199)
        Me.tbDanoPrin_CompraCar.Margin = New System.Windows.Forms.Padding(5)
        Me.tbDanoPrin_CompraCar.Name = "tbDanoPrin_CompraCar"
        Me.tbDanoPrin_CompraCar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbDanoPrin_CompraCar.PlaceholderText = "Facturacion"
        Me.tbDanoPrin_CompraCar.SelectedText = ""
        Me.tbDanoPrin_CompraCar.Size = New System.Drawing.Size(332, 37)
        Me.tbDanoPrin_CompraCar.TabIndex = 50
        '
        'tbLote_CompraCar
        '
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
        Me.tbLote_CompraCar.Location = New System.Drawing.Point(419, 120)
        Me.tbLote_CompraCar.Margin = New System.Windows.Forms.Padding(5)
        Me.tbLote_CompraCar.Name = "tbLote_CompraCar"
        Me.tbLote_CompraCar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbLote_CompraCar.PlaceholderText = "Placas"
        Me.tbLote_CompraCar.SelectedText = ""
        Me.tbLote_CompraCar.Size = New System.Drawing.Size(369, 37)
        Me.tbLote_CompraCar.TabIndex = 49
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(8, 120)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 28)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Compra"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(8, 67)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 28)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Carro"
        '
        'cbSub_CompraCar
        '
        Me.cbSub_CompraCar.BackColor = System.Drawing.Color.Transparent
        Me.cbSub_CompraCar.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbSub_CompraCar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSub_CompraCar.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbSub_CompraCar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbSub_CompraCar.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSub_CompraCar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbSub_CompraCar.ItemHeight = 30
        Me.cbSub_CompraCar.Location = New System.Drawing.Point(170, 102)
        Me.cbSub_CompraCar.Margin = New System.Windows.Forms.Padding(4)
        Me.cbSub_CompraCar.Name = "cbSub_CompraCar"
        Me.cbSub_CompraCar.Size = New System.Drawing.Size(228, 36)
        Me.cbSub_CompraCar.TabIndex = 46
        '
        'btnmodificar_factura
        '
        Me.btnmodificar_factura.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnmodificar_factura.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnmodificar_factura.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnmodificar_factura.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnmodificar_factura.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnmodificar_factura.Font = New System.Drawing.Font("Segoe UI Black", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnmodificar_factura.ForeColor = System.Drawing.Color.White
        Me.btnmodificar_factura.Location = New System.Drawing.Point(860, 138)
        Me.btnmodificar_factura.Margin = New System.Windows.Forms.Padding(4)
        Me.btnmodificar_factura.Name = "btnmodificar_factura"
        Me.btnmodificar_factura.Size = New System.Drawing.Size(240, 47)
        Me.btnmodificar_factura.TabIndex = 45
        Me.btnmodificar_factura.Text = "Modificar"
        '
        'btnguardar_factura
        '
        Me.btnguardar_factura.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnguardar_factura.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnguardar_factura.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnguardar_factura.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnguardar_factura.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.btnguardar_factura.Font = New System.Drawing.Font("Segoe UI Black", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnguardar_factura.ForeColor = System.Drawing.Color.White
        Me.btnguardar_factura.Location = New System.Drawing.Point(860, 84)
        Me.btnguardar_factura.Margin = New System.Windows.Forms.Padding(4)
        Me.btnguardar_factura.Name = "btnguardar_factura"
        Me.btnguardar_factura.Size = New System.Drawing.Size(240, 47)
        Me.btnguardar_factura.TabIndex = 44
        Me.btnguardar_factura.Text = "Guardar"
        '
        'btnnuevo_factura
        '
        Me.btnnuevo_factura.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnnuevo_factura.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnnuevo_factura.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnnuevo_factura.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnnuevo_factura.Font = New System.Drawing.Font("Segoe UI Black", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnnuevo_factura.ForeColor = System.Drawing.Color.White
        Me.btnnuevo_factura.Location = New System.Drawing.Point(860, 30)
        Me.btnnuevo_factura.Margin = New System.Windows.Forms.Padding(4)
        Me.btnnuevo_factura.Name = "btnnuevo_factura"
        Me.btnnuevo_factura.Size = New System.Drawing.Size(240, 47)
        Me.btnnuevo_factura.TabIndex = 43
        Me.btnnuevo_factura.Text = "Nuevo"
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
        Me.tbID_CompraCar.Location = New System.Drawing.Point(13, 13)
        Me.tbID_CompraCar.Margin = New System.Windows.Forms.Padding(5)
        Me.tbID_CompraCar.Name = "tbID_CompraCar"
        Me.tbID_CompraCar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbID_CompraCar.PlaceholderText = "ID"
        Me.tbID_CompraCar.ReadOnly = True
        Me.tbID_CompraCar.SelectedText = ""
        Me.tbID_CompraCar.Size = New System.Drawing.Size(65, 37)
        Me.tbID_CompraCar.TabIndex = 42
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(8, 164)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 28)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Importacion "
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
        Me.Guna2ComboBox1.Location = New System.Drawing.Point(170, 154)
        Me.Guna2ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2ComboBox1.Name = "Guna2ComboBox1"
        Me.Guna2ComboBox1.Size = New System.Drawing.Size(228, 36)
        Me.Guna2ComboBox1.TabIndex = 58
        '
        'facturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1107, 511)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Guna2ComboBox1)
        Me.Controls.Add(Me.cbCarro_CompraCar)
        Me.Controls.Add(Me.tbUbi_CompraCar)
        Me.Controls.Add(Me.tbDanoPrin_CompraCar)
        Me.Controls.Add(Me.tbLote_CompraCar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbSub_CompraCar)
        Me.Controls.Add(Me.btnmodificar_factura)
        Me.Controls.Add(Me.btnguardar_factura)
        Me.Controls.Add(Me.btnnuevo_factura)
        Me.Controls.Add(Me.tbID_CompraCar)
        Me.Name = "facturacion"
        Me.Text = "facturacion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbCarro_CompraCar As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents tbUbi_CompraCar As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbDanoPrin_CompraCar As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbLote_CompraCar As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbSub_CompraCar As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnmodificar_factura As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnguardar_factura As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnnuevo_factura As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents tbID_CompraCar As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Guna2ComboBox1 As Guna.UI2.WinForms.Guna2ComboBox
End Class
