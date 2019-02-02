Imports BDList_DAO_BO.DAO

Namespace RequestBuilder

    Friend Class BasicAccessRequestBuilder
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


            Return "INSERT INTO " & m_tableName & "(" & fieldsNames & ") VALUES (" & fieldsValues & ")"

        End Function

        Public Overrides Function GetInsertRangeRequests() As List(Of String)
            Return New List(Of String)
        End Function

        Public Overrides Function GetUpdateRequest() As String

            Dim fields As String = ""
            Dim fieldValue As Object

            For Each fieldName As String In m_fields.Keys
                If fieldName.ToLower <> "id" Then
                    fieldValue = m_fields.Item(fieldName)
                    fields &= "[" & fieldName & "]=" & fieldValue & ", "
                End If
            Next

            If fields.Length > 0 Then
                fields = fields.Substring(0, fields.Length - 2)
            End If

            Dim criteriasPart As String = ""
            If Not String.IsNullOrEmpty(m_criterias) Then
                criteriasPart = " WHERE " & m_criterias
            End If

            Return "UPDATE " & m_tableName & " SET " & fields & criteriasPart

        End Function

        Public Overrides Function GetUpdateRangeRequests() As List(Of String)
            Return New List(Of String)
        End Function

    End Class

End Namespace