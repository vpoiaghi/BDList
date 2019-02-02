Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.RequestBuilder
Imports BDList_DATABASE

Namespace DAO

    Public Class DaoPhoneEdition
        Inherits DaoSQLite

        Private Const FIELD_ID_EDITOR As String = "idEditor"
        Private Const FIELD_ID_SERIE As String = "idSerie"
        Private Const FIELD_ID_SERIES As String = "idSeries"
        Private Const FIELD_ID_TITLE As String = "idTitle"
        Private Const FIELD_ID_TITLES As String = "idTitles"
        Private Const FIELD_SERIE_NAME As String = "serieName"
        Private Const FIELD_SERIE_SEARCH_NAME As String = "serieSearchName"
        Private Const FIELD_ORDER_NUMBER As String = "orderNumber"
        Private Const FIELD_COLLECTION As String = "collection"
        Private Const FIELD_STATE As String = "state"
        Private Const FIELD_POSSESSION_STATE As String = "possessionState"
        Private Const FIELD_EDITION_NUMBER As String = "editionNumber"
        Private Const FIELD_ISBN As String = "isbn"
        Private Const FIELD_INTEGRAL As String = "isIntegral"
        Private Const FIELD_IS_SET As String = "isSet"
        Private Const FIELD_NAME As String = "name"
        Private Const FIELD_SEARCH_NAME As String = "searchName"
        Private Const FIELD_PARUTION_DATE As String = "parutionDate"
        Private Const FIELD_VERSION_NUMBER As String = "versionNumber"
        Private Const FIELD_SPECIAL_EDITION As String = "specialEdition"
        Private Const FIELD_BOARDS_COUNT As String = "boardsCount"
        Private Const FIELD_PRINTING_MAX As String = "printingMax"
        Private Const FIELD_BOARDS_COLOR As String = "boardsColor"
        Private Const FIELD_TEXT_AUTHOR_NAME As String = "textAuthorName"
        Private Const FIELD_DRAW_AUTHOR_NAME As String = "drawAuthorName"
        Private Const FIELD_COLOR_AUTHOR_NAME As String = "colorAuthorName"
        Private Const FIELD_WITH_AUTOGRAPH As String = "isWithAutograph"
        Private Const FIELD_HAS_ANOTHER_EDITIONS As String = "hasAnotherEditions"
        Private Const FIELD_EDITOR_NAME As String = "editorName"

        Protected Friend Overrides Function GetBoType() As Type
            Return GetType(PhoneEdition)
        End Function

        Protected Friend Overrides Function GetTableName() As String
            Return "edition"
        End Function

        Protected Friend Overrides Sub InitFieldsList(fieldsNames As FieldList)
            fieldsNames.AddFields(FIELD_ID_EDITOR, FIELD_ID_SERIE, FIELD_ID_SERIES, FIELD_ID_TITLE, FIELD_ID_TITLES, FIELD_SERIE_NAME, FIELD_SERIE_SEARCH_NAME,
                                  FIELD_ORDER_NUMBER, FIELD_COLLECTION, FIELD_STATE, FIELD_POSSESSION_STATE, FIELD_EDITION_NUMBER, FIELD_ISBN, FIELD_INTEGRAL, _
                                  FIELD_IS_SET, FIELD_NAME, FIELD_SEARCH_NAME, FIELD_PARUTION_DATE, FIELD_VERSION_NUMBER, FIELD_SPECIAL_EDITION, _
                                  FIELD_BOARDS_COUNT, FIELD_PRINTING_MAX, FIELD_BOARDS_COLOR, FIELD_TEXT_AUTHOR_NAME, FIELD_DRAW_AUTHOR_NAME, _
                                  FIELD_COLOR_AUTHOR_NAME, FIELD_WITH_AUTOGRAPH, FIELD_HAS_ANOTHER_EDITIONS, FIELD_EDITOR_NAME)
        End Sub

        Protected Friend Overrides Sub InitLinkedDaoList()

            AddNotVeryLinkedDao(GetDao(Of DaoPhoneSerie))

        End Sub

        Protected Friend Overrides Sub BuildBo(sqlResult As ISqlResult, bo As IdBObject)

            With CType(bo, PhoneEdition)

                .SetIdEditor(sqlResult.GetLong(FIELD_ID_EDITOR))
                .SetIdSerie(sqlResult.GetLong(FIELD_ID_SERIE))
                .SetIdSeries(sqlResult.GetString(FIELD_ID_SERIES))
                .SetIdTitle(sqlResult.GetLong(FIELD_ID_TITLE))
                .SetIdTitles(sqlResult.GetString(FIELD_ID_TITLES))
                .SetSerieName(sqlResult.GetString(FIELD_SERIE_NAME))
                .SetSerieSearchName(sqlResult.GetString(FIELD_SERIE_SEARCH_NAME))
                .SetOrderNumber(sqlResult.GetInteger(FIELD_ORDER_NUMBER))
                .SetCollection(sqlResult.GetString(FIELD_COLLECTION))
                .SetState(sqlResult.GetInteger(FIELD_STATE))
                .SetPossessionState(sqlResult.GetInteger(FIELD_POSSESSION_STATE))
                .SetEditionNumber(sqlResult.GetString(FIELD_EDITION_NUMBER))
                .SetIsbn(sqlResult.GetString(FIELD_ISBN))
                .SetIntegral(sqlResult.GetBoolean(FIELD_INTEGRAL))
                .SetMiscellany(sqlResult.GetBoolean(FIELD_IS_SET))
                .SetName(sqlResult.GetString(FIELD_NAME))
                .SetSearchName(sqlResult.GetString(FIELD_SEARCH_NAME))
                .SetParutionDate(sqlResult.GetSqlDate(FIELD_PARUTION_DATE))
                .SetVersionNumber(sqlResult.GetInteger(FIELD_VERSION_NUMBER))
                .SetSpecialEdition(sqlResult.GetString(FIELD_SPECIAL_EDITION))
                .SetBoardsCount(sqlResult.GetInteger(FIELD_BOARDS_COUNT))
                .SetPrintingMax(sqlResult.GetInteger(FIELD_PRINTING_MAX))
                .SetBoardsColor(sqlResult.GetString(FIELD_BOARDS_COLOR))
                .SetTextAuthorName(sqlResult.GetString(FIELD_TEXT_AUTHOR_NAME))
                .SetDrawAuthorName(sqlResult.GetString(FIELD_DRAW_AUTHOR_NAME))
                .SetColorAuthorName(sqlResult.GetString(FIELD_COLOR_AUTHOR_NAME))
                .SetWithAutograph(sqlResult.GetBoolean(FIELD_WITH_AUTOGRAPH))
                .SetHasAnotherEditions(sqlResult.GetBoolean(FIELD_HAS_ANOTHER_EDITIONS))
                .SetEditorName(sqlResult.GetString(FIELD_EDITOR_NAME))

            End With

        End Sub

        Protected Friend Overrides Sub SetBasicRequestBuilder(ByRef reqBuilder As IBasicRequestBuilder, ByRef phoneEdition As IdBObject)

            With CType(phoneEdition, PhoneEdition)

                reqBuilder.AddValue(FIELD_ID_EDITOR, GetSqlIntegerValue(.GetIdEditor()))
                reqBuilder.AddValue(FIELD_ID_SERIE, GetSqlIntegerValue(.GetIdSerie()))
                reqBuilder.AddValue(FIELD_ID_SERIES, GetSqlStringValue(.GetIdSeries()))
                reqBuilder.AddValue(FIELD_ID_TITLE, GetSqlIntegerValue(.GetIdTitle()))
                reqBuilder.AddValue(FIELD_ID_TITLES, GetSqlStringValue(.GetIdTitles()))
                reqBuilder.AddValue(FIELD_SERIE_NAME, GetSqlStringValue(.GetSerieName))
                reqBuilder.AddValue(FIELD_SERIE_SEARCH_NAME, GetSqlStringValue(.GetSerieSearchName))
                reqBuilder.AddValue(FIELD_ORDER_NUMBER, GetSqlIntegerValue(.GetOrderNumber))
                reqBuilder.AddValue(FIELD_COLLECTION, GetSqlStringValue(.GetCollection))
                reqBuilder.AddValue(FIELD_STATE, GetSqlIntegerValue(.GetState))
                reqBuilder.AddValue(FIELD_POSSESSION_STATE, GetSqlIntegerValue(.GetPossessionState))
                reqBuilder.AddValue(FIELD_EDITION_NUMBER, GetSqlStringValue(.GetEditionNumber))
                reqBuilder.AddValue(FIELD_ISBN, GetSqlStringValue(.GetIsbn))
                reqBuilder.AddValue(FIELD_INTEGRAL, GetSqlBooleanValue(.IsIntegral))
                reqBuilder.AddValue(FIELD_IS_SET, GetSqlBooleanValue(.IsMiscellany))
                reqBuilder.AddValue(FIELD_NAME, GetSqlStringValue(.GetName))
                reqBuilder.AddValue(FIELD_SEARCH_NAME, GetSqlStringValue(.GetSearchName))
                reqBuilder.AddValue(FIELD_PARUTION_DATE, GetSqlDateValue(.GetParutionDate))
                reqBuilder.AddValue(FIELD_VERSION_NUMBER, GetSqlIntegerValue(.GetVersionNumber))
                reqBuilder.AddValue(FIELD_SPECIAL_EDITION, GetSqlStringValue(.GetSpecialEdition))
                reqBuilder.AddValue(FIELD_BOARDS_COUNT, GetSqlIntegerValue(.GetBoardsCount))
                reqBuilder.AddValue(FIELD_PRINTING_MAX, GetSqlIntegerValue(.GetPrintingMax))
                reqBuilder.AddValue(FIELD_BOARDS_COLOR, GetSqlStringValue(.GetBoardsColor))
                reqBuilder.AddValue(FIELD_TEXT_AUTHOR_NAME, GetSqlStringValue(.GetTextAuthorName))
                reqBuilder.AddValue(FIELD_DRAW_AUTHOR_NAME, GetSqlStringValue(.GetDrawAuthorName))
                reqBuilder.AddValue(FIELD_COLOR_AUTHOR_NAME, GetSqlStringValue(.GetColorAuthorName))
                reqBuilder.AddValue(FIELD_WITH_AUTOGRAPH, GetSqlBooleanValue(.IsWithAutograph))
                reqBuilder.AddValue(FIELD_HAS_ANOTHER_EDITIONS, GetSqlBooleanValue(.GetHasAnotherEditions))
                reqBuilder.AddValue(FIELD_EDITOR_NAME, GetSqlStringValue(.GetEditorName))

            End With

        End Sub


    End Class

End Namespace