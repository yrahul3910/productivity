Imports System.Xml
Imports System.Xml.Serialization
<XmlRoot("Card")> Public Class Card
    <XmlAttribute("Content")>
    Public Content As String
    <XmlAttribute("Back")>
    Public Back As String
    <XmlAttribute("Recall")>
    Public Recall As Integer

    Public Sub New()

    End Sub

    Public Sub New(c As String, b As String, r As Integer)
        Content = c
        Back = b
        Recall = r
    End Sub
End Class

