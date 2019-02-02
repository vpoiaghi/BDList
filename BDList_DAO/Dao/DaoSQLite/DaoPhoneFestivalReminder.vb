Imports BDList_DAO_BO.BO
Imports BDList_DATABASE

Namespace DAO

    Public Class DaoPhoneFestivalReminder
        Inherits DaoSQLite

        Public Const FIELD_ID_FESTIVAL As String = "idFestival"
        Public Const FIELD_ID_EDITOR As String = "idEditor"
        Public Const FIELD_NAME As String = "name"
        Public Const FIELD_KIND As String = "kind"
        Public Const FIELD_COMMENTS As String = "comments"

        Protected Friend Overrides Function GetBoType() As Type
            Return GetType(PhoneFestivalReminder)
        End Function

        Protected Friend Overrides Function GetTableName() As String
            Return "festivalReminder"
        End Function

        Protected Friend Overrides Sub InitFieldsList(fieldsNames As FieldList)
            fieldsNames.AddFields(FIELD_ID_FESTIVAL, FIELD_ID_EDITOR, FIELD_NAME, FIELD_KIND, FIELD_COMMENTS)
        End Sub

        Protected Friend Overrides Sub BuildBo(sqlResult As ISqlResult, bo As IdBObject)

            With CType(bo, PhoneFestivalReminder)

                .SetIdFestival(sqlResult.GetLong(FIELD_ID_FESTIVAL))
                .SetIdEditor(sqlResult.GetLong(FIELD_ID_EDITOR))
                .SetName(sqlResult.GetString(FIELD_NAME))
                .SetKind(sqlResult.GetInteger(FIELD_KIND))
                .SetComments(sqlResult.GetString(FIELD_COMMENTS))

            End With

        End Sub

        Protected Friend Overrides Sub SetBasicRequestBuilder(ByRef reqBuilder As RequestBuilder.IBasicRequestBuilder, ByRef phoneFestival As IdBObject)

            With CType(phoneFestival, PhoneFestivalReminder)

                reqBuilder.AddValue(FIELD_ID_FESTIVAL, GetSqlIntegerValue(.GetIdFestival()))
                reqBuilder.AddValue(FIELD_ID_EDITOR, GetSqlIntegerValue(.GetIdEditor()))
                reqBuilder.AddValue(FIELD_NAME, GetSqlStringValue(.GetName))
                reqBuilder.AddValue(FIELD_KIND, GetSqlIntegerValue(.GetKind))
                reqBuilder.AddValue(FIELD_COMMENTS, GetSqlStringValue(.GetComments))
            End With

        End Sub


    End Class

End Namespace