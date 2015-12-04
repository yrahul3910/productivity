Imports System.Xml
Imports System.Xml.Serialization
<XmlRoot("task")> Public Class Task
    <XmlAttribute("title")>
    Public title As String
    <XmlAttribute("severity")>
    Public severity As Integer
    <XmlAttribute("comment")>
    Public comment As String
    <XmlAttribute("deadline")>
    Public deadline As Date
    <XmlAttribute("assignee")>
    Public assignee As String
    <XmlAttribute("completed")>
    Public Completed As String
    <XmlAttribute("assigner")>
    Public assigner As String
    <XmlAttribute("category")>
    Public category As String
    <XmlAttribute("percentage")>
    Public percentage As Integer
    <XmlAttribute("ID")>
    Public ID As String
    <XmlAttribute("StartDate")>
    Public StartDate As Date

    Public Sub New(t As String, s As Integer, c As String, d As Date, a As String, comp As String, assi As String, cat As String, per As Integer,
                   _id As String, start As Date)
        title = t
        severity = s
        comment = c
        deadline = d
        assignee = a
        Completed = comp
        assigner = assi
        category = cat
        percentage = per
        ID = _id
        StartDate = start
    End Sub

    Public Sub New()

    End Sub
End Class
