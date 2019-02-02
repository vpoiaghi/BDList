Option Explicit On

Namespace BO

    Public MustInherit Class BoPhoneEditor
        Inherits IdBObject

        Private name As String

        Public Function GetName() As String
            Return name
        End Function

        Public Sub SetName(value As String)
            name = value
        End Sub

    End Class

End Namespace