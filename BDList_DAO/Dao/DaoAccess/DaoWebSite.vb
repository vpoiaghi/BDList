Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.RequestBuilder
Imports BDList_DATABASE

Namespace DAO

    Public Class DaoWebSite
        Inherits DaoNamedBo

        Protected Friend Overrides Function GetBoType() As Type
            Return GetType(WebSite)
        End Function

        Protected Friend Overrides Function GetTableName() As String
            Return "WebSite"
        End Function

        Protected Friend Overrides Sub InitFieldsList(fieldsNames As FieldList)
            MyBase.InitFieldsList(fieldsNames)
            fieldsNames.AddFields("Url")
        End Sub

        Protected Friend Overrides Sub BuildBo(sqlResult As ISqlResult, bo As IdBObject)

            With CType(bo, WebSite)

                .SetName(sqlResult.GetString("Name"))
                .SetUrl(sqlResult.GetString("Url"))

            End With

        End Sub

        Protected Friend Overrides Sub SetBasicRequestBuilder(ByRef reqBuilder As IBasicRequestBuilder, ByRef society As IdBObject)

            With CType(society, WebSite)
                reqBuilder.AddValue("Name", GetSqlStringValue(.GetName))
                reqBuilder.AddValue("Url", GetSqlStringValue(.GetUrl))
            End With

        End Sub

    End Class

End Namespace