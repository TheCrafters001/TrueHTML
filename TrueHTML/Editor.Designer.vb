<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Editor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Editor))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.pgDetails = New System.Windows.Forms.TabPage()
        Me.pageTitle_txt = New System.Windows.Forms.TextBox()
        Me.pageTitle_lbl = New System.Windows.Forms.Label()
        Me.pgMetaTags = New System.Windows.Forms.TabPage()
        Me.pgEditors = New System.Windows.Forms.TabPage()
        Me.pgPreview = New System.Windows.Forms.TabPage()
        Me.pgExport = New System.Windows.Forms.TabPage()
        Me.pgAbout = New System.Windows.Forms.TabPage()
        Me.pgExtra = New System.Windows.Forms.TabPage()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpSeperator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CheckForUpdatesMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1.SuspendLayout()
        Me.pgDetails.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.AllowDrop = True
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.pgDetails)
        Me.TabControl1.Controls.Add(Me.pgMetaTags)
        Me.TabControl1.Controls.Add(Me.pgEditors)
        Me.TabControl1.Controls.Add(Me.pgPreview)
        Me.TabControl1.Controls.Add(Me.pgExport)
        Me.TabControl1.Controls.Add(Me.pgAbout)
        Me.TabControl1.Controls.Add(Me.pgExtra)
        Me.TabControl1.ItemSize = New System.Drawing.Size(100, 20)
        Me.TabControl1.Location = New System.Drawing.Point(12, 27)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1240, 627)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 0
        '
        'pgDetails
        '
        Me.pgDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.pgDetails.Controls.Add(Me.pageTitle_txt)
        Me.pgDetails.Controls.Add(Me.pageTitle_lbl)
        Me.pgDetails.Location = New System.Drawing.Point(4, 24)
        Me.pgDetails.Name = "pgDetails"
        Me.pgDetails.Padding = New System.Windows.Forms.Padding(3)
        Me.pgDetails.Size = New System.Drawing.Size(1232, 599)
        Me.pgDetails.TabIndex = 0
        Me.pgDetails.Text = "Details"
        '
        'pageTitle_txt
        '
        Me.pageTitle_txt.Location = New System.Drawing.Point(6, 21)
        Me.pageTitle_txt.Name = "pageTitle_txt"
        Me.pageTitle_txt.Size = New System.Drawing.Size(164, 23)
        Me.pageTitle_txt.TabIndex = 1
        '
        'pageTitle_lbl
        '
        Me.pageTitle_lbl.AutoSize = True
        Me.pageTitle_lbl.Location = New System.Drawing.Point(6, 3)
        Me.pageTitle_lbl.Name = "pageTitle_lbl"
        Me.pageTitle_lbl.Size = New System.Drawing.Size(58, 15)
        Me.pageTitle_lbl.TabIndex = 0
        Me.pageTitle_lbl.Text = "Page Title"
        '
        'pgMetaTags
        '
        Me.pgMetaTags.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.pgMetaTags.Location = New System.Drawing.Point(4, 24)
        Me.pgMetaTags.Name = "pgMetaTags"
        Me.pgMetaTags.Size = New System.Drawing.Size(1232, 599)
        Me.pgMetaTags.TabIndex = 1
        Me.pgMetaTags.Text = "Meta Tags/SEO"
        '
        'pgEditors
        '
        Me.pgEditors.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.pgEditors.Location = New System.Drawing.Point(4, 24)
        Me.pgEditors.Name = "pgEditors"
        Me.pgEditors.Size = New System.Drawing.Size(1232, 599)
        Me.pgEditors.TabIndex = 2
        Me.pgEditors.Text = "Editors"
        '
        'pgPreview
        '
        Me.pgPreview.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.pgPreview.Location = New System.Drawing.Point(4, 24)
        Me.pgPreview.Name = "pgPreview"
        Me.pgPreview.Size = New System.Drawing.Size(1232, 599)
        Me.pgPreview.TabIndex = 3
        Me.pgPreview.Text = "Preview"
        '
        'pgExport
        '
        Me.pgExport.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.pgExport.Location = New System.Drawing.Point(4, 24)
        Me.pgExport.Name = "pgExport"
        Me.pgExport.Size = New System.Drawing.Size(1232, 599)
        Me.pgExport.TabIndex = 4
        Me.pgExport.Text = "Export"
        '
        'pgAbout
        '
        Me.pgAbout.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.pgAbout.Location = New System.Drawing.Point(4, 24)
        Me.pgAbout.Name = "pgAbout"
        Me.pgAbout.Size = New System.Drawing.Size(1232, 599)
        Me.pgAbout.TabIndex = 5
        Me.pgAbout.Text = "About"
        '
        'pgExtra
        '
        Me.pgExtra.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.pgExtra.Location = New System.Drawing.Point(4, 24)
        Me.pgExtra.Name = "pgExtra"
        Me.pgExtra.Size = New System.Drawing.Size(1232, 599)
        Me.pgExtra.TabIndex = 6
        Me.pgExtra.Text = "Extra Fun Stuff"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 659)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1264, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "editorStatus"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(29, 17)
        Me.ToolStripStatusLabel1.Text = "Idle."
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1264, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.toolStripSeparator, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.toolStripSeparator2, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Image = CType(resources.GetObject("NewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.NewToolStripMenuItem.Text = "&New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Image = CType(resources.GetObject("OpenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.OpenToolStripMenuItem.Text = "&Open"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(187, 6)
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Image = CType(resources.GetObject("SaveToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SaveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.SaveToolStripMenuItem.Text = "&Save As JSON"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save &As Project Folder"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(187, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.OptionsToolStripMenuItem.Text = "&Options"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.HelpSeperator1, Me.CheckForUpdatesMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.AboutToolStripMenuItem.Text = "&About..."
        '
        'HelpSeperator1
        '
        Me.HelpSeperator1.Name = "HelpSeperator1"
        Me.HelpSeperator1.Size = New System.Drawing.Size(168, 6)
        '
        'CheckForUpdatesMenuItem
        '
        Me.CheckForUpdatesMenuItem.Name = "CheckForUpdatesMenuItem"
        Me.CheckForUpdatesMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.CheckForUpdatesMenuItem.Text = "Check for Updates"
        '
        'Editor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.ForeColor = System.Drawing.Color.White
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(1280, 720)
        Me.Name = "Editor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TrueHTML Editor"
        Me.TabControl1.ResumeLayout(False)
        Me.pgDetails.ResumeLayout(False)
        Me.pgDetails.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents pgDetails As TabPage
    Friend WithEvents pgMetaTags As TabPage
    Friend WithEvents pgEditors As TabPage
    Friend WithEvents pgPreview As TabPage
    Friend WithEvents pgExport As TabPage
    Friend WithEvents pgAbout As TabPage
    Friend WithEvents pgExtra As TabPage
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpSeperator1 As ToolStripSeparator
    Friend WithEvents CheckForUpdatesMenuItem As ToolStripMenuItem
    Friend WithEvents pageTitle_lbl As Label
    Friend WithEvents pageTitle_txt As TextBox
End Class
