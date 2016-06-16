<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Events
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AddEventToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MultiLineListBox1
        '
        Me.MultiLineListBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MultiLineListBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.MultiLineListBox1.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MultiLineListBox1.FormattingEnabled = True
        Me.MultiLineListBox1.Location = New System.Drawing.Point(0, 25)
        Me.MultiLineListBox1.Name = "MultiLineListBox1"
        Me.MultiLineListBox1.ScrollAlwaysVisible = True
        Me.MultiLineListBox1.Size = New System.Drawing.Size(464, 355)
        Me.MultiLineListBox1.TabIndex = 2
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddEventToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(464, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AddEventToolStripMenuItem
        '
        Me.AddEventToolStripMenuItem.Name = "AddEventToolStripMenuItem"
        Me.AddEventToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.AddEventToolStripMenuItem.Text = "Add Event"
        '
        'Events
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 380)
        Me.Controls.Add(Me.MultiLineListBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Events"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Event"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MultiLineListBox1 As NishBox.MultiLineListBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AddEventToolStripMenuItem As ToolStripMenuItem
End Class
