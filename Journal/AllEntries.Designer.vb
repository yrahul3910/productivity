<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AllEntries
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
        Me.MultiLineListBox1 = New NishBox.MultiLineListBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.RadButton2 = New MetroFramework.Controls.MetroTile()
        Me.RadButton1 = New MetroFramework.Controls.MetroTile()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RadButtonElement2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RadButtonElement1 = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        Me.MetroTabPage2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MultiLineListBox1
        '
        Me.MultiLineListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MultiLineListBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.MultiLineListBox1.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MultiLineListBox1.FormattingEnabled = True
        Me.MultiLineListBox1.Location = New System.Drawing.Point(0, 137)
        Me.MultiLineListBox1.Name = "MultiLineListBox1"
        Me.MultiLineListBox1.ScrollAlwaysVisible = True
        Me.MultiLineListBox1.Size = New System.Drawing.Size(489, 316)
        Me.MultiLineListBox1.TabIndex = 1
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Journal Files (.journal)|*.journal|Productivity 4.0 Journal Files (.journalx)|*.j" &
    "ournalx"
        Me.OpenFileDialog1.Title = "Choose Location"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Productivity 4.0 Journal Files (.journalx)| *.journalx"
        Me.SaveFileDialog1.Title = "Choose Location"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(231, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(190, 23)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Text = "Search..."
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Wingdings 2", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Button1.Location = New System.Drawing.Point(393, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(28, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "P"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.DodgerBlue
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 457)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(490, 22)
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel1.Text = "Ready"
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage2)
        Me.MetroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(490, 108)
        Me.MetroTabControl1.TabIndex = 8
        Me.MetroTabControl1.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.RadButton2)
        Me.MetroTabPage1.Controls.Add(Me.RadButton1)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(482, 66)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "FILE"
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'RadButton2
        '
        Me.RadButton2.ActiveControl = Nothing
        Me.RadButton2.Location = New System.Drawing.Point(8, 35)
        Me.RadButton2.Name = "RadButton2"
        Me.RadButton2.Size = New System.Drawing.Size(100, 28)
        Me.RadButton2.TabIndex = 3
        Me.RadButton2.Text = "Save"
        Me.RadButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadButton2.UseSelectable = True
        '
        'RadButton1
        '
        Me.RadButton1.ActiveControl = Nothing
        Me.RadButton1.Location = New System.Drawing.Point(8, 3)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(100, 28)
        Me.RadButton1.TabIndex = 2
        Me.RadButton1.Text = "Open"
        Me.RadButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadButton1.UseSelectable = True
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.Controls.Add(Me.Label3)
        Me.MetroTabPage2.Controls.Add(Me.RadButtonElement2)
        Me.MetroTabPage2.Controls.Add(Me.Label2)
        Me.MetroTabPage2.Controls.Add(Me.RadButtonElement1)
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.HorizontalScrollbarSize = 10
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(482, 66)
        Me.MetroTabPage2.TabIndex = 1
        Me.MetroTabPage2.Text = "New"
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.VerticalScrollbarSize = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(123, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "New Entry"
        '
        'RadButtonElement2
        '
        Me.RadButtonElement2.BackColor = System.Drawing.Color.White
        Me.RadButtonElement2.BackgroundImage = Global.Journal.My.Resources.Resources.add2
        Me.RadButtonElement2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadButtonElement2.FlatAppearance.BorderSize = 0
        Me.RadButtonElement2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadButtonElement2.Location = New System.Drawing.Point(132, 3)
        Me.RadButtonElement2.Name = "RadButtonElement2"
        Me.RadButtonElement2.Size = New System.Drawing.Size(49, 45)
        Me.RadButtonElement2.TabIndex = 4
        Me.RadButtonElement2.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "New Journal"
        '
        'RadButtonElement1
        '
        Me.RadButtonElement1.BackColor = System.Drawing.Color.White
        Me.RadButtonElement1.BackgroundImage = Global.Journal.My.Resources.Resources.add1
        Me.RadButtonElement1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadButtonElement1.FlatAppearance.BorderSize = 0
        Me.RadButtonElement1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadButtonElement1.Location = New System.Drawing.Point(27, 3)
        Me.RadButtonElement1.Name = "RadButtonElement1"
        Me.RadButtonElement1.Size = New System.Drawing.Size(49, 45)
        Me.RadButtonElement1.TabIndex = 2
        Me.RadButtonElement1.UseVisualStyleBackColor = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Top
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.MetroTabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(490, 142)
        Me.SplitContainer1.SplitterDistance = 30
        Me.SplitContainer1.TabIndex = 9
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(490, 30)
        Me.Panel1.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(420, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(33, 29)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "-"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(457, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(33, 29)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "X"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(6, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 19)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Journal"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AllEntries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 479)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MultiLineListBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AllEntries"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "All Entries"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.MetroTabPage2.ResumeLayout(False)
        Me.MetroTabPage2.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MultiLineListBox1 As NishBox.MultiLineListBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents RadButtonElement2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents RadButtonElement1 As Button
    Friend WithEvents RadButton2 As MetroFramework.Controls.MetroTile
    Friend WithEvents RadButton1 As MetroFramework.Controls.MetroTile
End Class
