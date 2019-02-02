Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.DAO

Public Class ServicePurchase
    Inherits Service(Of DaoPurchase)

    Public Function GetByAd(ad As Ad) As List(Of IdBObject)
        Return GetDao().GetByAd(ad)
    End Function

    Public Function GetByAd(adId As Long?) As List(Of IdBObject)
        Return GetDao().GetByAd(adId)
    End Function

    Public Function GetAllByStartDate() As List(Of IdBObject)
        Return GetDao().GetAllByStartDate
    End Function

    Public Overrides Sub InsertOrUpdate(purchase As IdBObject)

        Dim serviceAd As New ServiceAd
        For Each ad As Ad In CType(purchase, Purchase).GetAds
            serviceAd.InsertOrUpdate(ad)
        Next

        MyBase.InsertOrUpdate(purchase)

    End Sub

End Class
