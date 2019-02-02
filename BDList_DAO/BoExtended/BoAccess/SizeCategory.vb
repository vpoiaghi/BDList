Namespace BO

    Public Class SizeCategory
        Inherits BoSizeCategory

        Public Overrides Function ToString() As String
            Return GetName()
        End Function

    End Class

End Namespace