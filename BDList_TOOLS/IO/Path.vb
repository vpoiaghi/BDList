Namespace IO

    Public NotInheritable Class Path

        Private Sub New()
        End Sub

        Public Shared Function Combine(path1 As String, path2 As String) As String
            Return System.IO.Path.Combine(path1, path2)
        End Function

    End Class

End Namespace
