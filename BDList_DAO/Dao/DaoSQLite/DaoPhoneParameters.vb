Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.RequestBuilder
Imports BDList_DATABASE
Imports BDList_TOOLS
Imports BDList_TOOLS.Types.Sql

Imports System.Text

Namespace DAO

    Public Class DaoPhoneParameters
        Inherits DaoSQLite

        Protected Friend Overrides Function GetBoType() As Type
            Return GetType(PhoneParameters)
        End Function

        Protected Friend Overrides Function GetTableName() As String
            Return "parameters"
        End Function

        Protected Friend Overrides Sub InitFieldsList(fieldsNames As FieldList)
            fieldsNames.AddFields("newsDaysCount", "dataUpdateDate", "firstComingDate", "useDefaultFirstComingDate", "eventPastDaysCount")
        End Sub

        Protected Friend Overrides Sub BuildBo(sqlResult As ISqlResult, bo As IdBObject)

            With CType(bo, PhoneParameters)

                .SetDataUpdateDate(sqlResult.GetSqlDate("dataUpdateDate"))
                .SetNewsDaysCount(sqlResult.GetInteger("newsDaysCount"))
                .SetFirstComingDate(sqlResult.GetSqlDate("firstComingDate"))
                .SetUseDefaultFirstComingDate(sqlResult.GetBoolean("useDefaultFirstComingDate"))
                .SetEventPastDaysCount(sqlResult.GetInteger("eventPastDaysCount"))

            End With

        End Sub

        Protected Friend Overrides Sub SetBasicRequestBuilder(ByRef reqBuilder As RequestBuilder.IBasicRequestBuilder, ByRef phoneParameters As IdBObject)

            With CType(phoneParameters, PhoneParameters)

                reqBuilder.AddValue("dataUpdateDate", GetSqlDateValue(.GetDataUpdateDate))
                reqBuilder.AddValue("newsDaysCount", GetSqlIntegerValue(.GetNewsDaysCount))
                reqBuilder.AddValue("useDefaultFirstComingDate", GetSqlBooleanValue(.IsUseDefaultFirstComingDate))
                reqBuilder.AddValue("eventPastDaysCount", GetSqlIntegerValue(.GetEventPastDaysCount))

            End With

        End Sub

    End Class

End Namespace