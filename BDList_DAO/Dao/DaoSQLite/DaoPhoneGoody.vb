Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.RequestBuilder
Imports BDList_DATABASE
Imports BDList_TOOLS
Imports BDList_TOOLS.Types.Sql

Imports System.Text

Namespace DAO

    Public Class DaoPhoneGoody
        Inherits DaoSQLite

        Private Const FIELD_ID_EDITOR As String = "idEditor"
        Private Const FIELD_ID_SERIE As String = "idSerie"
        Private Const FIELD_ID_SERIES As String = "idSeries"
        Private Const FIELD_ID_AUTHOR As String = "idAuthor"
        Private Const FIELD_ID_AUTHORS As String = "idAuthors"
        Private Const FIELD_NAME As String = "name"
        Private Const FIELD_SEARCH_NAME As String = "searchName"
        Private Const FIELD_SERIE_NAME As String = "serieName"
        Private Const FIELD_SERIE_SEARCH_NAME As String = "serieSearchName"
        Private Const FIELD_KIND_NAME As String = "kindName"
        Private Const FIELD_EDITOR_NAME As String = "editorName"
        Private Const FIELD_STATE As String = "state"
        Private Const FIELD_WITH_AUTOGRAPH As String = "isWithAutograph"
        Private Const FIELD_PARUTION_DATE As String = "parutionDate"
        Private Const FIELD_POSSESSION_STATE As String = "possessionState"
        Private Const FIELD_COPY_NUMBER As String = "copyNumber"
        Private Const FIELD_COPY_COUNT As String = "copyCount"
        Private Const FIELD_SIZE_X As String = "sizeX"
        Private Const FIELD_SIZE_Y As String = "sizeY"
        Private Const FIELD_SIZE_Z As String = "sizeZ"
        Private Const FIELD_ORDER_NUMBER As String = "orderNumber"

        Protected Friend Overrides Function GetBoType() As Type
            Return GetType(PhoneGoody)
        End Function

        Protected Friend Overrides Function GetTableName() As String
            Return "goody"
        End Function

        Protected Friend Overrides Sub InitFieldsList(fieldsNames As FieldList)
            fieldsNames.AddFields(FIELD_ID_EDITOR, FIELD_ID_SERIE, FIELD_ID_SERIES, FIELD_ID_AUTHOR, FIELD_ID_AUTHORS, FIELD_NAME, FIELD_SEARCH_NAME, FIELD_SERIE_NAME, _
                                  FIELD_SERIE_SEARCH_NAME, FIELD_KIND_NAME, FIELD_EDITOR_NAME, FIELD_STATE, FIELD_WITH_AUTOGRAPH, FIELD_PARUTION_DATE, FIELD_POSSESSION_STATE, _
                                  FIELD_COPY_NUMBER, FIELD_COPY_COUNT, FIELD_SIZE_X, FIELD_SIZE_Y, FIELD_SIZE_Z, FIELD_ORDER_NUMBER)

        End Sub

        Protected Friend Overrides Sub BuildBo(sqlResult As ISqlResult, bo As IdBObject)

            With CType(bo, PhoneGoody)

                .SetIdEditor(sqlResult.GetLong(FIELD_ID_EDITOR))
                .SetIdSerie(sqlResult.GetLong(FIELD_ID_SERIE))
                .SetIdSeries(sqlResult.GetString(FIELD_ID_SERIES))
                .SetIdAuthor(sqlResult.GetLong(FIELD_ID_AUTHOR))
                .SetIdAuthors(sqlResult.GetString(FIELD_ID_AUTHORS))
                .SetName(sqlResult.GetString(FIELD_NAME))
                .SetSearchName(sqlResult.GetString(FIELD_SEARCH_NAME))
                .SetSerieName(sqlResult.GetString(FIELD_SERIE_NAME))
                .SetSerieSearchName(sqlResult.GetString(FIELD_SERIE_SEARCH_NAME))
                .SetKindName(sqlResult.GetString(FIELD_KIND_NAME))
                .SetEditorName(sqlResult.GetString(FIELD_EDITOR_NAME))
                .SetState(sqlResult.GetInteger(FIELD_STATE))
                .SetWithAutograph(sqlResult.GetBoolean(FIELD_WITH_AUTOGRAPH))
                .SetParutionDate(sqlResult.GetSqlDate(FIELD_PARUTION_DATE))
                .SetPossessionState(sqlResult.GetInteger(FIELD_POSSESSION_STATE))
                .SetCopyNumber(sqlResult.GetString(FIELD_COPY_NUMBER))
                .SetCopyCount(sqlResult.GetInteger(FIELD_COPY_COUNT))
                .SetSizeX(sqlResult.GetInteger(FIELD_SIZE_X))
                .SetSizeY(sqlResult.GetInteger(FIELD_SIZE_Y))
                .SetSizeZ(sqlResult.GetInteger(FIELD_SIZE_Z))
                .SetOrderNumber(sqlResult.GetInteger(FIELD_ORDER_NUMBER))
            End With

        End Sub

        Protected Friend Overrides Sub SetBasicRequestBuilder(ByRef reqBuilder As RequestBuilder.IBasicRequestBuilder, ByRef phoneGoody As IdBObject)

            With CType(phoneGoody, PhoneGoody)

                reqBuilder.AddValue(FIELD_ID_EDITOR, GetSqlIntegerValue(.GetIdEditor))
                reqBuilder.AddValue(FIELD_ID_SERIE, GetSqlIntegerValue(.GetIdSerie()))
                reqBuilder.AddValue(FIELD_ID_SERIES, GetSqlStringValue(.GetIdSeries()))
                reqBuilder.AddValue(FIELD_ID_AUTHOR, GetSqlIntegerValue(.GetIdAuthor()))
                reqBuilder.AddValue(FIELD_ID_AUTHORS, GetSqlStringValue(.GetIdAuthors()))
                reqBuilder.AddValue(FIELD_NAME, GetSqlStringValue(.GetName))
                reqBuilder.AddValue(FIELD_SEARCH_NAME, GetSqlStringValue(.GetSearchName))
                reqBuilder.AddValue(FIELD_SERIE_NAME, GetSqlStringValue(.GetSerieName))
                reqBuilder.AddValue(FIELD_SERIE_SEARCH_NAME, GetSqlStringValue(.GetSerieSearchName))
                reqBuilder.AddValue(FIELD_KIND_NAME, GetSqlStringValue(.GetKindName))
                reqBuilder.AddValue(FIELD_EDITOR_NAME, GetSqlStringValue(.GetEditorName))
                reqBuilder.AddValue(FIELD_STATE, GetSqlIntegerValue(.GetState))
                reqBuilder.AddValue(FIELD_WITH_AUTOGRAPH, GetSqlBooleanValue(.IsWithAutograph))
                reqBuilder.AddValue(FIELD_PARUTION_DATE, GetSqlDateValue(.GetParutionDate))
                reqBuilder.AddValue(FIELD_POSSESSION_STATE, GetSqlIntegerValue(.GetPossessionState))
                reqBuilder.AddValue(FIELD_COPY_NUMBER, GetSqlStringValue(.GetCopyNumber))
                reqBuilder.AddValue(FIELD_COPY_COUNT, GetSqlIntegerValue(.GetCopyCount))
                reqBuilder.AddValue(FIELD_SIZE_X, GetSqlIntegerValue(.GetSizeX))
                reqBuilder.AddValue(FIELD_SIZE_Y, GetSqlIntegerValue(.GetSizeY))
                reqBuilder.AddValue(FIELD_SIZE_Z, GetSqlIntegerValue(.GetSizeZ))
                reqBuilder.AddValue(FIELD_ORDER_NUMBER, GetSqlIntegerValue(.GetOrderNumber))

            End With

        End Sub


    End Class

End Namespace