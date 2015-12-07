Public Class Attachment

    Public Shared Function GetImageFromString(base64String As String) As Image
        If String.IsNullOrWhiteSpace(base64String) Then Return Nothing
        Dim buffer As Byte() = Convert.FromBase64String(base64String)
        If buffer IsNot Nothing Then
            Dim ic As New ImageConverter()
            Return TryCast(ic.ConvertFrom(buffer), Image)
        Else
            Return Nothing
        End If
    End Function
    Public Shared Function GetStringFromImage(image As Image) As String
        If image IsNot Nothing Then
            Dim ic As New ImageConverter()
            Dim buffer As Byte() = DirectCast(ic.ConvertTo(image, GetType(Byte())), Byte())
            Return Convert.ToBase64String(buffer, Base64FormattingOptions.InsertLineBreaks)
        Else
            Return Nothing
        End If
    End Function

    Private Sub btnAddAttachment_Click(sender As Object, e As EventArgs) Handles btnAddAttachment.Click
        Dim str As String = GetStringFromImage(PictureBox1.Image)
        Form1.attachmentString = str
        Close()
    End Sub

    Private Sub btnChooseAttachment_Click(sender As Object, e As EventArgs) Handles btnChooseAttachment.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "JPEG Files | *.jpg | PNG Files | *.png"
        ofd.FileName = ""
        ofd.Multiselect = False
        ofd.Title = "Choose Attachment"
        If ofd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(ofd.FileName)
        End If
    End Sub
End Class