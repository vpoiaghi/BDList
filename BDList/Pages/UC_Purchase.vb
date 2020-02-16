Imports BDList_DAO_BO.BO
Imports BDList_SERVICE
Imports FrameworkPN

Public Class UC_Purchase

    Private m_svcPurchase As New ServicePurchase
    Private m_svcAd As New ServiceAd
    Private m_purchase As Purchase

    Public Sub New(frm As FrmPagesManager)
        MyBase.New(frm)
        InitializeComponent()

        DGV_Prices.BackgroundColor = DGV_Prices.Parent.BackColor
        DGV_Prices.DefaultCellStyle.BackColor = DGV_Prices.Parent.BackColor

        DGV_PricesMedium.BackgroundColor = DGV_Prices.Parent.BackColor
        DGV_PricesMedium.DefaultCellStyle.BackColor = DGV_Prices.Parent.BackColor

        btn_edit.Enabled = False
        btn_show.Enabled = False

    End Sub

    Protected Overrides Sub Activate()

        Dim purchaseId As Integer = GetParameter(NavParameters.PRM_PURCHASE_ID)
        m_purchase = m_svcPurchase.GetById(purchaseId)

        Refesh()

    End Sub

    Private Sub Refesh()
        RefreshPurchase()
        RefreshAds()
    End Sub

    Private Sub RefreshPurchase()

        If m_purchase IsNot Nothing Then
            With m_purchase
                Me.Title = "Vente de " & .GetSeller.GetAlias & " (" & .GetWebSite.GetName & ") du " & Format(.GetStartDate, "dd/MM/yyyy")
                Lnk_Seller.Text = .GetSeller.GetAlias
                Lbl_PurchaseState.Text = .GetPurchaseState.ToString
                RTB_Comments.Text = .GetComments
            End With
        End If

    End Sub

    Private Sub RefreshAds()

        Dim adsList As List(Of IdBObject) = m_svcAd.GetByPurchase(m_purchase)
        GVw_Ads.SetAdapter(New AdsAdapter(adsList))

        RefreshPurchasePrice(adsList)

    End Sub

    Private Sub RefreshPurchasePrice(adsList As List(Of IdBObject))

        Dim priceAds As Single = 0
        Dim articlesCount As Integer = 0
        Dim ac As Integer

        For Each ad As Ad In adsList

            ac = ad.GetAdArticles.Count

            'temporaire
            'If ac = 0 Then ac = 1
            If ac = 0 Then ac = ad.GetArticlesCount

            If (ad.GetBestPrice >= ad.GetCurrentCost) AndAlso (ac > 0) Then
                priceAds += ad.GetCurrentCost
                articlesCount += ac
            End If
        Next

        Dim pricePostage As Single = m_purchase.GetPostage
        Dim priceTotal As Single = priceAds + pricePostage
        Dim priceByArticle As Single = IIf(articlesCount > 0, priceTotal / articlesCount, 0)

        With DGV_Prices.Rows
            .Clear()
            .Add({"", ""})
            .Add({"Coût des articles", StringUtils.ToMoneyString(priceAds)})
            .Add({"Coût des frais de port", StringUtils.ToMoneyString(pricePostage)})
            .Add({"Coût Total", StringUtils.ToMoneyString(priceTotal)})
            .Item(0).Visible = False
        End With

        With DGV_PricesMedium.Rows
            .Clear()
            .Add({"", ""})
            .Add({"Nombre d'articles", articlesCount})
            .Add({"Coût moyen", StringUtils.ToMoneyString(priceByArticle)})
            .Item(0).Visible = False
        End With

    End Sub

    Private Sub GVw_Ads_ItemSelectionChanged(Sender As Object, e As GridItemSelectedEventArgs) Handles GVw_Ads.ItemSelectionChanged

        Dim itemSelected As Boolean = (e.GetValue IsNot Nothing)

        btn_edit.Enabled = itemSelected
        btn_show.Enabled = itemSelected

    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        GVw_Ads.SelectedItem.ModifyItem()
        RefreshAds()
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click

        Dim newAd As ModifiedItem = FrmWriteAd.CreateOrEdit(Me.ParentForm, Nothing, m_purchase)

        If newAd IsNot Nothing Then

            Dim ad As Ad = CType(newAd.GetItem, Ad)

            If ad IsNot Nothing Then
                m_purchase.GetAds.Add(ad)
                m_svcPurchase.InsertOrUpdate(m_purchase)
                RefreshAds()
            End If

        End If

    End Sub

    Private Sub Lnk_Seller_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Lnk_Seller.LinkClicked
        Dim url As String = "https://www.ebay.fr/sch/m.html?_nkw=&_armrs=1&_from=&_ssn=" & m_purchase.GetSeller.GetAlias & "&_sop=1"
        Process.Start(url)
    End Sub

End Class
