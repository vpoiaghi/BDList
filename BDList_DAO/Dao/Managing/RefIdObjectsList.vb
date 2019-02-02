Imports BDList_DAO_BO.BO

Namespace DAO

    Friend Class RefIdObjectsList

        Private m_idsList As List(Of Long?)
        Private m_idBObjectsList As List(Of IdBObject)

        Friend Sub New()
            m_idsList = New List(Of Long?)
        End Sub

        Friend Sub New(id As Long)
            Me.New()
            Me.Add(id)
        End Sub

        Friend Sub New(idsList As List(Of Long?))
            Me.New()
            Me.AddRange(idsList)
        End Sub

        Friend Function GetIdBObjectsList(dao As DaoBObject) As List(Of IdBObject)

            If m_idBObjectsList Is Nothing Then
                m_idBObjectsList = dao.GetByIds(m_idsList)
            End If

            Return m_idBObjectsList

        End Function

        Friend Sub Add(id As Long)

            If Not m_idsList.Contains(id) Then
                m_idsList.Add(id)
            End If

        End Sub

        Friend Sub AddRange(idsList As List(Of Long?))

            For Each id As Long In idsList
                Me.Add(id)
            Next

        End Sub

    End Class

End Namespace
