Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.DAO
Imports BDList_TOOLS.IO

Public Class ServicePerson
    Inherits Service(Of DaoPerson)

    Public Function GetByNames(lastname As String, firstname As String) As List(Of IdBObject)

        Return GetDao().GetByNames(lastname, firstname)

    End Function

    Public Overrides Function GetFile(bo As IdBObject, Optional fileIndex As Integer? = 1) As IFile

        Dim fileName As String = Format(fileIndex.Value, "0000") & ".jpg"
        Dim dirPath As String = DirNameGenerator.GetPersonsDir(CType(bo, Person).ToString).GetFullName
        Dim filePath As String = Path.Combine(dirPath, fileName)

        Return Factory.GetFile(filepath)

    End Function

End Class
