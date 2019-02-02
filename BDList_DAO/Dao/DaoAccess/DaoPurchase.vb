Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.RequestBuilder
Imports BDList_DATABASE
Imports BDList_TOOLS

Namespace DAO

    Public Class DaoPurchase
        Inherits DaoAccess

        Protected Friend Overrides Function GetBoType() As Type
            Return GetType(Purchase)
        End Function

        Protected Friend Overrides Function GetTableName() As String
            Return "Purchase"
        End Function

        Protected Friend Overrides Sub InitFieldsList(fieldsNames As FieldList)
            fieldsNames.AddFields("IdSeller",
                                  "IdWebSite",
                                  "Postage",
                                  "StartDate",
                                  "IdState",
                                  "Comments")
        End Sub

        Protected Friend Overrides Sub InitLinkedDaoList()
            AddVeryLinkedDao(GetDao(Of DaoAd))
        End Sub

        Protected Friend Overrides Sub BuildBo(sqlResult As ISqlResult, bo As IdBObject)

            With CType(bo, Purchase)

                .SetPostage(sqlResult.GetSingle("Postage"))
                .SetStartDate(sqlResult.GetDate("StartDate"))
                .SetComments(sqlResult.GetString("Comments"))

                .SetSeller(GetLinkedBoById(sqlResult, GetType(DaoSeller), "IdSeller"))
                .SetWebSite(GetLinkedBoById(sqlResult, GetType(DaoWebSite), "IdWebSite"))
                .SetPurchaseState(GetLinkedBoById(sqlResult, GetType(DaoPurchaseState), "IdState"))

            End With

        End Sub

        Protected Friend Overrides Sub SetBasicRequestBuilder(ByRef reqBuilder As IBasicRequestBuilder, ByRef edition As IdBObject)

            With CType(edition, Purchase)
                reqBuilder.AddValue("IdSeller", GetSqlIdValue(.GetSeller))
                reqBuilder.AddValue("IdWebSite", GetSqlIdValue(.GetWebSite))
                reqBuilder.AddValue("Postage", GetSqlSingleValue(.GetPostage))
                reqBuilder.AddValue("StartDate", GetSqlDateValue(.GetStartDate))
                reqBuilder.AddValue("IdState", GetSqlIdValue(.GetPurchaseState))
                reqBuilder.AddValue("Comments", GetSqlStringValue(.GetComments))
            End With

        End Sub

        Public Function GetAllByStartDate() As List(Of IdBObject)

            Dim rqt As String _
                = " SELECT Purchase.Id AS Id" _
                & " FROM Purchase" _
                & " ORDER BY Purchase.StartDate DESC"

            Return GetByIds(rqt)

        End Function

        Public Function GetAllBySeller(sellerId As Long?) As List(Of IdBObject)

            Dim rqt As String _
                = " SELECT Purchase.Id AS Id" _
                & " FROM Purchase" _
                & " WHERE Purchase.IdSeller = " & sellerId _
                & " ORDER BY Purchase.StartDate ASC"

            Return GetByIds(rqt)

        End Function

        Public Function GetByAd(ad As Ad) As List(Of IdBObject)
            Return GetByAd(ad.GetId())
        End Function

        Public Function GetByAd(adId As Long?) As List(Of IdBObject)

            Dim rqt As String _
                = " SELECT Purchase.Id AS Id" _
                & " FROM Purchase" _
                & " LEFT JOIN Purchase_Ad ON (Purchase.Id = Purchase_Ad.IdPurchase)" _
                & " WHERE Purchase_Ad.IdAd = " & adId _
                & " ORDER BY Purchase.StartDate ASC"

            Return GetByIds(rqt)

        End Function

    End Class

End Namespace