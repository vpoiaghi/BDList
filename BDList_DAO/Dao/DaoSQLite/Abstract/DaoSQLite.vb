Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.RequestBuilder
Imports BDList_DATABASE
Imports BDList_TOOLS
Imports BDList_TOOLS.Types.Sql

Imports System.Text

Namespace DAO

    Public MustInherit Class DaoSQLite
        Inherits DaoBObject

        ' Classes utilitaires spécifiques
        Private m_daoSearch As DaoUtilsSearch
        Private m_daoInsertOrUpdate As DaoUtilsInsertOrUpdate
        Private m_daoDelete As DaoUtilsDelete


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
            reqBuilder.AddValue(GetModifiedDateTimeFieldName, GetSqlDateValue(New SqlDate(bo.GetModifiedDateTime)))

            SetBasicRequestBuilder(reqBuilder, bo)

        End Sub

        Protected Friend Overrides Function GetIdFieldName() As String
            Return "id"
        End Function

        Protected Friend Overrides Function GetModifiedDateTimeFieldName() As String
            Return "TSP"
        End Function

        Protected Friend Overrides Function GetConnectionType() As ConnectionTypes
            Return ConnectionTypes.SQLite
        End Function

        Protected Friend Overrides Function GetBasicRequestBuilder() As IBasicRequestBuilder
            Return New BasicSQLiteRequestBuilder(Me)
        End Function

        Public Overrides Function GetAll() As List(Of IdBObject)

            Dim rqt As String = " SELECT Id" & " FROM " & GetTableName() & " ORDER BY Id ASC"

            Return m_daoSearch.GetIds(rqt)

        End Function

        Public Overrides Function GetAllSortedById() As List(Of IdBObject)

            Dim rqt As String = " SELECT Id" & " FROM " & GetTableName() & " ORDER BY Id ASC"

            Return m_daoSearch.GetIds(rqt)

        End Function

        Public Overrides Function GetCount() As Integer

            Dim rqt As String = " SELECT COUNT(*)" & " FROM " & GetTableName()

            Return GetRequestValue(rqt)

        End Function

        Protected Friend Function GetRequestValue(rqt As String) As IComparable

            Dim result As IComparable = Nothing
            Dim valuesList As List(Of IComparable) = m_daoSearch.GetRequestValues(rqt)

            If valuesList.Count > 0 Then
                result = valuesList(0)
            End If

            Return result

        End Function

        Public Overrides Function GetChanged(fromDate As DateTime) As List(Of IdBObject)

            Dim rqt As String = " SELECT * FROM " & GetTableName() & " WHERE (" & GetModifiedDateTimeFieldName() & ">" & GetSqlDateValue(fromDate) & ") ORDER BY Id ASC"

            Return m_daoSearch.GetIds(rqt)

        End Function

        Public Overrides Function InsertOrUpdate(bo As IdBObject) As IdBObject
            Return m_daoInsertOrUpdate.InsertOrUpdate(bo)
        End Function

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

        Public Overrides Sub Delete(bo As IdBObject)

            Dim boList As New List(Of IdBObject)
            boList.Add(bo)

            m_daoDelete.Delete(boList)

        End Sub

        Public Overrides Sub Delete(boList As List(Of IdBObject))
            m_daoDelete.Delete(boList)
        End Sub

        Protected Overrides Sub DeleteAllInBase()
            ExecuteNonQuery("DELETE FROM " & GetTableName())
        End Sub

        Public Overrides Sub DeleteLinks(linkedTableName As String, id As Long?)

            Dim thisBoTableName As String = GetTableName()
            Dim linkedBoTableName As String = thisBoTableName & "_" & linkedTableName

            Dim deleteRequest As String = " DELETE " & " FROM " & linkedBoTableName & " WHERE Id" & thisBoTableName & " = " & id

            ExecuteNonQuery(deleteRequest)

        End Sub

        Public Overrides Function GetById(id As Long?) As IdBObject
            Return m_daoSearch.GetById(id)
        End Function

        Friend Overrides Sub DeleteLinkedItems(ByRef newBo As IdBObject, ByRef oldlinkedBoList As List(Of IdBObject), dao As DaoBObject)
            Throw New NotImplementedException
        End Sub

        Friend Overrides Function GetInBaseById(id As Long?) As List(Of IdBObject)
            Return m_daoSearch.GetInBaseById(id)
        End Function

        Friend Overrides Function GetLinkedBoInBase(newBo As IdBObject, dao As DaoBObject) As List(Of IdBObject)
            Throw New NotImplementedException
        End Function

        Friend Overrides Function GetSqlIdValue(value As Long?) As String
            Return GetSqlLongValue(value)
        End Function

        Friend Overrides Function GetSqlIdValue(value As IdBObject) As String

            If value Is Nothing Then
                Return "null"
            Else
                Return GetSqlIdValue(value.GetId)
            End If

        End Function

        Protected Overrides Function GetSqlStringValue(value As String) As String

            If String.IsNullOrEmpty(value) Then
                Return "null"
            Else
                Return """" & value.Replace("""", "''") & """"
            End If

        End Function

        Protected Overrides Function GetSqlIntegerValue(value As Integer) As String
            Return value.ToString
        End Function

        Protected Overrides Function GetSqlIntegerValue(value As Nullable(Of Integer)) As String

            If value Is Nothing Then
                Return "null"
            ElseIf Not value.HasValue Then
                Return "null"
            Else
                Return GetSqlIntegerValue(value.Value)
            End If

        End Function

        Protected Overrides Function GetSqlLongValue(value As Long) As String
            Return value.ToString
        End Function

        Protected Overrides Function GetSqlLongValue(value As Nullable(Of Long)) As String

            If value Is Nothing Then
                Return "null"
            ElseIf Not value.HasValue Then
                Return "null"
            Else
                Return GetSqlLongValue(value.Value)
            End If

        End Function

        Protected Overrides Function GetSqlSingleValue(value As Single) As String
            Return value.ToString
        End Function

        Protected Overrides Function GetSqlSingleValue(value As Nullable(Of Single)) As String

            If value Is Nothing Then
                Return "null"
            ElseIf Not value.HasValue Then
                Return "null"
            Else
                Return GetSqlSingleValue(value.Value)
            End If

        End Function

        Protected Overrides Function GetSqlDateValue(value As DateTime) As String
            Dim v As DateTime? = value
            Return GetSqlDateValue(v)
        End Function

        ' BO java vers base SQL
        Protected Overrides Function GetSqlDateValue(value As SqlDate) As String

            If value Is Nothing Then
                Return "null"
            Else
                Return GetSqlStringValue(value.GetValue)
            End If

        End Function

        Protected Overrides Function GetSqlDateValue(value As Nullable(Of DateTime)) As String

            If value Is Nothing Then
                Return "null"
            ElseIf Not value.HasValue Then
                Return "null"
            Else
                Return GetSqlDateValue(New SqlDate(value.Value))
            End If

        End Function

        Protected Overrides Function GetSqlBooleanValue(value As Boolean) As String
            Return IIf(value, "1", "0")
        End Function

        Public Overrides Sub InsertOrUpdateRange(boList As List(Of IdBObject))
            m_daoInsertOrUpdate.InsertOrUpdateRange(boList)
        End Sub

        Protected Friend Overrides Function GetLastIdInBase(tableName As String) As ISqlResult
            Return ExecuteQuery("SELECT MAX(Id) FROM " & GetTableName())
        End Function

    End Class

End Namespace