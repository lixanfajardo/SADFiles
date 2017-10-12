Imports System.Environment
Public Class Constants

    Public Shared folderPath As String = Environment.GetFolderPath(SpecialFolder.ApplicationData) & "\MyApplication"
    Public Shared fileName As String = "\SAD.con"
    Public Shared MD5key As String = "lixan@GSW"
    Public Shared connectionString As String = ""
    Public Shared uFirstName As String = ""
    Public Shared uLastName As String = ""
    Public Shared uPosition As String = ""

End Class
