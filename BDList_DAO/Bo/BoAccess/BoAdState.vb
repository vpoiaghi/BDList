Option Explicit On

Namespace BO

    Public MustInherit Class BoAdState
        Inherits NamedBObject

        Dim m_isWin As Boolean
        Dim m_isLost As Boolean

        Public Function IsWin() As Boolean
            Return m_isWin
        End Function
        Public Sub SetWin(p_isWin As Boolean)
            m_isWin = p_isWin
        End Sub

        Public Function IsLost() As Boolean
            Return m_isLost
        End Function
        Public Sub SetLost(p_isLost As Boolean)
            m_isLost = p_isLost
        End Sub

    End Class

End Namespace