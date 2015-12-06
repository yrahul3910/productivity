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
        Me.SvhMenuStrip1 = New SVHSmokeBlackControls.SVHMenuStrip()
        Me.CardsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewSetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveCurrentSetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadExistingSetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RunPracticeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CardsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToSetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveFromSetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SvhStatusStrip1 = New SVHSmokeBlackControls.SVHStatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SvhMenuStrip1.SuspendLayout()
        Me.SvhStatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SvhMenuStrip1
        '
        Me.SvhMenuStrip1.ForeColor = System.Drawing.Color.LightGray
        Me.SvhMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CardsToolStripMenuItem, Me.CardsToolStripMenuItem1})
        Me.SvhMenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.SvhMenuStrip1.Name = "SvhMenuStrip1"
        Me.SvhMenuStrip1.Size = New System.Drawing.Size(537, 24)
        Me.SvhMenuStrip1.TabIndex = 0
        Me.SvhMenuStrip1.Text = "SvhMenuStrip1"
        '
        'CardsToolStripMenuItem
        '
        Me.CardsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewSetToolStripMenuItem, Me.SaveCurrentSetToolStripMenuItem, Me.LoadExistingSetToolStripMenuItem, Me.RunPracticeToolStripMenuItem})
        Me.CardsToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray
        Me.CardsToolStripMenuItem.Name = "CardsToolStripMenuItem"
        Me.CardsToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.CardsToolStripMenuItem.Text = "Card Sets"
        '
        'NewSetToolStripMenuItem
        '
        Me.NewSetToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray
        Me.NewSetToolStripMenuItem.Name = "NewSetToolStripMenuItem"
        Me.NewSetToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.NewSetToolStripMenuItem.Text = "New Set"
        '
        'SaveCurrentSetToolStripMenuItem
        '
        Me.SaveCurrentSetToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray
        Me.SaveCurrentSetToolStripMenuItem.Name = "SaveCurrentSetToolStripMenuItem"
        Me.SaveCurrentSetToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.SaveCurrentSetToolStripMenuItem.Text = "Save Current Set"
        '
        'LoadExistingSetToolStripMenuItem
        '
        Me.LoadExistingSetToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray
        Me.LoadExistingSetToolStripMenuItem.Name = "LoadExistingSetToolStripMenuItem"
        Me.LoadExistingSetToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.LoadExistingSetToolStripMenuItem.Text = "Load Existing Set"
        '
        'RunPracticeToolStripMenuItem
        '
        Me.RunPracticeToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray
        Me.RunPracticeToolStripMenuItem.Name = "RunPracticeToolStripMenuItem"
        Me.RunPracticeToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.RunPracticeToolStripMenuItem.Text = "Run Session"
        '
        'CardsToolStripMenuItem1
        '
        Me.CardsToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToSetToolStripMenuItem, Me.RemoveFromSetToolStripMenuItem})
        Me.CardsToolStripMenuItem1.ForeColor = System.Drawing.Color.LightGray
        Me.CardsToolStripMenuItem1.Name = "CardsToolStripMenuItem1"
        Me.CardsToolStripMenuItem1.Size = New System.Drawing.Size(49, 20)
        Me.CardsToolStripMenuItem1.Text = "Cards"
        '
        'AddToSetToolStripMenuItem
        '
        Me.AddToSetToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray
        Me.AddToSetToolStripMenuItem.Name = "AddToSetToolStripMenuItem"
        Me.AddToSetToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.AddToSetToolStripMenuItem.Text = "Add To Set"
        '
        'RemoveFromSetToolStripMenuItem
        '
        Me.RemoveFromSetToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray
        Me.RemoveFromSetToolStripMenuItem.Name = "RemoveFromSetToolStripMenuItem"
        Me.RemoveFromSetToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.RemoveFromSetToolStripMenuItem.Text = "Remove From Set"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(0, 25)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(536, 171)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(253, 199)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Front"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(0, 221)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(536, 171)
        Me.TextBox2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(253, 395)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Back"
        '
        'SvhStatusStrip1
        '
        Me.SvhStatusStrip1.ForeColor = System.Drawing.Color.LightGray
        Me.SvhStatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.SvhStatusStrip1.Location = New System.Drawing.Point(0, 527)
        Me.SvhStatusStrip1.Name = "SvhStatusStrip1"
        Me.SvhStatusStrip1.Size = New System.Drawing.Size(537, 22)
        Me.SvhStatusStrip1.TabIndex = 5
        Me.SvhStatusStrip1.Text = "SvhStatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.LightGray
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel1.Text = "Ready"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Learning Stage"
        '
        'RadioButton1
        '
        Me.RadioButton1.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(16, 47)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(78, 33)
        Me.RadioButton1.TabIndex = 7
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "0"
        Me.RadioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(100, 47)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(78, 33)
        Me.RadioButton2.TabIndex = 8
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "1"
        Me.RadioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.Location = New System.Drawing.Point(184, 47)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(78, 33)
        Me.RadioButton3.TabIndex = 9
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "2"
        Me.RadioButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton4.Location = New System.Drawing.Point(268, 47)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(78, 33)
        Me.RadioButton4.TabIndex = 10
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "3"
        Me.RadioButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton5.Location = New System.Drawing.Point(352, 47)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(78, 33)
        Me.RadioButton5.TabIndex = 11
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "4"
        Me.RadioButton5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton6.Location = New System.Drawing.Point(436, 47)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(78, 33)
        Me.RadioButton6.TabIndex = 12
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = "5"
        Me.RadioButton6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Card Set File | *.csf"
        Me.OpenFileDialog1.Title = "Select a Location"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Card Set Files | *.csf"
        Me.SaveFileDialog1.Title = "Browse to Location"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.RadioButton6)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton5)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(5, 434)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(525, 90)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Progress"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(345, 398)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 30)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Show Answer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 549)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.SvhStatusStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.SvhMenuStrip1)
        Me.MainMenuStrip = Me.SvhMenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Flash Cards"
        Me.SvhMenuStrip1.ResumeLayout(False)
        Me.SvhMenuStrip1.PerformLayout()
        Me.SvhStatusStrip1.ResumeLayout(False)
        Me.SvhStatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SvhMenuStrip1 As SVHSmokeBlackControls.SVHMenuStrip
    Friend WithEvents CardsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewSetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveCurrentSetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadExistingSetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SvhStatusStrip1 As SVHSmokeBlackControls.SVHStatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents CardsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddToSetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveFromSetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents RunPracticeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
