Imports BDList_DAO_BO.BO
Imports BDList_TOOLS
Imports System.Reflection
Imports BDList_DATABASE

Namespace DAO

    Friend Class DaoUtilsDelete

        Private m_dao As DaoBObject
        Private m_linkedDaoList As LinkedDaoList = m_linkedDaoList

        Friend Sub New(dao As DaoBObject)
            m_dao = dao
            m_linkedDaoList = New LinkedDaoList
        End Sub

        Friend Sub setLinkedDaoList(linkedDaoList As LinkedDaoList)
            m_linkedDaoList = linkedDaoList
        End Sub

        Friend Sub Delete(boList As List(Of IdBObject))

            If (boList IsNot Nothing) AndAlso (boList.Count > 0) Then

                Dim ids As String = Nothing
                Dim boListToDelete As New List(Of IdBObject)

                For Each bo As IdBObject In boList
                    ids &= bo.GetId & ","
                    boListToDelete.Add(bo)
                Next

                ids = ids.Substring(0, ids.Length - 1)

                ' Suppression en base
                DeleteReferencesInLinkedTables(ids)
                DeleteVeryLinkedBos(boListToDelete)
                DeleteBo(ids)

                ' Mise à jour du cache
                For Each bo As IdBObject In boList
                    m_dao.DeleteFromCash(bo)
                Next

            End If

        End Sub

        Private Sub DeleteReferencesInLinkedTables(ids As String)

            Dim tableName As String = m_dao.GetTableName()
            Dim linkedTableName As String = Nothing
            Dim rqt As String = Nothing

            For Each linkedDao As LinkedDao In m_linkedDaoList.Items

                If (linkedDao.GetLinkedMode = LinkedDaoList.LinkedModes.MultiNotVeryLinked) _
                OrElse (linkedDao.GetLinkedMode = LinkedDaoList.LinkedModes.MultiVeryLinked) _
                Then

                    linkedTableName = tableName & "_" & linkedDao.GetDao.GetTableName

                    m_dao.ExecuteNonQuery("DELETE FROM " & linkedTableName & " WHERE Id" & tableName & " IN (" & ids & ")")

                End If
            Next

        End Sub

        Private Sub DeleteVeryLinkedBos(boList As List(Of IdBObject))

            If (boList IsNot Nothing) AndAlso (boList.Count > 0) Then

                Dim getterMethodName As String
                Dim getterMethodOfBo As MethodInfo

                ' Pour chaque liaison de daos avec le dao courant
                For Each linkedDao As LinkedDao In m_linkedDaoList.Items

                    ' Si la liaison est de type lien fort avec table de liaison
                    If (linkedDao.GetLinkedMode = LinkedDaoList.LinkedModes.MultiVeryLinked) Then

                        ' Reconstitution du nom du getter du bo courant retournant les bo liés
                        getterMethodName = "Get" & linkedDao.GetDao.GetTableName & "s"

                        ' Récupération par reflexion de la méthode getter
                        getterMethodOfBo = m_dao.GetBoType().GetMethod(getterMethodName)

                        ' Suppression des bos liés à chaque bo à supprimer du dao courant, si ceux-ci ne 
                        ' sont plus utilisés par d'autres bo du dao courant.
                        DeleteVeryLinkedBos(boList, linkedDao.GetDao, getterMethodOfBo)

                    End If
                Next
            End If

        End Sub

        Private Sub DeleteBo(ids As String)
            m_dao.ExecuteNonQuery("DELETE FROM " & m_dao.GetTableName() & " WHERE Id IN (" & ids & ")")
        End Sub

        Private Sub DeleteVeryLinkedBos(boList As IEnumerable(Of IdBObject), dao As DaoBObject, getterMethodOfBo As MethodInfo)

            Dim linkedBoToRemove As List(Of IdBObject)
            Dim linkedBoList As IEnumerable(Of IdBObject)

            For Each bo As IdBObject In boList

                ' Récupération des bos liés qui seront potentiellement à supprimer
                linkedBoList = getterMethodOfBo.Invoke(bo, Nothing)

                ' Si au moins un bo lié
                If (linkedBoList IsNot Nothing) AndAlso (linkedBoList.Count > 0) Then

                    linkedBoToRemove = New List(Of IdBObject)
                    linkedBoToRemove.AddRange(linkedBoList)

                    DeleteLinkedItems(bo, linkedBoToRemove, dao)

                End If

            Next

        End Sub

        Friend Sub DeleteLinkedItems(ByRef boToDelete As IdBObject, ByRef oldlinkedBoList As List(Of IdBObject), dao As DaoBObject)

            Dim boList As List(Of IdBObject) = GetLinkedBoNotMoreLinked(boToDelete, oldlinkedBoList, dao)

            If boList.Count > 0 Then
                dao.Delete(boList)
            End If

        End Sub

        Private Function GetLinkedBoNotMoreLinked(ByRef boToDelete As IdBObject, deletedLinksId As List(Of IdBObject), dao As DaoBObject) As List(Of IdBObject)

            Dim mustBeDeletedBoList As New List(Of IdBObject)

            If (deletedLinksId IsNot Nothing) AndAlso (deletedLinksId.Count > 0) Then

                Dim thisBoTableName As String = m_dao.GetTableName()
                Dim linkedBotableName As String = dao.GetTableName
                Dim linkTableName As String = thisBoTableName & "_" & linkedBotableName

                Dim ids As String

                ids = ""
                For Each bo As IdBObject In deletedLinksId
                    mustBeDeletedBoList.Add(bo)
                    ids &= bo.GetId & ","
                Next
                ids = ids.Substring(0, ids.Length - 1)

                Dim rqt As String = " SELECT Id" & linkedBotableName _
                                  & " FROM " & linkTableName _
                                  & " WHERE Id" & linkedBotableName & " IN (" & ids & ")" '_
                '& " AND NOT Id" & thisBoTableName & " = " & boToDelete.GetId()

                Dim sqlResult As ISqlResult = m_dao.ExecuteQuery(rqt)

                Dim alwaysUsedIdList = New List(Of IdBObject)

                While sqlResult.MoveNext
                    mustBeDeletedBoList.Remove(dao.GetById(sqlResult.GetInteger(0)))
                End While

            End If

            Return mustBeDeletedBoList

        End Function

    End Class

End Namespace