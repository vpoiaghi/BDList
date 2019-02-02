Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.RequestBuilder
Imports BDList_DATABASE
Imports BDList_TOOLS

Namespace DAO

    Public Class DaoAutograph
        Inherits DaoAccess

        Protected Friend Overrides Function GetBoType() As Type
            Return GetType(Autograph)
        End Function

        Protected Friend Overrides Function GetTableName() As String
            Return "Autograph"
        End Function

        Protected Friend Overrides Sub InitFieldsList(fieldsNames As FieldList)
            fieldsNames.AddFields("IdAuthor", "Autograph", "Place", "Event", "Comments")
        End Sub

        Protected Friend Overrides Sub BuildBo(sqlResult As ISqlResult, bo As IdBObject)

            With CType(bo, Autograph)

                .SetAutographDate(sqlResult.GetDate("AutographDate"))
                .SetPlace(sqlResult.GetString("Place"))
                .SetEvent(sqlResult.GetString("Event"))
                .SetComments(sqlResult.GetString("Comments"))

                .SetAuthor(GetLinkedBoById(sqlResult, GetType(DaoAuthor), "IdAuthor"))

            End With

        End Sub

        Protected Friend Overrides Sub SetBasicRequestBuilder(ByRef reqBuilder As IBasicRequestBuilder, ByRef bo As IdBObject)

            With CType(bo, Autograph)

                reqBuilder.AddValue("AutographDate", GetSqlDateValue(.GetAutographDate))
                reqBuilder.AddValue("Place", GetSqlStringValue(.GetPlace))
                reqBuilder.AddValue("Event", GetSqlStringValue(.GetEvent))
                reqBuilder.AddValue("Comments", GetSqlStringValue(.GetComments))

                reqBuilder.AddValue("IdAuthor", GetSqlIdValue(.GetAuthor))

            End With

        End Sub

        Public Function GetByEdition(edition As Edition) As List(Of IdBObject)

            Dim autographTableName As String = GetTableName()
            Dim editionAutographTableName As String = GetLinkTableName(Of DaoEdition, DaoAutograph)()

            Dim rqt As String = " SELECT Id" _
                              & " FROM " & autographTableName _
                              & " LEFT JOIN " & editionAutographTableName _
                              & " ON (" & autographTableName & ".Id = " & editionAutographTableName & ".IdAutograph)" _
                              & " WHERE IdEdition = " & edition.GetId _
                              & " ORDER BY AutographDate ASC"

            Return GetByIds(rqt)

        End Function

        Public Function GetByGoody(goody As Goody) As List(Of IdBObject)

            Dim autographTableName As String = GetTableName()
            Dim goodyAutographTableName As String = GetLinkTableName(Of DaoGoody, DaoAutograph)()

            Dim rqt As String = " SELECT Id" _
                              & " FROM " & autographTableName _
                              & " LEFT JOIN " & goodyAutographTableName _
                              & " ON (" & autographTableName & ".Id = " & goodyAutographTableName & ".IdAutograph)" _
                              & " WHERE IdGoody = " & goody.GetId _
                              & " ORDER BY AutographDate ASC"

            Return GetByIds(rqt)

        End Function

        Public Overrides Function InsertOrUpdate(bo As IdBObject) As IdBObject
            Return MyBase.InsertOrUpdate(bo)
        End Function

    End Class

End Namespace