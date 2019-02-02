Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.DAO
Imports BDList_TOOLS.IO

Public Class ServicePhoneAutograph
    Inherits Service(Of DaoPhoneAutograph)

    Public Overrides Function GetFile(bo As IdBObject, Optional fileIndex As Integer? = 1) As IFile

        Dim fileName As String = Format(bo.GetId, "00000") & "-" & Format(fileIndex, "00") & ".jpg"

        Return Factory.GetFile(Path.Combine(PHONE_AUTOGRAPHS_FOLDER, fileName))

    End Function

End Class
