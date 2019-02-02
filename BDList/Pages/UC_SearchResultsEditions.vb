Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.DAO
Imports BDList_SERVICE
Imports FrameworkPN

Public Class UC_SearchResultsEditions

    Private m_searchCriteria As SearchCriteria = Nothing
    Private editionsList As List(Of IdBObject)

    Public Sub New(frm As FrmPagesManager)
        MyBase.New(frm)
        InitializeComponent()
    End Sub

    Protected Overrides Sub Activate()

        m_searchCriteria = GetParameter(NavParameters.PRM_SEARCH_CRITERIA)

        If m_searchCriteria IsNot Nothing Then

            Dim svcEditions As New ServiceEdition
            editionsList = svcEditions.Search(m_searchCriteria)

            Dim adapter As IAdapter = New EditionsAdapter(editionsList)
            lst_editionsList.SetAdapter(adapter)

            Dim itemSelected As Boolean = (lst_editionsList.SelectedItem IsNot Nothing)
            btn_edit.Enabled = itemSelected
            btn_show.Enabled = itemSelected

        End If

    End Sub

    Private Sub btn_series_Click(sender As Object, e As EventArgs) Handles btn_series.Click
        SetParameter(NavParameters.PRM_SEARCH_CRITERIA, m_searchCriteria)
        ShowPage(GetType(UC_SearchResultsSeries).FullName)
    End Sub

    Private Sub btn_goodies_Click(sender As Object, e As EventArgs) Handles btn_goodies.Click
        SetParameter(NavParameters.PRM_SEARCH_CRITERIA, m_searchCriteria)
        ShowPage(GetType(UC_SearchResultsGoodies).FullName)
    End Sub

    Private Sub btn_authors_Click(sender As Object, e As EventArgs) Handles btn_authors.Click
        SetParameter(NavParameters.PRM_SEARCH_CRITERIA, m_searchCriteria)
        ShowPage(GetType(UC_SearchResultsAuthors).FullName)
    End Sub

    Private Sub lst_editionsList_ListItemAction(Sender As Object, e As GridItemActionEventArgs) Handles lst_editionsList.ListItemAction

        If e.GetAction = GridItemActionEventArgs.listItemActions.Show Then
            SetParameter(NavParameters.PRM_EDITION_ID, e.GetParameter(NavParameters.PRM_EDITION_ID))
            'ShowPage(GetType(UC_Edition).FullName)

        ElseIf e.GetAction = GridItemActionEventArgs.listItemActions.Modify Then

        End If

    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click

        Dim gridItem As GridItem = lst_editionsList.SelectedItem

        If gridItem IsNot Nothing Then
            gridItem.ModifyItem()
        End If

    End Sub

    Private Sub btn_show_Click(sender As Object, e As EventArgs) Handles btn_show.Click

        Dim gridItem As GridItem = lst_editionsList.SelectedItem

        If gridItem IsNot Nothing Then
            gridItem.ShowItem()
        End If

    End Sub

    Private Sub lst_editionsList_ItemSelectionChanged(Sender As Object, e As GridItemSelectedEventArgs) Handles lst_editionsList.ItemSelectionChanged

        Dim itemSelected As Boolean = (e.GetValue IsNot Nothing)

        btn_edit.Enabled = itemSelected
        btn_show.Enabled = itemSelected

    End Sub

End Class
