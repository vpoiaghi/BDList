Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.DAO

Public Class ServiceRole
    Inherits Service(Of DaoRole)

    Public Function GetByName(name As String) As List(Of IdBObject)

        Return GetDao().GetByName(name)

    End Function

End Class
