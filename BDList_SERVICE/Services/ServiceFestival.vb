Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.DAO
Imports BDList_TOOLS.IO

Public Class ServiceFestival
    Inherits Service(Of DaoFestival)

    Public Overrides Function GetFile(bo As IdBObject, Optional fileIndex As Integer? = 1) As IFile

        Dim fileName As String = Format(CType(bo, Editor).GetId, "00000") & ".png"
        Dim dirPath As String = FESTIVALS_FOLDER_PATH
        Dim filePath As String = Path.Combine(dirPath, fileName)

        Return Factory.GetFile(filePath)

    End Function


End Class
