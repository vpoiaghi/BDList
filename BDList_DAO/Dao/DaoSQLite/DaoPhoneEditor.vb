Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.RequestBuilder
Imports BDList_DATABASE
Imports BDList_TOOLS

Imports System.Text

Namespace DAO

    Public Class DaoPhoneEditor
        Inherits DaoSQLite

        Public Const FIELD_NAME As String = "name"

        Protected Friend Overrides Function GetBoType() As Type
            Return GetType(PhoneEditor)
        End Function

        Protected Friend Overrides Function GetTableName() As String
            Return "editor"
        End Function

        Protected Friend Overrides Sub InitFieldsList(fieldsNames As FieldList)
            fieldsNames.AddFields(FIELD_NAME)
        End Sub

        Protected Friend Overrides Sub BuildBo(sqlResult As ISqlResult, bo As IdBObject)

            With CType(bo, PhoneEditor)

                .SetName(sqlResult.GetString(FIELD_NAME))

            End With

        End Sub

        Protected Friend Overrides Sub SetBasicRequestBuilder(ByRef reqBuilder As RequestBuilder.IBasicRequestBuilder, ByRef phoneEditor As IdBObject)

            With CType(phoneEditor, PhoneEditor)

                reqBuilder.AddValue(FIELD_NAME, GetSqlStringValue(.GetName))

            End With

        End Sub


    End Class

End Namespace