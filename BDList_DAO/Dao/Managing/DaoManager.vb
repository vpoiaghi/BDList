Imports BDList_DAO_BO.DAO

Public Class DaoManager

    Private Shared addedHandlerLockObject As New Object

    Private Shared m_instance As New DaoManager

    Private m_daoMap As Hashtable           ' clé = type d'un dao, valeur = l'instance du type de dao
    Private m_daoBoRelations As Hashtable   ' clé = un dao, valeur = type des bo gérés par le dao
    Private m_boDaoRelations As Hashtable   ' clé = un type de bo, valeur = le dao gérant ce type de bo

    Private Sub New()

        m_daoMap = New Hashtable()
        m_daoBoRelations = New Hashtable
        m_boDaoRelations = New Hashtable

    End Sub

    Public Shared Function GetInstance() As DaoManager
        Return m_instance
    End Function

    Public Shared Function GetDao(Of DaoType As {IDao})() As DaoType
        Return GetInstance.GetDaoAndCreateIfNotExists(GetType(DaoType))
    End Function

    Public Shared Function GetDao(daoType As Type) As IDao
        Return GetInstance.GetDaoAndCreateIfNotExists(daoType)
    End Function

    Private Function GetDaoAndCreateIfNotExists(daoType As Type) As IDao

        SyncLock addedHandlerLockObject
            'Console.WriteLine("Début GetDaoAndCreateIfNotExists(" & daoType.ToString & ")")

            Dim d As IDao = m_daoMap.Item(daoType)

            If d Is Nothing Then

                Dim o As Object = daoType.GetConstructor(Type.EmptyTypes).Invoke(Nothing)
                d = CType(o, IDao)
                Dim fd As DAO.DaoBObject = CType(o, DAO.DaoBObject)

                m_daoBoRelations.Add(d, fd.GetBoType)

                Try
                    m_daoMap.Add(daoType, d)
                Catch ex As Exception
                End Try

            End If

            'Console.WriteLine("Fin GetDaoAndCreateIfNotExists(" & daoType.ToString & ")")

            Return d

        End SyncLock

    End Function

    Private Function Items() As List(Of IDao)
        Return m_daoMap.Values
    End Function

End Class