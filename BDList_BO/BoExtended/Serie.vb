Option Explicit On

Namespace BO

    Public Class Serie
        Inherits BoSerie

        Public Overrides Function ToString() As String
            Return GetSortName()
        End Function

    End Class

End Namespace
