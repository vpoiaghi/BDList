Imports BDList_DAO_BO.BO
Imports BDList_SERVICE
Imports FrameworkPN

Public Class UC_NewEditions

    Public Sub New(frm As FrmPagesManager)
        MyBase.New(frm)
        InitializeComponent()
    End Sub

    Protected Overrides Sub Activate()

        RefreshEditorsList()

        Dim itemSelected As Boolean = (lst_newItemsList.SelectedItem IsNot Nothing)
        btn_edit.Enabled = itemSelected
        btn_show.Enabled = itemSelected

    End Sub

    Private Sub lst_editionsList_ListItemAction(Sender As Object, e As GridItemActionEventArgs) Handles lst_newItemsList.ListItemAction

        If e.GetAction = GridItemActionEventArgs.listItemActions.Show Then

            SetParameter(NavParameters.PRM_EDITION_ID, e.GetParameter(NavParameters.PRM_EDITION_ID))

        End If

    End Sub

    Private Sub lst_editors_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_editors.SelectedIndexChanged

        If lst_editors.SelectedIndices.Count = 1 Then

            If lst_editors.SelectedIndices(0) = 0 Then
                RefreshEditionsList()
            Else
                RefreshEditionsList(CType(lst_editors.SelectedItems(0).Tag, Editor))
            End If

            Dim itemSelected As Boolean = (lst_newItemsList.SelectedItem IsNot Nothing)
            btn_edit.Enabled = itemSelected
            btn_show.Enabled = itemSelected

        End If

    End Sub

    Private Sub RefreshEditorsList()

        Dim svcEditor As New ServiceEditor
        Dim editorsList As List(Of IdBObject) = svcEditor.GetHavingNewEditions(Now.AddDays(-30), Now)

        lst_editors.Items.Clear()
        lst_editors.Items.Add("TOUS")

        For Each e As Editor In editorsList

            With lst_editors.Items.Add(e.ToString)
                .Tag = e
            End With

        Next

        lst_editors.Items(0).Selected = True


    End Sub

    Private Sub RefreshEditionsList()

        Dim svcEditions As New ServiceEdition
        Dim items As List(Of IdBObject) = svcEditions.GetEditionByPeriod(Now.AddDays(-30), Now)

        Dim svcGoodies As New ServiceGoody
        items.AddRange(svcGoodies.GetByPeriod(Now.AddDays(-30), Now))

        Dim adapter As IAdapter = New IdBObjectsAdapter(items)

        lst_newItemsList.SetAdapter(adapter)

    End Sub

    Private Sub RefreshEditionsList(editor As Editor)

        Dim svcEditions As New ServiceEdition
        Dim items As List(Of IdBObject) = svcEditions.GetEditionByPeriodAndEditor(Now.AddDays(-30), Now, editor)

        Dim svcGoodies As New ServiceGoody
        items.AddRange(svcGoodies.GetByPeriodAndEditor(Now.AddDays(-30), Now, editor))

        Dim adapter As IAdapter = New IdBObjectsAdapter(items)

        lst_newItemsList.SetAdapter(adapter)

    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click

        Dim gridItem As GridItem = lst_newItemsList.SelectedItem

        If gridItem IsNot Nothing Then
            gridItem.ModifyItem()
        End If

    End Sub

    Private Sub btn_show_Click(sender As Object, e As EventArgs) Handles btn_show.Click

        Dim gridItem As GridItem = lst_newItemsList.SelectedItem

        If gridItem IsNot Nothing Then
            gridItem.ShowItem()
        End If

    End Sub

    Private Sub lst_newItemsList_ItemSelectionChanged(Sender As Object, e As GridItemSelectedEventArgs) Handles lst_newItemsList.ItemSelectionChanged

        Dim itemSelected As Boolean = (e.GetValue IsNot Nothing)

        btn_edit.Enabled = itemSelected
        btn_show.Enabled = itemSelected

    End Sub
End Class
