Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.RequestBuilder
Imports BDList_DATABASE
Imports BDList_TOOLS

Namespace DAO
    Public Class DaoSerie
        Inherits DaoNamedBo

        Private Shared m_inBuildBo As Boolean = False

        Protected Friend Overrides Function GetBoType() As Type
            Return GetType(Serie)
        End Function

        Protected Friend Overrides Function GetTableName() As String
            Return "Serie"
        End Function

        Protected Friend Overrides Sub InitFieldsList(fieldsNames As FieldList)
            fieldsNames.AddFields("IdKind", "IdOrigin", "IdManager", "Name", "SortName", "Ended", "WebSite", "Story")
        End Sub

        Protected Friend Overrides Sub SetBasicRequestBuilder(ByRef reqBuilder As IBasicRequestBuilder, ByRef serie As IdBObject)

            With CType(serie, Serie)
                reqBuilder.AddValue("Name", GetSqlStringValue(.GetName))
                reqBuilder.AddValue("SortName", GetSqlStringValue(.GetSortName))
                reqBuilder.AddValue("Ended", GetSqlIntegerValue(.IsEnded))
                reqBuilder.AddValue("WebSite", GetSqlStringValue(.GetWebSite))
                reqBuilder.AddValue("Story", GetSqlStringValue(.GetStory))
                reqBuilder.AddValue("IdKind", GetSqlIdValue(.GetKind))
                reqBuilder.AddValue("IdOrigin", GetSqlIdValue(.GetOrigin))
                reqBuilder.AddValue("IdManager", GetSqlIdValue(.GetManager))
            End With

        End Sub

        Protected Friend Overrides Sub BuildBo(sqlResult As ISqlResult, bo As IdBObject)

            Dim serie As Serie = CType(bo, Serie)

            With serie

                .SetName(sqlResult.GetString("Name"))
                .SetEnded(sqlResult.GetInteger("Ended"))
                .SetWebSite(sqlResult.GetString("WebSite"))
                .SetStory(sqlResult.GetString("Story"))

                .SetKind(GetLinkedBoById(sqlResult, GetType(DaoKind), "IdKind"))
                .SetOrigin(GetLinkedBoById(sqlResult, GetType(DaoOrigin), "IdOrigin"))
                .SetManager(GetLinkedBoById(sqlResult, GetType(DaoAuthor), "IdManager"))

                If Not m_inBuildBo Then
                    ' Si le BO est construit suite à une requête de lecture standard et non
                    ' dans le cas de la récupération du BO en base avant mise à jour de celui-ci,
                    ' alors vérification que le nom de tri reconstitué est toujours le même que celui en base.

                    Dim sortNameInBase As String = sqlResult.GetString("SortName")
                    Dim sortNameComputed As String = .GetSortName()

                    If sortNameInBase <> sortNameComputed Then
                        ' Si le nom de tri reconstitué est différent de celui en base
                        ' alors réenregistrement du bo avec le nouveau nom de tri
                        m_inBuildBo = True
                        InsertOrUpdate(serie)
                        m_inBuildBo = False
                    End If
                End If

            End With

        End Sub

        Public Function GetByFirstLetters(ParamArray firstLetters() As String) As List(Of IdBObject)

            Dim filter As String = ""

            For Each letter As String In firstLetters
                filter &= "(LEFT(SortName,1) = """ & letter & """) OR "
            Next

            filter = filter.Substring(0, filter.Length - 4)

            Dim rqt As String = " SELECT Id" _
                              & " FROM Serie" _
                              & " LEFT JOIN Edition_Serie ON (Serie.Id = Edition_Serie.IdSerie)" _
                              & " WHERE " & filter _
                              & " ORDER BY SortName ASC"

            Return GetByIds(rqt)

        End Function

        Public Function GetSeriesStartByNumber() As List(Of IdBObject)

            Dim rqt As String = " SELECT Id" _
                              & " FROM Serie" _
                              & " LEFT JOIN Edition_Serie ON (Serie.Id = Edition_Serie.IdSerie)" _
                              & " WHERE ISNUMERIC(LEFT(SortName, 1))" _
                              & " ORDER BY SortName ASC"

            Return GetByIds(rqt)

        End Function

        Public Function GetSeriesByAuthorName(author As Author) As List(Of IdBObject)

            Dim rqt As String =
                  " SELECT Serie.Id" _
                & " FROM ((Serie" _
                & " Left Join Edition_Serie ON (Edition_Serie.IdSerie = Serie.Id))" _
                & " Left Join Edition_AuthorRole On (Edition_AuthorRole.IdEdition = Edition_Serie.IdEdition))" _
                & " Left Join AuthorRole ON (AuthorRole.Id = Edition_AuthorRole.IdAuthorRole)" _
                & " WHERE(AuthorRole.IdAuthor = " & author.GetId.Value & ")" _
                & " UNION" _
                & " SELECT Serie.Id" _
                & " FROM (Serie" _
                & " Left Join Goody_Serie ON(Goody_Serie.IdSerie = Serie.Id))" _
                & " Left Join Goody_Author On(Goody_Author.IdGoody = Goody_Serie.IdGoody)" _
                & " WHERE(Goody_Author.IdAuthor = " & author.GetId.Value & ")"

            Return GetByIds(rqt)

        End Function

        Public Function Search(searchCriteria As SearchCriteria) As List(Of IdBObject)

            Dim result As List(Of IdBObject)

            If searchCriteria.id IsNot Nothing Then
                ' Si le critère Identifiant est renseigné, on ne tien pas compte des autres critères
                result = GetByIds("Select Serie.Id As Id FROM Serie WHERE Id=" & searchCriteria.id)

            Else

                Dim strSearchCriteria = BuildSearchCriteria(searchCriteria)

                Dim rqt As String = " Select Id" _
                                  & " FROM Serie" _
                                  & strSearchCriteria _
                                  & " ORDER BY SortName ASC"

                result = GetByIds(rqt)

            End If

            Return result

        End Function

        Public Function SearchCount(searchCriteria As SearchCriteria) As Integer

            Dim rqt As String

            If searchCriteria.id IsNot Nothing Then
                ' Si le critère Identifiant est renseigné, on ne tien pas compte des autres critères
                rqt = "Select Count(*) FROM Serie WHERE Id=" & searchCriteria.id

            Else
                Dim strSearchCriteria = BuildSearchCriteria(searchCriteria)

                rqt = " SELECT COUNT(*)" _
                    & " FROM (" _
                    & " SELECT DISTINCT Id" _
                    & " FROM Serie" _
                    & strSearchCriteria _
                    & " )"

            End If

            Return GetRequestValue(rqt)

        End Function

        Private Function BuildSearchCriteria(searchCriteria As SearchCriteria) As String

            Dim result As String = ""

            Dim criteriasList As New List(Of String)
            Dim keyWord As String = searchCriteria.keyword

            If keyWord IsNot Nothing Then
                keyWord = keyWord.Trim

                If keyWord.Length = 1 Then
                    criteriasList.Add("(SortName Like '" & Accents.GetSqlAccentsFormat(keyWord) & "%')")

                ElseIf keyWord.Length > 1 Then
                    criteriasList.Add("(SortName LIKE '%" & Accents.GetSqlAccentsFormat(keyWord) & "%')")

                End If
            End If

            If criteriasList.Count > 0 Then

                result = " WHERE " & criteriasList(0)

                For i As Integer = 1 To criteriasList.Count - 1
                    result &= " AND " & criteriasList(i)
                Next

            End If

            Return result

        End Function

        Public Function GetBySortName(sortName As String) As List(Of IdBObject)

            Dim rqt As String = " SELECT Id" _
                              & " FROM Serie" _
                              & " WHERE SortName = """ & sortName & """" _
                              & " ORDER BY SortName ASC"

            Return GetByIds(rqt)

        End Function

        Public Function GetByEdition(editionId As Long?) As List(Of IdBObject)

            Dim rqt As String = " SELECT Id" _
                              & " FROM Serie" _
                              & " LEFT JOIN Edition_Serie ON (Serie.Id = Edition_Serie.IdSerie)" _
                              & " WHERE Edition_Serie.IdEdition = " & editionId _
                              & " ORDER BY SortName ASC"

            Return GetByIds(rqt)

        End Function

        Public Function GetByGoody(goodyId As Long?) As List(Of IdBObject)

            Dim rqt As String = " SELECT Id" _
                              & " FROM Serie" _
                              & " LEFT JOIN Goody_Serie ON (Serie.Id = Goody_Serie.IdSerie)" _
                              & " WHERE Goody_Serie.IdGoody = " & goodyId _
                              & " ORDER BY SortName ASC"

            Return GetByIds(rqt)

        End Function

        Public Function GetAllWithEditionsCount() As Integer

            Dim rqt As String = " SELECT COUNT(*) " _
                              & " FROM (" _
                              & "    SELECT DISTINCT IdSerie " _
                              & "    FROM Edition_Serie" _
                              & "    LEFT JOIN Edition ON (Edition_Serie.IdEdition = Edition.Id)" _
                              & "    WHERE Edition.IdPossessionState = " & PossessionStates.InPossession _
                              & " )"

            Return GetRequestValue(rqt)

        End Function

        Public Function GetAllWithEditionsNotFullCount() As Integer

            Dim rqt As String = " SELECT COUNT(*) " _
                              & " FROM (" _
                              & "    SELECT DISTINCT IdSerie " _
                              & "    FROM Edition_Serie" _
                              & "    LEFT JOIN Edition ON (Edition_Serie.IdEdition = Edition.Id)" _
                              & "    WHERE NOT (Edition.IdPossessionState = " & PossessionStates.InPossession & ")" _
                              & "    AND IdSerie IN (" _
                              & "       SELECT DISTINCT IdSerie " _
                              & "       FROM Edition_Serie" _
                              & "       LEFT JOIN Edition ON (Edition_Serie.IdEdition = Edition.Id)" _
                              & "       WHERE Edition.IdPossessionState = " & PossessionStates.InPossession _
                              & "    )" _
                              & " )"

            Return GetRequestValue(rqt)

        End Function

        Public Function GetAllWithEditionsFullCount() As Integer

            Return GetAllWithEditionsCount() - GetAllWithEditionsNotFullCount()

        End Function

        Public Function GetSeriesWithCoffretAlerts() As List(Of IdBObject)

            Dim rqt As String _
                = " SELECT tbl1.idserie" _
                & " FROM (" _
                & "     SELECT edition_serie.idserie, COUNT(*) AS nbTomesHorsCoffret" _
                & "     FROM (" _
                & "         SELECT *" _
                & "         FROM edition" _
                & "         WHERE edition.id NOT IN (SELECT idEdition FROM goody_edition)" _
                & "     ) as ed" _
                & "     INNER JOIN edition_serie ON (ed.id = edition_serie.idEdition)" _
                & "     GROUP BY idSerie" _
                & " ) tbl1" _
                & " INNER JOIN (" _
                & "     SELECT idSerie, MIN(nb) AS minPourCoffret" _
                & "     FROM (" _
                & "         SELECT serie.id as idSerie, goody.id as idGoody, COUNT(*) AS nb" _
                & "         FROM (((serie" _
                & "         INNER JOIN goody_serie ON (serie.id = goody_serie.idSerie))" _
                & "         INNER JOIN goody ON (goody_serie.idGoody = goody.id))" _
                & "         INNER JOIN goody_edition ON (goody_edition.idgoody = goody.id))" _
                & "         INNER JOIN edition ON (goody_edition.idEdition = edition.id)" _
                & "         WHERE goody.idkindofgoody IN (11, 17)" _
                & "         group by serie.id, goody.id" _
                & "     )" _
                & "     GROUP BY idserie" _
                & " ) tbl2" _
                & " ON (tbl1.idserie = tbl2.idserie)" _
                & " WHERE tbl1.nbtomeshorscoffret >= tbl2.minpourcoffret"

            Return GetByIds(rqt)

        End Function

    End Class
End Namespace