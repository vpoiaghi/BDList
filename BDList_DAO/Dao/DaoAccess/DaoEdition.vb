Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.RequestBuilder
Imports BDList_DATABASE
Imports BDList_TOOLS

Namespace DAO

    Public Class DaoEdition
        Inherits DaoAccess

        Protected Friend Overrides Function GetBoType() As Type
            Return GetType(Edition)
        End Function

        Protected Friend Overrides Function GetTableName() As String
            Return "Edition"
        End Function

        Protected Friend Overrides Sub InitFieldsList(fieldsNames As FieldList)
            fieldsNames.AddFields("IdEditor", "IdState", "IdCollection", "EditionNumber", "Read", _
                                   "ISBN", "EAN_ISBN", "ISSN", "DDL", "Reedition", "IdPossessionState", "Integral", _
                                   "Miscellany", "Name", "PageCount", "BoardCount", "GraphicPagesCount", _
                                   "BoughtPrice", "LegalDepositDate", "LegalDepositMonth", "LegalDepositYear", _
                                   "ParutionDate", "ParutionMonth", "ParutionYear", "BoughtDate", "BoughtMonth", _
                                   "BoughtYear", "PrintDate", "PrintMonth", "PrintYear", "VersionNumber", _
                                   "EditionInformations", "SpecialEdition", "Width", "Height", _
                                   "IdSizeCategory", "PrintingNumber", "PrintingMaxNumber", "Comments")
        End Sub

        Protected Friend Overrides Sub InitLinkedDaoList()

            AddNotVeryLinkedDao(GetDao(Of DaoSerie))
            AddNotVeryLinkedDao(GetDao(Of DaoFormat))
            AddNotVeryLinkedDao(GetDao(Of DaoColor))

            AddVeryLinkedDao(GetDao(Of DaoTitle))
            AddVeryLinkedDao(GetDao(Of DaoAuthorRole))
            AddVeryLinkedDao(GetDao(Of DaoSocietyRole))
            AddVeryLinkedDao(GetDao(Of DaoAutograph))

        End Sub

        Protected Friend Overrides Sub BuildBo(sqlResult As ISqlResult, bo As IdBObject)

            With CType(bo, Edition)

                .SetEditionNumber(sqlResult.GetString("EditionNumber"))
                .SetRead(sqlResult.GetBoolean("Read"))
                .SetISBN(sqlResult.GetString("ISBN"))
                .SetEAN_ISBN(sqlResult.GetString("EAN_ISBN"))
                .SetISSN(sqlResult.GetString("ISSN"))
                .SetDDL(sqlResult.GetString("DDL"))
                .SetReedition(sqlResult.GetString("Reedition"))
                .SetIntegral(sqlResult.GetBoolean("Integral"))
                .SetMiscellany(sqlResult.GetBoolean("Miscellany"))
                .SetName(sqlResult.GetString("Name"))
                .SetPageCount(sqlResult.GetInteger("PageCount"))
                .SetBoardCount(sqlResult.GetInteger("BoardCount"))
                .SetGraphicPagesCount(sqlResult.GetInteger("GraphicPagesCount"))
                .SetBoughtPrice(sqlResult.GetInteger("BoughtPrice"))
                .SetLegalDepositDate(sqlResult.GetDate("LegalDepositDate"))
                .SetLegalDepositMonth(sqlResult.GetInteger("LegalDepositMonth"))
                .SetLegalDepositYear(sqlResult.GetInteger("LegalDepositYear"))
                .SetParutionDate(sqlResult.GetDate("ParutionDate"))
                .SetParutionMonth(sqlResult.GetInteger("ParutionMonth"))
                .SetParutionYear(sqlResult.GetInteger("ParutionYear"))
                .SetBoughtDate(sqlResult.GetDate("BoughtDate"))
                .SetBoughtMonth(sqlResult.GetInteger("BoughtMonth"))
                .SetBoughtYear(sqlResult.GetInteger("BoughtYear"))
                .SetPrintDate(sqlResult.GetDate("PrintDate"))
                .SetPrintMonth(sqlResult.GetInteger("PrintMonth"))
                .SetPrintYear(sqlResult.GetInteger("PrintYear"))
                .SetVersionNumber(sqlResult.GetInteger("VersionNumber"))
                .SetEditionInformations(sqlResult.GetString("EditionInformations"))
                .SetSpecialEdition(sqlResult.GetString("SpecialEdition"))
                .SetWidth(sqlResult.GetInteger("Width"))
                .SetHeight(sqlResult.GetInteger("Height"))
                .SetPrintingNumber(sqlResult.GetInteger("PrintingNumber"))
                .SetPrintingMaxNumber(sqlResult.GetInteger("PrintingMaxNumber"))
                .SetComments(sqlResult.GetString("Comments"))

                .SetEditor(GetLinkedBoById(sqlResult, GetType(DaoEditor), "IdEditor"))
                .SetCollection(GetLinkedBoById(sqlResult, GetType(DaoCollection), "IdCollection"))
                .SetState(GetLinkedBoById(sqlResult, GetType(DaoState), "IdState"))
                .SetSizeCategory(GetLinkedBoById(sqlResult, GetType(DaoSizeCategory), "IdSizeCategory"))
                .SetPossessionState(GetLinkedBoById(sqlResult, GetType(DaoPossessionState), "IdPossessionState"))

            End With

        End Sub

        Protected Friend Overrides Sub SetBasicRequestBuilder(ByRef reqBuilder As IBasicRequestBuilder, ByRef edition As IdBObject)

            With CType(edition, Edition)
                reqBuilder.AddValue("IdEditor", GetSqlIdValue(.GetEditor))
                reqBuilder.AddValue("IdState", GetSqlIdValue(.GetState))
                reqBuilder.AddValue("IdPossessionState", GetSqlIdValue(.GetPossessionState))
                reqBuilder.AddValue("IdCollection", GetSqlIdValue(.GetCollection))
                reqBuilder.AddValue("IdSizeCategory", GetSqlIdValue(.GetSizeCategory))
                reqBuilder.AddValue("EditionNumber", GetSqlStringValue(.GetEditionNumber))
                reqBuilder.AddValue("Read", GetSqlBooleanValue(.IsRead))
                reqBuilder.AddValue("ISBN", GetSqlStringValue(.GetISBN))
                reqBuilder.AddValue("EAN_ISBN", GetSqlStringValue(.GetEAN_ISBN))
                reqBuilder.AddValue("ISSN", GetSqlStringValue(.GetISSN))
                reqBuilder.AddValue("DDL", GetSqlStringValue(.GetDDL))
                reqBuilder.AddValue("Reedition", GetSqlStringValue(.GetReedition))
                reqBuilder.AddValue("Integral", GetSqlBooleanValue(.IsIntegral))
                reqBuilder.AddValue("Miscellany", GetSqlBooleanValue(.IsMiscellany))
                reqBuilder.AddValue("Name", GetSqlStringValue(.GetName))
                reqBuilder.AddValue("PageCount", GetSqlIntegerValue(.GetPageCount))
                reqBuilder.AddValue("BoardCount", GetSqlIntegerValue(.GetBoardCount))
                reqBuilder.AddValue("GraphicPagesCount", GetSqlIntegerValue(.GetGraphicPagesCount))
                reqBuilder.AddValue("BoughtPrice", GetSqlIntegerValue(.GetBoughtPrice))
                reqBuilder.AddValue("LegalDepositDate", GetSqlDateValue(.GetLegalDepositDate))
                reqBuilder.AddValue("ParutionDate", GetSqlDateValue(.GetParutionDate))
                reqBuilder.AddValue("BoughtDate", GetSqlDateValue(.GetBoughtDate))
                reqBuilder.AddValue("PrintDate", GetSqlDateValue(.GetPrintDate))
                reqBuilder.AddValue("VersionNumber", GetSqlIntegerValue(.GetVersionNumber))
                reqBuilder.AddValue("EditionInformations", GetSqlStringValue(.GetEditionInformations))
                reqBuilder.AddValue("SpecialEdition", GetSqlStringValue(.GetSpecialEdition))
                reqBuilder.AddValue("Width", GetSqlIntegerValue(.GetWidth))
                reqBuilder.AddValue("Height", GetSqlIntegerValue(.GetHeight))
                reqBuilder.AddValue("PrintingNumber", GetSqlIntegerValue(.GetPrintingNumber))
                reqBuilder.AddValue("PrintingMaxNumber", GetSqlIntegerValue(.GetPrintingMaxNumber))
                reqBuilder.AddValue("Comments", GetSqlStringValue(.GetComments))
            End With

        End Sub


        Public Function GetAllBySerie(serieId As Long?) As List(Of IdBObject)

            Dim rqt As String = " SELECT Edition.Id AS Id" _
                              & " FROM (((Edition" _
                              & " LEFT JOIN Edition_Serie ON (Edition.Id = Edition_Serie.IdEdition))" _
                              & " LEFT JOIN Serie ON (Edition_Serie.IdSerie = Serie.Id))" _
                              & " LEFT JOIN Edition_Title ON (Edition.Id = Edition_Title.IdEdition))" _
                              & " LEFT JOIN Title ON (Edition_Title.IdTitle = Title.Id)" _
                              & " WHERE Serie.Id = " & serieId _
                              & " ORDER BY Serie.SortName ASC," _
                              & " Edition.Miscellany DESC," _
                              & " Edition.Integral DESC," _
                              & " Title.OutSerie DESC," _
                              & " Title.OrderNumber ASC," _
                              & " Edition.SpecialEdition ASC"

            Return GetByIds(rqt)

        End Function

        Public Function GetByAutograph(autograph As BoAutograph) As Edition

            Dim result As Edition = Nothing

            If autograph IsNot Nothing Then
                result = GetByAutograph(autograph.GetId)
            End If

            Return result

        End Function

        Public Function GetByAutograph(autographId As Long?) As Edition

            Dim result As Edition = Nothing

            If (autographId IsNot Nothing) AndAlso (autographId.HasValue) Then

                Dim rqt As String = " SELECT IdEdition AS Id" _
                & " FROM Edition_Autograph" _
                & " WHERE IdAutograph = " & autographId.Value

                Dim results As List(Of IdBObject) = GetByIds(rqt)

                If results.Count = 1 Then
                    result = results(0)
                End If

            End If

            Return result

        End Function

        Public Function GetExisting() As List(Of IdBObject)

            Dim rqt As String = " SELECT Edition.Id AS Id" _
                  & " FROM (((Edition" _
                  & " LEFT JOIN Edition_Serie ON (Edition.Id = Edition_Serie.IdEdition))" _
                  & " LEFT JOIN Serie ON (Edition_Serie.IdSerie = Serie.Id))" _
                  & " LEFT JOIN Edition_Title ON (Edition.Id = Edition_Title.IdEdition))" _
                  & " LEFT JOIN Title ON (Edition_Title.IdTitle = Title.Id)" _
                  & " WHERE NOT Edition.ParutionDate > " & GetSqlDateValue(Today) _
                  & " ORDER BY Serie.SortName ASC," _
                  & " Edition.Miscellany DESC," _
                  & " Edition.Integral DESC," _
                  & " Title.OutSerie DESC," _
                  & " Title.OrderNumber ASC," _
                  & " Edition.SpecialEdition ASC"

            Return GetByIds(rqt)

        End Function

        Public Function GetExistingBySerie(serieId As Long?) As List(Of IdBObject)

            Dim rqt As String = " SELECT Edition.Id AS Id" _
                              & " FROM (((Edition" _
                              & " LEFT JOIN Edition_Serie ON (Edition.Id = Edition_Serie.IdEdition))" _
                              & " LEFT JOIN Serie ON (Edition_Serie.IdSerie = Serie.Id))" _
                              & " LEFT JOIN Edition_Title ON (Edition.Id = Edition_Title.IdEdition))" _
                              & " LEFT JOIN Title ON (Edition_Title.IdTitle = Title.Id)" _
                              & " WHERE Serie.Id = " & serieId _
                              & " AND NOT Edition.ParutionDate > " & GetSqlDateValue(Today) _
                              & " ORDER BY Serie.SortName ASC," _
                              & " Edition.Miscellany DESC," _
                              & " Edition.Integral DESC," _
                              & " Title.OutSerie DESC," _
                              & " Title.OrderNumber ASC," _
                              & " Edition.SpecialEdition ASC"

            Return GetByIds(rqt)

        End Function

        Public Function Search(searchCriteria As SearchCriteria) As List(Of IdBObject)

            Dim result As List(Of IdBObject) = Nothing

            If searchCriteria.id IsNot Nothing Then
                ' Si le critère Identifiant est renseigné, on ne tien pas compte des autres critères
                result = GetByIds("SELECT Edition.Id AS Id FROM Edition WHERE Id=" & searchCriteria.id)

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

                Dim rqt As String = " SELECT Edition.Id AS Id" _
                  & " FROM ((((((((((Edition" _
                  & " LEFT JOIN Edition_Serie ON (Edition.Id = Edition_Serie.IdEdition))" _
                  & " LEFT JOIN Serie ON (Edition_Serie.IdSerie = Serie.Id))" _
                  & " LEFT JOIN Edition_Title ON (Edition.Id = Edition_Title.IdEdition))" _
                  & " LEFT JOIN Title ON (Edition_Title.IdTitle = Title.Id))" _
                  & " LEFT JOIN Editor ON (Edition.IdEditor = Editor.Id))" _
                  & " LEFT JOIN Collection ON (Edition.IdCollection = Collection.Id))" _
                  & " LEFT JOIN Edition_AuthorRole ON (Edition.Id = Edition_AuthorRole.IdEdition))" _
                  & " LEFT JOIN AuthorRole ON (Edition_AuthorRole.IdAuthorRole = AuthorRole.Id))" _
                  & " LEFT JOIN Author ON (AuthorRole.IdAuthor = Author.Id))" _
                  & " LEFT JOIN Author_Person ON (Author.Id = Author_Person.IdAuthor))" _
                  & " LEFT JOIN Person ON (Author_Person.IdPerson = Person.Id)" _
                  & strSearchCriteria _
                  & " ORDER BY Serie.SortName ASC," _
                  & " Edition.Miscellany DESC," _
                  & " Edition.Integral DESC," _
                  & " Title.OutSerie DESC," _
                  & " Title.OrderNumber ASC," _
                  & " Edition.SpecialEdition ASC"

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
                    rqt = "SELECT Count(*) FROM Edition WHERE Id=" & searchCriteria.id


                Else
                    Dim strSearchCriteria = BuildSearchCriteria(searchCriteria)

                    rqt = " SELECT Count(*)" _
                        & " FROM (" _
                        & " SELECT DISTINCT Edition.Id" _
                        & " FROM ((((((((((Edition" _
                        & " LEFT JOIN Edition_Serie ON (Edition.Id = Edition_Serie.IdEdition))" _
                        & " LEFT JOIN Serie ON (Edition_Serie.IdSerie = Serie.Id))" _
                        & " LEFT JOIN Edition_Title ON (Edition.Id = Edition_Title.IdEdition))" _
                        & " LEFT JOIN Title ON (Edition_Title.IdTitle = Title.Id))" _
                        & " LEFT JOIN Editor ON (Edition.IdEditor = Editor.Id))" _
                        & " LEFT JOIN Collection ON (Edition.IdCollection = Collection.Id))" _
                        & " LEFT JOIN Edition_AuthorRole ON (Edition.Id = Edition_AuthorRole.IdEdition))" _
                        & " LEFT JOIN AuthorRole ON (Edition_AuthorRole.IdAuthorRole = AuthorRole.Id))" _
                        & " LEFT JOIN Author ON (AuthorRole.IdAuthor = Author.Id))" _
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
            ' FILTRE PAR MOT CLE SUR LE NOM DU TITRE, DE L'EDITION OU DE LA SERIE

            If keyWord IsNot Nothing Then
                keyWord = keyWord.Trim
                If keyWord.Length > 0 Then
                    keyWord = Accents.GetSqlAccentsFormat(keyWord)
                    criteriasList.Add("((Title.Name LIKE ""%" & keyWord & "%"") OR (Serie.Name LIKE ""%" & keyWord & "%"") OR (Edition.Name LIKE ""%" & keyWord & "%""))")
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
            ' FILTRE SUR LA COLLECTION

            If Not String.IsNullOrEmpty(searchCriteria.collection) Then
                criteriasList.Add("(Collection.Name LIKE ""%" & searchCriteria.collection & "%"")")
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

        Public Function GetEditionByPeriod(firstDate As Date, lastDate As Date) As List(Of IdBObject)

            Dim rqt As String = " SELECT Edition.Id AS Id" _
                  & " FROM (((Edition" _
                  & " LEFT JOIN Edition_Serie ON (Edition.Id = Edition_Serie.IdEdition))" _
                  & " LEFT JOIN Serie ON (Edition_Serie.IdSerie = Serie.Id))" _
                  & " LEFT JOIN Edition_Title ON (Edition.Id = Edition_Title.IdEdition))" _
                  & " LEFT JOIN Title ON (Edition_Title.IdTitle = Title.Id)" _
                  & " WHERE Edition.ParutionDate >= " & GetSqlDateValue(firstDate) _
                  & " AND Edition.ParutionDate <= " & GetSqlDateValue(lastDate) _
                  & " ORDER BY ParutionDate ASC," _
                  & " Serie.SortName ASC," _
                  & " Edition.Miscellany DESC," _
                  & " Edition.Integral DESC," _
                  & " Title.OutSerie DESC," _
                  & " Title.OrderNumber ASC," _
                  & " Edition.SpecialEdition ASC"

            Return GetByIds(rqt)

        End Function

        Public Function GetBoughtByPeriod(firstDate As Date, lastDate As Date) As List(Of IdBObject)

            Dim rqt As String = " SELECT Edition.Id AS Id" _
                  & " FROM (((Edition" _
                  & " LEFT JOIN Edition_Serie ON (Edition.Id = Edition_Serie.IdEdition))" _
                  & " LEFT JOIN Serie ON (Edition_Serie.IdSerie = Serie.Id))" _
                  & " LEFT JOIN Edition_Title ON (Edition.Id = Edition_Title.IdEdition))" _
                  & " LEFT JOIN Title ON (Edition_Title.IdTitle = Title.Id)" _
                  & " WHERE Edition.BoughtDate >= " & GetSqlDateValue(firstDate) _
                  & " AND Edition.BoughtDate <= " & GetSqlDateValue(lastDate) _
                  & " ORDER BY BoughtDate ASC," _
                  & " Serie.SortName ASC," _
                  & " Edition.Miscellany DESC," _
                  & " Edition.Integral DESC," _
                  & " Title.OutSerie DESC," _
                  & " Title.OrderNumber ASC," _
                  & " Edition.SpecialEdition ASC"

            Return GetByIds(rqt)

        End Function

        Public Function GetEditionByPeriodAndEditor(firstDate As Date, lastDate As Date, editorId As Long?) As List(Of IdBObject)

            Dim rqt As String = " SELECT Edition.Id AS Id" _
                  & " FROM (((Edition" _
                  & " LEFT JOIN Edition_Serie ON (Edition.Id = Edition_Serie.IdEdition))" _
                  & " LEFT JOIN Serie ON (Edition_Serie.IdSerie = Serie.Id))" _
                  & " LEFT JOIN Edition_Title ON (Edition.Id = Edition_Title.IdEdition))" _
                  & " LEFT JOIN Title ON (Edition_Title.IdTitle = Title.Id)" _
                  & " WHERE Edition.IdEditor = " & editorId _
                  & " AND Edition.ParutionDate >= " & GetSqlDateValue(firstDate) _
                  & " AND Edition.ParutionDate <= " & GetSqlDateValue(lastDate) _
                  & " ORDER BY ParutionDate ASC," _
                  & " Serie.SortName ASC," _
                  & " Edition.Miscellany DESC," _
                  & " Edition.Integral DESC," _
                  & " Title.OutSerie DESC," _
                  & " Title.OrderNumber ASC," _
                  & " Edition.SpecialEdition ASC"

            Return GetByIds(rqt)

        End Function

        Public Function GetBoughtByPeriodAndEditor(firstDate As Date, lastDate As Date, editorId As Long?) As List(Of IdBObject)

            Dim rqt As String = " SELECT Edition.Id AS Id" _
                  & " FROM (((Edition" _
                  & " LEFT JOIN Edition_Serie ON (Edition.Id = Edition_Serie.IdEdition))" _
                  & " LEFT JOIN Serie ON (Edition_Serie.IdSerie = Serie.Id))" _
                  & " LEFT JOIN Edition_Title ON (Edition.Id = Edition_Title.IdEdition))" _
                  & " LEFT JOIN Title ON (Edition_Title.IdTitle = Title.Id)" _
                  & " WHERE Edition.IdEditor = " & editorId _
                  & " AND Edition.BoughtDate >= " & GetSqlDateValue(firstDate) _
                  & " AND Edition.BoughtDate <= " & GetSqlDateValue(lastDate) _
                  & " ORDER BY BoughtDate ASC," _
                  & " Serie.SortName ASC," _
                  & " Edition.Miscellany DESC," _
                  & " Edition.Integral DESC," _
                  & " Title.OutSerie DESC," _
                  & " Title.OrderNumber ASC," _
                  & " Edition.SpecialEdition ASC"

            Return GetByIds(rqt)

        End Function

        Public Function GetComing(firstDate As Date) As List(Of IdBObject)

            Dim rqt As String = " SELECT Edition.Id AS Id" _
                              & " FROM (((Edition" _
                              & " LEFT JOIN Edition_Serie ON (Edition.Id = Edition_Serie.IdEdition))" _
                              & " LEFT JOIN Serie ON (Edition_Serie.IdSerie = Serie.Id))" _
                              & " LEFT JOIN Edition_Title ON (Edition.Id = Edition_Title.IdEdition))" _
                              & " LEFT JOIN Title ON (Edition_Title.IdTitle = Title.Id)" _
                              & " WHERE Edition.ParutionDate > " & GetSqlDateValue(firstDate) _
                              & " ORDER BY ParutionDate ASC," _
                              & " Serie.SortName ASC," _
                              & " Edition.Miscellany DESC," _
                              & " Edition.Integral DESC," _
                              & " Title.OutSerie DESC," _
                              & " Title.OrderNumber ASC," _
                              & " Edition.SpecialEdition ASC"

            Return GetByIds(rqt)

        End Function

        Public Function GetComingBySerie(serieId As Long?) As List(Of IdBObject)

            Dim rqt As String = " SELECT Edition.Id AS Id" _
                              & " FROM (((Edition" _
                              & " LEFT JOIN Edition_Serie ON (Edition.Id = Edition_Serie.IdEdition))" _
                              & " LEFT JOIN Serie ON (Edition_Serie.IdSerie = Serie.Id))" _
                              & " LEFT JOIN Edition_Title ON (Edition.Id = Edition_Title.IdEdition))" _
                              & " LEFT JOIN Title ON (Edition_Title.IdTitle = Title.Id)" _
                              & " WHERE Serie.Id = " & serieId _
                              & " AND Edition.ParutionDate > " & GetSqlDateValue(Today) _
                              & " ORDER BY ParutionDate ASC," _
                              & " Serie.SortName ASC," _
                              & " Edition.Miscellany DESC," _
                              & " Edition.Integral DESC," _
                              & " Title.OutSerie DESC," _
                              & " Title.OrderNumber ASC," _
                              & " Edition.SpecialEdition ASC"

            Return GetByIds(rqt)

        End Function

        Public Function GetComingByEditor(editorId As Long?) As List(Of IdBObject)

            Dim rqt As String = " SELECT Edition.Id AS Id" _
                  & " FROM (((Edition" _
                  & " LEFT JOIN Edition_Serie ON (Edition.Id = Edition_Serie.IdEdition))" _
                  & " LEFT JOIN Serie ON (Edition_Serie.IdSerie = Serie.Id))" _
                  & " LEFT JOIN Edition_Title ON (Edition.Id = Edition_Title.IdEdition))" _
                  & " LEFT JOIN Title ON (Edition_Title.IdTitle = Title.Id)" _
                  & " WHERE Edition.IdEditor = " & editorId _
                  & " AND Edition.ParutionDate > " & GetSqlDateValue(Today) _
                  & " ORDER BY ParutionDate ASC," _
                  & " Serie.SortName ASC," _
                  & " Edition.Miscellany DESC," _
                  & " Edition.Integral DESC," _
                  & " Title.OutSerie DESC," _
                  & " Title.OrderNumber ASC," _
                  & " Edition.SpecialEdition ASC"

            Return GetByIds(rqt)

        End Function

        Public Function GetPurchased() As List(Of IdBObject)

            Dim rqt As String = " SELECT Edition.Id AS Id" _
                              & " FROM (((Edition" _
                              & " LEFT JOIN Edition_Serie ON (Edition.Id = Edition_Serie.IdEdition))" _
                              & " LEFT JOIN Serie ON (Edition_Serie.IdSerie = Serie.Id))" _
                              & " LEFT JOIN Edition_Title ON (Edition.Id = Edition_Title.IdEdition))" _
                              & " LEFT JOIN Title ON (Edition_Title.IdTitle = Title.Id)" _
                              & " WHERE Edition.BoughtDate IS NOT NULL" _
                              & " ORDER BY BoughtDate DESC," _
                              & " Serie.SortName ASC," _
                              & " Edition.Miscellany DESC," _
                              & " Edition.Integral DESC," _
                              & " Title.OutSerie DESC," _
                              & " Title.OrderNumber ASC," _
                              & " Edition.SpecialEdition ASC"

            Return GetByIds(rqt)

        End Function

        Public Function GetPurchasedByEditor(editor As Editor) As List(Of IdBObject)

            Dim rqt As String =
                " SELECT Edition.Id AS Id" &
                " FROM (((Edition" &
                " LEFT JOIN Edition_Serie ON (Edition.Id = Edition_Serie.IdEdition))" &
                " LEFT JOIN Serie ON (Edition_Serie.IdSerie = Serie.Id))" &
                " LEFT JOIN Edition_Title ON (Edition.Id = Edition_Title.IdEdition))" &
                " LEFT JOIN Title ON (Edition_Title.IdTitle = Title.Id)" &
                " WHERE Edition.BoughtDate IS NOT NULL"

            If editor IsNot Nothing Then
                rqt &= " AND Edition.IdEditor = " & editor.GetId()
            End If

            rqt &=
                " ORDER BY BoughtDate DESC," &
                " Serie.SortName ASC," &
                " Edition.Miscellany DESC," &
                " Edition.Integral DESC," &
                " Title.OutSerie DESC," &
                " Title.OrderNumber ASC," &
                " Edition.SpecialEdition ASC"

            Return GetByIds(rqt)

        End Function

        Public Function GetByGoody(goodyId As Long?) As List(Of IdBObject)

            Dim rqt As String = " SELECT Edition.Id AS Id" _
                  & " FROM ((((Edition" _
                  & " LEFT JOIN Edition_Serie ON (Edition.Id = Edition_Serie.IdEdition))" _
                  & " LEFT JOIN Serie ON (Edition_Serie.IdSerie = Serie.Id))" _
                  & " LEFT JOIN Edition_Title ON (Edition.Id = Edition_Title.IdEdition))" _
                  & " LEFT JOIN Title ON (Edition_Title.IdTitle = Title.Id))" _
                  & " LEFT JOIN Goody_Edition ON (Goody_Edition.IdEdition = Edition.Id)" _
                  & " WHERE Goody_Edition.IdGoody = " & goodyId _
                  & " ORDER BY Serie.SortName ASC," _
                  & " Edition.Miscellany DESC," _
                  & " Edition.Integral DESC," _
                  & " Title.OutSerie DESC," _
                  & " Title.OrderNumber ASC," _
                  & " Edition.SpecialEdition ASC"

            Return GetByIds(rqt)

        End Function

        Public Function GetCountBySerie(idSerie As Long?) As Integer

            Dim editionTableName As String = GetTableName()
            Dim serieTableName As String = (DaoManager.GetDao(Of DaoSerie)()).GetTableName
            Dim editionSerieTableName As String = editionTableName & "_" & serieTableName

            Dim rqt As String = " SELECT COUNT(*)" _
                              & " FROM " & editionTableName _
                              & " LEFT JOIN " & editionSerieTableName & " ON (" & editionTableName & ".Id = " & editionSerieTableName & ".IdEdition)" _
                              & " WHERE " & editionSerieTableName & ".IdSerie = " & idSerie

            Return GetRequestValue(rqt)

        End Function

        Public Function GetCountInPossessionBySerie(idSerie As Long?) As Integer

            Dim editionTableName As String = GetTableName()
            Dim serieTableName As String = (DaoManager.GetDao(Of DaoSerie)()).GetTableName
            Dim editionSerieTableName As String = editionTableName & "_" & serieTableName

            Dim rqt As String = " SELECT COUNT(*)" _
                              & " FROM " & editionTableName _
                              & " LEFT JOIN " & editionSerieTableName & " ON (" & editionTableName & ".Id = " & editionSerieTableName & ".IdEdition)" _
                              & " WHERE (" & editionSerieTableName & ".IdSerie = " & idSerie & ")" _
                              & " AND (IdPossessionState = " & PossessionStates.InPossession & ")"

            Return GetRequestValue(rqt)


        End Function

        Public Function GetComingCountBySerie(idSerie As Long?) As Integer

            Dim editionTableName As String = GetTableName()
            Dim serieTableName As String = (DaoManager.GetDao(Of DaoSerie)()).GetTableName
            Dim editionSerieTAbleName As String = editionTableName & "_" & serieTableName

            Dim rqt As String = " SELECT COUNT(*)" _
                              & " FROM " & editionTableName _
                              & " LEFT JOIN " & editionSerieTAbleName & " ON (" & editionTableName & ".Id = " & editionSerieTAbleName & ".IdEdition)" _
                              & " WHERE " & editionSerieTAbleName & ".IdSerie = " & idSerie _
                              & " AND " & editionTableName & ".ParutionDate > " & GetSqlDateValue(Today)

            Return GetRequestValue(rqt)

        End Function

        Public Function GetInPossessionCount() As Integer

            Dim rqt As String = "SELECT COUNT(*) FROM Edition WHERE IdPossessionState = " & PossessionStates.InPossession
            Return GetRequestValue(rqt)

        End Function

        Public Function GetIntegralsInPossessionCount() As Integer

            Dim rqt As String = "SELECT COUNT(*) FROM Edition WHERE IdPossessionState = " & PossessionStates.InPossession & " AND Integral = TRUE"
            Return GetRequestValue(rqt)

        End Function

        Public Function GetMiscellaniesInPossessionCount() As Integer

            Dim rqt As String = "SELECT COUNT(*) FROM Edition WHERE IdPossessionState = " & PossessionStates.InPossession & " AND Miscellany = TRUE"
            Return GetRequestValue(rqt)

        End Function

        Public Function GetInPossessionByEditorCount(editor As Editor) As Integer

            Dim rqt As String = "SELECT COUNT(*)" _
                              & " FROM Edition" _
                              & " WHERE IdPossessionState = " & PossessionStates.InPossession _
                              & " AND IdEditor = " & editor.GetId

            Return GetRequestValue(rqt)

        End Function

        Public Function GetInPossessionByMonths() As List(Of CountByMonth)

            Dim result As New List(Of CountByMonth)

            Dim m As Integer = Now.Month
            Dim y As Integer = Now.Year

            Dim rqt As String = " SELECT [Month], [Year], Count(*) AS [Count]" _
                              & " FROM (" _
                              & " SELECT IIF(BoughtDate IS NULL, " & m & ", MONTH(BoughtDate)) AS [Month], IIF(BoughtDate IS NULL, " & y & ", YEAR(BoughtDate)) AS [Year]" _
                              & " FROM Edition" _
                              & " WHERE IdPossessionState = " & PossessionStates.InPossession _
                              & " )" _
                              & " GROUP BY [Year], [Month]" _
                              & " ORDER BY [Year] ASC, [Month] ASC"


            Dim sqlResult As ISqlResult = ExecuteQuery(rqt)
            Dim cbm As CountByMonth
            Dim sum As Integer = 0

            While sqlResult.MoveNext
                sum += sqlResult.GetInteger(2)
                cbm = New CountByMonth(sqlResult.GetInteger(0), sqlResult.GetInteger(1), sum)
                result.Add(cbm)
            End While

            Return result

        End Function

        Public Function GetInPossessionByYears() As List(Of CountByYear)

            Dim result As New List(Of CountByYear)

            Dim rqt As String = " SELECT [Year], Count(*) AS [Count]" _
                              & " FROM (" _
                              & " SELECT IIF(BoughtDate IS NULL, " & Now.Year & ", YEAR(BoughtDate)) AS [Year]" _
                              & " FROM Edition" _
                              & " WHERE IdPossessionState = " & PossessionStates.InPossession _
                              & " )" _
                              & " GROUP BY [Year]" _
                              & " ORDER BY [Year] ASC"


            Dim sqlResult As ISqlResult = ExecuteQuery(rqt)
            Dim cby As CountByYear
            Dim sum As Integer = 0

            While sqlResult.MoveNext

                sum += sqlResult.GetInteger(1)

                cby = New CountByYear
                cby.SetYear(sqlResult.GetInteger(0))
                cby.SetCount(sum)

                result.Add(cby)

            End While

            Return result

        End Function

        Public Function HasAnotherEditions(edition As Edition) As Integer

            Dim rqt As String = " SELECT COUNT(*)" _
                              & " FROM Edition_Title AS table1" _
                              & " INNER JOIN Edition_Title AS table2" _
                              & " ON (table1.IdTitle = table2.IdTitle AND table1.IdEdition <> table2.IdEdition)" _
                              & " WHERE table1.IdEdition = " & edition.GetId

            Return GetRequestValue(rqt)

        End Function

        Public Function GetWithAutograph() As List(Of IdBObject)

            Dim rqt As String = " SELECT IdEdition AS Id" _
                              & " FROM Edition_Autograph"

            Return GetByIds(rqt)

        End Function

        Public Function GetLastModified() As List(Of IdBObject)

            Dim rqt As String _
                = " SELECT Id" _
                & " FROM Edition" _
                & " ORDER BY TSP DESC"

            Return GetByIds(rqt)

        End Function

    End Class

End Namespace