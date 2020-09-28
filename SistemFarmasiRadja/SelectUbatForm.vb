Imports MySql.Data.MySqlClient

Public Class SelectUbatForm

    Private Sub SelectUbatForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StockDataLoad()
    End Sub

    Private Sub StockDataLoad()
        With DataGridViewStock
            .DataSource = Nothing
            .Rows.Clear()
            .ColumnCount = 9

            .Columns(0).HeaderText = "ID Ubat"
            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns(1).HeaderText = "Quantity"
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns(2).HeaderText = "Nama Ubat"
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns(3).HeaderText = "Harga Ubat"
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns(4).HeaderText = "Pembekal"
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns(5).HeaderText = "Alamat Pembekal"
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns(6).HeaderText = "No Telefon"
            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns(7).HeaderText = "Modified_at"
            .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns(8).HeaderText = "Created_at"
            .Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(8).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With

        Call Connect()

        Dim ds As New DataSet
        Dim cmd = New MySqlCommand("SELECT * FROM ubat_table", conn)
        Dim da As New MySqlDataAdapter(cmd)
        Dim rowsCount As Integer
        da.Fill(ds, "ubat_table")
        rowsCount = ds.Tables("ubat_table").Rows.Count
        conn.Close()

        If rowsCount < 1 Then
            MessageBox.Show("There is no records", "No Employee Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ds.Reset()
        Else
            DataGridViewStock.Rows.Add(rowsCount)
            For i As Integer = 0 To rowsCount - 1
                With DataGridViewStock
                    .Rows(i).Cells(0).Value = ds.Tables("ubat_table").Rows(i).Item("id_ubat")
                    .Rows(i).Cells(1).Value = ds.Tables("ubat_table").Rows(i).Item("quantity")
                    .Rows(i).Cells(2).Value = ds.Tables("ubat_table").Rows(i).Item("nama_ubat")
                    .Rows(i).Cells(3).Value = ds.Tables("ubat_table").Rows(i).Item("harga_ubat")
                    .Rows(i).Cells(4).Value = ds.Tables("ubat_table").Rows(i).Item("pembekal")
                    .Rows(i).Cells(5).Value = ds.Tables("ubat_table").Rows(i).Item("alamat_pembekal")
                    .Rows(i).Cells(6).Value = ds.Tables("ubat_table").Rows(i).Item("no_telefon")
                    .Rows(i).Cells(7).Value = ds.Tables("ubat_table").Rows(i).Item("modified_at")
                    .Rows(i).Cells(8).Value = ds.Tables("ubat_table").Rows(i).Item("created_at")
                End With
            Next
        End If
    End Sub

    Private Sub SearchStockDataLoad()
        With DataGridViewStock
            .DataSource = Nothing
            .Rows.Clear()
            .ColumnCount = 9

            .Columns(0).HeaderText = "ID Ubat"
            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns(1).HeaderText = "Quantity"
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns(2).HeaderText = "Nama Ubat"
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns(3).HeaderText = "Harga Ubat"
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns(4).HeaderText = "Pembekal"
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns(5).HeaderText = "Alamat Pembekal"
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns(6).HeaderText = "No Telefon"
            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns(7).HeaderText = "Modified_at"
            .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns(8).HeaderText = "Created_at"
            .Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(8).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With

        Call Connect()

        Dim ds As New DataSet
        Dim cmd = New MySqlCommand("SELECT * FROM ubat_table WHERE nama_ubat LIKE @nama_ubat", conn)
        cmd.Parameters.AddWithValue("@nama_ubat", TxtSearch.Text & "%")
        Dim da As New MySqlDataAdapter(cmd)
        Dim rowsCount As Integer
        da.Fill(ds, "ubat_table")
        rowsCount = ds.Tables("ubat_table").Rows.Count
        conn.Close()

        If rowsCount < 1 Then
            MessageBox.Show("There is no records", "No Employee Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ds.Reset()
        Else
            DataGridViewStock.Rows.Add(rowsCount)
            For i As Integer = 0 To rowsCount - 1
                With DataGridViewStock
                    .Rows(i).Cells(0).Value = ds.Tables("ubat_table").Rows(i).Item("id_ubat")
                    .Rows(i).Cells(1).Value = ds.Tables("ubat_table").Rows(i).Item("quantity")
                    .Rows(i).Cells(2).Value = ds.Tables("ubat_table").Rows(i).Item("nama_ubat")
                    .Rows(i).Cells(3).Value = ds.Tables("ubat_table").Rows(i).Item("harga_ubat")
                    .Rows(i).Cells(4).Value = ds.Tables("ubat_table").Rows(i).Item("pembekal")
                    .Rows(i).Cells(5).Value = ds.Tables("ubat_table").Rows(i).Item("alamat_pembekal")
                    .Rows(i).Cells(6).Value = ds.Tables("ubat_table").Rows(i).Item("no_telefon")
                    .Rows(i).Cells(7).Value = ds.Tables("ubat_table").Rows(i).Item("modified_at")
                    .Rows(i).Cells(8).Value = ds.Tables("ubat_table").Rows(i).Item("created_at")
                End With
            Next
        End If
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        If TxtSearch.Text = String.Empty Then
            StockDataLoad()
        Else
            SearchStockDataLoad()
        End If

    End Sub

    Private Sub DataGridViewStock_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewStock.CellClick
        MainPanel.TxtIdStock.Text = DataGridViewStock.SelectedRows.Item(0).Cells(0).Value
        Me.Close()
    End Sub

    Private Sub SelectUbatForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        With MainPanel
            .Show()
            .Location = Me.Location
        End With
    End Sub

End Class