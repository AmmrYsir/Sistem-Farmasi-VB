<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.LblUsername = New System.Windows.Forms.Label()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.LblStyle1 = New System.Windows.Forms.Label()
        Me.LblStyle2 = New System.Windows.Forms.Label()
        Me.LblStyle3 = New System.Windows.Forms.Label()
        Me.LblStyle4 = New System.Windows.Forms.Label()
        Me.PcBoxLogo = New System.Windows.Forms.PictureBox()
        CType(Me.PcBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnLogin
        '
        Me.BtnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.BtnLogin.FlatAppearance.BorderSize = 0
        Me.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogin.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogin.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnLogin.Location = New System.Drawing.Point(350, 578)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(467, 67)
        Me.BtnLogin.TabIndex = 3
        Me.BtnLogin.Text = "LOGIN"
        Me.BtnLogin.UseVisualStyleBackColor = False
        '
        'LblUsername
        '
        Me.LblUsername.AutoSize = True
        Me.LblUsername.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsername.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.LblUsername.Location = New System.Drawing.Point(463, 257)
        Me.LblUsername.Name = "LblUsername"
        Me.LblUsername.Size = New System.Drawing.Size(251, 57)
        Me.LblUsername.TabIndex = 1
        Me.LblUsername.Text = "USERNAME"
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPassword.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.LblPassword.Location = New System.Drawing.Point(463, 419)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(259, 57)
        Me.LblPassword.TabIndex = 2
        Me.LblPassword.Text = "PASSWORD"
        '
        'TxtUsername
        '
        Me.TxtUsername.BackColor = System.Drawing.Color.DarkSlateGray
        Me.TxtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtUsername.Font = New System.Drawing.Font("Microsoft YaHei UI", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsername.ForeColor = System.Drawing.SystemColors.Control
        Me.TxtUsername.Location = New System.Drawing.Point(350, 340)
        Me.TxtUsername.MaxLength = 13
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(467, 47)
        Me.TxtUsername.TabIndex = 1
        Me.TxtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtPassword
        '
        Me.TxtPassword.BackColor = System.Drawing.Color.DarkSlateGray
        Me.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtPassword.Font = New System.Drawing.Font("Microsoft YaHei UI", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPassword.ForeColor = System.Drawing.SystemColors.Control
        Me.TxtPassword.Location = New System.Drawing.Point(350, 494)
        Me.TxtPassword.MaxLength = 12
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(467, 55)
        Me.TxtPassword.TabIndex = 2
        Me.TxtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblStyle1
        '
        Me.LblStyle1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.LblStyle1.Location = New System.Drawing.Point(350, 329)
        Me.LblStyle1.Name = "LblStyle1"
        Me.LblStyle1.Size = New System.Drawing.Size(467, 11)
        Me.LblStyle1.TabIndex = 5
        '
        'LblStyle2
        '
        Me.LblStyle2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.LblStyle2.Location = New System.Drawing.Point(350, 387)
        Me.LblStyle2.Name = "LblStyle2"
        Me.LblStyle2.Size = New System.Drawing.Size(467, 11)
        Me.LblStyle2.TabIndex = 6
        '
        'LblStyle3
        '
        Me.LblStyle3.BackColor = System.Drawing.Color.DarkSlateGray
        Me.LblStyle3.Location = New System.Drawing.Point(350, 483)
        Me.LblStyle3.Name = "LblStyle3"
        Me.LblStyle3.Size = New System.Drawing.Size(467, 11)
        Me.LblStyle3.TabIndex = 7
        '
        'LblStyle4
        '
        Me.LblStyle4.BackColor = System.Drawing.Color.DarkSlateGray
        Me.LblStyle4.Location = New System.Drawing.Point(350, 548)
        Me.LblStyle4.Name = "LblStyle4"
        Me.LblStyle4.Size = New System.Drawing.Size(467, 11)
        Me.LblStyle4.TabIndex = 8
        '
        'PcBoxLogo
        '
        Me.PcBoxLogo.Image = Global.SistemFarmasiRadja.My.Resources.Resources.logo
        Me.PcBoxLogo.Location = New System.Drawing.Point(441, 37)
        Me.PcBoxLogo.Name = "PcBoxLogo"
        Me.PcBoxLogo.Size = New System.Drawing.Size(294, 188)
        Me.PcBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PcBoxLogo.TabIndex = 4
        Me.PcBoxLogo.TabStop = False
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(1193, 713)
        Me.Controls.Add(Me.LblStyle4)
        Me.Controls.Add(Me.LblStyle3)
        Me.Controls.Add(Me.LblStyle2)
        Me.Controls.Add(Me.LblStyle1)
        Me.Controls.Add(Me.PcBoxLogo)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.TxtUsername)
        Me.Controls.Add(Me.LblPassword)
        Me.Controls.Add(Me.LblUsername)
        Me.Controls.Add(Me.BtnLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "LoginForm"
        Me.Text = "Sistem Farmasi Radja | Login Form"
        CType(Me.PcBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnLogin As Button
    Friend WithEvents LblUsername As Label
    Friend WithEvents LblPassword As Label
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents PcBoxLogo As PictureBox
    Friend WithEvents LblStyle1 As Label
    Friend WithEvents LblStyle2 As Label
    Friend WithEvents LblStyle3 As Label
    Friend WithEvents LblStyle4 As Label
End Class
