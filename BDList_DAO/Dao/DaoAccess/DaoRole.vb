Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.RequestBuilder
Imports BDList_DATABASE
Imports BDList_TOOLS

Namespace DAO

    Public Class DaoRole
        Inherits DaoNamedBo

        Protected Friend Overrides Function GetBoType() As Type
            Return GetType(Role)
        End Function

        Protected Friend Overrides Function GetTableName() As String
            Return "Role"
        End Function

    End Class

End Namespace