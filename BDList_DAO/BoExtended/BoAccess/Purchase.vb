Imports BDList_DAO_BO.DAO

Namespace BO

    Public Class Purchase
        Inherits BoPurchase

        Private m_ads As List(Of IdBObject)

        Public Function GetAds() As List(Of IdBObject)

            If m_ads Is Nothing Then

                m_ads = New List(Of IdBObject)

                If Me.GetId IsNot Nothing Then
                    Dim daoAd As DAO.DaoAd = DaoManager.GetDao(Of DaoAd)()
                    m_ads = daoAd.GetByPurchase(Me.GetId)
                End If

            End If

            Return m_ads

        End Function

        Public Sub SetAds(ads As List(Of IdBObject))
            m_ads = ads
        End Sub

    End Class

End Namespace