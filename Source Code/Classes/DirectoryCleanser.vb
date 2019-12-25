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

    Public Shared Function DirFileSize(ByVal DirPath As String, ByVal FileType As String)
        Dim FileSize As Integer = 0
        For Each item As IO.FileInfo In New IO.DirectoryInfo(DirPath).GetFiles()
            If item.Extension = "." + FileType Or FileType = "" Then
                FileSize += item.Length
            End If
        Next

        Return FileSize
    End Function

    Public Shared Function DirFileList(ByVal DirPath As String, ByVal FileType As String)
        ''Used for test purposes only
        Dim FileList As String = ""
        For Each item As IO.FileInfo In New IO.DirectoryInfo(DirPath).GetFiles()
            If item.Extension = "." + FileType Or FileType = "" Then
                FileList = FileList + item.Name + ","
            End If
        Next

        Return FileList.ToString
    End Function
End Class
