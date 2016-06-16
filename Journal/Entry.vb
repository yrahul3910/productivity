Imports System.Xml.Serialization
<XmlRoot("Entry")>
Public Class Entry
    <XmlAttribute("entryDate")>
    Public entryDate As Date
    <XmlAttribute("Content")>
    Public content As String
    <XmlAttribute("Attachment")>
    Public Attachment As String

    Public Sub New(d As Date, c As String)
        entryDate = d
        content = c
        Attachment = ""
    End Sub

    Public Sub New(d As Date, c As String, a As String)
        entryDate = d
        content = c
        Attachment = a
    End Sub
    Public Sub New()

    End Sub
End Class
