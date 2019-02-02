Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.DAO
Imports BDList_TOOLS

Public Class ServiceSocietyRole
    Inherits Service(Of DaoSocietyRole)

    Public Function GetBySocietyAndRole(idSociety As Long?, idRole As Long?) As List(Of IdBObject)

        Return GetDao().GetBySocietyAndRole(idSociety, idRole)

    End Function

End Class
