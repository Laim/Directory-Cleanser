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
        Dim FileSize As Int64 = 0
        For Each item As IO.FileInfo In New IO.DirectoryInfo(DirPath).GetFiles()
            If item.Extension = "." + FileType Or FileType = "" Then
                FileSize += item.Length
            End If
        Next

        Return FormatFileSize(FileSize)
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

    '' Credit: https://stackoverflow.com/a/39449400
    Public Shared Function FormatFileSize(ByVal lngFileSize As Long) As String

        Dim x As Int64 : x = 0
        Dim Suffix As String : Suffix = ""
        Dim Result As Single : Result = lngFileSize

        Do Until Int(Result) < 1000
            x = x + 1
            Result = Result / 1024
        Loop

        Result = Math.Round(Result, 2)

        Select Case x
            Case 0
                Suffix = "Bytes"
            Case 1 'KiloBytes
                Suffix = "KB"
            Case 2 'MegaBytes
                Suffix = "MB"
            Case 3 'GigaBytes
                Suffix = "GB"
            Case 4 'TeraBytes
                Suffix = "TB"
            Case 5 'PetaBytes
                Suffix = "PB"
            Case 6 'ExaBytes
                Suffix = "EB"
            Case 7 'ZettaBytes
                Suffix = "ZB"
            Case 8 'YottaBytes
                Suffix = "YB"
            Case Else
                Suffix = "Too big to compute :)"
        End Select

        FormatFileSize = Format(Result, "#,##0.00") & " " & Suffix

    End Function 'FormatFileSize
End Class
