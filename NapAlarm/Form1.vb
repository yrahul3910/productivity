Imports System.Xml.Serialization
Imports System.IO

Public Class Form1

    Dim timeLeft As Integer
    Public cards As List(Of Card)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Please make sure of two things. First, your computer must not sleep in the nap period. Otherwise, the alarm will not ring. Second, your system volume must be at a level that can wake you up. Click OK to continue.")
        Button1.Enabled = False
        NumericUpDown1.Enabled = False
        lblTimeLeft.Visible = True
        timeLeft = NumericUpDown1.Value * 60
        cmbDifficulty.Enabled = False
        cmbNumberOfProblems.Enabled = False
        cmbLearningStage.Enabled = False
        Button2.Enabled = False
        btnDymaxion.Enabled = False
        btnEveryman.Enabled = False
        TabPage3.Enabled = False
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timeLeft -= 1
        If timeLeft = 0 Then
            WakeUp.Show()
            If cmbDifficulty.Text <> "None" AndAlso cmbNumberOfProblems.Text <> "0" AndAlso cmbNumberOfProblems.Text <> String.Empty Then
                WakeUp.minutes = CInt(cmbNumberOfProblems.Text)
                WakeUp.level = cmbDifficulty.SelectedIndex
            Else
                WakeUp.minutes = 0
                WakeUp.level = 0
            End If
            If Not cards Is Nothing Then
                ' Overrides math
                WakeUp.minutes = 0
                WakeUp.level = 0

                WakeUp.number = cmbLearningStage.SelectedIndex + 1
            Else
                WakeUp.number = -1
            End If
            lblTimeLeft.Visible = False
            Timer1.Stop()
            Hide()
        Else
            If timeLeft >= 60 Then
                lblTimeLeft.Text = "Time Left: " + CInt(timeLeft / 60).ToString() + " minutes."
            Else
                lblTimeLeft.Text = "Time Left: Less than a minute."
            End If
        End If
    End Sub

    Private Sub UbermanCycleToolStripMenuItem_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Please make sure of two things. First, your computer must not sleep in the nap period. Otherwise, the alarm will not ring. Second, your system volume must be at a level that can wake you up. Click OK to continue.")
        Button1.Enabled = False
        NumericUpDown1.Enabled = False
        lblTimeLeft.Visible = True
        timeLeft = 20 * 60
        cmbDifficulty.Enabled = False
        cmbNumberOfProblems.Enabled = False
        Button2.Enabled = False
        btnDymaxion.Enabled = False
        btnEveryman.Enabled = False
        Timer1.Start()
    End Sub

    Private Sub DymaxionCycleToolStripMenuItem_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Please make sure of two things. First, your computer must not sleep in the nap period. Otherwise, the alarm will not ring. Second, your system volume must be at a level that can wake you up. Click OK to continue.")
        Button1.Enabled = False
        NumericUpDown1.Enabled = False
        lblTimeLeft.Visible = True
        timeLeft = 30 * 60
        cmbDifficulty.Enabled = False
        cmbNumberOfProblems.Enabled = False
        Button2.Enabled = False
        btnDymaxion.Enabled = False
        btnEveryman.Enabled = False
        Timer1.Start()
    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs)
        Process.Start("http://www.polyphasicsociety.com/polyphasic-sleep/overviews/")
    End Sub

    Private Sub RadButton2_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Snoozing an alarm is scientifically shown to be bad for you, and it's usually better to just stay up than go back to sleep after snoozing. This is why we don't provide a snooze option in the alarm.")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("Please make sure of two things. First, your computer must not sleep in the nap period. Otherwise, the alarm will not ring. Second, your system volume must be at a level that can wake you up. Click OK to continue.")
        Button1.Enabled = False
        NumericUpDown1.Enabled = False
        lblTimeLeft.Visible = True
        timeLeft = 20 * 60
        cmbDifficulty.Enabled = False
        cmbNumberOfProblems.Enabled = False
        Button2.Enabled = False
        btnDymaxion.Enabled = False
        btnEveryman.Enabled = False
        Timer1.Start()
    End Sub

    Private Sub btnDymaxion_Click(sender As Object, e As EventArgs) Handles btnDymaxion.Click
        MessageBox.Show("Please make sure of two things. First, your computer must not sleep in the nap period. Otherwise, the alarm will not ring. Second, your system volume must be at a level that can wake you up. Click OK to continue.")
        Button1.Enabled = False
        NumericUpDown1.Enabled = False
        lblTimeLeft.Visible = True
        timeLeft = 30 * 60
        cmbDifficulty.Enabled = False
        cmbNumberOfProblems.Enabled = False
        Button2.Enabled = False
        btnDymaxion.Enabled = False
        btnEveryman.Enabled = False
        Timer1.Start()
    End Sub

    Private Sub btnEveryman_Click(sender As Object, e As EventArgs) Handles btnEveryman.Click
        MessageBox.Show("Please make sure of two things. First, your computer must not sleep in the nap period. Otherwise, the alarm will not ring. Second, your system volume must be at a level that can wake you up. Click OK to continue.")
        Button1.Enabled = False
        NumericUpDown1.Enabled = False
        lblTimeLeft.Visible = True
        timeLeft = 20 * 60
        cmbDifficulty.Enabled = False
        cmbNumberOfProblems.Enabled = False
        Button2.Enabled = False
        btnDymaxion.Enabled = False
        btnEveryman.Enabled = False
        Timer1.Start()
    End Sub

    Private Sub browseButton_Click(sender As Object, e As EventArgs) Handles browseButton.Click
        cards = New List(Of Card)
        Try
            If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Dim ser As New XmlSerializer(cards.GetType())
                Using f = File.OpenRead(OpenFileDialog1.FileName)
                    cards = CType(ser.Deserialize(f), List(Of Card))
                End Using
            End If
        Catch

        End Try
    End Sub
End Class
