Imports System.Xml
Imports System.Xml.Serialization
Imports System.IO
Imports System.Windows.Forms
Imports System.Collections
Imports System
Imports System.Drawing
Imports System.Drawing.Printing

Public Class Form1

    Dim tasks As New List(Of Task)
    Dim sortColumn As Integer = -1

    Private Sub ListView1_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles ListView1.ColumnClick
        ' Determine whether the column is the same as the last column clicked.
        If e.Column <> sortColumn Then
            ' Set the sort column to the new column.
            sortColumn = e.Column
            ' Set the sort order to ascending by default.
            ListView1.Sorting = SortOrder.Ascending
        Else
            ' Determine what the last sort order was and change it.
            If ListView1.Sorting = SortOrder.Ascending Then
                ListView1.Sorting = SortOrder.Descending
            Else
                ListView1.Sorting = SortOrder.Ascending
            End If
        End If
        ' Call the sort method to manually sort.
        ListView1.Sort()
        ' Set the ListViewItemSorter property to a new ListViewItemComparer
        ' object.
        ListView1.ListViewItemSorter = New ListViewItemComparer(e.Column, _
                                                         ListView1.Sorting)
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        Try
            Dim coll = ListView1.SelectedItems
            Dim item As ListViewItem = coll(0)
            Dim tit As String = item.Text
            For Each t As Task In tasks
                If tit = t.ID Then
                    TextBox1.Text = t.comment
                End If
            Next
        Catch
            Exit Sub
        End Try
    End Sub

    Private Sub SaveListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveListToolStripMenuItem.Click
        Try
            If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Dim ser As New XmlSerializer(tasks.GetType())
                Using f = File.Create(SaveFileDialog1.FileName)
                    ser.Serialize(f, tasks)
                End Using
            End If
        Catch
            Exit Sub
        End Try
    End Sub

    Private Sub ClearListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearListToolStripMenuItem.Click
        tasks.Clear()
        TextBox1.Clear()
        ListView1.Items.Clear()
    End Sub

    Private Sub LoadListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadListToolStripMenuItem.Click
        Try
            If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Dim ser As New XmlSerializer(tasks.GetType())
                Using f = File.OpenRead(OpenFileDialog1.FileName)
                    tasks = CType(ser.Deserialize(f), List(Of Task))
                End Using
                For Each t As Task In tasks
                    Dim str() As String = {t.ID, t.title, t.severity.ToString(), t.StartDate.Date.ToString("d"), t.deadline.Date.ToString("d"), t.assigner, t.assignee, t.percentage, t.category}
                    ListView1.Items.Add(New ListViewItem(str))
                    If t.deadline.Date = Today.Date Then
                        Dim item As ListViewItem = ListView1.FindItemWithText(t.ID)
                        item.BackColor = Color.Red
                    End If
                    If t.deadline.Date < Today.Date Then
                        Dim item As ListViewItem = ListView1.FindItemWithText(t.ID)
                        item.BackColor = Color.Gray
                    End If
                    If t.Completed = "Yes" Then
                        Dim item As ListViewItem = ListView1.FindItemWithText(t.ID)
                        item.BackColor = Color.Green
                    End If
                Next
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AddTaskToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddTaskToolStripMenuItem.Click
        If ID.Text = String.Empty Then
            Exit Sub
        Else
            For Each t1 As Task In tasks
                If t1.ID = ID.Text Then
                    MessageBox.Show("Task ID cannot be duplicate.", "Productivity - ToDo List", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Next
            Dim str1 As String
            If NumericUpDown1.Value = 100 Then str1 = "Yes" Else str1 = "No"
            Dim t As New Task(Title.Text, ComboBox1.Text, TextBox3.Text, DateTimePicker1.Value.Date, TextBox4.Text, str1,
                              assigner.Text, category.Text, NumericUpDown1.Value, ID.Text, DateTimePicker2.Value.Date)
            If t.deadline.Date < Today.Date Then
                MessageBox.Show("Overdue tasks cannot be added.")
                Exit Sub
            End If
            tasks.Add(t)
            Dim str() As String = {ID.Text, Title.Text, ComboBox1.SelectedIndex.ToString(), DateTimePicker2.Value.Date.ToString("d"), DateTimePicker1.Value.Date.ToString("d"), assigner.Text, TextBox4.Text, NumericUpDown1.Value, category.Text}
            ListView1.Items.Add(New ListViewItem(str))
            If t.deadline.Date = Today.Date Then
                Dim item As ListViewItem = ListView1.FindItemWithText(t.ID)
                item.BackColor = Color.Red
            End If
            If t.Completed = "Yes" Then
                Dim item As ListViewItem = ListView1.FindItemWithText(t.ID)
                item.BackColor = Color.Green
            End If
        End If
    End Sub

    Private Sub RemoveTaskToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveTaskToolStripMenuItem.Click
        Try
            Dim coll = ListView1.SelectedItems
            Dim item As ListViewItem = coll(0)
            Dim tit As String = item.Text
            For Each t As Task In tasks
                If tit = t.ID Then
                    tasks.Remove(t)
                    ListView1.Items.Remove(item)
                    TextBox1.Text = String.Empty
                End If
            Next
        Catch
            Exit Sub
        End Try
    End Sub

    Private Sub MarkAsCompletedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarkAsCompletedToolStripMenuItem.Click
        Try
            Dim coll = ListView1.SelectedItems
            Dim item As ListViewItem = coll(0)
            Dim tit As String = item.Text
            For Each t As Task In tasks
                If tit = t.ID Then
                    item.BackColor = Color.Green
                    t.Completed = "Yes"
                    t.percentage = 100
                End If
            Next
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub UnmarkAsCompletedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnmarkAsCompletedToolStripMenuItem.Click
        Try
            Dim coll = ListView1.SelectedItems
            Dim item As ListViewItem = coll(0)
            Dim tit As String = item.Text
            For Each t As Task In tasks
                If tit = t.ID Then
                    t.Completed = "No"
                    t.percentage = 99
                    item.BackColor = Color.White
                End If
            Next
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub PrintTasksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintTasksToolStripMenuItem.Click
        ListView1.FitToPage = True
        ListView1.Print()
    End Sub

    Private Sub PrintPreviewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintPreviewToolStripMenuItem.Click
        ListView1.FitToPage = True
        ListView1.PrintPreview()
    End Sub

    Private Sub GenerateGanttChartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerateGanttChartToolStripMenuItem.Click
        Try
            Dim tmp1 As List(Of Task) = tasks.OrderBy(Function(x) x.StartDate).ToList()
            Dim startDate As Date = tmp1.ElementAt(0).StartDate.Date
            Dim tmp2 As List(Of Task) = tasks.OrderByDescending(Function(x) x.deadline).ToList()
            Dim endDate As Date = tmp2.ElementAt(0).deadline.Date
            GanttChart1.FromDate = startDate
            GanttChart1.ToDate = endDate
            For i As Integer = 0 To tasks.Count - 1
                GanttChart1.AddChartBar(tasks(i).ID, Nothing, tasks(i).StartDate.Date, tasks(i).deadline.Date, Color.Brown, Color.Green, i)
            Next
        Catch
            Exit Sub
        End Try
    End Sub

    Private Sub SaveAsImageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsImageToolStripMenuItem.Click
        Try
            Dim sfd As New SaveFileDialog
            sfd.Title = "Choose Location"
            sfd.FileName = ""
            sfd.Filter = "JPG File (*.jpg) |*.jpg"
            If sfd.ShowDialog() = Windows.Forms.DialogResult.OK Then
                GanttChart1.SaveImage(sfd.FileName)
            End If
        Catch
            Exit Sub
        End Try
    End Sub

    Private Sub RemoveOverdueTasksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveOverdueTasksToolStripMenuItem.Click
        For Each t As Task In tasks.ToList()
            If t.deadline.Date < Today.Date Then
                tasks.Remove(t)
                TextBox1.Text = String.Empty
            End If
        Next

        For Each t As Task In tasks
            Dim str() As String = {t.ID, t.title, t.severity.ToString(), t.StartDate.Date.ToString("d"), t.deadline.Date.ToString("d"), t.assigner, t.assignee, t.percentage, t.category}
            ListView1.Items.Add(New ListViewItem(str))
            If t.deadline.Date = Today.Date Then
                Dim item As ListViewItem = ListView1.FindItemWithText(t.ID)
                item.BackColor = Color.Red
            End If
            If t.Completed = "Yes" Then
                Dim item As ListViewItem = ListView1.FindItemWithText(t.ID)
                item.BackColor = Color.Green
            End If
        Next
    End Sub

    Private Sub UpdateTaskToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateTaskToolStripMenuItem.Click
        For Each t As Task In tasks
            If t.ID = ID.Text Then
                t.title = Title.Text
                t.severity = ComboBox1.Text
                t.deadline = DateTimePicker1.Value.Date
                t.StartDate = DateTimePicker2.Value.Date
                t.percentage = NumericUpDown1.Value
                If t.percentage = 100 Then t.Completed = "Yes"
                t.assignee = TextBox4.Text
                t.assigner = assigner.Text
                t.category = category.Text
                t.comment = TextBox3.Text

                Dim item As ListViewItem = ListView1.FindItemWithText(t.ID)
                item = New ListViewItem(New String() {t.ID, t.title, t.severity.ToString(), t.StartDate.Date.ToString("d"), t.deadline.Date.ToString("d"), t.assigner, t.assignee, t.percentage, t.category})
                If t.deadline.Date = Today.Date Then
                    item.BackColor = Color.Red
                End If
                If t.deadline.Date < Today.Date Then
                    item.BackColor = Color.Gray
                End If
                If t.Completed = "Yes" Then
                    item.BackColor = Color.Green
                End If
                For Each i As ListViewItem In ListView1.Items
                    If i.SubItems(0).Text = t.ID.ToString() Then
                        Dim index = ListView1.Items.IndexOf(i)
                        ListView1.Items(index) = item
                    End If
                Next
                Exit For
            End If
        Next
    End Sub
End Class

' Implements the manual sorting of items by column.
Class ListViewItemComparer
    Implements IComparer
    Private col As Integer
    Private order As SortOrder

    Public Sub New()
        col = 0
        order = SortOrder.Ascending
    End Sub

    Public Sub New(column As Integer, order As SortOrder)
        col = column
        Me.order = order
    End Sub

    Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements System.Collections.IComparer.Compare
        Dim returnVal As Integer
        ' Determine whether the type being compared is a date type.
        Try
            ' Parse the two objects passed as a parameter as a DateTime.
            Dim firstDate As System.DateTime = DateTime.Parse(CType(x,  _
                                    ListViewItem).SubItems(col).Text)
            Dim secondDate As System.DateTime = DateTime.Parse(CType(y,  _
                                      ListViewItem).SubItems(col).Text)
            ' Compare the two dates.
            returnVal = DateTime.Compare(firstDate, secondDate)
            ' If neither compared object has a valid date format, 
            ' compare as a string.
        Catch
            ' Compare the two items as a string.
            returnVal = [String].Compare(CType(x,  _
                              ListViewItem).SubItems(col).Text, CType(y, ListViewItem).SubItems(col).Text)
        End Try

        ' Determine whether the sort order is descending.
        If order = SortOrder.Descending Then
            ' Invert the value returned by String.Compare.
            returnVal *= -1
        End If
        Return returnVal
    End Function

End Class

