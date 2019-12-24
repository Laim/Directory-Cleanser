<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFileRemover
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFileRemover))
        Me.lblDirectory = New System.Windows.Forms.Label()
        Me.txtDirectory = New System.Windows.Forms.TextBox()
        Me.btnDirectoryBrowser = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.lblFileType = New System.Windows.Forms.Label()
        Me.txtFileType = New System.Windows.Forms.TextBox()
        Me.btnFileTypeHelp = New System.Windows.Forms.Button()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.btnDate = New System.Windows.Forms.Button()
        Me.lblDays = New System.Windows.Forms.Label()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.gbFolderStats = New System.Windows.Forms.GroupBox()
        Me.txtFolderStats = New System.Windows.Forms.TextBox()
        Me.btnGenerateStats = New System.Windows.Forms.Button()
        Me.gbFolderStats.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDirectory
        '
        Me.lblDirectory.AutoSize = True
        Me.lblDirectory.Location = New System.Drawing.Point(12, 15)
        Me.lblDirectory.Name = "lblDirectory"
        Me.lblDirectory.Size = New System.Drawing.Size(52, 13)
        Me.lblDirectory.TabIndex = 0
        Me.lblDirectory.Text = "Directory:"
        '
        'txtDirectory
        '
        Me.txtDirectory.Location = New System.Drawing.Point(70, 12)
        Me.txtDirectory.Name = "txtDirectory"
        Me.txtDirectory.Size = New System.Drawing.Size(293, 20)
        Me.txtDirectory.TabIndex = 1
        '
        'btnDirectoryBrowser
        '
        Me.btnDirectoryBrowser.Location = New System.Drawing.Point(369, 10)
        Me.btnDirectoryBrowser.Name = "btnDirectoryBrowser"
        Me.btnDirectoryBrowser.Size = New System.Drawing.Size(25, 23)
        Me.btnDirectoryBrowser.TabIndex = 2
        Me.btnDirectoryBrowser.Text = "..."
        Me.btnDirectoryBrowser.UseVisualStyleBackColor = True
        '
        'lblFileType
        '
        Me.lblFileType.AutoSize = True
        Me.lblFileType.Location = New System.Drawing.Point(11, 41)
        Me.lblFileType.Name = "lblFileType"
        Me.lblFileType.Size = New System.Drawing.Size(53, 13)
        Me.lblFileType.TabIndex = 3
        Me.lblFileType.Text = "File Type:"
        '
        'txtFileType
        '
        Me.txtFileType.Location = New System.Drawing.Point(70, 38)
        Me.txtFileType.Name = "txtFileType"
        Me.txtFileType.Size = New System.Drawing.Size(293, 20)
        Me.txtFileType.TabIndex = 4
        Me.txtFileType.Text = "txt"
        '
        'btnFileTypeHelp
        '
        Me.btnFileTypeHelp.Location = New System.Drawing.Point(369, 36)
        Me.btnFileTypeHelp.Name = "btnFileTypeHelp"
        Me.btnFileTypeHelp.Size = New System.Drawing.Size(25, 23)
        Me.btnFileTypeHelp.TabIndex = 5
        Me.btnFileTypeHelp.Text = "?"
        Me.btnFileTypeHelp.UseVisualStyleBackColor = True
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(70, 64)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(293, 20)
        Me.txtDate.TabIndex = 6
        Me.txtDate.Text = "3"
        '
        'btnDate
        '
        Me.btnDate.Location = New System.Drawing.Point(369, 62)
        Me.btnDate.Name = "btnDate"
        Me.btnDate.Size = New System.Drawing.Size(25, 23)
        Me.btnDate.TabIndex = 7
        Me.btnDate.Text = "?"
        Me.btnDate.UseVisualStyleBackColor = True
        '
        'lblDays
        '
        Me.lblDays.AutoSize = True
        Me.lblDays.Location = New System.Drawing.Point(31, 67)
        Me.lblDays.Name = "lblDays"
        Me.lblDays.Size = New System.Drawing.Size(34, 13)
        Me.lblDays.TabIndex = 8
        Me.lblDays.Text = "Days:"
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(307, 91)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(87, 23)
        Me.btnRemove.TabIndex = 9
        Me.btnRemove.Text = "Remove Files"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'gbFolderStats
        '
        Me.gbFolderStats.Controls.Add(Me.txtFolderStats)
        Me.gbFolderStats.Location = New System.Drawing.Point(12, 120)
        Me.gbFolderStats.Name = "gbFolderStats"
        Me.gbFolderStats.Size = New System.Drawing.Size(382, 100)
        Me.gbFolderStats.TabIndex = 10
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
        Me.btnGenerateStats.Location = New System.Drawing.Point(203, 91)
        Me.btnGenerateStats.Name = "btnGenerateStats"
        Me.btnGenerateStats.Size = New System.Drawing.Size(98, 23)
        Me.btnGenerateStats.TabIndex = 11
        Me.btnGenerateStats.Text = "Get Folder Stats"
        Me.btnGenerateStats.UseVisualStyleBackColor = True
        '
        'frmFileRemover
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 234)
        Me.Controls.Add(Me.btnGenerateStats)
        Me.Controls.Add(Me.gbFolderStats)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.lblDays)
        Me.Controls.Add(Me.btnDate)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.btnFileTypeHelp)
        Me.Controls.Add(Me.txtFileType)
        Me.Controls.Add(Me.lblFileType)
        Me.Controls.Add(Me.btnDirectoryBrowser)
        Me.Controls.Add(Me.txtDirectory)
        Me.Controls.Add(Me.lblDirectory)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmFileRemover"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Directory Cleanser : File Remover"
        Me.gbFolderStats.ResumeLayout(False)
        Me.gbFolderStats.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDirectory As Label
    Friend WithEvents txtDirectory As TextBox
    Friend WithEvents btnDirectoryBrowser As Button
    Friend WithEvents FolderBrowserDialog As FolderBrowserDialog
    Friend WithEvents lblFileType As Label
    Friend WithEvents txtFileType As TextBox
    Friend WithEvents btnFileTypeHelp As Button
    Friend WithEvents txtDate As TextBox
    Friend WithEvents btnDate As Button
    Friend WithEvents lblDays As Label
    Friend WithEvents btnRemove As Button
    Friend WithEvents gbFolderStats As GroupBox
    Friend WithEvents txtFolderStats As TextBox
    Friend WithEvents btnGenerateStats As Button
End Class
