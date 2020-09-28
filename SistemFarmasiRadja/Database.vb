Imports MySql.Data.MySqlClient

Module Database
    Public da As MySqlDataAdapter
    Public dr As MySqlDataReader
    Public cmd As MySqlCommand
    Public conn As MySqlConnection

    Public sql As String

    Public Sub Connect()
        Try
            conn = New MySqlConnection("server=localhost;user id=root;database=sistemfarmasi")
            If conn.State = ConnectionState.Closed Then conn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Kegagalan Database", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Module