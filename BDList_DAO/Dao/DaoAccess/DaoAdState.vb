Imports BDList_DAO_BO.BO

Namespace DAO

    Public Class DaoAdState
        Inherits DaoNamedBo

        Protected Friend Overrides Function GetBoType() As Type
            Return GetType(AdState)
        End Function

        Protected Friend Overrides Function GetTableName() As String
            Return "AdState"
        End Function

    End Class

End Namespace