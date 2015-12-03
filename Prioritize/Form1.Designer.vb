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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim Animation1 As AnimatorNS.Animation = New AnimatorNS.Animation()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTile1 = New MetroFramework.Controls.MetroTile()
        Me.MetroTile2 = New MetroFramework.Controls.MetroTile()
        Me.MetroTile3 = New MetroFramework.Controls.MetroTile()
        Me.MetroTile4 = New MetroFramework.Controls.MetroTile()
        Me.Animator1 = New AnimatorNS.Animator()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.MetroTile6 = New MetroFramework.Controls.MetroTile()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.MetroTextBox2 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTile5 = New MetroFramework.Controls.MetroTile()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.MetroTile7 = New MetroFramework.Controls.MetroTile()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.MetroTextBox3 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTile8 = New MetroFramework.Controls.MetroTile()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel3 = New MetroFramework.Controls.MetroPanel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.ListBox5 = New System.Windows.Forms.ListBox()
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.MetroPanel1.SuspendLayout()
        Me.MetroPanel2.SuspendLayout()
        Me.MetroPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.Silver
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox1.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 21
        Me.ListBox1.Location = New System.Drawing.Point(411, 63)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(259, 294)
        Me.ListBox1.TabIndex = 0
        '

        'MetroLabel1
        '
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(12, 75)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(349, 233)
        Me.MetroLabel1.TabIndex = 1
        Me.MetroLabel1.Text = resources.GetString("MetroLabel1.Text")
        MetroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark        '
        'MetroTextBox1
        '
        Me.MetroTextBox1.Lines = New String(-1) {}
        Me.MetroTextBox1.Location = New System.Drawing.Point(23, 334)
        Me.MetroTextBox1.MaxLength = 32767
        Me.MetroTextBox1.Name = "MetroTextBox1"
        Me.MetroTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox1.SelectedText = ""
        Me.MetroTextBox1.Size = New System.Drawing.Size(197, 23)
        Me.MetroTextBox1.TabIndex = 2
        Me.MetroTextBox1.UseSelectable = True
        '
        'MetroTile1
        '
        Me.MetroTile1.ActiveControl = Nothing
        Me.MetroTile1.Location = New System.Drawing.Point(244, 326)
        Me.MetroTile1.Name = "MetroTile1"
        Me.MetroTile1.Size = New System.Drawing.Size(75, 31)
        Me.MetroTile1.TabIndex = 3
        Me.MetroTile1.Text = "Add"
        Me.MetroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.MetroTile1.UseSelectable = True
        '
        'MetroTile2
        '
        Me.MetroTile2.ActiveControl = Nothing
        Me.MetroTile2.Location = New System.Drawing.Point(577, 365)
        Me.MetroTile2.Name = "MetroTile2"
        Me.MetroTile2.Size = New System.Drawing.Size(93, 31)
        Me.MetroTile2.Style = MetroFramework.MetroColorStyle.Red
        Me.MetroTile2.TabIndex = 4
        Me.MetroTile2.Text = "Clear All"
        Me.MetroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.MetroTile2.UseSelectable = True
        '
        'MetroTile3
        '
        Me.MetroTile3.ActiveControl = Nothing
        Me.MetroTile3.Location = New System.Drawing.Point(411, 365)
        Me.MetroTile3.Name = "MetroTile3"
        Me.MetroTile3.Size = New System.Drawing.Size(75, 31)
        Me.MetroTile3.Style = MetroFramework.MetroColorStyle.Yellow
        Me.MetroTile3.TabIndex = 5
        Me.MetroTile3.Text = "Clear"
        Me.MetroTile3.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.MetroTile3.UseSelectable = True
        '
        'MetroTile4
        '
        Me.MetroTile4.ActiveControl = Nothing
        Me.MetroTile4.Location = New System.Drawing.Point(145, 383)
        Me.MetroTile4.Name = "MetroTile4"
        Me.MetroTile4.Size = New System.Drawing.Size(89, 31)
        Me.MetroTile4.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroTile4.TabIndex = 6
        Me.MetroTile4.Text = "DONE"
        Me.MetroTile4.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.MetroTile4.UseSelectable = True
        '
        'Animator1
        '
        Me.Animator1.AnimationType = AnimatorNS.AnimationType.Particles
        Me.Animator1.Cursor = Nothing
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0.0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 1
        Animation1.Padding = New System.Windows.Forms.Padding(100, 50, 100, 150)
        Animation1.RotateCoeff = 0.0!
        Animation1.RotateLimit = 0.0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 2.0!
        Animation1.TransparencyCoeff = 0.0!
        Me.Animator1.DefaultAnimation = Animation1
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.MetroTile6)
        Me.MetroPanel1.Controls.Add(Me.ListView1)
        Me.MetroPanel1.Controls.Add(Me.MetroTextBox2)
        Me.MetroPanel1.Controls.Add(Me.MetroTile5)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel2)
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(12, 75)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(366, 397)
        Me.MetroPanel1.TabIndex = 0
        Me.MetroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'MetroTile6
        '
        Me.MetroTile6.ActiveControl = Nothing
        Me.MetroTile6.Location = New System.Drawing.Point(171, 364)
        Me.MetroTile6.Name = "MetroTile6"
        Me.MetroTile6.Size = New System.Drawing.Size(79, 28)
        Me.MetroTile6.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroTile6.TabIndex = 10
        Me.MetroTile6.Text = "DONE"
        Me.MetroTile6.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.MetroTile6.UseSelectable = True
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.Silver
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView1.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.Location = New System.Drawing.Point(11, 268)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(352, 90)
        Me.ListView1.TabIndex = 9
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'MetroTextBox2
        '
        Me.MetroTextBox2.Lines = New String(-1) {}
        Me.MetroTextBox2.Location = New System.Drawing.Point(11, 239)
        Me.MetroTextBox2.MaxLength = 32767
        Me.MetroTextBox2.Name = "MetroTextBox2"
        Me.MetroTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox2.SelectedText = ""
        Me.MetroTextBox2.Size = New System.Drawing.Size(247, 23)
        Me.MetroTextBox2.TabIndex = 0
        Me.MetroTextBox2.UseSelectable = True
        '
        'MetroTile5
        '
        Me.MetroTile5.ActiveControl = Nothing
        Me.MetroTile5.Location = New System.Drawing.Point(283, 234)
        Me.MetroTile5.Name = "MetroTile5"
        Me.MetroTile5.Size = New System.Drawing.Size(66, 28)
        Me.MetroTile5.TabIndex = 8
        Me.MetroTile5.Text = "NEXT"
        Me.MetroTile5.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.MetroTile5.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.Location = New System.Drawing.Point(5, 4)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(360, 233)
        Me.MetroLabel2.TabIndex = 7
        Me.MetroLabel2.Text = resources.GetString("MetroLabel2.Text")
        Me.MetroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroPanel2
        '
        Me.MetroPanel2.Controls.Add(Me.MetroTile7)
        Me.MetroPanel2.Controls.Add(Me.ListView2)
        Me.MetroPanel2.Controls.Add(Me.MetroTextBox3)
        Me.MetroPanel2.Controls.Add(Me.MetroTile8)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel3)
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(15, 67)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(389, 405)
        Me.MetroPanel2.TabIndex = 7
        Me.MetroPanel2.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'MetroTile7
        '
        Me.MetroTile7.ActiveControl = Nothing
        Me.MetroTile7.Location = New System.Drawing.Point(171, 364)
        Me.MetroTile7.Name = "MetroTile7"
        Me.MetroTile7.Size = New System.Drawing.Size(79, 28)
        Me.MetroTile7.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroTile7.TabIndex = 10
        Me.MetroTile7.Text = "DONE"
        Me.MetroTile7.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.MetroTile7.UseSelectable = True
        '
        'ListView2
        '
        Me.ListView2.BackColor = System.Drawing.Color.Silver
        Me.ListView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView2.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView2.Location = New System.Drawing.Point(11, 161)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(352, 197)
        Me.ListView2.TabIndex = 9
        Me.ListView2.UseCompatibleStateImageBehavior = False
        '
        'MetroTextBox3
        '
        Me.MetroTextBox3.Lines = New String(-1) {}
        Me.MetroTextBox3.Location = New System.Drawing.Point(11, 132)
        Me.MetroTextBox3.MaxLength = 32767
        Me.MetroTextBox3.Name = "MetroTextBox3"
        Me.MetroTextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox3.SelectedText = ""
        Me.MetroTextBox3.Size = New System.Drawing.Size(247, 23)
        Me.MetroTextBox3.TabIndex = 0
        Me.MetroTextBox3.UseSelectable = True
        '
        'MetroTile8
        '
        Me.MetroTile8.ActiveControl = Nothing
        Me.MetroTile8.Location = New System.Drawing.Point(286, 127)
        Me.MetroTile8.Name = "MetroTile8"
        Me.MetroTile8.Size = New System.Drawing.Size(66, 28)
        Me.MetroTile8.TabIndex = 8
        Me.MetroTile8.Text = "NEXT"
        Me.MetroTile8.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.MetroTile8.UseSelectable = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel3.Location = New System.Drawing.Point(5, 4)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(360, 110)
        Me.MetroLabel3.TabIndex = 7
        Me.MetroLabel3.Text = "Now, order the tasks by how much time you " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "have for them. Enter the tasks with t" & _
    "he " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "shortest deadline first."
        Me.MetroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroPanel3
        '
        Me.MetroPanel3.Controls.Add(Me.MetroLabel4)
        Me.MetroPanel3.Controls.Add(Me.ListBox5)
        Me.MetroPanel3.Controls.Add(Me.ListBox4)
        Me.MetroPanel3.Controls.Add(Me.ListBox3)
        Me.MetroPanel3.Controls.Add(Me.ListBox2)
        Me.MetroPanel3.HorizontalScrollbarBarColor = True
        Me.MetroPanel3.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel3.HorizontalScrollbarSize = 10
        Me.MetroPanel3.Location = New System.Drawing.Point(12, 61)
        Me.MetroPanel3.Name = "MetroPanel3"
        Me.MetroPanel3.Size = New System.Drawing.Size(701, 453)
        Me.MetroPanel3.TabIndex = 0
        Me.MetroPanel3.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroPanel3.VerticalScrollbarBarColor = True
        Me.MetroPanel3.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel3.VerticalScrollbarSize = 10
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel4.Location = New System.Drawing.Point(17, 3)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(643, 75)
        Me.MetroLabel4.TabIndex = 6
        Me.MetroLabel4.Text = resources.GetString("MetroLabel4.Text")
        Me.MetroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'ListBox5
        '
        Me.ListBox5.BackColor = System.Drawing.Color.Green
        Me.ListBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox5.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox5.FormattingEnabled = True
        Me.ListBox5.ItemHeight = 21
        Me.ListBox5.Location = New System.Drawing.Point(378, 255)
        Me.ListBox5.Name = "ListBox5"
        Me.ListBox5.Size = New System.Drawing.Size(279, 168)
        Me.ListBox5.TabIndex = 5
        '
        'ListBox4
        '
        Me.ListBox4.BackColor = System.Drawing.Color.Orange
        Me.ListBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox4.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.ItemHeight = 21
        Me.ListBox4.Location = New System.Drawing.Point(378, 81)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(279, 168)
        Me.ListBox4.TabIndex = 4
        '
        'ListBox3
        '
        Me.ListBox3.BackColor = System.Drawing.Color.Red
        Me.ListBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox3.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.ItemHeight = 21
        Me.ListBox3.Location = New System.Drawing.Point(17, 81)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(279, 168)
        Me.ListBox3.TabIndex = 3
        '
        'ListBox2
        '
        Me.ListBox2.BackColor = System.Drawing.Color.Orange
        Me.ListBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox2.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 21
        Me.ListBox2.Location = New System.Drawing.Point(17, 255)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(279, 168)
        Me.ListBox2.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 537)
        Me.Controls.Add(Me.MetroPanel3)
        Me.Controls.Add(Me.MetroPanel2)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Controls.Add(Me.MetroTile2)
        Me.Controls.Add(Me.MetroTile4)
        Me.Controls.Add(Me.MetroTile3)
        Me.Controls.Add(Me.MetroTile1)
        Me.Controls.Add(Me.MetroTextBox1)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form1"
        Me.Text = "Prioritize"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel2.ResumeLayout(False)
        Me.MetroPanel3.ResumeLayout(False)
        Me.MetroPanel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTextBox1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTile1 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTile2 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTile3 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTile4 As MetroFramework.Controls.MetroTile
    Friend WithEvents Animator1 As AnimatorNS.Animator
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTextBox2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTile5 As MetroFramework.Controls.MetroTile
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents MetroTile6 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroTile7 As MetroFramework.Controls.MetroTile
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents MetroTextBox3 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTile8 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroPanel3 As MetroFramework.Controls.MetroPanel
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox5 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox4 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox3 As System.Windows.Forms.ListBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel

End Class
