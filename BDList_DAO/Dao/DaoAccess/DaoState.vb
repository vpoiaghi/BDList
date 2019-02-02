Imports BDList_DAO_BO.BO

Namespace DAO

    Public Class DaoState
        Inherits DaoNamedBo

        Protected Friend Overrides Function GetBoType() As Type
            Return GetType(State)
        End Function

        Protected Friend Overrides Function GetTableName() As String
            Return "State"
        End Function

    End Class

End Namespace