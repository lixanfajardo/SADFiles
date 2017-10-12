Imports MySql.Data.MySqlClient
Public Class LogInScreen
    Private md5hash As New MD5Hashing
    Private cmd As MySqlCommand
    Private reader As MySqlDataReader
    Private dt As DataTable

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles exit_btn.Click
        If MessageBox.Show("Do you want to exit the application?", "Exit Application.", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        If username_txt.Text = Nothing And password_txt.Text = Nothing Then
            MessageBox.Show("Please enter username/password.", "Input username/password.")
            Exit Sub
        ElseIf username_txt.Text = Nothing Then
            MessageBox.Show("Please enter username.", "Input username.")
            Exit Sub
        ElseIf password_txt.Text = Nothing Then
            MessageBox.Show("Please enter password.", "Input password.")
            Exit Sub
        End If

        'Load Data From Database
        Dim username As String = ""
        Dim enc_password As String = ""
        Dim password As String

        openConnection()
        Dim query As String = "SELECT * FROM tbl_user, tbl_employees WHERE tbl_user.employee_id = tbl_employees.employee_id AND tbl_user.user_userName = '" & username_txt.Text & "'"
        cmd = New MySqlCommand(query, con)
        reader = cmd.ExecuteReader

        While reader.Read
            username = reader.GetString("user_userName")
            enc_password = reader.GetString("user_password")
            Constants.uFirstName = reader.GetString("employee_firstName")
            Constants.uLastName = reader.GetString("employee_lastName")
            Constants.uPosition = reader.GetString("employee_position")
        End While
        password = md5hash.Decrypt(enc_password, Constants.MD5key)
        reader.Close()

        If username_txt.Text = username And password_txt.Text = password Then
            MessageBox.Show("Welcome " & Constants.uPosition & ": " & Constants.uFirstName & "!", "Welcome.")

            clearFields()
            closeConnection()

            Dim splash As New SplashScreen1
            splash.Show()

            Me.Hide()
        Else
            MessageBox.Show("Incorrect username/password. Access Denied.", "Access Denied.")
            Exit Sub
        End If

    End Sub
    Private Sub clearFields()
        username_txt.Clear()
        password_txt.Clear()
    End Sub

    Private Sub username_txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles username_txt.KeyPress, password_txt.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            Button1_Click_1(sender, e)
        End If
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Escape) Then
            Button1_Click(sender, e)
        End If
    End Sub

End Class