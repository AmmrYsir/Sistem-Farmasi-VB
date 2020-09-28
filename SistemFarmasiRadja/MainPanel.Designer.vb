<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainPanel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainPanel))
        Me.PcBoxSales = New System.Windows.Forms.PictureBox()
        Me.PcBoxEmployee = New System.Windows.Forms.PictureBox()
        Me.PcBoxStock = New System.Windows.Forms.PictureBox()
        Me.LblPointOfSale = New System.Windows.Forms.Label()
        Me.LblIDStock = New System.Windows.Forms.Label()
        Me.BtnCompleteOrder = New System.Windows.Forms.Button()
        Me.BtnAddOrder = New System.Windows.Forms.Button()
        Me.LblQuantity = New System.Windows.Forms.Label()
        Me.TxtIdStock = New System.Windows.Forms.TextBox()
        Me.LblStyle1 = New System.Windows.Forms.Label()
        Me.LblStyle2 = New System.Windows.Forms.Label()
        Me.LblStyle3 = New System.Windows.Forms.Label()
        Me.LblStyle4 = New System.Windows.Forms.Label()
        Me.BtnDeleteOrder = New System.Windows.Forms.Button()
        Me.DataGridViewPOS = New System.Windows.Forms.DataGridView()
        Me.TxtQuantity = New System.Windows.Forms.TextBox()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.PrintDocument = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog = New System.Windows.Forms.PrintPreviewDialog()
        CType(Me.PcBoxSales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PcBoxEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PcBoxStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewPOS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PcBoxSales
        '
        Me.PcBoxSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PcBoxSales.Image = Global.SistemFarmasiRadja.My.Resources.Resources.sales
        Me.PcBoxSales.Location = New System.Drawing.Point(896, 12)
        Me.PcBoxSales.Name = "PcBoxSales"
        Me.PcBoxSales.Size = New System.Drawing.Size(210, 172)
        Me.PcBoxSales.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PcBoxSales.TabIndex = 2
        Me.PcBoxSales.TabStop = False
        Me.PcBoxSales.Visible = False
        '
        'PcBoxEmployee
        '
        Me.PcBoxEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PcBoxEmployee.Image = Global.SistemFarmasiRadja.My.Resources.Resources.employee
        Me.PcBoxEmployee.Location = New System.Drawing.Point(183, 12)
        Me.PcBoxEmployee.Name = "PcBoxEmployee"
        Me.PcBoxEmployee.Size = New System.Drawing.Size(396, 172)
        Me.PcBoxEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PcBoxEmployee.TabIndex = 1
        Me.PcBoxEmployee.TabStop = False
        Me.PcBoxEmployee.Visible = False
        '
        'PcBoxStock
        '
        Me.PcBoxStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PcBoxStock.Image = Global.SistemFarmasiRadja.My.Resources.Resources.stock
        Me.PcBoxStock.Location = New System.Drawing.Point(621, 12)
        Me.PcBoxStock.Name = "PcBoxStock"
        Me.PcBoxStock.Size = New System.Drawing.Size(210, 172)
        Me.PcBoxStock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PcBoxStock.TabIndex = 0
        Me.PcBoxStock.TabStop = False
        Me.PcBoxStock.Visible = False
        '
        'LblPointOfSale
        '
        Me.LblPointOfSale.AutoSize = True
        Me.LblPointOfSale.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPointOfSale.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.LblPointOfSale.Location = New System.Drawing.Point(91, 221)
        Me.LblPointOfSale.Name = "LblPointOfSale"
        Me.LblPointOfSale.Size = New System.Drawing.Size(232, 38)
        Me.LblPointOfSale.TabIndex = 4
        Me.LblPointOfSale.Text = "POINT OF SALE"
        '
        'LblIDStock
        '
        Me.LblIDStock.AutoSize = True
        Me.LblIDStock.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIDStock.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.LblIDStock.Location = New System.Drawing.Point(886, 262)
        Me.LblIDStock.Name = "LblIDStock"
        Me.LblIDStock.Size = New System.Drawing.Size(103, 30)
        Me.LblIDStock.TabIndex = 5
        Me.LblIDStock.Text = "ID Stock"
        '
        'BtnCompleteOrder
        '
        Me.BtnCompleteOrder.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnCompleteOrder.FlatAppearance.BorderSize = 0
        Me.BtnCompleteOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCompleteOrder.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnCompleteOrder.Location = New System.Drawing.Point(891, 544)
        Me.BtnCompleteOrder.Name = "BtnCompleteOrder"
        Me.BtnCompleteOrder.Size = New System.Drawing.Size(210, 47)
        Me.BtnCompleteOrder.TabIndex = 4
        Me.BtnCompleteOrder.Text = "Complete Order"
        Me.BtnCompleteOrder.UseVisualStyleBackColor = False
        '
        'BtnAddOrder
        '
        Me.BtnAddOrder.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.BtnAddOrder.FlatAppearance.BorderSize = 0
        Me.BtnAddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddOrder.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnAddOrder.Location = New System.Drawing.Point(891, 491)
        Me.BtnAddOrder.Name = "BtnAddOrder"
        Me.BtnAddOrder.Size = New System.Drawing.Size(210, 47)
        Me.BtnAddOrder.TabIndex = 3
        Me.BtnAddOrder.Text = "Add Order"
        Me.BtnAddOrder.UseVisualStyleBackColor = False
        '
        'LblQuantity
        '
        Me.LblQuantity.AutoSize = True
        Me.LblQuantity.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblQuantity.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.LblQuantity.Location = New System.Drawing.Point(886, 361)
        Me.LblQuantity.Name = "LblQuantity"
        Me.LblQuantity.Size = New System.Drawing.Size(107, 30)
        Me.LblQuantity.TabIndex = 8
        Me.LblQuantity.Text = "Quantity"
        '
        'TxtIdStock
        '
        Me.TxtIdStock.BackColor = System.Drawing.Color.DarkSlateGray
        Me.TxtIdStock.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtIdStock.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIdStock.ForeColor = System.Drawing.SystemColors.Control
        Me.TxtIdStock.Location = New System.Drawing.Point(893, 306)
        Me.TxtIdStock.MaxLength = 16
        Me.TxtIdStock.Name = "TxtIdStock"
        Me.TxtIdStock.ReadOnly = True
        Me.TxtIdStock.Size = New System.Drawing.Size(208, 27)
        Me.TxtIdStock.TabIndex = 1
        Me.TxtIdStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblStyle1
        '
        Me.LblStyle1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.LblStyle1.Location = New System.Drawing.Point(893, 293)
        Me.LblStyle1.Name = "LblStyle1"
        Me.LblStyle1.Size = New System.Drawing.Size(208, 13)
        Me.LblStyle1.TabIndex = 11
        '
        'LblStyle2
        '
        Me.LblStyle2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.LblStyle2.Location = New System.Drawing.Point(893, 332)
        Me.LblStyle2.Name = "LblStyle2"
        Me.LblStyle2.Size = New System.Drawing.Size(208, 13)
        Me.LblStyle2.TabIndex = 12
        '
        'LblStyle3
        '
        Me.LblStyle3.BackColor = System.Drawing.Color.DarkSlateGray
        Me.LblStyle3.Location = New System.Drawing.Point(893, 393)
        Me.LblStyle3.Name = "LblStyle3"
        Me.LblStyle3.Size = New System.Drawing.Size(208, 13)
        Me.LblStyle3.TabIndex = 13
        '
        'LblStyle4
        '
        Me.LblStyle4.BackColor = System.Drawing.Color.DarkSlateGray
        Me.LblStyle4.Location = New System.Drawing.Point(893, 431)
        Me.LblStyle4.Name = "LblStyle4"
        Me.LblStyle4.Size = New System.Drawing.Size(208, 13)
        Me.LblStyle4.TabIndex = 14
        '
        'BtnDeleteOrder
        '
        Me.BtnDeleteOrder.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BtnDeleteOrder.FlatAppearance.BorderSize = 0
        Me.BtnDeleteOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDeleteOrder.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnDeleteOrder.Location = New System.Drawing.Point(891, 597)
        Me.BtnDeleteOrder.Name = "BtnDeleteOrder"
        Me.BtnDeleteOrder.Size = New System.Drawing.Size(210, 47)
        Me.BtnDeleteOrder.TabIndex = 5
        Me.BtnDeleteOrder.Text = "Delete Order"
        Me.BtnDeleteOrder.UseVisualStyleBackColor = False
        '
        'DataGridViewPOS
        '
        Me.DataGridViewPOS.AllowUserToAddRows = False
        Me.DataGridViewPOS.AllowUserToDeleteRows = False
        Me.DataGridViewPOS.AllowUserToOrderColumns = True
        Me.DataGridViewPOS.AllowUserToResizeRows = False
        Me.DataGridViewPOS.BackgroundColor = System.Drawing.Color.LightSeaGreen
        Me.DataGridViewPOS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridViewPOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPOS.Location = New System.Drawing.Point(98, 262)
        Me.DataGridViewPOS.MultiSelect = False
        Me.DataGridViewPOS.Name = "DataGridViewPOS"
        Me.DataGridViewPOS.ReadOnly = True
        Me.DataGridViewPOS.RowHeadersWidth = 51
        Me.DataGridViewPOS.RowTemplate.Height = 24
        Me.DataGridViewPOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewPOS.Size = New System.Drawing.Size(750, 428)
        Me.DataGridViewPOS.TabIndex = 16
        '
        'TxtQuantity
        '
        Me.TxtQuantity.BackColor = System.Drawing.Color.DarkSlateGray
        Me.TxtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtQuantity.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtQuantity.ForeColor = System.Drawing.SystemColors.Control
        Me.TxtQuantity.Location = New System.Drawing.Point(893, 406)
        Me.TxtQuantity.MaxLength = 3
        Me.TxtQuantity.Name = "TxtQuantity"
        Me.TxtQuantity.Size = New System.Drawing.Size(208, 27)
        Me.TxtQuantity.TabIndex = 17
        Me.TxtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnBack
        '
        Me.BtnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BtnBack.FlatAppearance.BorderSize = 0
        Me.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBack.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBack.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnBack.Location = New System.Drawing.Point(12, 12)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(107, 39)
        Me.BtnBack.TabIndex = 44
        Me.BtnBack.Text = "Log Out"
        Me.BtnBack.UseVisualStyleBackColor = False
        '
        'PrintDocument
        '
        '
        'PrintPreviewDialog
        '
        Me.PrintPreviewDialog.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog.Enabled = True
        Me.PrintPreviewDialog.Icon = CType(resources.GetObject("PrintPreviewDialog.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog.Visible = False
        '
        'MainPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(1193, 713)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.TxtQuantity)
        Me.Controls.Add(Me.DataGridViewPOS)
        Me.Controls.Add(Me.BtnDeleteOrder)
        Me.Controls.Add(Me.LblStyle4)
        Me.Controls.Add(Me.LblStyle3)
        Me.Controls.Add(Me.LblStyle2)
        Me.Controls.Add(Me.LblStyle1)
        Me.Controls.Add(Me.TxtIdStock)
        Me.Controls.Add(Me.LblQuantity)
        Me.Controls.Add(Me.BtnAddOrder)
        Me.Controls.Add(Me.BtnCompleteOrder)
        Me.Controls.Add(Me.LblIDStock)
        Me.Controls.Add(Me.LblPointOfSale)
        Me.Controls.Add(Me.PcBoxSales)
        Me.Controls.Add(Me.PcBoxEmployee)
        Me.Controls.Add(Me.PcBoxStock)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "MainPanel"
        Me.Text = "Sistem Farmasi Radja | Main Panel"
        CType(Me.PcBoxSales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PcBoxEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PcBoxStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewPOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PcBoxStock As PictureBox
    Friend WithEvents PcBoxEmployee As PictureBox
    Friend WithEvents PcBoxSales As PictureBox
    Friend WithEvents LblPointOfSale As Label
    Friend WithEvents LblIDStock As Label
    Friend WithEvents BtnCompleteOrder As Button
    Friend WithEvents BtnAddOrder As Button
    Friend WithEvents LblQuantity As Label
    Friend WithEvents TxtIdStock As TextBox
    Friend WithEvents LblStyle1 As Label
    Friend WithEvents LblStyle2 As Label
    Friend WithEvents LblStyle3 As Label
    Friend WithEvents LblStyle4 As Label
    Friend WithEvents BtnDeleteOrder As Button
    Friend WithEvents DataGridViewPOS As DataGridView
    Friend WithEvents TxtQuantity As TextBox
    Friend WithEvents BtnBack As Button
    Friend WithEvents PrintDocument As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog As PrintPreviewDialog
End Class
