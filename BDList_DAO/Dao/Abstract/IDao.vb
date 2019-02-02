Imports BDList_DAO_BO.BO
Imports BDList_TOOLS

Namespace DAO

    Public Interface IDao

        Function InsertOrUpdate(bo As IdBObject) As IdBObject
        Sub InsertOrUpdateRange(boList As List(Of IdBObject))

        'Sub Delete(ParamArray boArray() As IdBObject)
        Sub Delete(bo As IdBObject)
        Sub Delete(boList As List(Of IdBObject))
        Sub DeleteAll()

        Sub CleanCash()

    End Interface

End Namespace