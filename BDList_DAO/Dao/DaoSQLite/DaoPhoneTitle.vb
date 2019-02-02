Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.RequestBuilder
Imports BDList_DATABASE
Imports BDList_TOOLS

Imports System.Text

Namespace DAO

    Public Class DaoPhoneTitle
        Inherits DaoSQLite

        Public Const FIELD_ID_SERIE As String = "idSerie"
        Public Const FIELD_NAME As String = "name"
        Public Const FIELD_ORDER_NUMBER As String = "orderNumber"
        Public Const FIELD_STORY As String = "story"
        Public Const FIELD_OUT_SERIE As String = "outSerie"
        Public Const FIELD_IN_POSSESSION As String = "inPossession"

        Protected Friend Overrides Function GetBoType() As Type
            Return GetType(PhoneTitle)
        End Function

        Protected Friend Overrides Function GetTableName() As String
            Return "title"
        End Function

        Protected Friend Overrides Sub InitFieldsList(fieldsNames As FieldList)
            fieldsNames.AddFields(FIELD_ID_SERIE, FIELD_NAME, FIELD_ORDER_NUMBER, FIELD_STORY, FIELD_OUT_SERIE, FIELD_IN_POSSESSION)
        End Sub

        Protected Friend Overrides Sub BuildBo(sqlResult As ISqlResult, bo As IdBObject)

            With CType(bo, PhoneTitle)

                .SetIdSerie(sqlResult.GetLong(FIELD_ID_SERIE))
                .SetName(sqlResult.GetString(FIELD_NAME))
                .SetOrderNumber(sqlResult.GetInteger(FIELD_ORDER_NUMBER))
                .SetStory(sqlResult.GetString(FIELD_STORY))
                .SetOutSerie(sqlResult.GetBoolean(FIELD_OUT_SERIE))
                .SetInPossession(sqlResult.GetBoolean(FIELD_IN_POSSESSION))

            End With

        End Sub

        Protected Friend Overrides Sub SetBasicRequestBuilder(ByRef reqBuilder As RequestBuilder.IBasicRequestBuilder, ByRef phoneTitle As IdBObject)

            With CType(phoneTitle, PhoneTitle)

                reqBuilder.AddValue(FIELD_ID_SERIE, GetSqlIntegerValue(.GetIdSerie))
                reqBuilder.AddValue(FIELD_NAME, GetSqlStringValue(.GetName))
                reqBuilder.AddValue(FIELD_ORDER_NUMBER, GetSqlIntegerValue(.GetOrderNumber))
                reqBuilder.AddValue(FIELD_STORY, GetSqlStringValue(.GetStory))
                reqBuilder.AddValue(FIELD_OUT_SERIE, GetSqlBooleanValue(.IsOutSerie))
                reqBuilder.AddValue(FIELD_IN_POSSESSION, GetSqlBooleanValue(.IsInPossession))

            End With

        End Sub

    End Class

End Namespace