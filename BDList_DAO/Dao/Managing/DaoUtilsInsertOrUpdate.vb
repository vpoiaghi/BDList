Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.RequestBuilder
Imports BDList_TOOLS
Imports BDList_DATABASE

Namespace DAO

    Friend Class DaoUtilsInsertOrUpdate

        Private m_dao As DaoBObject
        'Private m_linkedDaoList As LinkedDaoList

        Friend Sub New(dao As DaoBObject)
            m_dao = dao
        End Sub

        Friend Sub SetLinkedDaoList(linkedDaoList As LinkedDaoList)
            'm_linkedDaoList = linkedDaoList
        End Sub

        Friend Function InsertOrUpdate(bo As IdBObject) As IdBObject

            Dim oldBo As idbobject = Nothing

            bo.SetModifiedDateTime(Now)

            If bo.IsInBase Then
                oldBo = UpdateBo(bo)
            Else
                InsertBo(bo)
            End If

            Return oldBo

        End Function

        Friend Sub InsertOrUpdateRange(boList As List(Of IdBObject))

            Dim reqInsertBuilder As IBasicRequestBuilder
            reqInsertBuilder = m_dao.GetBasicRequestBuilder

            Dim reqUpdateBuilder As IBasicRequestBuilder
            reqUpdateBuilder = m_dao.GetBasicRequestBuilder

            Dim cashBoList As List(Of BObject) = m_dao.GetCashBoList

            For Each bo As IdBObject In boList

                bo.SetModifiedDateTime(Now)

                If bo.IsInBase Then
                    reqUpdateBuilder.AddRow()
                    m_dao.InitBasicRequestBuilder(reqUpdateBuilder, bo)
                Else
                    reqInsertBuilder.AddRow()
                    m_dao.InitBasicRequestBuilder(reqInsertBuilder, bo)
                    cashBoList.Add(bo)
                End If

            Next

            Dim requests As List(Of String)

            requests = reqInsertBuilder.GetInsertRangeRequests
            For Each request As String In requests
                m_dao.ExecuteNonQuery(request)
            Next

            requests = reqUpdateBuilder.GetUpdateRangeRequests
            For Each request As String In requests
                m_dao.ExecuteNonQuery(request)
            Next

            For Each bo As IdBObject In boList
                bo.SetInBase(True)
            Next

        End Sub

        Private Sub InsertBo(bo As IdBObject)

            Dim reqBuilder As IBasicRequestBuilder
            reqBuilder = m_dao.GetBasicRequestBuilder

            m_dao.InitBasicRequestBuilder(reqBuilder, bo)
            m_dao.ExecuteNonQuery(reqBuilder.GetInsertRequest)

            InsertBoLinks(bo)
            m_dao.GetCashBoList.Add(bo)

            bo.SetInBase(True)

        End Sub

        Private Function UpdateBo(ByRef bo As IdBObject) As IdBObject

            Dim oldBos As List(Of IdBObject) = m_dao.GetInBaseById(bo.GetId())
            Dim oldBo As IdBObject = oldBos(0)

            Dim reqBuilder As IBasicRequestBuilder
            reqBuilder = m_dao.GetBasicRequestBuilder

            reqBuilder.AddCriterias("Id = " & m_dao.GetSqlIdValue(bo))

            m_dao.InitBasicRequestBuilder(reqBuilder, bo)
            m_dao.ExecuteNonQuery(reqBuilder.GetUpdateRequest)

            UpdateBoLinks(bo)

            Return oldBo

        End Function

        Private Sub InsertBoLinks(bo As IdBObject)

            'For Each d As LinkedDao In m_linkedDaoList.Items
            For Each d As LinkedDao In m_dao.GetLinkedDaoList.Items
                InsertBosLinks(bo, d.GetDao)
            Next

        End Sub

        Private Sub UpdateBoLinks(bo As IdBObject)

            'For Each d As LinkedDao In m_linkedDaoList.Items
            For Each d As LinkedDao In m_dao.GetLinkedDaoList().Items

                Select Case d.GetLinkedMode
                    Case LinkedDaoList.LinkedModes.MultiNotVeryLinked : UpdateBosLinks(bo, d.GetDao)
                    Case LinkedDaoList.LinkedModes.MultiVeryLinked : UpdateAndCleanLinkedItems(bo, d.GetDao)
                End Select

            Next

        End Sub

        ' *********************************************************************
        ' Mets à jour la liste des liens entre le bo à mettre à jour et les bos
        ' liés pour une table liée donnée.
        '
        ' @param : boToInsert : le bo à mettre à jour en base.
        ' @param : linkedDao : le dao lié
        ' *********************************************************************
        Private Sub InsertBosLinks(boToInsert As IdBObject, linkedDao As DaoBObject)

            Dim thisBoTableName As String = m_dao.GetTableName()
            Dim linkedBoTableName As String = linkedDao.GetTableName()
            Dim linkTableName As String = thisBoTableName & "_" & linkedBoTableName

            Dim methodName As String = "Get" & linkedBoTableName & "s"
            Dim methodGetBos As Reflection.MethodInfo = boToInsert.GetType.GetMethod(methodName)

            If methodGetBos Is Nothing Then
                methodName = "Get" & linkedBoTableName.Substring(0, 1).ToUpper & linkedBoTableName.Substring(1) & "s"
                methodGetBos = boToInsert.GetType.GetMethod(methodName)
            End If

            Dim tmpNewLinkedBoLists As IEnumerable(Of idbobject) = methodGetBos.Invoke(boToInsert, Nothing)

            Dim values As New List(Of String)
            Dim boToInsertId As String = boToInsert.GetId.ToString

            For Each linkedBo As idbobject In tmpNewLinkedBoLists

                values.Clear()
                values.Add(boToInsertId)
                values.Add(linkedBo.GetId.ToString)

                m_dao.Insert(linkTableName, values)

            Next

        End Sub

        ' *********************************************************************
        ' Mets à jour la liste des liens entre le bo à mettre à jour et les bos
        ' liés pour une table liée donnée.
        '
        ' @param : boToUpdate : le bo à mettre à jour en base.
        ' @param : linkedDao : le dao lié
        ' *********************************************************************
        Private Sub UpdateBosLinks(boToUpdate As IdBObject, linkedDao As DaoBObject)

            Dim thisBoTableName As String = m_dao.GetTableName()
            Dim linkedBoTableName As String = linkedDao.GetTableName()
            Dim linkTableName As String = thisBoTableName & "_" & linkedBoTableName

            m_dao.DeleteLinks(linkedBoTableName, boToUpdate.GetId)

            Dim methodName As String = "Get" & linkedBoTableName & "s"
            Dim methodGetBos As Reflection.MethodInfo = boToUpdate.GetType.GetMethod(methodName)

            If methodGetBos Is Nothing Then
                methodName = "Get" & linkedBoTableName.Substring(0, 1).ToUpper & linkedBoTableName.Substring(1) & "s"
                methodGetBos = boToUpdate.GetType.GetMethod(methodName)
            End If

            Dim tmpNewLinkedBoLists As IEnumerable(Of idbobject) = methodGetBos.Invoke(boToUpdate, Nothing)

            Dim values As New List(Of String)
            Dim boToUpdateId As String = boToUpdate.GetId.ToString

            For Each linkedBo As idbobject In tmpNewLinkedBoLists

                values.Clear()
                values.Add(boToUpdateId)
                values.Add(linkedBo.GetId.ToString)

                m_dao.Insert(linkTableName, values)

            Next

        End Sub

        Protected Sub UpdateAndCleanLinkedItems(ByRef newBo As IdBObject, dao As DaoBObject)

            ' Récupération des bos liés en base.
            Dim oldlinkedBoList As List(Of idbobject) = m_dao.GetLinkedBoInBase(newBo, dao)

            ' Mise à jour en base de la table de liaison (Suppression des 
            ' liaisons abandonnées, et création des nouvelles liaisons).
            UpdateBosLinks(newBo, dao)

            ' Suppression en base et en cache des bo anciennement liés et
            ' qui ne sont plus liés à aucun bo du type courant.
            m_dao.DeleteLinkedItems(newBo, oldlinkedBoList, dao)

        End Sub

    End Class

End Namespace