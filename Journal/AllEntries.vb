﻿Imports System.Xml
Imports System.Xml.Serialization
Imports System.IO
Imports System.Text.RegularExpressions

Public Class AllEntries

    Public entries As List(Of Entry)

    Private Sub NewJournalToolStripMenuItem_Click(sender As Object, e As EventArgs)
        entries = New List(Of Entry)
        ToolStripStatusLabel1.Text = "Successfully created."
        Me.Text = "New Journal - Journal (Productivity)"
    End Sub

    Private Sub SaveJournalToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If entries Is Nothing Then
            MessageBox.Show("Empty journal", "Productivity", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim ser As New XmlSerializer(entries.GetType())
            Using f = File.Create(SaveFileDialog1.FileName)
                ser.Serialize(f, entries)
            End Using
            ToolStripStatusLabel1.Text = "Successfully saved."
        End If
    End Sub

    Private Function SplitWords(ByVal s As String) As String()
        '
        ' Call Regex.Split function from the imported namespace.
        ' Return the result array.
        '
        Return Regex.Split(s, "\W+")
    End Function
    Private Sub LoadJournalToolStripMenuItem_Click(sender As Object, e As EventArgs)
        entries = New List(Of Entry)
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim ser As New XmlSerializer(entries.GetType())
            Using f = File.OpenRead(OpenFileDialog1.FileName)
                entries = CType(ser.Deserialize(f), List(Of Entry))
            End Using
            ToolStripStatusLabel1.Text = "Journal loaded."
            For Each en As Entry In entries
                Dim d As String = en.entryDate.ToString("d")
                Dim c() As String = SplitWords(en.content)
                Dim str As String
                If c.Count > 4 Then
                    str = c(0) + " " + c(1) + " " + c(2) + " " + c(3) + " " + c(4) + "..."
                Else
                    str = c(0) + "..."
                End If
                Dim final As String = d + Environment.NewLine + str
                MultiLineListBox1.Items.Add(final)
            Next
        End If
    End Sub

    Private Sub AddEntryToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If entries Is Nothing Then
            MessageBox.Show("No journal loaded. Create a new one or load one first.", "Productivity", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Form1.attachmentMode = 1
        Form1.Show()
        Form1.TextBox1.Text = String.Empty
        Form1.DateTimePicker1.Value = Today.Date
        Form1.AddEntryToolStripMenuItem.Enabled = True
        Form1.DateTimePicker1.Enabled = True
    End Sub

    Private Sub MultiLineListBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles MultiLineListBox1.MouseClick
        TextBox1.Text = "Search..."
    End Sub

    Private Sub MultiLineListBox1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles MultiLineListBox1.MouseDoubleClick
        Dim index As Integer = MultiLineListBox1.IndexFromPoint(e.Location)
        If Not index = ListBox.NoMatches Then
            Dim item = MultiLineListBox1.SelectedItem
            Dim c As String = SplitToLines(item).ElementAt(0)
            Dim d As Date = CDate(c)
            For Each en As Entry In entries
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

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        TextBox1.Text = String.Empty
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each en As Entry In entries
            If en.content.Contains(TextBox1.Text) Then
                Dim d As String = en.entryDate.ToString("d")
                Dim c() As String = SplitWords(en.content)
                Dim str As String
                If c.Count > 4 Then
                    str = c(0) + " " + c(1) + " " + c(2) + " " + c(3) + " " + c(4) + "..."
                Else
                    str = c(0) + "..."
                End If
                Dim final As String = d + Environment.NewLine + str
                SearchResults.MultiLineListBox1.Items.Add(final)
            End If
        Next
        SearchResults.Show()
    End Sub

    Private Sub RadButtonElement1_Click(sender As Object, e As EventArgs) Handles RadButtonElement1.Click
        entries = New List(Of Entry)
        ToolStripStatusLabel1.Text = "Successfully created."
        Me.Text = "New Journal - Journal (Productivity)"
    End Sub

    Private Sub RadButtonElement2_Click(sender As Object, e As EventArgs) Handles RadButtonElement2.Click
        If entries Is Nothing Then
            MessageBox.Show("No journal loaded. Create a new one or load one first.", "Productivity", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Form1.attachmentMode = 1
        Form1.Show()
        Form1.TextBox1.Text = String.Empty
        Form1.DateTimePicker1.Value = Today.Date
        Form1.AddEntryToolStripMenuItem.Enabled = True
        Form1.DateTimePicker1.Enabled = True
    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        entries = New List(Of Entry)
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim ser As New XmlSerializer(entries.GetType())
            Using f = File.OpenRead(OpenFileDialog1.FileName)
                entries = CType(ser.Deserialize(f), List(Of Entry))
            End Using
            ToolStripStatusLabel1.Text = "Journal loaded."
            For Each en As Entry In entries
                Dim d As String = en.entryDate.ToString("d")
                Dim c() As String = SplitWords(en.content)
                Dim str As String
                If c.Count > 4 Then
                    str = c(0) + " " + c(1) + " " + c(2) + " " + c(3) + " " + c(4) + "..."
                Else
                    str = c(0) + "..."
                End If
                Dim final As String = d + Environment.NewLine + str
                MultiLineListBox1.Items.Add(final)
            Next
        End If
    End Sub

    Private Sub RadButton2_Click(sender As Object, e As EventArgs) Handles RadButton2.Click
        If entries Is Nothing Then
            MessageBox.Show("Empty journal", "Productivity", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim ser As New XmlSerializer(entries.GetType())
            Using f = File.Create(SaveFileDialog1.FileName)
                ser.Serialize(f, entries)
            End Using
            ToolStripStatusLabel1.Text = "Successfully saved."
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class