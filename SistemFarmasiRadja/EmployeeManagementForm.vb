Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Public Class EmployeeManagementForm
    Public kadPengenalan As String
    Private Edit = False

    Private Sub EmployeeManagementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CleanDataGridViewEmployee()
    End Sub

    Private Sub CleanDataGridViewEmployee()
        With DataGridViewEmployee
            .DataSource = Nothing
            .Rows.Clear()
            .ColumnCount = 10

            .Columns(0).HeaderText = "Kad Pengenalan"
            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns(1).HeaderText = "Umur"
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns(2).HeaderText = "Nama Pekerja"
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns(3).HeaderText = "Alamat"
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns(4).HeaderText = "Nombor Telefon"
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns(5).HeaderText = "Username"
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns(6).HeaderText = "Password"
            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns(7).HeaderText = "Created_at"
            .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns(8).HeaderText = "Modified_at"
            .Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(8).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
        LoadEmployeeData()
        Switch()
    End Sub

    Public Sub LoadEmployeeData()
        Call Connect()

        Dim ds As New DataSet
        Dim cmd = New MySqlCommand("SELECT * FROM user_table WHERE rank = 1", conn)
        Dim da As New MySqlDataAdapter(cmd)
        Dim rowsCount As Integer
        da.Fill(ds, "user_table")
        rowsCount = ds.Tables("user_table").Rows.Count
        conn.Close()

        If rowsCount < 1 Then
            MessageBox.Show("There is no records", "No Employee Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ds.Reset()
        Else
            DataGridViewEmployee.Rows.Add(rowsCount)
            For i As Integer = 0 To rowsCount - 1
                With DataGridViewEmployee
                    .Rows(i).Cells(0).Value = ds.Tables("user_table").Rows(i).Item("kad_pengenalan")
                    .Rows(i).Cells(1).Value = ds.Tables("user_table").Rows(i).Item("umur")
                    .Rows(i).Cells(2).Value = ds.Tables("user_table").Rows(i).Item("nama_pekerja")
                    .Rows(i).Cells(3).Value = ds.Tables("user_table").Rows(i).Item("alamat")
                    .Rows(i).Cells(4).Value = ds.Tables("user_table").Rows(i).Item("nombor_telefon")
                    .Rows(i).Cells(5).Value = ds.Tables("user_table").Rows(i).Item("username")
                    .Rows(i).Cells(6).Value = ds.Tables("user_table").Rows(i).Item("password")
                    .Rows(i).Cells(7).Value = ds.Tables("user_table").Rows(i).Item("created_at")
                    .Rows(i).Cells(8).Value = ds.Tables("user_table").Rows(i).Item("modified_at")
                End With
            Next
        End If

    End Sub

    Private Sub BtnAgree_Click(sender As Object, e As EventArgs) Handles BtnAgree.Click
        If Edit Then
            Try
                If TxtKadPengenalan.Text = String.Empty Or TxtUmur.Text = String.Empty Or TxtNamaPekerja.Text = String.Empty Or TxtAlamat.Text = String.Empty Or TxtNoTelefon.Text = String.Empty Or TxtUsername.Text = String.Empty Or TxtPassword.Text = String.Empty Then
                    Throw New Exception("Please do not leave any input blank")
                ElseIf Not TxtKadPengenalan.MaskFull Then
                    Throw New Exception("Please enter kad pengenalan carefully")
                ElseIf Not TxtNoTelefon.MaskFull Then
                    Throw New Exception("Please enter employee's Number Phone carefully")
                Else
                    EditEmployee()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Edit Employee Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Finally
                CleanDataGridViewEmployee()
            End Try
        Else
            Try
                If TxtKadPengenalan.Text = String.Empty Or TxtUmur.Text = String.Empty Or TxtNamaPekerja.Text = String.Empty Or TxtAlamat.Text = String.Empty Or TxtNoTelefon.Text = String.Empty Or TxtUsername.Text = String.Empty Or TxtPassword.Text = String.Empty Then
                    Throw New Exception("Please do not leave any input blank")
                ElseIf Not TxtKadPengenalan.MaskFull Then
                    Throw New Exception("Please enter kad pengenalan carefully")
                ElseIf Not TxtNoTelefon.MaskFull Then
                    Throw New Exception("Please enter employee's Number Phone carefully")
                Else
                    InsertNewEmployee()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Add Employee Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Finally
                CleanDataGridViewEmployee()
            End Try
        End If
    End Sub

    Private Sub InsertNewEmployee()
        Dim Duplicate As Boolean = False
        Call Connect()

        cmd = New MySqlCommand("SELECT kad_pengenalan FROM user_table WHERE kad_pengenalan=@kad_pengenalan", conn)
        cmd.Parameters.AddWithValue("@kad_pengenalan", TxtKadPengenalan.Text)
        Dim dr As MySqlDataReader = cmd.ExecuteReader()

        If Not dr.HasRows() Then
            cmd = New MySqlCommand("INSERT INTO user_table(kad_pengenalan, umur, nama_pekerja, alamat, nombor_telefon, username, password) VALUES(@kad_pengenalan, @umur, @nama_pekerja, @alamat, @nombor_telefon, @username, @password)", conn)
            cmd.Parameters.AddWithValue("@kad_pengenalan", TxtKadPengenalan.Text)
            cmd.Parameters.AddWithValue("@umur", TxtUmur.Text)
            cmd.Parameters.AddWithValue("@nama_pekerja", TxtNamaPekerja.Text)
            cmd.Parameters.AddWithValue("@alamat", TxtAlamat.Text)
            cmd.Parameters.AddWithValue("@nombor_telefon", TxtNoTelefon.Text)
            cmd.Parameters.AddWithValue("@username", TxtUsername.Text)
            cmd.Parameters.AddWithValue("@password", TxtPassword.Text)

            If DialogResult.Yes = MessageBox.Show("Are you sure you want to edit this data?", "Confirmation Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
                If cmd.ExecuteNonQuery() Then
                    MessageBox.Show("Data Pekerja Telah Berjaya Dimasukkan", "Add Employee Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Data Pekerja Tidak Berjaya Dimasukkan", "Add Employee Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        Else
            MessageBox.Show("Data Pekerja Tersenarai Di Database", "Duplicate Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        conn.Close()
    End Sub

    Private Sub EditEmployee()
        Call Connect()
        cmd = New MySqlCommand("UPDATE user_table SET kad_pengenalan=@kad_pengenalan, umur=@umur, nama_pekerja=@nama_pekerja, alamat=@alamat, nombor_telefon=@nombor_telefon, username=@username, password=@password, modified_at=@modified_at WHERE kad_pengenalan=@kad_pengenalan_for_req", conn)
        cmd.Parameters.AddWithValue("@kad_pengenalan_for_req", kadPengenalan)
        cmd.Parameters.AddWithValue("@kad_pengenalan", TxtKadPengenalan.Text)
        cmd.Parameters.AddWithValue("@umur", TxtUmur.Text)
        cmd.Parameters.AddWithValue("@nama_pekerja", TxtNamaPekerja.Text)
        cmd.Parameters.AddWithValue("@alamat", TxtAlamat.Text)
        cmd.Parameters.AddWithValue("@nombor_telefon", TxtNoTelefon.Text)
        cmd.Parameters.AddWithValue("@username", TxtUsername.Text)
        cmd.Parameters.AddWithValue("@password", TxtPassword.Text)
        cmd.Parameters.AddWithValue("@modified_at", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))

        If DialogResult.Yes = MessageBox.Show("Are you sure you want to edit this data?", "Confirmation Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
            If cmd.ExecuteNonQuery() Then
                MessageBox.Show("Data Pekerja Telah Berjaya Diubah", "Edit Employee Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Data Pekerja Tidak Berjaya Diubah", "Edit Employee Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If

        conn.Close()
    End Sub

    Private Sub BtnExitEditMode_Click(sender As Object, e As EventArgs) Handles BtnExitEditMode.Click
        Switch()
    End Sub

    Private Sub Switch()
        Edit = False
        BtnAgree.Text = "Add"
        BtnDelete.Text = "Clear"
        LblEditMode.Visible = False
        LblEditMode2.Visible = False
        BtnExitEditMode.Visible = False
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If Edit Then

            Call Connect()

            cmd = New MySqlCommand("DELETE FROM user_table WHERE kad_pengenalan=@kad_pengenalan", conn)
            cmd.Parameters.AddWithValue("@kad_pengenalan", kadPengenalan)

            If DialogResult.Yes = MessageBox.Show("Are you sure you want to delete this data?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
                If cmd.ExecuteNonQuery() Then
                    MessageBox.Show("Data the been deleted", "Delete Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearAllTextBox()
                Else
                    MessageBox.Show("Unable to delete the data", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

            End If
            conn.Close()
        Else
            ClearAllTextBox()
        End If
    End Sub

    Private Sub ClearAllTextBox()
        TxtKadPengenalan.Text = String.Empty
        TxtUmur.Text = String.Empty
        TxtNamaPekerja.Text = String.Empty
        TxtAlamat.Text = String.Empty
        TxtNoTelefon.Text = String.Empty
        TxtUsername.Text = String.Empty
        TxtPassword.Text = String.Empty
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Close()
    End Sub

    Private Sub DataGridViewEmployee_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewEmployee.CellContentClick
        If DataGridViewEmployee.SelectedRows.Count = 1 Then
            Call Connect()

            Dim dt As New DataTable
            Dim row As DataGridViewRow = DataGridViewEmployee.SelectedRows(0)

            kadPengenalan = DataGridViewEmployee.SelectedRows.Item(0).Cells(0).Value

            cmd = New MySqlCommand("SELECT kad_pengenalan, umur, nama_pekerja, alamat, nombor_telefon, username, password FROM user_table WHERE kad_pengenalan=@kad_pengenalan", conn)
            cmd.Parameters.AddWithValue("@kad_pengenalan", kadPengenalan)
            Dim da As New MySqlDataAdapter(cmd)
            da.Fill(dt)

            conn.Close()

            For Each column In dt.Rows()
                TxtKadPengenalan.Text = column(0).ToString()
                TxtUmur.Text = column(1).ToString()
                TxtNamaPekerja.Text = column(2).ToString()
                TxtAlamat.Text = column(3).ToString()
                TxtNoTelefon.Text = column(4).ToString()
                TxtUsername.Text = column(5).ToString()
                TxtPassword.Text = column(6).ToString()
            Next

            ' Changing into edit mode
            If TxtNamaPekerja.Text <> String.Empty Then
                Edit = True
                BtnAgree.Text = "Edit"
                BtnDelete.Text = "Delete"
                LblEditMode.Visible = True
                LblEditMode2.Visible = True
                BtnExitEditMode.Visible = True
            End If
        End If
    End Sub

    Private Sub EmployeeManagementForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        With MainPanel
            .Show()
            .Location = Me.Location
        End With
    End Sub

End Class