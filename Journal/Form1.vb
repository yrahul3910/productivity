Imports System.Text.RegularExpressions

Public Class Form1

    Public attachmentMode As Integer  ' 0 means view, 1 means add.
    Public eventMode As Integer
    Public attachmentString As String = ""
    Private Function SplitWords(ByVal s As String) As String()
        '
        ' Call Regex.Split function from the imported namespace.
        ' Return the result array.
        '
        Return Regex.Split(s, "\W+")
    End Function
    Private Sub AddEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddEntryToolStripMenuItem.Click
        For Each ent As Entry In AllEntries.journal.en
            If ent.entryDate = DateTimePicker1.Value.Date Then
                MessageBox.Show("Only one journal entry per day is allowed.", "Productivity", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Next

        Dim en As New Entry(DateTimePicker1.Value.Date, TextBox1.Text, attachmentString)
        AllEntries.journal.en.Add(en)

        Dim d As String = en.entryDate.Date.ToString("d")
        Dim c() As String = SplitWords(en.content)
        Dim str As String
        If c.Count > 4 Then
            str = c(0) + " " + c(1) + " " + c(2) + " " + c(3) + " " + c(4) + "..."
        Else
            str = c(0) + "..."
        End If
        Dim final As String = d + Environment.NewLine + str
        AllEntries.MultiLineListBox1.Items.Add(final)
        Close()
    End Sub

    Private Sub UpdateEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateEntryToolStripMenuItem.Click
        For Each en As Entry In AllEntries.journal.en
            If en.entryDate.Date = DateTimePicker1.Value.Date Then
                en.content = TextBox1.Text
                For Each item In AllEntries.MultiLineListBox1.Items
                    If item.ToString().StartsWith(en.entryDate.Date.ToString("d")) Then
                        Dim d As String = en.entryDate.Date.ToString("d")
                        Dim c() As String = SplitWords(en.content)
                        Dim str As String
                        If c.Count > 4 Then
                            str = c(0) + " " + c(1) + " " + c(2) + " " + c(3) + " " + c(4) + "..."
                        Else
                            str = c(0) + "..."
                        End If
                        Dim final As String = d + Environment.NewLine + str
                        AllEntries.MultiLineListBox1.Items.Remove(item)
                        AllEntries.MultiLineListBox1.Items.Add(final)
                        Exit Sub
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub AttachmentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AttachmentsToolStripMenuItem.Click
        If attachmentMode = 0 Then
            ' VIEW Mode
            Try
                Attachment.PictureBox1.Image = Nothing
                For Each en As Entry In AllEntries.journal.en
                    If en.entryDate.Date = DateTimePicker1.Value.Date Then
                        Attachment.PictureBox1.Image = Attachment.GetImageFromString(en.Attachment)
                        Exit For
                    End If
                Next
                Attachment.btnAddAttachment.Visible = False
                Attachment.btnChooseAttachment.Visible = False
                Attachment.Show()
            Catch
                Exit Sub
            End Try
        Else
            ' ADD Mode
            Attachment.PictureBox1.Image = Nothing
            Attachment.btnAddAttachment.Visible = True
            Attachment.btnChooseAttachment.Visible = True
            Attachment.Show()
        End If
    End Sub

    Private Sub EventsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EventsToolStripMenuItem.Click
        Journal.Events.d = Today
        Journal.Events.Show()
    End Sub
End Class
