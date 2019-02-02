Imports BDList_TOOLS

Namespace BO

    Public Class PossessionState
        Inherits BoPossessionState

        Public Function IsInPossession() As Boolean
            Return GetId() = PossessionStates.InPossession
        End Function

    End Class

End Namespace