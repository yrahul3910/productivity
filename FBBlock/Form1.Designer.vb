<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits MetroFramework.Forms.MetroForm

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
        Me.MetroTile1 = New MetroFramework.Controls.MetroTile()
        Me.MetroTile2 = New MetroFramework.Controls.MetroTile()
        Me.MetroTile3 = New MetroFramework.Controls.MetroTile()
        Me.MetroTile4 = New MetroFramework.Controls.MetroTile()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MetroTile5 = New MetroFramework.Controls.MetroTile()
        Me.SuspendLayout()
        '
        'MetroTile1
        '
        Me.MetroTile1.ActiveControl = Nothing
        Me.MetroTile1.Location = New System.Drawing.Point(28, 80)
        Me.MetroTile1.Name = "MetroTile1"
        Me.MetroTile1.Size = New System.Drawing.Size(208, 48)
        Me.MetroTile1.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroTile1.TabIndex = 0
        Me.MetroTile1.Text = "Block Social Networks"
        Me.MetroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.MetroTile1.UseSelectable = True
        '
        'MetroTile2
        '
        Me.MetroTile2.ActiveControl = Nothing
        Me.MetroTile2.Location = New System.Drawing.Point(242, 80)
        Me.MetroTile2.Name = "MetroTile2"
        Me.MetroTile2.Size = New System.Drawing.Size(208, 48)
        Me.MetroTile2.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroTile2.TabIndex = 1
        Me.MetroTile2.Text = "Unblock Social Networks"
        Me.MetroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.MetroTile2.UseSelectable = True
        '
        'MetroTile3
        '
        Me.MetroTile3.ActiveControl = Nothing
        Me.MetroTile3.Location = New System.Drawing.Point(28, 311)
        Me.MetroTile3.Name = "MetroTile3"
        Me.MetroTile3.Size = New System.Drawing.Size(208, 48)
        Me.MetroTile3.Style = MetroFramework.MetroColorStyle.Lime
        Me.MetroTile3.TabIndex = 2
        Me.MetroTile3.Text = "Enable God Mode"
        Me.MetroTile3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile3.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.MetroTile3.UseSelectable = True
        '
        'MetroTile4
        '
        Me.MetroTile4.ActiveControl = Nothing
        Me.MetroTile4.Location = New System.Drawing.Point(28, 221)
        Me.MetroTile4.Name = "MetroTile4"
        Me.MetroTile4.Size = New System.Drawing.Size(208, 48)
        Me.MetroTile4.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroTile4.TabIndex = 3
        Me.MetroTile4.Text = "Block Website"
        Me.MetroTile4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile4.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.MetroTile4.UseSelectable = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(74, 156)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(351, 33)
        Me.TextBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 159)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "URL"
        '
        'MetroTile5
        '
        Me.MetroTile5.ActiveControl = Nothing
        Me.MetroTile5.Location = New System.Drawing.Point(242, 221)
        Me.MetroTile5.Name = "MetroTile5"
        Me.MetroTile5.Size = New System.Drawing.Size(208, 48)
        Me.MetroTile5.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroTile5.TabIndex = 4
        Me.MetroTile5.Text = "Unblock Website"
        Me.MetroTile5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile5.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.MetroTile5.UseSelectable = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 389)
        Me.Controls.Add(Me.MetroTile5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MetroTile4)
        Me.Controls.Add(Me.MetroTile3)
        Me.Controls.Add(Me.MetroTile2)
        Me.Controls.Add(Me.MetroTile1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Social Blocker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MetroTile1 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTile2 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTile3 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTile4 As MetroFramework.Controls.MetroTile
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MetroTile5 As MetroFramework.Controls.MetroTile

End Class
