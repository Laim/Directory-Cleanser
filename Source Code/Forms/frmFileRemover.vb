Imports Directory_Cleanser.DirectoryCleanser
Public Class frmFileRemover
    Private Sub btnDirectoryBrowser_Click(sender As Object, e As EventArgs) Handles btnDirectoryBrowser.Click
        Try
            If (FolderBrowserDialog.ShowDialog() = DialogResult.OK) Then
                txtDirectory.Text = FolderBrowserDialog.SelectedPath
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnFileTypeHelp_Click(sender As Object, e As EventArgs) Handles btnFileTypeHelp.Click
        MsgBox("You only need to enter the filetype here, I.E txt NOT .txt.  If left blank, this will affect all files in the folder.", MsgBoxStyle.Information, "File Type Help")
    End Sub

    Private Sub btnDate_Click(sender As Object, e As EventArgs) Handles btnDate.Click
        MsgBox("Delete files older than X days. To remove all files in a folder, enter -1", MsgBoxStyle.Information, "File Type Help")
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Try
            For Each file As IO.FileInfo In New IO.DirectoryInfo(txtDirectory.Text).GetFiles()
                If (Now - file.CreationTime).Days > txtDate.Text Then

                    If file.Extension = "." + txtFileType.Text Or txtFileType.Text = "" Then
                        file.Delete()
                    End If

                    IO.File.AppendAllText(DeleteLogFile, Now.ToString("yyyy-MM-dd HH:mm:ss") + " : " + file.Name.ToString + " has been deleted." + vbCrLf)
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Function RemoveLog(ByVal FileName As String)
        Return Now.ToString("yyyy-MM-dd").ToString + ": " + FileName + " has been deleted." + vbCrLf
    End Function

    Private Sub btnGenerateStats_Click(sender As Object, e As EventArgs) Handles btnGenerateStats.Click
        Try
            txtFolderStats.Text = ""
            txtFolderStats.Text = txtFolderStats.Text + "Directry File Count : " + DirFileCount(txtDirectory.Text, txtFileType.Text).ToString + vbCrLf
            txtFolderStats.Text = txtFolderStats.Text + "Directory File Size : " + DirFileSize(txtDirectory.Text, txtFileType.Text).ToString + " bytes" + vbCrLf
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If IO.Directory.Exists(LogPath) = False Then
                IO.Directory.CreateDirectory(LogPath)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub frmFileRemover_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmMain.Show()
    End Sub
End Class
