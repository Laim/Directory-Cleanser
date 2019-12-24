Public Class frmMain
    Private Sub lblInfo_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblInfo.LinkClicked
        Process.Start("https://github.com/Laim/Directory-Cleanser")
    End Sub

    Private Sub btnFileRemover_Click(sender As Object, e As EventArgs) Handles btnFileRemover.Click
        frmFileRemover.Show()
        Close()
    End Sub

    Private Sub btnFileMover_Click(sender As Object, e As EventArgs) Handles btnFileMover.Click
        frmFileMover.Show()
        Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblVersion.Text = "Version " + Application.ProductVersion
    End Sub
End Class