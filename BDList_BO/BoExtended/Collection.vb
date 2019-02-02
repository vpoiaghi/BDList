Namespace BO

    Public Class Collection
        Inherits BoCollection

        Public Overrides Function ToString() As String
            Return GetName()
        End Function

    End Class

End Namespace