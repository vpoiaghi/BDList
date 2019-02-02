Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.RequestBuilder
Imports BDList_DATABASE
Imports BDList_TOOLS

Namespace DAO

    Public Class DaoPerson
        Inherits DaoAccess

        Protected Friend Overrides Function GetBoType() As Type
            Return GetType(Person)
        End Function

        Protected Friend Overrides Function GetTableName() As String
            Return "Person"
        End Function

        Protected Friend Overrides Sub InitFieldsList(fieldsNames As FieldList)
            fieldsNames.AddFields("Firstname", "Lastname", "WebSite", "BirthDay", "BirthPlace", "BirthCountry", "DeathDay", "Biography")
        End Sub

        Protected Friend Overrides Sub SetBasicRequestBuilder(ByRef reqBuilder As IBasicRequestBuilder, ByRef person As IdBObject)

            With CType(person, Person)
                reqBuilder.AddValue("Firstname", GetSqlStringValue(.GetFirstname))
                reqBuilder.AddValue("Lastname", GetSqlStringValue(.GetLastname))
                reqBuilder.AddValue("WebSite", GetSqlStringValue(.GetWebSite))
                reqBuilder.AddValue("BirthDay", GetSqlDateValue(.GetBirthDay))
                reqBuilder.AddValue("BirthPlace", GetSqlStringValue(.GetBirthPlace))
                reqBuilder.AddValue("BirthCountry", GetSqlStringValue(.GetBirthCountry))
                reqBuilder.AddValue("DeathDay", GetSqlDateValue(.GetDeathDay))
                reqBuilder.AddValue("Biography", GetSqlStringValue(.GetBiography))
            End With

        End Sub

        Protected Friend Overrides Sub BuildBo(sqlResult As ISqlResult, bo As IdBObject)

            With CType(bo, Person)

                .SetFirstname(sqlResult.GetString("Firstname"))
                .SetLastname(sqlResult.GetString("Lastname"))
                .SetWebSite(sqlResult.GetString("WebSite"))
                .SetBirthDay(sqlResult.GetDate("BirthDay"))
                .SetBirthPlace(sqlResult.GetString("BirthPlace"))
                .SetBirthCountry(sqlResult.GetString("BirthCountry"))
                .SetDeathDay(sqlResult.GetDate("DeathDay"))
                .SetBiography(sqlResult.GetString("Biography"))

            End With

        End Sub


        Public Overrides Function GetAll() As List(Of IdBObject)

            Dim rqt As String = " SELECT Id" _
                              & " FROM " & GetTableName() _
                              & " ORDER BY LastName ASC, FirstName ASC"

            Return GetByIds(rqt)

        End Function

        Public Function GetByNames(ByVal lastname As String, ByVal firstname As String) As List(Of IdBObject)

            Dim result As List(Of IdBObject)

            Dim wherePart As String = ""
            Dim oneCriteriaOrMore As Boolean = False

            If Not String.IsNullOrEmpty(firstname) Then
                wherePart &= " FirstName LIKE """ & firstname & """"
                oneCriteriaOrMore = True
            End If

            If Not String.IsNullOrEmpty(lastname) Then

                If Not String.IsNullOrEmpty(wherePart) Then
                    wherePart &= " AND"
                End If

                wherePart &= " LastName LIKE """ & lastname & """"
                oneCriteriaOrMore = True
            End If

            If oneCriteriaOrMore Then

                If Not String.IsNullOrEmpty(wherePart) Then
                    wherePart = " WHERE" & wherePart
                End If

                Dim rqt As String = " SELECT Id" _
                                  & " FROM Person" _
                                  & wherePart _
                                  & " ORDER BY LastName ASC, FirstName ASC"


                result = GetByIds(rqt)
            Else
                result = New List(Of IdBObject)
            End If

            Return result

        End Function

        Public Function GetByAuthor(ByVal idAuthor As Long?) As List(Of IdBObject)

            Dim authorTableName As String = DaoManager.GetDao(Of DaoAuthor).GetTableName
            Dim personTableName As String = DaoManager.GetDao(Of DaoPerson).GetTableName
            Dim linkTableName As String = authorTableName & "_" & personTableName

            Dim rqt As String = " SELECT IdPerson" _
                              & " FROM " & linkTableName _
                              & " WHERE IdAuthor = " & idAuthor

            Return GetByIds(rqt)

        End Function
    End Class
End Namespace