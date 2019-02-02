Imports BDList_DAO_BO.BO
Imports BDList_DATABASE

Namespace DAO

    Public Class DaoPhoneFestival
        Inherits DaoSQLite

        Public Const FIELD_NAME As String = "name"
        Public Const FIELD_BEGIN_DATE As String = "beginDate"
        Public Const FIELD_END_DATE As String = "endDate"

        Protected Friend Overrides Function GetBoType() As Type
            Return GetType(PhoneFestival)
        End Function

        Protected Friend Overrides Function GetTableName() As String
            Return "festival"
        End Function

        Protected Friend Overrides Sub InitFieldsList(fieldsNames As FieldList)
            fieldsNames.AddFields(FIELD_NAME, FIELD_BEGIN_DATE, FIELD_END_DATE)
        End Sub

        Protected Friend Overrides Sub BuildBo(sqlResult As ISqlResult, bo As IdBObject)

            With CType(bo, PhoneFestival)

                .SetName(sqlResult.GetString(FIELD_NAME))
                .SetBeginDate(sqlResult.GetSqlDate(FIELD_BEGIN_DATE))
                .SetEndDate(sqlResult.GetSqlDate(FIELD_END_DATE))

            End With

        End Sub

        Protected Friend Overrides Sub SetBasicRequestBuilder(ByRef reqBuilder As RequestBuilder.IBasicRequestBuilder, ByRef phoneFestival As IdBObject)

            With CType(phoneFestival, PhoneFestival)

                reqBuilder.AddValue(FIELD_NAME, GetSqlStringValue(.GetName))
                reqBuilder.AddValue(FIELD_BEGIN_DATE, GetSqlDateValue(.GetBeginDate))
                reqBuilder.AddValue(FIELD_END_DATE, GetSqlDateValue(.GetEndDate))

            End With

        End Sub


    End Class

End Namespace