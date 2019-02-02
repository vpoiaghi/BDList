Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.RequestBuilder
Imports BDList_DATABASE
Imports BDList_TOOLS

Namespace DAO

    Public Class DaoTitle
        Inherits DaoAccess

        Protected Friend Overrides Function GetBoType() As Type
            Return GetType(Title)
        End Function

        Protected Friend Overrides Function GetTableName() As String
            Return "Title"
        End Function

        Protected Friend Overrides Sub InitFieldsList(fieldsNames As FieldList)
            fieldsNames.AddFields("IdSerie", "Name", "OrderNumber", "Story", "OutSerie")
        End Sub

        Protected Friend Overrides Sub BuildBo(sqlResult As ISqlResult, bo As IdBObject)

            With CType(bo, Title)

                .SetName(sqlResult.GetString("Name"))
                .SetOrderNumber(sqlResult.GetInteger("OrderNumber"))
                .SetStory(sqlResult.GetString("Story"))
                .SetOutSerie(sqlResult.GetBoolean("OutSerie"))

                .SetSerie(GetLinkedBoById(sqlResult, GetType(DaoSerie), "IdSerie"))

            End With

        End Sub

        Protected Friend Overrides Sub SetBasicRequestBuilder(ByRef reqBuilder As IBasicRequestBuilder, ByRef title As IdBObject)

            With CType(title, Title)
                reqBuilder.AddValue("Name", GetSqlStringValue(.GetName))
                reqBuilder.AddValue("OrderNumber", GetSqlIntegerValue(.GetOrderNumber))
                reqBuilder.AddValue("Story", GetSqlStringValue(.GetStory))
                reqBuilder.AddValue("OutSerie", GetSqlBooleanValue(.IsOutSerie))

                reqBuilder.AddValue("IdSerie", GetSqlIdValue(.GetSerie))
            End With

        End Sub


        Public Function GetByEdition(idEdition As Long?) As List(Of IdBObject)

            Dim rqt As String = " SELECT Title.Id AS Id" _
                              & " FROM Title" _
                              & " LEFT JOIN Edition_Title ON (Title.Id = Edition_Title.IdTitle)" _
                              & " WHERE IdEdition = " & idEdition _
                              & " ORDER BY OutSerie DESC, OrderNumber ASC"

            Return GetByIds(rqt)

        End Function

        Public Function GetBySerie(idSerie As Long?) As List(Of IdBObject)

            Dim rqt As String = " SELECT Id" _
                              & " FROM Title" _
                              & " WHERE IdSerie = " & idSerie _
                              & " ORDER BY OutSerie DESC, OrderNumber ASC"

            Return GetByIds(rqt)

        End Function

        Public Function GetCountBySerie(idSerie As Long?) As Integer

            Dim rqt As String = " SELECT COUNT(*)" _
                              & " FROM " & GetTableName() _
                              & " WHERE IdSerie = " & idSerie

            Return GetRequestValue(rqt)

        End Function

        Public Function GetInPossessionCount() As Integer

            Dim titleTableName As String = GetTableName()
            Dim editionTableName As String = DaoManager.GetDao(Of DaoEdition).GetTableName
            Dim editionTitleTableName As String = editionTableName & "_" & titleTableName

            Dim rqt As String = " SELECT COUNT(*)" _
                  & " FROM (" _
                  & "    SELECT DISTINCT " & editionTitleTableName & ".IdTitle" _
                  & "    FROM " & editionTitleTableName _
                  & "    LEFT JOIN " & editionTableName _
                  & "    ON (" & editionTitleTableName & ".idEdition = " & editionTableName & ".id)" _
                  & "    WHERE (IdPossessionState = " & PossessionStates.InPossession & ")" _
                  & " )"

            Return GetRequestValue(rqt)

        End Function

        Public Function GetCountInPosssessionBySerie(idSerie As Long?) As Integer

            Dim titleTableName As String = GetTableName()
            Dim editionTableName As String = DaoManager.GetDao(Of DaoEdition).GetTableName
            Dim editionTitleTableName As String = editionTableName & "_" & titleTableName
            Dim serieTableName As String = DaoManager.GetDao(Of DaoSerie).GetTableName
            Dim editionSerieTableName As String = editionTableName & "_" & serieTableName

            Dim rqt As String = " SELECT COUNT(*)" _
                  & " FROM (" _
                  & " SELECT DISTINCT " & editionTitleTableName & ".IdTitle" _
                  & " FROM (" & editionTitleTableName _
                  & " LEFT JOIN " & editionTableName _
                  & " ON (" & editionTitleTableName & ".idEdition = " & editionTableName & ".id))" _
                  & " LEFT JOIN " & editionSerieTableName _
                  & " ON (" & editionTableName & ".id = " & editionSerieTableName & ".idEdition)" _
                  & " WHERE (" & editionSerieTableName & ".IdSerie = " & idSerie & ")" _
                  & " AND (IdPossessionState = " & PossessionStates.InPossession & ")" _
                  & " )"

            Return GetRequestValue(rqt)

        End Function

    End Class

End Namespace