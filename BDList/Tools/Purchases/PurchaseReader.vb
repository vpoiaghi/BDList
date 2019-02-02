Imports System.Xml

Public MustInherit Class PurchaseReader
    Implements IPurchaseReader

    Private m_source As String = Nothing
    Private m_title As String = Nothing
    Private m_images As List(Of Image)
    Private m_endOfValidity As DateTime? = Nothing
    Private m_currentCost As Single? = Nothing
    Private m_comments As String

    Public MustOverride Function GetBaseUrl() As String Implements IPurchaseReader.GetBaseUrl
    Public MustOverride Function GetSiteName() As String Implements IPurchaseReader.GetSiteName
    Protected MustOverride Function ExtractTitle(ByVal source As HtmlDocument) As String
    Protected MustOverride Function ExtractImages(ByVal source As HtmlDocument) As List(Of Image)
    Protected MustOverride Function ExtractEndOfValidity(ByVal source As HtmlDocument) As DateTime?
    Protected MustOverride Function ExtractCurrentCost(ByVal source As HtmlDocument) As Single?
    Protected MustOverride Function ExtractComments(ByVal source As HtmlDocument) As String


    Public Sub ReadSource(source As String) Implements IPurchaseReader.ReadSource

        m_source = source

        If Not String.IsNullOrEmpty(source) Then

            Dim doc As HtmlDocument = GetDocument(source)

            m_title = ExtractTitle(doc)
            If String.IsNullOrEmpty(m_title) Then
                m_title = "Sans titre"
            End If

            m_images = ExtractImages(doc)
            If m_images Is Nothing Then
                m_images = New List(Of Image)
            End If

            m_endOfValidity = ExtractEndOfValidity(doc)
            m_currentCost = ExtractCurrentCost(doc)
            m_comments = ExtractComments(doc)

        End If

    End Sub

    Private Function GetDocument(source As String) As HtmlDocument

        Dim browser = New WebBrowser()

        browser.ScriptErrorsSuppressed = True
        browser.DocumentText = source
        browser.Document.OpenNew(True)
        browser.Document.Write(source)
        browser.Refresh()

        Return browser.Document

    End Function

    Public Function GetImages() As List(Of Image) Implements IPurchaseReader.GetImages

        Dim images As New List(Of Image)

        For Each img As Image In m_images
            images.Add(img.Clone())
        Next

        Return images

    End Function

    Public Function GetTitle() As String Implements IPurchaseReader.GetTitle
        Return m_title
    End Function

    Public Function GetEndOfValidity() As DateTime? Implements IPurchaseReader.GetEndOfValidity
        Return m_endOfValidity
    End Function

    Public Function GetCurrentCost() As Single? Implements IPurchaseReader.GetCurrentCost
        Return m_currentCost
    End Function

    Public Function GetComments() As String Implements IPurchaseReader.GetComments
        Return m_comments
    End Function

End Class
