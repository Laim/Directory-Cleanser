Imports System.ComponentModel
Imports Directory_Cleanser.DirectoryCleanser
Public Class frmFileMover

    Dim MaxMove As Integer

    Private Sub btnOldDirectoryBrowser_Click(sender As Object, e As EventArgs) Handles btnOldDirectoryBrowser.Click
        Try
            If (FolderBrowserDialog.ShowDialog() = DialogResult.OK) Then
                txtOldDirectory.Text = FolderBrowserDialog.SelectedPath
                FolderSanatize()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnNewDirectoryBrowser_Click(sender As Object, e As EventArgs) Handles btnNewDirectoryBrowser.Click
        Try
            If (FolderBrowserDialog.ShowDialog() = DialogResult.OK) Then
                txtNewDirectory.Text = FolderBrowserDialog.SelectedPath
                FolderSanatize()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Sub FolderSanatize()
        ''How does this work?  Why does this work?
        If txtOldDirectory.Text.EndsWith("\") = False And txtOldDirectory.Text = "" = False Then
            txtOldDirectory.Text = txtOldDirectory.Text + "\"
        End If
        If txtNewDirectory.Text.EndsWith("\") = False And txtNewDirectory.Text = "" = False Then
            txtNewDirectory.Text = txtNewDirectory.Text + "\"
        End If
    End Sub

    Private Sub frmFileMover_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        frmMain.Show()
    End Sub

    Private Sub btnGenerateStats_Click(sender As Object, e As EventArgs) Handles btnGenerateStats.Click
        Try
            txtFolderStats.Text = ""
            txtFolderStats.Text = "Old Directry File Count : " + DirFileCount(txtOldDirectory.Text, txtFileType.Text) + vbCrLf
            txtFolderStats.Text = txtFolderStats.Text + "Old Directory File Size : " + DirFileSize(txtOldDirectory.Text, txtFileType.Text).ToString + " bytes" + vbCrLf
            txtFolderStats.Text = txtFolderStats.Text + "New Directry Current File Count : " + DirFileCount(txtNewDirectory.Text, txtFileType.Text) + vbCrLf
            txtFolderStats.Text = txtFolderStats.Text + "New Directory Current File Size : " + DirFileSize(txtNewDirectory.Text, txtFileType.Text) + " bytes"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnMove_Click(sender As Object, e As EventArgs) Handles btnMove.Click
        Try

            '' Trust no one, not even your code
            FolderSanatize()

            If IO.Directory.Exists(txtOldDirectory.Text) = True And IO.Directory.Exists(txtNewDirectory.Text) Then
                MaxMove = DirFileCount(txtOldDirectory.Text, txtFileType.Text)

                If txtCountToMove.Text = "" Then
                    txtCountToMove.Text = MaxMove
                End If

                If txtCountToMove.Text > MaxMove Then
                    txtCountToMove.Text = MaxMove
                End If

                Dim Counter As Integer = 0

                For Each item As IO.FileInfo In New IO.DirectoryInfo(txtOldDirectory.Text).GetFiles()
                    If Counter < txtCountToMove.Text Then
                        If item.Extension = "." + txtFileType.Text Or txtFileType.Text = "" Then
                            item.MoveTo(txtNewDirectory.Text + item.Name)
                            Counter += 1
                            IO.File.AppendAllText(MoveLogFile, Now.ToString("yyyy-MM-dd HH:mm:ss") + " : " + item.Name.ToString + " has been moved" + vbCrLf)
                        End If
                    End If
                Next
            Else
                MsgBox("One of your directories does not exist", MsgBoxStyle.Critical)
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub txtCountToMove_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCountToMove.KeyPress

        'This just makes it so you can only input numbers, code from https://stackoverflow.com/a/9971500
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnFileTypeHelp_Click(sender As Object, e As EventArgs) Handles btnFileTypeHelp.Click
        MsgBox("You only need to enter the filetype here, I.E txt NOT .txt.  If left blank, this will affect all files in the folder.", MsgBoxStyle.Information, "File Type Help")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("This is the amount of files you want to move at once, if you enter a value higher than the amount of files in the folder or no value at all, it will move everything.", MsgBoxStyle.Information, "File Count Help")
    End Sub
End Class