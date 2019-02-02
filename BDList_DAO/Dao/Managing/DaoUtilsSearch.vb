Imports BDList_DAO_BO.BO
Imports BDList_DATABASE
Imports BDList_TOOLS

Namespace DAO

    Friend Class DaoUtilsSearch

        Private m_dao As DaoBObject

        Friend Sub New(dao As DaoBObject)
            m_dao = dao
        End Sub

        Friend Function GetById(id As Long?) As IdBObject

            Return FindBoById(id)

        End Function

        Friend Function GetInBaseById(id As Long?) As List(Of IdBObject)

            Dim result As New List(Of IdBObject)

            Dim rqt As String = "SELECT * FROM " & m_dao.GetTableName() & " WHERE Id=" & id

            Dim sqlResult As ISqlResult = m_dao.ExecuteQuery(rqt)

            While sqlResult.MoveNext
                result.Add(m_dao.SqlResultToBo(sqlResult))
            End While

            Return result

        End Function

        Protected Friend Function GetRequestValues(rqt As String) As List(Of IComparable)

            Dim result As New List(Of IComparable)

            Dim sqlResult As ISqlResult = m_dao.ExecuteQuery(rqt)

            While sqlResult.MoveNext
                result.Add(sqlResult.GetValue(0))
            End While

            Return result

        End Function

        Friend Function GetByIds(idsList As List(Of Long?)) As List(Of IdBObject)

            Dim result As New List(Of IdBObject)

            Dim unknownIds As New Hashtable(Of Long?, Integer) ' identifient du bo, position dans le résultat de la requête
            Dim bo As IdBObject
            Dim i As Integer = 0

            For Each id As Long In idsList

                bo = m_dao.GetInCashById(id)

                If bo Is Nothing Then
                    unknownIds.Add(id, i)
                End If

                ' Ajout du bo même si il est à Nothing pour instancier la position
                result.Add(bo)

                i += 1
            Next

            FindBoListInBase(unknownIds, result)

            Return result

        End Function


        Friend Function GetIds(rqt As String) As List(Of IdBObject)

            Dim id1 As Long?
            Dim unknownIds As New Hashtable(Of Long?, Integer) ' identifient du bo, position dans le résultat de la requête
            Dim allIds As New List(Of Long?)

            Dim idFilterList As New List(Of IComparable)

            Dim sqlResult As ISqlResult = m_dao.ExecuteQuery(rqt)

            Dim result As New List(Of IdBObject)()

            Dim bo As IdBObject
            Dim rowIndex As Integer = 0

            While sqlResult.MoveNext

                id1 = sqlResult.GetLong(0)

                If Not idFilterList.Contains(id1) Then

                    idFilterList.Add(id1)
                    bo = m_dao.GetInCashById(id1)

                    If bo Is Nothing Then
                        unknownIds.Add(id1, rowIndex)
                    End If

                    ' Ajout du bo même si il est à Nothing pour instancier la position
                    result.Add(bo)

                    rowIndex += 1

                End If

            End While

            FindBoListInBase(unknownIds, result)

            Return result

        End Function

        ' ********************************************************************* 
        ' Retourne une liste de IBo pour un Id donné (normalement un ou zéro Bo
        ' atendu).
        ' Le Bo est recherché en mémoire cash. 
        ' Si il n'est pas trouvé, il est recherché en base.
        '
        ' @param id : identifiant technique du bo recherché.
        ' @return : une liste contenant un IBo si trouvé, ou une liste vide si
        '           le IBo n'est ni en cash ni en base.
        '
        ' *********************************************************************
        Private Function FindBoById(id As Long?) As IdBObject

            Dim result As IdBObject

            ' Recherche du bo correspondant à l'id dans la mémoire cash.
            Dim bo As IdBObject = m_dao.GetInCashById(id)

            If bo Is Nothing Then
                ' Si le bo correspondant à l'id n'est pas en cash on va le chercher
                ' en base.

                ' Map avec identifient du bo et position dans le résultat de la requête.
                Dim unknownIds As New Hashtable(Of Long?, Integer)
                unknownIds.Add(id, 0)

                ' Ajout d'une valeur Nothing dans la liste pour instancier la position
                Dim resultsList As New List(Of IdBObject)
                resultsList.Add(Nothing)

                ' Recherche en base.
                FindBoListInBase(unknownIds, resultsList)

                If resultsList.Count = 0 Then
                    result = Nothing
                ElseIf resultsList.Count = 1 Then
                    result = resultsList(0)
                Else
                    Throw New IndexOutOfRangeException("La table " & m_dao.GetTableName & " contient " & resultsList.Count & " enregistrements avec l'id " & id)
                End If

            Else
                ' Sinon, si le bo correspondant à l'id est en cash on l'ajoute
                ' à la liste des résultats.
                result = bo
            End If

            Return result

        End Function

        Private Sub FindBoListInBase(unknownIds As Hashtable(Of Long?, Integer), result As List(Of IdBObject))

            Dim unknownIdsCount As Integer = unknownIds.Count
            Dim cashBoList As List(Of BObject) = m_dao.GetCashBoList

            If unknownIdsCount > 0 Then

                Dim b As IdBObject
                Dim idsCount As Integer = 0
                Dim maxIdsByRequest As Integer = 250
                Dim rqt As String = Nothing
                Dim sqlResult As ISqlResult

                Dim unknownIdsEntry As DictionaryEntry
                Dim unknownIdsEnum As IDictionaryEnumerator = unknownIds.GetEnumerator

                While unknownIdsEnum.MoveNext()

                    unknownIdsEntry = unknownIdsEnum.Entry

                    rqt = "SELECT * FROM " & m_dao.GetTableName() & " WHERE Id IN (" & unknownIdsEntry.Key.ToString
                    idsCount = 1

                    While (idsCount < maxIdsByRequest) AndAlso (unknownIdsEnum.MoveNext())

                        unknownIdsEntry = unknownIdsEnum.Entry

                        rqt &= "," & unknownIdsEntry.Key.ToString
                        idsCount += 1

                    End While

                    rqt = rqt & ")"
                    sqlResult = m_dao.ExecuteQuery(rqt)

                    While sqlResult.MoveNext

                        Try

                            b = m_dao.SqlResultToBo(sqlResult)

                            cashBoList.Add(b)
                            result.Item(unknownIds.Item(b.GetId)) = b

                        Catch ex As Exception
                            MsgBox("Une erreur s'est produite lors de l'initialisation de l'objet " & m_dao.GetTableName() & " ayant l'id " & sqlResult.GetInteger(0) & ".", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Erreur de BuildBo...")
                        End Try

                    End While

                End While

            End If

        End Sub

    End Class

End Namespace