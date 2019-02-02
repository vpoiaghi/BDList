Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.DAO
Imports BDList_TOOLS.IO

Public Class ServiceAutograph
    Inherits Service(Of DaoAutograph)

    Public Function GetByEdition(edition As Edition) As List(Of IdBObject)

        Return GetDao().GetByEdition(edition)

    End Function

    Public Function GetByGoody(goody As Goody) As List(Of IdBObject)

        Return GetDao().GetByGoody(goody)

    End Function

    Public Overrides Function GetFile(bo As IdBObject, Optional fileIndex As Integer? = 1) As IFile

        Dim fileName As String = GetFilePattern(CType(bo, Autograph), fileIndex)
        Dim dirPath As String = DirNameGenerator.GetAutographDir(CType(bo, Autograph)).GetFullName
        Dim filePath As String = Path.Combine(dirPath, fileName)

        Return Factory.GetFile(filePath)

    End Function

    Public Function GetFiles(autograph As Autograph) As List(Of IFile)

        Dim result As List(Of IFile) = Nothing

        Dim parentDir As IDirectory = DirNameGenerator.GetAutographDir(autograph)

        If parentDir.IsExists Then
            result = parentDir.GetFiles(GetFilePattern(autograph)).ToList
        Else
            result = New List(Of IFile)
        End If

        Return result

    End Function

    Private Function GetFilePattern(autograph As Autograph, Optional fileIndex As Nullable(Of Integer) = Nothing) As String

        Dim filePattern As String = Format(autograph.GetId, "00000") & "-"

        If fileIndex Is Nothing Then
            filePattern &= "*"
        Else
            filePattern &= Format(fileIndex.Value, "00")
        End If

        Return filePattern & ".jpg"

    End Function

End Class
