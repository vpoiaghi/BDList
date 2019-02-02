Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.RequestBuilder
Imports BDList_DATABASE
Imports BDList_TOOLS

Namespace DAO

    Public Class DaoOrigin
        Inherits DaoNamedBo

        Protected Friend Overrides Function GetBoType() As Type
            Return GetType(Origin)
        End Function

        Protected Friend Overrides Function GetTableName() As String
            Return "Origin"
        End Function

    End Class

End Namespace