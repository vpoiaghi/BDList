Imports BDList_DAO_BO.BO

Namespace DAO

    Public Class DaoPurchaseState
        Inherits DaoNamedBo

        Protected Friend Overrides Function GetBoType() As Type
            Return GetType(PurchaseState)
        End Function

        Protected Friend Overrides Function GetTableName() As String
            Return "PurchaseState"
        End Function

        Public Overrides Function GetAll() As List(Of IdBObject)

            Dim rqt As String = " SELECT Id" _
                              & " FROM " & GetTableName() _
                              & " ORDER BY Id ASC"

            Return GetByIds(rqt)

        End Function

    End Class

End Namespace