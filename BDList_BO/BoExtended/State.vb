Namespace BO

    Public Class State
        Inherits BoState

        Public Overrides Function ToString() As String
            Return GetId() & "- " & GetName()
        End Function

    End Class

End Namespace