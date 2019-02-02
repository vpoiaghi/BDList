Imports BDList_DAO_BO.BO
Imports BDList_DATABASE

Namespace DAO

    Public MustInherit Class Dao
        Implements IDao

        ' Bo en mémoire cache pour le Dao courant
        Protected m_cashBoList As New List(Of BObject)

        Protected Friend MustOverride Function GetConnectionType() As ConnectionTypes
        Protected Friend MustOverride Function GetTableName() As String
        Protected Friend MustOverride Function GetBoType() As Type

        Public MustOverride Function InsertOrUpdate(bo As IdBObject) As IdBObject Implements IDao.InsertOrUpdate
        Public MustOverride Sub InsertOrUpdateRange(boList As List(Of IdBObject)) Implements IDao.InsertOrUpdateRange

        'Public MustOverride Sub Delete(ParamArray boArray() As IdBObject) Implements IDao.Delete
        Public MustOverride Sub Delete(bo As IdBObject) Implements IDao.Delete
        Public MustOverride Sub Delete(boList As List(Of IdBObject)) Implements IDao.Delete
        Public MustOverride Sub DeleteAll() Implements IDao.DeleteAll
        Protected MustOverride Sub DeleteAllInBase()

        Friend MustOverride Function GetSqlIdValue(id As Long?) As String

        Friend Function ExecuteQuery(query As String) As ISqlResult
            Return ConnectionPool.ExecuteQuery(GetConnectionType(), query)
        End Function

        Friend Sub ExecuteNonQuery(query As String)
            ConnectionPool.ExecuteNonQuery(GetConnectionType(), query)
        End Sub

        Friend Function GetCashBoList() As List(Of BObject)
            Return m_cashBoList
        End Function

        Public Sub CleanCash() Implements IDao.CleanCash
            m_cashBoList.Clear()
        End Sub

    End Class

End Namespace