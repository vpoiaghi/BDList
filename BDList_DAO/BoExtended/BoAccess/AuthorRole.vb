Imports BDList_TOOLS

Namespace BO

    Public Class AuthorRole
        Inherits BoAuthorRole

        Public Overrides Function ToString() As String

            Return GetRole.ToString & " : " & GetAuthor.ToString & " (P)"

        End Function

    End Class

End Namespace