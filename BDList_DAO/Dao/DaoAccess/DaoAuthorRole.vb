Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.RequestBuilder
Imports BDList_DATABASE
Imports BDList_TOOLS

Namespace DAO

    Public Class DaoAuthorRole
        Inherits DaoAccess

        Protected Friend Overrides Function GetBoType() As Type
            Return GetType(AuthorRole)
        End Function

        Protected Friend Overrides Function GetTableName() As String
            Return "AuthorRole"
        End Function

        Protected Friend Overrides Sub InitFieldsList(fieldsNames As FieldList)
            fieldsNames.AddFields("IdAuthor", "IdRole")
        End Sub

        Protected Friend Overrides Sub BuildBo(sqlResult As ISqlResult, bo As IdBObject)

            With CType(bo, AuthorRole)
                .SetAuthor(GetLinkedBoById(sqlResult, GetType(DaoAuthor), "IdAuthor"))
                .SetRole(GetLinkedBoById(sqlResult, GetType(DaoRole), "IdRole"))
            End With

        End Sub

        Protected Friend Overrides Sub SetBasicRequestBuilder(ByRef reqBuilder As IBasicRequestBuilder, ByRef bo As IdBObject)

            With CType(bo, AuthorRole)
                reqBuilder.AddValue("IdAuthor", GetSqlIdValue(.GetAuthor))
                reqBuilder.AddValue("IdRole", GetSqlIdValue(.GetRole))
            End With

        End Sub

        Public Function GetByAuthorAndRole(idAuthor As Long?, idRole As Long?) As List(Of IdBObject)

            Dim rqt As String = " SELECT Id" _
                              & " FROM " & GetTableName() _
                              & " WHERE IdAuthor = " & idAuthor _
                              & " AND IdRole = " & idRole

            Return GetByIds(rqt)

        End Function

        Public Function GetByEdition(idEdition As Long?) As List(Of IdBObject)

            Dim rqt As String = " SELECT Id" & GetTableName() _
                              & " FROM Edition_AuthorRole" _
                              & " WHERE Edition_AuthorRole.IdEdition = " & idEdition

            Return GetByIds(rqt)

        End Function

    End Class

End Namespace