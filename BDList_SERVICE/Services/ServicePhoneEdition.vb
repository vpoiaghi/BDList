Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.DAO
Imports BDList_TOOLS.IO

Public Class ServicePhoneEdition
    Inherits Service(Of DaoPhoneEdition)

    Public Overrides Function GetFile(bo As IdBObject, Optional fileIndex As Integer? = 1) As IFile

        Dim fileName As String = Format(bo.GetId, "000000") & ".jpg"

        Return Factory.GetFile(Path.Combine(PHONE_COVERS_FOLDER, fileName))

    End Function

End Class
