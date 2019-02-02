Imports BDList_TOOLS

Namespace BO

    Public MustInherit Class BObject
        Implements IBObject

        Public MustOverride Overrides Function ToString() As String

        Private m_inBase As Boolean = True

        Public Function IsInBase() As Boolean Implements IBObject.IsInBase
            Return m_inBase
        End Function

        Public Sub SetInBase(inBase As Boolean) Implements IBObject.SetInBase
            m_inBase = inBase
        End Sub

    End Class

End Namespace