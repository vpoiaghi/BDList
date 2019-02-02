Imports BDList_DAO_BO.DAO

Namespace BO

    Public Class PhoneSerie
        Inherits BoPhoneSerie

        Public Overrides Function ToString() As String
            Return GetName()
        End Function

    End Class

End Namespace