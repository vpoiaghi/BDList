Imports BDList_DAO_BO.BO
Imports BDList_SERVICE
Imports FrameworkPN

Public Class UC_Home

    Public Sub New(frm As FrmPagesManager)
        MyBase.New(frm)
        InitializeComponent()
    End Sub

    Protected Overrides Sub Activate()
        RefreshItemsList()
    End Sub

    Private Sub RefreshItemsList()

        Dim svcRecentlyModifiedItems As New ServiceRecentlyModifiedItems()
        Dim items As List(Of IdBObject) = svcRecentlyModifiedItems.getLast(GVw_RecentlyModifiedItems.ColumnsCount * GVw_RecentlyModifiedItems.RowsCount)
        Dim adapter As IAdapter = New RecentlyModifiedItemsAdapter(items)

        GVw_RecentlyModifiedItems.SetAdapter(adapter)

    End Sub

End Class
