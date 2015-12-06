Public Class RunningSet

    Dim index As Integer = 0
    Dim copy_cards As List(Of Card)
    Private Sub RunningSet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Visible = False
        ToolStripStatusLabel1.Text = "Ready. Load cards to start."
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GroupBox1.Visible = True
        For Each c As Card In copy_cards
            If c.Content = TextBox1.Text Then
                TextBox2.Text = c.Back
            End If
        Next
    End Sub

    Private Sub Stage_Select(sender As Object, e As EventArgs) Handles RadioButton6.Click, RadioButton5.Click, RadioButton4.Click, RadioButton3.Click, RadioButton2.Click, RadioButton1.Click
        For Each c As Card In copy_cards
            If c.Content = TextBox1.Text Then
                c.Recall = CInt(sender.Text)
            End If
        Next
        GroupBox1.Visible = False
        index += 1
        If index = copy_cards.Count Then
            index = 0
        End If
        TextBox1.Text = copy_cards(index).Content
    End Sub

    Private Sub StopSessionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StopSessionToolStripMenuItem.Click
        'TODO: Show stats
        Dim fives As Integer = 0
        Dim ones As Integer = 0
        Dim increase As Double = 0
        Dim total As Double = 0
        Dim _tot As Double = 0
        For Each c As Card In copy_cards
            If c.Recall = 5 Then
                fives += 1
            End If
            If c.Recall = 1 Then
                ones += 1
            End If
            For Each c1 As Card In Form1.cards
                If c.Content = c1.Content AndAlso c.Back = c1.Back Then
                    increase += c.Recall - c1.Recall
                End If
            Next
            total += c.Recall
        Next
        For Each c As Card In Form1.cards
            _tot += c.Recall
        Next
        total /= (5 * copy_cards.Count)
        _tot /= (5 * copy_cards.Count)
        increase /= copy_cards.Count
        Dim sb As New System.Text.StringBuilder
        sb.AppendLine("Thank you for running a session. Here are a few stats about your learning progress.")
        sb.AppendLine("Number of cards with full recall ability: " + fives.ToString())
        sb.AppendLine("Number of cards that need most revision (very less recall ability): " + ones.ToString())
        sb.AppendLine("Mean increase in recall ability: " + increase.ToString())
        sb.AppendLine("Total learn percentage: " + total.ToString())
        sb.AppendLine("Learn percentage increase: " + (_tot - total).ToString())
        MessageBox.Show(sb.ToString())
        Close()
    End Sub

    Private Sub RunningSet_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        copy_cards = New List(Of Card)
        For Each c As Card In Form1.cards
            copy_cards.Add(c)
        Next
        ToolStripStatusLabel1.Text = "Loaded " + copy_cards.Count.ToString() + " cards."
    End Sub
End Class