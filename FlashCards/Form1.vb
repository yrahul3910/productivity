Imports System.IO
Imports System.Xml
Imports System.Xml.Serialization
Public Class Form1
    Public cards As List(Of Card)
    Dim stage As Integer = 0
    Dim running As Boolean = False
    Dim index As Integer = 0

    Private Sub NewSetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewSetToolStripMenuItem.Click
        cards = New List(Of Card)
        ToolStripStatusLabel1.Text = "Successfully created. Use Cards menu to add cards to set."
    End Sub

    Private Sub Stage_Select(sender As Object, e As EventArgs) Handles RadioButton6.Click, RadioButton5.Click, RadioButton4.Click, RadioButton3.Click, RadioButton2.Click, RadioButton1.Click
        If sender.Checked AndAlso running = False Then
            stage = sender.Text
        Else
            For Each c As Card In cards
                If c.Content = TextBox1.Text Then
                    c.Recall = CInt(sender.Text)
                End If
            Next
            index += 1
            If index = cards.Count Then
                index = 0
            End If
            TextBox1.Text = cards(index).Content
            GroupBox1.Visible = False
            TextBox2.Clear()
        End If
    End Sub

    Private Sub AddToSetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToSetToolStripMenuItem.Click
        If cards Is Nothing Then
            MessageBox.Show("Please create a new card set first.")
            Exit Sub
        End If
        If TextBox1.Text = String.Empty Then
            Exit Sub
        Else
            For Each c1 As Card In cards
                If c1.Content = TextBox1.Text Then
                    MessageBox.Show("Title cannot be duplicate.", "Productivity - Flash Cards", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Next
            Dim c As New Card(TextBox1.Text, TextBox2.Text, stage)
            cards.Add(c)
            ToolStripStatusLabel1.Text = "Added to card set. Total " + cards.Count.ToString() + " cards."
        End If
    End Sub

    Private Sub SaveCurrentSetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveCurrentSetToolStripMenuItem.Click
        Try
            If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Dim ser As New XmlSerializer(cards.GetType())
                Using f = File.Create(SaveFileDialog1.FileName)
                    ser.Serialize(f, cards)
                End Using
                ToolStripStatusLabel1.Text = "Successfully saved."
            End If
        Catch
            Exit Sub
        End Try
    End Sub

    Private Sub LoadExistingSetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadExistingSetToolStripMenuItem.Click
        Try
            If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Dim ser As New XmlSerializer(cards.GetType())
                Using f = File.OpenRead(OpenFileDialog1.FileName)
                    cards = CType(ser.Deserialize(f), List(Of Card))
                End Using
                ToolStripStatusLabel1.Text = "Card set loaded."
            End If
        Catch

        End Try
    End Sub

    Private Sub RemoveFromSetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveFromSetToolStripMenuItem.Click
        For Each c As Card In cards
            If c.Content = TextBox1.Text Then
                cards.Remove(c)
                ToolStripStatusLabel1.Text = "Card successfully removed."
            End If
        Next
        If ToolStripStatusLabel1.Text <> "Card successfully removed." Then
            ToolStripStatusLabel1.Text = "Card not found."
        End If
    End Sub

    Private Sub RunPracticeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RunPracticeToolStripMenuItem.Click
        'RunningSet.Show()
        GroupBox1.Visible = False
        TextBox1.ReadOnly = True
        TextBox2.ReadOnly = True
        TextBox2.Clear()
        running = True
        TextBox1.Text = cards(0).Content
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GroupBox1.Visible = True
        For Each c As Card In cards
            If c.Content = TextBox1.Text Then
                TextBox2.Text = c.Back
            End If
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Please note that this feature is still under development. Although you can make card sets, save and load them, and also run a session, the final build will let you see how much you learned in the session.")
    End Sub
End Class
