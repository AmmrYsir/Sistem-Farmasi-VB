<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectUbatForm
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
        Me.DataGridViewStock = New System.Windows.Forms.DataGridView()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.LblStyle2 = New System.Windows.Forms.Label()
        Me.LblStyle3 = New System.Windows.Forms.Label()
        Me.LblStyle1 = New System.Windows.Forms.Label()
        Me.LblStyle4 = New System.Windows.Forms.Label()
        Me.BtnSearch = New System.Windows.Forms.Button()
        CType(Me.DataGridViewStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewStock
        '
        Me.DataGridViewStock.BackgroundColor = System.Drawing.Color.LightSeaGreen
        Me.DataGridViewStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewStock.Location = New System.Drawing.Point(33, 86)
        Me.DataGridViewStock.Name = "DataGridViewStock"
        Me.DataGridViewStock.RowHeadersWidth = 51
        Me.DataGridViewStock.RowTemplate.Height = 24
        Me.DataGridViewStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewStock.Size = New System.Drawing.Size(1042, 569)
        Me.DataGridViewStock.TabIndex = 41
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.LblTitle.Location = New System.Drawing.Point(27, 37)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(365, 36)
        Me.LblTitle.TabIndex = 42
        Me.LblTitle.Text = "STOCK MANAGEMENT LIST"
        '
        'TxtSearch
        '
        Me.TxtSearch.BackColor = System.Drawing.Color.DarkSlateGray
        Me.TxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtSearch.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSearch.ForeColor = System.Drawing.SystemColors.Control
        Me.TxtSearch.Location = New System.Drawing.Point(734, 48)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(328, 22)
        Me.TxtSearch.TabIndex = 1
        '
        'LblStyle2
        '
        Me.LblStyle2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.LblStyle2.Location = New System.Drawing.Point(734, 37)
        Me.LblStyle2.Name = "LblStyle2"
        Me.LblStyle2.Size = New System.Drawing.Size(328, 12)
        Me.LblStyle2.TabIndex = 44
        '
        'LblStyle3
        '
        Me.LblStyle3.BackColor = System.Drawing.Color.DarkSlateGray
        Me.LblStyle3.Location = New System.Drawing.Point(734, 69)
        Me.LblStyle3.Name = "LblStyle3"
        Me.LblStyle3.Size = New System.Drawing.Size(328, 12)
        Me.LblStyle3.TabIndex = 45
        '
        'LblStyle1
        '
        Me.LblStyle1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.LblStyle1.Location = New System.Drawing.Point(721, 37)
        Me.LblStyle1.Name = "LblStyle1"
        Me.LblStyle1.Size = New System.Drawing.Size(14, 44)
        Me.LblStyle1.TabIndex = 46
        '
        'LblStyle4
        '
        Me.LblStyle4.BackColor = System.Drawing.Color.DarkSlateGray
        Me.LblStyle4.Location = New System.Drawing.Point(1061, 37)
        Me.LblStyle4.Name = "LblStyle4"
        Me.LblStyle4.Size = New System.Drawing.Size(14, 44)
        Me.LblStyle4.TabIndex = 47
        '
        'BtnSearch
        '
        Me.BtnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnSearch.FlatAppearance.BorderSize = 0
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearch.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnSearch.Location = New System.Drawing.Point(643, 37)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(72, 44)
        Me.BtnSearch.TabIndex = 2
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = False
        '
        'SelectUbatForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(1128, 680)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.LblStyle4)
        Me.Controls.Add(Me.LblStyle1)
        Me.Controls.Add(Me.LblStyle3)
        Me.Controls.Add(Me.LblStyle2)
        Me.Controls.Add(Me.TxtSearch)
        Me.Controls.Add(Me.DataGridViewStock)
        Me.Controls.Add(Me.LblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "SelectUbatForm"
        Me.Text = "Sistem Farmasi Radja | Admin Form"
        CType(Me.DataGridViewStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewStock As DataGridView
    Friend WithEvents LblTitle As Label
    Friend WithEvents TxtSearch As TextBox
    Friend WithEvents LblStyle2 As Label
    Friend WithEvents LblStyle3 As Label
    Friend WithEvents LblStyle1 As Label
    Friend WithEvents LblStyle4 As Label
    Friend WithEvents BtnSearch As Button
End Class
