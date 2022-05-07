<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Editor
    Inherits DarkUI.Forms.DarkForm

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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.pgDetails = New System.Windows.Forms.TabPage()
        Me.pgMetaTags = New System.Windows.Forms.TabPage()
        Me.pgEditors = New System.Windows.Forms.TabPage()
        Me.pgPreview = New System.Windows.Forms.TabPage()
        Me.pgExport = New System.Windows.Forms.TabPage()
        Me.pgAbout = New System.Windows.Forms.TabPage()
        Me.pgExtra = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
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
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(978, 638)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 0
        '
        'pgDetails
        '
        Me.pgDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.pgDetails.Location = New System.Drawing.Point(4, 24)
        Me.pgDetails.Name = "pgDetails"
        Me.pgDetails.Padding = New System.Windows.Forms.Padding(3)
        Me.pgDetails.Size = New System.Drawing.Size(970, 610)
        Me.pgDetails.TabIndex = 0
        Me.pgDetails.Text = "Details"
        '
        'pgMetaTags
        '
        Me.pgMetaTags.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.pgMetaTags.Location = New System.Drawing.Point(4, 24)
        Me.pgMetaTags.Name = "pgMetaTags"
        Me.pgMetaTags.Size = New System.Drawing.Size(970, 610)
        Me.pgMetaTags.TabIndex = 1
        Me.pgMetaTags.Text = "Meta Tags/SEO"
        '
        'pgEditors
        '
        Me.pgEditors.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.pgEditors.Location = New System.Drawing.Point(4, 24)
        Me.pgEditors.Name = "pgEditors"
        Me.pgEditors.Size = New System.Drawing.Size(970, 610)
        Me.pgEditors.TabIndex = 2
        Me.pgEditors.Text = "Editors"
        '
        'pgPreview
        '
        Me.pgPreview.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.pgPreview.Location = New System.Drawing.Point(4, 24)
        Me.pgPreview.Name = "pgPreview"
        Me.pgPreview.Size = New System.Drawing.Size(970, 610)
        Me.pgPreview.TabIndex = 3
        Me.pgPreview.Text = "Preview"
        '
        'pgExport
        '
        Me.pgExport.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.pgExport.Location = New System.Drawing.Point(4, 24)
        Me.pgExport.Name = "pgExport"
        Me.pgExport.Size = New System.Drawing.Size(970, 610)
        Me.pgExport.TabIndex = 4
        Me.pgExport.Text = "Export"
        '
        'pgAbout
        '
        Me.pgAbout.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.pgAbout.Location = New System.Drawing.Point(4, 24)
        Me.pgAbout.Name = "pgAbout"
        Me.pgAbout.Size = New System.Drawing.Size(970, 610)
        Me.pgAbout.TabIndex = 5
        Me.pgAbout.Text = "About"
        '
        'pgExtra
        '
        Me.pgExtra.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.pgExtra.Location = New System.Drawing.Point(4, 24)
        Me.pgExtra.Name = "pgExtra"
        Me.pgExtra.Size = New System.Drawing.Size(970, 610)
        Me.pgExtra.TabIndex = 6
        Me.pgExtra.Text = "Extra Fun Stuff"
        '
        'Editor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1002, 662)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Editor"
        Me.Text = "TrueHTML Editor"
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents pgDetails As TabPage
    Friend WithEvents pgMetaTags As TabPage
    Friend WithEvents pgEditors As TabPage
    Friend WithEvents pgPreview As TabPage
    Friend WithEvents pgExport As TabPage
    Friend WithEvents pgAbout As TabPage
    Friend WithEvents pgExtra As TabPage
End Class
