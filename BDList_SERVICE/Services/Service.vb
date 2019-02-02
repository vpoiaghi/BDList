Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO
Imports BDList_DAO_BO.DAO
Imports BDList_TOOLS.IO

Public MustInherit Class Service(Of DaoType As IDaoBObject)
    Implements IService

    Protected Function GetDao() As DaoType
        Return DaoManager.GetDao(Of DaoType)()
    End Function

    Public Sub CleanCash() Implements IService.CleanCash
        GetDao().CleanCash()
    End Sub

    Public Function GetNew() As IdBObject Implements IService.GetNew
        Return GetDao().GetNew()
    End Function

    Public Function GetNew(id As Long?) As IdBObject Implements IService.GetNew
        Return GetDao().GetNew(id)
    End Function

    Public Function GetById(id As Long?) As IdBObject Implements IService.GetById
        Return GetDao().GetById(id)
    End Function

    Public Overridable Function GetAll() As List(Of IdBObject) Implements IService.GetAll
        Return GetDao().GetAll()
    End Function

    Public Overridable Function GetAllSortedById() As List(Of IdBObject) Implements IService.GetAllSortedById
        Return GetDao().GetAllSortedById()
    End Function

    ' Retourne le nombre total d'item en base dans la table ciblée par le dao lié
    Public Overridable Function GetCount() As Integer Implements IService.GetCount
        Return GetDao().GetCount
    End Function

    Public Overridable Sub Delete(bo As IdBObject) Implements IService.Delete
        GetDao().Delete(bo)
    End Sub

    Public Overridable Sub Delete(boList As List(Of IdBObject)) Implements IService.Delete
        GetDao().Delete(boList)
    End Sub

    Public Overridable Sub DeleteAll() Implements IService.DeleteAll
        GetDao().DeleteAll()
    End Sub

    Public Function GetChanged(fromDate As DateTime) As List(Of IdBObject) Implements IService.GetChanged
        Return GetDao().GetChanged(fromDate)
    End Function

    Public Overridable Sub InsertOrUpdate(bo As IdBObject) Implements IService.InsertOrUpdate

        Dim isNewBo As Boolean = (bo.IsInBase = False)
        Dim oldBo As IdBObject = GetDao().InsertOrUpdate(bo)

        If isNewBo Then
            BoAdded(bo)
        Else
            BoUpdated(oldBo, bo)
        End If

    End Sub

    Public Sub InsertOrUpdateRange(boList As List(Of IdBObject)) Implements IService.InsertOrUpdateRange
        GetDao().InsertOrUpdateRange(boList)
    End Sub


    Protected Overridable Sub BoAdded(bo As IdBObject)
    End Sub

    Protected Overridable Sub BoUpdated(oldBo As IdBObject, newBo As IdBObject)
    End Sub

    Public Overridable Function GetFile(bo As IdBObject, Optional fileIndex As Integer? = 1) As IFile Implements IService.GetFile
        Return Nothing
    End Function

    Public Function GetFileName(bo As IdBObject, Optional fileIndex As Integer? = 1) As String Implements IService.GetFileName

        Dim result As String
        Dim file As IFile = GetFile(bo, fileIndex)

        If file Is Nothing Then
            result = Nothing
        Else
            result = file.GetName
        End If

        Return result

    End Function

    Public Overridable Function GetFilePath(bo As IdBObject, Optional fileIndex As Integer? = 1) As String Implements IService.GetFilePath

        Dim result As String
        Dim file As IFile = GetFile(bo, fileIndex)

        If file Is Nothing Then
            result = Nothing
        Else
            result = file.GetFullName
        End If

        Return result

    End Function

    Function GetFileParentDirPath(bo As IdBObject, Optional fileIndex As Integer? = 1) As String Implements IService.GetFileParentDirPath

        Dim result As String
        Dim file As IFile = GetFile(bo, fileIndex)

        If file Is Nothing Then
            result = Nothing
        Else
            result = file.GetDirectory.GetFullName
        End If

        Return result

    End Function

End Class
