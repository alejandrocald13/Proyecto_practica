﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Subasta
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
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.tbID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbURL_Sub = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbNombre_Sub = New Guna.UI2.WinForms.Guna2TextBox()
        Me.dgvSubastas = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.dgvSubastas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Button2
        '
        Me.Guna2Button2.AutoRoundedCorners = True
        Me.Guna2Button2.BorderRadius = 18
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI Black", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.Location = New System.Drawing.Point(343, 96)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(118, 38)
        Me.Guna2Button2.TabIndex = 23
        Me.Guna2Button2.Text = "Guardar"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.AutoRoundedCorners = True
        Me.Guna2Button1.BorderRadius = 18
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI Black", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(343, 52)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(118, 38)
        Me.Guna2Button1.TabIndex = 22
        Me.Guna2Button1.Text = "Nuevo"
        '
        'Guna2Button3
        '
        Me.Guna2Button3.AutoRoundedCorners = True
        Me.Guna2Button3.BorderRadius = 18
        Me.Guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button3.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Button3.Font = New System.Drawing.Font("Segoe UI Black", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button3.ForeColor = System.Drawing.Color.White
        Me.Guna2Button3.Location = New System.Drawing.Point(343, 140)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.Size = New System.Drawing.Size(118, 38)
        Me.Guna2Button3.TabIndex = 24
        Me.Guna2Button3.Text = "Modificar"
        '
        'tbID
        '
        Me.tbID.AutoRoundedCorners = True
        Me.tbID.BorderRadius = 14
        Me.tbID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbID.DefaultText = ""
        Me.tbID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbID.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tbID.ForeColor = System.Drawing.Color.Black
        Me.tbID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbID.Location = New System.Drawing.Point(13, 60)
        Me.tbID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbID.Name = "tbID"
        Me.tbID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbID.PlaceholderText = "ID"
        Me.tbID.ReadOnly = True
        Me.tbID.SelectedText = ""
        Me.tbID.Size = New System.Drawing.Size(211, 30)
        Me.tbID.TabIndex = 25
        '
        'tbURL_Sub
        '
        Me.tbURL_Sub.AutoRoundedCorners = True
        Me.tbURL_Sub.BorderRadius = 14
        Me.tbURL_Sub.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbURL_Sub.DefaultText = ""
        Me.tbURL_Sub.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbURL_Sub.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbURL_Sub.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbURL_Sub.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbURL_Sub.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbURL_Sub.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tbURL_Sub.ForeColor = System.Drawing.Color.Black
        Me.tbURL_Sub.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbURL_Sub.Location = New System.Drawing.Point(11, 148)
        Me.tbURL_Sub.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.tbURL_Sub.Name = "tbURL_Sub"
        Me.tbURL_Sub.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbURL_Sub.PlaceholderText = "URL"
        Me.tbURL_Sub.SelectedText = ""
        Me.tbURL_Sub.Size = New System.Drawing.Size(211, 30)
        Me.tbURL_Sub.TabIndex = 27
        '
        'tbNombre_Sub
        '
        Me.tbNombre_Sub.AutoRoundedCorners = True
        Me.tbNombre_Sub.BorderRadius = 14
        Me.tbNombre_Sub.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbNombre_Sub.DefaultText = ""
        Me.tbNombre_Sub.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbNombre_Sub.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbNombre_Sub.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbNombre_Sub.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbNombre_Sub.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbNombre_Sub.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tbNombre_Sub.ForeColor = System.Drawing.Color.Black
        Me.tbNombre_Sub.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbNombre_Sub.Location = New System.Drawing.Point(13, 104)
        Me.tbNombre_Sub.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbNombre_Sub.Name = "tbNombre_Sub"
        Me.tbNombre_Sub.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbNombre_Sub.PlaceholderText = "Nombre"
        Me.tbNombre_Sub.SelectedText = ""
        Me.tbNombre_Sub.Size = New System.Drawing.Size(211, 30)
        Me.tbNombre_Sub.TabIndex = 26
        '
        'dgvSubastas
        '
        Me.dgvSubastas.AllowUserToAddRows = False
        Me.dgvSubastas.AllowUserToDeleteRows = False
        Me.dgvSubastas.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvSubastas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSubastas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSubastas.BackgroundColor = System.Drawing.Color.White
        Me.dgvSubastas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSubastas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvSubastas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSubastas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSubastas.ColumnHeadersHeight = 20
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSubastas.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvSubastas.EnableHeadersVisualStyles = False
        Me.dgvSubastas.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvSubastas.Location = New System.Drawing.Point(11, 194)
        Me.dgvSubastas.Name = "dgvSubastas"
        Me.dgvSubastas.ReadOnly = True
        Me.dgvSubastas.RowHeadersVisible = False
        Me.dgvSubastas.RowTemplate.Height = 24
        Me.dgvSubastas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSubastas.Size = New System.Drawing.Size(470, 217)
        Me.dgvSubastas.TabIndex = 28
        Me.dgvSubastas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvSubastas.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvSubastas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvSubastas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvSubastas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvSubastas.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvSubastas.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvSubastas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvSubastas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvSubastas.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvSubastas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvSubastas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvSubastas.ThemeStyle.HeaderStyle.Height = 20
        Me.dgvSubastas.ThemeStyle.ReadOnly = True
        Me.dgvSubastas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvSubastas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvSubastas.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvSubastas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvSubastas.ThemeStyle.RowsStyle.Height = 24
        Me.dgvSubastas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvSubastas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(191, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(247, 25)
        Me.Label5.TabIndex = 122
        Me.Label5.Text = "REGISTRO DE SUBASTA"
        '
        'Subasta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 391)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dgvSubastas)
        Me.Controls.Add(Me.tbURL_Sub)
        Me.Controls.Add(Me.tbNombre_Sub)
        Me.Controls.Add(Me.tbID)
        Me.Controls.Add(Me.Guna2Button3)
        Me.Controls.Add(Me.Guna2Button2)
        Me.Controls.Add(Me.Guna2Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Subasta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Subasta"
        CType(Me.dgvSubastas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents tbID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbURL_Sub As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbNombre_Sub As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dgvSubastas As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label5 As Label
End Class
