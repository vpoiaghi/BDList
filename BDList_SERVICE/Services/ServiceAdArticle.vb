Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.DAO

Public Class ServiceAdArticle
    Inherits Service(Of DaoAdArticle)

    Public Function GetByAd(ad As Ad) As List(Of IdBObject)
        Return GetDao.GetByAd(ad)
    End Function

End Class
