Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.RequestBuilder
Imports BDList_DATABASE

Namespace DAO

    Public Class DaoInSigning
        Inherits DaoAccess

        Protected Friend Overrides Function GetBoType() As Type
            Return GetType(InSigning)
        End Function

        Protected Friend Overrides Function GetTableName() As String
            Return "InSigning"
        End Function

        Protected Friend Overrides Sub InitFieldsList(fieldsNames As FieldList)
            fieldsNames.AddFields("IdFestival", "IdEditor", "IdAuthor", "Day", "StartTime", "EndTime", "Comments")
        End Sub

        Protected Friend Overrides Sub InitLinkedDaoList()

            AddNotVeryLinkedDao(GetDao(Of DaoEdition))

        End Sub

        Protected Friend Overrides Sub BuildBo(sqlResult As ISqlResult, bo As IdBObject)

            With CType(bo, InSigning)

                .SetDay(sqlResult.GetDate("Day"))
                .SetStartTime(sqlResult.GetDate("StartTime"))
                .SetEndTime(sqlResult.GetDate("EndTime"))
                .SetComments(sqlResult.GetString("Comments"))

                .SetFestival(GetLinkedBoById(sqlResult, GetType(DaoFestival), "IdFestival"))
                .SetEditor(GetLinkedBoById(sqlResult, GetType(DaoEditor), "IdEditor"))
                .SetAuthor(GetLinkedBoById(sqlResult, GetType(DaoAuthor), "IdAuthor"))

            End With

        End Sub

        Protected Friend Overrides Sub SetBasicRequestBuilder(ByRef reqBuilder As IBasicRequestBuilder, ByRef inSigning As IdBObject)

            With CType(inSigning, InSigning)
                reqBuilder.AddValue("IdFestival", GetSqlIdValue(.GetFestival))
                reqBuilder.AddValue("IdEditor", GetSqlIdValue(.GetEditor))
                reqBuilder.AddValue("IdAuthor", GetSqlIdValue(.GetAuthor))
                reqBuilder.AddValue("Day", GetSqlDateValue(.GetDay))
                reqBuilder.AddValue("StartTime", GetSqlDateValue(.GetStartTime))
                reqBuilder.AddValue("EndTime", GetSqlDateValue(.GetEndTime))
                reqBuilder.AddValue("Comments", GetSqlStringValue(.GetComments))
            End With

        End Sub

        Public Function GetByFestival(festival As Festival) As List(Of IdBObject)

            Dim rqt As String _
                = " SELECT Id" _
                & " FROM " & GetTableName() _
                & " WHERE IdFestival = " & festival.GetId().Value _
                & " ORDER BY Day ASC, StartTime ASC"

            Return GetByIds(rqt)

        End Function

    End Class

End Namespace