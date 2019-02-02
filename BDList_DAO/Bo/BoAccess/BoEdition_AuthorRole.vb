Imports BDList_TOOLS

Namespace BO

    Public MustInherit Class BoEdition_AuthorRole
        Inherits BObject

        Dim m_edition As BoEdition
        Dim m_personRole As BoAuthorRole

        Public Function GetEdition() As BoEdition
            Return m_edition
        End Function

        Public Sub SetEdition(p_Edition As BoEdition)
            m_edition = p_Edition
        End Sub

        Public Function GetPersonRole() As BoAuthorRole
            Return m_personRole
        End Function

        Public Sub SetPersonRole(p_personRole As BoAuthorRole)
            m_personRole = p_personRole
        End Sub

    End Class
End Namespace