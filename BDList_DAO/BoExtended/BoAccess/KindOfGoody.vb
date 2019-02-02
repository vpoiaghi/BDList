Namespace BO

    Public Class KindOfGoody
        Inherits BoKindOfGoody

        Public Overrides Function ToString() As String
            Return GetName()
        End Function

    End Class

End Namespace