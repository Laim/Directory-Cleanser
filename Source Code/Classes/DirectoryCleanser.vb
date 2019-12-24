Public Class DirectoryCleanser

    Public Shared LogPath As String = Environment.CurrentDirectory + "\Logs\"
    Public Shared DeleteLogFile As String = LogPath + "DeleteLog-" + Now.ToString("yyyy-MM-dd") + ".log"
    Public Shared MoveLogFile As String = LogPath + "MoveLog-" + Now.ToString("yyyy-MM-dd") + ".log"

    Public Shared Function DirFileCount(ByVal DirPath As String, ByVal FileType As String)
        Dim Counter As Integer = 0
        For Each item As IO.FileInfo In New IO.DirectoryInfo(DirPath).GetFiles()
            If item.Extension = "." + FileType Or FileType = "" Then
                Counter += 1
            End If
        Next

        Return Counter.ToString
    End Function
End Class
