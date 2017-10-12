Imports MySql.Data.MySqlClient
Public Module SqlConnection

    Private openFile As New FileHandling
    Private conn As MySqlConnection

    Private Function getConnectionString() As String

        Dim connString As String = Nothing
        Dim filepath As String = Constants.folderPath & Constants.fileName

        connString = openFile.readFile(filepath)
        Return connString
    End Function

    Private Function connectoDB() As MySqlConnection
        Return New MySqlConnection(getConnectionString)
    End Function

    Public Function openConnection()
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            Return con.State
        Catch ex As Exception
            MsgBox("Failed to connect MySQL Database. Please check if MySQL server is open. Application will now exit.")
        End Try
    End Function
    Public Function closeConnection()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Return con.State
    End Function

    Public con As MySqlConnection = connectoDB()

End Module
