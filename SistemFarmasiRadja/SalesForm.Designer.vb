<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SalesForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GrpBoxStatistic = New System.Windows.Forms.GroupBox()
        Me.LblStyle5 = New System.Windows.Forms.Label()
        Me.LblStyle6 = New System.Windows.Forms.Label()
        Me.TxtTotalProfit = New System.Windows.Forms.TextBox()
        Me.LblStyle3 = New System.Windows.Forms.Label()
        Me.LblTotalInvoice = New System.Windows.Forms.Label()
        Me.LblStyle4 = New System.Windows.Forms.Label()
        Me.TxtTotalInvoice = New System.Windows.Forms.TextBox()
        Me.LblTotalProfit = New System.Windows.Forms.Label()
        Me.GrpBoxSearchForInvoice = New System.Windows.Forms.GroupBox()
        Me.DataGridViewTransaction = New System.Windows.Forms.DataGridView()
        Me.LblStyle1 = New System.Windows.Forms.Label()
        Me.LblStyle2 = New System.Windows.Forms.Label()
        Me.TxtSearchInvoice = New System.Windows.Forms.TextBox()
        Me.BtnSearchInvoice = New System.Windows.Forms.Button()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.GrpBoxStatistic.SuspendLayout()
        Me.GrpBoxSearchForInvoice.SuspendLayout()
        CType(Me.DataGridViewTransaction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpBoxStatistic
        '
        Me.GrpBoxStatistic.Controls.Add(Me.LblStyle5)
        Me.GrpBoxStatistic.Controls.Add(Me.LblStyle6)
        Me.GrpBoxStatistic.Controls.Add(Me.TxtTotalProfit)
        Me.GrpBoxStatistic.Controls.Add(Me.LblStyle3)
        Me.GrpBoxStatistic.Controls.Add(Me.LblTotalInvoice)
        Me.GrpBoxStatistic.Controls.Add(Me.LblStyle4)
        Me.GrpBoxStatistic.Controls.Add(Me.TxtTotalInvoice)
        Me.GrpBoxStatistic.Controls.Add(Me.LblTotalProfit)
        Me.GrpBoxStatistic.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpBoxStatistic.ForeColor = System.Drawing.SystemColors.Control
        Me.GrpBoxStatistic.Location = New System.Drawing.Point(22, 121)
        Me.GrpBoxStatistic.Name = "GrpBoxStatistic"
        Me.GrpBoxStatistic.Size = New System.Drawing.Size(343, 456)
        Me.GrpBoxStatistic.TabIndex = 0
        Me.GrpBoxStatistic.TabStop = False
        Me.GrpBoxStatistic.Text = "SALES STATISTIC"
        '
        'LblStyle5
        '
        Me.LblStyle5.BackColor = System.Drawing.Color.DarkSlateGray
        Me.LblStyle5.Location = New System.Drawing.Point(21, 184)
        Me.LblStyle5.Name = "LblStyle5"
        Me.LblStyle5.Size = New System.Drawing.Size(300, 15)
        Me.LblStyle5.TabIndex = 14
        '
        'LblStyle6
        '
        Me.LblStyle6.BackColor = System.Drawing.Color.DarkSlateGray
        Me.LblStyle6.Location = New System.Drawing.Point(21, 223)
        Me.LblStyle6.Name = "LblStyle6"
        Me.LblStyle6.Size = New System.Drawing.Size(300, 15)
        Me.LblStyle6.TabIndex = 12
        '
        'TxtTotalProfit
        '
        Me.TxtTotalProfit.BackColor = System.Drawing.Color.DarkSlateGray
        Me.TxtTotalProfit.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTotalProfit.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalProfit.ForeColor = System.Drawing.SystemColors.Control
        Me.TxtTotalProfit.Location = New System.Drawing.Point(21, 198)
        Me.TxtTotalProfit.MaxLength = 100
        Me.TxtTotalProfit.Name = "TxtTotalProfit"
        Me.TxtTotalProfit.ReadOnly = True
        Me.TxtTotalProfit.Size = New System.Drawing.Size(300, 26)
        Me.TxtTotalProfit.TabIndex = 13
        Me.TxtTotalProfit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblStyle3
        '
        Me.LblStyle3.BackColor = System.Drawing.Color.DarkSlateGray
        Me.LblStyle3.Location = New System.Drawing.Point(21, 77)
        Me.LblStyle3.Name = "LblStyle3"
        Me.LblStyle3.Size = New System.Drawing.Size(300, 15)
        Me.LblStyle3.TabIndex = 11
        '
        'LblTotalInvoice
        '
        Me.LblTotalInvoice.AutoSize = True
        Me.LblTotalInvoice.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 13.8!)
        Me.LblTotalInvoice.Location = New System.Drawing.Point(81, 46)
        Me.LblTotalInvoice.Name = "LblTotalInvoice"
        Me.LblTotalInvoice.Size = New System.Drawing.Size(152, 31)
        Me.LblTotalInvoice.TabIndex = 3
        Me.LblTotalInvoice.Text = "Total Invoice"
        '
        'LblStyle4
        '
        Me.LblStyle4.BackColor = System.Drawing.Color.DarkSlateGray
        Me.LblStyle4.Location = New System.Drawing.Point(21, 116)
        Me.LblStyle4.Name = "LblStyle4"
        Me.LblStyle4.Size = New System.Drawing.Size(300, 15)
        Me.LblStyle4.TabIndex = 9
        '
        'TxtTotalInvoice
        '
        Me.TxtTotalInvoice.BackColor = System.Drawing.Color.DarkSlateGray
        Me.TxtTotalInvoice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTotalInvoice.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalInvoice.ForeColor = System.Drawing.SystemColors.Control
        Me.TxtTotalInvoice.Location = New System.Drawing.Point(21, 91)
        Me.TxtTotalInvoice.MaxLength = 3
        Me.TxtTotalInvoice.Name = "TxtTotalInvoice"
        Me.TxtTotalInvoice.ReadOnly = True
        Me.TxtTotalInvoice.Size = New System.Drawing.Size(300, 26)
        Me.TxtTotalInvoice.TabIndex = 10
        Me.TxtTotalInvoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblTotalProfit
        '
        Me.LblTotalProfit.AutoSize = True
        Me.LblTotalProfit.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 13.8!)
        Me.LblTotalProfit.Location = New System.Drawing.Point(91, 153)
        Me.LblTotalProfit.Name = "LblTotalProfit"
        Me.LblTotalProfit.Size = New System.Drawing.Size(133, 31)
        Me.LblTotalProfit.TabIndex = 1
        Me.LblTotalProfit.Text = "Total Profit"
        '
        'GrpBoxSearchForInvoice
        '
        Me.GrpBoxSearchForInvoice.Controls.Add(Me.DataGridViewTransaction)
        Me.GrpBoxSearchForInvoice.Controls.Add(Me.LblStyle1)
        Me.GrpBoxSearchForInvoice.Controls.Add(Me.LblStyle2)
        Me.GrpBoxSearchForInvoice.Controls.Add(Me.TxtSearchInvoice)
        Me.GrpBoxSearchForInvoice.Controls.Add(Me.BtnSearchInvoice)
        Me.GrpBoxSearchForInvoice.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpBoxSearchForInvoice.ForeColor = System.Drawing.SystemColors.Control
        Me.GrpBoxSearchForInvoice.Location = New System.Drawing.Point(384, 12)
        Me.GrpBoxSearchForInvoice.Name = "GrpBoxSearchForInvoice"
        Me.GrpBoxSearchForInvoice.Size = New System.Drawing.Size(670, 565)
        Me.GrpBoxSearchForInvoice.TabIndex = 4
        Me.GrpBoxSearchForInvoice.TabStop = False
        Me.GrpBoxSearchForInvoice.Text = "SEARCH FOR INVOICE"
        '
        'DataGridViewTransaction
        '
        Me.DataGridViewTransaction.AllowUserToAddRows = False
        Me.DataGridViewTransaction.AllowUserToDeleteRows = False
        Me.DataGridViewTransaction.AllowUserToOrderColumns = True
        Me.DataGridViewTransaction.AllowUserToResizeRows = False
        Me.DataGridViewTransaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridViewTransaction.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataGridViewTransaction.BackgroundColor = System.Drawing.Color.LightSeaGreen
        Me.DataGridViewTransaction.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridViewTransaction.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 11.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTransaction.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 8.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTransaction.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTransaction.GridColor = System.Drawing.SystemColors.AppWorkspace
        Me.DataGridViewTransaction.Location = New System.Drawing.Point(21, 96)
        Me.DataGridViewTransaction.MultiSelect = False
        Me.DataGridViewTransaction.Name = "DataGridViewTransaction"
        Me.DataGridViewTransaction.ReadOnly = True
        Me.DataGridViewTransaction.RowHeadersWidth = 51
        Me.DataGridViewTransaction.RowTemplate.Height = 24
        Me.DataGridViewTransaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewTransaction.Size = New System.Drawing.Size(624, 463)
        Me.DataGridViewTransaction.TabIndex = 8
        '
        'LblStyle1
        '
        Me.LblStyle1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.LblStyle1.Location = New System.Drawing.Point(21, 42)
        Me.LblStyle1.Name = "LblStyle1"
        Me.LblStyle1.Size = New System.Drawing.Size(484, 15)
        Me.LblStyle1.TabIndex = 7
        '
        'LblStyle2
        '
        Me.LblStyle2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.LblStyle2.Location = New System.Drawing.Point(21, 75)
        Me.LblStyle2.Name = "LblStyle2"
        Me.LblStyle2.Size = New System.Drawing.Size(484, 15)
        Me.LblStyle2.TabIndex = 4
        '
        'TxtSearchInvoice
        '
        Me.TxtSearchInvoice.BackColor = System.Drawing.Color.DarkSlateGray
        Me.TxtSearchInvoice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtSearchInvoice.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!)
        Me.TxtSearchInvoice.ForeColor = System.Drawing.SystemColors.Control
        Me.TxtSearchInvoice.Location = New System.Drawing.Point(21, 56)
        Me.TxtSearchInvoice.MaxLength = 12
        Me.TxtSearchInvoice.Name = "TxtSearchInvoice"
        Me.TxtSearchInvoice.Size = New System.Drawing.Size(484, 20)
        Me.TxtSearchInvoice.TabIndex = 4
        Me.TxtSearchInvoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnSearchInvoice
        '
        Me.BtnSearchInvoice.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.BtnSearchInvoice.FlatAppearance.BorderSize = 0
        Me.BtnSearchInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearchInvoice.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearchInvoice.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnSearchInvoice.Location = New System.Drawing.Point(511, 42)
        Me.BtnSearchInvoice.Name = "BtnSearchInvoice"
        Me.BtnSearchInvoice.Size = New System.Drawing.Size(134, 48)
        Me.BtnSearchInvoice.TabIndex = 6
        Me.BtnSearchInvoice.Text = "Search Invoice"
        Me.BtnSearchInvoice.UseVisualStyleBackColor = False
        '
        'BtnBack
        '
        Me.BtnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BtnBack.FlatAppearance.BorderSize = 0
        Me.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBack.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBack.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnBack.Location = New System.Drawing.Point(22, 22)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(107, 47)
        Me.BtnBack.TabIndex = 5
        Me.BtnBack.Text = "BACK"
        Me.BtnBack.UseVisualStyleBackColor = False
        '
        'SalesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(1076, 595)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.GrpBoxSearchForInvoice)
        Me.Controls.Add(Me.GrpBoxStatistic)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "SalesForm"
        Me.Text = "Sistem Farmasi Radja | Admin Form"
        Me.GrpBoxStatistic.ResumeLayout(False)
        Me.GrpBoxStatistic.PerformLayout()
        Me.GrpBoxSearchForInvoice.ResumeLayout(False)
        Me.GrpBoxSearchForInvoice.PerformLayout()
        CType(Me.DataGridViewTransaction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GrpBoxStatistic As GroupBox
    Friend WithEvents LblTotalProfit As Label
    Friend WithEvents LblTotalInvoice As Label
    Friend WithEvents GrpBoxSearchForInvoice As GroupBox
    Friend WithEvents BtnBack As Button
    Friend WithEvents TxtSearchInvoice As TextBox
    Friend WithEvents BtnSearchInvoice As Button
    Friend WithEvents LblStyle1 As Label
    Friend WithEvents LblStyle2 As Label
    Friend WithEvents DataGridViewTransaction As DataGridView
    Friend WithEvents LblStyle3 As Label
    Friend WithEvents LblStyle4 As Label
    Friend WithEvents TxtTotalInvoice As TextBox
    Friend WithEvents LblStyle5 As Label
    Friend WithEvents LblStyle6 As Label
    Friend WithEvents TxtTotalProfit As TextBox
End Class
