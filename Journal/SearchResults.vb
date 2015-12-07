Public Class SearchResults

    Public Function SplitToLines(str As String) As List(Of String)
        Dim lst As New List(Of String)
        Using SR = New IO.StringReader(str)
            While SR.Peek >= 0
                Dim l As String = SR.ReadLine()
                lst.Add(l)
            End While
        End Using
        Return lst

    End Function
    Private Sub MultiLineListBox1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles MultiLineListBox1.MouseDoubleClick
        Dim index As Integer = MultiLineListBox1.IndexFromPoint(e.Location)
        If Not index = ListBox.NoMatches Then
            Dim item = MultiLineListBox1.SelectedItem
            Dim c As String = SplitToLines(item).ElementAt(0)
            Dim d As Date = CDate(c)
            For Each en As Entry In AllEntries.entries
                If en.entryDate = d Then
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