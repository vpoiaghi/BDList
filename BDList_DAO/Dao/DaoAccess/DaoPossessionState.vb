Imports BDList_DAO_BO.BO

Namespace DAO

    Public Class DaoPossessionState
        Inherits DaoNamedBo

        Protected Friend Overrides Function GetBoType() As Type
            Return GetType(PossessionState)
        End Function

        Protected Friend Overrides Function GetTableName() As String
            Return "PossessionState"
        End Function

    End Class

End Namespace