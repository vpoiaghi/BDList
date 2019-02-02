Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.RequestBuilder
Imports BDList_DATABASE
Imports BDList_TOOLS.Types.Sql

Namespace DAO

    Public MustInherit Class DaoBObject
        Inherits Dao
        Implements IDaoBObject

        ' Liste des dao liés
        Private m_linkedDaoList As LinkedDaoList

        ' Plus grand Id technique dans la table
        Protected m_lastId As Long = -1


        ' Nom des colonnes de la table
        Protected m_fieldsNames As FieldList = Nothing

        Public MustOverride Function GetById(id As Long?) As IdBObject Implements IDaoBObject.GetById
        Friend MustOverride Function GetByIds(idsList As List(Of Long?)) As List(Of IdBObject)
        Public MustOverride Function GetAll() As List(Of IdBObject) Implements IDaoBObject.GetAll
        Public MustOverride Function GetAllSortedById() As List(Of IdBObject) Implements IDaoBObject.GetAllSortedById
        Public MustOverride Function GetChanged(lastSyncDate As DateTime) As List(Of IdBObject) Implements IDaoBObject.GetChanged
        Public MustOverride Function GetCount() As Integer Implements IDaoBObject.GetCount

        Protected Friend MustOverride Function GetBasicRequestBuilder() As IBasicRequestBuilder
        Protected Friend MustOverride Sub SetBasicRequestBuilder(ByRef reqBuilder As IBasicRequestBuilder, ByRef bo As IdBObject)

        Friend MustOverride Function GetLinkedBoInBase(newBo As IdBObject, dao As DaoBObject) As List(Of IdBObject)
        Friend MustOverride Sub DeleteLinkedItems(ByRef newBo As IdBObject, ByRef oldlinkedBoList As List(Of IdBObject), dao As DaoBObject)

        Protected Friend MustOverride Sub InitFieldsList(fieldsNames As FieldList)
        Protected Friend MustOverride Function GetIdFieldName() As String
        Protected Friend MustOverride Function GetModifiedDateTimeFieldName() As String

        Protected Friend MustOverride Function GetLastIdInBase(tableName As String) As ISqlResult
        Protected Friend MustOverride Sub BuildBo(sqlResult As ISqlResult, bo As IdBObject)

        Friend MustOverride Function GetInBaseById(id As Long?) As List(Of IdBObject)

        Friend MustOverride Sub Insert(tableName As String, values As List(Of String))

        Public MustOverride Sub DeleteLinks(linkedTableName As String, id As Long?)

        Friend MustOverride Overloads Function GetSqlIdValue(bo As IdBObject) As String
        Protected MustOverride Function GetSqlStringValue(value As String) As String
        Protected MustOverride Function GetSqlIntegerValue(value As Integer) As String
        Protected MustOverride Function GetSqlIntegerValue(value As Nullable(Of Integer)) As String
        Protected MustOverride Function GetSqlLongValue(value As Long) As String
        Protected MustOverride Function GetSqlLongValue(value As Nullable(Of Long)) As String
        Protected MustOverride Function GetSqlSingleValue(value As Single) As String
        Protected MustOverride Function GetSqlSingleValue(value As Nullable(Of Single)) As String
        Protected MustOverride Function GetSqlBooleanValue(value As Boolean) As String
        Protected MustOverride Function GetSqlDateValue(value As DateTime) As String
        Protected MustOverride Function GetSqlDateValue(value As SqlDate) As String
        Protected MustOverride Function GetSqlDateValue(value As Nullable(Of DateTime)) As String

        Protected Friend MustOverride Sub InitBasicRequestBuilder(ByRef reqBuilder As IBasicRequestBuilder, ByRef bo As IdBObject)


        Protected Friend Sub New()
            MyBase.New()

            m_linkedDaoList = New LinkedDaoList
            InitLinkedDaoList()

        End Sub

        Friend Function GetDao(Of DaoType As {IDao})() As DaoType
            Return DaoManager.GetDao(Of DaoType)()
        End Function

        Protected Friend Function GetDao(daoType As Type) As IDao
            Return DaoManager.GetDao(daoType)
        End Function

        Public Function GetFieldsEnumerator() As IEnumerator
            Return GetFields().GetEnumerator
        End Function

        Public Function GetFieldName(index As Integer) As String
            Return GetFields()(index)
        End Function

        Public Function GetFieldsCount() As Integer
            Return GetFields().Count()
        End Function

        Friend Function GetFields() As FieldList

            If m_fieldsNames Is Nothing Then
                m_fieldsNames = New FieldList
                m_fieldsNames.AddFields(GetIdFieldName())
                m_fieldsNames.AddFields(GetModifiedDateTimeFieldName())
                InitFieldsList(m_fieldsNames)
            End If

            Return m_fieldsNames

        End Function

        Protected Friend Overridable Sub InitLinkedDaoList()
        End Sub

        Friend Function GetLinkedDaoList() As LinkedDaoList
            Return m_linkedDaoList
        End Function

        Protected Friend Sub AddVeryLinkedDao(dao As IDao)

            m_linkedDaoList.Add(LinkedDaoList.LinkedModes.MultiVeryLinked, dao)

        End Sub

        Protected Friend Sub AddNotVeryLinkedDao(dao As IDao)

            m_linkedDaoList.Add(LinkedDaoList.LinkedModes.MultiNotVeryLinked, dao)

        End Sub

        Protected Friend Function SqlResultToBo(sqlResult As ISqlResult) As IdBObject

            Dim bo As IdBObject = Nothing

            Dim id As Long? = sqlResult.GetLong(GetIdFieldName)

            If id IsNot Nothing Then

                Dim tsp As DateTime? = sqlResult.GetDate(GetModifiedDateTimeFieldName)

                bo = GetEmpty()

                bo.SetId(id)
                bo.SetInBase(True)

                If tsp IsNot Nothing Then
                    bo.SetModifiedDateTime(tsp)
                End If

                BuildBo(sqlResult, bo)

            End If

            Return bo

        End Function

        Private Function GetEmpty() As IdBObject

            Dim boType As Type = GetBoType()
            Dim newBo As IdBObject = boType.GetConstructor(Type.EmptyTypes).Invoke(Nothing)

            newBo.SetInBase(False)

            Return newBo

        End Function

        Public Function GetNew() As IdBObject Implements IDaoBObject.GetNew
            Return GetNewBo(GetNextId())
        End Function

        Public Function GetNew(id As Long) As IdBObject Implements IDaoBObject.GetNew

            If (id <= m_lastId) AndAlso (GetById(id) IsNot Nothing) Then
                Throw New Exception("Unique constraints exception.")
            Else
                Return GetNewBo(id)
            End If

        End Function

        Private Function GetNewBo(id As Long) As IdBObject

            Dim newBo As IdBObject = GetEmpty()

            newBo.SetId(id)
            newBo.SetInBase(False)

            Return newBo

        End Function

        Public Function GetNextId() As Long

            If m_lastId = -1 Then
                m_lastId = GetLastIdInBase()
            End If

            m_lastId += 1

            Return m_lastId

        End Function

        Private Function GetLastIdInBase() As Long

            Dim lastId As Long = 0

            Dim sqlResult As ISqlResult = GetLastIdInBase(GetTableName())

            If sqlResult.MoveNext Then
                With sqlResult.GetInteger(0)
                    If .HasValue Then
                        lastId = .Value
                    End If
                End With
            End If

            Return lastId

        End Function

        Friend Function GetInCashById(id As Long?) As IdBObject

            Dim e As List(Of BObject).Enumerator = m_cashBoList.GetEnumerator
            Dim b As IdBObject = Nothing
            Dim found As Boolean = False

            While e.MoveNext And Not found

                b = CType(e.Current, IdBObject)
                found = (b.GetId = id)

            End While

            Return IIf(found, b, Nothing)

        End Function

        Friend Sub DeleteFromCash(bo As IdBObject)

            Dim newLastId As Long = m_lastId

            If bo.GetId = m_lastId Then
                newLastId = GetLastIdInBase()
            End If

            GetCashBoList.Remove(bo)

            m_lastId = newLastId

        End Sub

        Public Overrides Sub DeleteAll()

            DeleteAllInBase()
            GetCashBoList.Clear()
            m_lastId = -1

        End Sub

        Protected Friend Class FieldList
            Inherits List(Of String)

            Public Sub AddFields(ParamArray fieldsNames As String())

                For Each fieldName As String In fieldsNames
                    Me.Add(fieldName)
                Next

            End Sub

        End Class

    End Class

End Namespace