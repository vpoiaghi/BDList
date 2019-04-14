Imports System.Net
Imports System.Web.Script.Serialization

Public Class GoogleBookAPI

    Public Shared Function GetBookInfos(isbn As String) As GBookInfos

        Dim result As GBookInfos = Nothing

        Dim url As String = "https://www.googleapis.com/books/v1/volumes?q=isbn:" & isbn & "&key=AIzaSyB3Z8f544fCYBe7eElVJUoh4N-RIZWAi3k"
        Dim json As String
        Dim booksInfos As GBooksInfos

        Using client As New WebClient()
            json = client.DownloadString(url)
            booksInfos = (New JavaScriptSerializer()).Deserialize(Of GBooksInfos)(json)
        End Using

        If (booksInfos.Items IsNot Nothing) AndAlso (booksInfos.Items.Count > 0) Then
            result = booksInfos.Items(0)
        End If

        Return result

    End Function

End Class
