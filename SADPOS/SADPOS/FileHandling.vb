Imports System.IO

Public Class FileHandling

    Public Sub writeFile(ByVal path As String, ByVal text As String)
        If Not IO.Directory.Exists(Constants.folderPath) Then
            Directory.CreateDirectory(Constants.folderPath)
        End If
        If File.Exists(path) Then
            File.Delete(path)
        End If

        Dim filestream As New FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite)

        Dim writer As New StreamWriter(filestream)
        writer.WriteLine(text)
        writer.Close()

        Console.WriteLine("File write complete.")
    End Sub

    Public Function readFile(ByVal path As String)
        Dim filestream As New FileStream(path, FileMode.Open, FileAccess.Read)
        Dim reader As New StreamReader(filestream)
        Dim reads As String = reader.ReadLine()
        reader.Close()
        Return reads
    End Function
End Class
