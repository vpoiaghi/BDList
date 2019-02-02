Imports BDList_DAO_BO.BO
Imports BDList_SERVICE
Imports FrameworkPN

Public Class UC_Press

    Public Sub New(frm As FrmPagesManager)
        MyBase.New(frm)
        InitializeComponent()
    End Sub

    Protected Overrides Sub Activate()

        RefreshSeriesList()

    End Sub

    Private Sub lst_itemsList_ListItemAction(Sender As Object, e As GridItemActionEventArgs) Handles lst_itemsList.ListItemAction

        If e.GetAction = GridItemActionEventArgs.listItemActions.Show Then
            SetParameter(NavParameters.PRM_SERIE_ID, e.GetParameter(NavParameters.PRM_SERIE_ID))
        End If

    End Sub

    Private Sub lst_series_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles lst_series.SelectedIndexChanged

        If lst_series.SelectedIndices.Count = 1 Then

            If lst_series.SelectedIndices(0) = 0 Then
                RefreshItemsList()
            Else
                RefreshItemsList(CType(lst_series.SelectedItems(0).Tag, Serie))
            End If

        End If

    End Sub

    Private Sub RefreshSeriesList()

        Dim svcSerie As New ServiceSerie

        lst_series.Items.Clear()
        lst_series.Items.Add("TOUS")

        ' Figurines marvel
        Dim s As Serie = svcSerie.GetById(678)
        lst_series.Items.Add(s.ToString).Tag = s

        ' Marvel collection Hachette
        s = svcSerie.GetById(501)
        lst_series.Items.Add(s.ToString).Tag = s

        ' DC Comics
        s = svcSerie.GetById(610)
        lst_series.Items.Add(s.ToString).Tag = s

        ' DC Comics - Batman
        s = svcSerie.GetById(903)
        lst_series.Items.Add(s.ToString).Tag = s

        ' Valerian
        s = svcSerie.GetById(859)
        lst_series.Items.Add(s.ToString).Tag = s

        lst_series.Items(0).Selected = True


    End Sub

    Private Sub RefreshItemsList()

        Dim svcEditions As New ServiceEdition
        Dim svcGoodies As New ServiceGoody
        Dim items As New List(Of IdBObject)
        Dim s As Serie

        For i As Integer = 1 To lst_series.Items.Count - 1
            s = lst_series.Items(i).Tag
            items.AddRange(svcEditions.GetAllBySerie(s))
            items.AddRange(svcGoodies.GetAllBySerie(s))
        Next

        Dim adapter As IAdapter = New PressAdapter(items)

        lst_itemsList.SetAdapter(adapter)

    End Sub

    Private Sub RefreshItemsList(serie As Serie)

        Dim svcEditions As New ServiceEdition
        Dim items As List(Of IdBObject) = svcEditions.GetAllBySerie(serie)

        Dim svcGoodies As New ServiceGoody
        items.AddRange(svcGoodies.GetAllBySerie(serie))

        Dim adapter As IAdapter = New PressAdapter(items)

        lst_itemsList.SetAdapter(adapter)

    End Sub

End Class
