Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.RequestBuilder
Imports BDList_DATABASE
Imports BDList_TOOLS

Namespace DAO

    Public Class DaoSociety
        Inherits DaoNamedBo

        Protected Friend Overrides Function GetBoType() As Type
            Return GetType(Society)
        End Function

        Protected Friend Overrides Function GetTableName() As String
            Return "Society"
        End Function

        Protected Friend Overrides Sub InitFieldsList(fieldsNames As FieldList)
            fieldsNames.AddFields("Name", "WebSite")
        End Sub

        Protected Friend Overrides Sub BuildBo(sqlResult As ISqlResult, bo As IdBObject)

            With CType(bo, Society)

                .SetName(sqlResult.GetString("Name"))
                .SetWebSite(sqlResult.GetString("WebSite"))

            End With

        End Sub

        Protected Friend Overrides Sub SetBasicRequestBuilder(ByRef reqBuilder As IBasicRequestBuilder, ByRef society As IdBObject)

            With CType(society, Society)
                reqBuilder.AddValue("Name", GetSqlStringValue(.GetName))
                reqBuilder.AddValue("WebSite", GetSqlStringValue(.GetWebSite))
            End With

        End Sub


    End Class

End Namespace