Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.RequestBuilder
Imports BDList_DATABASE
Imports BDList_TOOLS

Namespace DAO

    Public Class DaoFormat
        Inherits DaoNamedBo

        Protected Friend Overrides Function GetBoType() As Type
            Return GetType(EditionFormat)
        End Function

        Protected Friend Overrides Function GetTableName() As String
            Return "Format"
        End Function

        Public Function GetByEdition(editionId As Long?) As List(Of IdBObject)

            Dim rqt As String = " SELECT IdFormat AS Id" _
                              & " FROM Edition_Format" _
                              & " LEFT JOIN Format ON (Format.Id = Edition_Format.IdFormat)" _
                              & " WHERE Edition_Format.IdEdition = " & editionId _
                              & " ORDER By Format.Name ASC"

            Return GetByIds(rqt)

        End Function

    End Class

End Namespace