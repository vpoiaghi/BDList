Imports BDList_DAO_BO.BO
Imports BDList_DATABASE
Imports FrameworkPN

Public Class FrmMain

    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    Private Sub Form1_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        ConnectionPool.CloseAll()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        AddPage(New UC_Home(Me), Pnl_Main)
        AddPage(New UC_Search(Me), Pnl_Main)
        AddPage(New UC_SearchResultsSeries(Me), Pnl_Main)
        AddPage(New UC_SearchResultsEditions(Me), Pnl_Main)
        AddPage(New UC_SearchResultsGoodies(Me), Pnl_Main)
        AddPage(New UC_SearchResultsAuthors(Me), Pnl_Main)
        AddPage(New UC_ExLibris(Me), Pnl_Main)
        AddPage(New UC_NewEditions(Me), Pnl_Main)
        AddPage(New UC_Coming(Me), Pnl_Main)
        AddPage(New UC_Serie(Me), Pnl_Main)
        AddPage(New UC_Synchronize(Me), Pnl_Main)
        AddPage(New UC_Events(Me), Pnl_Main)
        AddPage(New UC_Author(Me), Pnl_Main)
        AddPage(New UC_Authors(Me), Pnl_Main)
        AddPage(New UC_Editors(Me), Pnl_Main)
        AddPage(New UC_Press(Me), Pnl_Main)
        AddPage(New UC_Purchases(Me), Pnl_Main)
        AddPage(New UC_Purchase(Me), Pnl_Main)
        AddPage(New UC_Statistics(Me), Pnl_Main)
        AddPage(New UC_Tests(Me), Pnl_Main)
        AddPage(New UC_Festivals(Me), Pnl_Main)
        ShowPage(0)

        Menu_App.Items.Add("Accueil", GetType(UC_Home).FullName, My.Resources.menu_home)
        Menu_App.Items.Add("Recherche", GetType(UC_Search).FullName, My.Resources.menu_search)
        Menu_App.Items.Add("Nouveautés", GetType(UC_NewEditions).FullName, My.Resources.menu_new)
        Menu_App.Items.Add("A paraître", GetType(UC_Coming).FullName, My.Resources.menu_coming)
        Menu_App.Items.Add("Ex-Libris", GetType(UC_ExLibris).FullName, My.Resources.menu_exlibris)
        Menu_App.Items.Add("Auteurs", GetType(UC_Authors).FullName, My.Resources.menu_author)
        Menu_App.Items.Add("Editeurs", GetType(UC_Editors).FullName, My.Resources.menu_editor)
        Menu_App.Items.Add("Evènements", GetType(UC_Events).FullName, My.Resources.menu_events)
        Menu_App.Items.Add("En presse", GetType(UC_Press).FullName, My.Resources.menu_events)
        Menu_App.Items.Add("Festivals", GetType(UC_Festivals).FullName, My.Resources.menu_festival)
        Menu_App.Items.Add("Statistiques", GetType(UC_Statistics).FullName, My.Resources.menu_statistics)
        Menu_App.Items.Add("Suivi des achats", GetType(UC_Purchases).FullName, My.Resources.menu_boughts)
        Menu_App.Items.Add("Synchronisation", GetType(UC_Synchronize).FullName, My.Resources.menu_synchronize)
        Menu_App.Items.Add("Print", My.Resources.menu_print)
        Menu_App.Items.Add("Test", GetType(UC_Tests).FullName, My.Resources.menu_synchronize)

    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        ShowPage(GetType(UC_Search).FullName)
    End Sub

    Private Sub btn_news_Click(sender As Object, e As EventArgs) Handles btn_news.Click
        ShowPage(GetType(UC_NewEditions).FullName)
    End Sub

    Private Sub btn_coming_Click(sender As Object, e As EventArgs) Handles btn_coming.Click
        ShowPage(GetType(UC_Coming).FullName)
    End Sub

    Private Sub btn_synchronize_Click(sender As Object, e As EventArgs) Handles btn_synchronize.Click
        ShowPage(GetType(UC_Synchronize).FullName)
    End Sub

    Private Sub btn_addSerie_Click(sender As Object, e As EventArgs) Handles btn_addSerie.Click

        Dim serie As Serie = FrmWriteSerie.CreateOrEdit(Me, Nothing)

        If serie IsNot Nothing Then
            SetParameter(NavParameters.PRM_SERIE_ID, serie.GetId)
            ShowPage(GetType(UC_Serie).FullName)
        End If

    End Sub

    Private Sub btn_events_Click(sender As Object, e As EventArgs) Handles btn_events.Click
        ShowPage(GetType(UC_Events).FullName)
    End Sub

    Private Sub Pct_BtnHome_Click(sender As Object, e As EventArgs) Handles Pct_BtnHome.Click
        ShowPage(GetType(UC_Home).FullName)
    End Sub

    Private Sub Menu_App_OnGoToTarget(Sender As MenuItem, Target As String) Handles Menu_App.OnGoToTarget
        ShowPage(Target)
    End Sub

    Private Sub Pct_BtnPrevPage_Click(sender As Object, e As EventArgs) Handles Pct_BtnPrevPage.Click
        ShowPreviousPage()
    End Sub

End Class