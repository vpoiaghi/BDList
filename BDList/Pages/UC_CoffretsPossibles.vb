Imports FrameworkPN
Imports BDList_DAO_BO.BO
Imports BDList_SERVICE

Public Class UC_CoffretsPossibles

    Private svcSeries As New ServiceSerie
    Private seriesList As List(Of IdBObject) = Nothing

    Public Sub New(frm As FrmPagesManager)
        MyBase.New(frm)
        InitializeComponent()
    End Sub

    Protected Overrides Sub Activate()

        seriesList = svcSeries.GetSeriesWithCoffretAlerts()

        Dim adapter As IAdapter = New SeriesAdapter(seriesList)
        lst_seriesList.SetAdapter(adapter)

    End Sub

    Private Sub lst_seriesList_ItemSelectionChanged(Sender As Object, e As GridItemSelectedEventArgs) Handles lst_seriesList.ItemSelectionChanged

        Dim serie As Serie = CType(e.GetValue, Serie)

        If serie IsNot Nothing Then
            SetParameter(NavParameters.PRM_SERIE_ID, serie.GetId)
            ShowPage(GetType(UC_Serie).FullName)
        End If

    End Sub

End Class
