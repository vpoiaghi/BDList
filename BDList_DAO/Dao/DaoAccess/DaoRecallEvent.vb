Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.RequestBuilder
Imports BDList_DATABASE
Imports BDList_TOOLS

Imports System.Text

Namespace DAO

    Public Class DaoRecallEvent
        Inherits DaoAccess

        Public Const FIELD_START_DATE As String = "startDate"
        Public Const FIELD_END_DATE As String = "endDate"
        Public Const FIELD_NAME As String = "name"
        Public Const FIELD_PLACE As String = "place"
        Public Const FIELD_COMMENTS As String = "comments"
        Public Const FIELD_STATE As String = "state"
        Public Const FIELD_REMINDER_DAYS As String = "reminderDays"
        Public Const FIELD_PERSISTENCE_DAYS As String = "persistenceDays"

        Protected Friend Overrides Function GetBoType() As Type
            Return GetType(RecallEvent)
        End Function

        Protected Friend Overrides Function GetTableName() As String
            Return "RecallEvent"
        End Function

        Protected Friend Overrides Sub InitFieldsList(fieldsNames As FieldList)
            fieldsNames.AddFields(FIELD_START_DATE, FIELD_END_DATE, FIELD_NAME, FIELD_PLACE, FIELD_COMMENTS, FIELD_STATE, FIELD_REMINDER_DAYS, FIELD_PERSISTENCE_DAYS)
        End Sub

        Protected Friend Overrides Sub BuildBo(sqlResult As ISqlResult, bo As IdBObject)

            With CType(bo, RecallEvent)

                .SetStartDate(sqlResult.GetDate(FIELD_START_DATE))
                .SetEndDate(sqlResult.GetDate(FIELD_END_DATE))
                .SetName(sqlResult.GetString(FIELD_NAME))
                .SetPlace(sqlResult.GetString(FIELD_PLACE))
                .SetComments(sqlResult.GetString(FIELD_COMMENTS))
                .SetState(sqlResult.GetInteger(FIELD_STATE))
                .SetReminderDays(sqlResult.GetInteger(FIELD_REMINDER_DAYS))
                .SetPersistenceDays(sqlResult.GetInteger(FIELD_PERSISTENCE_DAYS))

            End With

        End Sub

        Protected Friend Overrides Sub SetBasicRequestBuilder(ByRef reqBuilder As RequestBuilder.IBasicRequestBuilder, ByRef recallEvent As IdBObject)

            With CType(recallEvent, RecallEvent)

                reqBuilder.AddValue(FIELD_START_DATE, GetSqlDateValue(.GetStartDate))
                reqBuilder.AddValue(FIELD_END_DATE, GetSqlDateValue(.GetEndDate))
                reqBuilder.AddValue(FIELD_NAME, GetSqlStringValue(.GetName))
                reqBuilder.AddValue(FIELD_PLACE, GetSqlStringValue(.GetPlace))
                reqBuilder.AddValue(FIELD_COMMENTS, GetSqlStringValue(.GetComments))
                reqBuilder.AddValue(FIELD_STATE, GetSqlIntegerValue(.GetState))
                reqBuilder.AddValue(FIELD_REMINDER_DAYS, GetSqlIntegerValue(.GetReminderDays))
                reqBuilder.AddValue(FIELD_PERSISTENCE_DAYS, GetSqlIntegerValue(.GetPersistenceDays))

            End With

        End Sub

        Public Overrides Function GetAll() As List(Of IdBObject)

            Dim rqt As String = " SELECT Id" _
                              & " FROM " & GetTableName() _
                              & " ORDER BY " & FIELD_START_DATE & " ASC"

            Return GetByIds(rqt)

        End Function

    End Class

End Namespace