Imports BDList_TOOLS

Namespace BO

    Public MustInherit Class BoEdition_Autograph
        Inherits BObject

        Dim m_Edition As BoEdition
        Dim m_Autograph As BoAutograph

        Public Function GetEdition() As BoEdition
            Return m_Edition
        End Function

        Public Sub SetEdition(p_Edition As BoEdition)
            m_Edition = p_Edition
        End Sub

        Public Function GetAutograph() As BoAutograph
            Return m_Autograph
        End Function

        Public Sub SetAutograph(p_Autograph As BoAutograph)
            m_Autograph = p_Autograph
        End Sub

    End Class

End Namespace