Imports BDList_TOOLS

Namespace BO

    Public MustInherit Class BoInSigning_Edition
        Inherits BObject

        Dim m_Edition As BoEdition
        Dim m_InSigning As BoInSigning

        Public Function GetEdition() As BoEdition
            Return m_Edition
        End Function

        Public Sub SetEdition(p_Edition As BoEdition)
            m_Edition = p_Edition
        End Sub

        Public Function GetInSigning() As BoInSigning
            Return m_InSigning
        End Function

        Public Sub SetInSigning(p_InSigning As BoInSigning)
            m_InSigning = p_InSigning
        End Sub

    End Class

End Namespace