Imports BDList_TOOLS

Namespace BO

	Public MustInherit Class BoEdition_Title
        Inherits BObject

        Dim m_Edition As BoEdition
        Dim m_Title As BoTitle

        Public Function GetEdition() As BoEdition
            Return m_Edition
        End Function

        Public Sub SetEdition(p_Edition As BoEdition)
            m_Edition = p_Edition
        End Sub

        Public Function GetTitle() As BoTitle
            Return m_Title
        End Function

        Public Sub SetTitle(p_Title As BoTitle)
            m_Title = p_Title
        End Sub

    End Class

End Namespace