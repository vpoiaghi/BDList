Namespace DAO

    Public Class SearchCriteria

        Public id As Integer? = Nothing
        Public keyword As String = Nothing
        Public editorId As Long? = Nothing
        Public editorName As String = Nothing
        Public kindOfGoodies As String = Nothing
        Public collection As String = Nothing
        Public authorId As Long? = Nothing
        Public authorName As String = Nothing
        Public possessionCriteria As New PossessionSearchCriteria

        Public Class PossessionSearchCriteria
            Public inPossession As Boolean = True
            Public wanted As Boolean = True
            Public missing As Boolean = True
            Public inDelivery As Boolean = True
            Public reserved As Boolean = True
            Public toReserveAtBDfugue As Boolean = True
            Public toReserveAtCultura As Boolean = True
            Public present As Boolean = True
        End Class

    End Class

End Namespace