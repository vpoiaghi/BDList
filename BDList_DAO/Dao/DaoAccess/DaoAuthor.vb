Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.RequestBuilder
Imports BDList_DATABASE
Imports BDList_TOOLS

Namespace DAO

    Public Class DaoAuthor
        Inherits DaoAccess

        Private Shared daoLinkPersons As DaoLinksAccess

        Protected Friend Overrides Function GetBoType() As Type
            Return GetType(Author)
        End Function

        Protected Friend Overrides Function GetTableName() As String
            Return "Author"
        End Function

        Protected Friend Overrides Sub InitFieldsList(fieldsNames As FieldList)
            fieldsNames.AddFields("IdPerson", "Alias")
        End Sub

        Protected Friend Overrides Sub InitLinkedDaoList()
            AddNotVeryLinkedDao(GetDao(Of DaoPerson))
        End Sub

        Protected Friend Overrides Sub SetBasicRequestBuilder(ByRef reqBuilder As IBasicRequestBuilder, ByRef author As IdBObject)

            With CType(author, Author)
                reqBuilder.AddValue("Alias", GetSqlStringValue(.GetAlias))
            End With

        End Sub

        Protected Friend Overrides Sub BuildBo(sqlResult As ISqlResult, bo As IdBObject)

            With CType(bo, BoAuthor)

                .SetAlias(sqlResult.GetString("Alias"))

            End With

        End Sub

        Friend Function GetLinkedPersons(author As Author) As List(Of IdBObject)

            If daoLinkPersons Is Nothing Then
                daoLinkPersons = New DaoLinksAccess(Me, DaoManager.GetDao(Of DaoPerson))
            End If

            Return daoLinkPersons.GetLinkedObjects(author.GetId)

        End Function

        Public Overrides Function GetAll() As List(Of IdBObject)

            Dim daoPerson As DaoPerson = DaoManager.GetDao(Of DaoPerson)()

            Dim authorTableName As String = GetTableName()
            Dim personTableName As String = daoPerson.GetTableName
            Dim linkTableName As String = authorTableName & "_" & personTableName

            Dim rqt As String = " SELECT " & authorTableName & ".Id" _
                              & " FROM (" & authorTableName _
                              & " LEFT JOIN " & linkTableName & " ON (" & authorTableName & ".Id = " & linkTableName & ".IdAuthor))" _
                              & " LEFT JOIN " & personTableName & " ON (" & linkTableName & ".IdPerson = " & personTableName & ".Id)" _
                              & " ORDER BY (Alias & LastName & FirstName) ASC"

            Return GetByIds(rqt)

        End Function

        Public Function GetByAlias(allias As String) As List(Of IdBObject)

            Dim daoPerson As DaoPerson = DaoManager.GetDao(Of DaoPerson)()

            Dim personTableName As String = daoPerson.GetTableName
            Dim authorTableName As String = GetTableName()
            Dim linkTableName As String = authorTableName & "_" & personTableName

            allias = GetSqlStringValue(allias)

            Dim rqt As String = " SELECT " & authorTableName & ".Id" _
                              & " FROM (" & authorTableName _
                              & " LEFT JOIN " & linkTableName & " ON (" & authorTableName & ".Id = " & linkTableName & ".IdAuthor))" _
                              & " LEFT JOIN " & personTableName & " ON (" & linkTableName & ".IdPerson = " & personTableName & ".Id)" _
                              & " WHERE Alias = " & allias _
                              & " ORDER BY Alias ASC"

            Return GetByIds(rqt)

        End Function

        Public Function GetByPerson(ByVal p_personId As Long?) As List(Of IdBObject)

            Dim result As List(Of IdBObject)

            Dim daoPerson As DaoPerson = DaoManager.GetDao(Of DaoPerson)()

            If p_personId Is Nothing Then
                result = New List(Of IdBObject)

            Else
                Dim personTableName As String = daoPerson.GetTableName
                Dim authorTableName As String = GetTableName()
                Dim linkTableName As String = authorTableName & "_" & personTableName

                Dim rqt As String = " SELECT " & authorTableName & ".Id" _
                                  & " FROM " & authorTableName _
                                  & " LEFT JOIN " & linkTableName & " ON (" & authorTableName & ".Id = " & linkTableName & ".IdAuthor)" _
                                  & " WHERE " & linkTableName & ".IdPerson = " & p_personId _
                                  & " ORDER BY Alias ASC"

                result = GetByIds(rqt)
            End If

            Return result

        End Function

        Public Function GetByGoody(goodyId As Long?) As List(Of IdBObject)

            Dim result As List(Of IdBObject)

            Dim daoGoody As DaoGoody = DaoManager.GetDao(Of DaoGoody)()

            If goodyId Is Nothing Then
                result = New List(Of IdBObject)

            Else
                Dim goodyTableName As String = daoGoody.GetTableName
                Dim authorTableName As String = GetTableName()
                Dim linkTableName As String = goodyTableName & "_" & authorTableName

                Dim rqt As String = " SELECT " & linkTableName & ".IdAuthor" _
                                  & " FROM " & linkTableName _
                                  & " WHERE " & linkTableName & ".IdGoody = " & goodyId

                result = GetByIds(rqt)
            End If

            Return result

        End Function

        Public Function Search(searchCriteria As SearchCriteria) As List(Of IdBObject)

            Dim result As List(Of IdBObject) = Nothing

            If searchCriteria.id IsNot Nothing Then
                ' Si le critère Identifiant est renseigné, on ne tien pas compte des autres critères
                result = GetByIds("SELECT Author.Id AS Id FROM Author WHERE Id=" & searchCriteria.id)

            Else
                Dim daoPerson As DaoPerson = DaoManager.GetDao(Of DaoPerson)()
                Dim strSearchCriteria = BuildSearchCriteria(searchCriteria)

                Dim personTableName As String = DaoPerson.GetTableName
                Dim authorTableName As String = GetTableName()
                Dim linkTableName As String = authorTableName & "_" & personTableName

                Dim rqt As String = " SELECT " & authorTableName & ".Id" _
                              & " FROM (" & authorTableName _
                              & " LEFT JOIN " & linkTableName & " ON (" & authorTableName & ".Id = " & linkTableName & ".IdAuthor))" _
                              & " LEFT JOIN " & personTableName & " ON (" & linkTableName & ".IdPerson = " & personTableName & ".Id)" _
                              & strSearchCriteria _
                              & " ORDER BY (Alias & LastName & FirstName) ASC"

                result = GetByIds(rqt)

            End If

            Return result

        End Function

        Public Function SearchCount(searchCriteria As SearchCriteria) As Integer

            Dim rqt As String

            If searchCriteria.id IsNot Nothing Then
                ' Si le critère Identifiant est renseigné, on ne tien pas compte des autres critères
                rqt = "SELECT Count(*) FROM Author WHERE Id=" & searchCriteria.id

            Else
                Dim daoPerson As DaoPerson = DaoManager.GetDao(Of DaoPerson)()
                Dim strSearchCriteria = BuildSearchCriteria(searchCriteria)

                Dim personTableName As String = daoPerson.GetTableName
                Dim authorTableName As String = GetTableName()
                Dim linkTableName As String = authorTableName & "_" & personTableName

                rqt = " SELECT COUNT(*)" _
                    & " FROM (" _
                    & " SELECT DISTINCT " & authorTableName & ".Id" _
                    & " FROM (" & authorTableName _
                    & " LEFT JOIN " & linkTableName & " ON (" & authorTableName & ".Id = " & linkTableName & ".IdAuthor))" _
                    & " LEFT JOIN " & personTableName & " ON (" & linkTableName & ".IdPerson = " & personTableName & ".Id)" _
                    & strSearchCriteria _
                    & " )"

            End If

            Return GetRequestValue(rqt)

        End Function

        Private Function BuildSearchCriteria(searchCriteria As SearchCriteria) As String

            Dim result As String = ""

            Dim criteriasList As New List(Of String)

            Dim keyWord As String = searchCriteria.keyword

            ' -----------------------------------------------------------------
            ' FILTRE PAR MOT CLE SUR L'ALIAS, LE NOM OU LE PRENOM DE L'AUTEUR

            If keyWord IsNot Nothing Then
                keyWord = keyWord.Trim
                If keyWord.Length > 0 Then
                    keyWord = Accents.GetSqlAccentsFormat(keyWord)
                    criteriasList.Add("((Author.Alias LIKE ""%" & keyWord & "%"") OR (Person.Firstname LIKE ""%" & keyWord & "%"") OR (Person.Lastname LIKE ""%" & keyWord & "%""))")
                End If
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