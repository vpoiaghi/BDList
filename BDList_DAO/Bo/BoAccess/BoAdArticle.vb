Imports BDList_TOOLS

Namespace BO

    Public MustInherit Class BoAdArticle
        Inherits IdBObject

        Dim m_edition As BoEdition
        Dim m_goody As BoGoody

        Dim m_withNumber As Integer
        Dim m_withAutograph As Integer

        Public Function GetEdition() As BoEdition
            Return m_edition
        End Function
        Public Sub SetEdition(p_edition As BoEdition)
            m_edition = p_edition
        End Sub

        Public Function GetGoody() As BoGoody
            Return m_goody
        End Function
        Public Sub SetGoody(p_goody As BoGoody)
            m_goody = p_goody
        End Sub

        Public Overridable Function IsWithNumber() As Integer
            Return m_withNumber
        End Function
        Public Sub SetWithNumber(p_withNumber As Integer)
            m_withNumber = p_withNumber
        End Sub

        Public Overridable Function IsWithAutograph() As Integer
            Return m_withAutograph
        End Function
        Public Sub SetWithAutograph(p_withAutograph As Integer)
            m_withAutograph = p_withAutograph
        End Sub

    End Class
End Namespace