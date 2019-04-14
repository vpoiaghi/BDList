Imports FrameworkPN
Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.DAO
Imports BDList_SERVICE

Public Class UC_SearchResultsSeries

    Private svcSeries As New ServiceSerie
    Private svcEditions As New ServiceEdition
    Private svcGoodies As New ServiceGoody
    Private svcAuthors As New ServiceAuthor

    Private m_searchCriteria As SearchCriteria = Nothing

    Private seriesList As List(Of IdBObject) = Nothing
    Private editionsCount As Integer = 0
    Private goodiesCount As Integer = 0
    Private authorsCount As Integer = 0

    Public Sub New(frm As FrmPagesManager)
        MyBase.New(frm)
        InitializeComponent()
    End Sub

    Protected Overrides Sub Activate()

        m_searchCriteria = GetParameter(NavParameters.PRM_SEARCH_CRITERIA)

        If m_searchCriteria IsNot Nothing Then

            seriesList = svcSeries.Search(m_searchCriteria)
            editionsCount = svcEditions.SearchCount(m_searchCriteria)
            goodiesCount = svcGoodies.SearchCount(m_searchCriteria)
            authorsCount = svcAuthors.SearchCount(m_searchCriteria)

            Dim adapter As IAdapter = New SeriesAdapter(seriesList)
            lst_seriesList.SetAdapter(adapter)

            btn_series.Text = seriesList.Count & " Séries"
            btn_editions.Text = editionsCount & " Editions"
            btn_goodies.Text = goodiesCount & " Para-bds"
            btn_authors.Text = authorsCount & " Auteurs"

        End If

    End Sub

    Private Sub btn_series_Click(sender As Object, e As EventArgs) Handles btn_series.Click
        SetParameter(NavParameters.PRM_SEARCH_CRITERIA, m_searchCriteria)
        ShowPage(GetType(UC_SearchResultsSeries).FullName)
    End Sub

    Private Sub btn_editions_Click(sender As Object, e As EventArgs) Handles btn_editions.Click
        SetParameter(NavParameters.PRM_SEARCH_CRITERIA, m_searchCriteria)
        ShowPage(GetType(UC_SearchResultsEditions).FullName)
    End Sub

    Private Sub btn_goodies_Click(sender As Object, e As EventArgs) Handles btn_goodies.Click
        SetParameter(NavParameters.PRM_SEARCH_CRITERIA, m_searchCriteria)
        ShowPage(GetType(UC_SearchResultsGoodies).FullName)
    End Sub

    Private Sub btn_authors_Click(sender As Object, e As EventArgs) Handles btn_authors.Click
        SetParameter(NavParameters.PRM_SEARCH_CRITERIA, m_searchCriteria)
        ShowPage(GetType(UC_SearchResultsAuthors).FullName)
    End Sub

    Private Sub lst_seriesList_ListItemAction(Sender As Object, e As GridItemActionEventArgs) Handles lst_seriesList.ListItemAction

        If e.GetAction = GridItemActionEventArgs.listItemActions.Show Then

            SetParameter(NavParameters.PRM_SERIE_ID, e.GetParameter(NavParameters.PRM_SERIE_ID))
            ShowPage(GetType(UC_Serie).FullName)

        ElseIf e.GetAction = GridItemActionEventArgs.listItemActions.Modify Then


        End If

    End Sub

    Private Sub Btn_AddSerie_Click(sender As Object, e As EventArgs) Handles Btn_AddSerie.Click

        Dim serie As Serie = FrmWriteSerie.CreateOrEdit(Me.ParentForm, Nothing)

        If serie IsNot Nothing Then
            SetParameter(NavParameters.PRM_SERIE_ID, serie.GetId)
            ShowPage(GetType(UC_Serie).FullName)
        End If

    End Sub

    Private Sub lst_seriesList_ItemSelectionChanged(Sender As Object, e As GridItemSelectedEventArgs) Handles lst_seriesList.ItemSelectionChanged

        Dim serie As Serie = CType(e.GetValue, Serie)

        If serie IsNot Nothing Then
            SetParameter(NavParameters.PRM_SERIE_ID, serie.GetId)
            ShowPage(GetType(UC_Serie).FullName)
        End If

    End Sub

End Class
