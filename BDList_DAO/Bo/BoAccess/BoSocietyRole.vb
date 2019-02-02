Imports BDList_TOOLS

Namespace BO

    Public MustInherit Class BoSocietyRole
        Inherits IdBObject

        Dim m_society As BoSociety
        Dim m_role As BoRole

        Public Function GetSociety() As BoSociety
            Return m_society
        End Function
        Public Sub SetSociety(p_society As BoSociety)
            m_society = p_society
        End Sub

        Public Function GetRole() As BoRole
            Return m_role
        End Function
        Public Sub SetRole(p_role As BoRole)
            m_role = p_role
        End Sub

    End Class
End Namespace