Imports BDList_DAO_BO.BO
Imports BDList_SERVICE
Imports FrameworkPN

Public Class UC_Purchases

    Private m_purchases As List(Of IdBObject)

    Public Sub New(frm As FrmPagesManager)
        MyBase.New(frm)
        InitializeComponent()
    End Sub

    Protected Overrides Sub Activate()

        InitPurchasesList()

    End Sub

    Private Sub InitPurchasesList()

        DGV_Purchases.Rows.Clear()
        DGV_Purchases.Refresh()

        Dim svcPurchase As New ServicePurchase

        m_purchases = svcPurchase.GetAllByStartDate()

        For Each purchase As Purchase In m_purchases
            With purchase
                Dim values() As Object = { .GetId, .GetWebSite, .GetSeller, Format(.GetStartDate, "dd/MM/yyyy"), .GetPurchaseState, .GetComments}
                DGV_Purchases.Rows.Add(values)
            End With
        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_showPurchase.Click

        Dim purchaseId As Integer = DGV_Purchases.SelectedRows(0).Cells(0).Value

        SetParameter(NavParameters.PRM_PURCHASE_ID, purchaseId)
        ShowPage(GetType(UC_Purchase).FullName)

    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click

        If DGV_Purchases.SelectedRows.Count = 1 Then

            Dim selectedRowIndex As Integer = DGV_Purchases.SelectedRows.Item(0).Index
            Dim selectedPurchase As Purchase = CType(m_purchases(selectedRowIndex), Purchase)

            Dim modifiedPurchase As ModifiedItem = FrmWritePurchase.CreateOrEdit(Me.ParentForm, selectedPurchase)

            If modifiedPurchase IsNot Nothing Then
                InitPurchasesList()
                DGV_Purchases.Rows.Item(selectedRowIndex).Selected = True
            End If

        End If

    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click

        Dim newPurchase As ModifiedItem = FrmWritePurchase.CreateOrEdit(Me.ParentForm, Nothing)

        If newPurchase IsNot Nothing Then
            InitPurchasesList()
        End If

    End Sub
End Class
