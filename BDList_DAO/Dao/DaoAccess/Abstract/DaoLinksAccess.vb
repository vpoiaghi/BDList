Imports BDList_DATABASE

Namespace DAO

    Friend Class DaoLinksAccess
        Inherits DaoLinks

        Public Sub New(dao1 As DaoBObject, dao2 As DaoBObject)
            MyBase.New(dao1, dao2)
        End Sub

        Protected Friend Overrides Function GetConnectionType() As ConnectionTypes
            Return ConnectionTypes.Access
        End Function

        Protected Overrides Function GetRequestDeleteAll() As String
            Return "DELETE FROM " & GetTableName()
        End Function

        Protected Overrides Function GetRequestSelectAll() As String
            Return "SELECT * FROM " & GetTableName()
        End Function


    End Class

End Namespace