Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.RequestBuilder
Imports BDList_DATABASE

Namespace DAO

    Public Class DaoCollection
        Inherits DaoNamedBo

        Protected Friend Overrides Function GetBoType() As Type
            Return GetType(Collection)
        End Function

        Protected Friend Overrides Function GetTableName() As String
            Return "Collection"
        End Function

        Protected Friend Overrides Sub InitFieldsList(fieldsNames As FieldList)
            fieldsNames.AddFields("IdEditor", FIELD_NAME, "WebSite", "Management", "CreationYear")
        End Sub

        Protected Friend Overrides Sub BuildBo(sqlResult As ISqlResult, bo As IdBObject)

            With CType(bo, Collection)

                .SetName(sqlResult.GetString(FIELD_NAME))
                .SetWebSite(sqlResult.GetString("WebSite"))
                .SetManagement(sqlResult.GetString("Management"))
                .SetCreationYear(sqlResult.GetInteger("CreationYear"))

                .SetEditor(GetLinkedBoById(sqlResult, GetType(DaoEditor), "IdEditor"))

            End With

        End Sub

        Protected Friend Overrides Sub SetBasicRequestBuilder(ByRef reqBuilder As IBasicRequestBuilder, ByRef collection As IdBObject)

            With CType(collection, Collection)
                reqBuilder.AddValue(FIELD_NAME, GetSqlStringValue(.GetName))
                reqBuilder.AddValue("IdEditor", GetSqlIdValue(.GetEditor))
                reqBuilder.AddValue("WebSite", GetSqlStringValue(.GetWebSite))
                reqBuilder.AddValue("Management", GetSqlStringValue(.GetManagement))
                reqBuilder.AddValue("CreationYear", GetSqlIntegerValue(.GetCreationYear))
            End With

        End Sub

        Public Function GetByEditor(editor As Editor) As List(Of IdBObject)

            Dim rqt As String = " SELECT Id" _
                              & " FROM " & GetTableName() _
                              & " WHERE IdEditor = " & editor.GetId _
                              & " ORDER BY " & FIELD_NAME & " ASC"

            Return GetByIds(rqt)

        End Function

    End Class

End Namespace