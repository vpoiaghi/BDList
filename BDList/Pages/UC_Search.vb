Imports FrameworkPN
Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.DAO
Imports BDList_SERVICE

Public Class UC_Search

    Dim m_searchCriteria As New SearchCriteria

    Public Sub New(frm As FrmPagesManager)
        MyBase.New(frm)
        InitializeComponent()

        InitEditorsCombo()
        InitCollectionsCombo()

        InitCriteriaComponents()

    End Sub

    Protected Overrides Sub Activate()
        txt_keyword.Focus()
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click

        With m_searchCriteria
            .id = Nothing
            .keyword = Nothing
            .editorName = Nothing
            .kindOfGoodies = Nothing
            .collection = Nothing


            Dim id As String = txt_id.Text.Trim
            If IsNumeric(id) Then
                .id = Integer.Parse(id)
            End If

            .keyword = txt_keyword.Text.Trim.Replace("'", "''")
            .editorName = txt_editor.Text.Trim.Replace("'", "''")
            .kindOfGoodies = cmb_kindOfGoodies.Text.Trim.Replace("'", "''")
            .collection = cmb_collection.Text.Trim.Replace("'", "''")

            With .possessionCriteria
                .inPossession = btn_inPossession.Tag
                .wanted = btn_wanted.Tag
                .missing = btn_missing.Tag
                .inDelivery = btn_inDelivery.Tag
                .reserved = btn_reserved.Tag
                .toReserveAtBDfugue = btn_toReserveAtBDfugue.Tag
                .toReserveAtCultura = btn_toReserveAtCultura.Tag
                .present = btn_present.Tag
            End With

        End With

        SetParameter(NavParameters.PRM_SEARCH_CRITERIA, m_searchCriteria)
        ShowPage(GetType(UC_SearchResultsSeries).FullName)

    End Sub

    Private Sub btn_inPossession_Click(sender As Object, e As EventArgs) Handles btn_inPossession.Click
        ChangePossessionButtonState(btn_inPossession)
    End Sub

    Private Sub btn_wanted_Click(sender As Object, e As EventArgs) Handles btn_wanted.Click
        ChangePossessionButtonState(btn_wanted)
    End Sub

    Private Sub btn_missing_Click(sender As Object, e As EventArgs) Handles btn_missing.Click
        ChangePossessionButtonState(btn_missing)
    End Sub

    Private Sub btn_inDelivery_Click(sender As Object, e As EventArgs) Handles btn_inDelivery.Click
        ChangePossessionButtonState(btn_inDelivery)
    End Sub

    Private Sub btn_reserved_Click(sender As Object, e As EventArgs) Handles btn_reserved.Click
        ChangePossessionButtonState(btn_reserved)
    End Sub

    Private Sub btn_toReserveAtBDfugue_Click(sender As Object, e As EventArgs) Handles btn_toReserveAtBDfugue.Click
        ChangePossessionButtonState(btn_toReserveAtBDfugue)
    End Sub

    Private Sub btn_toReserveAtCultura_Click(sender As Object, e As EventArgs) Handles btn_toReserveAtCultura.Click
        ChangePossessionButtonState(btn_toReserveAtCultura)
    End Sub

    Private Sub btn_present_Click(sender As Object, e As EventArgs) Handles btn_present.Click
        ChangePossessionButtonState(btn_present)
    End Sub


    Private Sub txt_keyword_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_keyword.KeyDown

        If e.KeyCode = Keys.Enter Then
            btn_search.PerformClick()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim serie As Serie = FrmWriteSerie.CreateOrEdit(Me.ParentForm, Nothing)

        If serie IsNot Nothing Then
            SetParameter(NavParameters.PRM_SERIE_ID, serie.GetId)
            ShowPage(GetType(UC_Serie).FullName)
        End If

    End Sub

    Private Sub InitEditorsCombo()

        Dim serviceKindOfGoody As New ServiceKindOfGoody
        Dim kindOfGoodies As List(Of IdBObject) = serviceKindOfGoody.GetAll()

        cmb_kindOfGoodies.Items.Clear()

        For Each kindOfGoody As KindOfGoody In kindOfGoodies
            cmb_kindOfGoodies.Items.Add(kindOfGoody)
        Next

    End Sub

    Private Sub InitCollectionsCombo()

        Dim serviceCollection As New ServiceCollection
        Dim collectionsList As List(Of IdBObject) = serviceCollection.GetAll()

        cmb_collection.Items.Clear()

        For Each collection As Collection In collectionsList
            cmb_collection.Items.Add(collection)
        Next

    End Sub

    Private Sub ChangePossessionButtonState(btn As Button)
        ChangePossessionButtonState(btn, Not btn.Tag)
    End Sub

    Private Sub ChangePossessionButtonState(btn As Button, newState As Boolean)

        If newState Then
            btn.BackColor = Color.Lime
        Else
            btn.BackColor = Color.Gray
        End If

        btn.Tag = newState

    End Sub

    Private Sub btn_reinitialize_Click(sender As Object, e As EventArgs) Handles btn_reinitialize.Click
        InitCriteriaComponents()
    End Sub

    Private Sub InitCriteriaComponents()

        txt_keyword.Text = ""
        txt_id.Text = ""
        txt_editor.Text = ""
        cmb_kindOfGoodies.SelectedItem = Nothing
        cmb_kindOfGoodies.Text = ""
        cmb_collection.SelectedItem = Nothing
        cmb_collection.Text = ""

        ChangePossessionButtonState(btn_inPossession, True)
        ChangePossessionButtonState(btn_wanted, True)
        ChangePossessionButtonState(btn_missing, True)
        ChangePossessionButtonState(btn_inDelivery, True)
        ChangePossessionButtonState(btn_reserved, True)
        ChangePossessionButtonState(btn_toReserveAtBDfugue, True)
        ChangePossessionButtonState(btn_toReserveAtCultura, True)
        ChangePossessionButtonState(btn_present, True)

    End Sub

End Class
