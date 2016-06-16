Imports System.Xml.Serialization
<XmlRoot("Diary")>
Public Class Diary
    <XmlAttribute("Entries")>
    Public en As List(Of Entry)
    <XmlAttribute("Map")>
    Public map As Dictionary(Of String, Date)

    Public Sub New()
        en = New List(Of Entry)
        map = New Dictionary(Of String, Date)
    End Sub
    Public Sub New(e As List(Of Entry), m As Dictionary(Of String, Date))
        en = e
        map = m
    End Sub
    Public Sub New(e As List(Of Entry)) ' For ugrading .journal files
        en = e
        map = New Dictionary(Of String, Date)
    End Sub
End Class
