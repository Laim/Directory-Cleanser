<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFileMover
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFileMover))
        Me.btnOldDirectoryBrowser = New System.Windows.Forms.Button()
        Me.txtOldDirectory = New System.Windows.Forms.TextBox()
        Me.lblOldDirectory = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.lblNewDirectory = New System.Windows.Forms.Label()
        Me.txtNewDirectory = New System.Windows.Forms.TextBox()
        Me.btnNewDirectoryBrowser = New System.Windows.Forms.Button()
        Me.gbFolderStats = New System.Windows.Forms.GroupBox()
        Me.txtFolderStats = New System.Windows.Forms.TextBox()
        Me.btnGenerateStats = New System.Windows.Forms.Button()
        Me.btnMove = New System.Windows.Forms.Button()
        Me.btnFileTypeHelp = New System.Windows.Forms.Button()
        Me.txtFileType = New System.Windows.Forms.TextBox()
        Me.lblFileType = New System.Windows.Forms.Label()
        Me.txtCountToMove = New System.Windows.Forms.TextBox()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.gbFolderStats.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOldDirectoryBrowser
        '
        Me.btnOldDirectoryBrowser.Location = New System.Drawing.Point(369, 10)
        Me.btnOldDirectoryBrowser.Name = "btnOldDirectoryBrowser"
        Me.btnOldDirectoryBrowser.Size = New System.Drawing.Size(25, 23)
        Me.btnOldDirectoryBrowser.TabIndex = 5
        Me.btnOldDirectoryBrowser.Text = "..."
        Me.btnOldDirectoryBrowser.UseVisualStyleBackColor = True
        '
        'txtOldDirectory
        '
        Me.txtOldDirectory.Location = New System.Drawing.Point(89, 12)
        Me.txtOldDirectory.Name = "txtOldDirectory"
        Me.txtOldDirectory.Size = New System.Drawing.Size(274, 20)
        Me.txtOldDirectory.TabIndex = 4
        '
        'lblOldDirectory
        '
        Me.lblOldDirectory.AutoSize = True
        Me.lblOldDirectory.Location = New System.Drawing.Point(12, 15)
        Me.lblOldDirectory.Name = "lblOldDirectory"
        Me.lblOldDirectory.Size = New System.Drawing.Size(71, 13)
        Me.lblOldDirectory.TabIndex = 3
        Me.lblOldDirectory.Text = "Old Directory:"
        '
        'lblNewDirectory
        '
        Me.lblNewDirectory.AutoSize = True
        Me.lblNewDirectory.Location = New System.Drawing.Point(6, 41)
        Me.lblNewDirectory.Name = "lblNewDirectory"
        Me.lblNewDirectory.Size = New System.Drawing.Size(77, 13)
        Me.lblNewDirectory.TabIndex = 6
        Me.lblNewDirectory.Text = "New Directory:"
        '
        'txtNewDirectory
        '
        Me.txtNewDirectory.Location = New System.Drawing.Point(89, 38)
        Me.txtNewDirectory.Name = "txtNewDirectory"
        Me.txtNewDirectory.Size = New System.Drawing.Size(274, 20)
        Me.txtNewDirectory.TabIndex = 7
        '
        'btnNewDirectoryBrowser
        '
        Me.btnNewDirectoryBrowser.Location = New System.Drawing.Point(369, 36)
        Me.btnNewDirectoryBrowser.Name = "btnNewDirectoryBrowser"
        Me.btnNewDirectoryBrowser.Size = New System.Drawing.Size(25, 23)
        Me.btnNewDirectoryBrowser.TabIndex = 8
        Me.btnNewDirectoryBrowser.Text = "..."
        Me.btnNewDirectoryBrowser.UseVisualStyleBackColor = True
        '
        'gbFolderStats
        '
        Me.gbFolderStats.Controls.Add(Me.txtFolderStats)
        Me.gbFolderStats.Location = New System.Drawing.Point(12, 146)
        Me.gbFolderStats.Name = "gbFolderStats"
        Me.gbFolderStats.Size = New System.Drawing.Size(382, 100)
        Me.gbFolderStats.TabIndex = 11
        Me.gbFolderStats.TabStop = False
        Me.gbFolderStats.Text = "Directory Statistics"
        '
        'txtFolderStats
        '
        Me.txtFolderStats.BackColor = System.Drawing.SystemColors.Control
        Me.txtFolderStats.Location = New System.Drawing.Point(6, 19)
        Me.txtFolderStats.Multiline = True
        Me.txtFolderStats.Name = "txtFolderStats"
        Me.txtFolderStats.ReadOnly = True
        Me.txtFolderStats.Size = New System.Drawing.Size(370, 75)
        Me.txtFolderStats.TabIndex = 0
        '
        'btnGenerateStats
        '
        Me.btnGenerateStats.Location = New System.Drawing.Point(203, 117)
        Me.btnGenerateStats.Name = "btnGenerateStats"
        Me.btnGenerateStats.Size = New System.Drawing.Size(98, 23)
        Me.btnGenerateStats.TabIndex = 13
        Me.btnGenerateStats.Text = "Get Folder Stats"
        Me.btnGenerateStats.UseVisualStyleBackColor = True
        '
        'btnMove
        '
        Me.btnMove.Location = New System.Drawing.Point(307, 117)
        Me.btnMove.Name = "btnMove"
        Me.btnMove.Size = New System.Drawing.Size(87, 23)
        Me.btnMove.TabIndex = 12
        Me.btnMove.Text = "Move Files"
        Me.btnMove.UseVisualStyleBackColor = True
        '
        'btnFileTypeHelp
        '
        Me.btnFileTypeHelp.Location = New System.Drawing.Point(369, 62)
        Me.btnFileTypeHelp.Name = "btnFileTypeHelp"
        Me.btnFileTypeHelp.Size = New System.Drawing.Size(25, 23)
        Me.btnFileTypeHelp.TabIndex = 16
        Me.btnFileTypeHelp.Text = "?"
        Me.btnFileTypeHelp.UseVisualStyleBackColor = True
        '
        'txtFileType
        '
        Me.txtFileType.Location = New System.Drawing.Point(89, 64)
        Me.txtFileType.Name = "txtFileType"
        Me.txtFileType.Size = New System.Drawing.Size(274, 20)
        Me.txtFileType.TabIndex = 15
        Me.txtFileType.Text = "txt"
        '
        'lblFileType
        '
        Me.lblFileType.AutoSize = True
        Me.lblFileType.Location = New System.Drawing.Point(30, 67)
        Me.lblFileType.Name = "lblFileType"
        Me.lblFileType.Size = New System.Drawing.Size(53, 13)
        Me.lblFileType.TabIndex = 14
        Me.lblFileType.Text = "File Type:"
        '
        'txtCountToMove
        '
        Me.txtCountToMove.Location = New System.Drawing.Point(89, 90)
        Me.txtCountToMove.Name = "txtCountToMove"
        Me.txtCountToMove.Size = New System.Drawing.Size(274, 20)
        Me.txtCountToMove.TabIndex = 17
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Location = New System.Drawing.Point(26, 93)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(57, 13)
        Me.lblCount.TabIndex = 18
        Me.lblCount.Text = "File Count:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(369, 88)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "?"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmFileMover
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 260)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.txtCountToMove)
        Me.Controls.Add(Me.btnFileTypeHelp)
        Me.Controls.Add(Me.txtFileType)
        Me.Controls.Add(Me.lblFileType)
        Me.Controls.Add(Me.btnGenerateStats)
        Me.Controls.Add(Me.btnMove)
        Me.Controls.Add(Me.gbFolderStats)
        Me.Controls.Add(Me.btnNewDirectoryBrowser)
        Me.Controls.Add(Me.txtNewDirectory)
        Me.Controls.Add(Me.lblNewDirectory)
        Me.Controls.Add(Me.btnOldDirectoryBrowser)
        Me.Controls.Add(Me.txtOldDirectory)
        Me.Controls.Add(Me.lblOldDirectory)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmFileMover"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Directory Cleanser : File Mover"
        Me.gbFolderStats.ResumeLayout(False)
        Me.gbFolderStats.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOldDirectoryBrowser As Button
    Friend WithEvents txtOldDirectory As TextBox
    Friend WithEvents lblOldDirectory As Label
    Friend WithEvents FolderBrowserDialog As FolderBrowserDialog
    Friend WithEvents lblNewDirectory As Label
    Friend WithEvents txtNewDirectory As TextBox
    Friend WithEvents btnNewDirectoryBrowser As Button
    Friend WithEvents gbFolderStats As GroupBox
    Friend WithEvents txtFolderStats As TextBox
    Friend WithEvents btnGenerateStats As Button
    Friend WithEvents btnMove As Button
    Friend WithEvents btnFileTypeHelp As Button
    Friend WithEvents txtFileType As TextBox
    Friend WithEvents lblFileType As Label
    Friend WithEvents txtCountToMove As TextBox
    Friend WithEvents lblCount As Label
    Friend WithEvents Button1 As Button
End Class
