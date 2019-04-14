Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.DAO

Public Class ServiceAdState
    Inherits Service(Of DaoAdState)

    Public Function GetWinStates() As List(Of IdBObject)
        Return GetDao().GetWinStates()
    End Function

    Public Function GetLostStates() As List(Of IdBObject)
        Return GetDao().GetLostStates()
    End Function

End Class
