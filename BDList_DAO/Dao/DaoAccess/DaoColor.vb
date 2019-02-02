Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.RequestBuilder
Imports BDList_DATABASE
Imports BDList_TOOLS

Namespace DAO

    Public Class DaoColor
        Inherits DaoNamedBo

        Protected Friend Overrides Function GetBoType() As Type
            Return GetType(EditionColor)
        End Function

        Protected Friend Overrides Function GetTableName() As String
            Return "Color"
        End Function

        Public Function GetByEdition(editionId As Long?) As List(Of IdBObject)

            Dim rqt As String = " SELECT IdColor AS Id" _
                              & " FROM Edition_Color" _
                              & " LEFT JOIN Color ON (Color.Id = Edition_Color.IdColor)" _
                              & " WHERE Edition_Color.IdEdition = " & editionId _
                              & " ORDER BY Color.Name ASC"

            Return GetByIds(rqt)

        End Function

    End Class

End Namespace