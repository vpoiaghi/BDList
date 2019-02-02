Imports BDList_DAO_BO.BO
Imports BDList_SERVICE
Imports FrameworkPN

Public Class UC_Authors

    Private m_authorsItems As New List(Of AuthorListItem)

    Public Sub New(frm As FrmPagesManager)
        MyBase.New(frm)
        InitializeComponent()
    End Sub

    Protected Overrides Sub Activate()
        InitAuthorsList()
        CleanAuthor()
    End Sub

    Private Sub btn_addEvent_Click_1(sender As Object, e As EventArgs) Handles btn_addEvent.Click

        Dim selectedAuthor As Author = Nothing

        If LVwAuthors.SelectedItems.Count = 1 Then
            selectedAuthor = CType(LVwAuthors.SelectedItems(0), AuthorListItem).Author
        End If

        Dim modifiedItem As ModifiedItem = FrmWriteAuthor.CreateOrEdit(Me.ParentForm, Nothing)

        If modifiedItem IsNot Nothing Then

            Dim modifiedAuthor As Author = modifiedItem.GetItem

            If modifiedAuthor IsNot Nothing Then

                If (selectedAuthor IsNot Nothing) AndAlso (modifiedAuthor.GetId = selectedAuthor.GetId) Then
                    SelectAuthor(LVwAuthors.SelectedItems(0))
                Else
                    InitAuthorsList()

                    For Each authorItem As AuthorListItem In LVwAuthors.Items

                        If authorItem.Author.GetId = modifiedAuthor.GetId Then
                            LVwAuthors.SelectedItems.Clear()
                            authorItem.Selected = True
                            Exit For
                        End If

                    Next

                End If
            End If
        End If

    End Sub

    Private Sub TxtFilter_TextChanged(sender As Object, e As EventArgs) Handles TxtFilter.TextChanged
        FilterAuthorsList(TxtFilter.Text.Trim.ToLower)
    End Sub

    Private Sub LVwAuthors_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles LVwAuthors.MouseDoubleClick

        Dim authorItem As AuthorListItem = LVwAuthors.GetItemAt(e.X, e.Y)

        If authorItem IsNot Nothing Then

            FrmWriteAuthor.CreateOrEdit(Me.ParentForm, authorItem.Author)

            SelectAuthor(authorItem)

        End If

    End Sub

    Private Sub LVwAuthors_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LVwAuthors.SelectedIndexChanged

        CleanAuthor()

        If LVwAuthors.SelectedItems.Count = 1 Then
            SelectAuthor(LVwAuthors.SelectedItems(0))
        End If

    End Sub

    Private Sub LVwGoodies_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles LVwGoodies.MouseDoubleClick

        Dim item As ListViewItem = LVwGoodies.GetItemAt(e.X, e.Y)

        If item IsNot Nothing Then

            Dim goody As Goody = CType(item.Tag, Goody)

            SetParameter(NavParameters.PRM_SERIE_ID, goody.GetSeries(0).GetId)
            ShowPage(GetType(UC_Serie).FullName)
        End If

    End Sub

    Private Sub LVwGoodies_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LVwGoodies.SelectedIndexChanged

        If LVwGoodies.SelectedItems.Count = 1 Then

            Dim g As Goody = LVwGoodies.SelectedItems(0).Tag
            Dim serviceGoody As New ServiceGoody

            Try
                PctGoody.Image = ImageUtils.LoadImage(serviceGoody.GetFile(g).GetFullName)
            Catch ex As Exception
                PctGoody.Image = Nothing
            End Try

        Else
            PctGoody.Image = Nothing
        End If

    End Sub


    Private Sub InitAuthorsList()

        Dim serviceAuthor As New ServiceAuthor
        Dim authorsList As List(Of IdBObject) = serviceAuthor.GetAll
        Dim authorItem As AuthorListItem

        m_authorsItems.Clear()
        LVwAuthors.Items.Clear()

        For Each author As BoAuthor In authorsList

            authorItem = New AuthorListItem()
            authorItem.Text = author.ToString
            authorItem.SearchName = author.ToString.Trim.ToLower
            authorItem.Author = author

            LVwAuthors.Items.Add(authorItem)
            m_authorsItems.Add(authorItem)

        Next

    End Sub

    Private Sub FilterAuthorsList(nameFilter As String)

        Dim filter As String = "*" & nameFilter & "*"

        CleanAuthor()

        LVwAuthors.SuspendLayout()
        LVwAuthors.Items.Clear()

        For Each item As AuthorListItem In m_authorsItems

            If item.SearchName Like filter Then
                LVwAuthors.Items.Add(item)
            End If

        Next

        LVwAuthors.ResumeLayout(False)

    End Sub

    Private Sub SelectAuthor(author As AuthorListItem)

        If author Is Nothing Then
            CleanAuthor()
        Else
            InitGoodiesList(author.Author)
        End If

    End Sub

    Private Sub CleanAuthor()

        LVwGoodies.Items.Clear()
        PctGoody.Image = Nothing

    End Sub

    Private Sub InitGoodiesList(author As BoAuthor)

        Dim serviceGoody As New ServiceGoody
        Dim goodiesList As List(Of IdBObject) = serviceGoody.GetAllByAuthor(author)
        Dim goodyItem As ListViewItem

        LVwGoodies.Items.Clear()

        For Each goody As Goody In goodiesList

            goodyItem = New ListViewItem()
            goodyItem.Text = goody.ToString
            goodyItem.Tag = goody
            goodyItem.SubItems.Add(goody.GetSeries(0).ToString)

            LVwGoodies.Items.Add(goodyItem)

        Next

    End Sub

    Private Class AuthorListItem
        Inherits ListViewItem

        Public Author As BoAuthor
        Public SearchName As String

        Public Sub New()
            MyBase.New()
        End Sub

    End Class

End Class
