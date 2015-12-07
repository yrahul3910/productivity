<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchResults
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
        Me.SuspendLayout()
        '
        'MultiLineListBox1
        '
        Me.MultiLineListBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MultiLineListBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.MultiLineListBox1.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MultiLineListBox1.FormattingEnabled = True
        Me.MultiLineListBox1.Location = New System.Drawing.Point(0, 0)
        Me.MultiLineListBox1.Name = "MultiLineListBox1"
        Me.MultiLineListBox1.ScrollAlwaysVisible = True
        Me.MultiLineListBox1.Size = New System.Drawing.Size(511, 461)
        Me.MultiLineListBox1.TabIndex = 2
        '
        'SearchResults
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 461)
        Me.Controls.Add(Me.MultiLineListBox1)
        Me.Name = "SearchResults"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search Results"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MultiLineListBox1 As NishBox.MultiLineListBox
End Class
