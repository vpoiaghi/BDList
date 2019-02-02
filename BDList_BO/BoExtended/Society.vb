Namespace BO

    Public Class Society
        Inherits BoSociety

        Public Overrides Function ToString() As String
            Return GetName()
        End Function

    End Class

End Namespace