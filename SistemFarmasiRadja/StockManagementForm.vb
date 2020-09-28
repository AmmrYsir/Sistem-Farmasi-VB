Imports MySql.Data.MySqlClient

Public Class StockManagementForm
    Public Id_Ubat As String
    Private Edit As Boolean = False

    Private Sub StockManagementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StockDataLoad()
    End Sub

    Private Sub StockManagementForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        With MainPanel
            .Show()
            .Location = Me.Location
        End With
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

            .Columns(3).HeaderText = "Harga"
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

    Private Sub CleanAllTextBox()
        TxtIdUbat.Text = String.Empty
        TxtQuantity.Text = String.Empty
        TxtNamaUbat.Text = String.Empty
        TxtHarga.Text = String.Empty
        TxtPembekal.Text = String.Empty
        TxtAlamatPembekal.Text = String.Empty
        TxtNoTelefon.Text = String.Empty
    End Sub

    Private Sub Switch()
        Edit = False
        BtnExitEditMode.Visible = False
        LblEditMode.Visible = False
        LblEditMode2.Visible = False
        BtnDelete.Text = "Clear"
        BtnAgree.Text = "Add"
    End Sub

    Private Sub BtnExitEditMode_Click(sender As Object, e As EventArgs) Handles BtnExitEditMode.Click
        Switch()
    End Sub

    Private Sub BtnAgree_Click(sender As Object, e As EventArgs) Handles BtnAgree.Click
        If Edit Then
            Try
                If TxtIdUbat.Text = String.Empty Or TxtQuantity.Text = String.Empty Or TxtNamaUbat.Text = String.Empty Or TxtHarga.Text = String.Empty Or TxtPembekal.Text = String.Empty Or TxtAlamatPembekal.Text = String.Empty Or TxtNoTelefon.Text = String.Empty Then
                    Throw New Exception("Please do not leave blank input")
                ElseIf Not TxtIdUbat.MaskFull Or Not TxtNoTelefon.MaskFull Then
                    Throw New Exception("Please enter your ID Ubat Or No Telefon carefully")
                Else
                    EditStock()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Edit Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        Else
            Try
                If TxtIdUbat.Text = String.Empty Or TxtQuantity.Text = String.Empty Or TxtNamaUbat.Text = String.Empty Or TxtHarga.Text = String.Empty Or TxtPembekal.Text = String.Empty Or TxtAlamatPembekal.Text = String.Empty Or TxtNoTelefon.Text = String.Empty Then
                    Throw New Exception("Please do not leave blank input")
                ElseIf Not TxtIdUbat.MaskFull Or Not TxtNoTelefon.MaskFull Then
                    Throw New Exception("Please enter your ID Ubat Or No Telefon carefully")
                Else
                    AddStock()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Add Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If Edit Then
            Try
                DelStock()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Delete Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        Else
            CleanAllTextBox()
        End If
    End Sub

    Private Sub AddStock()
        Call Connect()
        cmd = New MySqlCommand("SELECT id_ubat from ubat_table WHERE id_ubat=@id_ubat", conn)
        cmd.Parameters.AddWithValue("@id_ubat", TxtIdUbat.Text)
        Dim dr As MySqlDataReader = cmd.ExecuteReader()

        If Not dr.HasRows() Then
            dr.Close()
            cmd = New MySqlCommand("INSERT INTO ubat_table(id_ubat, quantity, nama_ubat, harga_ubat, pembekal, alamat_pembekal, no_telefon) VALUES(@id_ubat, @quantity, @nama_ubat, @harga_ubat, @pembekal, @alamat_pembekal, @no_telefon)", conn)
            cmd.Parameters.AddWithValue("@id_ubat", TxtIdUbat.Text)
            cmd.Parameters.AddWithValue("@quantity", TxtQuantity.Text)
            cmd.Parameters.AddWithValue("@nama_ubat", TxtNamaUbat.Text)
            cmd.Parameters.AddWithValue("@harga_ubat", TxtHarga.Text)
            cmd.Parameters.AddWithValue("@pembekal", TxtPembekal.Text)
            cmd.Parameters.AddWithValue("@alamat_pembekal", TxtAlamatPembekal.Text)
            cmd.Parameters.AddWithValue("@no_telefon", TxtNoTelefon.Text)

            If cmd.ExecuteNonQuery() Then
                MessageBox.Show("Data telah berjaya dimasukkan", "Add Stock Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Data tidak berjaya dimasukkan", "Add Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Stock Already In the List", "Data Duplicate | Duplicatet ID Ubat", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        conn.Close()
        StockDataLoad()
    End Sub

    Private Sub EditStock()
        Call Connect()
        Dim Today As DateTime = DateTime.Now.ToShortDateString()

        If MessageBox.Show("Are you sure you want to edit this data?", "Confirmation Edit Stock", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            cmd = New MySqlCommand("UPDATE ubat_table SET id_ubat=@id_ubat, quantity=@quantity, nama_ubat=@nama_ubat, harga_ubat=@harga_ubat, pembekal=@pembekal, alamat_pembekal=@alamat_pembekal, no_telefon=@no_telefon, modified_at=@modified_at WHERE id_ubat=@id_ubat_req", conn)
            cmd.Parameters.AddWithValue("@id_ubat_req", Id_Ubat)
            cmd.Parameters.AddWithValue("@id_ubat", TxtIdUbat.Text)
            cmd.Parameters.AddWithValue("@quantity", TxtQuantity.Text)
            cmd.Parameters.AddWithValue("@nama_ubat", TxtNamaUbat.Text)
            cmd.Parameters.AddWithValue("@harga_ubat", TxtHarga.Text)
            cmd.Parameters.AddWithValue("@pembekal", TxtPembekal.Text)
            cmd.Parameters.AddWithValue("@alamat_pembekal", TxtAlamatPembekal.Text)
            cmd.Parameters.AddWithValue("@no_telefon", TxtNoTelefon.Text)
            cmd.Parameters.AddWithValue("@modified_at", Today)

            If cmd.ExecuteNonQuery() Then
                MessageBox.Show("Data telah berjaya diubah", "Stock Edit Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Data tidak berjaya diubah", "Stock Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
        End If

        Switch()
        CleanAllTextBox()

        conn.Close()
        StockDataLoad()
    End Sub

    Private Sub DelStock()
        Call Connect()

        If MessageBox.Show("Are you sure you want to delete this data?", "Confirmation Delete Stock", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            cmd = New MySqlCommand("DELETE FROM ubat_table WHERE id_ubat=@id_ubat_req", conn)
            cmd.Parameters.AddWithValue("@id_ubat_req", Id_Ubat)

            If cmd.ExecuteNonQuery() Then
                MessageBox.Show("Data telah berjaya dipadam", "Stock Delete Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Data tidak berjaya dipadam", "Stock Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If

        Switch()
        CleanAllTextBox()

        conn.Close()
        StockDataLoad()
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        With MainPanel
            .Show()
            .Location = Me.Location
            Me.Close()
        End With
    End Sub

    Private Sub DataGridViewStock_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewStock.CellContentClick
        If DataGridViewStock.SelectedRows.Count = 1 Then
            Call Connect()

            Dim dt As New DataTable
            Dim row As DataGridViewRow = DataGridViewStock.SelectedRows(0)

            Id_Ubat = DataGridViewStock.SelectedRows.Item(0).Cells(0).Value

            cmd = New MySqlCommand("SELECT * FROM ubat_table WHERE id_ubat=@id_ubat", conn)
            cmd.Parameters.AddWithValue("@id_ubat", Id_Ubat)
            Dim da As New MySqlDataAdapter(cmd)
            da.Fill(dt)

            conn.Close()

            For Each column In dt.Rows()
                TxtIdUbat.Text = column(0).ToString()
                TxtQuantity.Text = column(1).ToString()
                TxtNamaUbat.Text = column(2).ToString()
                TxtHarga.Text = column(3).ToString()
                TxtPembekal.Text = column(4).ToString()
                TxtAlamatPembekal.Text = column(5).ToString()
                TxtNoTelefon.Text = column(6).ToString()
            Next

            ' Changing into edit mode
            If TxtNamaUbat.Text <> String.Empty Then
                Edit = True
                BtnAgree.Text = "Edit"
                BtnDelete.Text = "Delete"
                LblEditMode.Visible = True
                LblEditMode2.Visible = True
                BtnExitEditMode.Visible = True
            End If
        End If
    End Sub

End Class