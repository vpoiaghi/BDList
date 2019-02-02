Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.RequestBuilder
Imports BDList_DATABASE
Imports BDList_TOOLS

Imports System.Text

Namespace DAO

    Public Class DaoPhoneSerie
        Inherits DaoSQLite

        Public Const FIELD_KIND As String = "kind"
        Public Const FIELD_ORIGIN As String = "origin"
        Public Const FIELD_NAME As String = "name"
        Public Const FIELD_SEARCH_NAME As String = "searchName"
        Public Const FIELD_ENDED As String = "ended"
        Public Const FIELD_STORY As String = "story"

        Protected Friend Overrides Function GetBoType() As Type
            Return GetType(PhoneSerie)
        End Function

        Protected Friend Overrides Function GetTableName() As String
            Return "serie"
        End Function

        Protected Friend Overrides Sub InitFieldsList(fieldsNames As FieldList)
            fieldsNames.AddFields(FIELD_KIND, FIELD_ORIGIN, FIELD_NAME, FIELD_SEARCH_NAME, FIELD_ENDED, FIELD_STORY)
        End Sub

        Protected Friend Overrides Sub BuildBo(sqlResult As ISqlResult, bo As IdBObject)

            With CType(bo, PhoneSerie)

                .SetKind(sqlResult.GetString(FIELD_KIND))
                .SetOrigin(sqlResult.GetString(FIELD_ORIGIN))
                .SetName(sqlResult.GetString(FIELD_NAME))
                .SetSearchName(sqlResult.GetString(FIELD_SEARCH_NAME))
                .SetEnded(sqlResult.GetBoolean(FIELD_ENDED))
                .SetStory(sqlResult.GetString(FIELD_STORY))

            End With

        End Sub

        Protected Friend Overrides Sub SetBasicRequestBuilder(ByRef reqBuilder As RequestBuilder.IBasicRequestBuilder, ByRef phoneSerie As IdBObject)

            With CType(phoneSerie, PhoneSerie)

                reqBuilder.AddValue(FIELD_KIND, GetSqlStringValue(.GetKind))
                reqBuilder.AddValue(FIELD_ORIGIN, GetSqlStringValue(.GetOrigin))
                reqBuilder.AddValue(FIELD_NAME, GetSqlStringValue(.GetName))
                reqBuilder.AddValue(FIELD_SEARCH_NAME, GetSqlStringValue(.GetSearchName))
                reqBuilder.AddValue(FIELD_ENDED, GetSqlBooleanValue(.IsEnded))
                reqBuilder.AddValue(FIELD_STORY, GetSqlStringValue(.GetStory))

            End With

        End Sub

        Public Function GetByEdition(editionId As Long?) As List(Of IdBObject)

            Dim editionTableName As String = GetDao(Of DaoPhoneEdition).GetTableName
            Dim serieTableName As String = GetTableName()
            Dim editionSerieTableName As String = editionTableName & "_" & serieTableName

            Dim rqt As String = " SELECT " & GetIdFieldName() _
                              & " FROM " & serieTableName _
                              & " LEFT JOIN " & editionSerieTableName & " ON (" & serieTableName & "." & GetIdFieldName() & " = " & editionSerieTableName & ".IdSerie)" _
                              & " WHERE " & editionSerieTableName & ".IdEdition = " & editionId _
                              & " ORDER BY " & FIELD_NAME & " ASC"

            Return GetByIds(rqt)

        End Function

    End Class

End Namespace