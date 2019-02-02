Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.DAO

Public Class ServiceCollection
    Inherits Service(Of DaoCollection)

    Public Function GetByEditor(editor As Editor) As List(Of IdBObject)
        Return GetDao.GetByEditor(editor)
    End Function

End Class
