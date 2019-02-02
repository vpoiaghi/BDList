Imports BDList_DAO_BO.BO
Imports BDList_TOOLS.IO

Public Interface IService

    Function GetNew() As IdBObject
    Function GetNew(id As Long?) As IdBObject

    Function GetById(id As Long?) As IdBObject
    Function GetAll() As List(Of IdBObject)
    Function GetAllSortedById() As List(Of IdBObject)
    Function GetChanged(fromDate As DateTime) As List(Of IdBObject)
    Function GetCount() As Integer

    Sub InsertOrUpdate(bo As IdBObject)
    Sub InsertOrUpdateRange(boList As List(Of IdBObject))

    Function GetFile(bo As IdBObject, Optional fileIndex As Integer? = 1) As IFile
    Function GetFileName(bo As IdBObject, Optional fileIndex As Integer? = 1) As String
    Function GetFilePath(bo As IdBObject, Optional fileIndex As Integer? = 1) As String
    Function GetFileParentDirPath(bo As IdBObject, Optional fileIndex As Integer? = 1) As String

    Sub Delete(bo As IdBObject)
    Sub Delete(boList As List(Of IdBObject))
    Sub DeleteAll()

    Sub CleanCash()

End Interface
