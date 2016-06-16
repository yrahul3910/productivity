<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AttachmentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EventsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Date"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(12, 56)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(382, 29)
        Me.DateTimePicker1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Entry"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(12, 126)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(382, 269)
        Me.TextBox1.TabIndex = 3
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EntryToolStripMenuItem, Me.AttachmentsToolStripMenuItem, Me.EventsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(409, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EntryToolStripMenuItem
        '
        Me.EntryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddEntryToolStripMenuItem, Me.UpdateEntryToolStripMenuItem})
        Me.EntryToolStripMenuItem.Name = "EntryToolStripMenuItem"
        Me.EntryToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.EntryToolStripMenuItem.Text = "Entry"
        '
        'AddEntryToolStripMenuItem
        '
        Me.AddEntryToolStripMenuItem.Name = "AddEntryToolStripMenuItem"
        Me.AddEntryToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.AddEntryToolStripMenuItem.Text = "Add Entry"
        '
        'UpdateEntryToolStripMenuItem
        '
        Me.UpdateEntryToolStripMenuItem.Name = "UpdateEntryToolStripMenuItem"
        Me.UpdateEntryToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.UpdateEntryToolStripMenuItem.Text = "Update Entry"
        '
        'AttachmentsToolStripMenuItem
        '
        Me.AttachmentsToolStripMenuItem.Name = "AttachmentsToolStripMenuItem"
        Me.AttachmentsToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.AttachmentsToolStripMenuItem.Text = "Attachments"
        '
        'EventsToolStripMenuItem
        '
        Me.EventsToolStripMenuItem.Name = "EventsToolStripMenuItem"
        Me.EventsToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.EventsToolStripMenuItem.Text = "Events"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 421)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Journal Entry"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents EntryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddEntryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateEntryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AttachmentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EventsToolStripMenuItem As ToolStripMenuItem
End Class
