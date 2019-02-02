Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.RequestBuilder
Imports BDList_DATABASE
Imports BDList_TOOLS
Imports BDList_TOOLS.Types.Sql

Imports System.Text

Namespace DAO

    Public Class DaoPhoneAuthor
        Inherits DaoSQLite


        Public Const FIELD_NAME As String = "name"
        Public Const FIELD_SEARCH_NAME As String = "searchname"

        Protected Friend Overrides Function GetBoType() As Type
            Return GetType(PhoneAuthor)
        End Function

        Protected Friend Overrides Function GetTableName() As String
            Return "author"
        End Function

        Protected Friend Overrides Sub InitFieldsList(fieldsNames As FieldList)
            fieldsNames.AddFields(FIELD_NAME, FIELD_SEARCH_NAME)
        End Sub

        Protected Friend Overrides Sub BuildBo(sqlResult As ISqlResult, bo As IdBObject)

            With CType(bo, PhoneAuthor)

                .SetName(sqlResult.GetString(FIELD_NAME))
                .SetSearchName(sqlResult.GetString(FIELD_SEARCH_NAME))

            End With

        End Sub

        Protected Friend Overrides Sub SetBasicRequestBuilder(ByRef reqBuilder As RequestBuilder.IBasicRequestBuilder, ByRef phoneAuthor As IdBObject)

            With CType(phoneAuthor, PhoneAuthor)

                reqBuilder.AddValue(FIELD_NAME, GetSqlStringValue(.GetName))
                reqBuilder.AddValue(FIELD_SEARCH_NAME, GetSqlStringValue(.GetSearchName))

            End With

        End Sub

    End Class

End Namespace