Imports BDList_TOOLS

Namespace BO

    Public MustInherit Class BoAd
        Inherits IdBObject

        Dim m_state As BoAdState

        Dim m_title As String
        Dim m_url As String
        Dim m_sellerComments As String
        Dim m_comments As String
        Dim m_endOfValidity As Nullable(Of DateTime)
        Dim m_currentcost As Nullable(Of Single)
        Dim m_bestPrice As Nullable(Of Single)
        Dim m_articlesCount As Integer

        Public Function GetTitle() As String
            Return m_title
        End Function
        Public Sub SetTitle(p_title As String)
            m_title = p_title
        End Sub

        Public Function GetUrl() As String
            Return m_url
        End Function
        Public Sub SetUrl(p_url As String)
            m_url = p_url
        End Sub

        Public Function GetSellerComments() As String
            Return m_sellerComments
        End Function
        Public Sub SetSellerComments(p_sellercomments As String)
            m_sellerComments = p_sellercomments
        End Sub

        Public Function GetComments() As String
            Return m_Comments
        End Function
        Public Sub SetComments(p_comments As String)
            m_comments = p_comments
        End Sub

        Public Function GetEndOfValidity() As Nullable(Of DateTime)
            Return m_endOfValidity
        End Function
        Public Sub SetEndOfValidity(p_endOfValidity As Nullable(Of DateTime))
            m_endOfValidity = p_endOfValidity
        End Sub

        Public Function GetState() As BoAdState
            Return m_state
        End Function
        Public Sub SetState(p_state As BoAdState)
            m_state = p_state
        End Sub

        Public Function GetCurrentCost() As Nullable(Of Single)
            Return m_currentcost
        End Function
        Public Sub SetCurrentCost(p_currentCost As Nullable(Of Single))
            m_currentcost = p_currentCost
        End Sub

        Public Function GetBestPrice() As Nullable(Of Single)
            Return m_bestPrice
        End Function
        Public Sub SetBestPrice(p_bestPrice As Nullable(Of Single))
            m_bestPrice = p_bestPrice
        End Sub

        Public Function GetArticlesCount() As Integer
            Return m_articlesCount
        End Function
        Public Sub SetArticlesCount(p_articlesCount As Integer)
            m_articlesCount = p_articlesCount
        End Sub

    End Class
End Namespace