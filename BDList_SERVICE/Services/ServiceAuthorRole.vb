Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.DAO
Imports BDList_TOOLS

Public Class ServiceAuthorRole
    Inherits Service(Of DaoAuthorRole)

    Public Function GetByAuthorAndRole(idAuthor As Long?, idRole As Long?) As List(Of IdBObject)

        Return GetDao().GetByAuthorAndRole(idAuthor, idRole)

    End Function

End Class
