Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.RequestBuilder
Imports BDList_DATABASE
Imports BDList_TOOLS

Namespace DAO

    Public Class DaoParameter
        Inherits DaoNamedBo

        Protected Friend Overrides Function GetBoType() As Type
            Return GetType(Parameter)
        End Function

        Protected Friend Overrides Function GetTableName() As String
            Return "Parameter"
        End Function

        Protected Friend Overrides Sub InitFieldsList(fieldsNames As FieldList)
            fieldsNames.AddFields("Name", "Value")
        End Sub

        Protected Friend Overrides Sub BuildBo(sqlResult As ISqlResult, bo As IdBObject)

            With CType(bo, Parameter)

                .SetName(sqlResult.GetString("Name"))
                .SetValue(sqlResult.GetString("Value"))

            End With

        End Sub

        Protected Friend Overrides Sub SetBasicRequestBuilder(ByRef reqBuilder As IBasicRequestBuilder, ByRef parameter As IdBObject)

            With CType(parameter, Parameter)
                reqBuilder.AddValue("Name", GetSqlStringValue(.GetName))
                reqBuilder.AddValue("Value", GetSqlStringValue(.GetValue))
            End With

        End Sub

    End Class

End Namespace