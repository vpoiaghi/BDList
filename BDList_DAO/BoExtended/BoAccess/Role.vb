Namespace BO

    Public Class Role
        Inherits BoRole

        Public Overrides Function ToString() As String
            Return GetName()
        End Function

    End Class

End Namespace