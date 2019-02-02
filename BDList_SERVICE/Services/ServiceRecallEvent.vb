Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.DAO
Imports BDList_TOOLS.IO

Public Class ServiceRecallEvent
    Inherits Service(Of DaoRecallEvent)

    Public Overrides Function GetFile(bo As IdBObject, Optional fileIndex As Integer? = 1) As IFile

        Dim fileName As String = Format(bo.GetId, "000000") & ".jpg"
        Dim dirPath As String = DirNameGenerator.GetEventsDir(CType(bo, RecallEvent)).GetFullName
        Dim filePath As String = Path.Combine(dirPath, fileName)

        Return Factory.GetFile(filePath)

    End Function

    Public Function GetFiles(recallEvent As RecallEvent) As List(Of IFile)

        Dim result As List(Of IFile)

        Dim parentDir As IDirectory = DirNameGenerator.GetEventsDir(recallEvent)
        Dim filePattern As String = GetFileName(recallEvent)

        If parentDir.IsExists Then
            result = parentDir.GetFiles(filePattern).ToList
        Else
            result = New List(Of IFile)
        End If

        Return result

    End Function

End Class
