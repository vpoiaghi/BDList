Imports BDList_DAO_BO.DAO

Namespace BO

    Public Class PhoneEditor
        Inherits BoPhoneEditor

        Public Overrides Function ToString() As String
            Return GetName()
        End Function

    End Class

End Namespace