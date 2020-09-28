Imports System.Xml
Imports MySql.Data.MySqlClient

Public Class SalesForm

    Private Sub SalesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtSearchInvoice.Focus()
        SaleStatistic()
    End Sub

    Private Sub SalesForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        With MainPanel
            .Show()
            .Location = Me.Location
        End With
    End Sub

    Private Sub SaleStatistic()
        Call Connect()
        Dim totalInvoice As Integer
        Dim totalProfit As Double
        cmd = New MySqlCommand("SELECT COUNT(*) FROM invoice_table", conn)
        totalInvoice = cmd.ExecuteScalar()
        cmd = New MySqlCommand("SELECT totalAmount FROM invoice_table", conn)
        Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable
        da.Fill(dt)

        For Each row As DataRow In dt.Rows()
            totalProfit += row.Item(0)
        Next

        conn.Close()

        TxtTotalInvoice.Text = totalInvoice
        TxtTotalProfit.Text = totalProfit.ToString("C2")

    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Close()
    End Sub

    Private Sub DataGridViewReload()
        With DataGridViewTransaction
            .DataSource = Nothing
            .Rows.Clear()
            .ColumnCount = 5

            .Columns(0).HeaderText = "Transc. ID"
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
        End With
    End Sub

    Private Sub BtnSearchInvoice_Click(sender As Object, e As EventArgs) Handles BtnSearchInvoice.Click
        If TxtSearchInvoice.Text <> "" Then
            DataGridViewReload()

            Dim iteration As Integer = 0
            Dim dt As DataTable = New DataTable
            If TxtSearchInvoice.Text <> String.Empty Then
                Call Connect()
                cmd = New MySqlCommand("SELECT * FROM transaction_details_table WHERE invoice_id=@invoice_id", conn)
                cmd.Parameters.AddWithValue("@invoice_id", TxtSearchInvoice.Text)
                Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                da.Fill(dt)
                conn.Close()
            Else
                DataGridViewTransaction.Rows.Clear()
            End If

            For Each row As DataRow In dt.Rows()
                DataGridViewTransaction.Rows.Insert(iteration, row.Item("id"), row.Item("ubat_id"), row.Item("quantity"), row.Item("price"), row.Item("totalAmount"))
                iteration += 1
            Next
        End If
    End Sub

    Private Sub DataGridViewTransaction_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewTransaction.CellContentClick
        If DataGridViewTransaction.SelectedRows.Count <> 0 Then

        End If
    End Sub

End Class