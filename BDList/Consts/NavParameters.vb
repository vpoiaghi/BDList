Public NotInheritable Class NavParameters

    Private Shared PRM_VALUE As Integer = 0

    Private Shared Function GetNextValue() As Integer
        PRM_VALUE = PRM_VALUE + 1
        Return PRM_VALUE
    End Function


    Public Shared ReadOnly PRM_SERIE_ID As Integer = GetNextValue()
    Public Shared ReadOnly PRM_EDITION_ID As Integer = GetNextValue()
    Public Shared ReadOnly PRM_GOODY_ID As Integer = GetNextValue()
    Public Shared ReadOnly PRM_AUTHOR_ID As Integer = GetNextValue()
    Public Shared ReadOnly PRM_PURCHASE_ID As Integer = GetNextValue()
    Public Shared ReadOnly PRM_AD_ID As Integer = GetNextValue()

    Public Shared ReadOnly PRM_SEARCH_CRITERIA As Integer = GetNextValue()

End Class
