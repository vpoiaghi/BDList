Namespace RequestBuilder

    Public Interface IBasicRequestBuilder

        Function GetInsertRequest() As String
        Function GetInsertRangeRequests() As List(Of String)
        Function GetUpdateRequest() As String
        Function GetUpdateRangeRequests() As List(Of String)

        Sub AddRow()
        Sub AddValue(ByVal fieldName As String, ByVal fieldValue As String)
        Sub AddCriterias(ByVal criterias As String)

    End Interface

End Namespace