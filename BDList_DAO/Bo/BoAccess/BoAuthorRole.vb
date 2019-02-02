Imports BDList_TOOLS

Namespace BO

    Public MustInherit Class BoAuthorRole
        Inherits IdBObject

        Dim m_author As BoAuthor
        Dim m_role As BoRole

        Public Function GetAuthor() As BoAuthor
            Return m_author
        End Function

        Public Sub SetAuthor(p_author As BoAuthor)
            m_author = p_author
        End Sub

        Public Function GetRole() As BoRole
            Return m_role
        End Function

        Public Sub SetRole(p_Role As BoRole)
            m_role = p_Role
        End Sub

    End Class

End Namespace