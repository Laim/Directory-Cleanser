<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.btnFileRemover = New System.Windows.Forms.Button()
        Me.btnFileMover = New System.Windows.Forms.Button()
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.LinkLabel()
        Me.lblVersion = New System.Windows.Forms.Label()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picLogo
        '
        Me.picLogo.BackColor = System.Drawing.Color.White
        Me.picLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.picLogo.Image = Global.Directory_Cleanser.My.Resources.Resources.logo1
        Me.picLogo.Location = New System.Drawing.Point(0, 0)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(500, 100)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogo.TabIndex = 0
        Me.picLogo.TabStop = False
        '
        'btnFileRemover
        '
        Me.btnFileRemover.Location = New System.Drawing.Point(12, 106)
        Me.btnFileRemover.Name = "btnFileRemover"
        Me.btnFileRemover.Size = New System.Drawing.Size(230, 23)
        Me.btnFileRemover.TabIndex = 1
        Me.btnFileRemover.Text = "File Remover"
        Me.btnFileRemover.UseVisualStyleBackColor = True
        '
        'btnFileMover
        '
        Me.btnFileMover.Location = New System.Drawing.Point(258, 106)
        Me.btnFileMover.Name = "btnFileMover"
        Me.btnFileMover.Size = New System.Drawing.Size(230, 23)
        Me.btnFileMover.TabIndex = 2
        Me.btnFileMover.Text = "File Mover"
        Me.btnFileMover.UseVisualStyleBackColor = True
        '
        'lblCopyright
        '
        Me.lblCopyright.AutoSize = True
        Me.lblCopyright.Location = New System.Drawing.Point(12, 137)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(141, 13)
        Me.lblCopyright.TabIndex = 3
        Me.lblCopyright.Text = "Copyright (c) Laim McKenzie"
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Location = New System.Drawing.Point(165, 137)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(323, 13)
        Me.lblInfo.TabIndex = 4
        Me.lblInfo.TabStop = True
        Me.lblInfo.Text = "Directory Cleanser is open-source, released under the MIT license. "
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Location = New System.Drawing.Point(406, 9)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(82, 13)
        Me.lblVersion.TabIndex = 5
        Me.lblVersion.Text = "Version X.X.X.X"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(500, 159)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.lblCopyright)
        Me.Controls.Add(Me.btnFileMover)
        Me.Controls.Add(Me.btnFileRemover)
        Me.Controls.Add(Me.picLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Directory Cleanser"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picLogo As PictureBox
    Friend WithEvents btnFileRemover As Button
    Friend WithEvents btnFileMover As Button
    Friend WithEvents lblCopyright As Label
    Friend WithEvents lblInfo As LinkLabel
    Friend WithEvents lblVersion As Label
End Class
