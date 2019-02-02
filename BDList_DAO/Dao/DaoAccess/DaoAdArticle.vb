Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.RequestBuilder
Imports BDList_DATABASE

Namespace DAO

    Public Class DaoAdArticle
        Inherits DaoAccess

        Protected Friend Overrides Function GetBoType() As Type
            Return GetType(AdArticle)
        End Function

        Protected Friend Overrides Function GetTableName() As String
            Return "AdArticle"
        End Function

        Protected Friend Overrides Sub InitFieldsList(fieldsNames As FieldList)
            fieldsNames.AddFields("IdEdition",
                                  "IdGoody",
                                  "WithNumber",
                                  "WithAutograph")
        End Sub

        Protected Friend Overrides Sub BuildBo(sqlResult As ISqlResult, bo As IdBObject)

            With CType(bo, AdArticle)

                .SetWithNumber(sqlResult.GetInteger("WithNumber"))
                .SetWithAutograph(sqlResult.GetInteger("WithAutograph"))

                .SetEdition(GetLinkedBoById(sqlResult, GetType(DaoEdition), "IdEdition"))
                .SetGoody(GetLinkedBoById(sqlResult, GetType(DaoGoody), "IdGoody"))

            End With

        End Sub

        Protected Friend Overrides Sub SetBasicRequestBuilder(ByRef reqBuilder As IBasicRequestBuilder, ByRef obj As IdBObject)

            With CType(obj, AdArticle)
                reqBuilder.AddValue("IdEdition", GetSqlIdValue(.GetEdition))
                reqBuilder.AddValue("IdGoody", GetSqlIdValue(.GetGoody))

                reqBuilder.AddValue("WithNumber", GetSqlIntegerValue(.IsWithNumber))
                reqBuilder.AddValue("WithAutograph", GetSqlIntegerValue(.IsWithAutograph))
            End With

        End Sub

        Public Function GetByAd(ad As Ad) As List(Of IdBObject)
            Return GetByAd(ad.GetId)
        End Function

        Public Function GetByAd(adId As Long?) As List(Of IdBObject)

            Dim rqt As String = " SELECT AdArticle.Id" _
                              & " FROM AdArticle" _
                              & " LEFT JOIN Ad_AdArticle ON (Ad_AdArticle.IdAdArticle = AdArticle.Id)" _
                              & " WHERE Ad_AdArticle.IdAd = " & adId

            Return GetByIds(rqt)

        End Function

    End Class

End Namespace