Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.RequestBuilder
Imports BDList_DATABASE

Namespace DAO

    Public Class DaoFestivalReminder
        Inherits DaoNamedBo

        Protected Friend Overrides Function GetBoType() As Type
            Return GetType(FestivalReminder)
        End Function

        Protected Friend Overrides Function GetTableName() As String
            Return "FestivalReminder"
        End Function

        Protected Friend Overrides Sub InitFieldsList(fieldsNames As FieldList)
            fieldsNames.AddFields("IdFestival", "IdEditor", "Name", "Kind", "Comments")
        End Sub

        Protected Friend Overrides Sub BuildBo(sqlResult As ISqlResult, bo As IdBObject)

            With CType(bo, FestivalReminder)

                .SetName(sqlResult.GetString("Name"))
                .SetKind(sqlResult.GetInteger("Kind"))
                .SetComments(sqlResult.GetString("Comments"))

                .SetFestival(GetLinkedBoById(sqlResult, GetType(DaoFestival), "IdFestival"))
                .SetEditor(GetLinkedBoById(sqlResult, GetType(DaoEditor), "IdEditor"))

            End With

        End Sub

        Protected Friend Overrides Sub SetBasicRequestBuilder(ByRef reqBuilder As IBasicRequestBuilder, ByRef festivalReminder As IdBObject)

            With CType(festivalReminder, FestivalReminder)
                reqBuilder.AddValue("IdFestival", GetSqlIdValue(.GetFestival))
                reqBuilder.AddValue("IdEditor", GetSqlIdValue(.GetEditor))
                reqBuilder.AddValue("Name", GetSqlStringValue(.GetName))
                reqBuilder.AddValue("Kind", GetSqlIntegerValue(.GetKind))
                reqBuilder.AddValue("Comments", GetSqlStringValue(.GetComments))
            End With

        End Sub


    End Class

End Namespace