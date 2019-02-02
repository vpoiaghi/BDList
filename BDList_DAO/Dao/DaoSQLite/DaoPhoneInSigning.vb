Imports BDList_DAO_BO.BO
Imports BDList_DATABASE

Namespace DAO

    Public Class DaoPhoneInSigning
        Inherits DaoSQLite

        Public Const FIELD_ID_FESTIVAL As String = "idFestival"
        Public Const FIELD_ID_AUTHOR As String = "idAuthor"
        Public Const FIELD_ID_EDITOR As String = "idEditor"
        Public Const FIELD_START_HOUR As String = "startHour"
        Public Const FIELD_END_HOUR As String = "endHour"
        Public Const FIELD_COMMENTS As String = "comments"

        Protected Friend Overrides Function GetBoType() As Type
            Return GetType(PhoneInSigning)
        End Function

        Protected Friend Overrides Function GetTableName() As String
            Return "insigning"
        End Function

        Protected Friend Overrides Sub InitFieldsList(fieldsNames As FieldList)
            fieldsNames.AddFields(FIELD_ID_FESTIVAL, FIELD_ID_AUTHOR, FIELD_ID_EDITOR, FIELD_START_HOUR, FIELD_END_HOUR, FIELD_COMMENTS)
        End Sub

        Protected Friend Overrides Sub BuildBo(sqlResult As ISqlResult, bo As IdBObject)

            With CType(bo, PhoneInSigning)

                .SetIdFestival(sqlResult.GetLong(FIELD_ID_FESTIVAL))
                .SetIdEditor(sqlResult.GetLong(FIELD_ID_EDITOR))
                .SetIdAuthor(sqlResult.GetLong(FIELD_ID_AUTHOR))
                .SetStartHour(sqlResult.GetSqlDate(FIELD_START_HOUR))
                .SetEndHour(sqlResult.GetSqlDate(FIELD_END_HOUR))
                .SetComments(sqlResult.GetString(FIELD_COMMENTS))

            End With

        End Sub

        Protected Friend Overrides Sub SetBasicRequestBuilder(ByRef reqBuilder As RequestBuilder.IBasicRequestBuilder, ByRef phoneFestival As IdBObject)

            With CType(phoneFestival, PhoneInSigning)

                reqBuilder.AddValue(FIELD_ID_FESTIVAL, GetSqlIntegerValue(.GetIdFestival()))
                reqBuilder.AddValue(FIELD_ID_EDITOR, GetSqlIntegerValue(.GetIdEditor()))
                reqBuilder.AddValue(FIELD_ID_AUTHOR, GetSqlIntegerValue(.GetIdAuthor()))
                reqBuilder.AddValue(FIELD_START_HOUR, GetSqlDateValue(.GetStartHour))
                reqBuilder.AddValue(FIELD_END_HOUR, GetSqlDateValue(.GetEndHour))
                reqBuilder.AddValue(FIELD_COMMENTS, GetSqlStringValue(.GetComments))
            End With

        End Sub


    End Class

End Namespace