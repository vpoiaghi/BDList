Imports BDList_TOOLS

Namespace BO

	Public MustInherit Class BoEdition_Format
        Inherits BObject

        Dim m_Edition As BoEdition
        Dim m_Format As BoFormat

        Public Function GetEdition() As BoEdition
            Return m_Edition
        End Function

        Public Sub SetEdition(p_Edition As BoEdition)
            m_Edition = p_Edition
        End Sub

        Public Function GetFormat() As BoFormat
            Return m_Format
        End Function

        Public Sub SetFormat(p_Format As BoFormat)
            m_Format = p_Format
        End Sub

    End Class

End Namespace