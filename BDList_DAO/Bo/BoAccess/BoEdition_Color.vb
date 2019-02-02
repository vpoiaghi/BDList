Imports BDList_TOOLS

Namespace BO

	Public MustInherit Class BoEdition_Color
        Inherits BObject

        Dim m_Edition As BoEdition
        Dim m_Color As BoColor

        Public Function GetEdition() As BoEdition
            Return m_Edition
        End Function

        Public Sub SetEdition(p_Edition As BoEdition)
            m_Edition = p_Edition
        End Sub

        Public Function GetColor() As BoColor
            Return m_Color
        End Function

        Public Sub SetColor(p_Color As BoColor)
            m_Color = p_Color
        End Sub

    End Class

End Namespace