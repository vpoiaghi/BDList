Imports BDList_TOOLS

Namespace BO

    Public MustInherit Class BoAuthor_Person
        Inherits BObject

        Dim m_author As BoAuthor
        Dim m_person As BoPerson

        Public Function GetAuthor() As BoAuthor
            Return m_author
        End Function

        Public Sub SetAuthor(p_author As BoAuthor)
            m_author = p_author
        End Sub

        Public Function GetPerson() As BoPerson
            Return m_person
        End Function

        Public Sub SetPerson(p_Person As BoPerson)
            m_Person = p_Person
        End Sub

    End Class

End Namespace