Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.RequestBuilder
Imports BDList_DATABASE
Imports BDList_TOOLS

Namespace DAO
    Public Class DaoGoody
        Inherits DaoAccess

        Public Const FIELD_ORDER_NUMBER As String = "OrderNumber"
        Public Const FIELD_ID_KIND_OF_GOODY As String = "IdKindOfGoody"
        Public Const FIELD_ID_POSSESSION_STATE As String = "IdPossessionState"
        Public Const FIELD_DESCRIPTION As String = "Description"
        Public Const FIELD_NUMBER As String = "Number"
        Public Const FIELD_NUMBER_TYPE As String = "NumberType"
        Public Const FIELD_NUMBER_MAX As String = "NumberMax"
        Public Const FIELD_AUTOGRAPH As String = "Autograph"
        Public Const FIELD_PARUTION_DATE As String = "ParutionDate"
        Public Const FIELD_BOUGHT_DATE As String = "BoughtDate"
        Public Const FIELD_FORMAT As String = "Format"
        Public Const FIELD_WIDTH As String = "Width"
        Public Const FIELD_HEIGHT As String = "Height"
        Public Const FIELD_COMMENTS As String = "Comments"
        Public Const FIELD_BOX_NUMBER As String = "BoxNumber"
        Public Const FIELD_ID_COLLECTION As String = "IdCollection"
        Public Const FIELD_NUMBER_IN_COLLECTION As String = "NumberInCollection"
        Public Const FIELD_SCANNED As String = "Scanned"


        Protected Friend Overrides Function GetBoType() As Type
            Return GetType(Goody)
        End Function

        Protected Friend Overrides Function GetTableName() As String
            Return "Goody"
        End Function

        Protected Friend Overrides Sub InitFieldsList(fieldsNames As FieldList)
            fieldsNames.AddFields(FIELD_ORDER_NUMBER, FIELD_ID_KIND_OF_GOODY, FIELD_ID_POSSESSION_STATE, FIELD_DESCRIPTION,
                                  FIELD_NUMBER, FIELD_NUMBER_TYPE, FIELD_NUMBER_MAX, FIELD_AUTOGRAPH, FIELD_PARUTION_DATE, FIELD_BOUGHT_DATE, FIELD_FORMAT,
                                  FIELD_WIDTH, FIELD_HEIGHT, FIELD_COMMENTS, FIELD_BOX_NUMBER, FIELD_ID_COLLECTION, FIELD_NUMBER_IN_COLLECTION,
                                  FIELD_SCANNED)
        End Sub

        Protected Friend Overrides Sub InitLinkedDaoList()

            AddNotVeryLinkedDao(GetDao(Of DaoSerie))
            AddNotVeryLinkedDao(GetDao(Of DaoEdition))
            AddNotVeryLinkedDao(GetDao(Of DaoAuthor))
            AddNotVeryLinkedDao(GetDao(Of DaoEditor))

        End Sub

        Protected Friend Overrides Sub SetBasicRequestBuilder(ByRef reqBuilder As IBasicRequestBuilder, ByRef goody As IdBObject)

            With CType(goody, Goody)
                reqBuilder.AddValue(FIELD_ORDER_NUMBER, GetSqlIntegerValue(.GetOrderNumber))
                reqBuilder.AddValue(FIELD_ID_KIND_OF_GOODY, GetSqlIdValue(.GetKindOfGoody))
                reqBuilder.AddValue(FIELD_ID_POSSESSION_STATE, GetSqlIdValue(.GetPossessionState))
                reqBuilder.AddValue(FIELD_DESCRIPTION, GetSqlStringValue(.GetDescription))
                reqBuilder.AddValue(FIELD_NUMBER, GetSqlStringValue(.GetNumber))
                reqBuilder.AddValue(FIELD_NUMBER_TYPE, GetSqlStringValue(.GetNumberType))
                reqBuilder.AddValue(FIELD_NUMBER_MAX, GetSqlIntegerValue(.GetNumberMax))
                reqBuilder.AddValue(FIELD_AUTOGRAPH, GetSqlStringValue(.GetAutograph))
                reqBuilder.AddValue(FIELD_PARUTION_DATE, GetSqlDateValue(.GetParutionDate))
                reqBuilder.AddValue(FIELD_BOUGHT_DATE, GetSqlDateValue(.GetBoughtDate))
                reqBuilder.AddValue(FIELD_FORMAT, GetSqlStringValue(.GetFormat))
                reqBuilder.AddValue(FIELD_WIDTH, GetSqlIntegerValue(.GetWidth))
                reqBuilder.AddValue(FIELD_HEIGHT, GetSqlIntegerValue(.GetHeight))
                reqBuilder.AddValue(FIELD_COMMENTS, GetSqlStringValue(.GetComments))
                reqBuilder.AddValue(FIELD_BOX_NUMBER, GetSqlIntegerValue(.GetBoxNumber))
                reqBuilder.AddValue(FIELD_ID_COLLECTION, GetSqlIdValue(.GetCollection))
                reqBuilder.AddValue(FIELD_NUMBER_IN_COLLECTION, GetSqlIntegerValue(.GetNumberInCollection))
                reqBuilder.AddValue(FIELD_SCANNED, GetSqlBooleanValue(.IsScanned))

            End With

        End Sub

        Protected Friend Overrides Sub BuildBo(sqlResult As ISqlResult, bo As IdBObject)


            With CType(bo, Goody)

                .SetOrderNumber(sqlResult.GetInteger(FIELD_ORDER_NUMBER))
                .SetDescription(sqlResult.GetString(FIELD_DESCRIPTION))
                .SetNumber(sqlResult.GetString(FIELD_NUMBER))
                .SetNumberType(sqlResult.GetString(FIELD_NUMBER_TYPE))
                .SetNumberMax(sqlResult.GetInteger(FIELD_NUMBER_MAX))
                .SetAutograph(sqlResult.GetString(FIELD_AUTOGRAPH))
                .SetParutionDate(sqlResult.GetDate(FIELD_PARUTION_DATE))
                .SetBoughtDate(sqlResult.GetDate(FIELD_BOUGHT_DATE))
                .SetFormat(sqlResult.GetString(FIELD_FORMAT))
                .SetWidth(sqlResult.GetInteger(FIELD_WIDTH))
                .SetHeight(sqlResult.GetInteger(FIELD_HEIGHT))
                .SetComments(sqlResult.GetString(FIELD_COMMENTS))
                .SetBoxNumber(sqlResult.GetInteger(FIELD_BOX_NUMBER))
                .SetNumberInCollection(sqlResult.GetInteger(FIELD_NUMBER_IN_COLLECTION))
                .SetScanned(sqlResult.GetBoolean(FIELD_SCANNED))

                .SetKindOfGoody(GetLinkedBoById(sqlResult, GetType(DaoKindOfGoody), FIELD_ID_KIND_OF_GOODY))
                .SetPossessionState(GetLinkedBoById(sqlResult, GetType(DaoPossessionState), FIELD_ID_POSSESSION_STATE))
                .SetCollection(GetLinkedBoById(sqlResult, GetType(DaoCollection), "IdCollection"))

            End With

        End Sub

        Public Function GetAllBySerie(serie As Serie) As List(Of IdBObject)
            Return GetAllBySerie(serie.GetId)
        End Function

        Public Function GetAllBySerie(idSerie As Long?) As List(Of IdBObject)

            Dim rqt As String = " SELECT Goody_Serie.IdGoody AS Id" _
                  & " FROM ((Goody_Serie" _
                  & " LEFT JOIN Goody ON (Goody_Serie.IdGoody = Goody.Id))" _
                  & " LEFT JOIN Goody_Edition ON (Goody_Edition.IdGoody = Goody_Serie.IdGoody))" _
                  & " LEFT JOIN Edition ON (Goody_Edition.IdEdition = Edition.Id)" _
                  & " WHERE IdSerie = " & idSerie _
                  & " ORDER BY Goody.ParutionDate ASC, Description ASC, EditionNumber ASC"

            Return GetByIds(rqt)

        End Function

        Public Function GetAllByAuthor(idAuthor As Long?) As List(Of IdBObject)

            Dim rqt As String = " SELECT Goody_Author.IdGoody AS Id" _
                  & " FROM Goody_Author" _
                  & " LEFT JOIN Goody ON (Goody_Author.IdGoody = Goody.Id)" _
                  & " WHERE Goody_Author.IdAuthor = " & idAuthor _
                  & " ORDER BY Goody.ParutionDate ASC, Description ASC, OrderNumber ASC"

            Return GetByIds(rqt)

        End Function

        Public Function GetByAutograph(autograph As BoAutograph) As Goody

            Dim result As Goody = Nothing

            If autograph IsNot Nothing Then
                result = GetByAutograph(autograph.GetId)
            End If

            Return result

        End Function

        Public Function GetByAutograph(autographId As Long?) As Goody

            Dim result As Goody = Nothing

            If (autographId IsNot Nothing) AndAlso (autographId.HasValue) Then

                Dim rqt As String = " SELECT IdGoody AS Id" _
                & " FROM Goody_Autograph" _
                & " WHERE IdAutograph = " & autographId.Value

                Dim results As List(Of IdBObject) = GetByIds(rqt)

                If results.Count = 1 Then
                    result = results(0)
                End If

            End If

            Return result

        End Function

        Public Function GetLastModified() As List(Of IdBObject)

            Dim rqt As String _
                = " SELECT Id" _
                & " FROM Goody" _
                & " ORDER BY TSP DESC"

            Return GetByIds(rqt)

        End Function

        Public Function GetComing(firstDate As Date) As List(Of IdBObject)

            Dim rqt As String = " SELECT Goody_Serie.IdGoody AS Id" _
                                & " FROM ((Goody_Serie" _
                                & " LEFT JOIN Goody ON (Goody_Serie.IdGoody = Goody.Id))" _
                                & " LEFT JOIN Goody_Edition ON (Goody_Edition.IdGoody = Goody_Serie.IdGoody))" _
                                & " LEFT JOIN Edition ON (Goody_Edition.IdEdition = Edition.Id)" _
                                & " WHERE Goody.ParutionDate > " & GetSqlDateValue(firstDate) _
                                & " ORDER BY Goody.ParutionDate ASC, Description ASC, EditionNumber ASC"

            Return GetByIds(rqt)

        End Function

        Public Function GetComingByEditor(firstDate As Date, idEditor As Long?) As List(Of IdBObject)

            Dim rqt As String = " SELECT Goody_Serie.IdGoody AS Id" _
                                & " FROM (((Goody_Serie" _
                                & " LEFT JOIN Goody ON (Goody_Serie.IdGoody = Goody.Id))" _
                                & " LEFT JOIN Goody_Edition ON (Goody_Edition.IdGoody = Goody_Serie.IdGoody))" _
                                & " LEFT JOIN Edition ON (Goody_Edition.IdEdition = Edition.Id))" _
                                & " LEFT JOIN Goody_Editor ON (Goody.Id = Goody_Editor.IdGoody)" _
                                & " WHERE Goody.ParutionDate > " & GetSqlDateValue(firstDate) _
                                & " AND Goody_Editor.IdEditor = " & idEditor.Value _
                                & " ORDER BY Goody.ParutionDate ASC, Description ASC, EditionNumber ASC"

            Return GetByIds(rqt)

        End Function

        Public Function GetExLibrisLike() As List(Of IdBObject)

            Dim rqt As String = " SELECT Goody_Serie.IdGoody AS Id" _
                                & " FROM (Goody_Serie" _
                                & " LEFT JOIN Goody ON (Goody_Serie.IdGoody = Goody.Id))" _
                                & " LEFT JOIN Serie ON (Goody_Serie.IdSerie = Serie.Id)" _
                                & " WHERE (" & FIELD_ID_KIND_OF_GOODY & " IN (14, 18, 22, 32, 33, 34, 35))" _
                                & " ORDER BY Serie.SortName ASC, Goody.Description ASC"

            Return GetByIds(rqt)


        End Function

        Public Function GetByPeriod(firstDate As Date, lastDate As Date) As List(Of IdBObject)

            Dim goodyTableName As String = GetTableName()
            Dim goodySerieTableName As String = GetLinkTableName(Of DaoGoody, DaoSerie)()
            Dim editionTableName As String = DaoManager.GetDao(Of DaoEdition).GetTableName()
            Dim goodyEditionTableName As String = GetLinkTableName(Of DaoGoody, DaoEdition)()

            Dim rqt As String = " SELECT " & goodySerieTableName & ".IdGoody AS Id" _
                                & " FROM ((" & goodySerieTableName _
                                & " LEFT JOIN " & goodyTableName & " ON (" & goodySerieTableName & ".IdGoody = " & goodyTableName & ".Id))" _
                                & " LEFT JOIN " & goodyEditionTableName & " ON (" & goodyEditionTableName & ".IdGoody = " & goodySerieTableName & ".IdGoody))" _
                                & " LEFT JOIN " & editionTableName & " ON (" & goodyEditionTableName & ".IdEdition = " & editionTableName & ".Id)" _
                                & " WHERE " & goodyTableName & ".ParutionDate >= " & GetSqlDateValue(firstDate) _
                                & " AND " & goodyTableName & ".ParutionDate <= " & GetSqlDateValue(lastDate) _
                                & " ORDER BY " & goodyTableName & ".ParutionDate ASC, Description ASC, EditionNumber ASC"

            Return GetByIds(rqt)

        End Function

        Public Function GetBoughtByPeriod(firstDate As Date, lastDate As Date) As List(Of IdBObject)

            Dim goodyTableName As String = GetTableName()
            Dim goodySerieTableName As String = GetLinkTableName(Of DaoGoody, DaoSerie)()
            Dim editionTableName As String = DaoManager.GetDao(Of DaoEdition).GetTableName()
            Dim goodyEditionTableName As String = GetLinkTableName(Of DaoGoody, DaoEdition)()

            Dim rqt As String = " SELECT " & goodySerieTableName & ".IdGoody AS Id" _
                                & " FROM ((" & goodySerieTableName _
                                & " LEFT JOIN " & goodyTableName & " ON (" & goodySerieTableName & ".IdGoody = " & goodyTableName & ".Id))" _
                                & " LEFT JOIN " & goodyEditionTableName & " ON (" & goodyEditionTableName & ".IdGoody = " & goodySerieTableName & ".IdGoody))" _
                                & " LEFT JOIN " & editionTableName & " ON (" & goodyEditionTableName & ".IdEdition = " & editionTableName & ".Id)" _
                                & " WHERE " & goodyTableName & ".BoughtDate >= " & GetSqlDateValue(firstDate) _
                                & " AND " & goodyTableName & ".BoughtDate <= " & GetSqlDateValue(lastDate) _
                                & " ORDER BY " & goodyTableName & ".boughtDate ASC, Description ASC, EditionNumber ASC"

            Return GetByIds(rqt)

        End Function

        Public Function GetByPeriodAndEditor(firstDate As Date, lastDate As Date, idEditor As Long?) As List(Of IdBObject)

            Dim goodyTableName As String = GetTableName()
            Dim goodySerieTableName As String = GetLinkTableName(Of DaoGoody, DaoSerie)()
            Dim editionTableName As String = DaoManager.GetDao(Of DaoEdition).GetTableName()
            Dim goodyEditionTableName As String = GetLinkTableName(Of DaoGoody, DaoEdition)()

            Dim rqt As String = " SELECT " & goodySerieTableName & ".IdGoody AS Id" _
                                & " FROM (((" & goodySerieTableName _
                                & " LEFT JOIN " & goodyTableName & " ON (" & goodySerieTableName & ".IdGoody = " & goodyTableName & ".Id))" _
                                & " LEFT JOIN " & goodyEditionTableName & " ON (" & goodyEditionTableName & ".IdGoody = " & goodySerieTableName & ".IdGoody))" _
                                & " LEFT JOIN " & editionTableName & " ON (" & goodyEditionTableName & ".IdEdition = " & editionTableName & ".Id))" _
                                & " LEFT JOIN Goody_Editor ON (Goody.Id = Goody_Editor.IdGoody)" _
                                & " WHERE " & goodyTableName & ".ParutionDate >= " & GetSqlDateValue(firstDate) _
                                & " AND " & goodyTableName & ".ParutionDate <= " & GetSqlDateValue(lastDate) _
                                & " AND Goody_Editor.IdEditor = " & idEditor.Value _
                                & " ORDER BY " & goodyTableName & ".ParutionDate ASC, Description ASC, EditionNumber ASC"

            Return GetByIds(rqt)

        End Function

        Public Function GetBoughtByPeriodAndEditor(firstDate As Date, lastDate As Date, idEditor As Long?) As List(Of IdBObject)

            Dim goodyTableName As String = GetTableName()
            Dim goodySerieTableName As String = GetLinkTableName(Of DaoGoody, DaoSerie)()
            Dim editionTableName As String = DaoManager.GetDao(Of DaoEdition).GetTableName()
            Dim goodyEditionTableName As String = GetLinkTableName(Of DaoGoody, DaoEdition)()

            Dim rqt As String = " SELECT " & goodySerieTableName & ".IdGoody AS Id" _
                                & " FROM (((" & goodySerieTableName _
                                & " LEFT JOIN " & goodyTableName & " ON (" & goodySerieTableName & ".IdGoody = " & goodyTableName & ".Id))" _
                                & " LEFT JOIN " & goodyEditionTableName & " ON (" & goodyEditionTableName & ".IdGoody = " & goodySerieTableName & ".IdGoody))" _
                                & " LEFT JOIN " & editionTableName & " ON (" & goodyEditionTableName & ".IdEdition = " & editionTableName & ".Id)" _
                                & " LEFT JOIN Goody_Editor ON (Goody.Id = Goody_Editor.IdGoody)" _
                                & " WHERE " & goodyTableName & ".BoughtDate >= " & GetSqlDateValue(firstDate) _
                                & " AND " & goodyTableName & ".BoughtDate <= " & GetSqlDateValue(lastDate) _
                                & " AND Goody_Editor.IdEditor = " & idEditor _
                                & " ORDER BY " & goodyTableName & ".BoughtDate ASC, Description ASC, EditionNumber ASC"

            Return GetByIds(rqt)

        End Function

        Public Function GetCountBySerie(idSerie As Long?) As Integer

            Dim linkTableName As String = GetLinkTableName(Of DaoGoody, DaoSerie)()

            Dim rqt As String = " SELECT COUNT(*)" _
                              & " FROM " & linkTableName _
                              & " WHERE IdSerie = " & idSerie

            Return GetRequestValue(rqt)

        End Function

        Public Function GetCountInPossessionBySerie(idSerie As Long?) As Integer

            Dim goodyTableName As String = GetTableName()
            Dim linkTableName As String = GetLinkTableName(Of DaoGoody, DaoSerie)()

            Dim rqt As String = " SELECT COUNT(*)" _
                              & " FROM " & linkTableName _
                              & " LEFT JOIN " & goodyTableName _
                              & " ON (" & linkTableName & ".IdGoody = " & goodyTableName & ".Id)" _
                              & " WHERE (IdSerie = " & idSerie & ")" _
                              & " AND (" & FIELD_ID_POSSESSION_STATE & " = " & PossessionStates.InPossession & ")"

            Return GetRequestValue(rqt)

        End Function

        Public Function GetBoxesInPossessionCount() As Integer
            Return getGoodiesCountByKind(11)
        End Function

        Public Function GetSheathsInPossessionCount() As Integer
            Return GetGoodiesCountByKind(17)
        End Function

        Public Function GetGoodiesCountByKind(idKindOfGoody As Long?) As Integer

            Dim goodyTableName As String = GetTableName()

            Dim rqt As String = " SELECT COUNT(*)" _
                              & " FROM " & goodyTableName _
                              & " WHERE IdKindOfGoody = " & idKindOfGoody

            Return GetRequestValue(rqt)

        End Function

        Public Function GetWithAutograph() As List(Of IdBObject)

            Dim rqt As String = " SELECT IdGoody AS Id" _
                              & " FROM Goody_Autograph"

            Return GetByIds(rqt)

        End Function

        Public Function GetNumberTypes() As List(Of String)

            Dim rqt As String = " SELECT DISTINCT NumberType FROM Goody ORDER BY NumberType ASC"
            Dim result As List(Of IComparable) = GetRequestValues(rqt)

            Return result.ConvertAll(Of String)(New Converter(Of IComparable, String)(AddressOf IComparableToString))

        End Function

        Private Function IComparableToString(value As IComparable) As String
            Return CType(value, string)
        End Function

        Public Function Search(searchCriteria As SearchCriteria) As List(Of IdBObject)

            Dim result As List(Of IdBObject) = Nothing

            If searchCriteria.id IsNot Nothing Then
                ' Si le critère Identifiant est renseigné, on ne tien pas compte des autres critères
                result = GetByIds("SELECT Goody.Id AS Id FROM Goody WHERE Id=" & searchCriteria.id)

            ElseIf Not (searchCriteria.possessionCriteria.inPossession _
                OrElse searchCriteria.possessionCriteria.wanted _
                OrElse searchCriteria.possessionCriteria.missing _
                OrElse searchCriteria.possessionCriteria.inDelivery _
                OrElse searchCriteria.possessionCriteria.reserved _
                OrElse searchCriteria.possessionCriteria.toReserveAtBDfugue _
                OrElse searchCriteria.possessionCriteria.toReserveAtCultura _
                OrElse searchCriteria.possessionCriteria.present
                ) Then
                ' Si aucune des options n'est cochée, on prend rien donc pas besoin de lancer une requête
                result = New List(Of IdBObject)

            Else
                Dim strSearchCriteria = BuildSearchCriteria(searchCriteria)

                Dim rqt As String = " SELECT Goody.Id AS Id" _
                  & " FROM (((((((((Goody" _
                  & " LEFT JOIN Goody_Serie ON (Goody.Id = Goody_Serie.IdGoody))" _
                  & " LEFT JOIN Serie ON (Goody_Serie.IdSerie = Serie.Id))" _
                  & " LEFT JOIN Goody_Editor ON (Goody_Editor.IdGoody = Goody.Id))" _
                  & " LEFT JOIN Editor ON (Goody_Editor.IdEditor = Editor.Id))" _
                  & " LEFT JOIN KindOfGoody ON (Goody.IdKindOfGoody = KindOfGoody.Id))" _
                  & " LEFT JOIN Collection ON (Goody.IdCollection = Collection.Id))" _
                  & " LEFT JOIN Goody_Author ON (Goody.Id = Goody_Author.IdGoody))" _
                  & " LEFT JOIN Author ON (Goody_Author.IdAuthor = Author.Id))" _
                  & " LEFT JOIN Author_Person ON (Author.Id = Author_Person.IdAuthor))" _
                  & " LEFT JOIN Person ON (Author_Person.IdPerson = Person.Id)" _
                  & strSearchCriteria

                If searchCriteria.collection Is Nothing Then
                    rqt &= " ORDER BY Serie.SortName ASC, Goody." & FIELD_NUMBER_IN_COLLECTION & " ASC"
                Else
                    rqt &= " ORDER BY Goody." & FIELD_NUMBER_IN_COLLECTION & " ASC"
                End If

                result = GetByIds(rqt)

            End If

            Return result

        End Function

        Public Function SearchCount(searchCriteria As SearchCriteria) As Integer

            Dim result As Integer

            If Not (searchCriteria.possessionCriteria.inPossession _
                OrElse searchCriteria.possessionCriteria.wanted _
                OrElse searchCriteria.possessionCriteria.missing _
                OrElse searchCriteria.possessionCriteria.inDelivery _
                OrElse searchCriteria.possessionCriteria.reserved _
                OrElse searchCriteria.possessionCriteria.toReserveAtBDfugue _
                OrElse searchCriteria.possessionCriteria.toReserveAtCultura _
                OrElse searchCriteria.possessionCriteria.present
                ) Then
                ' Si aucune des options n'est cochée, on prend rien donc pas besoin de lancer une requête
                result = 0

            Else
                Dim rqt As String

                If searchCriteria.id IsNot Nothing Then
                    ' Si le critère Identifiant est renseigné, on ne tien pas compte des autres critères
                    rqt = "SELECT COUNT(*) FROM Goody WHERE Id=" & searchCriteria.id

                Else
                    Dim strSearchCriteria = BuildSearchCriteria(searchCriteria)

                    rqt = " SELECT Count(*)" _
                        & " FROM (" _
                        & " SELECT DISTINCT Goody.Id" _
                        & " FROM (((((((((Goody" _
                        & " LEFT JOIN Goody_Serie ON (Goody.Id = Goody_Serie.IdGoody))" _
                        & " LEFT JOIN Serie ON (Goody_Serie.IdSerie = Serie.Id))" _
                        & " LEFT JOIN Goody_Editor ON (Goody_Editor.IdGoody = Goody.Id))" _
                        & " LEFT JOIN Editor ON (Goody_Editor.IdEditor = Editor.Id))" _
                        & " LEFT JOIN KindOfGoody ON (Goody.IdKindOfGoody = KindOfGoody.Id))" _
                        & " LEFT JOIN Collection ON (Goody.IdCollection = Collection.Id))" _
                        & " LEFT JOIN Goody_Author ON (Goody.Id = Goody_Author.IdGoody))" _
                        & " LEFT JOIN Author ON (Goody_Author.IdAuthor = Author.Id))" _
                        & " LEFT JOIN Author_Person ON (Author.Id = Author_Person.IdAuthor))" _
                        & " LEFT JOIN Person ON (Author_Person.IdPerson = Person.Id)" _
                        & strSearchCriteria _
                        & " )"

                End If

                result = GetRequestValue(rqt)

            End If

            Return result

        End Function

        Private Function BuildSearchCriteria(searchCriteria As SearchCriteria) As String

            Dim result As String = ""

            Dim criteriasList As New List(Of String)

            Dim keyWord As String = searchCriteria.keyword
            Dim editorId As Long? = searchCriteria.editorId
            Dim editorName As String = searchCriteria.editorName
            Dim authorId As Long? = searchCriteria.authorId
            Dim authorName As String = searchCriteria.authorName

            ' -----------------------------------------------------------------
            ' FILTRE PAR MOT CLE SUR LE NOM DU PARA-BD OU DE LA SERIE

            If keyWord IsNot Nothing Then
                keyWord = keyWord.Trim
                If keyWord.Length > 0 Then
                    keyWord = Accents.GetSqlAccentsFormat(keyWord)
                    criteriasList.Add("((Goody.Description LIKE ""%" & keyWord & "%"") OR (Serie.Name LIKE ""%" & keyWord & "%""))")
                End If
            End If

            ' -----------------------------------------------------------------
            ' FILTRE SUR L'EDITEUR

            If editorId IsNot Nothing Then
                criteriasList.Add("(IdEditor = " & editorId & ")")
            ElseIf editorName IsNot Nothing Then
                editorName = editorName.Trim
                If editorName.Length > 0 Then
                    criteriasList.Add("(Editor.Name LIKE ""%" & editorName & "%"")")
                End If
            End If

            ' -----------------------------------------------------------------
            ' FILTRE SUR L'AUTEUR

            If authorId IsNot Nothing Then
                criteriasList.Add("(Author.Id = " & authorId & ")")
            ElseIf authorName IsNot Nothing Then
                authorName = authorName.Trim
                If authorName.Length > 0 Then
                    criteriasList.Add("(Author.Alias LIKE ""%" & authorName & "%"") OR (Person.Firstname LIKE ""%" & authorName & "%"") OR (Person.Lastname LIKE ""%" & authorName & "%"")")
                End If
            End If

            ' -----------------------------------------------------------------
            ' FILTRE SUR LE TYPE DE PARA-BD

            If Not String.IsNullOrEmpty(searchCriteria.kindOfGoodies) Then
                criteriasList.Add("(KindOfGoody.Name LIKE ""%" & searchCriteria.kindOfGoodies & "%"")")
            End If

            ' -----------------------------------------------------------------
            ' FILTRE SUR LA COLLECTION

            If Not String.IsNullOrEmpty(searchCriteria.collection) Then
                criteriasList.Add("(Collection.Name = """ & searchCriteria.collection & """)")
            End If

            ' -----------------------------------------------------------------
            ' FILTRE SUR L'ETAT DE POSSESSION

            Dim crtPossession As String = ""

            With searchCriteria.possessionCriteria
                If .inPossession Then crtPossession &= "," & PossessionStates.InPossession
                If .wanted Then crtPossession &= "," & PossessionStates.Wanted
                If .missing Then crtPossession &= "," & PossessionStates.missing
                If .inDelivery Then crtPossession &= "," & PossessionStates.InDelivery
                If .reserved Then crtPossession &= "," & PossessionStates.Reserved
                If .toReserveAtBDfugue Then crtPossession &= "," & PossessionStates.ToOrderAtBDfugue
                If .toReserveAtCultura Then crtPossession &= "," & PossessionStates.ToReserveAtCultura
                If .present Then crtPossession &= "," & PossessionStates.Present
            End With

            If crtPossession <> "" Then
                criteriasList.Add("(IdPossessionState IN (" & crtPossession.Substring(1) & "))")
            End If


            ' -----------------------------------------------------------------
            ' CONSTRUCTION DU WHERE

            If criteriasList.Count > 0 Then

                result = " WHERE " & criteriasList(0)

                For i As Integer = 1 To criteriasList.Count - 1
                    result &= " AND " & criteriasList(i)
                Next

            End If

            Return result

        End Function

    End Class
End Namespace