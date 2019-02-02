Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.DAO

Public Class ServiceInSigning
    Inherits Service(Of DaoInSigning)

    Public Function GetByFestival(festval As Festival) As List(Of IdBObject)
        Return GetDao().GetByFestival(festval)
    End Function

End Class
