Public Interface IPurchaseReader

    Sub ReadSource(source As String)

    Function GetBaseUrl() As String
    Function GetSiteName() As String


    Function GetImages() As List(Of Image)
    Function GetTitle() As String
    Function GetEndOfValidity() As DateTime?
    Function GetCurrentCost() As Single?
    Function GetComments() As String

End Interface
