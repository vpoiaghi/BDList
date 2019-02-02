Namespace BO
    Public MustInherit Class BoSeller
        Inherits IdBObject

        Dim m_person As BoPerson

        Dim m_alias As String
        Dim m_recommended As Boolean
        Dim m_comments As String

        Public Function GetPerson() As BoPerson
            Return m_person
        End Function

        Public Sub SetPerson(p_person As BoPerson)
            m_person = p_person
        End Sub

        Public Function GetAlias() As String
            Return m_alias
        End Function

        Public Sub SetAlias(p_alias As String)
            m_alias = p_alias
        End Sub

        Public Function IsRecommended() As Boolean
            Return m_recommended
        End Function

        Public Sub SetRecommended(p_recommended As Boolean)
            m_recommended = p_recommended
        End Sub

        Public Function GetComments() As String
            Return m_comments
        End Function

        Public Sub SetComments(p_comments As String)
            m_comments = p_comments
        End Sub

    End Class

End Namespace
