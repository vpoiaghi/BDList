Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.RequestBuilder
Imports BDList_DATABASE

Namespace DAO

    Public MustInherit Class DaoNamedBo
        Inherits DaoAccess

        Protected Const FIELD_NAME As String = "Name"

        Public Overrides Function GetAll() As List(Of IdBObject)

            Dim rqt As String = " SELECT Id" _
                              & " FROM " & GetTableName() _
                              & " ORDER BY " & FIELD_NAME & " ASC"

            Return GetByIds(rqt)

        End Function

        Public Function GetByName(name As String) As List(Of IdBObject)

            Dim rqt As String = " SELECT Id" _
                              & " FROM " & GetTableName() _
                              & " WHERE " & FIELD_NAME & " = """ & name & """" _
                              & " ORDER BY " & FIELD_NAME & " ASC"

            Return GetByIds(rqt)

        End Function

        Protected Friend Overrides Sub InitFieldsList(fieldsNames As FieldList)
            fieldsNames.AddFields(FIELD_NAME)
        End Sub

        Protected Friend Overrides Sub SetBasicRequestBuilder(ByRef reqBuilder As IBasicRequestBuilder, ByRef bo As IdBObject)

            With CType(bo, NamedBObject)
                reqBuilder.AddValue(FIELD_NAME, GetSqlStringValue(.GetName))
            End With

        End Sub

        Protected Friend Overrides Sub BuildBo(sqlResult As ISqlResult, bo As IdBObject)

            With CType(bo, NamedBObject)
                .SetName(sqlResult.GetString(FIELD_NAME))
            End With

        End Sub

    End Class

End Namespace