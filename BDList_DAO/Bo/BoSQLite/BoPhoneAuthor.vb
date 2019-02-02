Option Explicit On

Namespace BO

    Public MustInherit Class BoPhoneAuthor
        Inherits IdBObject

        Private name As String
        Private searchName As String

        Public Function GetName() As String
            Return name
        End Function
        Public Sub SetName(value As String)
            name = value
        End Sub

        Public Function GetSearchName() As String
            Return searchName
        End Function
        Public Sub SetSearchName(value As String)
            searchName = value
        End Sub

    End Class

End Namespace