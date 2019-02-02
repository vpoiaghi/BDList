Namespace BO

    Public Class PhoneAutograph
        Inherits BoPhoneAutograph

        Public Overrides Function ToString() As String
            Return GetDate().ToString & GetPlace()
        End Function

    End Class

End Namespace