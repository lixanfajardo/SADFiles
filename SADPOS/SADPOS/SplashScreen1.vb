Imports MySql.Data.MySqlClient
Public NotInheritable Class SplashScreen1

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        ProgressBar1.Increment(1)

        If ProgressBar1.Value = 10 Then
            
            Label1.Text = "Getting SQL Connection..."
            SqlConnection.openConnection()
            If Not SqlConnection.con.State = ConnectionState.Open Then
                Label1.Text = "Fail to Get SQL Connection."
                Application.Exit()
            Else
                Label1.Text = "Get SQL Connection Success."
            End If
        End If

        If ProgressBar1.Value = 20 Then
            If SqlConnection.con.State = ConnectionState.Open Then
                closeConnection()
            End If
            Label1.Text = "Loading Other Components..."
        End If

        If ProgressBar1.Value = 100 Then
            If SqlConnection.con.State = ConnectionState.Open Then
                closeConnection()
            End If
            Label1.Text = "Finalizing..."
            Timer1.Stop()
            glass_timer.Stop()
            Dim main As New MainMenu2
            main.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub glass_timer_Tick(sender As Object, e As EventArgs) Handles glass_timer.Tick
        If Me.Opacity.ToString > 0 Then
            Me.Opacity = Me.Opacity.ToString + 0.05
        End If
    End Sub

    Private Sub SplashScreen1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        glass_timer.Start()

    End Sub

End Class
