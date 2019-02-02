Imports BDList_DAO_BO.DAO

Namespace BO

    Public Class PhoneParameters
        Inherits BoPhoneParameters


        Public Overrides Function ToString() As String
            Return GetDataUpdateDate().ToString
        End Function

    End Class

End Namespace