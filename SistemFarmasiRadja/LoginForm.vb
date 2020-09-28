Imports MySql.Data.MySqlClient

Public Class LoginForm
    Public rank As Integer

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Try
            If TxtUsername.Text = String.Empty Then
                Throw New Exception("Please do not leave Username blank")
            ElseIf TxtPassword.Text = String.Empty Then
                Throw New Exception("Please do not leave Password blank")
            Else
                ValidateLogin()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Public Sub ValidateLogin()
        Call Connect()

        cmd = New MySqlCommand("SELECT * FROM user_table WHERE username=@username AND password=@password", conn)
        cmd.Parameters.AddWithValue("@username", TxtUsername.Text)
        cmd.Parameters.AddWithValue("@password", TxtPassword.Text)
        Dim dr As MySqlDataReader = cmd.ExecuteReader()

        If dr.HasRows() Then
            dr.Close()
            cmd = New MySqlCommand("SELECT rank FROM user_table WHERE username=@username", conn)
            cmd.Parameters.AddWithValue("@username", TxtUsername.Text)
            rank = cmd.ExecuteScalar()

            With MainPanel
                .Show()
                .Location = Me.Location
                Me.Hide()
            End With

        End If

        conn.Close()
    End Sub

    Private Sub PcBoxAdmin_Click(sender As Object, e As EventArgs)
        With MainPanel
            .Show()
            .Location = Me.Location
            Me.Hide()
        End With
    End Sub

End Class