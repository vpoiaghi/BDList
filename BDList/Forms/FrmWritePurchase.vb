Imports BDList_DAO_BO.BO
Imports BDList_SERVICE

Public Class FrmWritePurchase

    Private Shared m_servicePurchase As New ServicePurchase

    Private m_purchase As Purchase
    Private m_purchaseResult As Purchase

    Private Sub New(ByRef purchase As Purchase)

        InitializeComponent()

        InitStatesList()

        m_purchase = purchase

        LoadPurchase()

    End Sub

    Public Shared Function CreateOrEdit(owner As Form, purchase As Purchase) As ModifiedItem

        Dim isNewPurchase As Boolean = False
        Dim modifiedPurchase As ModifiedItem = Nothing

        If purchase Is Nothing Then
            purchase = m_servicePurchase.GetNew()
            isNewPurchase = True
        End If

        If purchase Is Nothing Then
            Throw New NullReferenceException()

        Else
            modifiedPurchase = New ModifiedItem(purchase)

            Dim frm As New FrmWritePurchase(purchase)
            frm.ShowDialog(owner)

            If frm.DialogResult = Windows.Forms.DialogResult.OK Then
                m_servicePurchase.InsertOrUpdate(purchase)
            Else
                If isNewPurchase Then
                    m_servicePurchase.Delete(purchase)
                End If
                modifiedPurchase = Nothing
            End If

            frm.Close()
            frm.Dispose()

        End If

        Return modifiedPurchase

    End Function

    Public Function GetPurchase() As Purchase
        Return m_purchaseResult
    End Function

    Private Sub Btn_OK_Click(sender As Object, e As EventArgs) Handles Btn_OK.Click

        If ValidateBeforeSave() Then
            Save()
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If

    End Sub

    Private Sub Btn_Cancel_Click(sender As Object, e As EventArgs) Handles Btn_Cancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Function ValidateBeforeSave() As Boolean

        Dim allowSave As Boolean = True
        Dim errMsg As String = Nothing

        If (slst_websites.Items Is Nothing) OrElse (slst_websites.Items.Count = 0) Then
            errMsg = "Indiquez le site de vente."
        End If

        If (slst_sellers.Items Is Nothing) OrElse (slst_sellers.Count = 0) Then
            errMsg = "Indiquez le vendeur."
        End If

        If errMsg IsNot Nothing Then
            Call MsgBox(errMsg, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Informations incomplètes...")
            allowSave = False
        End If

        Dim value As String = Dtb_StartDate.Text.Trim
        If (Not String.IsNullOrEmpty(value)) AndAlso (Not IsDate(value)) Then
            errMsg = "Le format de la date initiale n'est pas valide."
        End If

        Dim purchaseState As PurchaseState = CType(Cmb_State.SelectedItem, PurchaseState)
        If purchaseState Is Nothing Then
            errMsg = "Indiquez le suivi."
        End If

        If errMsg IsNot Nothing Then
            Call MsgBox(errMsg, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Informations incomplètes...")
            allowSave = False
        End If

        Return allowSave

    End Function

    Private Sub Save()

        If m_purchase Is Nothing Then
            m_purchase = m_servicePurchase.GetNew
        End If

        m_purchase.SetSeller(slst_sellers.Items(0))
        m_purchase.SetPostage(CSng(Txt_Postage.Text.Trim))
        m_purchase.SetWebSite(slst_websites.Items(0))
        m_purchase.SetStartDate(Dtb_StartDate.GetDate)
        m_purchase.SetPurchaseState(Cmb_State.SelectedItem)
        m_purchase.SetComments(RTB_Comments.Text.Trim)

        m_purchaseResult = m_purchase

    End Sub

    Private Sub InitStatesList()

        Dim svcPurchaseState As New ServicePurchaseState

        Cmb_State.Items.Clear()

        For Each state As PurchaseState In svcPurchaseState.GetAll()
            Cmb_State.Items.Add(state)
        Next

    End Sub

    Private Sub LoadPurchase()

        With m_purchase

            Dim serviceSeller As New ServiceSeller
            slst_sellers.SetValues(serviceSeller.GetAll)

            Dim serviceWebSite As New ServiceWebSite
            slst_websites.SetValues(serviceWebSite.GetAll)

            If m_purchase.GetSeller IsNot Nothing Then
                slst_sellers.AddItem(m_purchase.GetSeller)
            End If

            If m_purchase.GetWebSite IsNot Nothing Then
                slst_websites.AddItem(m_purchase.GetWebSite)
            End If

            If m_purchase.GetPostage() IsNot Nothing Then
                Txt_Postage.Text = m_purchase.GetPostage()
            End If

            If m_purchase.GetStartDate() IsNot Nothing Then
                Dtb_StartDate.SetDate(m_purchase.GetStartDate())
            End If

            If m_purchase.GetPurchaseState() IsNot Nothing Then
                Cmb_State.SelectedItem = m_purchase.GetPurchaseState()
            End If

            RTB_Comments.Text = m_purchase.GetComments()

        End With

    End Sub

End Class