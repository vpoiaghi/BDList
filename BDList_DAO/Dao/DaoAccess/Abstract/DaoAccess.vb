Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.RequestBuilder
Imports BDList_DATABASE
Imports BDList_TOOLS.Types.Sql


Namespace DAO

    Public MustInherit Class DaoAccess
        Inherits DaoBObject

        ' Classes utilitaires spécifiques
        Private m_daoSearch As DaoUtilsSearch
        Private m_daoInsertOrUpdate As DaoUtilsInsertOrUpdate
        Private m_daoDelete As DaoUtilsDelete

        Private m_reqBuilder As IBasicRequestBuilder

        Protected Friend Sub New()
            MyBase.New()

            m_daoSearch = New DaoUtilsSearch(Me)
            m_daoInsertOrUpdate = New DaoUtilsInsertOrUpdate(Me)
            m_daoDelete = New DaoUtilsDelete(Me)

            m_daoDelete.setLinkedDaoList(GetLinkedDaoList)
            m_daoInsertOrUpdate.SetLinkedDaoList(GetLinkedDaoList)

        End Sub

        Protected Friend Overrides Sub InitBasicRequestBuilder(ByRef reqBuilder As IBasicRequestBuilder, ByRef bo As IdBObject)

            reqBuilder.AddValue(GetIdFieldName, GetSqlIdValue(bo.GetId))
            reqBuilder.AddValue(GetModifiedDateTimeFieldName, GetSqlDateValue(bo.GetModifiedDateTime))

            SetBasicRequestBuilder(reqBuilder, bo)

        End Sub

        Protected Friend Overrides Function GetIdFieldName() As String
            Return "Id"
        End Function

        Protected Friend Overrides Function GetModifiedDateTimeFieldName() As String
            Return "TSP"
        End Function

        Protected Friend Overrides Function GetConnectionType() As ConnectionTypes
            Return ConnectionTypes.Access
        End Function

        Protected Friend Overrides Function GetBasicRequestBuilder() As IBasicRequestBuilder
            Return New BasicAccessRequestBuilder(Me)
        End Function

        Friend Overrides Function GetInBaseById(id As Long?) As List(Of IdBObject)
            Return m_daoSearch.GetInBaseById(id)
        End Function

        Public Overrides Function GetById(id As Long?) As IdBObject
            Return m_daoSearch.GetById(id)
        End Function

        Public Overrides Function GetAll() As List(Of IdBObject)

            Dim rqt As String = " SELECT " & GetIdFieldName() & " FROM " & GetTableName() & " ORDER BY " & GetIdFieldName() & " ASC"

            Return m_daoSearch.GetIds(rqt)

        End Function

        Public Overrides Function GetAllSortedById() As List(Of IdBObject)

            Dim rqt As String = " SELECT " & GetIdFieldName() & " FROM " & GetTableName() & " ORDER BY " & GetIdFieldName() & " ASC"

            Return m_daoSearch.GetIds(rqt)

        End Function

        Public Overrides Function GetCount() As Integer

            Dim rqt As String = " SELECT COUNT(*)" & " FROM " & GetTableName()

            Return GetRequestValue(rqt)

        End Function

        Public Overrides Function GetChanged(fromDate As DateTime) As List(Of IdBObject)

            Dim rqt As String = " SELECT * FROM " & GetTableName() & " WHERE (" & GetModifiedDateTimeFieldName() & ">" & GetSqlDateValue(fromDate) & ") ORDER BY " & GetIdFieldName() & " ASC"

            Return m_daoSearch.GetIds(rqt)

        End Function

        Public Overrides Function InsertOrUpdate(bo As IdBObject) As IdBObject
            Return m_daoInsertOrUpdate.InsertOrUpdate(bo)
        End Function

        Public Overrides Sub InsertOrUpdateRange(boList As List(Of IdBObject))
            m_daoInsertOrUpdate.InsertOrUpdateRange(boList)
        End Sub

        Friend Overrides Sub Insert(tableName As String, values As List(Of String))

            Dim insertRequest As String = "INSERT INTO " & tableName & " VALUES ("

            For Each value As String In values
                insertRequest &= value & ","
            Next

            insertRequest = insertRequest.Substring(0, insertRequest.Length - 1) & ")"

            ExecuteNonQuery(insertRequest)

        End Sub

        Protected Friend Overloads Function GetByIds(rqt As String) As List(Of IdBObject)
            Return m_daoSearch.GetIds(rqt)
        End Function

        Friend Overrides Function GetByIds(idsList As List(Of Long?)) As List(Of IdBObject)
            Return m_daoSearch.GetByIds(idsList)
        End Function

        Protected Friend Function GetRequestValue(rqt As String) As IComparable

            Dim result As IComparable = Nothing
            Dim valuesList As List(Of IComparable) = m_daoSearch.GetRequestValues(rqt)

            If valuesList.Count > 0 Then
                result = valuesList(0)
            End If

            Return result

        End Function

        Protected Friend Function GetRequestValues(rqt As String) As List(Of IComparable)
            Return m_daoSearch.GetRequestValues(rqt)
        End Function

        'Public Overrides Sub Delete(ParamArray boArray() As IdBObject)
        '    m_daoDelete.Delete(boArray)
        'End Sub

        Public Overrides Sub Delete(bo As IdBObject)

            Dim boList As New List(Of IdBObject)
            boList.Add(bo)

            m_daoDelete.Delete(boList)

        End Sub

        Public Overrides Sub Delete(boList As List(Of IdBObject))
            m_daoDelete.Delete(boList)
        End Sub

        Public Overrides Sub DeleteAll()
            Throw New NotSupportedException("DeleteAll n'est pas autorisée")
        End Sub

        Protected Overrides Sub DeleteAllInBase()
            ExecuteNonQuery("DELETE FROM " & GetTableName())
        End Sub

        Public Overrides Sub DeleteLinks(linkedTableName As String, id As Long?)

            Dim thisBoTableName As String = GetTableName()
            Dim linkedBoTableName As String = thisBoTableName & "_" & linkedTableName

            Dim deleteRequest As String = " DELETE FROM " & linkedBoTableName & " WHERE Id" & thisBoTableName & " = " & id

            ExecuteNonQuery(deleteRequest)

        End Sub

        Protected Function ItemToBo(row As DataRow, columnName As String) As Object

            Dim value As Object = Nothing

            Try
                value = row.Item(columnName)
            Catch e As System.ArgumentException
                MsgBox("La colonne " & columnName & " est inconnue dans la table " & GetTableName() & vbCrLf & vbCrLf & e.Message, vbCritical + MsgBoxStyle.OkOnly, "Erreur...")
            End Try

            If value IsNot Nothing Then
                If TypeOf value Is DBNull Then
                    value = Nothing
                End If
            End If

            Return value

        End Function

        Protected Friend Function GetLinkedBoById(ByRef sqlResult As ISqlResult, ByRef daoType As Type, ByRef idFieldName As String) As IdBObject

            Dim result As IdBObject = Nothing
            Dim dao As IDao = GetDao(daoType)
            Dim id As Long? = sqlResult.GetLong(idFieldName)

            If id IsNot Nothing Then
                result = GetLinkedBoById(dao, id)
            End If

            Return result

        End Function

        Protected Friend Function GetLinkedBoById(dao As DaoBObject, id As Long?) As IdBObject
            Return dao.GetById(id)
        End Function

        Protected Sub AddFieldValue(fieldName As String, value As Object)
            m_reqBuilder.AddValue(fieldName, value)
        End Sub

        Friend Overrides Sub DeleteLinkedItems(ByRef newBo As IdBObject, ByRef oldlinkedBoList As List(Of IdBObject), dao As DaoBObject)
            m_daoDelete.DeleteLinkedItems(newBo, oldlinkedBoList, dao)
        End Sub

        Friend Overrides Function GetLinkedBoInBase(newBo As IdBObject, dao As DaoBObject) As List(Of IdBObject)

            Dim boList As New List(Of IdBObject)

            Dim thisTableName As String = GetTableName()
            Dim linkedTableName As String = dao.GetTableName()
            Dim linkTableName As String = thisTableName & "_" & linkedTableName

            Dim rqt As String = " SELECT Id" & linkedTableName _
                              & " FROM " & linkTableName _
                              & " WHERE Id" & thisTableName & " = " & newBo.GetId()

            Dim sqlResult As ISqlResult = ExecuteQuery(rqt)

            While sqlResult.MoveNext
                boList.Add(dao.GetById(sqlResult.GetLong(0)))
            End While

            Return boList

        End Function

        Protected Function GetLinkTableName(Of DaoType1 As DaoAccess, DaoType2 As DaoAccess)() As String

            Dim tableName1 As String = DaoManager.GetDao(Of DaoType1).GetTableName
            Dim tableName2 As String = DaoManager.GetDao(Of DaoType2).GetTableName
            Return tableName1 & "_" & tableName2

        End Function

        Protected Friend Overrides Function GetLastIdInBase(tableName As String) As ISqlResult
            Return ExecuteQuery("SELECT MAX(Id) FROM " & GetTableName())
        End Function

        Friend Overrides Function GetSqlIdValue(value As Long?) As String
            Return GetSqlLongValue(value)
        End Function

        Friend Overrides Function GetSqlIdValue(value As IdBObject) As String

            If value Is Nothing Then
                Return "NULL"
            Else
                Return GetSqlIdValue(value.GetId)
            End If

        End Function

        Protected Overrides Function GetSqlStringValue(value As String) As String

            If String.IsNullOrEmpty(value) Then
                Return "NULL"
            Else
                Return """" & value.Replace("""", """""") & """"
            End If

        End Function

        Protected Overrides Function GetSqlIntegerValue(value As Integer) As String
            Return value.ToString
        End Function

        Protected Overrides Function GetSqlIntegerValue(value As Nullable(Of Integer)) As String

            If value Is Nothing Then
                Return "NULL"
            ElseIf Not value.HasValue Then
                Return "NULL"
            Else
                Return GetSqlIntegerValue(value.Value)
            End If

        End Function

        Protected Overrides Function GetSqlLongValue(value As Long) As String
            Return value.ToString
        End Function

        Protected Overrides Function GetSqlLongValue(value As Nullable(Of Long)) As String

            If value Is Nothing Then
                Return "NULL"
            ElseIf Not value.HasValue Then
                Return "NULL"
            Else
                Return GetSqlLongValue(value.Value)
            End If

        End Function

        Protected Overrides Function GetSqlSingleValue(value As Single) As String
            Return value.ToString.Replace(",", ".")
        End Function

        Protected Overrides Function GetSqlSingleValue(value As Nullable(Of Single)) As String

            If value Is Nothing Then
                Return "NULL"
            ElseIf Not value.HasValue Then
                Return "NULL"
            Else
                Return GetSqlSingleValue(value.Value)
            End If

        End Function

        Protected Overrides Function GetSqlBooleanValue(value As Boolean) As String
            Return IIf(value, "TRUE", "FALSE")
        End Function

        Protected Overrides Function GetSqlDateValue(value As DateTime) As String
            Return "#" & value.ToString("MM/dd/yyyy HH:mm:ss") & "#"
        End Function

        Protected Overrides Function GetSqlDateValue(value As SqlDate) As String

            If value Is Nothing Then
                Return "NULL"
            Else
                Return value.GetValue
            End If

        End Function

        Protected Overrides Function GetSqlDateValue(value As Nullable(Of DateTime)) As String

            If value Is Nothing Then
                Return "NULL"
            ElseIf Not value.HasValue Then
                Return "NULL"
            Else
                Return GetSqlDateValue(value.Value)
            End If

        End Function

    End Class

End Namespace