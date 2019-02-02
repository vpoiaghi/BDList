Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.RequestBuilder
Imports BDList_DATABASE

Namespace DAO

    Public Class DaoFestival
        Inherits DaoNamedBo

        Protected Friend Overrides Function GetBoType() As Type
            Return GetType(Festival)
        End Function

        Protected Friend Overrides Function GetTableName() As String
            Return "Festival"
        End Function

        Protected Friend Overrides Sub InitFieldsList(fieldsNames As FieldList)
            fieldsNames.AddFields("BeginDate", "EndDate")
        End Sub

        Protected Friend Overrides Sub BuildBo(sqlResult As ISqlResult, bo As IdBObject)

            With CType(bo, Festival)

                .SetName(sqlResult.GetString("Name"))
                .SetBeginDate(sqlResult.GetDate("BeginDate"))
                .SetEndDate(sqlResult.GetDate("EndDate"))

            End With

        End Sub

        Protected Friend Overrides Sub SetBasicRequestBuilder(ByRef reqBuilder As IBasicRequestBuilder, ByRef festival As IdBObject)

            With CType(festival, Festival)
                reqBuilder.AddValue("Name", GetSqlStringValue(.GetName))
                reqBuilder.AddValue("BeginDate", GetSqlDateValue(.GetBeginDate))
                reqBuilder.AddValue("EndDate", GetSqlDateValue(.GetEndDate))
            End With

        End Sub

        Public Overrides Function GetAll() As List(Of IdBObject)

            Dim rqt As String = " SELECT Id" _
                              & " FROM " & GetTableName() _
                              & " ORDER BY BeginDate DESC, " & FIELD_NAME & " ASC"

            Return GetByIds(rqt)

        End Function


    End Class

End Namespace