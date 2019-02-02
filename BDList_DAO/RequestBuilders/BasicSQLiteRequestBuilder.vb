Imports BDList_DAO_BO.DAO

Namespace RequestBuilder

    Friend Class BasicSQLiteRequestBuilder
        Inherits BasicRequestBuilder

        Public Sub New(p_dao As DAO.DaoBObject)
            MyBase.New(p_dao)
        End Sub

        Public Sub New(tableName As String, fieldNames As DAO.DaoBObject.FieldList)
            MyBase.New(tableName, fieldNames)
        End Sub

        Public Overrides Function GetInsertRequest() As String

            Dim fieldsNames As String = ""
            Dim fieldsValues As String = ""
            Dim fieldValue As Object

            For Each fieldName As String In m_fields.Keys
                fieldValue = m_fields.Item(fieldName)

                fieldsNames &= "[" & fieldName & "], "
                fieldsValues &= fieldValue & ", "
            Next

            If fieldsNames.Length > 0 Then
                fieldsNames = fieldsNames.Substring(0, fieldsNames.Length - 2)
            End If

            If fieldsValues.Length > 0 Then
                fieldsValues = fieldsValues.Substring(0, fieldsValues.Length - 2)
            End If


            Return "INSERT INTO " & m_tableName & "(" & fieldsNames & ") VALUES (" & fieldsValues & ");"

        End Function

        Public Overrides Function GetInsertRangeRequests() As List(Of String)

            Dim requestsList As New List(Of String)

            Dim boListCount As Integer = m_rows.Count
            Dim blocRowsCount As Integer = 0
            Dim totalRowsCount As Integer = 0

            Dim strBuilderSQL As New System.Text.StringBuilder()

            Dim tableName As String = m_tableName
            Dim fieldNamesList As IEnumerator
            Dim fieldName As String

            For Each row As Hashtable In m_rows

                If blocRowsCount = 0 Then
                    strBuilderSQL.Append(" SELECT ")
                    fieldNamesList = m_fieldNames.GetEnumerator

                    While fieldNamesList.MoveNext
                        fieldName = fieldNamesList.Current
                        strBuilderSQL.Append(row.Item(fieldName) & " AS " & fieldName & ", ")
                    End While

                Else
                    strBuilderSQL.Append(" UNION ALL SELECT ")
                    fieldNamesList = m_fieldNames.GetEnumerator

                    While fieldNamesList.MoveNext
                        fieldName = fieldNamesList.Current
                        strBuilderSQL.Append(row.Item(fieldName) & ", ")
                    End While

                End If

                strBuilderSQL.Length = strBuilderSQL.Length - 2

                blocRowsCount += 1
                totalRowsCount += 1

                If blocRowsCount = 400 OrElse totalRowsCount = boListCount Then
                    requestsList.Add("INSERT INTO " & tableName & strBuilderSQL.ToString & ";")
                    strBuilderSQL = New System.Text.StringBuilder()
                    blocRowsCount = 0
                End If

            Next

            Return requestsList

        End Function

        Public Overrides Function GetUpdateRequest() As String
            Return GetUpdateRequest(m_fields, m_criterias)
        End Function

        Private Overloads Function GetUpdateRequest(fields As Hashtable, criterias As String) As String

            Dim fieldKeysValues As String = ""
            Dim fieldValue As Object
            Dim criteriasPart As String = ""

            For Each fieldName As String In fields.Keys
                If fieldName <> "id" Then
                    fieldValue = fields.Item(fieldName)
                    fieldKeysValues &= "[" & fieldName & "]=" & fieldValue & ", "
                End If
            Next

            If fieldKeysValues.Length > 0 Then
                fieldKeysValues = fieldKeysValues.Substring(0, fieldKeysValues.Length - 2)
            End If

            If Not String.IsNullOrEmpty(criterias) Then
                criteriasPart = " WHERE " & criterias
            End If

            Return "UPDATE " & m_tableName & " SET " & fieldKeysValues & criteriasPart & ";"

        End Function

        Public Overrides Function GetUpdateRangeRequests() As List(Of String)

            Dim requestsList As New List(Of String)

            For Each row As Hashtable In m_rows
                requestsList.Add(GetUpdateRequest(row, " id=" & row.Item("id")))
            Next

            Return requestsList

        End Function

    End Class

End Namespace