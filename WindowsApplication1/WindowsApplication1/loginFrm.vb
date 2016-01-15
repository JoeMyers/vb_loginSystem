Public Class loginFrm
    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        If usernameTextbox.Text = "" Or passwordTextbox.Text = "" Then
            MessageBox.Show("The username or password entered is incorrect. Please try again.", "Auth Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            ' Connect to DB
            Dim conn As New System.Data.OleDb.OleDbConnection()
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\loginsystem.accdb"

            Try
                Dim Sql As String = "SELECT * FROM users WHERE username='" + usernameTextbox.Text & "' AND password = '" + passwordTextbox.Text + "'"
                Dim sqlCom As New System.Data.OleDb.OleDbCommand(Sql)

                ' Open Database Connection
                sqlCom.Connection = conn
                conn.Open()

                Dim sqlRead As System.Data.OleDb.OleDbDataReader = sqlCom.ExecuteReader()

                If sqlRead.Read() Then
                    ' What to do if the login is a success e.g form1.Show()
                    MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    ' Error message
                    MessageBox.Show("The username or password entered is incorrect. Please try again.", "Auth Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    ' Clears textboxes
                    usernameTextbox.Text = ""
                    passwordTextbox.Text = ""
                    usernameTextbox.Select()

                End If
            Catch ex As Exception
                MessageBox.Show("Unfortunately, the database is unaccessable. Please try again later or contact for help. The error message that was produced is: " + ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If

        usernameTextbox.Text = ""
        passwordTextbox.Text = ""
    End Sub

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Me.Close()
    End Sub
End Class