Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.RequestBuilder
Imports BDList_DATABASE
Imports BDList_TOOLS
Imports BDList_TOOLS.Types.Sql

Imports System.Text

Namespace DAO

    Public Class DaoPhoneAutograph
        Inherits DaoSQLite

        Public Const FIELD_ID_EDITION As String = "idEdition"
        Public Const FIELD_ID_GOODY As String = "idGoody"
        Public Const FIELD_ID_AUTHOR As String = "idAuthor"
        Public Const FIELD_ID_AUTHORS As String = "idAuthors"
        Public Const FIELD_DATE As String = "autographDate"
        Public Const FIELD_PLACE As String = "place"
        Public Const FIELD_EVENT As String = "event"
        Public Const FIELD_COMMENT As String = "comments"

        Protected Friend Overrides Function GetBoType() As Type
            Return GetType(PhoneAutograph)
        End Function

        Protected Friend Overrides Function GetTableName() As String
            Return "autograph"
        End Function

        Protected Friend Overrides Sub InitFieldsList(fieldsNames As FieldList)
            fieldsNames.AddFields(FIELD_ID_EDITION, FIELD_ID_GOODY, FIELD_ID_AUTHOR, FIELD_ID_AUTHORS, FIELD_DATE, FIELD_PLACE, FIELD_EVENT, FIELD_COMMENT)
        End Sub

        Protected Friend Overrides Sub BuildBo(sqlResult As ISqlResult, bo As IdBObject)

            With CType(bo, PhoneAutograph)

                .SetIdEdition(sqlResult.GetLong(FIELD_ID_EDITION))
                .SetIdGoody(sqlResult.GetLong(FIELD_ID_GOODY))
                .SetIdAuthor(sqlResult.GetLong(FIELD_ID_AUTHOR))
                .SetIdAuthors(sqlResult.GetString(FIELD_ID_AUTHORS))
                .SetDate(sqlResult.GetSqlDate(FIELD_DATE))
                .SetPlace(sqlResult.GetString(FIELD_PLACE))
                .SetEvent(sqlResult.GetString(FIELD_EVENT))
                .SetComments(sqlResult.GetString(FIELD_COMMENT))

            End With

        End Sub

        Protected Friend Overrides Sub SetBasicRequestBuilder(ByRef reqBuilder As RequestBuilder.IBasicRequestBuilder, ByRef phoneTitle As IdBObject)

            With CType(phoneTitle, PhoneAutograph)

                reqBuilder.AddValue(FIELD_ID_EDITION, GetSqlIntegerValue(.GetIdEdition))
                reqBuilder.AddValue(FIELD_ID_GOODY, GetSqlIntegerValue(.GetIdGoody))
                reqBuilder.AddValue(FIELD_ID_AUTHOR, GetSqlIntegerValue(.GetIdAuthor))
                reqBuilder.AddValue(FIELD_ID_AUTHORS, GetSqlStringValue(.GetIdAuthors))
                reqBuilder.AddValue(FIELD_DATE, GetSqlDateValue(.GetDate))
                reqBuilder.AddValue(FIELD_PLACE, GetSqlStringValue(.GetPlace))
                reqBuilder.AddValue(FIELD_EVENT, GetSqlStringValue(.GetEvent))
                reqBuilder.AddValue(FIELD_COMMENT, GetSqlStringValue(.GetComments))

            End With

        End Sub

    End Class

End Namespace