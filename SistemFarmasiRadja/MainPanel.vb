Imports MySql.Data.MySqlClient

Public Class MainPanel
    Public Selected_Id_Transaction As String
    Public Invoice_Id As String = Nothing
    Private Transaction_Row As String = "0"
    Private SortedListTransaction As SortedList(Of String, String) = New SortedList(Of String, String)
    Private ArrayDeletedTransaction As New List(Of Integer)
    Private ArrayTransactionList As New List(Of Integer)

    Private Sub BtnAddOrder_Click(sender As Object, e As EventArgs) Handles BtnAddOrder.Click
        If TxtIdStock.Text = String.Empty Then
            MessageBox.Show("Please do not leave Id Stock blank", "Add Order Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf TxtQuantity.Text = String.Empty Then
            MessageBox.Show("Please do not leave Quantity blank", "Add Order Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            AddTransaction()
        End If
    End Sub

    Private Sub BtnCompleteOrder_Click(sender As Object, e As EventArgs) Handles BtnCompleteOrder.Click
        CompleteInvoice()
    End Sub

    Private Sub CreateNewInvoice(ByVal TotalAmount)
        Call Connect()
        cmd = New MySqlCommand("INSERT INTO invoice_table(totalAmount,invoice_id) VALUES(@totalAmount,@invoice_id)", conn)
        cmd.Parameters.AddWithValue("@totalAmount", TotalAmount)
        cmd.Parameters.AddWithValue("@invoice_id", Invoice_Id)
        cmd.ExecuteNonQuery()
        conn.Close()
        TransactionDataLoad()
        Invoice_Id = GenerateUUID()
    End Sub

    Private Sub AddTransaction()

        Call Connect()
        cmd = New MySqlCommand("SELECT quantity FROM ubat_table WHERE id_ubat=@ubat_id", conn)
        cmd.Parameters.AddWithValue("@ubat_id", TxtIdStock.Text)
        Dim QuantityStock As Integer = cmd.ExecuteScalar()
        conn.Close()

        With SortedListTransaction
            If .ContainsKey(TxtIdStock.Text) Then
                EditTransaction()
            Else
                .Add(TxtIdStock.Text, QuantityStock)
                EditTransaction()
            End If
        End With
    End Sub

    Private Sub EditTransaction()
        Call Connect()
        cmd = New MySqlCommand("SELECT harga_ubat FROM ubat_table WHERE id_ubat=@ubat_id", conn)
        cmd.Parameters.AddWithValue("@ubat_id", TxtIdStock.Text)
        Dim Harga As Double = cmd.ExecuteScalar()
        conn.Close()

        Dim QuantityNow As String = SortedListTransaction(TxtIdStock.Text).ToString()

        Select Case QuantityNow
            Case >= Integer.Parse(TxtQuantity.Text)
                If TxtQuantity.Text = 0 Then
                    MessageBox.Show("Please enter valid quantity", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    If ArrayDeletedTransaction.Count > 0 Then
                        Dim y As Integer = 0
                        Transaction_Row = Integer.Parse(ArrayDeletedTransaction(0)) - 1
                        MessageBox.Show("ArrayDeletedTransaction: " & Transaction_Row)
                        ArrayDeletedTransaction.RemoveAt(0)
                    End If
                    If DataGridViewPOS.Rows.Count > 1 Then
                        'MessageBox.Show("While Transaction_Row: " & Transaction_Row & " =  ArrayTransactionList: " & ArrayTransactionList(Transaction_Row - 1))
                        If Not Transaction_Row = 0 Then
                            While Transaction_Row = ArrayTransactionList(Transaction_Row - 1)
                                'MessageBox.Show("While Transaction_Row: " & Transaction_Row & " =  ArrayTransactionList: " & ArrayTransactionList(Transaction_Row - 1))
                                Transaction_Row = (Integer.Parse(Transaction_Row) + 1)
                            End While
                        End If

                    End If
                    ArrayTransactionList.Add(Transaction_Row)
                    DataGridViewPOS.Rows.Insert(Transaction_Row, (Transaction_Row + 1), TxtIdStock.Text, TxtQuantity.Text, Harga.ToString("N2"), (Integer.Parse(TxtQuantity.Text) * Harga).ToString("N2"), Invoice_Id)
                    SortedListTransaction(TxtIdStock.Text) = QuantityNow - Integer.Parse(TxtQuantity.Text)
                    Transaction_Row = (Integer.Parse(Transaction_Row) + 1)
                End If
            Case = 0
                MessageBox.Show("Ubat telah kehabisan stock", "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Case Else
                MessageBox.Show("Kekurangan stok ubat untuk meneruskan transaksi" & Environment.NewLine & "Sebanyak " & QuantityNow & " ubat sahaja yang tinggal.", "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Select
    End Sub

    Private Sub DelTransaction()
        If DataGridViewPOS.SelectedRows.Count = 1 Then
            If DialogResult.Yes = MessageBox.Show("Are you sure to delete this transaction?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) Then
                MessageBox.Show(Selected_Id_Transaction)
                Dim QuantityNow As String = SortedListTransaction(Selected_Id_Transaction).ToString()
                SortedListTransaction(Selected_Id_Transaction) = Integer.Parse(QuantityNow) + Integer.Parse(DataGridViewPOS.SelectedRows.Item(0).Cells(2).Value)
                With DataGridViewPOS
                    .Rows.Remove(.SelectedRows(0))
                End With
                ArrayTransactionList.Remove(Integer.Parse(DataGridViewPOS.SelectedRows.Item(0).Cells(0).Value) - 1)
                MessageBox.Show(Integer.Parse(DataGridViewPOS.SelectedRows.Item(0).Cells(0).Value) - 1)
                ArrayDeletedTransaction.Add(Integer.Parse(DataGridViewPOS.SelectedRows.Item(0).Cells(0).Value) - 1)
            End If
        Else
            MessageBox.Show("Please select your transaction!")
        End If
    End Sub

    Private Sub CompleteInvoice()
        Dim TotalAmount As Double = 0

        Call Connect()

        For Each transaction As KeyValuePair(Of String, String) In SortedListTransaction
            cmd = New MySqlCommand("UPDATE ubat_table SET quantity=@quantity WHERE id_ubat=@ubat_id", conn)
            cmd.Parameters.AddWithValue("@ubat_id", transaction.Key)
            cmd.Parameters.AddWithValue("@quantity", transaction.Value)
            cmd.ExecuteNonQuery()
        Next

        For Each row As DataGridViewRow In DataGridViewPOS.Rows()
            cmd = New MySqlCommand("INSERT INTO transaction_details_table(ubat_id, quantity, price, totalAmount, invoice_id) VALUES(@ubat_id, @quantity, @price, @totalAmount, @invoice_id)", conn)
            cmd.Parameters.AddWithValue("@ubat_id", row.Cells(1).Value)
            cmd.Parameters.AddWithValue("@quantity", row.Cells(2).Value)
            cmd.Parameters.AddWithValue("@price", row.Cells(3).Value)
            cmd.Parameters.AddWithValue("@totalAmount", row.Cells(4).Value)
            cmd.Parameters.AddWithValue("@invoice_id", row.Cells(5).Value)
            TotalAmount += row.Cells(4).Value
            cmd.ExecuteNonQuery()
        Next

        With PrintPreviewDialog
            .Document = PrintDocument
            .ShowDialog()
        End With

        CreateNewInvoice(TotalAmount)

        conn.Close()

    End Sub

    Private Sub PcBoxEmployee_Click(sender As Object, e As EventArgs) Handles PcBoxEmployee.Click
        With EmployeeManagementForm
            .Show()
            .Location = Me.Location
            Me.Hide()
        End With
    End Sub

    Private Sub PcBoxStock_Click(sender As Object, e As EventArgs) Handles PcBoxStock.Click
        With StockManagementForm
            .Show()
            .Location = Me.Location
            Me.Hide()
        End With
    End Sub

    Private Sub TxtIdStock_MouseClick(sender As Object, e As MouseEventArgs) Handles TxtIdStock.MouseClick
        With SelectUbatForm
            .Show()
            .Location = Me.Location
        End With
    End Sub

    Private Function GenerateUUID()
        Dim UUID As String = String.Empty
        For I As Integer = 0 To 5
            UUID += GenerateLetter()
        Next
        For I As Integer = 0 To 5
            UUID += GenerateNumber()
        Next
        Return UUID
    End Function

    Private Function GenerateLetter()
        Static Dim rd As System.Random = New System.Random(System.DateTime.Now.Second)
        Dim RandomChar As Char = Chr(rd.Next(65, 90))
        Return RandomChar
    End Function

    Private Function GenerateNumber()
        Static Dim rd As Random = New Random(System.DateTime.Now.Second)
        Return rd.Next(0, 9).ToString()
    End Function

    Private Sub MainPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case LoginForm.rank
            Case 1
                PcBoxSales.Visible = True
            Case 2
                PcBoxEmployee.Visible = True
                PcBoxSales.Visible = True
                PcBoxStock.Visible = True
            Case Else

        End Select

        Invoice_Id = GenerateUUID()
        TransactionDataLoad()
    End Sub

    Private Sub MainPanel_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        LoginForm.Close()
    End Sub

    Private Sub TransactionDataLoad()
        With DataGridViewPOS
            .DataSource = Nothing
            .Rows.Clear()
            .ColumnCount = 6

            .Columns(0).HeaderText = "Transaction Number"
            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns(1).HeaderText = "ID Ubat"
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns(2).HeaderText = "Quantity"
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns(3).HeaderText = "Harga"
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns(4).HeaderText = "Harga Keseluruhan"
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns(5).HeaderText = "ID Invoice"
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
    End Sub

    Private Sub DataGridViewPOS_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewPOS.CellClick
        Selected_Id_Transaction = DataGridViewPOS.SelectedRows.Item(0).Cells(1).Value
    End Sub

    Private Sub BtnDeleteOrder_Click(sender As Object, e As EventArgs) Handles BtnDeleteOrder.Click
        DelTransaction()
    End Sub

    Private Sub PcBoxSales_Click(sender As Object, e As EventArgs) Handles PcBoxSales.Click
        With SalesForm
            .Show()
            .Location = Me.Location
            Me.Hide()
        End With
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        With LoginForm
            .Show()
            .Location = Me.Location
            Me.Close()
        End With
    End Sub

    Private Sub PrintDocument_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument.PrintPage

        Dim PrintFont As New Font("Arial", 12, FontStyle.Regular)
        Dim HeadingFont As New Font("Arial", 14, FontStyle.Bold)
        Dim LineHeightSingle As Single = PrintFont.GetHeight + 2
        Dim ColumnHorizontalLocationSingle As Single = e.MarginBounds.Left
        Dim VerticalHorizontalLocationSingle As Single = e.MarginBounds.Top
        Dim Column2HorizontalLocationSingle As Single = 300
        Dim Column3HorizontalLocationSingle As Single
        Dim PrintLineString As String
        Dim FontSizeF As New SizeF
        Dim FormattedPriceString As String

        ' Set up and display heading lines.
        PrintLineString = "Sistem Farmasi Radja"
        e.Graphics.DrawString(PrintLineString, HeadingFont, Brushes.Black, Column2HorizontalLocationSingle, VerticalHorizontalLocationSingle)

        PrintLineString = "Invoice ID: " & Invoice_Id
        VerticalHorizontalLocationSingle += LineHeightSingle

        e.Graphics.DrawString(PrintLineString, HeadingFont, Brushes.Black, Column2HorizontalLocationSingle, VerticalHorizontalLocationSingle)

        VerticalHorizontalLocationSingle += LineHeightSingle * 2

        For Each row As DataGridViewRow In DataGridViewPOS.Rows()

            ' Ubat Id
            e.Graphics.DrawString(row.Cells(1).Value, PrintFont, Brushes.Black, ColumnHorizontalLocationSingle, VerticalHorizontalLocationSingle)

            ' Type.
            e.Graphics.DrawString(row.Cells(2).Value, PrintFont, Brushes.Black, Column2HorizontalLocationSingle, VerticalHorizontalLocationSingle)

            ' Measure string in this font.
            FontSizeF = e.Graphics.MeasureString(row.Cells(4).Value, PrintFont)
            ' Subtract width of string from column position.
            Column3HorizontalLocationSingle = 550 - FontSizeF.Width

            e.Graphics.DrawString(row.Cells(4).Value, PrintFont, Brushes.Black, Column3HorizontalLocationSingle, VerticalHorizontalLocationSingle)

            ' Increment the Y position for the next lime; Double space.
            VerticalHorizontalLocationSingle += LineHeightSingle * 2

        Next

    End Sub

End Class