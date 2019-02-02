Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.RequestBuilder
Imports BDList_DATABASE
Imports BDList_TOOLS

Namespace DAO

    Public Class DaoSocietyRole
        Inherits DaoAccess

        Protected Friend Overrides Function GetBoType() As Type
            Return GetType(SocietyRole)
        End Function

        Protected Friend Overrides Function GetTableName() As String
            Return "SocietyRole"
        End Function

        Protected Friend Overrides Sub InitFieldsList(fieldsNames As FieldList)
            fieldsNames.AddFields("IdSociety", "IdRole")
        End Sub

        Protected Friend Overrides Sub BuildBo(sqlResult As ISqlResult, bo As IdBObject)

            With CType(bo, SocietyRole)

                .SetSociety(GetLinkedBoById(sqlResult, GetType(DaoSociety), "IdSociety"))
                .SetRole(GetLinkedBoById(sqlResult, GetType(DaoRole), "IdRole"))

            End With

        End Sub

        Protected Friend Overrides Sub SetBasicRequestBuilder(ByRef reqBuilder As IBasicRequestBuilder, ByRef bo As IdBObject)

            With CType(bo, SocietyRole)
                reqBuilder.AddValue("IdSociety", GetSqlIdValue(.GetSociety))
                reqBuilder.AddValue("IdRole", GetSqlIdValue(.GetRole))
            End With

        End Sub

        Public Function GetBySocietyAndRole(idSociety As Long?, idRole As Long?) As List(Of IdBObject)

            Dim rqt As String = " SELECT Id" _
                              & " FROM SocietyRole" _
                              & " WHERE IdSociety = " & idSociety _
                              & " AND IdRole = " & idRole

            Return GetByIds(rqt)

        End Function

        Public Function GetByEdition(editionId As Long?) As List(Of IdBObject)

            Dim rqt As String = " SELECT IdSocietyRole" _
                              & " FROM Edition_SocietyRole" _
                              & " WHERE Edition_SocietyRole.IdEdition = " & editionId

            Return GetByIds(rqt)

        End Function

    End Class

End Namespace