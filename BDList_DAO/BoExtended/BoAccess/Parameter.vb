Namespace BO

    Public Class Parameter
        Inherits BoParameter

        Public Overrides Function ToString() As String
            Return GetName() & "=" & GetValue()
        End Function

    End Class

End Namespace