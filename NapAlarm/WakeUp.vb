Public Class WakeUp

    Public minutes As Integer 'Number of problems
    Public level As Integer
    Public number As Integer ' Flash Cards Option
    Dim FlashCards As Boolean
    Private Sub WakeUp_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        My.Computer.Audio.Play(My.Resources.Alarm01, AudioPlayMode.BackgroundLoop)
        If minutes > 0 Then
            Button1.Text = "NEXT"
            TextBox1.Visible = True
        Else
            'No math, check for flash cards option
            If Not number = -1 Then
                GoTo UsingFlashCards
            End If
        End If
        Dim rnd = New Random
        Dim lowerBound = Math.Pow(10.0, level)
        Dim upperBound = Math.Pow(10.0, level + 1)

        Dim num1 = rnd.Next(lowerBound, upperBound)
        Dim num2 = rnd.Next(lowerBound, upperBound)
        Dim num3 = rnd.Next(lowerBound, upperBound)
        Label2.Text = num1.ToString() + "+" + num2.ToString() + "-" + num3.ToString()
        Exit Sub
UsingFlashCards:
        For Each c As Card In Form1.cards
            If c.Recall = number Then
                Label2.Text = c.Content
                Exit Sub
            End If
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Visible Then
            If Not FlashCards Then
                Dim dt As New DataTable
                Dim res = dt.Compute(Label2.Text, "").ToString()
                If res = TextBox1.Text Then
                    minutes -= 1
                    If minutes = 0 Then
                        Button1.Text = "DISMISS"
                        TextBox1.Visible = False
                        Label2.Visible = False
                    Else
                        Dim rnd = New Random
                        Dim lowerBound = Math.Pow(10.0, level)
                        Dim upperBound = Math.Pow(10.0, level + 1)

                        Dim num1 = rnd.Next(lowerBound, upperBound)
                        Dim num2 = rnd.Next(lowerBound, upperBound)
                        Dim num3 = rnd.Next(lowerBound, upperBound)
                        Label2.Text = num1.ToString() + "+" + num2.ToString() + "-" + num3.ToString()
                    End If
                End If
            Else
                'Using Flash Cards
                'First check answer
                Dim index As Integer
                For i As Integer = 0 To Form1.cards.Count - 1
                    If Label2.Text = Form1.cards(i).Content Then
                        'Found the card to check answer
                        If TextBox1.Text = Form1.cards(i).Back Then
                            'Correct Answer
                            index = i
                            'Now load it to the next card with the same recall value
                            For j As Integer = index To Form1.cards.Count - 1
                                If Form1.cards(j).Recall = number Then
                                    'Found a card, load it
                                    Label2.Text = Form1.cards(j).Content
                                    Exit Sub
                                End If
                            Next
                            ' No more cards, let user close the alarm.
                            Button1.Text = "DISMISS"
                            TextBox1.Visible = False
                            Label2.Visible = False
                        End If
                    End If
                Next
            End If
        Else
            My.Computer.Audio.Stop()
            Close()
            Form1.Show()
            Form1.cmbDifficulty.Enabled = True
            Form1.cmbLearningStage.Enabled = True
            Form1.cmbNumberOfProblems.Enabled = True
            Form1.Button2.Enabled = True
            Form1.btnDymaxion.Enabled = True
            Form1.browseButton.Enabled = True
            Form1.btnEveryman.Enabled = True
            Form1.Button1.Enabled = True
            Form1.NumericUpDown1.Enabled = True
            Form1.lblTimeLeft.Visible = False
        End If
    End Sub
End Class