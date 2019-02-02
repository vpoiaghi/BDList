Imports BDList_TOOLS
Imports System.ComponentModel

Public Class FrmPagesManager

    Private Shared m_currentPage As UC_Page = Nothing

    Private Shared m_pagesNameHashtable As New Hashtable(Of String, UC_Page)
    Private Shared m_pagesIndexHashtable As New Hashtable(Of Integer, UC_Page)
    Private Shared m_parameters As New Hashtable(Of Integer, Object)

    Private Shared m_pagesHistory As New List(Of MemorisedPage)
    Private Shared m_indexOfLastPageInHistory As Integer = -1

    Public Sub New()
        InitializeComponent()
    End Sub

    Protected Sub AddPage(page As UserControl, parentContainer As Component)

        With page
            .Parent = parentContainer
            .Visible = False
            .Dock = DockStyle.Fill
        End With

        m_pagesNameHashtable.Add(page.GetType.FullName, page)
        m_pagesIndexHashtable.Add(m_pagesIndexHashtable.Count, page)

    End Sub

    Protected Sub ShowPage(pageIndex As Integer)

        Dim pageToShow As UC_Page = m_pagesIndexHashtable.Item(pageIndex)

        If pageToShow Is Nothing Then
            MsgBox("La page à l'indice " & pageIndex & " n'a pas été trouvée.", vbOKOnly + vbCritical, "Page inconnue...")

        ElseIf pageToShow IsNot m_currentPage Then
            pageToShow.Visible = True

            For i As Integer = 0 To m_pagesIndexHashtable.Count - 1
                If (i <> pageIndex) Then
                    m_pagesIndexHashtable.Item(i).Visible = False
                End If
            Next

            pageToShow.Activate()
            m_currentPage = pageToShow

        End If

    End Sub

    Public Shared Sub ShowPreviousPage()

        If m_indexOfLastPageInHistory > -1 Then

            Dim memPage As MemorisedPage = m_pagesHistory(m_indexOfLastPageInHistory)
            m_indexOfLastPageInHistory = m_indexOfLastPageInHistory - 1

            m_parameters = memPage.Parameters
            GotoPage(memPage.Page)

        End If

    End Sub

    Public Shared Sub ShowPage(pageName As String)

        Dim pageToShow As UC_Page = m_pagesNameHashtable.Item(pageName)

        If pageToShow Is Nothing Then
            MsgBox("La page " & pageName & " n'a pas été trouvée.", vbOKOnly + vbCritical, "Page inconnue...")
        Else
            MemoriseCurrentPageInHistory()
            GotoPage(pageToShow)
        End If

    End Sub

    Public Function GetCurrentPage() As UC_Page
        Return m_currentPage
    End Function

    Public Function GetCurrentPageName() As String
        Return m_currentPage.GetType.FullName
    End Function

    Public Shared Sub SetParameter(key As Integer, value As Object)
        m_parameters.Add(key, value)
    End Sub

    Public Function GetParameter(key As Integer) As Object
        Return m_parameters.Item(key)
    End Function

    Private Shared Sub GotoPage(pageToShow As UC_Page)

        pageToShow.SendToBack()
        pageToShow.Show()
        pageToShow.Activate()

        For Each p As UC_Page In m_pagesNameHashtable.Values
            If (p IsNot pageToShow) AndAlso (p.Visible) Then
                p.Hide()
            End If
        Next

        m_currentPage = pageToShow

    End Sub

    Private Shared Sub MemoriseCurrentPageInHistory()

        If m_indexOfLastPageInHistory > -1 Then
            While (m_pagesHistory.Count > 0) AndAlso (m_indexOfLastPageInHistory < m_pagesHistory.Count - 1)
                m_pagesHistory.RemoveAt(m_pagesHistory.Count - 1)
            End While
        End If

        Dim memPage As New MemorisedPage
        memPage.Page = m_currentPage
        memPage.Parameters = m_parameters.Clone

        m_pagesHistory.Add(memPage)
        m_indexOfLastPageInHistory += 1

    End Sub

End Class