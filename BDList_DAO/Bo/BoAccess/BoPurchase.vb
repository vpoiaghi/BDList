Namespace BO

    Public MustInherit Class BoPurchase
        Inherits IdBObject

        Dim m_seller As BoSeller
        Dim m_webSite As BoWebSite
        Dim m_purchaseState As BoPurchaseState

        Dim m_postage As Nullable(Of Single)
        Dim m_startDate As Nullable(Of DateTime)
        Dim m_comments As String

        Public Function GetSeller() As BoSeller
            Return m_seller
        End Function

        Public Sub SetSeller(p_seller As BoSeller)
            m_seller = p_seller
        End Sub

        Public Function GetWebSite() As BoWebSite
            Return m_webSite
        End Function

        Public Sub SetWebSite(p_webSite As BoWebSite)
            m_webSite = p_webSite
        End Sub

        Public Function GetPurchaseState() As BoPurchaseState
            Return m_purchaseState
        End Function

        Public Sub SetPurchaseState(p_purchaseState As BoPurchaseState)
            m_purchaseState = p_purchaseState
        End Sub

        Public Function GetPostage() As Nullable(Of Single)
            Return m_postage
        End Function

        Public Sub SetPostage(p_postage As Nullable(Of Single))
            m_postage = p_postage
        End Sub

        Public Function GetStartDate() As Nullable(Of DateTime)
            Return m_startDate
        End Function

        Public Sub SetStartDate(p_StartDate As Nullable(Of DateTime))
            m_startDate = p_StartDate
        End Sub

        Public Function GetComments() As String
            Return m_comments
        End Function

        Public Sub SetComments(p_comments As String)
            m_comments = p_comments
        End Sub

    End Class

End Namespace