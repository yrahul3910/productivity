Public Class Events

    Public d As Date

    Private Sub Events_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each it As KeyValuePair(Of String, Date) In AllEntries.journal.map
            If Now > it.Value Then
                Dim final As String = it.Key + Environment.NewLine + it.Value.ToString()
                MultiLineListBox1.Items.Add(final)
            End If
        Next
    End Sub

    Private Sub AddEventToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddEventToolStripMenuItem.Click
        Dim title As String = InputBox("You'll be able to access this event on every year from now.", "Give your event a title!")
        AllEntries.journal.map.Add(title, Today)
        Dim str As String = title + Environment.NewLine + Today.ToString()
    End Sub

    Private Sub MultiLineListBox1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles MultiLineListBox1.MouseDoubleClick
        Dim index As Integer = MultiLineListBox1.IndexFromPoint(e.Location)
        If Not index = ListBox.NoMatches Then
            Dim item = MultiLineListBox1.SelectedItem
            Dim c As String = AllEntries.SplitToLines(item).ElementAt(1)
            Dim d As Date = c
            For Each en As Entry In AllEntries.journal.en
                If en.entryDate = d Then
                    Form1.attachmentMode = 0
                    Form1.Show()
                    Form1.DateTimePicker1.Value = d
                    Form1.TextBox1.Text = en.content
                    Form1.AddEntryToolStripMenuItem.Enabled = False
                    Form1.DateTimePicker1.Enabled = False
                End If
            Next
        End If
    End Sub
End Class