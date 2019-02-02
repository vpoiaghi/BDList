Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.RequestBuilder
Imports BDList_DATABASE
Imports BDList_TOOLS

Namespace DAO

    Public Class DaoSeller
        Inherits DaoAccess

        Protected Friend Overrides Function GetBoType() As Type
            Return GetType(Seller)
        End Function

        Protected Friend Overrides Function GetTableName() As String
            Return "Seller"
        End Function

        Protected Friend Overrides Sub InitFieldsList(fieldsNames As FieldList)
            fieldsNames.AddFields("IdPerson",
                                  "Alias",
                                  "Recommended",
                                  "Comments")
        End Sub

        Protected Friend Overrides Sub InitLinkedDaoList()
            AddNotVeryLinkedDao(GetDao(Of DaoPerson))
        End Sub

        Protected Friend Overrides Sub BuildBo(sqlResult As ISqlResult, bo As IdBObject)

            With CType(bo, BoSeller)

                .SetAlias(sqlResult.GetString("Alias"))
                .SetRecommended(sqlResult.GetBoolean("Recommended"))
                .SetComments(sqlResult.GetString("Comments"))

                .SetPerson(GetLinkedBoById(sqlResult, GetType(DaoPerson), "IdPerson"))

            End With

        End Sub

        Protected Friend Overrides Sub SetBasicRequestBuilder(ByRef reqBuilder As IBasicRequestBuilder, ByRef bo As IdBObject)

            With CType(bo, Seller)
                reqBuilder.AddValue("IdPerson", GetSqlIdValue(.GetPerson))
                reqBuilder.AddValue("Alias", GetSqlStringValue(.GetAlias))
                reqBuilder.AddValue("Recommended", GetSqlBooleanValue(.IsRecommended))
                reqBuilder.AddValue("Comments", GetSqlStringValue(.GetComments))
            End With

        End Sub

        Public Overrides Function GetAll() As List(Of IdBObject)

            Dim rqt As String = " SELECT Id" _
                              & " FROM " & GetTableName() _
                              & " ORDER BY Alias ASC"

            Return GetByIds(rqt)

        End Function

    End Class

End Namespace