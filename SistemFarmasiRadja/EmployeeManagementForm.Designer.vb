<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeManagementForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.DataGridViewEmployee = New System.Windows.Forms.DataGridView()
        Me.LblNamaPekerja = New System.Windows.Forms.Label()
        Me.LblAlamat = New System.Windows.Forms.Label()
        Me.LblKadPengenalan = New System.Windows.Forms.Label()
        Me.LblPoskod = New System.Windows.Forms.Label()
        Me.LblUsername = New System.Windows.Forms.Label()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.LblUmur = New System.Windows.Forms.Label()
        Me.TxtNamaPekerja = New System.Windows.Forms.TextBox()
        Me.TxtAlamat = New System.Windows.Forms.TextBox()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.BtnAgree = New System.Windows.Forms.Button()
        Me.LblStyle1 = New System.Windows.Forms.Label()
        Me.LblStyle2 = New System.Windows.Forms.Label()
        Me.LblStyle3 = New System.Windows.Forms.Label()
        Me.LblStyle4 = New System.Windows.Forms.Label()
        Me.LblStyle5 = New System.Windows.Forms.Label()
        Me.LblStyle7 = New System.Windows.Forms.Label()
        Me.LblStyle8 = New System.Windows.Forms.Label()
        Me.TxtKadPengenalan = New System.Windows.Forms.MaskedTextBox()
        Me.LblStyle9 = New System.Windows.Forms.Label()
        Me.TxtNoTelefon = New System.Windows.Forms.MaskedTextBox()
        Me.LblStyle10 = New System.Windows.Forms.Label()
        Me.LblStyle11 = New System.Windows.Forms.Label()
        Me.LblStyle12 = New System.Windows.Forms.Label()
        Me.LblStyle14 = New System.Windows.Forms.Label()
        Me.LblStyle13 = New System.Windows.Forms.Label()
        Me.LblStyle15 = New System.Windows.Forms.Label()
        Me.LblStyle16 = New System.Windows.Forms.Label()
        Me.LblEditMode = New System.Windows.Forms.Label()
        Me.BtnExitEditMode = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.LblEditMode2 = New System.Windows.Forms.Label()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.TxtUmur = New System.Windows.Forms.TextBox()
        CType(Me.DataGridViewEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.LblTitle.Location = New System.Drawing.Point(30, 55)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(416, 36)
        Me.LblTitle.TabIndex = 1
        Me.LblTitle.Text = "EMPLOYEE MANAGEMENT LIST"
        '
        'DataGridViewEmployee
        '
        Me.DataGridViewEmployee.AllowUserToAddRows = False
        Me.DataGridViewEmployee.AllowUserToDeleteRows = False
        Me.DataGridViewEmployee.AllowUserToResizeRows = False
        Me.DataGridViewEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridViewEmployee.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewEmployee.BackgroundColor = System.Drawing.Color.LightSeaGreen
        Me.DataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewEmployee.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewEmployee.Location = New System.Drawing.Point(36, 104)
        Me.DataGridViewEmployee.Name = "DataGridViewEmployee"
        Me.DataGridViewEmployee.RowHeadersWidth = 51
        Me.DataGridViewEmployee.RowTemplate.Height = 24
        Me.DataGridViewEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewEmployee.Size = New System.Drawing.Size(698, 569)
        Me.DataGridViewEmployee.TabIndex = 0
        '
        'LblNamaPekerja
        '
        Me.LblNamaPekerja.AutoSize = True
        Me.LblNamaPekerja.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNamaPekerja.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.LblNamaPekerja.Location = New System.Drawing.Point(785, 197)
        Me.LblNamaPekerja.Name = "LblNamaPekerja"
        Me.LblNamaPekerja.Size = New System.Drawing.Size(148, 24)
        Me.LblNamaPekerja.TabIndex = 3
        Me.LblNamaPekerja.Text = "NAMA PEKERJA"
        '
        'LblAlamat
        '
        Me.LblAlamat.AutoSize = True
        Me.LblAlamat.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAlamat.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.LblAlamat.Location = New System.Drawing.Point(783, 288)
        Me.LblAlamat.Name = "LblAlamat"
        Me.LblAlamat.Size = New System.Drawing.Size(86, 24)
        Me.LblAlamat.TabIndex = 4
        Me.LblAlamat.Text = "ALAMAT"
        '
        'LblKadPengenalan
        '
        Me.LblKadPengenalan.AutoSize = True
        Me.LblKadPengenalan.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblKadPengenalan.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.LblKadPengenalan.Location = New System.Drawing.Point(785, 104)
        Me.LblKadPengenalan.Name = "LblKadPengenalan"
        Me.LblKadPengenalan.Size = New System.Drawing.Size(180, 24)
        Me.LblKadPengenalan.TabIndex = 5
        Me.LblKadPengenalan.Text = "KAD PENGENALAN"
        '
        'LblPoskod
        '
        Me.LblPoskod.AutoSize = True
        Me.LblPoskod.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPoskod.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.LblPoskod.Location = New System.Drawing.Point(784, 413)
        Me.LblPoskod.Name = "LblPoskod"
        Me.LblPoskod.Size = New System.Drawing.Size(132, 24)
        Me.LblPoskod.TabIndex = 6
        Me.LblPoskod.Text = "NO. TELEFON"
        '
        'LblUsername
        '
        Me.LblUsername.AutoSize = True
        Me.LblUsername.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsername.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.LblUsername.Location = New System.Drawing.Point(788, 512)
        Me.LblUsername.Name = "LblUsername"
        Me.LblUsername.Size = New System.Drawing.Size(109, 24)
        Me.LblUsername.TabIndex = 8
        Me.LblUsername.Text = "USERNAME"
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPassword.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.LblPassword.Location = New System.Drawing.Point(980, 512)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(111, 24)
        Me.LblPassword.TabIndex = 9
        Me.LblPassword.Text = "PASSWORD"
        '
        'LblUmur
        '
        Me.LblUmur.AutoSize = True
        Me.LblUmur.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUmur.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.LblUmur.Location = New System.Drawing.Point(1065, 104)
        Me.LblUmur.Name = "LblUmur"
        Me.LblUmur.Size = New System.Drawing.Size(64, 24)
        Me.LblUmur.TabIndex = 11
        Me.LblUmur.Text = "UMUR"
        '
        'TxtNamaPekerja
        '
        Me.TxtNamaPekerja.BackColor = System.Drawing.Color.DarkSlateGray
        Me.TxtNamaPekerja.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNamaPekerja.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!)
        Me.TxtNamaPekerja.ForeColor = System.Drawing.SystemColors.Control
        Me.TxtNamaPekerja.Location = New System.Drawing.Point(789, 238)
        Me.TxtNamaPekerja.MaxLength = 36
        Me.TxtNamaPekerja.Name = "TxtNamaPekerja"
        Me.TxtNamaPekerja.Size = New System.Drawing.Size(349, 26)
        Me.TxtNamaPekerja.TabIndex = 3
        Me.TxtNamaPekerja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtAlamat
        '
        Me.TxtAlamat.BackColor = System.Drawing.Color.DarkSlateGray
        Me.TxtAlamat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtAlamat.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!)
        Me.TxtAlamat.ForeColor = System.Drawing.SystemColors.Control
        Me.TxtAlamat.Location = New System.Drawing.Point(797, 324)
        Me.TxtAlamat.MaxLength = 65
        Me.TxtAlamat.Multiline = True
        Me.TxtAlamat.Name = "TxtAlamat"
        Me.TxtAlamat.Size = New System.Drawing.Size(338, 57)
        Me.TxtAlamat.TabIndex = 4
        '
        'TxtUsername
        '
        Me.TxtUsername.BackColor = System.Drawing.Color.DarkSlateGray
        Me.TxtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtUsername.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.0!)
        Me.TxtUsername.ForeColor = System.Drawing.SystemColors.Control
        Me.TxtUsername.Location = New System.Drawing.Point(789, 553)
        Me.TxtUsername.MaxLength = 16
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(163, 24)
        Me.TxtUsername.TabIndex = 6
        Me.TxtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtPassword
        '
        Me.TxtPassword.BackColor = System.Drawing.Color.DarkSlateGray
        Me.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtPassword.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.0!)
        Me.TxtPassword.ForeColor = System.Drawing.SystemColors.Control
        Me.TxtPassword.Location = New System.Drawing.Point(984, 553)
        Me.TxtPassword.MaxLength = 16
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(154, 24)
        Me.TxtPassword.TabIndex = 7
        Me.TxtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnAgree
        '
        Me.BtnAgree.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.BtnAgree.FlatAppearance.BorderSize = 0
        Me.BtnAgree.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgree.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgree.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnAgree.Location = New System.Drawing.Point(789, 619)
        Me.BtnAgree.Name = "BtnAgree"
        Me.BtnAgree.Size = New System.Drawing.Size(248, 54)
        Me.BtnAgree.TabIndex = 8
        Me.BtnAgree.Text = "Add"
        Me.BtnAgree.UseVisualStyleBackColor = False
        '
        'LblStyle1
        '
        Me.LblStyle1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.LblStyle1.Location = New System.Drawing.Point(789, 166)
        Me.LblStyle1.Name = "LblStyle1"
        Me.LblStyle1.Size = New System.Drawing.Size(229, 10)
        Me.LblStyle1.TabIndex = 21
        '
        'LblStyle2
        '
        Me.LblStyle2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.LblStyle2.Location = New System.Drawing.Point(1057, 166)
        Me.LblStyle2.Name = "LblStyle2"
        Me.LblStyle2.Size = New System.Drawing.Size(81, 10)
        Me.LblStyle2.TabIndex = 22
        '
        'LblStyle3
        '
        Me.LblStyle3.BackColor = System.Drawing.Color.DarkSlateGray
        Me.LblStyle3.Location = New System.Drawing.Point(789, 264)
        Me.LblStyle3.Name = "LblStyle3"
        Me.LblStyle3.Size = New System.Drawing.Size(349, 10)
        Me.LblStyle3.TabIndex = 23
        '
        'LblStyle4
        '
        Me.LblStyle4.BackColor = System.Drawing.Color.DarkSlateGray
        Me.LblStyle4.Location = New System.Drawing.Point(786, 380)
        Me.LblStyle4.Name = "LblStyle4"
        Me.LblStyle4.Size = New System.Drawing.Size(349, 10)
        Me.LblStyle4.TabIndex = 24
        '
        'LblStyle5
        '
        Me.LblStyle5.BackColor = System.Drawing.Color.DarkSlateGray
        Me.LblStyle5.Location = New System.Drawing.Point(788, 474)
        Me.LblStyle5.Name = "LblStyle5"
        Me.LblStyle5.Size = New System.Drawing.Size(349, 10)
        Me.LblStyle5.TabIndex = 26
        '
        'LblStyle7
        '
        Me.LblStyle7.BackColor = System.Drawing.Color.DarkSlateGray
        Me.LblStyle7.Location = New System.Drawing.Point(789, 576)
        Me.LblStyle7.Name = "LblStyle7"
        Me.LblStyle7.Size = New System.Drawing.Size(163, 10)
        Me.LblStyle7.TabIndex = 27
        '
        'LblStyle8
        '
        Me.LblStyle8.BackColor = System.Drawing.Color.DarkSlateGray
        Me.LblStyle8.Location = New System.Drawing.Point(984, 576)
        Me.LblStyle8.Name = "LblStyle8"
        Me.LblStyle8.Size = New System.Drawing.Size(154, 10)
        Me.LblStyle8.TabIndex = 28
        '
        'TxtKadPengenalan
        '
        Me.TxtKadPengenalan.BackColor = System.Drawing.Color.DarkSlateGray
        Me.TxtKadPengenalan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtKadPengenalan.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtKadPengenalan.ForeColor = System.Drawing.SystemColors.Control
        Me.TxtKadPengenalan.Location = New System.Drawing.Point(789, 141)
        Me.TxtKadPengenalan.Mask = "000000-00-0000"
        Me.TxtKadPengenalan.Name = "TxtKadPengenalan"
        Me.TxtKadPengenalan.Size = New System.Drawing.Size(229, 26)
        Me.TxtKadPengenalan.TabIndex = 1
        Me.TxtKadPengenalan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblStyle9
        '
        Me.LblStyle9.BackColor = System.Drawing.Color.DarkSlateGray
        Me.LblStyle9.Location = New System.Drawing.Point(786, 324)
        Me.LblStyle9.Name = "LblStyle9"
        Me.LblStyle9.Size = New System.Drawing.Size(11, 57)
        Me.LblStyle9.TabIndex = 30
        '
        'TxtNoTelefon
        '
        Me.TxtNoTelefon.BackColor = System.Drawing.Color.DarkSlateGray
        Me.TxtNoTelefon.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNoTelefon.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!)
        Me.TxtNoTelefon.ForeColor = System.Drawing.SystemColors.Control
        Me.TxtNoTelefon.Location = New System.Drawing.Point(788, 449)
        Me.TxtNoTelefon.Mask = "000-00000000"
        Me.TxtNoTelefon.Name = "TxtNoTelefon"
        Me.TxtNoTelefon.Size = New System.Drawing.Size(349, 26)
        Me.TxtNoTelefon.TabIndex = 5
        Me.TxtNoTelefon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblStyle10
        '
        Me.LblStyle10.BackColor = System.Drawing.Color.DarkSlateGray
        Me.LblStyle10.Location = New System.Drawing.Point(789, 228)
        Me.LblStyle10.Name = "LblStyle10"
        Me.LblStyle10.Size = New System.Drawing.Size(349, 10)
        Me.LblStyle10.TabIndex = 32
        '
        'LblStyle11
        '
        Me.LblStyle11.BackColor = System.Drawing.Color.DarkSlateGray
        Me.LblStyle11.Location = New System.Drawing.Point(786, 314)
        Me.LblStyle11.Name = "LblStyle11"
        Me.LblStyle11.Size = New System.Drawing.Size(349, 10)
        Me.LblStyle11.TabIndex = 33
        '
        'LblStyle12
        '
        Me.LblStyle12.BackColor = System.Drawing.Color.DarkSlateGray
        Me.LblStyle12.Location = New System.Drawing.Point(788, 439)
        Me.LblStyle12.Name = "LblStyle12"
        Me.LblStyle12.Size = New System.Drawing.Size(349, 10)
        Me.LblStyle12.TabIndex = 34
        '
        'LblStyle14
        '
        Me.LblStyle14.BackColor = System.Drawing.Color.DarkSlateGray
        Me.LblStyle14.Location = New System.Drawing.Point(984, 543)
        Me.LblStyle14.Name = "LblStyle14"
        Me.LblStyle14.Size = New System.Drawing.Size(154, 10)
        Me.LblStyle14.TabIndex = 35
        '
        'LblStyle13
        '
        Me.LblStyle13.BackColor = System.Drawing.Color.DarkSlateGray
        Me.LblStyle13.Location = New System.Drawing.Point(789, 543)
        Me.LblStyle13.Name = "LblStyle13"
        Me.LblStyle13.Size = New System.Drawing.Size(163, 10)
        Me.LblStyle13.TabIndex = 36
        '
        'LblStyle15
        '
        Me.LblStyle15.BackColor = System.Drawing.Color.DarkSlateGray
        Me.LblStyle15.Location = New System.Drawing.Point(789, 132)
        Me.LblStyle15.Name = "LblStyle15"
        Me.LblStyle15.Size = New System.Drawing.Size(229, 10)
        Me.LblStyle15.TabIndex = 37
        '
        'LblStyle16
        '
        Me.LblStyle16.BackColor = System.Drawing.Color.DarkSlateGray
        Me.LblStyle16.Location = New System.Drawing.Point(1057, 132)
        Me.LblStyle16.Name = "LblStyle16"
        Me.LblStyle16.Size = New System.Drawing.Size(81, 10)
        Me.LblStyle16.TabIndex = 38
        '
        'LblEditMode
        '
        Me.LblEditMode.AutoSize = True
        Me.LblEditMode.Font = New System.Drawing.Font("Microsoft JhengHei UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEditMode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.LblEditMode.Location = New System.Drawing.Point(830, 27)
        Me.LblEditMode.Name = "LblEditMode"
        Me.LblEditMode.Size = New System.Drawing.Size(112, 24)
        Me.LblEditMode.TabIndex = 39
        Me.LblEditMode.Text = "EDIT MODE"
        Me.LblEditMode.Visible = False
        '
        'BtnExitEditMode
        '
        Me.BtnExitEditMode.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BtnExitEditMode.FlatAppearance.BorderSize = 0
        Me.BtnExitEditMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExitEditMode.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnExitEditMode.Location = New System.Drawing.Point(995, 27)
        Me.BtnExitEditMode.Name = "BtnExitEditMode"
        Me.BtnExitEditMode.Size = New System.Drawing.Size(131, 42)
        Me.BtnExitEditMode.TabIndex = 40
        Me.BtnExitEditMode.Text = "Exit Edit Mode"
        Me.BtnExitEditMode.UseVisualStyleBackColor = False
        Me.BtnExitEditMode.Visible = False
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BtnDelete.FlatAppearance.BorderSize = 0
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnDelete.Location = New System.Drawing.Point(1043, 619)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(96, 54)
        Me.BtnDelete.TabIndex = 41
        Me.BtnDelete.Text = "Clear"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'LblEditMode2
        '
        Me.LblEditMode2.AutoSize = True
        Me.LblEditMode2.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEditMode2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.LblEditMode2.Location = New System.Drawing.Point(786, 51)
        Me.LblEditMode2.Name = "LblEditMode2"
        Me.LblEditMode2.Size = New System.Drawing.Size(195, 18)
        Me.LblEditMode2.TabIndex = 42
        Me.LblEditMode2.Text = "YOU ARE EDITING THE DATA"
        Me.LblEditMode2.Visible = False
        '
        'BtnBack
        '
        Me.BtnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BtnBack.FlatAppearance.BorderSize = 0
        Me.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBack.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBack.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnBack.Location = New System.Drawing.Point(36, 12)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(107, 39)
        Me.BtnBack.TabIndex = 43
        Me.BtnBack.Text = "BACK"
        Me.BtnBack.UseVisualStyleBackColor = False
        '
        'TxtUmur
        '
        Me.TxtUmur.BackColor = System.Drawing.Color.DarkSlateGray
        Me.TxtUmur.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtUmur.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!)
        Me.TxtUmur.ForeColor = System.Drawing.SystemColors.Control
        Me.TxtUmur.Location = New System.Drawing.Point(1057, 141)
        Me.TxtUmur.MaxLength = 2
        Me.TxtUmur.Name = "TxtUmur"
        Me.TxtUmur.Size = New System.Drawing.Size(81, 26)
        Me.TxtUmur.TabIndex = 2
        Me.TxtUmur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'EmployeeManagementForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(1166, 713)
        Me.Controls.Add(Me.TxtUmur)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.LblEditMode2)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnExitEditMode)
        Me.Controls.Add(Me.LblEditMode)
        Me.Controls.Add(Me.LblStyle16)
        Me.Controls.Add(Me.LblStyle15)
        Me.Controls.Add(Me.LblStyle13)
        Me.Controls.Add(Me.LblStyle14)
        Me.Controls.Add(Me.LblStyle12)
        Me.Controls.Add(Me.LblStyle11)
        Me.Controls.Add(Me.LblStyle10)
        Me.Controls.Add(Me.TxtNoTelefon)
        Me.Controls.Add(Me.LblStyle9)
        Me.Controls.Add(Me.TxtKadPengenalan)
        Me.Controls.Add(Me.LblStyle8)
        Me.Controls.Add(Me.LblStyle7)
        Me.Controls.Add(Me.LblStyle5)
        Me.Controls.Add(Me.LblStyle4)
        Me.Controls.Add(Me.LblStyle3)
        Me.Controls.Add(Me.LblStyle2)
        Me.Controls.Add(Me.LblStyle1)
        Me.Controls.Add(Me.BtnAgree)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.TxtUsername)
        Me.Controls.Add(Me.TxtAlamat)
        Me.Controls.Add(Me.TxtNamaPekerja)
        Me.Controls.Add(Me.LblUmur)
        Me.Controls.Add(Me.LblPassword)
        Me.Controls.Add(Me.LblUsername)
        Me.Controls.Add(Me.LblPoskod)
        Me.Controls.Add(Me.LblKadPengenalan)
        Me.Controls.Add(Me.LblAlamat)
        Me.Controls.Add(Me.LblNamaPekerja)
        Me.Controls.Add(Me.DataGridViewEmployee)
        Me.Controls.Add(Me.LblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "EmployeeManagementForm"
        Me.Text = "Sistem Farmasi Radja | Admin Form"
        CType(Me.DataGridViewEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblTitle As Label
    Friend WithEvents DataGridViewEmployee As DataGridView
    Friend WithEvents LblNamaPekerja As Label
    Friend WithEvents LblAlamat As Label
    Friend WithEvents LblKadPengenalan As Label
    Friend WithEvents LblPoskod As Label
    Friend WithEvents LblUsername As Label
    Friend WithEvents LblPassword As Label
    Friend WithEvents LblUmur As Label
    Friend WithEvents TxtNamaPekerja As TextBox
    Friend WithEvents TxtAlamat As TextBox
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents BtnAgree As Button
    Friend WithEvents LblStyle1 As Label
    Friend WithEvents LblStyle2 As Label
    Friend WithEvents LblStyle3 As Label
    Friend WithEvents LblStyle4 As Label
    Friend WithEvents LblStyle5 As Label
    Friend WithEvents LblStyle7 As Label
    Friend WithEvents LblStyle8 As Label
    Friend WithEvents TxtKadPengenalan As MaskedTextBox
    Friend WithEvents LblStyle9 As Label
    Friend WithEvents TxtNoTelefon As MaskedTextBox
    Friend WithEvents LblStyle10 As Label
    Friend WithEvents LblStyle11 As Label
    Friend WithEvents LblStyle12 As Label
    Friend WithEvents LblStyle14 As Label
    Friend WithEvents LblStyle13 As Label
    Friend WithEvents LblStyle15 As Label
    Friend WithEvents LblStyle16 As Label
    Friend WithEvents LblEditMode As Label
    Friend WithEvents BtnExitEditMode As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents LblEditMode2 As Label
    Friend WithEvents BtnBack As Button
    Friend WithEvents TxtUmur As TextBox
End Class
