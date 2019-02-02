Imports BDList_DAO_BO.BO
Imports BDList_DATABASE
Imports BDList_TOOLS

Namespace DAO

    Friend MustInherit Class DaoLinks
        Inherits Dao
        Implements IDaoLinks

        Protected MustOverride Function GetRequestSelectAll() As String
        Protected MustOverride Function GetRequestDeleteAll() As String

        Private m_dao1 As DaoBObject
        Private m_dao2 As DaoBObject

        Private m_map1 As New Hashtable(Of Long, RefIdObjectsList)
        'Private m_map2 As New Hashtable(Of Long, RefIdObjectsList)

        Public Sub New(dao1 As DaoBObject, dao2 As DaoBObject)
            m_dao1 = dao1
            m_dao2 = dao2
        End Sub

        Protected Friend Overrides Function GetTableName() As String
            Return m_dao1.GetTableName & "_" & m_dao2.GetTableName
        End Function

        Protected Friend Overrides Function GetBoType() As Type
            Return GetType(LinkBObject)
        End Function

        Public Function GetLinkedObjects(id As Long) As List(Of IdBObject)

            Dim result As List(Of IdBObject)

            If m_cashBoList.Count = 0 Then
                Update()
            End If

            Dim ref As RefIdObjectsList = m_map1.Item(id)

            If ref IsNot Nothing Then
                result = ref.GetIdBObjectsList(m_dao2)
            Else
                result = New List(Of IdBObject)
            End If

            Return result

        End Function

        Private Sub Update()

            Dim allLinks As List(Of LinkBObject) = GetAll()

            m_cashBoList.Clear()
            m_map1.Clear()
            'm_map2.Clear()

            m_dao1.GetAll()
            m_dao2.GetAll()

            For Each link As LinkBObject In allLinks

                AddLink(m_map1, link.GetId1, link.GetId2)
                'AddLink(m_map2, link.GetId2, link.GetId1)

                m_cashBoList.Add(link)

            Next

        End Sub

        Private Sub AddLink(map As Hashtable(Of Long, RefIdObjectsList), id1 As Long, id2 As Long)

            Dim ref As RefIdObjectsList = map.Item(id1)

            If ref Is Nothing Then
                ref = New RefIdObjectsList()
                map.Add(id1, ref)
            End If

            ref.Add(id2)

        End Sub

        Private Function GetAll() As List(Of LinkBObject)

            Dim rqt As String = "SELECT * FROM " & GetTableName()
            Dim result As ISqlResult = ExecuteQuery(rqt)

            Dim linksList As New List(Of LinkBObject)

            While result.MoveNext

                linksList.Add(New LinkBObject(result.GetLong(0), result.GetLong(1)))

            End While

            Return linksList

        End Function

        'Public Overrides Sub Delete(ParamArray boArray() As IdBObject)
        'End Sub

        Public Overrides Sub Delete(bo As IdBObject)
        End Sub

        Public Overrides Sub Delete(boList As List(Of IdBObject))
        End Sub

        Protected Overrides Sub DeleteAllInBase()
            ExecuteNonQuery(GetRequestDeleteAll)
        End Sub

        Public Overrides Sub DeleteAll()

            DeleteAllInBase()
            GetCashBoList.Clear()

        End Sub

        Public Overrides Function InsertOrUpdate(bo As IdBObject) As IdBObject
            Return Nothing
        End Function

        Public Overrides Sub InsertOrUpdateRange(boList As List(Of IdBObject))

        End Sub

        Friend Overrides Function GetSqlIdValue(value As Long?) As String

            If value Is Nothing Then
                Return "NULL"
            ElseIf Not value.HasValue Then
                Return "NULL"
            Else
                Return value.ToString
            End If

        End Function


    End Class

End Namespace