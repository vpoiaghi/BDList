Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.RequestBuilder
Imports BDList_DATABASE

Namespace DAO

    Public Class DaoAdState
        Inherits DaoNamedBo

        Protected Friend Overrides Function GetBoType() As Type
            Return GetType(AdState)
        End Function

        Protected Friend Overrides Function GetTableName() As String
            Return "AdState"
        End Function

        Protected Friend Overrides Sub InitFieldsList(fieldsNames As FieldList)
            fieldsNames.AddFields("IsWin", "IsLost")
        End Sub

        Protected Friend Overrides Sub BuildBo(sqlResult As ISqlResult, bo As IdBObject)

            With CType(bo, AdState)

                .SetName(sqlResult.GetString(FIELD_NAME))
                .SetWin(sqlResult.GetBoolean("IsWin"))
                .SetLost(sqlResult.GetBoolean("IsLost"))

            End With


        End Sub

        Protected Friend Overrides Sub SetBasicRequestBuilder(ByRef reqBuilder As IBasicRequestBuilder, ByRef collection As IdBObject)

            With CType(collection, AdState)
                reqBuilder.AddValue(FIELD_NAME, GetSqlStringValue(.GetName))
                reqBuilder.AddValue("IsWin", GetSqlBooleanValue(.IsWin))
                reqBuilder.AddValue("IsLost", GetSqlBooleanValue(.IsLost))
            End With

        End Sub

        Public Function GetWinStates() As List(Of IdBObject)

            Dim rqt As String = " SELECT Id" _
                              & " FROM " & GetTableName() _
                              & " WHERE IsWin IS TRUE"

            Return GetByIds(rqt)

        End Function

        Public Function GetLostStates() As List(Of IdBObject)

            Dim rqt As String = " SELECT Id" _
                              & " FROM " & GetTableName() _
                              & " WHERE IsLost IS TRUE"

            Return GetByIds(rqt)

        End Function


    End Class

End Namespace