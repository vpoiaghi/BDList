Imports BDList_TOOLS

Namespace BO

    Public MustInherit Class BoEdition_SocietyRole
        Inherits BObject

        Dim m_edition As BoEdition
        Dim m_societyRole As BoSocietyRole

        Public Function GetEdition() As BoEdition
            Return m_edition
        End Function

        Public Sub SetEdition(p_Edition As BoEdition)
            m_edition = p_Edition
        End Sub

        Public Function GetSocietyRole() As BoSocietyRole
            Return m_societyRole
        End Function

        Public Sub SetSocietyRole(p_societyRole As BoSocietyRole)
            m_societyRole = p_societyRole
        End Sub

    End Class

End Namespace