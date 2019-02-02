Namespace BO

    Public Class Seller
        Inherits BoSeller

        Public Overrides Function ToString() As String
            Return GetAlias()
        End Function

    End Class

End Namespace