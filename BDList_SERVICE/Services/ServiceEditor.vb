Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.DAO
Imports BDList_TOOLS.IO

Public Class ServiceEditor
    Inherits Service(Of DaoEditor)

    Public Function GetHavingComingEditions() As List(Of IdBObject)

        Return GetDao().GetHavingComingEditions

    End Function

    Public Function GetHavingComingObjects() As List(Of IdBObject)

        Return GetDao().GetHavingComingObjects()

    End Function

    Public Function GetHavingNewEditions(firstDate As Date, lastDate As Date) As List(Of IdBObject)

        Return GetDao().GetHavingNewEditions(firstDate, lastDate)

    End Function

    Public Function GetHavingBought(firstDate As Date, lastDate As Date) As List(Of IdBObject)

        Return GetDao().GetHavingBought(firstDate, lastDate)

    End Function

    Public Overrides Function GetFile(bo As IdBObject, Optional fileIndex As Integer? = 1) As IFile

        Dim fileName As String = Format(CType(bo, Editor).GetId, "00000") & ".png"
        Dim dirPath As String = EDITORS_FOLDER_PATH
        Dim filePath As String = Path.Combine(dirPath, fileName)

        Return Factory.GetFile(filePath)

    End Function

End Class
