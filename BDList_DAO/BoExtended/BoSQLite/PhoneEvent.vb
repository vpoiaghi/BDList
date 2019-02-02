Imports BDList_DAO_BO.DAO

Namespace BO

    Public Class PhoneEvent
        Inherits BoPhoneEvent

        Public Overrides Function ToString() As String
            Return GetName()
        End Function

    End Class

End Namespace