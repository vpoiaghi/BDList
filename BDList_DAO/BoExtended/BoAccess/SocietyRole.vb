Imports BDList_TOOLS

Namespace BO

    Public Class SocietyRole
        Inherits BoSocietyRole

        Public Overrides Function ToString() As String

            Return GetRole.ToString & " : " & GetSociety.ToString & " (S)"

        End Function

    End Class

End Namespace