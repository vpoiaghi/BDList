Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.RequestBuilder
Imports BDList_DATABASE

Namespace DAO

    Public Class DaoAd
        Inherits DaoAccess

        Protected Friend Overrides Function GetBoType() As Type
            Return GetType(Ad)
        End Function

        Protected Friend Overrides Function GetTableName() As String
            Return "Ad"
        End Function

        Protected Friend Overrides Sub InitFieldsList(fieldsNames As FieldList)
            fieldsNames.AddFields("Title",
                                  "Url",
                                  "SellerComments",
                                  "Comments",
                                  "EndOfValidity",
                                  "IdState",
                                  "CurrentCost",
                                  "BestPrice")
        End Sub

        Protected Friend Overrides Sub InitLinkedDaoList()
            AddVeryLinkedDao(GetDao(Of DaoAdArticle))
        End Sub

        Protected Friend Overrides Sub BuildBo(sqlResult As ISqlResult, bo As IdBObject)

            With CType(bo, Ad)

                .SetTitle(sqlResult.GetString("Title"))
                .SetUrl(sqlResult.GetString("Url"))
                .SetSellerComments(sqlResult.GetString("SellerComments"))
                .SetComments(sqlResult.GetString("Comments"))
                .SetEndOfValidity(sqlResult.GetDate("EndOfValidity"))
                .SetCurrentCost(sqlResult.GetSingle("CurrentCost"))
                .SetBestPrice(sqlResult.GetSingle("BestPrice"))

                .SetState(GetLinkedBoById(sqlResult, GetType(DaoAdState), "IdState"))

            End With

        End Sub

        Protected Friend Overrides Sub SetBasicRequestBuilder(ByRef reqBuilder As IBasicRequestBuilder, ByRef obj As IdBObject)

            With CType(obj, Ad)
                reqBuilder.AddValue("Title", GetSqlStringValue(.GetTitle))
                reqBuilder.AddValue("Url", GetSqlStringValue(.GetUrl))
                reqBuilder.AddValue("SellerComments", GetSqlStringValue(.GetSellerComments))
                reqBuilder.AddValue("Comments", GetSqlStringValue(.GetComments))
                reqBuilder.AddValue("EndOfValidity", GetSqlDateValue(.GetEndOfValidity))
                reqBuilder.AddValue("IdState", GetSqlIdValue(.GetState))
                reqBuilder.AddValue("CurrentCost", GetSqlSingleValue(.GetCurrentCost))
                reqBuilder.AddValue("BestPrice", GetSqlSingleValue(.GetBestPrice))
            End With

        End Sub

        Public Function GetByPurchase(purchase As Purchase) As List(Of IdBObject)
            Return GetByPurchase(purchase.GetId)
        End Function

        Public Function GetByPurchase(purchaseId As Long?) As List(Of IdBObject)

            Dim rqt As String = " SELECT Ad.Id" _
                              & " FROM ((Ad" _
                              & " LEFT JOIN Purchase_Ad ON (Ad.Id = Purchase_Ad.IdAd))" _
                              & " LEFT JOIN Ad_AdArticle ON (Ad.Id = Ad_AdArticle.IdAd))" _
                              & " LEFT JOIN AdArticle ON (Ad_AdArticle.IdAdArticle = AdArticle.Id)" _
                              & " WHERE Purchase_Ad.IdPurchase = " & purchaseId _
                              & " ORDER BY EndOfValidity ASC, Title ASC"

            Return GetByIds(rqt)

        End Function

    End Class

End Namespace