Imports System.Environment
Imports System.Net

Public Class Form1
    Inherits MetroFramework.Forms.MetroForm

    Private Sub MetroTile1_Click(sender As Object, e As EventArgs) Handles MetroTile1.Click
        Dim windir As String = GetFolderPath(SpecialFolder.Windows) + "\System32\drivers\etc\hosts"
        Using sw As System.IO.StreamWriter = System.IO.File.AppendText(windir)
            sw.WriteLine("127.0.0.1 www.facebook.com")
            sw.WriteLine("127.0.0.1 m.facebook.com")
            sw.WriteLine("127.0.0.1 www.twitter.com")
            sw.WriteLine("127.0.0.1 mobile.twitter.com")
            sw.WriteLine("127.0.0.1 plus.google.com")
            sw.WriteLine("127.0.0.1 www.yammer.com")
        End Using
        MessageBox.Show("Social media sites blocked. In some PCs, you may need to restart for the effect to take place.")
    End Sub

    Private Sub MetroTile2_Click(sender As Object, e As EventArgs) Handles MetroTile2.Click
        Dim windir As String = GetFolderPath(SpecialFolder.Windows) + "\System32\drivers\etc\hosts"
        My.Computer.FileSystem.WriteAllText(windir, My.Computer.FileSystem.ReadAllText(windir).Replace("127.0.0.1 www.facebook.com", ""), False)
        My.Computer.FileSystem.WriteAllText(windir, My.Computer.FileSystem.ReadAllText(windir).Replace("127.0.0.1 m.facebook.com", ""), False)
        My.Computer.FileSystem.WriteAllText(windir, My.Computer.FileSystem.ReadAllText(windir).Replace("127.0.0.1 www.twitter.com", ""), False)
        My.Computer.FileSystem.WriteAllText(windir, My.Computer.FileSystem.ReadAllText(windir).Replace("127.0.0.1 mobile.twitter.com", ""), False)
        My.Computer.FileSystem.WriteAllText(windir, My.Computer.FileSystem.ReadAllText(windir).Replace("127.0.0.1 plus.google.com", ""), False)
        My.Computer.FileSystem.WriteAllText(windir, My.Computer.FileSystem.ReadAllText(windir).Replace("127.0.0.1 www.yammer.com", ""), False)
        MessageBox.Show("Social media sites unblocked. In some PCs, you may need to restart for the effect to take place.")
    End Sub

    Private Sub MetroTile3_Click(sender As Object, e As EventArgs) Handles MetroTile3.Click
        If Environment.OSVersion.Version.Major >= 6 Then
            Dim path As String = GetFolderPath(SpecialFolder.DesktopDirectory) + "\\GodMode.{ED7BA470-8E54-465E-825C-99712043E01C}"
            System.IO.Directory.CreateDirectory(path)
            MessageBox.Show("Successfully enabled God Mode on your Desktop!")
        Else
            MessageBox.Show("You need Windows Vista or higher for this feature.")
        End If
    End Sub

    Public Function CheckAddress(ByVal URL As String) As Boolean
        Try
            Dim request As WebRequest = WebRequest.Create(URL)
            Dim response As WebResponse = request.GetResponse()
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Private Sub MetroTile5_Click(sender As Object, e As EventArgs) Handles MetroTile5.Click
        If CheckAddress(TextBox1.Text) Then
            Dim str = TextBox1.Text
            str = str.Replace("://", "")
            str = str.Replace("https", "")
            str = str.Replace("http", "")
            Dim windir As String = GetFolderPath(SpecialFolder.Windows) + "\System32\drivers\etc\hosts"
            My.Computer.FileSystem.WriteAllText(windir, My.Computer.FileSystem.ReadAllText(windir).Replace("127.0.0.1 " + str, ""), False)
            MessageBox.Show("Website unblocking successful. You may need to restart your PC for the changes to take effect.")
        Else
            MessageBox.Show("Make sure your URL starts with http://www. or https://www.")
        End If
    End Sub

    Private Sub MetroTile4_Click(sender As Object, e As EventArgs) Handles MetroTile4.Click
        If CheckAddress(TextBox1.Text) Then
            Dim windir As String = GetFolderPath(SpecialFolder.Windows) + "\System32\drivers\etc\hosts"
            Dim str = TextBox1.Text
            str = str.Replace("://", "")
            str = str.Replace("https", "")
            str = str.Replace("http", "")
            Using sw As System.IO.StreamWriter = System.IO.File.AppendText(windir)
                sw.WriteLine("127.0.0.1 " + str)
            End Using
            MessageBox.Show("Website blocked. You may need to restart your PC for the changes to take effect.")
        End If
    End Sub
End Class
