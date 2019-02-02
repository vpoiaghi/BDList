Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.RequestBuilder
Imports BDList_DATABASE
Imports BDList_TOOLS
Imports System.Runtime.CompilerServices

Namespace DAO

    Public Class DaoEditor
        Inherits DaoNamedBo

        Protected Friend Overrides Function GetBoType() As Type
            Return GetType(Editor)
        End Function

        Protected Friend Overrides Function GetTableName() As String
            Return "Editor"
        End Function

        Protected Friend Overrides Sub InitFieldsList(fieldsNames As FieldList)
            fieldsNames.AddFields("Name", "WebSite", "Nationality", "FoundationYear", "CessationYear", "CessationCause", "LegalForm", "Status", "HeadOffice", "Headquarters", "IdManager", "Broadcasting", "ComingBooksWebSite")
        End Sub

        Protected Friend Overrides Sub BuildBo(sqlResult As ISqlResult, bo As IdBObject)

            With CType(bo, Editor)

                .SetName(sqlResult.GetString("Name"))
                .SetWebSite(sqlResult.GetString("WebSite"))
                .SetNationality(sqlResult.GetString("Nationality"))
                .SetFoundationYear(sqlResult.GetInteger("FoundationYear"))
                .SetCessationYear(sqlResult.GetInteger("CessationYear"))
                .SetCessationCause(sqlResult.GetString("CessationCause"))
                .SetLegalForm(sqlResult.GetString("LegalForm"))
                .SetStatus(sqlResult.GetString("Status"))
                .SetHeadOffice(sqlResult.GetString("HeadOffice"))
                .SetHeadQuarters(sqlResult.GetString("Headquarters"))
                .SetComingWebSite(sqlResult.GetString("ComingBooksWebSite"))

                .SetManager(GetLinkedBoById(sqlResult, GetType(DaoPerson), "IdManager"))

            End With

        End Sub

        Protected Friend Overrides Sub SetBasicRequestBuilder(ByRef reqBuilder As IBasicRequestBuilder, ByRef editor As IdBObject)

            With CType(editor, Editor)
                reqBuilder.AddValue("IdManager", GetSqlIdValue(.GetManager))

                reqBuilder.AddValue("Name", GetSqlStringValue(.GetName))
                reqBuilder.AddValue("WebSite", GetSqlStringValue(.GetWebSite))
                reqBuilder.AddValue("Nationality", GetSqlStringValue(.GetNationality))
                reqBuilder.AddValue("FoundationYear", GetSqlIntegerValue(.GetFoundationYear))
                reqBuilder.AddValue("CessationYear", GetSqlIntegerValue(.GetCessationYear))
                reqBuilder.AddValue("CessationCause", GetSqlStringValue(.GetCessationCause))
                reqBuilder.AddValue("LegalForm", GetSqlStringValue(.GetLegalForm))
                reqBuilder.AddValue("Status", GetSqlStringValue(.GetStatus))
                reqBuilder.AddValue("HeadOffice", GetSqlStringValue(.GetHeadOffice))
                reqBuilder.AddValue("Headquarters", GetSqlStringValue(.GetHeadQuarters))
                reqBuilder.AddValue("Broadcasting", GetSqlStringValue(.GetBroadcasting))
                reqBuilder.AddValue("ComingBooksWebSite", GetSqlStringValue(.GetComingWebSite))

            End With

        End Sub

        Public Function GetHavingComingEditions() As List(Of IdBObject)

            Dim rqt As String = " SELECT Editor.Id AS Id" _
                              & " FROM Editor" _
                              & " LEFT JOIN Edition ON (Editor.Id = Edition.IdEditor)" _
                              & " WHERE ParutionDate > " & GetSqlDateValue(Today) _
                              & " ORDER BY Editor.Name ASC"

            Return GetByIds(rqt)

        End Function

        Public Function GetHavingComingObjects() As List(Of IdBObject)

            Dim strToday As String = GetSqlDateValue(Today)

            Dim rqt As String _
                = " SELECT Id FROM" _
                & " (SELECT DISTINCT Id, Name FROM" _
                & " (SELECT Editor.Id AS Id, Editor.Name AS Name" _
                & " FROM Editor" _
                & " LEFT JOIN Edition ON (Editor.Id = Edition.IdEditor)" _
                & " WHERE ParutionDate > " & strToday & ")" _
                & " UNION" _
                & " (SELECT Editor.Id AS Id, Editor.Name AS Name" _
                & " FROM (Editor" _
                & " LEFT JOIN Goody_Editor ON (Editor.Id = Goody_Editor.IdEditor))" _
                & " LEFT JOIN Goody ON (Goody.Id = Goody_Editor.IdGoody)" _
                & " WHERE ParutionDate > " & strToday & ")" _
                & " ORDER BY Name ASC)"

            Return GetByIds(rqt)

        End Function

        '**
        '* Retourne la liste des éditeurs pour lesquels au moins une édition
        '* référencée est parue durant la période passée en paramètre.
        '**
        Public Function GetHavingNewEditions(firstDate As Date, lastDate As Date) As List(Of IdBObject)

            Dim rqt As String = " SELECT Editor.Id AS Id" _
                              & " FROM Editor" _
                              & " LEFT JOIN Edition ON (Editor.Id = Edition.IdEditor)" _
                              & " WHERE ParutionDate > " & GetSqlDateValue(firstDate) _
                              & " AND ParutionDate <= " & GetSqlDateValue(lastDate) _
                              & " ORDER BY Editor.Name ASC"

            Return GetByIds(rqt)

        End Function

        '**
        '* Retourne la liste des éditeurs pour lesquels au moins une édition a
        '* été obtenue durant la période passée en paramètre.
        '**
        Public Function GetHavingBought(firstDate As Date, lastDate As Date) As List(Of IdBObject)

            Dim rqt As String = " SELECT Editor.Id AS Id" _
                              & " FROM Editor" _
                              & " LEFT JOIN Edition ON (Editor.Id = Edition.IdEditor)" _
                              & " WHERE BoughtDate > " & GetSqlDateValue(firstDate) _
                              & " AND BoughtDate <= " & GetSqlDateValue(lastDate) _
                              & " ORDER BY Editor.Name ASC"

            Return GetByIds(rqt)

        End Function

        Public Function GetByGoody(goody As Goody) As List(Of IdBObject)

            Dim rqt As String _
                = " SELECT Editor.Id AS Id" _
                & " FROM Editor" _
                & " LEFT JOIN Goody_Editor ON (Editor.Id = Goody_Editor.IdEditor)" _
                & " WHERE Goody_Editor.IdGoody = " & goody.GetId.Value _
                & " ORDER BY Editor.Name ASC"

            Return GetByIds(rqt)

        End Function

    End Class

End Namespace